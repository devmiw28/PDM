using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SendGrid;
using SendGrid.Helpers.Mail;
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
                            await SendEmailConfirmationAsync(userEmail, bookingRef, transactionRef, TotalPrice);
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

        private async Task SendEmailConfirmationAsync(string toEmail, string bookingRef, string transactionRef, decimal amount)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            var apiKey = "";
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress("enrollment.test101@gmail.com", "PDM Airline");
            var to = new EmailAddress(toEmail);
            var subject = "Your Flight Booking Confirmation";
            var plainTextContent = $"Thank you for your booking!\n\nBooking Reference: {bookingRef}\nTransaction Reference: {transactionRef}\nAmount Paid: PHP {amount:F2}\n\nSafe travels!";
            var htmlContent = $"<p>Thank you for your booking!</p><ul><li><strong>Booking Reference:</strong> {bookingRef}</li><li><strong>Transaction Reference:</strong> {transactionRef}</li><li><strong>Amount Paid:</strong> PHP {amount:F2}</li></ul><p>Safe travels!</p>";

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Failed to send email. Status Code: " + response.StatusCode);


            MessageBox.Show("E-ticket has been sent to your email.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
