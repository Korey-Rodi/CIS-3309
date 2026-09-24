using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classexampledemolab4
{
    public partial class Form1 : Form
    {
        private void Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                TextBox textBox2 = new TextBox();
                textBox2.Location = new System.Drawing.Point(250, 200 + i * 40);
                textBox2.Size = new System.Drawing.Size(200, 20);
                textBox2.BackColor = Color.Aqua;
                textBox2.Text = "Dynamic TextBox";
                this.Controls.Add(textBox2);
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            String selectedItem = cb.SelectedItem.ToString();

            MessageBox.Show("You have chosen the item = '" + selectedItem + "'");

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a Dynamic TextBox
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(250, 20);
            textBox.BackColor = System.Drawing.Color.DarkCyan;
            textBox.Size = new System.Drawing.Size(200, 20);
            textBox.Text = "Dynamic TextBox";
            this.Controls.Add(textBox);


            // Create a Dynamic Button
            Button button = new Button();
            button.Location = new System.Drawing.Point(250, 60);
            button.Size = new System.Drawing.Size(200, 30);
            button.BackColor = Color.Aqua;
            button.Text = "OK";
            this.Controls.Add(button);

            //Add Event Handler (Button Click) to the Control
            button.Click += new EventHandler(Button_Click);

            // Create a combo box
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new System.Drawing.Point(250, 120);
            comboBox.Size = new System.Drawing.Size(200, 20);
            comboBox.Items.Add("Phillies");
            comboBox.Items.Add("Eagles");
            comboBox.Items.Add("Sixers");
            comboBox.Items.Add("Flyers");
            comboBox.Items.Add("Union");
            this.Controls.Add(comboBox);

            //Add an Event Handler (Button MessageBox) to the control
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;


            // Create a Dynamic ListBox 
            ListBox listBox = new ListBox();
            listBox.Location = new System.Drawing.Point(250, 160);
            listBox.Size = new System.Drawing.Size(200, 60);
            listBox.BackColor = Color.Aqua;
            this.Controls.Add(listBox);
        }
    }
}
