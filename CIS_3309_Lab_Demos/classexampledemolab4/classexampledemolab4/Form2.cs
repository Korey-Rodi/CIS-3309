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

namespace classexampledemolab4
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {

            // Specify the filepath 

            string filepath = "Demo.txt";

            // Open the specified file for appending using Streamwriter

            using (StreamWriter writer = File.AppendText(filepath))

            {
                writer.WriteLine(txtOutput.Text);
                txtOutput.Clear();
            }

        }

        private void btnButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                // Note you will have to navigate to this in file explorer, in this case it will be stored
                // project folder/bin/debug/demo.txt
                string filepath = openFileDialog.FileName;
                using (StreamReader reader = File.OpenText(filepath))
                {
                    string filecontents = reader.ReadToEnd();

                    txtOutput.Text = filecontents;
                }

            }
        }
    }
}
