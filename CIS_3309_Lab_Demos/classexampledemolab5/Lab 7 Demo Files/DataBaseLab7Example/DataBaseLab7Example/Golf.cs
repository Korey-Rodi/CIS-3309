using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLab7Example
{
    public partial class Golf : Form
    {
        public Golf()
        {
            InitializeComponent();
        }

        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        BindingSource myBindingSource;
        string strSQL;

        private void frmGolf_Load(object sender, EventArgs e)
        {
            // Connect to the database, retrieve a result set of records, and store them in a DataSet
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Golf.accdb;");
            strSQL = "SELECT * FROM Golf";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet("GolfTable");
            myDataAdapter.Fill(myDataSet, "GolfTable");

            // Create a BindingSource used to bind the DataSet data to controls,
            // and navigate the records in the DataSet.
            myBindingSource = new BindingSource();
            myBindingSource.DataSource = myDataSet;
            myBindingSource.DataMember = "GolfTable";

            // Create Binding objects that bind a control's Text property to a specific record's field
            // via BindingSource
            Binding objSIDBinding = new Binding("Text", myBindingSource, "Player");
            Binding objLNBinding = new Binding("Text", myBindingSource, "Round1");
            Binding objFNBinding = new Binding("Text", myBindingSource, "Round2");
            Binding objMajorBinding = new Binding("Text", myBindingSource, "FinalScore");

            // Add the bindings to the controls
            // After this step, the control's Text property will display a record's field value
            // and change as the code navigates through the records using the BindingSource methods.
            txtPlayer.DataBindings.Add(objSIDBinding);
            txtRd1.DataBindings.Add(objLNBinding);
            txtRd2.DataBindings.Add(objFNBinding);
            txtFScore.DataBindings.Add(objMajorBinding);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            myBindingSource.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            myBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            myBindingSource.MoveLast();
        }


        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            // When the user clicks the Add Record button, suspend the databinding being used by the controls,
            // and clear the controls to allow for data entry. 
            if (btnAddRecord.Text == "Add Record")
            {
                myBindingSource.SuspendBinding();

                txtPlayer.Text = "";
                txtRd1.Text = "";
                txtRd2.Text = "";
                txtFScore.Text = "";

                btnAddRecord.Text = "Save";
            }
            else if (btnAddRecord.Text == "Save")
            {
                // Get a reference to the DataTable in the DataSet, and
                // have the table create a new row object that represents a row in
                // this DataTable. This only creates a new row, it doesn't add it to the DataTable/DataSet
                DataTable dtGolf = myDataSet.Tables["GolfTable"];
                DataRow drNewRecord = dtGolf.NewRow();

                // Set the values for each field in the new table row
                drNewRecord["Player"] = txtPlayer.Text;
                drNewRecord["Round1"] = txtRd1.Text;
                drNewRecord["Round2"] = txtRd2.Text;
                drNewRecord["FinalScore"] = txtFScore.Text;

                // Add the new row to the DataTable in the DataSet
                dtGolf.Rows.Add(drNewRecord);

                btnAddRecord.Text = "Add Record";

                // Resume the databinding for the controls and move to the last record (newly added record).
                myBindingSource.ResumeBinding();
                myBindingSource.MoveLast();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the database to reconcile any changes made to the DataSet
            OleDbCommandBuilder builder = new OleDbCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, "GolfTable");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }

}
