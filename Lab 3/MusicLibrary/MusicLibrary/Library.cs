using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{

    public class Library
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet myDataSet;
        string strSQL;
        public List<Song> MusicLibrary = new List<Song>();
        public Library(List<Song> MusicLibrary)
        {
            this.MusicLibrary = MusicLibrary;
        }
        public void LoadLibrary()
        {
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
                MusicLibrary.Add(Song);
            }
            myConnection.Close();
        }
        public void SearchLibraryGenre(String search)
        {
            //string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            MusicLibrary.Clear();
            strSQL = "SELECT * FROM Song WHERE Genre = '" + search + "';";
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
                MusicLibrary.Add(Song);
            }
        }
        public void SearchLibraryArtist(String search)
        {
            MusicLibrary.Clear();
            strSQL = "SELECT * FROM Song WHERE Artist = '" + search + "';";
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
                MusicLibrary.Add(Song);
            }

        }
        public void DeleteSong(String title)
        {
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            myConnection = new OleDbConnection(strConnection);
            strSQL = "DELETE FROM Song Where Title = '" + title + "';";
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();

            strSQL = "DELETE FROM PlaylistSongs Where Title = '" + title + "';";
            myCommand = new OleDbCommand(strSQL, myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }
        public void EditSong(String ogTitle, String title, String artist, String album,
            String genre, String desc, String year, String duration, String url)
        {
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Music.accdb;";
            myConnection = new OleDbConnection(strConnection);
            strSQL = "UPDATE Song SET " + "Title = '" + title + "', " + "Artist = '" + artist + "', " + "Album = '" + album + "', " +
            "Genre = '" + genre + "', " + "[Desc] = '" + desc + "', " + "[Year] = " + year + ", " + "Duration = " + duration + ", " +
            "AlbumURL = '" + url + "' " + "WHERE Title = '" + ogTitle + "'";
            OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            strSQL = "UPDATE PlaylistSongs SET Title = '" + title + "' WHERE Title = '" + ogTitle + "'";
            myCommand = new OleDbCommand(strSQL, myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
    
}
