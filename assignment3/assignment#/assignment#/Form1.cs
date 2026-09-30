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
                // Check if Food 1 Price is empty
                if (string.IsNullOrWhiteSpace(txtFood1Price.Text))
                {
                    MessageBox.Show("Please enter a price for Food 1.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFood1Price.Focus();
                    return;
                }

                // Check if Food 2 Price is empty
                if (string.IsNullOrWhiteSpace(txtFood2Price.Text))
                {
                    MessageBox.Show("Please enter a price for Food 2.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFood2Price.Focus();
                    return;
                }

                // Validate Food 1 price
                if (!decimal.TryParse(txtFood1Price.Text, out decimal food1Price))
                {
                    MessageBox.Show("Please enter a valid numeric value for Food 1 price.\nExample: 10.00", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFood1Price.Clear();
                    txtFood1Price.Focus();
                    return;
                }

                // Validate Food 2 price
                if (!decimal.TryParse(txtFood2Price.Text, out decimal food2Price))
                {
                    MessageBox.Show("Please enter a valid numeric value for Food 2 price.\nExample: 15.00", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFood2Price.Clear();
                    txtFood2Price.Focus();
                    return;
                }

                // Check for negative values
                if (food1Price < 0)
                {
                    MessageBox.Show("Food 1 price cannot be negative.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFood1Price.Clear();
                    txtFood1Price.Focus();
                    return;
                }

                if (food2Price < 0)
                {
                    MessageBox.Show("Food 2 price cannot be negative.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFood2Price.Clear();
                    txtFood2Price.Focus();
                    return;
                }

                // Check if at least one food item has a price
                if (food1Price == 0 && food2Price == 0)
                {
                    MessageBox.Show("At least one food item must have a price greater than $0.00.", "Invalid Total", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFood1Price.Focus();
                    return;
                }

                // Calculate subtotal (food1 + food2)
                decimal subtotal = food1Price + food2Price;

                // Calculate tax (7% of subtotal)
                decimal taxAmount = subtotal * 0.07m;

                // Calculate total (subtotal + tax only, no tip)
                decimal totalAmount = subtotal + taxAmount;

                // Display results
                lblTaxAmount.Text = taxAmount.ToString("F2");
                lblTotalAmount.Text = totalAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
