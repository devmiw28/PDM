using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class SeatSelection : Form
    {
        

        

        public SeatSelection()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            BookingSummary bookingsummary = Application.OpenForms.OfType<BookingSummary>().FirstOrDefault();

            if (bookingsummary == null || bookingsummary.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                bookingsummary = new BookingSummary();
                bookingsummary.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                bookingsummary.Show();
            }
            else
            {
                // If already open, bring it to the front
                bookingsummary.BringToFront();
                bookingsummary.Focus();
            }



            /*           // Check if the user is logged in
                       if (!isLoggedIn)
                       {
                           // Open the login form if not logged in
                           LogIn loginForm = new LogIn();
                           DialogResult result = loginForm.ShowDialog();

                           if (result == DialogResult.OK) // Check if login is successful
                           {
                               isLoggedIn = true;  // Set login status to true
                               MessageBox.Show("Login successful! You can now proceed with booking.");
                               // Now, you can proceed to the next step (e.g., continue the booking process)
                           }
                           else
                           {
                               MessageBox.Show("Login failed. Please try again.");
                           }
                       }
                       else
                       {
                           // If logged in, proceed with the booking process
                           MessageBox.Show("Proceeding with booking...");
                           // Here, you would add the functionality to proceed with booking
                       } 
              */
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
