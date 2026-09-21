using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classexampledemolab3part2
{
    public partial class frmRegister : Form
    {
        private Form1 formMain;


        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            formMain = (Form1)this.Owner;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String[] arr = new String[3];
            arr[0] = txtName.Text;
            arr[1] = cbxType.Text;
            arr[2] = cbxPosition.Text;
            ListViewItem itemNew = new ListViewItem(arr);
            formMain.lvPlayers.Items.Add(itemNew);
        }
    }
}
