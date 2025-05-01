using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Airline
{
    public partial class LogIn : Form
    {
        private readonly string connectionString = "server=localhost;database=pdm_airline_db;user=root;password=;";
        private static SignUp signupFormInstance;
        private static LogIn loginFormInstance;

        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text.Trim().ToLower();
            string password = TxtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Email and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE email = @Email LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader["password_hash"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                            {
                                
                                SessionManager.UserId = Convert.ToInt32(reader["user_id"]);
                                SessionManager.Email = reader["email"].ToString();
                                SessionManager.Role = reader["role"].ToString();
                                SessionManager.IsVerified = Convert.ToBoolean(reader["is_verified"]);

                                
                                if (!SessionManager.IsVerified)
                                {
                                    MessageBox.Show("Account not verified. Please check your email.", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                               
                                MessageBox.Show($"Welcome!: {SessionManager.Role}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                               
                                if (SessionManager.Role == "admin")
                                {
                                    new Admin().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    new Homepage().Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = ChkShowPassword.Checked ? '\0' : '*';
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            // Close Login if it's open
            if (loginFormInstance != null && !loginFormInstance.IsDisposed)
            {
                loginFormInstance.Close();
                loginFormInstance = null;
            }

            if (signupFormInstance == null || signupFormInstance.IsDisposed)
            {
                signupFormInstance = new SignUp();
                signupFormInstance.FormClosed += (s, args) => signupFormInstance = null;
                signupFormInstance.Show();
            }
            else
            {
                signupFormInstance.BringToFront();
                signupFormInstance.Focus();
            }


            this.Hide();
        }
    }
}
