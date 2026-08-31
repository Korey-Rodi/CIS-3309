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
            String userName = txtUserInput.Text;
            String state = ddlStateOfResidence.SelectedItem.ToString();
            //SelectedItems is used for multi select list box
            lblDisplayArea.Text = "Hello, you entered " + userName + 
                " and chose the state " + state;

            // Car Car = new Car();

            // Car.Make = "Benz";
            // String theMake = Car.Make;

        }

        private void lblDisplayArea_MouseEnter(object sender, EventArgs e)
        {
            lblDisplayArea.BackColor = Color.Aquamarine;
        }

        private void lblDisplayArea_MouseLeave(object sender, EventArgs e)
        {
            lblDisplayArea.BackColor = Color.LawnGreen;
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Text Changed '"+ txtUserInput.Text + " ' ");
        }
        private void MyHandler(object sender, EventArgs e)
        {
            MessageBox.Show("You selceted from the list: " + ddlStateOfResidence.SelectedItem.ToString());
        }
    }
}
