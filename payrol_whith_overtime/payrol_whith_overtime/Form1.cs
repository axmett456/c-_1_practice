using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrol_whith_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
{
    double hoursWorked, hourlyPayRate, grossPay;

    // Check validation
    if (txthours.Text == "")
    {
        MessageBox.Show("Please enter hours worked.");
    }
    else
    {
        if (txtrate.Text == "")
        {
            MessageBox.Show("Please enter hourly pay rate.");
        }
        else
        {
            hoursWorked = double.Parse(txthours.Text);
            hourlyPayRate = double.Parse(txtrate.Text);

            // Check negative values
            if (hoursWorked < 0 || hourlyPayRate < 0)
            {
                MessageBox.Show("Please enter positive numbers.");
            }
            else
            {
                // Overtime calculation
                if (hoursWorked <= 40)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    grossPay = (40 * hourlyPayRate) +
                               ((hoursWorked - 40) * hourlyPayRate * 1.5);
                }

               lblgrosspay.Text = grossPay.ToString("C2");
            }
        }
    }
}
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthours.Clear();
            txtrate.Clear();
            lblgrosspay.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
