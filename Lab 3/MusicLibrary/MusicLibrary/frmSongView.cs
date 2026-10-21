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
        Song selectedSong;
        Library myLibrary;
        public frmSongView(Song selectedSong,Library myLibrary)
        {
            InitializeComponent();
            this.selectedSong = selectedSong;
            this.myLibrary = myLibrary;
            txtTitle.Text = selectedSong.title;
            txtUrl.Text = selectedSong.albumUrl;
            txtYear.Text = selectedSong.year;
            txtDuration.Text = selectedSong.duration;
            txtDesc.Text = selectedSong.desc;
            txtArtist.Text = selectedSong.artist;
            txtGenre.Text = selectedSong.genre;
            txtAlbum.Text = selectedSong.album;
            pbxAlbum.Load(selectedSong.albumUrl);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            String ogTitle = selectedSong.title;
            String title = txtTitle.Text;
            String artist = txtArtist.Text;
            String album = txtAlbum.Text;
            String year = txtYear.Text;
            String desc = txtDesc.Text;
            String genre = txtGenre.Text;
            String duration = txtDuration.Text;
            String albumUrl = txtUrl.Text;
            myLibrary.EditSong(ogTitle, title, artist, album, genre, desc, year, duration, albumUrl);
            MessageBox.Show("Please close window and refresh Library", "Changes Saved");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String ogTitle = selectedSong.title;
            myLibrary.DeleteSong(ogTitle);
            MessageBox.Show("Please close window and refresh Library", "Song Removed");
        }
    }
}