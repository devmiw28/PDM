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
            SetupDataGridColumns();
            StyleDataGrid();
            LoadUserData();

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

        private void StyleDataGrid()
        {
            DataGridUsers.AutoGenerateColumns = false;
            DataGridUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DataGridUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            DataGridUsers.EnableHeadersVisualStyles = false;
            DataGridUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DataGridUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridUsers.RowTemplate.Height = 28;
            DataGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridUsers.MultiSelect = false;
            DataGridUsers.ReadOnly = true;
        }


    }
}
