using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
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
        public frmLibrary()
        {
            InitializeComponent();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            myLibrary = new Library(new List<Song>());
            myLibrary.LoadLibrary();
            dgvLibrary.DataSource = myLibrary.MusicLibrary;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Song selectedSong = (Song)dgvLibrary.CurrentRow.DataBoundItem;
            Form frm = new frmSongView(selectedSong,myLibrary);
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            myLibrary.MusicLibrary.Clear();
            myLibrary.LoadLibrary();
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
                string search = txtSearch.Text;
                myLibrary.SearchLibraryGenre(search);
                dgvLibrary.DataSource = null;
                dgvLibrary.DataSource = myLibrary.MusicLibrary;
            } else if (radArtist.Checked)
            {
                string search = txtSearch.Text;
                myLibrary.SearchLibraryArtist(search);
                dgvLibrary.DataSource = null;
                dgvLibrary.DataSource = myLibrary.MusicLibrary;
            } else
            {
                MessageBox.Show("You must select a search type", "Error");
            }
                
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            Form frm = new frmPlaylists();
            frm.ShowDialog();
        }
    }
}