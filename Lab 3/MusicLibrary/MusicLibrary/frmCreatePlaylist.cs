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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicLibrary
{
    public partial class frmCreatePlaylist : Form
    {
        OleDbConnection myConnection;
        DataSet myDataSet;
        string strSQL;
        public frmCreatePlaylist()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                         "Data Source=Music.accdb;";
            DateTime dt = DateTime.Now;

            myConnection = new OleDbConnection(strConnection);
            strSQL = "INSERT INTO Playlist VALUES ('" + txtPlaylistName.Text + "', '"
    + txtPlaylistDesc.Text + "', #" + dt.ToString("MM/dd/yyyy") + "#)";
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Please close window", "Playlist Created");


        }
    }
}
