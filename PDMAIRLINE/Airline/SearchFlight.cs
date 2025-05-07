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
    public partial class SearchFlight : Form
    {
        private readonly string connectionString = "server=localhost;database=pdm_airline_db1;user=root;password=;";

        private string lastSelectedLocation = null;  // To keep track of the last selected location in CmbLoc1
        private string lastSelectedLocation2 = null; // To keep track of the last selected location in CmbLoc2
        private bool isClearingSelection = false; // Flag to avoid unwanted behavior
        private NumericUpDown numericUpDownAdults;         
        private NumericUpDown numericUpDownChildren;        
        private NumericUpDown numericUpDownInfants;
        
        private Dictionary<string, string> departTimeToFlightNumber = new Dictionary<string, string>();
        private Dictionary<string, string> returnTimeToFlightNumber = new Dictionary<string, string>();



        public SearchFlight()
        {
            
            InitializeComponent();

            CmbLoc1.SelectedIndexChanged += CmbLoc1_SelectedIndexChanged;
            CmbLoc2.SelectedIndexChanged += CmbLoc2_SelectedIndexChanged;


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

            // Set DateTimePicker format to "yyyy-MM-dd" (which is more standard)
            dtpDepartDate.Format = DateTimePickerFormat.Custom;
            dtpDepartDate.CustomFormat = "yyyy-MM-dd";

            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.CustomFormat = "yyyy-MM-dd";

            dtpDepartDate.ValueChanged += dtpDepartDate_ValueChanged;
            dtpReturnDate.ValueChanged += dtpReturnDate_ValueChanged;


            // Make the DateTimePicker read - only by preventing user input
            dtpDepartDate.KeyPress += (s, args) =>
            {
                args.Handled = true;  // Prevent editing through the keyboard
            };

            dtpReturnDate.KeyPress += (s, args) =>
            {
                args.Handled = true;
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
        {// Check if an item is selected
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
            CmbLoc1.SelectedIndex = -1;
        }

        private void LblXTo_Click(object sender, EventArgs e)
        {
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
            // Validate trip type and ensure the necessary selections are made
            int adultCount = CmbAdults.SelectedItem != null ? Convert.ToInt32(CmbAdults.SelectedItem.ToString()) : 0;
            int childCount = CmbChildren.SelectedItem != null ? Convert.ToInt32(CmbChildren.SelectedItem.ToString()) : 0;
            int infantCount = CmbInfant.SelectedItem != null ? Convert.ToInt32(CmbInfant.SelectedItem.ToString()) : 0;

            int totalSeats = adultCount + childCount + infantCount;

            string selectedDepartTime = null;
            // Validate departure time selection
            if (CmbDepartTime.SelectedItem != null)
            {
                selectedDepartTime = CmbDepartTime.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a Departure Time.", "Time Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if Departure Time is not selected
            }

            string departFlightNumber = null;
            if (selectedDepartTime != null && departTimeToFlightNumber.ContainsKey(selectedDepartTime))
            {
                departFlightNumber = departTimeToFlightNumber[selectedDepartTime];
            }

            string returnFlightNumber = null;

            // Handle round-trip validation
            if (CmbTrip.SelectedItem?.ToString() == "Round-trip")
            {
                // Ensure return time is selected
                if (CmbReturnTime.SelectedItem == null)
                {
                    MessageBox.Show("Please select a return time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedReturnTime = CmbReturnTime.SelectedItem.ToString();
                if (returnTimeToFlightNumber.ContainsKey(selectedReturnTime))
                {
                    returnFlightNumber = returnTimeToFlightNumber[selectedReturnTime];
                }
                else
                {
                    MessageBox.Show("Return flight number not found for selected time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpReturnDate.Value.Date <= dtpDepartDate.Value.Date)
                {
                    // Ensure that the return date is later than the departure date.
                    if (dtpReturnDate.Value.Date == dtpDepartDate.Value.Date)
                    {
                        DateTime departTime = DateTime.Parse(selectedDepartTime);
                        DateTime returnTime = DateTime.Parse(selectedReturnTime);

                        // Calculate the minimum return time (12 hours after departure)
                        DateTime minReturnTime = departTime.AddHours(12);

                        // Calculate the time difference between return and depart time
                        TimeSpan timeDifference = returnTime - departTime;

                        // Check if return time is at least 12 hours after departure time
                        if (timeDifference.TotalHours < 12)
                        {
                            MessageBox.Show("Return time must be at least 12 hours after departure time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method if the return time is not valid
                        }
                    }
                }
                
            }
            
            // Prepare the SeatSelection form and pass the necessary data
            SeatSelection seatselection = Application.OpenForms.OfType<SeatSelection>().FirstOrDefault();

            if (seatselection == null || seatselection.IsDisposed)
            {
                seatselection = new SeatSelection
                {
                    DepartDate = dtpDepartDate.Value.ToShortDateString(),
                    NumAdults = adultCount,
                    AllowedSeatCount = totalSeats,
                    NumChildren = childCount,
                    NumInfants = infantCount,
                    Origin = CmbLoc1.Text,
                    Destination = CmbLoc2.Text,
                    TripType = CmbTrip.SelectedItem?.ToString(),
                    DepartTime = selectedDepartTime, // Pass selected depart time
                    FlightNumber = departFlightNumber, // Pass departure flight number
                    ReturnFlightNumber = returnFlightNumber // Pass return flight number for round-trip
                };

                // Set the Return Date and Time when it's a round trip
                if (CmbTrip.SelectedItem?.ToString() == "Round-trip")
                {
                    seatselection.ReturnDate = dtpReturnDate.Value.ToShortDateString(); // Add the Return Date here
                    seatselection.ReturnTime = CmbReturnTime.SelectedItem?.ToString(); // Add the Return Time here
                }

                seatselection.FormClosed += (s, args) => this.Show(); // When SeatSelection is closed, show SearchFlight again
                seatselection.Show();
            }
            else
            {
                seatselection.BringToFront();
                seatselection.Focus();
            }

            this.Hide(); 

        }
        

        private void LoadAvailableDepartTimes(DateTime selectedDate)
        {
            // Clear the combo box before adding new items
            CmbDepartTime.Items.Clear();

            // Format the selected date to match the format in the database (YYYY-MM-DD)
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");  // Use database-compatible format
            Console.WriteLine($"Searching for flights on: {formattedDate}");  // Debug output

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();  // Ensure connection is open

                    departTimeToFlightNumber.Clear();  
                    CmbDepartTime.Items.Clear();

                    // Modify the query to filter by selected date
                    string query = $"SELECT depart_time, depart_flight_number FROM depart_flights WHERE depart_date = '{formattedDate}'ORDER BY depart_time ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are any rows in the result
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    TimeSpan departTime = reader.GetTimeSpan("depart_time");
                                    string flightNumber = reader.GetString("depart_flight_number");
                                    string timeFormatted = departTime.ToString(@"hh\:mm");

                                    CmbDepartTime.Items.Add(timeFormatted);
                                    departTimeToFlightNumber[timeFormatted] = flightNumber;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows returned from the database.");
                            }
                        }
                    }
                }

                // If no items are found in the ComboBox, show a message
                if (CmbDepartTime.Items.Count == 0)
                {
                    MessageBox.Show("No departure times available for the selected date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departure times: " + ex.Message);
            }
        }

        // Event to load available departure times when the user selects a depart date
        private void dtpDepartDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableDepartTimes(dtpDepartDate.Value);
        }

        private void LoadAvailableReturnTimes(DateTime selectedDate)
        {
            // Clear the combo box before adding new items
            CmbReturnTime.Items.Clear();
            returnTimeToFlightNumber.Clear();

            // Format the selected date to match the format in the database (YYYY-MM-DD)
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query for return times on the selected date
                    string query = $"SELECT return_time, return_flight_number FROM return_flights WHERE return_date = '{formattedDate}'ORDER BY return_time ASC;";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    TimeSpan returnTime = reader.GetTimeSpan("return_time");
                                    string flightNumber = reader.GetString("return_flight_number");
                                    
                                    string timeFormatted = returnTime.ToString(@"hh\:mm");

                                    CmbReturnTime.Items.Add(timeFormatted);
                                    returnTimeToFlightNumber[timeFormatted] = flightNumber;
                                }
                            }
                        }
                    }
                }

                if (CmbReturnTime.Items.Count == 0)
                {
                    MessageBox.Show("No return times available for the selected date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading return times: " + ex.Message);
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableReturnTimes(dtpReturnDate.Value);
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


