using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classexampledemolab3part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Owner = this;
            registerForm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string message = "Do You Want To Exit";
            string title = "confirm";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button,
            MessageBoxIcon.Question);
        }
    }
}
