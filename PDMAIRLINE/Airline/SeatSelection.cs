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
        private bool isClassChanging = false;
        public int AllowedSeatCount { get; set; }  // total passengers
        public int NumAdults { get; set; }
        public int NumChildren { get; set; }
        public int NumInfants { get; set; }

        public string TripType { get; set; }
        public string Destination { get; set; }
        public string DepartDate { get; set; }
        public string DepartTime { get; set; }
        public string ReturnTime { get; set; }
        public string ReturnDate { get; set; }

        public string PickedSeats { get; set; }
        public string FlightNumber { get; set; }
        public string ReturnFlightNumber { get; set; }

        private bool isSelectingReturn = false;
        private List<string> selectedDepartureSeats = new List<string>();
        private List<string> selectedReturnSeats = new List<string>();
        private string selectedClassDeparture = "";
        private string selectedClassReturn = "";



        public SeatSelection()
        {
            InitializeComponent();
            Load += SeatSelection_Load;

            // Set checkbox Text from their Name (e.g., chkA1 → A1)
            foreach (Control ctrl in panelSeats.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox seatCheckbox = (CheckBox)ctrl;
                    ((CheckBox)ctrl).CheckedChanged += SeatCheckbox_CheckedChanged;

                    if (seatCheckbox.Name.StartsWith("chk") && seatCheckbox.Name.Length > 3)

                    {
                        string seatLabel = seatCheckbox.Name.Substring(3); // e.g., "A1", "B2"
                        seatCheckbox.Tag = seatLabel; // Store seat label hidden
                        seatCheckbox.Text = "";       // Hide label to avoid design layout issues
                    }

                }
            }


        }

        private void SeatSelection_Load(object sender, EventArgs e)
        {
            txtNumSeats.Text = AllowedSeatCount.ToString();
            txtNumAdults.Text = NumAdults.ToString(); // Display the number of adults
            txtNumChildren.Text = NumChildren.ToString(); // Display the number of childs
            txtNumInfants.Text = NumInfants.ToString();
            txtPickedSeats.Text = "";

            if (!string.IsNullOrEmpty(FlightNumber))
            {
                txtFlightNumber.Text = FlightNumber;
            }

            if (!string.IsNullOrEmpty(ReturnFlightNumber))
            {
                txtReturnFlightNumber.Text = ReturnFlightNumber;
            }

            if (TripType == "Round-trip")
            {
                btnNext.Visible = true;
                txtReturnFlightNumber.Visible = true;
                txtReturnFlightNumber.Text = ReturnFlightNumber;
            }
            else
            {
                btnNext.Visible = false;
                txtReturnFlightNumber.Visible = false;
            }

            lblSeatTitle.Text = "Select Seats for Departure Flight";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            BookingSummary bookingsummary = Application.OpenForms.OfType<BookingSummary>().FirstOrDefault();

            if (TripType == "Round-trip" && !isSelectingReturn)
            {
                MessageBox.Show("Please click 'Next' to select return flight seats before proceeding.");
                return;
            }

            if (TripType == "Round-trip")
            {
                selectedReturnSeats = panelSeats.Controls
                    .OfType<CheckBox>()
                    .Where(cb => cb.Checked)
                    .Select(cb => cb.Tag?.ToString())
                    .Where(tag => !string.IsNullOrEmpty(tag))
                    .ToList();

                selectedClassReturn = cmbFlightClass.SelectedItem?.ToString();

                if (selectedReturnSeats.Count != AllowedSeatCount)
                {
                    MessageBox.Show($"Please select exactly {AllowedSeatCount} seats for the return flight.");
                    return;
                }
            }

            string selectedClass = TripType == "Round-trip" ? $"{selectedClassDeparture} / {selectedClassReturn}" : cmbFlightClass.SelectedItem?.ToString();
            string allSeats = TripType == "Round-trip"
                ? string.Join(", ", selectedDepartureSeats) + " | Return: " + string.Join(", ", selectedReturnSeats)
                : txtPickedSeats.Text;

            decimal totalPrice = CalculateTotalPrice();

            if (bookingsummary == null || bookingsummary.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                bookingsummary = new BookingSummary
                {
                    SelectedDepartureSeats = selectedDepartureSeats,
                    SelectedReturnSeats = selectedReturnSeats,
                    NumAdults = this.NumAdults.ToString(),
                    NumChildren = this.NumChildren.ToString(),
                    NumInfants = this.NumInfants.ToString(),
                    TripType = this.TripType,
                    Destination = this.Destination,
                    DepartDate = this.DepartDate,
                    ReturnDate = this.ReturnDate,
                    ReturnTime = this.ReturnTime,
                    DepartTime = this.DepartTime,
                    FlightNumber = this.FlightNumber,
                    ReturnFlightNumber = this.ReturnFlightNumber,
                    PickedSeats = string.Join(", ", selectedDepartureSeats) +
                                  (TripType == "Round-trip" ? " / " + string.Join(", ", selectedReturnSeats) : ""),
                    FlightClass = selectedClass,
                    TotalPrice = totalPrice

                };



                bookingsummary.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                bookingsummary.Show();
            }
            else
            {
                // If already open, bring it to the front
                bookingsummary.BringToFront();
                bookingsummary.Focus();
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void cmbFlightClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (isClassChanging || cmbFlightClass.SelectedItem == null)
                return;

            try
            {
                isClassChanging = true;

                foreach (Control ctrl in panelSeats.Controls)
                {
                    var seatCheckbox = ctrl as CheckBox;
                    if (seatCheckbox != null)
                    {
                        seatCheckbox.Checked = false;
                    }
                }

                string selectedClass = cmbFlightClass.SelectedItem.ToString();

                foreach (Control ctrl in panelSeats.Controls)
                {
                    var seatCheckbox = ctrl as CheckBox;
                    if (seatCheckbox != null)
                    {
                        string seatName = seatCheckbox.Name;

                        if (seatName.StartsWith("chk") && seatName.Length >= 5)
                        {
                            string seatLabel = seatName.Substring(3);
                            string rowStr = seatLabel.Substring(1);

                            int rowNumber;

                            if (int.TryParse(rowStr, out rowNumber))
                            {
                                switch (selectedClass)
                                {
                                    case "First Class":
                                        seatCheckbox.Enabled = (rowNumber >= 1 && rowNumber <= 3);
                                        break;
                                    case "Business Class":
                                        seatCheckbox.Enabled = (rowNumber >= 4 && rowNumber <= 10);
                                        break;
                                    case "Economy Class":
                                        seatCheckbox.Enabled = (rowNumber >= 11 && rowNumber <= 22);
                                        break;
                                }

                                seatCheckbox.BackColor = seatCheckbox.Enabled ? Color.White : Color.LightGray;
                            }
                        }
                    }
                }
                txtPickedSeats.Text = "";  // Clear selected seats when class changes
            }
            finally
            {
                isClassChanging = false;
            }
        }

        private void SeatCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (isClassChanging) return;

            CheckBox clickedSeat = (CheckBox)sender;

            // If trying to check a seat
            if (clickedSeat.Checked)
            {
                int currentlyChecked = panelSeats.Controls
                    .OfType<CheckBox>()
                    .Count(cb => cb.Checked);

                if (currentlyChecked > AllowedSeatCount)
                {
                    clickedSeat.Checked = false;
                    MessageBox.Show($"You can only select up to {AllowedSeatCount} seats.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!clickedSeat.Checked)
                return;

            string seatName = clickedSeat.Name;

            if (seatName.StartsWith("chk") && seatName.Length >= 5)
            {
                string seatLabel = seatName.Substring(3);
                string rowStr = seatLabel.Substring(1);

                int rowNumber;
                if (int.TryParse(rowStr, out rowNumber))
                {
                    string seatClass = "";
                    if (rowNumber >= 1 && rowNumber <= 3)
                        seatClass = "First Class";
                    else if (rowNumber >= 4 && rowNumber <= 10)
                        seatClass = "Business Class";
                    else if (rowNumber >= 11 && rowNumber <= 22)
                        seatClass = "Economy Class";

                    if (cmbFlightClass.SelectedItem == null ||
                        cmbFlightClass.SelectedItem.ToString() != seatClass)
                    {
                        cmbFlightClass.SelectedItem = seatClass;
                        MessageBox.Show($"Flight class automatically changed to {seatClass} for this seat.");

                        try
                        {
                            isClassChanging = true;

                        }
                        finally
                        {
                            isClassChanging = false;
                        }
                    }
                }
            }
            // Update txtPickedSeats with selected seat labels
            var selectedSeats = panelSeats.Controls
                .OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Tag?.ToString()) // Use Tag, not Text
                .Where(tag => !string.IsNullOrEmpty(tag))
                .OrderBy(tag => tag) // ⬅️ Sort alphabetically
                .ToList();

            txtPickedSeats.Text = string.Join(", ", selectedSeats);
        }

        private decimal CalculateTotalPrice()
        {
            string selectedClass = cmbFlightClass.SelectedItem?.ToString();
            int selectedSeats = panelSeats.Controls.OfType<CheckBox>().Count(cb => cb.Checked);

            decimal pricePerSeat = 0;

            switch (selectedClass)
            {
                case "First Class":
                    pricePerSeat = 5000;
                    break;
                case "Business Class":
                    pricePerSeat = 3000;
                    break;
                case "Economy Class":
                    pricePerSeat = 2000;
                    break;
            }

            decimal destinationModifier = 0;
            if (!string.IsNullOrEmpty(Destination))
            {
                if (Destination.Contains("Iloilo   ILO"))
                    destinationModifier = -800;
                else if (Destination.Contains("Palawan   PAL"))
                    destinationModifier = -600;
                else if (Destination.Contains("Cebu   CEB"))
                    destinationModifier = -400;
                else if (Destination.Contains("Davao   DVO"))
                    destinationModifier = -200;
            }
            decimal total = (destinationModifier * selectedSeats) + (pricePerSeat * selectedSeats);

            // ✈️ Adjust for trip type (half price if One-way)
            if (TripType == "One-way")
            {
                total /= 2;
            }

            return total;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!isSelectingReturn)
            {
                // Save selected departure seats
                selectedDepartureSeats = panelSeats.Controls
                .OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Tag?.ToString())
                .Where(tag => !string.IsNullOrEmpty(tag))
                .ToList();
                selectedClassDeparture = cmbFlightClass.SelectedItem?.ToString();

                if (selectedDepartureSeats.Count != AllowedSeatCount)
                {
                    MessageBox.Show($"Please select exactly {AllowedSeatCount} seats for the departure flight.");
                    return;
                }

                // Reset seat selection for return
                foreach (Control ctrl in panelSeats.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox seatCheckbox = (CheckBox)ctrl;
                        seatCheckbox.Checked = false;
                        seatCheckbox.Enabled = true;
                    }
                }

                cmbFlightClass.SelectedItem = null;
                txtPickedSeats.Text = "";
                isSelectingReturn = true;

                lblSeatTitle.Text = "Select Seats for Return Flight";
            }
         }

       
    }
}
