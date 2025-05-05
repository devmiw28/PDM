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


        public Payment()
        {
            InitializeComponent();
            this.Load += Payment_Load;
            chkGcash.Checked = true;
            pnlCredit.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            UserId = SessionManager.UserId;

            string paymentMethod = "";

            if (rdbCredit.Checked)
            {
                paymentMethod = "credit_card";
            }
            else if (rdbEWallet.Checked)
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
                    (payment_method, payment_amount, transaction_reference, payment_status) 
                    VALUES (@method, @amount, @ref, 'completed')";

                    using (MySqlCommand cmd = new MySqlCommand(paymentQuery, conn, transaction))
                    {
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

                    // Commit transaction if everything succeeded
                    transaction.Commit();
                    MessageBox.Show("Payment and seat selection recorded successfully!\nTransaction Reference: " + transactionRef,
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rdbEWallet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEWallet.Checked)
            {
                pnlEWallet.Enabled = true;
                pnlCredit.Enabled = false;
                txtCardNum.Text = "";
                txtCCVNum.Text = "";
            }
            
            chkGcash.Checked = true;

        }

        private void rdbCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredit.Checked)
            {
                pnlEWallet.Enabled = false;
                pnlCredit.Enabled = true;
                chkGcash.Checked = false;
                chkPayMaya.Checked = false;
            }
            
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
