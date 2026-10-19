using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Nadiifi natiijadii hore
                lstResults.Items.Clear();

                // 1. Validation iyadoo la adeegsanayo TryParse iyo xeerarka shuruudaha
                string guestName = txtName.Text.Trim();
                if (string.IsNullOrEmpty(guestName))
                {
                    MessageBox.Show("Guest Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtAge.Text, out int guestAge) || guestAge < 18 || guestAge > 90)
                {
                    MessageBox.Show("Guest age must be between 18 and 90[cite: 1]!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtNights.Text, out int nights) || nights < 1 || nights > 30)
                {
                    MessageBox.Show("Number of nights must be between 1 and 30[cite: 1]!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtGuests.Text, out int guests) || guests < 1 || guests > 6)
                {
                    MessageBox.Show("Number of guests must be between 1 and 6[cite: 1]!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Xeerarka qaadaadhiga qolalka (Room Capacity Rules)
                string roomType = "";
                double ratePerNight = 0;
                bool bookingApproved = true;
                string rejectionReason = "";

                if (rdoStandard.Checked)
                {
                    roomType = "Standard";
                    ratePerNight = 50.0; // Standard room rate: $50[cite: 1]
                    if (guests > 2)
                    {
                        bookingApproved = false;
                        rejectionReason = "Standard rooms can accommodate a maximum of 2 guests[cite: 1].";
                    }
                }
                else if (rdoNormal.Checked)
                {
                    roomType = "Normal";
                    ratePerNight = 80.0; // Normal room rate: $80[cite: 1]
                    if (guests > 4) // Tusaale ahaan Normal/Deluxe waxay qaadaa ilaa 4
                    {
                        bookingApproved = false;
                        rejectionReason = "Normal rooms can accommodate a maximum of 4 guests.";
                    }
                }
                else if (rdoHight.Checked)
                {
                    roomType = "Hight (Suite)";
                    ratePerNight = 130.0; // Hight room rate: $130[cite: 1]
                    if (guests > 6)
                    {
                        bookingApproved = false;
                        rejectionReason = "A Suite can accommodate a maximum of 6 guests[cite: 1].";
                    }
                }

                // Haddii diidmo jirto (bool flag: bookingApproved)
                if (!bookingApproved)
                {
                    lstResults.Items.Add("=== HOTEL BOOKING DETAILS ===");
                    lstResults.Items.Add("Guest Name  : " + guestName);
                    lstResults.Items.Add("Booking Status: REJECTED ");
                    lstResults.Items.Add("Reason      : " + rejectionReason);
                    return;
                }

                // 3. Xisaabinta Qiimaha Aasaasiga ah (Basic Cost)
                double basicCost = ratePerNight * nights;

                // 4. Xeerarka Qiimo dhimisyada iyo Kharashyada (Cost Rules)
                // Disaount-ka qeybta nights-ka
                double nightDiscount = 0.0;
                if (nights >= 1 && nights <= 4)
                {
                    nightDiscount = 0.0; // No discount[cite: 1]
                }
                else if (nights >= 5 && nights <= 9)
                {
                    nightDiscount = basicCost * 0.05; // 5% discount[cite: 1]
                }
                else if (nights >= 10)
                {
                    nightDiscount = basicCost * 0.12; // 12% discount[cite: 1]
                }

                // Quraacda (Breakfast: add $10 per guest per night)[cite: 1]
                double breakfastCost = 0.0;
                if (chkBreakfast.Checked)
                {
                    breakfastCost = 10.0 * guests * nights;
                }

                // Surcharge-ka dadka baxa (More than 4 guests: add a 5% service surcharge)[cite: 1]
                double serviceSurcharge = 0.0;
                if (guests > 4)
                {
                    serviceSurcharge = basicCost * 0.05;
                }

                // Qiimo dhimisyada Waayeelka (Guests aged 60 or above: receive an additional 5% senior discount)[cite: 1]
                double seniorDiscount = 0.0;
                if (guestAge >= 60)
                {
                    seniorDiscount = basicCost * 0.05;
                }

                // Wadarta Guud
                double totalDiscount = nightDiscount + seniorDiscount;
                double finalCost = (basicCost - totalDiscount) + breakfastCost + serviceSurcharge;

                // 5. Soo bandhigida Natiijada (Displaying in Booking Details listbox)
                lstResults.Items.Add("=== HOTEL BOOKING DETAILS ===");
                lstResults.Items.Add("Guest Name      : " + guestName);
                lstResults.Items.Add("Guest Age       : " + guestAge);
                lstResults.Items.Add("Number of Nights: " + nights);
                lstResults.Items.Add("Number of Guests: " + guests);
                lstResults.Items.Add("Room Type       : " + roomType);
                lstResults.Items.Add("----------------------------------------");
                lstResults.Items.Add("Basic Room Cost : $" + basicCost.ToString("F2"));
                lstResults.Items.Add("Night Discount  : -$" + nightDiscount.ToString("F2"));
                if (seniorDiscount > 0)
                    lstResults.Items.Add("Senior Discount : -$" + seniorDiscount.ToString("F2"));
                if (breakfastCost > 0)
                    lstResults.Items.Add("Breakfast Fee   : +$" + breakfastCost.ToString("F2"));
                if (serviceSurcharge > 0)
                    lstResults.Items.Add("Service Surcharge: +$" + serviceSurcharge.ToString("F2"));
                lstResults.Items.Add("----------------------------------------");
                lstResults.Items.Add("Final Total Cost: $" + finalCost.ToString("F2"));
                lstResults.Items.Add("Booking Status  : APPROVED ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
            private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();
            rdoStandard.Checked = true;
            chkBreakfast.Checked = false;
            lstResults.Items.Clear();
            txtName.Focus();
        }

        
            private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    
