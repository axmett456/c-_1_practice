using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace files_assignment
{
    public partial class Form1 : Form
    {
        string filePath = Path.Combine(
            Application.StartupPath, "items.txt");

        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += button2_Click;

            LoadItems();
        }

        // Button 1: Add Item
        private void button1_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text.Trim();

            if (item == "")
            {
                MessageBox.Show("Please enter an item.");
                return;
            }

            try
            {
                File.AppendAllText(
                    filePath, item + Environment.NewLine);

                textBox1.Clear();
                LoadItems();

                MessageBox.Show("Item added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 2: Delete Item
        private void button2_Click(object sender, EventArgs e)
        {
            string target = textBox1.Text.Trim();

            if (target == "")
            {
                MessageBox.Show("Enter the item to delete.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            try
            {
                string[] items = File.ReadAllLines(filePath);

                string[] updatedItems = items
                    .Where(x => !x.Equals(
                        target,
                        StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                if (items.Length == updatedItems.Length)
                {
                    MessageBox.Show("Item not found.");
                    return;
                }

                File.WriteAllLines(filePath, updatedItems);

                textBox1.Clear();
                LoadItems();

                MessageBox.Show("Item deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 3: Read All Text
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            try
            {
                string content = File.ReadAllText(filePath);

                MessageBox.Show(
                    content == "" ? "File is empty." : content,
                    "Read All Text");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 4: Read All Lines
        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                listBox1.Items.AddRange(lines);

                MessageBox.Show("Read All Lines completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading lines: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load items into ListBox
        private void LoadItems()
        {
            listBox1.Items.Clear();

            try
            {
                if (File.Exists(filePath))
                {
                    listBox1.Items.AddRange(
                        File.ReadAllLines(filePath));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}