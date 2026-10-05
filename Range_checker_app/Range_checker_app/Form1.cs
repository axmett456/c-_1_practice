using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_checker_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try { 
          
            int number;

            if (txtnumber.Text == "")
            {
                MessageBox.Show("Please enter a number.");
            }
            else
            {
                number = int.Parse(txtnumber.Text);

                if (number >= 1 && number <= 10)
                {
                   lbldecision.Text = "The number is in the range.";
                }
                else
                {
                    lbldecision.Text = "The number is outside the range.";
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
            txtnumber.Clear();
            lbldecision.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
