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
    public partial class SearchFlight : Form
    {
        public SearchFlight()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTrip.SelectedItem.ToString() == "Round-trip")
            {
                LblReturn.Visible = true;
                DTPReturn.Visible = true; // Show the return date DateTimePicker
            }
            else
            {
                LblReturn.Visible = false;
                DTPReturn.Visible = false; // Hide the return date DateTimePicker
            }

            
        }

        // Populating the ComboBox with sample dates (You can populate with actual dates from a database or range)
        private void PopulateDates()
        {
            // Set the minimum and maximum date range for the destination and return DateTimePickers
            DTPDepart.MinDate = DateTime.Now;
            DTPDepart.MaxDate = DateTime.Now.AddMonths(6);

            DTPReturn.MinDate = DateTime.Now;
            DTPReturn.MaxDate = DateTime.Now.AddMonths(6);

            // Optionally, you can set default selected date for both DateTimePickers
            DTPDepart.Value = DateTime.Now;
            DTPReturn.Value = DateTime.Now;
        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {
            CmbTrip.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAdults.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbChildren.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbInfant.DropDownStyle = ComboBoxStyle.DropDownList;

            

            PopulateDates();
        }

        private void Pet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
