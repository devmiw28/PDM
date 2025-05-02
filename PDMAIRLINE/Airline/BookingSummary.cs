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
        public string TripType { get; set; }
        public string Destination { get; set; }
        public string DepartDate { get; set; }
        public string ReturnDate { get; set; }
        public string NumAdults { get; set; }
        public string NumChildren { get; set; }
        public string NumInfants { get; set; }
        public string PromoCode { get; set; }
        public string PickedSeats { get; set; }
        public string FlightClass { get; set; }
        public string FlightNumber { get; set; }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookingSummary_Load_1(object sender, EventArgs e)
        {
            txtNumAdults.Text = NumAdults;
            txtNumChildren.Text = NumChildren;
            txtNumInfants.Text = NumInfants;
            txtPickedSeats.Text = PickedSeats; 
            txtFlightLoc.Text = Destination;  
            txtTripType.Text = TripType;
            txtFlightClass.Text = FlightClass;
            txtDepartDateAndTime.Text = DepartDate;
            txtReturnDateAndTime.Text = ReturnDate;
            txtFlightNum.Text = FlightNumber;
        }
    }
}
