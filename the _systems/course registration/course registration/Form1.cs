using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblanemoutput_Click(object sender, EventArgs e)
        {

        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            //
            string name;
            int age;
            int number_of_courses;
            int study_level;
            double transportation_cost;

            if (int.TryParse(txtcourses.Text, out number_of_courses))
            {
                name = txtname.Text;
                age = int.Parse(txtage.Text);
                number_of_courses = int.Parse(txtcourses.Text);
                study_level = int.Parse(txtlevel.Text);
                transportation_cost = double.Parse(txtfee.Text);

                if (number_of_courses >= 1 && number_of_courses <= 8) {
                    
                    // 3
                    double fee_per_course = 0;
                    if (study_level == 1)
                    {
                        fee_per_course = 40;
                    } else if (study_level == 2)
                    {
                        fee_per_course = 45;

                    }
                    else if (study_level == 3)
                    {
                        fee_per_course = 50;

                    }
                    else if (study_level == 4)
                    {
                        fee_per_course = 55;

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid study level of between 1 and 4.");
                    }

                    // 4 =  basic tution calculation
                    double tuition_fee = number_of_courses * fee_per_course;

                    // 5 transportation cost

                    // 6 discount calculation
                    double discount = 0;
                    if (number_of_courses >= 6)
                    {
                        discount = tuition_fee * 0.10; // 10% discount
                    }

                    // calculate final fee
                    double final_fee = tuition_fee + transportation_cost - discount;

                    // display the output
                    lblanemeoutput.Text = "Name: " + name;
                    lblageoutput.Text = "Age: " + age;
                    lblcoursesoutput.Text = "Number of Courses: " + number_of_courses;
                    lblleveloutput.Text = "Study Level: " + study_level;
                    lblfeeoutput.Text = "Transportation Fee: " + transportation_cost;
                    lbldiscountoutput.Text = "Discount: " + discount;
                    lbltutionoutput.Text = "Tution fee: " + tuition_fee;
                    lblfinaloutput.Text = "Final fee: " + final_fee;

                    

                }
                else
                {
                    MessageBox.Show("Please enter a valid number of courses.");
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lblanemeoutput.Text = "";
            lblageoutput.Text = "";
            lblcoursesoutput.Text = "";
            lblleveloutput.Text = "";
            lblfeeoutput.Text = "";
            lbldiscountoutput.Text = "";
            lbltutionoutput.Text = "";
            lblfinaloutput.Text = "";

            txtage.Text = "";
            txtcourses.Text = "";
            txtfee.Text = "";
            txtlevel.Text = "";
            txtname.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
