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
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
    @"C:\Users\Student\Downloads\new3\NEW\destination\DAVAO1.png",
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
            LogIn form2 = new LogIn();
            form2.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp form3 = new SignUp();
            form3.Show();
        }

        private void lblLearnMore_Click(object sender, EventArgs e)
        {
            LearnMore form4 = new LearnMore();
            form4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlDestination1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblContactUs_Click(object sender, EventArgs e)
        {
            Help form5 = new Help();
            form5.Show();
        }
    }
}
