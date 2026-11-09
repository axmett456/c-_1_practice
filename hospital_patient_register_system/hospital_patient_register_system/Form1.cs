using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace hospital_patient_register_system
{
    public partial class Form1 : Form
    {
        private List<Patient> patients = new List<Patient>();
        private const string FilePath = "patients.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                int patientId = int.Parse(textBox1.Text);
                string patientName = textBox2.Text;
                int age = int.Parse(textBox3.Text);
                string gender = radioButton1.Checked ? "Male" : "Female";

                Patient patient = new Patient
                {
                    PatientID = patientId,
                    PatientName = patientName,
                    Age = age,
                    Gender = gender
                };

                patients.Add(patient);
                SaveToFile();
                listBox1.Items.Add(patient.ToString());
                MessageBox.Show("Patient registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonClear_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonViewFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    MessageBox.Show("No patient file found yet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                patients.Clear();
                listBox1.Items.Clear();

                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            Patient patient = new Patient
                            {
                                PatientID = int.Parse(parts[0]),
                                PatientName = parts[1],
                                Age = int.Parse(parts[2]),
                                Gender = parts[3]
                            };
                            patients.Add(patient);
                            listBox1.Items.Add(patient.ToString());
                        }
                    }
                }
                MessageBox.Show($"Loaded {patients.Count} patients from file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a patient to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedIndex = listBox1.SelectedIndex;
                patients.RemoveAt(selectedIndex);
                listBox1.Items.RemoveAt(selectedIndex);
                SaveToFile();
                MessageBox.Show("Patient removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            int count = patients.Count;
            labelCount.Text = $"Total Patients: {count}";
            MessageBox.Show($"Total number of patients: {count}", "Patient Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = true;
            textBox1.Focus();
        }

        private void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (Patient patient in patients)
                    {
                        writer.WriteLine($"{patient.PatientID},{patient.PatientName},{patient.Age},{patient.Gender}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter Patient ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }

            if (!int.TryParse(textBox1.Text, out int patientId) || patientId <= 0)
            {
                MessageBox.Show("Patient ID must be a positive number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter Patient Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter Age", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return false;
            }

            if (!int.TryParse(textBox3.Text, out int age) || age <= 0 || age > 150)
            {
                MessageBox.Show("Age must be a valid number between 1 and 150", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return false;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select a gender", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }

    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"ID: {PatientID} | Name: {PatientName} | Age: {Age} | Gender: {Gender}";
        }
    }
}
