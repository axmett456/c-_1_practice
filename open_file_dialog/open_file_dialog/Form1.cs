using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace open_file_dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reading  the file

            // import class

            StreamReader Reads;

            DialogResult Result;

            Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                // reading the file - reading the file 

                Reads = File.OpenText("C:\\Users\\Ahmed\\Downloads\\Assignment_3.txt");

                // process the file -
                string lines;

                //check the file is end 
                while(Reads.EndOfStream == false)
                {
                    lines = Reads.ReadLine();
                    listBox1.Items.Add(lines);
                    
                 }

                Reads.Close();



            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("not open the file ");





            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1 .Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // example of saving files with append functionality
            // import

            StreamWriter writes;

            DialogResult result;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";

            result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // open the file for appending (not replacing)
                // This keeps the existing content and adds new data
                writes = File.AppendText(saveFileDialog.FileName);

                // process the file - writing the file 
                writes.WriteLine("fasalkaan hadaa waxbaraneynin iska bax");
                writes.WriteLine("fasalkaan waxaa laga rabaa dad wax baranaayo");

                //close
                writes.Close();

                MessageBox.Show("File saved successfully. New data added to existing content.");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("canceled");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}