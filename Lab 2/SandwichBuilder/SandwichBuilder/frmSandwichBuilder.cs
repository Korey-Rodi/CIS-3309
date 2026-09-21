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
                    pbxSandwichImage.Image = SandwichBuilder.Properties.Resources.Sandwich1;
                }
                else if (cbxPreMade.Text == "Large Hateful Turkey")
                {
                    pbxSandwichImage.Image = SandwichBuilder.Properties.Resources.Sandwich2;
                }
                else if (cbxPreMade.Text == "Party Hateful Turkey")
                {
                    pbxSandwichImage.Image = SandwichBuilder.Properties.Resources.Sandwich3;
                }

            } else
            {
                gbBread.Visible = true;
                gbCheese.Visible = true;
                gbExtraToppings.Visible = true;
                gbMeats.Visible = true;
                gbToppings.Visible = true;
                gbSauces.Visible = true;
                cbxSize.Visible = true;

            }

        }
        private Sandwich GetPreMade(String sandwich)
        {
            if (cbxPreMade.Text == "Small Love Turkey")
            {
                return Sandwich.PreMadeSandwiches.preMade[0];
            }
            else if (cbxPreMade.Text == "Large Hateful Turkey")
            {
                return Sandwich.PreMadeSandwiches.preMade[1];
            }
            else if (cbxPreMade.Text == "Party Hateful Turkey")
            {
                return Sandwich.PreMadeSandwiches.preMade[2];
            } else
            {
                return null;
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

        private decimal getTotal(Sandwich sandwich)
        {
            Decimal subtotal = 0.0m;
           
            subtotal += Pricing.CostCalculator(Pricing.SizePricing, sandwich.Size);
            subtotal += Pricing.CostCalculator(Pricing.breadPricing, sandwich.Bread);

           
            if (sandwich.Sauces != null)
            {
                foreach (string sauce in sandwich.Sauces)
                {
                    subtotal += Pricing.CostCalculator(Pricing.saucePricing, sauce);
                }
            }

            if (sandwich.Meats != null)
            {
                foreach (string meat in sandwich.Meats)
                {
                    subtotal += Pricing.CostCalculator(Pricing.meatPricing, meat);
                }
            }

            if (sandwich.Cheese != null)
            {
                foreach (string ch in sandwich.Cheese)
                {
                    subtotal += Pricing.CostCalculator(Pricing.cheesePricing, ch);
                }
            }

            if (sandwich.Toppings != null)
            {
                foreach (string top in sandwich.Toppings)
                {
                    subtotal += Pricing.CostCalculator(Pricing.toppingsPricing, top);
                }
            }

            if (sandwich.PremToppings != null)
            {
                foreach (string prem in sandwich.PremToppings)
                {
                    subtotal += Pricing.CostCalculator(Pricing.premToppingsPricing, prem);
                }
            }

            return subtotal;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(txtName.Text,txtAddress.Text,txtPhone.Text);
            decimal subtotal = 0.0m;
            String orderType = cbxOrderType.Text;
            Sandwich sandwich = null;
            if(cbxPreMade.Text != "Custom")
            {
                sandwich = GetPreMade(cbxPreMade.Text);
                subtotal = getTotal(sandwich);
            } else
            {
              sandwich = getCustom();
              subtotal = getTotal(sandwich);
            }
            decimal tip = 0.0m;
            if (!decimal.TryParse(txtTip.Text, out tip) || tip < 0)
            {
                tip = 0.0m;
            }
            decimal total = subtotal + tip;
            Order order = new Order(customer, sandwich, orderType, tip, subtotal,total);

            //https://www.google.com/search?q=passing+object+to+new+form+in+C%23&rlz=1C1HKFL_enUS1220US1220&oq=passing+object+to+new+form+in+C%23&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIHCAEQIRigATIHCAIQIRigATIHCAMQIRigATIHCAQQIRigATIHCAUQIRigATIHCAYQIRifBTIHCAcQIRifBTIHCAgQIRifBdIBCDc0MTJqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8
            frmReceipt receipt = new frmReceipt();
            receipt.lblReceiptInfo.Text = order.ToString();
            receipt.ShowDialog();




            }

    }
}
