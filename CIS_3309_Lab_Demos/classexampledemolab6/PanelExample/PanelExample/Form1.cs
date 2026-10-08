using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelExample
{
    public partial class Form1 : Form
    {
        Button newButton = new Button();
        TextBox newTextBox = new TextBox();

        Course cis1 = new Course(1, "CIS 1", "Programming in C+");
        Course cis2 = new Course(2, "CIS 2", "Programming in C#");
        Course cis3 = new Course(3, "CIS 3", "Web Design in Dreamweaver");
        Course cis4 = new Course(4, "CIS 4", "Probability and Statistics");
        Course cis5 = new Course(5, "CIS 4", "Calculus 1 & 2");

        Course[] cis = new Course[5];

        public Form1()
        {
            InitializeComponent();
        }
        private void btnText_Click(object sender, EventArgs e)
        {
            cis[0] = cis1;
            cis[1] = cis2;
            cis[2] = cis3;
            cis[3] = cis4;
            cis[4] = cis5;

            // This would be solved by creating the list first and addig every new object to the list and interating through that

            for (int i = 0; i < 5; i++)
            {
                newTextBox.AppendText(cis[i].CourseName);
                newTextBox.AppendText("\r\n");
            }
        }
        private void btnAddControl_Click(object sender, EventArgs e)
        {
            // new button
            newButton.Location = new System.Drawing.Point(20, 20);
            newButton.Name = "btnText";
            newButton.Size = new System.Drawing.Size(140, 50);
            newButton.Text = "Show Roster";
            newButton.UseVisualStyleBackColor = true;
            newButton.BackColor = System.Drawing.Color.Teal;

            newButton.Click += new System.EventHandler(this.btnText_Click);

            this.pnlDemo.Controls.Add(newButton);

            // new textbox
            newTextBox.Location = new System.Drawing.Point(20, 90);
            newTextBox.Name = "txtFile";
            newTextBox.Size = new System.Drawing.Size(300, 450);
            newTextBox.Multiline = true;
            newTextBox.ScrollBars = ScrollBars.Vertical;
            newTextBox.CausesValidation = true;

            this.pnlDemo.Controls.Add(newTextBox);
        }
    private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDemo.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pnlDemo.Visible = true;
        }
        }

    }
