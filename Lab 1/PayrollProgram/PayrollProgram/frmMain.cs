using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProgram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlyRate.Text = " ";
            txtHoursWorked.Text = " ";
            lblDisplay.Text = "                 Pay:";
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            // Convert to double
            double hoursWorked;
            double.TryParse(txtHoursWorked.Text, out hoursWorked);
            double hourlyRate;
            double.TryParse(txtHourlyRate.Text, out hourlyRate);

            // Calculations
            double grossPay = hoursWorked * hourlyRate;
            double stateTax = grossPay * .035;
            double federalTax = grossPay * .15;
            double socialTax = grossPay * .062;
            double medicareTax = grossPay * .029;
            double netPay = grossPay - stateTax - federalTax - socialTax - medicareTax;

            // Set Display
            lblDisplay.Text = "Pay: " 
            + "\n Gross Pay: $" + grossPay
            + "\n State Tax: $" + stateTax
            + "\n Federal Tax: $" + federalTax
            + "\n Social Security Tax: $" + socialTax
            + "\n Medicare Tax: $" + medicareTax
            + "\n Net Pay: $" + netPay;
        }
    }
}
