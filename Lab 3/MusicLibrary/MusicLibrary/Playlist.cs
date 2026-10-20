using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class Playlist
    {
        public String playlistName { get; set; }
        public String Desc { get; set; }
        public DateTime dateCreated { get; set; }
        public List<Song> playlist = new List<Song>();
        public Playlist(String playlistName, String Desc, DateTime dateCreated, List<Song> playlist)
        {
            this.playlistName = playlistName;
            this.Desc = Desc;
            this.dateCreated = dateCreated;
            this.playlist = playlist;
        }
        public override string ToString()
        {
            return playlistName;
        }
    }
}   