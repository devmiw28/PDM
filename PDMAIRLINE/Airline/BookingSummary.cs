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
    public partial class BookingSummary : Form
    {
       /* int flag = -1;*/
        public string TripType { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string DepartDate { get; set; }
        public string ReturnDate { get; set; }
        public string Adults { get; set; }
        public string Children { get; set; }
        public string Infants { get; set; }
        public string PromoCode { get; set; }

        SearchFlight searchFlight = new SearchFlight();
        public BookingSummary()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Payment payment = Application.OpenForms.OfType<Payment>().FirstOrDefault();

            if (payment == null || payment.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                payment = new Payment();
                payment.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                payment.Show();
            }
            else
            {
                // If already open, bring it to the front
                payment.BringToFront();
                payment.Focus();
            }

        }
        private void BookingSummary_Load(object sender, EventArgs e)
        {
            if (TripType == "Round-trip")
            {
                lblTripSummary.Text = "Round-trip";
            }
            else if(TripType == "One-way")
            {
                lblTripSummary.Text = "One-way trip";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblLocation.Text = Departure +"-"+ Destination;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*flag *= -1;
            if (flag == 1)
            {
                pnlFlight.Show();
            }else
            {
                pnlFlight.Hide();
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

           
        }

        private void lblFlightDate_Click(object sender, EventArgs e)
        {
            lblFlightDate.Text = ReturnDate;
            
        }

        private void lblDepartDate_Click(object sender, EventArgs e)
        {
            lblFlightDate.Text = DepartDate;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblAdults_Click(object sender, EventArgs e)
        {
          lblAdults.Text = Adults;
        }

        private void lblChild_Click(object sender, EventArgs e)
        {
            lblChild.Text = Children;
        }

        private void lblInfant_Click(object sender, EventArgs e)
        {
            lblInfant.Text = Infants;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lblPromo.Text = PromoCode;
            lblPromo.Text = string.IsNullOrWhiteSpace(PromoCode) ? "None" : PromoCode;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
