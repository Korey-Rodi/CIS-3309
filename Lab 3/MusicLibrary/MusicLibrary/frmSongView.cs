using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    
    public partial class frmSongView : Form
    {
        OleDbConnection myConnection;
        string strSQL;
        Song selectedSong;
        public frmSongView(Song selectedSong)
        {
            InitializeComponent();
            this.selectedSong = selectedSong;
            txtTitle.Text = selectedSong.title;
            txtUrl.Text = selectedSong.albumUrl;
            txtYear.Text = selectedSong.year.ToString();
            txtDuration.Text = selectedSong.duration.ToString();
            txtDesc.Text = selectedSong.desc;
            txtArtist.Text = selectedSong.artist.ToString();
            txtGenre.Text = selectedSong.genre;
            txtAlbum.Text = selectedSong.album;
            pbxAlbum.Load(selectedSong.albumUrl);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            String ogTitle = selectedSong.title;
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            myConnection = new OleDbConnection(strConnection);
            strSQL = "UPDATE Song SET " + "Title = '" + txtTitle.Text + "', " + "Artist = '" + txtArtist.Text + "', " + "Album = '" + txtAlbum.Text + "', " +
            "Genre = '" + txtGenre.Text + "', " + "[Desc] = '" + txtDesc.Text + "', " + "[Year] = " + Convert.ToInt32(txtYear.Text) + ", " + "Duration = " + Convert.ToInt32(txtDuration.Text) + ", " +
            "AlbumURL = '" + txtUrl.Text + "' " + "WHERE Title = '" + ogTitle + "'";
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Please close window and refresh Library", "Changes Saved");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String ogTitle = selectedSong.title;
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            myConnection = new OleDbConnection(strConnection);
            strSQL = "DELETE FROM Song Where Title = '" + ogTitle + "';";
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Please close window and refresh Library", "Song Removed");
        }
    }
}