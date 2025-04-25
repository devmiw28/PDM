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
    public partial class TimeSearching : Form
    {
        

        public TimeSearching()
        {
            InitializeComponent();
        }
        
        private void btnProceed_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you already signed in?", "Sign In Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { 
                BookingSummary summary = Application.OpenForms.OfType<BookingSummary>().FirstOrDefault();

            }
            else
            {
                SignUp signUp = Application.OpenForms.OfType<SignUp>().FirstOrDefault();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
