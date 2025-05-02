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
    public partial class SearchFlight : Form
    {
        private string lastSelectedLocation = null;  // To keep track of the last selected location in CmbLoc1
        private string lastSelectedLocation2 = null; // To keep track of the last selected location in CmbLoc2
        private bool isClearingSelection = false; // Flag to avoid unwanted behavior
        private NumericUpDown numericUpDownAdults;         
        private NumericUpDown numericUpDownChildren;        
        private NumericUpDown numericUpDownInfants;

        public SearchFlight()
        {
            
            InitializeComponent();
            
            // Subscribe to the SelectedIndexChanged event
            CmbLoc1.SelectedIndexChanged -= CmbLoc1_SelectedIndexChanged;
            CmbLoc2.SelectedIndexChanged -= CmbLoc2_SelectedIndexChanged;


        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {
            

            CmbTrip.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAdults.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbChildren.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbInfant.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set the DateTimePicker to allow dates only within one year range
            DateTime today = DateTime.Today;
            dtpDepartDate.MinDate = today;  // Set minimum date to today
            dtpDepartDate.MaxDate = today.AddYears(1);  // Set maximum date to one year from today
            dtpReturnDate.MinDate = today;
            dtpReturnDate.MaxDate = today.AddYears(1);

            // Make the DateTimePicker read - only by preventing user input
            dtpDepartDate.KeyPress += (s, args) =>
            {
                args.Handled = true;  // Prevent editing through the keyboard
            };
            PopulateComboBoxes();
            
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookingSummary bookingSummary = new BookingSummary();
            if (CmbTrip.SelectedItem.ToString() == "Round-trip")
            {
                LblReturnDate.Visible = true;
                dtpReturnDate.Visible = true; // Show the return date DateTimePicker
                bookingSummary.TripType = CmbTrip.SelectedItem.ToString();

                LblReturnTime.Visible = true;
                CmbReturnTime.Visible = true;

            }
            else if(CmbTrip.SelectedItem.ToString() == "One-way")
            {
                LblReturnDate.Visible = false;
                dtpReturnDate.Visible = false; // Hide the return date DateTimePicker
                bookingSummary.TripType = CmbTrip.SelectedItem.ToString();

                LblReturnTime.Visible = false;
                CmbReturnTime.Visible = false;

            }
        }
        
        private void Pet_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void PopulateComboBoxes()
        {
            

            // Clear existing items
            CmbLoc1.Items.Clear();
            CmbLoc2.Items.Clear();

            // Add locations to both ComboBoxes
            string[] locations = { "Cebu   CEB", "Davao   DVO", "Iloilo   ILO", "Palawan   PAL", "Marilao   MRL" };
            CmbLoc1.Items.AddRange(locations);
            CmbLoc2.Items.AddRange(locations);
        }

        private void CmbLoc1_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Check if an item is selected
            if (CmbLoc1.SelectedItem != null)
            {
                // Get the currently selected location
                string selectedLocation = CmbLoc1.SelectedItem.ToString();

                // If there was a previously selected location, re-add it to CmbLoc2
                if (lastSelectedLocation != null && lastSelectedLocation != selectedLocation)
                {
                    // Re-add the last selected location to CmbLoc2
                    if (!CmbLoc2.Items.Contains(lastSelectedLocation))
                    {
                        CmbLoc2.Items.Add(lastSelectedLocation);
                    }
                }

                // Remove the currently selected location from CmbLoc2
                if (CmbLoc2.Items.Contains(selectedLocation))
                {
                    CmbLoc2.Items.Remove(selectedLocation);
                }

                // Update the last selected location
                lastSelectedLocation = selectedLocation;
            }
            else
            {
                // If no item is selected, re-add all locations to CmbLoc2
                PopulateComboBoxes();
                lastSelectedLocation = null; // Reset the last selected location
            }

            // Prevent processing when clearing ComboBox
            if (isClearingSelection)
                return;

        }

        private void CmbLoc2_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Check if an item is selected
            if (CmbLoc2.SelectedItem != null)
            {
                string selectedLocation = CmbLoc2.SelectedItem.ToString();

                // If there was a previously selected location, re-add it to CmbLoc1
                if (lastSelectedLocation2 != null && lastSelectedLocation2 != selectedLocation)
                {
                    if (!CmbLoc1.Items.Contains(lastSelectedLocation2))
                    {
                        CmbLoc1.Items.Add(lastSelectedLocation2);
                    }
                }

                // Remove the currently selected location from CmbLoc1
                if (CmbLoc1.Items.Contains(selectedLocation))
                {
                    CmbLoc1.Items.Remove(selectedLocation);
                }

                // Update the last selected location for CmbLoc2
                lastSelectedLocation2 = selectedLocation;
            }
            else
            {
                // If no item is selected, re-add all locations to CmbLoc1
                PopulateComboBoxes();
                lastSelectedLocation2 = null;
            }

            // Prevent processing when clearing ComboBox
            if (isClearingSelection)
                return;
        }

        private void LblXFrom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LblXFrom Clicked");
            CmbLoc1.SelectedIndex = -1;
        }

        private void LblXTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LblXTo Clicked");
            CmbLoc2.SelectedIndex = -1;
        }

        // Set ComboBox1 and ComboBox2 based on passed values
        public void SetComboBoxes(string location1, string location2)
        {
            SetComboBox1Text(location1);
            SetComboBox2Text(location2);
        }

        public void SetComboBox1Text(string location)
        {
            // Check if the location exists in the ComboBox, and select it if it does
            int index = CmbLoc1.Items.IndexOf(location);
            if (index != -1)
            {
                CmbLoc1.SelectedIndex = index;  // Set the selected item to the given location
            }

        }

        // Set ComboBox2 text based on passed value
        private void SetComboBox2Text(string location)
        {
            int index = CmbLoc2.Items.IndexOf(location);
            if (index != -1)
            {
                CmbLoc2.SelectedIndex = index;  // Set the selected item to the given location
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int adultCount = CmbAdults.SelectedItem != null ? Convert.ToInt32(CmbAdults.SelectedItem.ToString()) : 0;
            int childCount = CmbChildren.SelectedItem != null ? Convert.ToInt32(CmbChildren.SelectedItem.ToString()) : 0;
            int infantCount = CmbInfant.SelectedItem != null ? Convert.ToInt32(CmbInfant.SelectedItem.ToString()) : 0;

            int totalSeats = adultCount + childCount + infantCount;

            // Check if SearchFlight form is already open
            SeatSelection seatselection = Application.OpenForms.OfType<SeatSelection>().FirstOrDefault();
            
            if (seatselection == null || seatselection.IsDisposed)
            {
                seatselection = new SeatSelection();
                seatselection.DepartDate = dtpDepartDate.Value.ToShortDateString();
                seatselection.NumAdults = adultCount;  // Pass the number of adults to SeatSelection
                seatselection.AllowedSeatCount = totalSeats; // ✅ Pass it here
                seatselection.NumChildren = childCount;
                seatselection.NumInfants = infantCount;

                seatselection.Destination = $"{CmbLoc1.Text} to {CmbLoc2.Text}";

                seatselection.TripType = CmbTrip.SelectedItem?.ToString();

                // Handle Round-trip and One-way cases
                if (CmbTrip.SelectedItem?.ToString() == "Round-trip")
                {
                    // Pass the Return Date and Time for Round-trip
                    seatselection.ReturnDate = dtpReturnDate.Value.ToShortDateString();
                    seatselection.ReturnTime = CmbReturnTime.SelectedItem?.ToString();
                }
                else
                {
                    // For One-way trip, ReturnDate and ReturnTime can be null
                    seatselection.ReturnDate = null;
                    seatselection.ReturnTime = null;
                }

                seatselection.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                seatselection.Show();
            }
            else
            {
                // If already open, bring it to the front
                seatselection.BringToFront();
                seatselection.Focus();
            }
           
            
            this.Hide(); // Optionally hide the Homepage when navigating to SearchFlight
        }

      

        private void CmbAdults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Promo_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void DTPDepartTime_ValueChanged(object sender, EventArgs e)
        {

        }
        
    }
}


