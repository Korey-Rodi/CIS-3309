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
    public partial class frmPlaylists : Form
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        string strSQL;
        private Library myLibrary;
        public frmPlaylists()
        {
            InitializeComponent();
        }

        private void frmPlaylists_Load(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                          "Data Source=Music.accdb;";

            myConnection = new OleDbConnection(strConnection);
            strSQL = "SELECT * FROM Playlist";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "Playlist");

            DataTable playlistTable = myDataSet.Tables["Playlist"];
            List<Playlist> playlists = new List<Playlist>();
            

            foreach (DataRow row in playlistTable.Rows)
            {
                string PlaylistName = row["PlaylistName"].ToString();
                string Desc = row["Desc"].ToString();
                DateTime Date = Convert.ToDateTime(row["DataCreated"]);
                strSQL = "SELECT Song.* FROM Song INNER JOIN PlaylistSongs " +
            "ON Song.Title = PlaylistSongs.Title " +
            "WHERE PlaylistSongs.PlaylistName = '" + PlaylistName + "'";

                myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
                myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, "Song");

                DataTable songTable = myDataSet.Tables["Song"];
                List<Song> songs = new List<Song>();

                foreach (DataRow songRow in songTable.Rows)
                {
                    string title = songRow["Title"].ToString();
                    string artist = songRow["Artist"].ToString();
                    string album = songRow["Album"].ToString();
                    string year = songRow["Year"].ToString();
                    string description = songRow["Desc"].ToString();
                    string genre = songRow["Genre"].ToString();
                    string duration = songRow["Duration"].ToString();
                    string albumURL = songRow["AlbumURL"].ToString();

                    Song song = new Song(title, artist, album, year, description,
                                         genre, duration, albumURL);

                    songs.Add(song);
                }
                Playlist playlist = new Playlist(PlaylistName, Desc, Date, songs);

                playlists.Add(playlist);
                cbxPlaylist.Items.Add(playlist);

            }

            myConnection.Close();
        }

        private void cbxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPlaylist.SelectedIndex != -1)
            {
                Playlist selected = (Playlist)cbxPlaylist.SelectedItem;

                lblName.Text = "Name: " + selected.playlistName;
                lblDesc.Text = "Desc: " + selected.Desc;
                lblSongCount.Text = "Songs: " + selected.playlist.Count.ToString();
            }
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            Form frm = new frmCreatePlaylist();
            frm.ShowDialog();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbxPlaylist.SelectedIndex != -1)
            {
                Playlist selected = (Playlist)cbxPlaylist.SelectedItem;
                dgvSongs.DataSource = null;
                dgvSongs.DataSource = selected.playlist;


            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
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
            dgvSongs.DataSource = myLibrary.MusicLibrary;
            myConnection.Close();
        }

        private void btnAddSongs_Click(object sender, EventArgs e)
        {
            Song selectedSong = (Song)dgvSongs.CurrentRow.DataBoundItem;
            Playlist selectedPlaylist = (Playlist)cbxPlaylist.SelectedItem;
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                           "Data Source=Music.accdb;";

            myConnection = new OleDbConnection(strConnection);

            strSQL = "INSERT INTO PlaylistSongs (PlaylistName, Title) " +
                     "VALUES ('" + selectedPlaylist.playlistName + "', '" +
                     selectedSong.title + "')";

            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            selectedPlaylist.playlist.Add(selectedSong);
            MessageBox.Show("Refresh View","Song Added");


        }
    }
}
