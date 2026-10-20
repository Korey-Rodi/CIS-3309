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

    public partial class frmLibrary : Form
    {
        Library myLibrary;
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        string strSQL;
        public frmLibrary()
        {
            InitializeComponent();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            myLibrary = new Library(new List<Song>());

            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            myConnection = new OleDbConnection(strConnection);
            strSQL = "SELECT * FROM Song";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "Song");
            DataTable songTable = myDataSet.Tables["Song"];

            foreach (DataRow row in songTable.Rows)
            {
                string title = row["Title"].ToString();
                string artist = row["Artist"].ToString();
                string album = row["Album"].ToString();
                string genre = row["Genre"].ToString();
                string description = row["Desc"].ToString();
                string year = row["Year"].ToString();
                string duration = row["Duration"].ToString();
                string albumURL = row["AlbumURL"].ToString();

                Song Song = new Song(title, artist, album, year, description, genre, duration, albumURL);
                myLibrary.MusicLibrary.Add(Song);
            }
            dgvLibrary.DataSource = myLibrary.MusicLibrary;
            myConnection.Close();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Song selectedSong = (Song)dgvLibrary.CurrentRow.DataBoundItem;
            Form frm = new frmSongView(selectedSong);
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            myLibrary.MusicLibrary.Clear();

            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            myConnection = new OleDbConnection(strConnection);
            strSQL = "SELECT * FROM Song";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "Song");
            DataTable songTable = myDataSet.Tables["Song"];

            foreach (DataRow row in songTable.Rows)
            {
                string title = row["Title"].ToString();
                string artist = row["Artist"].ToString();
                string album = row["Album"].ToString();
                string genre = row["Genre"].ToString();
                string description = row["Desc"].ToString();
                string year = row["Year"].ToString();
                string duration = row["Duration"].ToString();
                string albumURL = row["AlbumURL"].ToString();

                Song Song = new Song(title, artist, album, year, description, genre, duration, albumURL);
                myLibrary.MusicLibrary.Add(Song);
            }
            //https://www.google.com/search?q=how+to+resest+a+data+grid+view&rlz=1C1HKFL_enUS1220US1220&oq=how+to+resest+a+data+grid+view&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIKCAEQABgKGBYYHjIHCAIQABjvBTIKCAMQABiiBBiJBTIKCAQQABiiBBiJBTIHCAUQABjvBdIBCDQ4ODBqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8
            dgvLibrary.DataSource = null;
            dgvLibrary.DataSource = myLibrary.MusicLibrary;

        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddSong();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radGenre.Checked)
            {
                strSQL = "SELECT * FROM Song WHERE Genre = '" + txtSearch.Text + "';";
                myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
                myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, "Song");
                DataTable songTable = myDataSet.Tables["Song"];
                myLibrary.MusicLibrary.Clear();
                foreach (DataRow row in songTable.Rows)
                {
                    string title = row["Title"].ToString();
                    string artist = row["Artist"].ToString();
                    string album = row["Album"].ToString();
                    string genre = row["Genre"].ToString();
                    string description = row["Desc"].ToString();
                    string year = row["Year"].ToString();
                    string duration = row["Duration"].ToString();
                    string albumURL = row["AlbumURL"].ToString();

                    Song Song = new Song(title, artist, album, year, description, genre, duration, albumURL);
                    myLibrary.MusicLibrary.Add(Song);
                }

                //https://www.google.com/search?q=how+to+resest+a+data+grid+view&rlz=1C1HKFL_enUS1220US1220&oq=how+to+resest+a+data+grid+view&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIKCAEQABgKGBYYHjIHCAIQABjvBTIKCAMQABiiBBiJBTIKCAQQABiiBBiJBTIHCAUQABjvBdIBCDQ4ODBqMGo3qAIAsAIA&sourceid=chrome&source=chrome.ob&ie=UTF-8
                dgvLibrary.DataSource = null;
                dgvLibrary.DataSource = myLibrary.MusicLibrary;
            }
            if (radArtist.Checked)
            {
                strSQL = "SELECT * FROM Song WHERE Artist = '" + txtSearch.Text + "';";
                myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
                myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, "Song");
                DataTable songTable = myDataSet.Tables["Song"];
                myLibrary.MusicLibrary.Clear();
                foreach (DataRow row in songTable.Rows)
                {
                    string title = row["Title"].ToString();
                    string artist = row["Artist"].ToString();
                    string album = row["Album"].ToString();
                    string genre = row["Genre"].ToString();
                    string description = row["Desc"].ToString();
                    string year = row["Year"].ToString();
                    string duration = row["Duration"].ToString();
                    string albumURL = row["AlbumURL"].ToString();

                    Song Song = new Song(title, artist, album, year, description, genre, duration, albumURL);
                    myLibrary.MusicLibrary.Add(Song);
                }
                dgvLibrary.DataSource = null;
                dgvLibrary.DataSource = myLibrary.MusicLibrary;
            }
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            Form frm = new frmPlaylists();
            frm.ShowDialog();
        }
    }
}