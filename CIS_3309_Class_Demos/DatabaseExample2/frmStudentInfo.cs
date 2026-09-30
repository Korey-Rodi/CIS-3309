using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;        // namespace needed in order to connect to Access database

namespace DatabaseExample2
{
    public partial class frmStudentInfo : Form
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        BindingSource myBindingSource;
        string strSQL;
        
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Form Load Event connects to the database, retrieves records, and creates a BindingSource
        /// that is used in binding controls to data in the DataSet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            // Connect to the database, retrieve a result set of records, and store them in a DataSet
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=School.accdb;");
            strSQL = "SELECT * FROM Students";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet("StudentsTable");
            myDataAdapter.Fill(myDataSet, "StudentsTable");

            // Create a BindingSource used to bind the DataSet data to controls,
            // and navigate the records in the DataSet.
            myBindingSource = new BindingSource();
            myBindingSource.DataSource = myDataSet;
            myBindingSource.DataMember = "StudentsTable";

            // Create Binding objects that bind a control's Text property to a specific record's field
            // via BindingSource
            Binding objSIDBinding = new Binding("Text", myBindingSource, "StudentID");
            Binding objLNBinding = new Binding("Text", myBindingSource, "Lastname");
            Binding objFNBinding = new Binding("Text", myBindingSource, "Firstname");
            Binding objMajorBinding = new Binding("Text", myBindingSource, "Major");

            // Add the bindings to the controls
            // After this step, the control's Text property will display a record's field value
            // and change as the code navigates through the records using the BindingSource methods.
            txtSID.DataBindings.Add(objSIDBinding);
            txtLN.DataBindings.Add(objLNBinding);
            txtFN.DataBindings.Add(objFNBinding);
            txtMajor.DataBindings.Add(objMajorBinding);
        }

        /// <summary>
        /// This button is used to move to the first record in the BindingSource and display the
        /// records data in all controls that were bound to the BindingSource.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            myBindingSource.MoveFirst();
        }

        /// <summary>
        /// This button is used to move to the next record in the BindingSource and display the
        /// records data in all controls that were bound to the BindingSource.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            myBindingSource.MoveNext();
        }

        /// <summary>
        /// This button is used to move to the previous record in the BindingSource and display the
        /// records data in all controls that were bound to the BindingSource.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            myBindingSource.MovePrevious();
        }

        /// <summary>
        /// This button is used to move to the last record in the BindingSource and display the
        /// records data in all controls that were bound to the BindingSource. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            myBindingSource.MoveLast();
        }

        /// <summary>
        /// This button is used to add a new record to the DataSet through the DataTable in
        /// the DataSet. This modification to the set of records only occurs locally and does not
        /// effect the records in the database because a DataSet is used in the Disconnected Data Architecture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            // When the user clicks the Add Record button, suspend the databinding being used by the controls,
            // and clear the controls to allow for data entry. 
            if (btnAddRecord.Text == "Add Record")
            {
                myBindingSource.SuspendBinding(); // You must do this to allow the changes to be made

                txtSID.Text = "";
                txtLN.Text = "";
                txtFN.Text = "";
                txtMajor.Text = "";

                btnAddRecord.Text = "Save";
            }
            else if (btnAddRecord.Text == "Save")
            {
                // Get a reference to the DataTable in the DataSet, and
                // have the table create a new row object that represents a row in
                // this DataTable. This only creates a new row, it doesn't add it to the DataTable/DataSet
                DataTable dtStudents = myDataSet.Tables["StudentsTable"];
                DataRow drNewRecord = dtStudents.NewRow(); // Creates a data row reference and allows you to add each new record to the row
                
                // Set the values for each field in the new table row
                drNewRecord["StudentID"] = txtSID.Text;
                drNewRecord["Lastname"] = txtLN.Text;
                drNewRecord["Firstname"] = txtFN.Text;
                drNewRecord["Major"] = txtMajor.Text;
                
                // Add the new row to the DataTable in the DataSet
                dtStudents.Rows.Add(drNewRecord);

                btnAddRecord.Text = "Add Record";

                // Resume the databinding for the controls and move to the last record (newly added record).
                myBindingSource.ResumeBinding();
                myBindingSource.MoveLast();
            }
        }

        /// <summary>
        /// This button is used to update the data in the database based on the modifications made
        /// to the DataSet. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the database to reconcile any changes made to the DataSet
            OleDbCommandBuilder builder = new OleDbCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, "StudentsTable");
        }
    }
}
