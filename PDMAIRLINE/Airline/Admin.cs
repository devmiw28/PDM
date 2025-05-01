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
            StyleDataGrid_BrownGold();
            SetColumnSizesAndAlignment();
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

        private void StyleDataGrid_BrownGold()
        {
            DataGridUsers.AutoGenerateColumns = false;

            DataGridUsers.EnableHeadersVisualStyles = false;
            DataGridUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DataGridUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 51, 0);  
            DataGridUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold;
            DataGridUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            DataGridUsers.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220);
            DataGridUsers.DefaultCellStyle.ForeColor = Color.Black;
            DataGridUsers.DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            DataGridUsers.DefaultCellStyle.SelectionForeColor = Color.White;

            DataGridUsers.RowTemplate.Height = 28;
            DataGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridUsers.MultiSelect = false;
            DataGridUsers.ReadOnly = true;
            DataGridUsers.BorderStyle = BorderStyle.None;
            DataGridUsers.GridColor = Color.FromArgb(153, 101, 21);
        }


        private void SetColumnSizesAndAlignment()
        {
            user_id.Width =150;
            user_id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            role.Width = 300;
            role.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            created_at.Width = 350;
            created_at.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            created_at.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }
    }
}
