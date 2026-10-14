using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{

    public class Song 
    {
        public String title {  get; set; }
        public String artist { get; set; }
        public String album { get; set; }
        public int year { get; set; }
        public String desc { get; set; }
        public String genre { get; set; }
        public int duration { get; set; }
        public String albumUrl { get; set; }
    public Song(String title, String artist, String album, 
        int year, String desc, String genre, int duration,String albumUrl)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.year = year;
            this.desc = desc;
            this.genre = genre;
            this.duration = duration;
            this.albumUrl = albumUrl;
        }
    }
}
