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
            newForm.MyOwnerForm = this;
            // newForm.Show(); // This makes it so you can work with multiple forms at the same time
            //newForm.lblDisplayArea.Text = "Do you see this";
            newForm.lblDisplayArea.Text = GlobalSharedData.theCar.Make;
            newForm.ShowDialog(); // This makes it so they have to deal with the new form before going back to the old one
            //this.Close(); // This references this form in that we are in
            //MessageBox.Show("Exiting the butLogin_Click Event!")
            lblMessage.Text = "Retrieved from frm registration name = " + newForm.txtUserInput.Text;
            newForm.lblDisplayArea.Text = GlobalSharedData.theCar.Make;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            GlobalSharedData.theCar.Make = "Benz";
            GlobalSharedData.message = "CIS3309 Login Form Message. You blah blah blah";
        }
    }
}
