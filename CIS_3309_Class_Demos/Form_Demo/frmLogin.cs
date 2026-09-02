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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmRegristration newForm = new frmRegristration();
           // newForm.Show(); // This makes it so you can work with multiple forms at the same time
            newForm.ShowDialog(); // This makes it so they have to deal with the new form before going back to the old one
            //this.Close(); // This references this form in that we are in
            //MessageBox.Show("Exiting the butLogin_Click Event!");
            lblMessage.Text = "Retrieved from frm registration name = " + newForm.txtUserInput.Text;
        }
    }
}
