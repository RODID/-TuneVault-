using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public class Playlist : IPlaylist
    {
        public Playlist(string name, List<ISong> song)
        {
            Name = name;
            Song = song;
        }

        public string Name { get; set; }
        public List<ISong> Song { get; set; }
        
        public void AddSong(ISong song)
        {
            Song.Add(song);
        }

        public void RemoveSong(ISong song)
        {
            Song.Remove(song);
        }
        public void ClearPlaylist()
        {
            Song.Clear();
        }


        public void Shuffle()
        {
            
        }
    }
}
