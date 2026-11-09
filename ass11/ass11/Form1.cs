using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ass11
{
    public partial class Form1 : Form
    {
        private const string FilePath = "student_data.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form on load
            ClearForm();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    string studentId = txtStudentID.Text;
                    string studentName = txtStudentName.Text;
                    string department = txtDepartment.Text;
                    string mark = txtMark.Text;
                    string studentType = rbUndergraduate.Checked ? "Undergraduate" : "Postgraduate";

                    string studentRecord = $"{studentId}|{studentName}|{department}|{mark}|{studentType}";

                    using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.UTF8))
                    {
                        writer.WriteLine(studentRecord);
                    }

                    MessageBox.Show("Student information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    MessageBox.Show("No saved student records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string allRecords = "";
                using (StreamReader reader = new StreamReader(FilePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        allRecords += line + Environment.NewLine;
                    }
                }

                txtSavedStudentInfo.Text = allRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidateInput()
        {
            // Validate Student ID
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please enter Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return false;
            }

            // Validate Student Name
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter Student Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }

            // Validate Department
            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Please enter Department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartment.Focus();
                return false;
            }

            // Validate Mark
            if (string.IsNullOrWhiteSpace(txtMark.Text))
            {
                MessageBox.Show("Please enter Mark.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMark.Focus();
                return false;
            }

            if (!int.TryParse(txtMark.Text, out int mark) || mark < 0)
            {
                MessageBox.Show("Mark must be a non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMark.Focus();
                return false;
            }

            // Validate Student Type
            if (!rbUndergraduate.Checked && !rbPostgraduate.Checked)
            {
                MessageBox.Show("Please select a Student Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtDepartment.Clear();
            txtMark.Clear();
            txtSavedStudentInfo.Clear();
            rbUndergraduate.Checked = true;
            txtStudentID.Focus();
        }
    }
}
