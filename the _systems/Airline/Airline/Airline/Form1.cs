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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtTickets.Clear();
            txtBaggage.Clear();
            rdoNormal.Checked = true;
            chkInsurance.Checked = false;
            lstResults.Items.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Nadiifi natiijadii hore
                lstResults.Items.Clear();

                // 1. Validation iyadoo la isticmaalayo TryParse
                string passengerName = txtName.Text.Trim();
                if (string.IsNullOrEmpty(passengerName))
                {
                    MessageBox.Show("Fadlan geli magaca rakaabka!", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 100)
                {
                    MessageBox.Show("Da'da rakaabku waa inay u dhaxaysaa 1 iyo 100 sano!", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtTickets.Text, out int tickets) || tickets < 1 || tickets > 5)
                {
                    MessageBox.Show("Tirada tikidhada waa inay u dhaxaysaa 1 iyo 5!", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtBaggage.Text, out double baggageWeight) || baggageWeight < 0 || baggageWeight > (50 * tickets))
                {
                    MessageBox.Show("Miisaanka shandaduhu ma aha inay ka yaraadaan 0 ama ka bataan 50kg qof walba!", "Khalad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Xeerarka gaarka ah (Booking Rules)
                bool bookingApproved = true;
                string rejectionReason = "";

                // Carruurta da'doodu ka hoosayso 12 ma qabsan karaan First Class
                if (age < 12 && rdoFirst.Checked)
                {
                    bookingApproved = false;
                    rejectionReason = "Rakaabka da'doodu ka hoosayso 12 sano ma geli karaan First Class.";
                }

                // Haddii diidmo jirto
                if (!bookingApproved)
                {
                    lstResults.Items.Add("=== AIRLINE BOOKING DETAILS ===");
                    lstResults.Items.Add("Passenger Name : " + passengerName);
                    lstResults.Items.Add("Booking Status : REJECTED ");
                    lstResults.Items.Add("Reason         : " + rejectionReason);
                    return;
                }

                // 3. Qiimaha Tikidhada (Ticket Prices iyadoo la adeegsanayo Switch ama If-Else)
                double ticketPrice = 0;
                string travelClass = "";

                if (rdoFirst.Checked)
                {
                    ticketPrice = 350.0;
                    travelClass = "First Class";
                }
                else if (rdoBusiness.Checked)
                {
                    ticketPrice = 220.0;
                    travelClass = "Business Class";
                }
                else if (rdoNormal.Checked)
                {
                    ticketPrice = 120.0;
                    travelClass = "Normal Class";
                }

                // Xisaabinta Basic Ticket Cost
                double basicCost = ticketPrice * tickets;

                // 4. Qiimo dhimisyada iyo kharashyada dheeraadka ah (Discounts & Surcharges)
                double ticketDiscount = 0.0;
                if (tickets >= 1 && tickets <= 2)
                {
                    ticketDiscount = 0;
                }
                else if (tickets >= 3 && tickets <= 4)
                {
                    ticketDiscount = basicCost * 0.05; // 5% discount
                }
                else if (tickets == 5)
                {
                    ticketDiscount = basicCost * 0.10; // 10% discount
                }

                // Da'da ku salaysan qiimo dhimis
                double ageDiscount = 0.0;
                if (age < 12)
                {
                    ageDiscount = basicCost * 0.20; // 20% child discount
                }
                else if (age >= 60)
                {
                    ageDiscount = basicCost * 0.10; // 10% senior discount
                }

                // Caymiska Safarka (Travel Insurance: $25 per ticket)
                double insuranceCost = 0.0;
                if (chkInsurance.Checked)
                {
                    insuranceCost = 25.0 * tickets;
                }

                // Miisaanka shandadaha (Baggage up to 20kg per passenger is free, excess $2 per kg)
                double excessBaggageCost = 0.0;
                double freeAllowance = 20.0 * tickets;
                if (baggageWeight > freeAllowance)
                {
                    double excessKg = baggageWeight - freeAllowance;
                    excessBaggageCost = excessKg * 2.0;
                }

                // Wadarta Guud (Final Cost Calculation)
                double totalDiscount = ticketDiscount + ageDiscount;
                double finalCost = (basicCost - totalDiscount) + insuranceCost + excessBaggageCost;

                // 5. Soo bandhigida Natiijada (Displaying in ListBox)
                lstResults.Items.Add("=== AIRLINE BOOKING DETAILS ===");
                lstResults.Items.Add("Passenger Name     : " + passengerName);
                lstResults.Items.Add("Passenger Age      : " + age);
                lstResults.Items.Add("Travel Class       : " + travelClass);
                lstResults.Items.Add("Number of Tickets  : " + tickets);
                lstResults.Items.Add("Baggage Weight     : " + baggageWeight + " kg");
                lstResults.Items.Add("----------------------------------------");
                lstResults.Items.Add("Basic Ticket Cost  : $" + basicCost.ToString("F2"));
                lstResults.Items.Add("Ticket Discount    : -$" + ticketDiscount.ToString("F2"));
                lstResults.Items.Add("Age Discount       : -$" + ageDiscount.ToString("F2"));
                lstResults.Items.Add("Insurance Cost     : +$" + insuranceCost.ToString("F2"));
                lstResults.Items.Add("Excess Baggage Fee : +$" + excessBaggageCost.ToString("F2"));
                lstResults.Items.Add("----------------------------------------");
                lstResults.Items.Add("Final Total Cost   : $" + finalCost.ToString("F2"));
                lstResults.Items.Add("Booking Status     : APPROVED ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}