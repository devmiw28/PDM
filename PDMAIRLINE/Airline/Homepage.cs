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

            // Attach the Paint event to redraw the image
            pnlDestination1.Paint += Panel1_Paint;
            pnlDestination2.Paint += Panel1_Paint;
            pnlDestination3.Paint += Panel1_Paint;
            pnlDestination4.Paint += Panel1_Paint;
          
            // Start the timer
            Timer timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadCurrentImage();
            pnlDestination1.Invalidate(); // Force the panel to repaint
            pnlDestination2.Invalidate();
            pnlDestination3.Invalidate();
            pnlDestination4.Invalidate(); // Force the panel to repaint

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

        // Paint event to draw the image on the panel
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (currentImage != null)
            {
                e.Graphics.DrawImage(currentImage, new Rectangle(0, 0, pnlDestination1.Width, pnlDestination1.Height));
            }
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
            this.Close();
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
            SearchFlight searchflight = new SearchFlight();
            searchflight.FormClosed += (s, args) => this.Show();
            searchflight.Show();

            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchFlight searchflight = new SearchFlight();
            searchflight.FormClosed += (s, args) => this.Show();
            searchflight.Show();

            this.Hide();
        }

        private void BookNow3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchFlight searchflight = new SearchFlight();
            searchflight.FormClosed += (s, args) => this.Show();
            searchflight.Show();

            this.Hide();
        }

        private void BookNow4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchFlight searchflight = new SearchFlight();
            searchflight.FormClosed += (s, args) => this.Show();
            searchflight.Show();

            this.Hide();
        }
    }
}
