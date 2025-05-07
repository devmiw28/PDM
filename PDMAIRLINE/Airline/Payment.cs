using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace Airline
{
    public partial class Payment : Form
    {
        private readonly string connectionString = "server=localhost;database=pdm_airline_db1;user=root;password=;";

        public decimal TotalPrice { get; set; }
        public List<string> DepartureSeats { get; set; }
        public List<string> ReturnSeats { get; set; }
        public string FlightNumberDeparture { get; set; }
        public string FlightNumberReturn { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public string TripType { get; set; }
        public string FlightClass { get; set; }
        public int UserId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public Payment()
        {
            InitializeComponent();
            Load += Payment_Load;
            chkGcash.Checked = true;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtTotalPrice.Text = TotalPrice.ToString("F2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbEWallet_CheckedChanged(object sender, EventArgs e)
        {
            pnlEWallet.Enabled = rdbEWallet.Checked;
            chkGcash.Checked = true;
        }

        private void chkGcash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGcash.Checked)
                chkPayMaya.Checked = false;
        }

        private void chkPayMaya_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayMaya.Checked)
                chkGcash.Checked = false;
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            UserId = SessionManager.UserId;

            string paymentMethod = GetSelectedPaymentMethod();
            if (string.IsNullOrEmpty(paymentMethod)) return;

            decimal paymentAmount;
            if (!decimal.TryParse(txtTotalPrice.Text, System.Globalization.NumberStyles.Currency, null, out paymentAmount))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string transactionRef = "TXN" + DateTime.Now.ToString("yyyyMMddHHmmss");

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                try
                {
                    InsertPaymentRecord(conn, transaction, paymentMethod, paymentAmount, transactionRef);
                    InsertSeatSelections(conn, transaction);

                    string bookingRef = "BOOK" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999);
                    InsertBookingRecord(conn, transaction, bookingRef);

                    transaction.Commit();

                    MessageBox.Show($"Payment and seat selection recorded successfully!\nTransaction Reference: {transactionRef}",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        string userEmail = txtEmail.Text.Trim();
                        if (!Regex.IsMatch(userEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        {
                            MessageBox.Show("Invalid email address.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        try
                        {
                            await SendEmailConfirmationAsync(
    userEmail,
    bookingRef,
    transactionRef,
    TotalPrice,
    TripType,
    FlightNumberDeparture,
    FlightNumberReturn,
    Origin,
    Destination
);
                        }
                        catch (Exception emailEx)
                        {
                            MessageBox.Show("Payment saved but failed to send confirmation email: " + emailEx.Message,
                                            "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    Hide();
                    new Homepage().Show();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetSelectedPaymentMethod()
        {
            if (!rdbEWallet.Checked)
            {
                MessageBox.Show("No payment method selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (chkGcash.Checked) return "gcash";
            if (chkPayMaya.Checked) return "paymaya";

            MessageBox.Show("Please select an e-wallet option (Gcash or PayMaya).", "Missing Option", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private void InsertPaymentRecord(MySqlConnection conn, MySqlTransaction transaction, string method, decimal amount, string reference)
        {
            string query = @"INSERT INTO payments (user_id, payment_method, payment_amount, transaction_reference, payment_status) 
                             VALUES (@userId, @method, @amount, @ref, 'completed')";
            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@userId", UserId);
                cmd.Parameters.AddWithValue("@method", method);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@ref", reference);
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertSeatSelections(MySqlConnection conn, MySqlTransaction transaction)
        {
            string query = @"INSERT INTO Seat_Selected (user_id, flight_number, datetime, seat_code, trip_leg) 
                             VALUES (@userId, @flight, @datetime, @seat, @tripLeg)";

            foreach (var seat in DepartureSeats)
            {
                using (var cmd = new MySqlCommand(query, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    cmd.Parameters.AddWithValue("@flight", FlightNumberDeparture);
                    cmd.Parameters.AddWithValue("@datetime", DepartureDateTime);
                    cmd.Parameters.AddWithValue("@seat", seat);
                    cmd.Parameters.AddWithValue("@tripLeg", "Departure");
                    cmd.ExecuteNonQuery();
                }
            }

            if (TripType == "Round-trip")
            {
                foreach (var seat in ReturnSeats)
                {
                    using (var cmd = new MySqlCommand(query, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        cmd.Parameters.AddWithValue("@flight", FlightNumberReturn);
                        cmd.Parameters.AddWithValue("@datetime", ReturnDateTime);
                        cmd.Parameters.AddWithValue("@seat", seat);
                        cmd.Parameters.AddWithValue("@tripLeg", "Return");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void InsertBookingRecord(MySqlConnection conn, MySqlTransaction transaction, string bookingReference)
        {
            string query = @"INSERT INTO bookings (user_id, depart_flight_id, return_flight_id, booking_reference,
                             trip_type, origin, destination, total_price, status)
                             VALUES (@user_id, @depart_flight_id, @return_flight_id, @booking_reference,
                             @trip_type, @origin, @destination, @total_price, @status)";

            long departFlightId = GetDepartFlightId(FlightNumberDeparture);
            object returnFlightId = TripType == "Round-trip" ? (object)GetReturnFlightId(FlightNumberReturn) : DBNull.Value;

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@user_id", UserId);
                cmd.Parameters.AddWithValue("@depart_flight_id", departFlightId);
                cmd.Parameters.AddWithValue("@return_flight_id", returnFlightId);
                cmd.Parameters.AddWithValue("@booking_reference", bookingReference);
                cmd.Parameters.AddWithValue("@trip_type", TripType);
                cmd.Parameters.AddWithValue("@origin", Origin);
                cmd.Parameters.AddWithValue("@destination", Destination);
                cmd.Parameters.AddWithValue("@total_price", TotalPrice);
                cmd.Parameters.AddWithValue("@status", "confirmed");
                cmd.ExecuteNonQuery();
            }
        }

        private long GetDepartFlightId(string flightNumber)
        {
            string query = "SELECT depart_flight_id FROM depart_flights WHERE depart_flight_number = @flightNumber";
            return GetFlightId(query, flightNumber);
        }

        private long GetReturnFlightId(string flightNumber)
        {
            string query = "SELECT return_flight_id FROM return_flights WHERE return_flight_number = @flightNumber";
            return GetFlightId(query, flightNumber);
        }

        private long GetFlightId(string query, string flightNumber)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt64(result) : -1;
                }
            }
        }

        private async Task SendEmailConfirmationAsync(
     string toEmail,
     string bookingRef,
     string transactionRef,
     decimal amount,
     string tripType,
     string flightNumberDeparture,
     string flightNumberReturn,
     string origin,
     string destination)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            string apiKey = "32acbac60d91302b5971cb7f1a033260";
            string secretKey = "83090e888b57e61f07e525837adf4fb1";

            using (var client = new HttpClient())
            {
                var credentials = Encoding.ASCII.GetBytes($"{apiKey}:{secretKey}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

                var email = new
                {
                    Messages = new[] {
                new {
                    From = new { Email = "leonardomarkace.pdm@gmail.com", Name = "PDM Airline" },
                    To = new[] { new { Email = toEmail, Name = "Passenger" } },
                    Subject = "Your Flight Booking Confirmation",
                    TextPart = $"Thank you for your booking!\n\nBooking Reference: {bookingRef}\nTransaction Reference: {transactionRef}\nAmount Paid: PHP {amount:F2}\n\nSafe travels!",
                    HTMLPart = $@"
                    <div style='font-family: Arial, sans-serif; border: 1px solid #ccc; padding: 20px; max-width: 700px; margin: auto;'>
                        <div style='background-color: #FFE600; padding: 10px;'>
                            <h1 style='display: inline-block; margin-left: 10px;'>E-Ticket</h1>
                        </div>

                        <h3 style='color: #444;'>Booking Details</h3>
                        <table style='width:100%; border-collapse: collapse; margin-bottom: 15px;'>
                            <tr><td><strong>Status:</strong> CONFIRMED</td><td><strong>Booking Date:</strong> {DateTime.Now:ddd, dd MMM. yyyy}</td><td><strong>Booking Reference:</strong> {bookingRef}</td></tr>
                        </table>

                        <h3 style='color: #444;'>Departure Flight Details</h3>
                        <table style='width:100%; border: 1px solid #ddd; border-collapse: collapse;'>
                            <tr style='background-color: #f5f5f5;'>
                                <th style='padding: 8px; border: 1px solid #ddd;'>Departure Flight No.</th>
                                <th style='padding: 8px; border: 1px solid #ddd;'>Departure</th>
                                <th style='padding: 8px; border: 1px solid #ddd;'>Arrival</th>
                            </tr>
                            <tr>
                                <td style='padding: 8px; border: 1px solid #ddd;'>{flightNumberDeparture}</td>
                                <td style='padding: 8px; border: 1px solid #ddd;'>{origin}<br>Terminal 3<br>{DateTime.Now.AddDays(1):ddd, dd MMM. yyyy, hh:mm tt}</td>
                                <td style='padding: 8px; border: 1px solid #ddd;'>{destination}<br>{DateTime.Now.AddDays(1).AddHours(2):ddd, dd MMM. yyyy, hh:mm tt}</td>
                            </tr>
                        </table>

                        {(tripType.ToLower() == "round-trip" ? $@"
                        <h3 style='color: #444;'>Return Flight Details</h3>
                        <table style='width:100%; border: 1px solid #ddd; border-collapse: collapse;'>
                            <tr style='background-color: #f5f5f5;'>
                                <th style='padding: 8px; border: 1px solid #ddd;'>Return Flight No.</th>
                                <th style='padding: 8px; border: 1px solid #ddd;'>Departure</th>
                                <th style='padding: 8px; border: 1px solid #ddd;'>Arrival</th>
                            </tr>
                            <tr>
                                <td style='padding: 8px; border: 1px solid #ddd;'>{flightNumberReturn}</td>
                                <td style='padding: 8px; border: 1px solid #ddd;'>{destination}<br>Terminal 3<br>{DateTime.Now.AddDays(2):ddd, dd MMM. yyyy, hh:mm tt}</td>
                                <td style='padding: 8px; border: 1px solid #ddd;'>{origin}<br>{DateTime.Now.AddDays(2).AddHours(2):ddd, dd MMM. yyyy, hh:mm tt}</td>
                            </tr>
                        </table>" : "")}

                        <h3 style='color: #444;'>Payment</h3>
                        <p><strong>Transaction Reference:</strong> {transactionRef}</p>
                        <p><strong>Amount Paid:</strong> PHP {amount:F2}</p>

                        <h3 style='color: #444;'>Guest Details</h3>
                        <p>Passenger Email: <strong>{toEmail}</strong></p>
                        <p><strong>Route:</strong> {origin} - {destination}</p>

                        <hr>
                        <p style='font-size: 12px; color: #555;'>This is a system-generated confirmation. Please do not reply to this email.</p>
                    </div>"
                }
            }
                };

                string json = JsonConvert.SerializeObject(email);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://api.mailjet.com/v3.1/send", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Failed to send email. Status: " + response.StatusCode + "\n" + responseBody);

                MessageBox.Show("E-ticket has been sent to your email.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}