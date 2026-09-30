using System;
using System.Windows.Forms;

namespace assignment_
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
                string food_1_name = txtfood1name.Text;
                double food_1_price = double.Parse(txtFood1Price.Text);
                string food_2_name = txtfoodtwoname.Text;
                double food_2_price = double.Parse(txtFood2Price.Text);

                // taxt constant variable
                double tax = 7;

                // calculate sum
                double sum = food_1_price + food_2_price;

                // calculate tax
                double taxAmount = (sum * tax) / 100;

                //calculate total 
                double total = sum + taxAmount;

                
                // Display results
                lblTaxAmount.Text = taxAmount.ToString("F2");
                lblTotalAmount.Text = total.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("enter valid data");
            }
        }
    }
}
