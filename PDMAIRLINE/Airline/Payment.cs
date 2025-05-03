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
        private readonly string connStr = "server=localhost;user=root;password=yourpassword;database=pdm_airline_db1;";
        private int currentBookingId;

        public Payment()
        {
            InitializeComponent();
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

            // Get payment amount from txtTotalPrice
            decimal paymentAmount = decimal.Parse(txtTotalPrice.Text);

            // Generate transaction reference
            string transactionRef = "TXN" + DateTime.Now.ToString("yyyyMMddHHmmss");

            
            

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO payments 
                (booking_id, payment_method, payment_amount, transaction_reference) 
                VALUES (@booking_id, @method, @amount, @ref)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@booking_id", currentBookingId);
                        cmd.Parameters.AddWithValue("@method", paymentMethod);
                        cmd.Parameters.AddWithValue("@amount", paymentAmount);
                        cmd.Parameters.AddWithValue("@ref", transactionRef);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Payment recorded successfully!\nTransaction Reference: " + transactionRef,
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Failed to record payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
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
    }
}
