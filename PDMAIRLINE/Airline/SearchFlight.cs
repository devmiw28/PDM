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

        public SearchFlight()
        {
            InitializeComponent();

            // Subscribe to the SelectedIndexChanged event
            CmbLoc1.SelectedIndexChanged += CmbLoc1_SelectedIndexChanged;
            CmbLoc2.SelectedIndexChanged += CmbLoc2_SelectedIndexChanged;

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTrip.SelectedItem.ToString() == "Round-trip")
            {
                LblReturn.Visible = true;
                DTPReturn.Visible = true; // Show the return date DateTimePicker
            }
            else
            {
                LblReturn.Visible = false;
                DTPReturn.Visible = false; // Hide the return date DateTimePicker
            }


        }

        // Populating the ComboBox with sample dates (You can populate with actual dates from a database or range)
        private void PopulateDates()
        {
            // Set the minimum and maximum date range for the destination and return DateTimePickers
            DTPDepart.MinDate = DateTime.Now;
            DTPDepart.MaxDate = DateTime.Now.AddMonths(12);

            DTPReturn.MinDate = DateTime.Now;
            DTPReturn.MaxDate = DateTime.Now.AddMonths(12);

            // Optionally, you can set default selected date for both DateTimePickers
            DTPDepart.Value = DateTime.Now;
            DTPReturn.Value = DateTime.Now;
        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {
            CmbTrip.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAdults.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbChildren.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbInfant.DropDownStyle = ComboBoxStyle.DropDownList;

            PopulateComboBoxes();
            PopulateDates();
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
            // Check if SearchFlight form is already open
            TimeSearching timeSearch = Application.OpenForms.OfType<TimeSearching>().FirstOrDefault();

            if (timeSearch == null || timeSearch.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                timeSearch = new TimeSearching();
                timeSearch.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                timeSearch.Show();
            }
            else
            {
                // If already open, bring it to the front
                timeSearch.BringToFront();
                timeSearch.Focus();
            }

            this.Hide(); // Optionally hide the Homepage when navigating to SearchFlight
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}


