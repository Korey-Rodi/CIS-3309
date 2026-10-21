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

namespace MusicLibrary
{

    public partial class frmAddSong : Form
    {
        OleDbConnection myConnection;
        string strSQL;
        public frmAddSong()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //String title = txtTitle.Text;
            //String artist = txtArtist.Text;
            //String album = txtAlbum.Text;
            //String year = txtYear.Text;
            //String desc = txtDesc.Text;
            //String genre = cbxGenre.Text;
            //String duration = txtDuration.Text;
            //String albumUrl = txtAlbumURL.Text;
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            myConnection = new OleDbConnection(strConnection);
            strSQL = "INSERT INTO Song VALUES ('" + txtTitle.Text + "', '" + txtArtist.Text + "', '" + txtAlbum.Text + "', '"
            + txtYear.Text + "', '" + txtDesc.Text + "', '" + cbxGenre.Text + "', '" + txtDuration.Text + "', '" + txtAlbumURL.Text + "')";
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Please close window and refresh Library", "Song Added");
        }
    }
}
