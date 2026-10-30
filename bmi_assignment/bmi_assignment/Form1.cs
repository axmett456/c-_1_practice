using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, height;

                if (!double.TryParse(txtWeight.Text, out weight) ||
                    !double.TryParse(txtHeight.Text, out height))
                {
                    MessageBox.Show("Invalid Input! Enter numbers only.");
                    return;
                }

                if (weight <= 0 || height <= 0)
                {
                    MessageBox.Show("Weight and height must be greater than zero.");
                    return;
                }

                double bmi = weight / (height * height);
                string category;

                if (bmi < 18.5)
                {
                    category = "Underweight";
                }
                else if (bmi <= 25)
                {
                    category = "Optimal weight";
                }
                else
                {
                    category = "Overweight";
                }

                LSTRESULT.Items.Clear();
                LSTRESULT.Items.Add("BMI RESULTS");
                LSTRESULT.Items.Add("--------------------");
                LSTRESULT.Items.Add("Weight: " + weight + " kg");
                LSTRESULT.Items.Add("Height: " + height + " m");
                LSTRESULT.Items.Add("BMI: " + bmi.ToString("0.00"));
                LSTRESULT.Items.Add("Category: " + category);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            LSTRESULT.Items.Clear();

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
