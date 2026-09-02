using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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


        }
        // Event handlers can be passed with any object
        private void MyHandler(object sender, EventArgs e) //This can be used to be generic for any textbox
        {
            // Cast the object to a textbox and store it in variable that can hold the textbox
            TextBox theTbox = (TextBox)sender;

            String userInput = theTbox.Text;
            int value = 0;

            if (int.TryParse(userInput, out value) == false)
            {
                lblDisplayArea.Text = "You must enter a valid integer integer for " + theTbox.Name; // This is how you can add the objects name
            }
            else
            {
                lblDisplayArea.Text = " ";
            }
            //MessageBox.Show("MyHandler executed!");
            //lblDisplayArea.Text = "Entered the Handler";
            //MessageBox.Show("You selceted from the list: " + ddlStateOfResidence.SelectedItem.ToString());
        }

// You get the load by clicking on the form
// this loads the event handler at runtime
        private void frmRegristration_Load(object sender, EventArgs e)
        {
            btnProcess.Click += btnProcess_Click;
            txtPassword.TextChanged += txtPassword_TextChanged;

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This runs");
        }
    }

}
