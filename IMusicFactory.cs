using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public interface IMusicFactory
    {
        ISong CreateSong(string name, string artist, string albumName, int durationInSeconds);
        IPlaylist CreatePlaylist(string name);
    }
}
