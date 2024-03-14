using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public class Playlist : IPlaylist
    {
        
        public string Name { get; set; }
        
        
        public Playlist(string name)
        {
            Name = name;
        }
    }
}
