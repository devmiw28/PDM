using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            this.Load += Payment_Load;
            chkGcash.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            UserId = SessionManager.UserId;

            string paymentMethod = "";

            if (rdbEWallet.Checked)
            {
                if (chkGcash.Checked)
                    paymentMethod = "gcash";
                else if (chkPayMaya.Checked)
                    paymentMethod = "paymaya";
                else
                {
                    MessageBox.Show("Please select an e-wallet option (Gcash or PayMaya).", "Missing Option", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No payment method selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal paymentAmount;
            if (!decimal.TryParse(txtTotalPrice.Text, System.Globalization.NumberStyles.Currency, null, out paymentAmount))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string transactionRef = "TXN" + DateTime.Now.ToString("yyyyMMddHHmmss");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Record the payment
                    string paymentQuery = @"INSERT INTO payments 
                    (user_id, payment_method, payment_amount, transaction_reference, payment_status) 
                    VALUES (@userId, @method, @amount, @ref, 'completed')";
                    
                    using (MySqlCommand cmd = new MySqlCommand(paymentQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        cmd.Parameters.AddWithValue("@method", paymentMethod);
                        cmd.Parameters.AddWithValue("@amount", paymentAmount);
                        cmd.Parameters.AddWithValue("@ref", transactionRef);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert Departure Seats
                    foreach (string seatCode in DepartureSeats)
                    {
                        string seatQuery = "INSERT INTO Seat_Selected (user_id, flight_number, datetime, seat_code, trip_leg) " +
                   "VALUES (@userId, @flight, @datetime, @seat, @tripLeg)";

                        using (MySqlCommand cmd = new MySqlCommand(seatQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@userId", UserId);
                            cmd.Parameters.AddWithValue("@flight", FlightNumberDeparture);
                            cmd.Parameters.AddWithValue("@datetime", DepartureDateTime);
                            cmd.Parameters.AddWithValue("@seat", seatCode);
                            cmd.Parameters.AddWithValue("@tripLeg", "Departure");
                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (TripType == "Round-trip")
                    {
                        foreach (string seatCode in ReturnSeats)
                        {
                            string seatQuery = "INSERT INTO Seat_Selected (user_id, flight_number, datetime, seat_code, trip_leg) " +
                   "VALUES (@userId, @flight, @datetime, @seat, @tripLeg)";

                            using (MySqlCommand cmd = new MySqlCommand(seatQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@userId", UserId);
                                cmd.Parameters.AddWithValue("@flight", FlightNumberReturn);
                                cmd.Parameters.AddWithValue("@datetime", ReturnDateTime);
                                cmd.Parameters.AddWithValue("@seat", seatCode);
                                cmd.Parameters.AddWithValue("@tripLeg", "Return");
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 3. Insert into bookings
                    string bookingReference = "BOOK" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999);
                    string bookingQuery = @"INSERT INTO bookings (user_id, depart_flight_id, return_flight_id, booking_reference, 
                                            trip_type, origin, destination, total_price, status) 
                                            VALUES (@user_id, @depart_flight_id, @return_flight_id, @booking_reference, 
                                            @trip_type, @origin, @destination, @total_price, @status)";

                    // Get the correct flight_id values from the depart_flights and return_flights tables
                    long departFlightId = GetDepartFlightId(FlightNumberDeparture);  // Get depart_flight_id from depart_flights table
                    long? returnFlightId = TripType == "Round-trip" ? (long?)GetReturnFlightId(FlightNumberReturn) : null;  // Nullable long for returnFlightId

                    using (MySqlCommand cmd = new MySqlCommand(bookingQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@user_id", UserId);
                        cmd.Parameters.AddWithValue("@depart_flight_id", departFlightId);  // Use depart_flight_id
                        cmd.Parameters.AddWithValue("@return_flight_id", returnFlightId.HasValue ? (object)returnFlightId.Value : DBNull.Value);  // Nullable return_flight_id
                        cmd.Parameters.AddWithValue("@booking_reference", bookingReference);
                        cmd.Parameters.AddWithValue("@trip_type", TripType);
                        cmd.Parameters.AddWithValue("@origin",Origin);
                        cmd.Parameters.AddWithValue("@destination",Destination);
                        cmd.Parameters.AddWithValue("@total_price", TotalPrice);
                        cmd.Parameters.AddWithValue("@status", "confirmed");
                        cmd.ExecuteNonQuery();
                    }



                    // Commit transaction if everything succeeded
                    transaction.Commit();
                    MessageBox.Show("Payment and seat selection recorded successfully!\nTransaction Reference: " + transactionRef,
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Homepage homeForm = new Homepage();
                    homeForm.Show();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private long GetDepartFlightId(string flightNumber)
        {
            long departFlightId = -1;

            string query = "SELECT depart_flight_id FROM depart_flights WHERE depart_flight_number = @flightNumber";  // Use 'depart_flight_number'

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        departFlightId = Convert.ToInt64(result);
                    }
                }
            }

            return departFlightId;
        }

        private long GetReturnFlightId(string flightNumber)
        {
            long returnFlightId = -1;

            string query = "SELECT return_flight_id FROM return_flights WHERE return_flight_number = @flightNumber";  // Use 'return_flight_number'

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        returnFlightId = Convert.ToInt64(result);
                    }
                }
            }

            return returnFlightId;
        }

        private void rdbEWallet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEWallet.Checked)
            {
                pnlEWallet.Enabled = true;
                
            }
            
            chkGcash.Checked = true;
        }

        private void chkGcash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGcash.Checked)
            {
                chkPayMaya.Checked = false;
            }
            
        }

        private void chkPayMaya_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayMaya.Checked)
            {
                chkGcash.Checked = false;
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtTotalPrice.Text = TotalPrice.ToString("F2"); 
        }
    }
}
