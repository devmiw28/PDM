using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Homepage : Form
    {
        private static LogIn loginFormInstance;
        private static SignUp signupFormInstance;
        private int currentImageIndex = 0;
        private Image[] images1;
        private Image[] images2;
        private Image[] images3;
        private Image[] images4;

        private string[] imagePaths = new string[]
        {
    @"PDM/PDMAIRLINE/destination/DAVAO1.png",
    @"C:\Users\Student\Downloads\new3\NEW\destination\DAVAO2.png",
    @"C:\Users\Student\Downloads\new3\NEW\destination\DAVAO3.png"
        };


        private Image currentImage;

        public Homepage()
        {
            InitializeComponent();

            // Load the first image
            LoadCurrentImage();


            images1 = new Image[]
            {
                Properties.Resources.DAVAO1,
                Properties.Resources.DAVAO2,
                Properties.Resources.DAVAO3,
            };

            images2 = new Image[]
            {
                Properties.Resources.CEBU1,
                Properties.Resources.CEBU2,
                Properties.Resources.CEBU3,
            };

            images3 = new Image[]
            {
                Properties.Resources.PALAWAN1,
                Properties.Resources.PALAWAN2,
                Properties.Resources.PALAWAN3,
            };

            images4 = new Image[]
            {
                Properties.Resources.ILOILO1,
                Properties.Resources.ILOILO2,
                Properties.Resources.ILOILO3,
            };

            PbDestination1.SizeMode = PictureBoxSizeMode.StretchImage;
            PbDestination1.Image = images1[currentImageIndex];

            PbDestination2.SizeMode = PictureBoxSizeMode.StretchImage;
            PbDestination2.Image = images2[currentImageIndex];

            PbDestination3.SizeMode = PictureBoxSizeMode.StretchImage;
            PbDestination3.Image = images3[currentImageIndex];

            PbDestination4.SizeMode = PictureBoxSizeMode.StretchImage;
            PbDestination4.Image = images4[currentImageIndex];

            timer1.Interval = 3000;
            timer1.Start();
        }



        private void LoadCurrentImage()
        {
            try
            {
                if (System.IO.File.Exists(imagePaths[currentImageIndex]))
                {
                    currentImage = Image.FromFile(imagePaths[currentImageIndex]);
                }
                else
                {
                    currentImage = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                currentImage = null;
            }

            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDestination2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDestination3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            if (signupFormInstance != null && !signupFormInstance.IsDisposed)
            {
                signupFormInstance.Close();
                signupFormInstance = null;
            }

            if (loginFormInstance == null || loginFormInstance.IsDisposed)
            {
                loginFormInstance = new LogIn();
                loginFormInstance.FormClosed += (s, args) => loginFormInstance = null; // Reset after closing
                loginFormInstance.Show();
            }
            else
            {
                loginFormInstance.BringToFront();
                loginFormInstance.Focus();
            }
            //LogIn form2 = new LogIn();
            // form2.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
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
            //SignUp form3 = new SignUp();
            //form3.Show();
        }

        private void lblLearnMore_Click(object sender, EventArgs e)
        {
            LearnMore learnmore = new LearnMore();
            learnmore.FormClosed += (s, args) => this.Show();
            learnmore.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlDestination1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblContactUs_Click(object sender, EventArgs e)
        {
            
            Help help = new Help();
            help.FormClosed += (s, args) => this.Show();
            help.Show();
            
            
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if SearchFlight form is already open
             SearchFlight searchFlight = Application.OpenForms.OfType<SearchFlight>().FirstOrDefault();

             if (searchFlight == null || searchFlight.IsDisposed)
             {
                 // If not open, create a new instance of SearchFlight
                 searchFlight = new SearchFlight();
                 searchFlight.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                 searchFlight.Show();
             }
             else
             {
                 // If already open, bring it to the front
                 searchFlight.BringToFront();
                 searchFlight.Focus();
             }

             // Pass "Davao" to SearchFlight form to set ComboBox1
             searchFlight.SetComboBoxes("Marilao   MRL", "Davao   DVO");
             

            this.Hide(); // Optionally hide the Homepage when navigating to SearchFlight
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if SearchFlight form is already open
            SearchFlight searchFlight = Application.OpenForms.OfType<SearchFlight>().FirstOrDefault();

            if (searchFlight == null || searchFlight.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                searchFlight = new SearchFlight();
                searchFlight.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                searchFlight.Show();
            }
            else
            {
                // If already open, bring it to the front
                searchFlight.BringToFront();
                searchFlight.Focus();
            }

            // Pass "Davao" to SearchFlight form to set ComboBox1
            searchFlight.SetComboBoxes("Marilao   MRL", "Cebu   CEB");


            this.Hide(); // Optionally hide the Homepage when navigating to SearchFlight
        }

        private void BookNow3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if SearchFlight form is already open
            SearchFlight searchFlight = Application.OpenForms.OfType<SearchFlight>().FirstOrDefault();

            if (searchFlight == null || searchFlight.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                searchFlight = new SearchFlight();
                searchFlight.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                searchFlight.Show();
            }
            else
            {
                // If already open, bring it to the front
                searchFlight.BringToFront();
                searchFlight.Focus();
            }

            // Pass "Davao" to SearchFlight form to set ComboBox1
            searchFlight.SetComboBoxes("Marilao   MRL", "Palawan   PAL");


            this.Hide(); // Optionally hide the Homepage when navigating to SearchFlight
        }

        private void BookNow4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if SearchFlight form is already open
            SearchFlight searchFlight = Application.OpenForms.OfType<SearchFlight>().FirstOrDefault();

            if (searchFlight == null || searchFlight.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                searchFlight = new SearchFlight();
                searchFlight.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                searchFlight.Show();
            }
            else
            {
                // If already open, bring it to the front
                searchFlight.BringToFront();
                searchFlight.Focus();
            }

            // Pass "Davao" to SearchFlight form to set ComboBox1
            searchFlight.SetComboBoxes("Marilao   MRL", "Iloilo   ILO");


            this.Hide(); // Optionally hide the Homepage when navigating to SearchFlight
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images1.Length;
            currentImageIndex = (currentImageIndex + 1) % images2.Length;
            currentImageIndex = (currentImageIndex + 1) % images3.Length;
            currentImageIndex = (currentImageIndex + 1) % images4.Length;

            PbDestination1.Image = images1[currentImageIndex];
            PbDestination2.Image = images2[currentImageIndex];
            PbDestination3.Image = images3[currentImageIndex];
            PbDestination4.Image = images4[currentImageIndex];
        }

        private void PbDestination2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void PbDestination1_Click(object sender, EventArgs e)
        {

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