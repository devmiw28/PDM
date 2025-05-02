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
    public partial class SeatSelection : Form
    {




        public SeatSelection()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            BookingSummary bookingsummary = Application.OpenForms.OfType<BookingSummary>().FirstOrDefault();

            if (bookingsummary == null || bookingsummary.IsDisposed)
            {
                // If not open, create a new instance of SearchFlight
                bookingsummary = new BookingSummary();
                bookingsummary.FormClosed += (s, args) => this.Show(); // When SearchFlight is closed, show Homepage again
                bookingsummary.Show();
            }
            else
            {
                // If already open, bring it to the front
                bookingsummary.BringToFront();
                bookingsummary.Focus();
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbFlightClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFlightClass.SelectedItem == null) return;

            string selectedClass = cmbFlightClass.SelectedItem.ToString();

            foreach (Control ctrl in panelSeats.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox seatCheckbox = (CheckBox)ctrl;
                    string seatName = seatCheckbox.Name;

                    if (seatName.StartsWith("chk") && seatName.Length >= 5)
                    {
                        string seatLabel = seatName.Substring(3);
                        string rowStr = seatLabel.Substring(1);

                        int rowNumber;

                        if (int.TryParse(rowStr, out rowNumber))
                        {
                            switch (selectedClass)
                            {
                                case "First Class":
                                    seatCheckbox.Enabled = (rowNumber >= 1 && rowNumber <= 3);
                                    break;

                                case "Business Class":
                                    seatCheckbox.Enabled = (rowNumber >= 4 && rowNumber <= 10);
                                    break;

                                case "Economy Class":
                                    seatCheckbox.Enabled = (rowNumber >= 11 && rowNumber <= 22);
                                    break;
                            }

                            seatCheckbox.BackColor = seatCheckbox.Enabled ? Color.White : Color.LightGray;
                        }
                    }
                }
            }
        }

        private void chkA1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkA9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkB9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkD4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkE4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkF1_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
