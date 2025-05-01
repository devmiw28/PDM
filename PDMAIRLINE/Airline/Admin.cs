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

        public Admin()
        {
            InitializeComponent();
            LoadUserData();

        }

        // Function to fetch user data and bind it to DataGridView
        private void LoadUserData()
        {
            // SQL query to fetch user data
            string query = "SELECT user_id, email, role, created_at FROM users";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Example: If you want to handle clicking on a cell (like opening a detailed view or editing)
            if (e.RowIndex >= 0)
            {
                // Retrieve the data from the selected row (example: user_id)
                int selectedUserId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value);

                // You could now open another form to edit or view the user's details
                MessageBox.Show("User ID: " + selectedUserId);
            }
        }
    }
}
