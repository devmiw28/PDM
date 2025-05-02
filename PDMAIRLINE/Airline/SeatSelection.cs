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

       


    }
}
