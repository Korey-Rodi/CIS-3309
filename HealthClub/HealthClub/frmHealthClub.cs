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
            int membershipFee = 0;
            int totalMembershipFee = 0;
            membershipFee = monthlyFee(membershipFee);
            totalMembershipFee = membershipFee + otherFees();
            lblMonthlyFees.Text = membershipFee.ToString();
            lblTotalFee.Text = totalMembershipFee.ToString();

        }

        // Calculate Base Memberhsip Fee 
        public int monthlyFee(int membershipFee)
            {
                if (radAdult.Checked)
                {
                    membershipFee = 40;
                }
                if (radChild.Checked)
                {
                    membershipFee = 20;
                }
                if (radStudent.Checked)
                {
                    membershipFee = 25;
                }
                if (radSenior.Checked)
                {
                    membershipFee = 30;
                }
            return membershipFee;
            }



        // Add fees in 
        public int otherFees()
            {
            int fees = 0;
            if(chkYoga.Checked)
            {
                fees = 10;
            }
            if(chkKarate.Checked)
            {
                fees = 30;
            }
            if (chkTrainer.Checked)
            {
                fees = 50;
            }
            return fees;
        }
    }
}
