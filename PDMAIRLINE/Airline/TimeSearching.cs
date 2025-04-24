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
        private List<Button> flightButtons = new List<Button>();
        private List<Button> dayButtons = new List<Button>();
        private DateTime startDate = DateTime.Today;

        public TimeSearching()
        {
            InitializeComponent();
        }

        private void TimeSearching_Load(object sender, EventArgs e)
        {
            // Add day buttons (ensure they exist on the form)
            dayButtons.AddRange(new[] { btnSun, btnMon, btnTue, btnWed, btnThu, btnFri, btnSat });

            InitializeWeekButtons();

            LoadFlightsForDate(startDate); // Load today by default
        }

        private void InitializeWeekButtons()
        {
            for (int i = 0; i < 7; i++)
            {
                DateTime day = startDate.AddDays(i);
                dayButtons[i].Text = day.ToString("ddd dd MMM"); // e.g., Sun 21 Apr
                int index = i;
                dayButtons[i].Click += (s, ev) => LoadFlightsForDate(startDate.AddDays(index));
            }
        }

        private void LoadFlightsForDate(DateTime date)
        {
            // Add flight buttons (ensure they exist on the form)
            flightButtons.Clear();
            flightButtons.AddRange(new[]
            {
                btnFlight1, btnFlight2, btnFlight3,
                btnFlight4, btnFlight5, btnFlight6,
                btnFlight7, btnFlight8, btnFlight9
            });

            Random rnd = new Random(date.Day); // Use date as seed for consistent randomness
            string[] locations = { "Marilao", "Cebu", "Davao", "Iloilo", "Palawan" };

            for (int i = 0; i < flightButtons.Count; i++)
            {
                string from = locations[rnd.Next(locations.Length)];
                string to = locations[rnd.Next(locations.Length)];
                while (to == from)
                    to = locations[rnd.Next(locations.Length)];

                TimeSpan departTime = TimeSpan.FromHours(rnd.Next(0, 24));
                TimeSpan flightDuration = TimeSpan.FromMinutes(rnd.Next(60, 300)); // 1 to 5 hrs
                TimeSpan arrivalTime = departTime + flightDuration;
                decimal price = rnd.Next(100, 600); // Price in your currency

                flightButtons[i].Text = $"🛫 {from} → {to}\n" +
                                        $"⏰ {departTime:hh\\:mm} - {arrivalTime:hh\\:mm}\n" +
                                        $"🕒 {flightDuration.Hours}h {flightDuration.Minutes}m | 💲{price}";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(-7);
            RefreshWeekView();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(7);
            RefreshWeekView();
        }

        private void RefreshWeekView()
        {
            for (int i = 0; i < dayButtons.Count; i++)
            {
                DateTime day = startDate.AddDays(i);
                dayButtons[i].Text = day.ToString("ddd dd MMM");
                int index = i;
                dayButtons[i].Click += (s, ev) => LoadFlightsForDate(startDate.AddDays(index));
            }

            LoadFlightsForDate(startDate);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnFlight2_Click(object sender, EventArgs e)
        {

        }
    }
}
