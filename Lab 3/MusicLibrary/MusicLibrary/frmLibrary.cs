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
        public frmLibrary()
        {
            InitializeComponent();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            String strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            String strSQL = "SELECT * FROM Song";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet myDataSet = new DataSet();

            myDataAdapter.Fill(myDataSet, "Song");

            dgvLibrary.DataSource = myDataSet.Tables["Song"];

        }

        private void btnViewSong_Click(object sender, EventArgs e)
        {
                DataRowView song = (DataRowView)dgvLibrary.SelectedRows[0].DataBoundItem;

                frmSongView frm = new frmSongView();

                BindingSource myBindingSource = new BindingSource();
                myBindingSource.DataSource = song;

                frm.txtTitle.DataBindings.Add("Text", myBindingSource, "Title");
                frm.txtArtist.DataBindings.Add("Text", myBindingSource, "Artist");
                frm.txtAlbum.DataBindings.Add("Text", myBindingSource, "Album");

                frm.ShowDialog();
            }
        }
    }
