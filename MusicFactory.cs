using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public class MusicFactory : IMusicFactory
    {
        public ISong CreateSong(string name, string artist, string albumName, int durationInSeconds) 
        {
            return new Song(name, artist, albumName, durationInSeconds);
        }

        public IPlaylist CreatePlaylist(string name)
        {
            List<ISong> songList = new List<ISong>();

            return new Playlist(name, songList);
        }
    }
}
