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
        private readonly string connectionString = "server=localhost;database=pdm_airline_db;user=root;password=;";
        public event EventHandler FlightAdded;

        public Admin()
        {
            InitializeComponent();
            SetupDataGridColumns();
            StyleDataGrid_BrownGold();
            SetColumnSizesAndAlignment();
            LoadUserData();

            SetupFlightGridColumns();
            LoadFlightData();

            FlightAdded += Admin_FlightAdded;
        }

        private void Admin_FlightAdded(object sender, EventArgs e)
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
                    string query = "SELECT user_id, email, role, created_at FROM users";
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
            email.DataPropertyName = "email";
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
        }


        private void SetColumnSizesAndAlignment()
        {
            user_id.Width = 150;
            user_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

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

            if (!TimeSpan.TryParse(txtDepartTime.Text, out timePart))
            {
                MessageBox.Show("Invalid time format. Use HH:mm (e.g., 14:30).");
                return;
            }

            DateTime departureDateTime = datePart.Add(timePart);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO flights (flight_number, departure_datetime) VALUES (@flightNumber, @departure)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                    cmd.Parameters.AddWithValue("@departure", departureDateTime);
                    cmd.ExecuteNonQuery();

                    // Retrieve the last inserted flight_id using LAST_INSERT_ID()
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    int flightId = Convert.ToInt32(cmd.ExecuteScalar());

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

            txtDepartTime.Text = "";
            txtDepartFlightNumber.Text = "";
        }

        private void OnFlightAdded(int flightId, string flightNumber, DateTime departureDateTime)
        {
            // Assuming dgDepartDateAndTime's DataSource is a DataTable
            DataTable dt = (DataTable)dgDepartDateAndTime.DataSource;

            // Create a new row for the new flight
            DataRow newRow = dt.NewRow();
            newRow["flight_id"] = flightId;
            newRow["flight_number"] = flightNumber;
            newRow["departure_datetime"] = departureDateTime;

            // Add the new row to the DataTable
            dt.Rows.Add(newRow);  // Insert at the top or use dt.Rows.Add(newRow) to append at the bottom
        }

        private void SetupFlightGridColumns()
        {
            dgDepartDateAndTime.AutoGenerateColumns = false;

            // Flight ID Column
            DataGridViewTextBoxColumn colFlightID = new DataGridViewTextBoxColumn
            {
                Name = "flight_id",
                HeaderText = "Flight ID",
                DataPropertyName = "flight_id", // This binds to the flight_id column in the DataTable
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Create columns manually
            DataGridViewTextBoxColumn colFlightNumber = new DataGridViewTextBoxColumn
            {
                Name = "flight_number",
                HeaderText = "Flight Number",
                DataPropertyName = "flight_number",
                Width = 300,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            DataGridViewTextBoxColumn colDeparture = new DataGridViewTextBoxColumn
            {
                Name = "departure_datetime",
                HeaderText = "Departure Date & Time",
                DataPropertyName = "departure_datetime",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm", Alignment = DataGridViewContentAlignment.MiddleCenter }
            };

            // Add columns to the grid

            dgDepartDateAndTime.Columns.Add(colFlightID);
            dgDepartDateAndTime.Columns.Add(colFlightNumber);
            dgDepartDateAndTime.Columns.Add(colDeparture);
        }

        private void LoadFlightData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT flight_id, flight_number, departure_datetime FROM flights ORDER BY departure_datetime ASC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
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
    }
}
