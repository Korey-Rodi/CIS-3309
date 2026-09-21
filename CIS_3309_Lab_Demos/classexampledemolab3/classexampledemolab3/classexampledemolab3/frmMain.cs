using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classexampledemolab3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
        }

        private void btnNonModal_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
        }
    }
}
