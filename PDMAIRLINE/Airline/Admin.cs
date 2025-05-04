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
    public partial class Admin : Form
    {
        private readonly string connectionString = "server=localhost;database=pdm_airline_db1;user=root;password=;";
        public event EventHandler DepartFlightAdded;
        public event EventHandler ReturnFlightAdded;

        public Admin()
        {
            InitializeComponent();

            dtpDepartDate.MinDate = DateTime.Today;
            dtpReturnDate.MinDate = DateTime.Today;

            dtpDepartDate.MaxDate = DateTime.Today.AddYears(1);
            dtpReturnDate.MaxDate = DateTime.Today.AddYears(1);

            SetupDataGridColumns();
            StyleDataGrid_BrownGold();
            SetColumnSizesAndAlignment();

            SetupFlightGridColumns();
            SetupReturnFlightGridColumns();
            SetupPaymentHistoryGridColumns();

            LoadFlightData();
            LoadReturnFlightData();
            LoadPaymentHistoryData();
            LoadUserData();

            DepartFlightAdded += Admin_DepartFlightAdded;
            ReturnFlightAdded += Admin_ReturnFlightAdded;


            dgDepartDateAndTime.CellFormatting += dgDepartDateAndTime_CellFormatting;
            dgReturnDateAndTime.CellFormatting += dgReturnDateAndTime_CellFormatting;

        }

        private void dgDepartDateAndTime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)  // Ensure the row is valid
            {
                if (dgDepartDateAndTime.Columns[e.ColumnIndex].Name == "departure_time")
                {
                    // Ensure the value is a valid TimeSpan and format it as HH:mm
                    if (e.Value is TimeSpan)
                    {
                        e.Value = ((TimeSpan)e.Value).ToString(@"hh\:mm");  // Format TimeSpan to HH:mm
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dgReturnDateAndTime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)  // Ensure the row is valid
            {
                if (dgReturnDateAndTime.Columns[e.ColumnIndex].Name == "return_time")
                {
                    // Ensure the value is a valid TimeSpan and format it as HH:mm
                    if (e.Value is TimeSpan)
                    {
                        e.Value = ((TimeSpan)e.Value).ToString(@"hh\:mm");  // Format TimeSpan to HH:mm
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void Admin_ReturnFlightAdded(object sender, EventArgs e)
        {
            LoadReturnFlightData(); // This will refresh the DataGridView
        }

        


        private void Admin_DepartFlightAdded(object sender, EventArgs e)
        {
            // You can update the DataGridView here if you need to perform any additional actions.
            // This will be called when a new flight is added successfully.

            // Optionally, you could also load the flight data again (in case you're not adding directly to the DataTable)
            LoadFlightData();  // Refresh the DataGridView by reloading the data
        }

        private void LoadUserData()
        {
            try
            {


                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT user_id, username, role, created_at FROM users";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataGridUsers.AutoGenerateColumns = false;
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            DataGridUsers.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetupDataGridColumns()
        {
            DataGridUsers.AutoGenerateColumns = false;
            user_id.DataPropertyName = "user_id";
            username.DataPropertyName = "username";
            role.DataPropertyName = "role";
            created_at.DataPropertyName = "created_at";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void StyleDataGrid_BrownGold()
        {
            Action<DataGridView> applyStyle = grid =>
            {
                grid.AutoGenerateColumns = false;

                grid.EnableHeadersVisualStyles = false;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 51, 0);
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold;
                grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220);
                grid.DefaultCellStyle.ForeColor = Color.Black;
                grid.DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
                grid.DefaultCellStyle.SelectionForeColor = Color.White;

                grid.RowTemplate.Height = 28;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
                grid.ReadOnly = true;
                grid.BorderStyle = BorderStyle.None;
                grid.GridColor = Color.FromArgb(153, 101, 21);
                grid.AllowUserToResizeColumns = false;
                grid.AllowUserToResizeRows = false;
            };

            applyStyle(DataGridUsers);
            applyStyle(dgDepartDateAndTime);
            applyStyle(dgReturnDateAndTime);
            applyStyle(dgPaymentHistory);

        }


        private void SetColumnSizesAndAlignment()
        {
            user_id.Width = 150;
            user_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            role.Width = 300;
            role.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            created_at.Width = 350;
            created_at.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            created_at.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

        }

        private void btnDepartInsert_Click(object sender, EventArgs e)
        {
            string flightNumber = txtDepartFlightNumber.Text.Trim();
            DateTime datePart = dtpDepartDate.Value.Date;
            TimeSpan timePart;

            if (string.IsNullOrEmpty(flightNumber))
            {
                MessageBox.Show("Please enter a flight number.");
                return;
            }

            // Validate time format
            if (!TimeSpan.TryParse(txtDepartTime.Text, out timePart))
            {
                MessageBox.Show("Invalid time format. Use HH:mm (e.g., 14:30).");
                return;
            }

            // Separate date and time
            DateTime departureDateTime = datePart.Add(timePart); // Combining the date and time

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO depart_flights (flight_number, departure_date, departure_time) VALUES (@flightNumber, @departureDate, @departureTime)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                    cmd.Parameters.AddWithValue("@departureDate", departureDateTime.Date);  // Date part
                    cmd.Parameters.AddWithValue("@departureTime", departureDateTime.TimeOfDay); // Time part
                    cmd.ExecuteNonQuery();

                    // Retrieve the last inserted flight_id using LAST_INSERT_ID()
                    MySqlCommand idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                    int flightId = Convert.ToInt32(idCmd.ExecuteScalar());

                    // Show success message
                    MessageBox.Show("Flight added successfully.");

                    // Trigger the event to notify the form that a flight has been added
                    OnFlightAdded(flightId, flightNumber, departureDateTime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding flight: " + ex.Message);
            }

            // Clear the input fields
            txtDepartTime.Text = "";
            txtDepartFlightNumber.Text = "";
        }

        private void OnFlightAdded(int flightId, string flightNumber, DateTime departureDateTime)
        {
            DataTable dt = dgDepartDateAndTime.DataSource as DataTable;

            if (dt != null)
            {
                DataRow newRow = dt.NewRow();
                newRow["departure_flight_id"] = flightId;
                newRow["flight_number"] = flightNumber;
                newRow["departure_date"] = departureDateTime.Date;
                newRow["departure_time"] = departureDateTime.ToString("HH:mm"); // Make sure to format as HH:mm
                dt.Rows.Add(newRow);
            }
            else
            {
                LoadFlightData(); // fallback if the DataSource is not set
            }
        }

        private void SetupFlightGridColumns()
        {
            dgDepartDateAndTime.AutoGenerateColumns = false;

            // Flight ID Column
            DataGridViewTextBoxColumn colFlightID = new DataGridViewTextBoxColumn
            {
                Name = "departure_flight_id",
                HeaderText = "Departure Flight ID",
                DataPropertyName = "departure_flight_id", // This binds to the flight_id column in the DataTable
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Flight Number Column
            DataGridViewTextBoxColumn colFlightNumber = new DataGridViewTextBoxColumn
            {
                Name = "flight_number",
                HeaderText = "Flight Number",
                DataPropertyName = "flight_number",
                Width = 300,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Departure Date Column
            DataGridViewTextBoxColumn colDepartureDate = new DataGridViewTextBoxColumn
            {
                Name = "departure_date",
                HeaderText = "Departure Date",
                DataPropertyName = "departure_date",
                Width = 225,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "yyyy-MM-dd" }
            };

            // Departure Time Column
            DataGridViewTextBoxColumn colDepartureTime = new DataGridViewTextBoxColumn
            {
                Name = "departure_time",
                HeaderText = "Departure Time",
                DataPropertyName = "departure_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "HH:mm" }
            };

            // Add columns to the grid
            dgDepartDateAndTime.Columns.Add(colFlightID);
            dgDepartDateAndTime.Columns.Add(colFlightNumber);
            dgDepartDateAndTime.Columns.Add(colDepartureDate);
            dgDepartDateAndTime.Columns.Add(colDepartureTime);
        }

        private void LoadFlightData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT departure_flight_id, flight_number, departure_date, departure_time FROM depart_flights ORDER BY departure_date, departure_time ASC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Format departure_time as HH:mm
                            foreach (DataRow row in dt.Rows)
                            {
                                TimeSpan departureTime = (TimeSpan)row["departure_time"];
                                row["departure_time"] = departureTime.ToString(@"hh\:mm");
                            }

                            dgDepartDateAndTime.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flights: " + ex.Message);
            }
        }

        private void SetupReturnFlightGridColumns()
        {
            dgReturnDateAndTime.AutoGenerateColumns = false;

            // Flight ID Column
            DataGridViewTextBoxColumn colFlightID = new DataGridViewTextBoxColumn
            {
                Name = "return_flight_id",
                HeaderText = "Return Flight ID",
                DataPropertyName = "return_flight_id",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Flight Number Column
            DataGridViewTextBoxColumn colFlightNumber = new DataGridViewTextBoxColumn
            {
                Name = "flight_number",
                HeaderText = "Flight Number",
                DataPropertyName = "flight_number",
                Width = 300,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Return Date Column
            DataGridViewTextBoxColumn colReturnDate = new DataGridViewTextBoxColumn
            {
                Name = "return_date",
                HeaderText = "Return Date",
                DataPropertyName = "return_date",
                Width = 225,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "yyyy-MM-dd" }
            };

            // Return Time Column
            DataGridViewTextBoxColumn colReturnTime = new DataGridViewTextBoxColumn
            {
                Name = "return_time",
                HeaderText = "Return Time",
                DataPropertyName = "return_time",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "HH:mm" }
            };

            // Add columns to the grid
            dgReturnDateAndTime.Columns.Add(colFlightID);
            dgReturnDateAndTime.Columns.Add(colFlightNumber);
            dgReturnDateAndTime.Columns.Add(colReturnDate);
            dgReturnDateAndTime.Columns.Add(colReturnTime);
        }

        private void LoadReturnFlightData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT return_flight_id, flight_number, return_date, return_time FROM return_flights ORDER BY return_date, return_time ASC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Format return_time as HH:mm
                            foreach (DataRow row in dt.Rows)
                            {
                                TimeSpan returnTime = (TimeSpan)row["return_time"];
                                row["return_time"] = returnTime.ToString(@"hh\:mm");
                            }

                            dgReturnDateAndTime.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading return flights: " + ex.Message);
            }
        }

        private void btnReturnInsert_Click(object sender, EventArgs e)
        {
            string flightNumber = txtReturnFlightNumber.Text.Trim();
            DateTime datePart = dtpReturnDate.Value.Date;
            TimeSpan timePart;

            if (string.IsNullOrEmpty(flightNumber))
            {
                MessageBox.Show("Please enter a flight number.");
                return;
            }

            if (!TimeSpan.TryParse(txtReturnTime.Text, out timePart))
            {
                MessageBox.Show("Invalid time format. Use HH:mm (e.g., 14:30).");
                return;
            }

            // Separate return_date and return_time
            DateTime returnDate = datePart;  // Only date part
            TimeSpan returnTime = timePart;  // Only time part

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO return_flights (flight_number, return_date, return_time) VALUES (@flightNumber, @returnDate, @returnTime)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                    cmd.Parameters.AddWithValue("@returnDate", returnDate);
                    cmd.Parameters.AddWithValue("@returnTime", returnTime);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Return flight added successfully.");
                    ReturnFlightAdded?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding return flight: " + ex.Message);
            }

            txtReturnTime.Text = "";
            txtReturnFlightNumber.Text = "";
        }

        private void SetupPaymentHistoryGridColumns()
        {
            dgPaymentHistory.AutoGenerateColumns = false;

            // Payment ID Column
            DataGridViewTextBoxColumn colPaymentID = new DataGridViewTextBoxColumn
            {
                Name = "payment_id",
                HeaderText = "Payment ID",
                DataPropertyName = "payment_id", // This binds to the payment_id column in the DataTable
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Payment Method Column
            DataGridViewTextBoxColumn colPaymentMethod = new DataGridViewTextBoxColumn
            {
                Name = "payment_method",
                HeaderText = "Payment Method",
                DataPropertyName = "payment_method", // This binds to the payment_method column in the DataTable
                Width = 150,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Payment Amount Column
            DataGridViewTextBoxColumn colPaymentAmount = new DataGridViewTextBoxColumn
            {
                Name = "payment_amount",
                HeaderText = "Payment Amount",
                DataPropertyName = "payment_amount",
                Width = 150,
                DefaultCellStyle = { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
            };

            // Payment Date Column
            DataGridViewTextBoxColumn colPaymentDate = new DataGridViewTextBoxColumn
            {
                Name = "payment_date",
                HeaderText = "Payment Date",
                DataPropertyName = "payment_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm", Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Payment Status Column
            DataGridViewTextBoxColumn colPaymentStatus = new DataGridViewTextBoxColumn
            {
                Name = "payment_status",
                HeaderText = "Payment Status",
                DataPropertyName = "payment_status",
                Width = 150,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Transaction Reference Column
            DataGridViewTextBoxColumn colTransactionRef = new DataGridViewTextBoxColumn
            {
                Name = "transaction_reference",
                HeaderText = "Transaction Reference",
                DataPropertyName = "transaction_reference",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleLeft }
            };

            // Add columns to the DataGridView
            dgPaymentHistory.Columns.Add(colPaymentID);
            dgPaymentHistory.Columns.Add(colPaymentMethod);
            dgPaymentHistory.Columns.Add(colPaymentAmount);
            dgPaymentHistory.Columns.Add(colPaymentDate);
            dgPaymentHistory.Columns.Add(colPaymentStatus);
            dgPaymentHistory.Columns.Add(colTransactionRef);
        }

        private void LoadPaymentHistoryData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT payment_id, payment_method, payment_amount, payment_date, payment_status, transaction_reference FROM payments ORDER BY payment_date DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgPaymentHistory.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment history: " + ex.Message);
            }
        }
        
    }
}
