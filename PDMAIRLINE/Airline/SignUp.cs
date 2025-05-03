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
using BCrypt.Net;

namespace Airline
{
    public partial class SignUp : Form
    {
        // Database connection string
        private readonly string connectionString = "server=localhost;database=pdm_airline_db1;user=root;password=;";

        public SignUp()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim().ToLower(); // Renamed
            string password = TxtPassword.Text.Trim();
            string confirmPassword = TxtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO users (username, password_hash, role, is_verified, created_at) VALUES (@Username, @PasswordHash, @Role, @IsVerified, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    cmd.Parameters.AddWithValue("@Role", "user");
                    cmd.Parameters.AddWithValue("@IsVerified", true);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        query = "SELECT user_id, username, role, is_verified FROM users WHERE username = @Username LIMIT 1";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SessionManager.UserId = Convert.ToInt32(reader["user_id"]);
                                SessionManager.Username = reader["username"].ToString(); // Renamed from Email
                                SessionManager.Role = reader["role"].ToString();
                                SessionManager.IsVerified = Convert.ToBoolean(reader["is_verified"]);
                            }
                        }

                        MessageBox.Show("Sign-Up Successful! You can Login now.", "Sign-Up Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new LogIn().Show();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred during sign-up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = ChkShowPassword.Checked ? '\0' : '*';
            TxtConfirmPassword.PasswordChar = ChkShowPassword.Checked ? '\0' : '*';
        }
    }
}
