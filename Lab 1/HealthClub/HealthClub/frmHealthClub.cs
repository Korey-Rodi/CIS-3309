using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthClub
{
    public partial class frmHealthClub : Form
    {
        public frmHealthClub()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal baseFee = this.BaseMembershipFee();
            int months;
            bool isValidMonth = int.TryParse(txtMonths.Text, out months) && this.CheckMonth(months);

            if (baseFee == 0)
            {
                MessageBox.Show("Please select a membership.");
                return; // This stops the code below it from exectuing
            }

            if (!isValidMonth)
            {
                MessageBox.Show("Please enter a valid month.");
                return; // This stops the code below it from exectuing
            }

            decimal extraFees = this.AdditionalOptionFees();
            decimal monthlyTotal = baseFee + extraFees;
            decimal totalFee = this.CalculateTotalFee(monthlyTotal, months);

            lblMonthlyFees.Text = monthlyTotal.ToString("C");
            lblTotalFee.Text = totalFee.ToString("C");

        }

        // Calculate Base Memberhsip Fee 
        public decimal BaseMembershipFee()
            {
                if (radAdult.Checked)
                {
                    return 40;
                }
                if (radChild.Checked)
                {
                    return 20;
                }
                if (radStudent.Checked)
                {
                    return 25;
                }
                if (radSenior.Checked)
                {
                    return 30;
                }
            return 0;
            }



        // Add fees in 
        private decimal AdditionalOptionFees()
        {
            decimal fees =  0;
            if(chkYoga.Checked)
            {
                fees += 10;
            }
            if(chkKarate.Checked)
            {
                fees += 30;
            }
            if (chkTrainer.Checked)
            {
                fees += 50;
            }
            return fees;
        }
        // Calculate total fee
        private decimal CalculateTotalFee(decimal monthlyTotal, int months)
        {
            return monthlyTotal * months;

        }
        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            radAdult.Checked = false;
            radChild.Checked = false;
            radSenior.Checked = false;
            radStudent.Checked = false;

            chkKarate.Checked = false;
            chkYoga.Checked = false;
            chkTrainer.Checked = false;

            txtMonths.Text = "";

            lblMonthlyFees.Text = "";
            lblTotalFee.Text = "";
        }
        // CHeck Month valid
        private Boolean CheckMonth(int months)
        {
            if(months < 1 || months > 24)
            {
                return false;
            }
            return true;
        }
    }
}