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
            DTPDepart.MaxDate = DateTime.Now.AddMonths(6);

            DTPReturn.MinDate = DateTime.Now;
            DTPReturn.MaxDate = DateTime.Now.AddMonths(6);

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
            string[] locations = { "Cebu   CEB", "Davao   DVO", "Iloilo   ILO", "Palawan   PAL" , "Marilao   MRL"};
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
            // Set flag to indicate we're clearing the ComboBox
            isClearingSelection = true;

            // Clear the selection (text) in ComboBox1
            CmbLoc1.SelectedIndex = -1;

            // Reset flag after clearing selection
            isClearingSelection = false;
        }

        private void LblXTo_Click(object sender, EventArgs e)
        {
            // Set flag to indicate we're clearing the ComboBox
            isClearingSelection = true;

            // Clear the selection (text) in ComboBox1
            CmbLoc2.SelectedIndex = -1;

            // Reset flag after clearing selection
            isClearingSelection = false;
        }
    }
}
