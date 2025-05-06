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
        public List<string> SelectedDepartureSeats { get; set; }
        public List<string> SelectedReturnSeats { get; set; }

        public string TripType { get; set; }
        public string Destination { get; set; }
        public string Origin { get; set; }

        public string NumAdults { get; set; }
        public string NumChildren { get; set; }
        public string NumInfants { get; set; }
        public string PromoCode { get; set; }
        public string PickedSeats { get; set; }
        public string FlightClass { get; set; }
        
        public decimal TotalPrice { get; set; }

        public string DepartDate { get; set; }
        public string ReturnDate { get; set; }

        public string DepartTime { get; set; }
        public string ReturnTime { get; set; }

        public string SelectedClassDeparture { get; set; }
        public string SelectedClassReturn { get; set; }

        public string FlightNumber { get; set; }
        public string ReturnFlightNumber { get; set; }

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
                payment = new Payment
                {
                    Origin = this.Origin,
                    Destination = this.Destination,
                    TotalPrice = this.TotalPrice,
                    DepartureSeats = this.SelectedDepartureSeats,
                    ReturnSeats = this.SelectedReturnSeats,
                    TripType = this.TripType,
                    FlightNumberDeparture = this.FlightNumber,
                    FlightNumberReturn = this.ReturnFlightNumber,
                    FlightClass = this.FlightClass,
                    DepartureDateTime = DateTime.Parse($"{DepartDate} {DepartTime}"),
                    ReturnDateTime = TripType == "Round-trip" ? DateTime.Parse($"{ReturnDate} {ReturnTime}") : DateTime.MinValue
                };

                payment.FormClosed += (s, args) => this.Show();
                payment.Show();
            }
            else
            {
                payment.BringToFront();
                payment.Focus();
            }
            this.Hide();

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
            txtFlightLoc.Text = $"{Origin} to {Destination}";
            txtTripType.Text = TripType;
            txtFlightClass.Text = FlightClass;
            txtDepartDateAndTime.Text = $"{DepartDate} {DepartTime}";
            txtReturnDateAndTime.Text = TripType == "Round-trip" ? $"{ReturnDate} {ReturnTime}" : "N/A";
            txtFlightNum.Text = FlightNumber;
            txtReturnFlightNum.Text = TripType == "Round-trip" ? ReturnFlightNumber : "N/A";
            txtTotalPrice.Text = TotalPrice.ToString("C2");
        }
    }
}
