using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    internal class Library
    {
        public List<Song> MusicLibrary = new List<Song>();
        public Library(List<Song> MusicLibrary)
        {
            this.MusicLibrary = MusicLibrary;
        }
    }
    
}
