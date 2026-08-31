using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Demo
{
    public partial class frmRegristration : Form
    {
        public frmRegristration()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
            // this is a comment in the code
            lblDisplayArea.Text = txtUserInput.Text;
        }
    }
}
