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
        private DataTable flightData;


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
            SetupBookingHistoryGridColumns();
            SetupSeatSelectedGridColumns();

            LoadFlightData();
            LoadReturnFlightData();
            LoadPaymentHistoryData();
            LoadUserData();
            LoadBookingHistoryData();
            LoadSeatSelectedData();

            DepartFlightAdded += Admin_DepartFlightAdded;
            ReturnFlightAdded += Admin_ReturnFlightAdded;


            dgDepartDateAndTime.CellFormatting += dgDepartDateAndTime_CellFormatting;
            dgReturnDateAndTime.CellFormatting += dgReturnDateAndTime_CellFormatting;

        }

        private void dgDepartDateAndTime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)  // Ensure the row is valid
            {
                if (dgDepartDateAndTime.Columns[e.ColumnIndex].Name == "depart_time")
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
            applyStyle(dgBookingHistory);
            applyStyle(dgSeatSelected);
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
            // Auto-generate flight number
            string flightNumber = GenerateFlightNumber();
            DateTime datePart = dtpDepartDate.Value.Date;
            TimeSpan timePart;

            // Validate time format
            if (!TimeSpan.TryParse(txtDepartTime.Text, out timePart))
            {
                MessageBox.Show("Invalid time format. Use HH:mm (e.g., 14:30).");
                return;
            }

            // Combine date and time
            DateTime departureDateTime = datePart.Add(timePart);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO depart_flights (depart_flight_number, depart_date, depart_time) VALUES (@flightNumber, @departDate, @departTime)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                        cmd.Parameters.AddWithValue("@departDate", departureDateTime.Date);
                        cmd.Parameters.AddWithValue("@departTime", departureDateTime.TimeOfDay);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
                    {
                        int flightId = Convert.ToInt32(idCmd.ExecuteScalar());
                        MessageBox.Show($"Flight '{flightNumber}' added successfully.");
                        OnFlightAdded(flightId, flightNumber, departureDateTime);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding flight: " + ex.Message);
            }

            // Clear input field (just time now)
            txtDepartTime.Text = "";
        }

        private string GenerateFlightNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string suffix = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return "FN" + suffix;
        }

        private void OnFlightAdded(int flightId, string flightNumber, DateTime departureDateTime)
        {
            DataTable dt = dgDepartDateAndTime.DataSource as DataTable;

            if (dt != null)
            {
                DataRow newRow = dt.NewRow();
                newRow["depart_flight_id"] = flightId;
                newRow["depart_flight_number"] = flightNumber;
                newRow["depart_date"] = departureDateTime.Date;
                newRow["depart_time"] = departureDateTime.ToString("HH:mm"); // Make sure to format as HH:mm
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
                Name = "depart_flight_id",
                HeaderText = "Departure Flight ID",
                DataPropertyName = "depart_flight_id", // This binds to the flight_id column in the DataTable
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Flight Number Column
            DataGridViewTextBoxColumn colFlightNumber = new DataGridViewTextBoxColumn
            {
                Name = "depart_flight_number",
                HeaderText = "Departure Flight Number",
                DataPropertyName = "depart_flight_number",
                Width = 300,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Departure Date Column
            DataGridViewTextBoxColumn colDepartureDate = new DataGridViewTextBoxColumn
            {
                Name = "depart_date",
                HeaderText = "Departure Date",
                DataPropertyName = "depart_date",
                Width = 225,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "yyyy-MM-dd" }
            };

            // Departure Time Column
            DataGridViewTextBoxColumn colDepartureTime = new DataGridViewTextBoxColumn
            {
                Name = "depart_time",
                HeaderText = "Departure Time",
                DataPropertyName = "depart_time",
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
                    string query = "SELECT depart_flight_id, depart_flight_number, depart_date, depart_time FROM depart_flights ORDER BY depart_flight_id ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            flightData = new DataTable();
                            adapter.Fill(flightData);

                            // Format departure_time as HH:mm
                            foreach (DataRow row in flightData.Rows)
                            {
                                TimeSpan departureTime = (TimeSpan)row["depart_time"];
                                row["depart_time"] = departureTime.ToString(@"hh\:mm");
                            }

                            dgDepartDateAndTime.DataSource = flightData;
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
                Name = "return_flight_number",
                HeaderText = "Return Flight Number",
                DataPropertyName = "return_flight_number",
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
                    string query = "SELECT return_flight_id, return_flight_number, return_date, return_time FROM return_flights ORDER BY return_flight_id ASC";

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
            // Auto-generate flight number
            string flightNumber = GenerateFlightNumber();
            DateTime datePart = dtpReturnDate.Value.Date;
            TimeSpan timePart;

            if (!TimeSpan.TryParse(txtReturnTime.Text, out timePart))
            {
                MessageBox.Show("Invalid time format. Use HH:mm (e.g., 14:30).");
                return;
            }

            DateTime returnDate = datePart;
            TimeSpan returnTime = timePart;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO return_flights (return_flight_number, return_date, return_time) VALUES (@flightNumber, @returnDate, @returnTime)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                        cmd.Parameters.AddWithValue("@returnDate", returnDate);
                        cmd.Parameters.AddWithValue("@returnTime", returnTime);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Return flight '{flightNumber}' added successfully.");
                    ReturnFlightAdded?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding return flight: " + ex.Message);
            }

            txtReturnTime.Text = "";
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

            // User ID Column
            DataGridViewTextBoxColumn colUserID = new DataGridViewTextBoxColumn
            {
                Name = "user_id",
                HeaderText = "User ID",
                DataPropertyName = "user_id", 
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
            dgPaymentHistory.Columns.Add(colUserID);
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
                    string query = "SELECT payment_id, user_id, payment_method, payment_amount, payment_date, payment_status, transaction_reference FROM payments ORDER BY payment_date ASC";
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

        private void SetupBookingHistoryGridColumns()
        {
            dgBookingHistory.AutoGenerateColumns = false;

            
            DataGridViewTextBoxColumn colBookingID = new DataGridViewTextBoxColumn
            {
                Name = "booking_id",
                HeaderText = "Booking ID",
                DataPropertyName = "booking_id", // This binds to the booking_id column in the DataTable
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            
            DataGridViewTextBoxColumn colUserID = new DataGridViewTextBoxColumn
            {
                Name = "user_id",
                HeaderText = "User ID",
                DataPropertyName = "user_id",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Depart Flight ID Column
            DataGridViewTextBoxColumn colDepartFlightID = new DataGridViewTextBoxColumn
            {
                Name = "depart_flight_id",
                HeaderText = "Depart Flight Id",
                DataPropertyName = "depart_flight_id",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Return Flight ID Column
            DataGridViewTextBoxColumn colReturnFlightID = new DataGridViewTextBoxColumn
            {
                Name = "return_flight_id",
                HeaderText = "Return Flight Id",
                DataPropertyName = "return_flight_id",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Booking Reference Column
            DataGridViewTextBoxColumn colBookingReference = new DataGridViewTextBoxColumn
            {
                Name = "booking_reference",
                HeaderText = "Booking Reference",
                DataPropertyName = "booking_reference",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter}
            };

            // Booking Date Column
            DataGridViewTextBoxColumn colBookingDate = new DataGridViewTextBoxColumn
            {
                Name = "booking_date",
                HeaderText = "Booking Date",
                DataPropertyName = "booking_date",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter, Format = "yyyy-MM-dd" }
            };

            DataGridViewTextBoxColumn colrTripType = new DataGridViewTextBoxColumn
            {
                Name = "trip_type",
                HeaderText = "Trip Type",
                DataPropertyName = "trip_type", 
                Width = 200,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colOrigin = new DataGridViewTextBoxColumn
            {
                Name = "origin",
                HeaderText = "Origin",
                DataPropertyName = "origin", 
                Width = 200,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colDestination = new DataGridViewTextBoxColumn
            {
                Name = "destination",
                HeaderText = "Destination",
                DataPropertyName = "destination", 
                Width = 200,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            // Total Price Column
            DataGridViewTextBoxColumn colTotalPrice = new DataGridViewTextBoxColumn
            {
                Name = "total_price",
                HeaderText = "Total Price",
                DataPropertyName = "total_price",
                Width = 200,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Status Column
            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn
            {
                Name = "status",
                HeaderText = "Status",
                DataPropertyName = "status",
                Width = 200,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Other necessary columns can be added here...

            // Add columns to the grid
            dgBookingHistory.Columns.Add(colBookingID);
            dgBookingHistory.Columns.Add(colUserID);
            dgBookingHistory.Columns.Add(colDepartFlightID);
            dgBookingHistory.Columns.Add(colReturnFlightID);
            dgBookingHistory.Columns.Add(colBookingReference);
            dgBookingHistory.Columns.Add(colBookingDate);
            dgBookingHistory.Columns.Add(colrTripType);
            dgBookingHistory.Columns.Add(colOrigin);
            dgBookingHistory.Columns.Add(colDestination);
            dgBookingHistory.Columns.Add(colTotalPrice);
            dgBookingHistory.Columns.Add(colStatus);
            // Add any additional columns as needed
        }

        private void LoadBookingHistoryData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT booking_id, user_id, depart_flight_id, return_flight_id, booking_reference, booking_date, trip_type, origin, destination, total_price, status FROM bookings ORDER BY booking_date ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgBookingHistory.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupSeatSelectedGridColumns()
        {
            dgSeatSelected.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colSeatSelectedID = new DataGridViewTextBoxColumn
            {
                Name = "seat_selected_id",
                HeaderText = "Seat Selected ID",
                DataPropertyName = "seat_selected_id",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colUserID = new DataGridViewTextBoxColumn
            {
                Name = "user_id",
                HeaderText = "User ID",
                DataPropertyName = "user_id",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colFlightNumber = new DataGridViewTextBoxColumn
            {
                Name = "flight_number",
                HeaderText = "Flight Number",
                DataPropertyName = "flight_number",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colDateTime = new DataGridViewTextBoxColumn
            {
                Name = "datetime",
                HeaderText = "Flight Date and Time",
                DataPropertyName = "datetime",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter}
            };

            DataGridViewTextBoxColumn colSeatCode = new DataGridViewTextBoxColumn
            {
                Name = "seat_code",
                HeaderText = "Seat Code",
                DataPropertyName = "seat_code",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colTripLeg = new DataGridViewTextBoxColumn
            {
                Name = "trip_leg",
                HeaderText = "Trip Leg",
                DataPropertyName = "trip_leg",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colCreatedAt = new DataGridViewTextBoxColumn
            {
                Name = "created_at",
                HeaderText = "Booking Date and Time",
                DataPropertyName = "created_at",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            dgSeatSelected.Columns.Add(colSeatSelectedID);
            dgSeatSelected.Columns.Add(colUserID);
            dgSeatSelected.Columns.Add(colFlightNumber);
            dgSeatSelected.Columns.Add(colDateTime);
            dgSeatSelected.Columns.Add(colSeatCode);
            dgSeatSelected.Columns.Add(colTripLeg);
            dgSeatSelected.Columns.Add(colCreatedAt);
        }

        private void LoadSeatSelectedData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT seat_selected_id, user_id, flight_number, datetime, seat_code, trip_leg, created_at FROM seat_selected ORDER BY created_at ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgSeatSelected.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
            private void btnDepartSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtDepartSearch.Text.Trim().Replace("'", "''");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT depart_flight_id, depart_flight_number, depart_date, depart_time 
                             FROM depart_flights
                             WHERE CAST(depart_flight_id AS INT) LIKE @search
                                OR depart_flight_number LIKE @search
                                OR depart_date LIKE @search
                                OR depart_time LIKE @search
                             ORDER BY depart_flight_id ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable filteredDepartData = new DataTable();
                            adapter.Fill(filteredDepartData);

                            // Format depart_time as HH:mm
                            foreach (DataRow row in filteredDepartData.Rows)
                            {
                                TimeSpan departTime = (TimeSpan)row["depart_time"];
                                row["depart_time"] = departTime.ToString(@"hh\:mm");
                            }

                            dgDepartDateAndTime.DataSource = filteredDepartData;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Depart flight search failed: " + ex.Message);
            }
        }

        private void btnReturnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtReturnSearch.Text.Trim().Replace("'", "''");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT return_flight_id, return_flight_number, return_date, return_time 
                             FROM return_flights
                             WHERE CAST(return_flight_id AS INT) LIKE @search
                                OR return_flight_number LIKE @search
                                OR return_date LIKE @search
                                OR return_time LIKE @search
                             ORDER BY return_flight_id ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable filteredReturnData = new DataTable();
                            adapter.Fill(filteredReturnData);

                            // Format return_time as HH:mm
                            foreach (DataRow row in filteredReturnData.Rows)
                            {
                                TimeSpan returnTime = (TimeSpan)row["return_time"];
                                row["return_time"] = returnTime.ToString(@"hh\:mm");
                            }

                            dgReturnDateAndTime.DataSource = filteredReturnData;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Return flight search failed: " + ex.Message);
            }
        }

        private void lblSignOut_Click(object sender, EventArgs e)
        {
            // Optional: ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            // Clear user session
            SessionManager.ClearSession();

            // Open login form
            LogIn loginForm = new LogIn(); // Replace with your actual login form class name
            loginForm.Show();

            // Close or hide this form
            this.Hide();
        }
    }
}
