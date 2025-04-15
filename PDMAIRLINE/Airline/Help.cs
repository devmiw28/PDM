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
    public partial class Help : Form
    {
        // Sample help topics or reports
        private string[] helpTopics = new string[]
        {
            "How to report a lost luggage",
            "Flight cancellation policy",
            "How to change a flight",
            "Refund process for canceled flights",
            "Contact customer service",
            "How to check flight status",
            "Baggage allowance information",
            "How to book a flight"
        };

        public Help()
        {
            InitializeComponent();
            // Populate the ListBox with help topics
            listBoxResults.Items.AddRange(helpTopics);
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower(); // Get the search term from the TextBox
            listBoxResults.Items.Clear(); // Clear previous results

            // Filter the help topics based on the search term
            var results = helpTopics.Where(topic => topic.ToLower().Contains(searchTerm)).ToArray();

            // Add the filtered results to the ListBox
            listBoxResults.Items.AddRange(results);

            // If no results found, you can optionally show a message
            if (results.Length == 0)
            {
                MessageBox.Show("No help topics found for your search.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {

        }

        private void lblLearnMore_Click(object sender, EventArgs e)
        {

        }

        private void lblHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
