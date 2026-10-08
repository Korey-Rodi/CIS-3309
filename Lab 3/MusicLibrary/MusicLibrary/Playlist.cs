using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    internal class Playlist
    {
        public int playlistId {  get; set; }
       public String playlistName { get; set; }
       public List<Song> playlist = new List<Song>();
    public Playlist(int playlistId,String playlistName, List<Song> playlist)
        {
            this.playlistId = playlistId;
            this.playlistName = playlistName;
            this.playlist = playlist;
        }
    }
}
