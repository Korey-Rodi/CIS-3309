using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandwichBuilder
{
    public partial class frmSandwichBuilder : Form
    {
        public frmSandwichBuilder()
        {
            InitializeComponent();
        }

        private void cbxPreMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxPreMade.Text != "Custom")
            {
                gbBread.Visible = false;
                gbCheese.Visible = false;
                gbExtraToppings.Visible = false;
                gbMeats.Visible = false;
                gbToppings.Visible = false;
                gbSauces.Visible = false;
                cbxSize.Visible = false;
                if (cbxPreMade.Text == "Small Love Turkey")
                {
                    lblSandwichDesc.Text = Sandwich.PreMadeSandwiches.preMade[0].Description;
                    pbxSandwichImage.Image = SandwichBuilder.Properties.Resources.Sandwich1;
                }
                else if (cbxPreMade.Text == "Large Hateful Turkey")
                {
                    lblSandwichDesc.Text = Sandwich.PreMadeSandwiches.preMade[1].Description;
                    pbxSandwichImage.Image = SandwichBuilder.Properties.Resources.Sandwich2;
                }
                else if (cbxPreMade.Text == "Party Hateful Turkey")
                {
                    lblSandwichDesc.Text = Sandwich.PreMadeSandwiches.preMade[2].Description;
                    pbxSandwichImage.Image = SandwichBuilder.Properties.Resources.Sandwich3;
                }

            }
            else
            {
                gbBread.Visible = true;
                gbCheese.Visible = true;
                gbExtraToppings.Visible = true;
                gbMeats.Visible = true;
                gbToppings.Visible = true;
                gbSauces.Visible = true;
                cbxSize.Visible = true;
                pbxSandwichImage.Image = SandwichBuilder.Properties.Resources.Logo;
                lblSandwichDesc.Text = "";
            }

        }
        private Sandwich GetPreMade()
        {
            if (cbxPreMade.Text == "Small Love Turkey")
            {
                return Sandwich.PreMadeSandwiches.preMade[0];
            }
            else if (cbxPreMade.Text == "Large Hateful Turkey")
            {
                return Sandwich.PreMadeSandwiches.preMade[1];
            }
            else
            {
                return Sandwich.PreMadeSandwiches.preMade[2];
            }
        
            }
        private Sandwich getCustom()
        {
            String name = "Custom";
            String description = "Custom made sandwich";
            String size = cbxSize.Text;
            String bread = "";
            List<String> sauces = new List<string>();
            List<String> meats = new List<string>();
            List<String> cheese = new List<string>();
            List<String> toppings = new List<string>();
            List<String> premToppings = new List<string>();
            foreach (RadioButton rad in gbBread.Controls.OfType<RadioButton>())
            {
                if (rad.Checked)
                {
                    bread = rad.Text;
                }

            }

            foreach (CheckBox chk in gbSauces.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    sauces.Add(chk.Text);
                }
            }
            foreach (CheckBox chk in gbMeats.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    meats.Add(chk.Text);
                } 
            }
            foreach (CheckBox chk in gbCheese.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    cheese.Add(chk.Text);
                }
            }
            foreach (CheckBox chk in gbToppings.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    toppings.Add(chk.Text);
                }
            }
            foreach (CheckBox chk in gbExtraToppings.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    premToppings.Add(chk.Text);
                }
            }
            Sandwich sandwich = new Sandwich(name, description, size,bread,sauces, meats, cheese, toppings, premToppings);
            return sandwich;
            }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("You need to enter a name for the order");
                return;
            }
            if (txtAddress.Text.Length == 0 && cbxOrderType.Text == "Delivery")
            {
                MessageBox.Show("You need to enter an address");
                return;
            }
            if(cbxOrderType.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select an order type");
                return;
            }
            // This needed to be switched to long to process a full phone number
            long phoneNumber;
            if (!long.TryParse(txtPhone.Text, out phoneNumber))
            {
                MessageBox.Show("You need to enter a valid phone Number");
                return;
            }
            decimal tip = 0.0m;
            if (!decimal.TryParse(txtTip.Text, out tip) || tip < 0)
            {
                tip = 0.0m;
                // If tip is not a decimal or less than 0 set to 0
            }
            if (cbxPreMade.Text == "Custom")
            {
                if (cbxSize.SelectedIndex == -1)
                {
                    MessageBox.Show("You Must enter a size");
                    return;
                }
                //https://www.google.com/search?q=how+to+use+a+break+in+C%23+with+boolean&sca_esv=d35e14188c1eb546&rlz=1C1HKFL_enUS1220US1220&sxsrf=APpeQntUWVOniLNM2_YZI3VLG94zHYZ6Fw%3A1790203276526&ei=jFW0apzRH9fZ5NoP8dKmiAI&biw=1504&bih=834&uact=5&oq=how+to+use+a+break+in+C%23+with+boolean&gs_lp=Egxnd3Mtd2l6LXNlcnAiJWhvdyB0byB1c2UgYSBicmVhayBpbiBDIyB3aXRoIGJvb2xlYW4yBRAhGKABMgUQIRigATIFECEYoAEyBRAhGKABSMUgUJoKWJ4ecAF4AZABAJgBkwGgAcYKqgEDNC45uAEDyAEA-AEBmAIOoAKsC8ICChAAGEcY1gQYsAPCAgYQABgWGB7CAgUQABjvBcICCBAAGIkFGKIEwgIFECEYqwKYAwCIBgGQBgiSBwQzLjExoAfgJ7IHBDIuMTG4B6ILwgcFMC42LjjIBzSACAE&sclient=gws-wiz-serp
                bool breadPicked = false;
                foreach(RadioButton rad in gbBread.Controls.OfType<RadioButton>())
                {
                    if (rad.Checked){
                        breadPicked = true;
                        break;
                    }

                }
                if (breadPicked == false) 
                {
                    MessageBox.Show("You must select a bread");
                    return;
                }
            }

            Customer customer = new Customer(txtName.Text,txtAddress.Text,txtPhone.Text);
            decimal subtotal = 0.0m;
            String orderType = cbxOrderType.Text;
            Sandwich sandwich = null;
            if(cbxPreMade.Text != "Custom")
            {
                sandwich = GetPreMade();
                //subtotal = Sandwich.getTotal(sandwich); moved this code to sandwich bc it involves objects not gui 
                subtotal = sandwich.getTotal();
            } else
            {
              sandwich = getCustom();
              subtotal = sandwich.getTotal();
            }
            decimal total = subtotal + tip;
            Order order = new Order(customer, sandwich, orderType, tip, subtotal,total);

            //https://www.google.com/search?q=passing+object+to+new+form+in+C%23&rlz=1C1HKFL_enUS1220US1220&oq=passing+object+to+new+form+in+C%23&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRigATIHCAIQIRigATIHCAMQIRigATIHCAQQIRigATIHCAUQIRigATIHCAYQIRifBTIHCAcQIRifBTIHCAgQIRifBdIBCDc0MTJqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8
            frmReceipt receipt = new frmReceipt(order);
            receipt.ShowDialog();




            }

    }
}
