using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_room
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
                // creating our variables
                string room_name = txtGuestName.Text;
                string room_type = txtRoomType.Text;
                double nights = double.Parse(txtNights.Text);
                double price = double.Parse(txtPriceNight.Text);

                

                // calculate sum
                double room_cost = nights * price;

                // calculate tax and discount
      
                double disc = room_cost * 0.05;
                double taxAmount = room_cost * 0.10;



                //calculate total 
                double total = (room_cost*2) + taxAmount - disc;


                // Display results
                lblServiceTax.Text = taxAmount.ToString("F2");
                lblDiscount.Text = disc.ToString("F2");
                lblTotalAmount.Text = total.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("enter valid data");
            }
        }
    }
}
