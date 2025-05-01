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
        private readonly string connectionString = "server=localhost;database=pdm_airline_db;user=root;password=;";

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
            string email = TxtEmail.Text.Trim().ToLower();
            string password = TxtPassword.Text.Trim();
            string confirmPassword = TxtConfirmPassword.Text.Trim();

            // Check if all fields are filled
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the password using BCrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Insert user data into the database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query to insert user into the database
                    string query = "INSERT INTO users (email, password_hash, role, is_verified, created_at) VALUES (@Email, @PasswordHash, @Role, @IsVerified, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    cmd.Parameters.AddWithValue("@Role", "user"); // Default role is 'user'
                    cmd.Parameters.AddWithValue("@IsVerified", true); // Automatic verified

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Retrieve the newly created user details
                        query = "SELECT user_id, email, role, is_verified FROM users WHERE email = @Email LIMIT 1";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set session data
                                SessionManager.UserId = Convert.ToInt32(reader["user_id"]);
                                SessionManager.Email = reader["email"].ToString();
                                SessionManager.Role = reader["role"].ToString();
                                SessionManager.IsVerified = Convert.ToBoolean(reader["is_verified"]);
                            }
                        }

                        MessageBox.Show("Sign-Up Successful! You can Login now.", "Sign-Up Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to login form after successful sign-up
                        this.Hide();
                        LogIn loginForm = new LogIn();
                        loginForm.Show();
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
