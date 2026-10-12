using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    internal class Playlist
    {
       public String playlistName { get; set; }
       public List<Song> playlist = new List<Song>();
    public Playlist(String playlistName, List<Song> playlist)
        {
            this.playlistName = playlistName;
            this.playlist = playlist;
        }
    }
}
