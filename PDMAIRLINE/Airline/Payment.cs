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
            // Determine selected payment method
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

            // Convert total price to decimal
            decimal paymentAmount;
            if (!decimal.TryParse(txtTotalPrice.Text, System.Globalization.NumberStyles.Currency, null, out paymentAmount))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate transaction reference
            string transactionRef = "TXN" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Open database connection
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Modified query to include 'payment_status' as 'completed'
                    string query = @"INSERT INTO payments 
                             (payment_method, payment_amount, transaction_reference, payment_status) 
                             VALUES (@method, @amount, @ref, 'completed')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to command
                        cmd.Parameters.AddWithValue("@method", paymentMethod);
                        cmd.Parameters.AddWithValue("@amount", paymentAmount);
                        cmd.Parameters.AddWithValue("@ref", transactionRef);

                        // Execute the query
                        int result = cmd.ExecuteNonQuery();

                        // Check if the query was successful
                        if (result > 0)
                            MessageBox.Show("Payment recorded successfully!\nTransaction Reference: " + transactionRef,
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Failed to record payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
