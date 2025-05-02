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
        public string ReturnDate { get; set; }
        public string ReturnTime { get; set; }
        public string PromoCode { get; set; }

        public string PickedSeats { get; set; }

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
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            BookingSummary bookingsummary = Application.OpenForms.OfType<BookingSummary>().FirstOrDefault();
            string selectedSeats = txtPickedSeats.Text; // This contains the picked seat labels
            string selectedClass = cmbFlightClass.SelectedItem?.ToString();

            if (bookingsummary == null || bookingsummary.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                bookingsummary = new BookingSummary
                {
                    
                    NumAdults = this.NumAdults.ToString(),       // <-- make sure SeatSelection has these values
                    NumChildren = this.NumChildren.ToString(),
                    NumInfants = this.NumInfants.ToString(),
                    TripType = this.TripType,                    // Optional: if you're passing trip type
                    Destination = this.Destination,
                    DepartDate = this.DepartDate,
                    ReturnDate = this.ReturnDate,
                    PromoCode = this.PromoCode,
                    PickedSeats = selectedSeats,
                    FlightClass = selectedClass

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
    }
}
