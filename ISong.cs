using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public interface ISong 
    {
        string Name { get; set; }
        string Artist { get; set; }
        string AlbumName { get; set; }
        int DurationInSeconds { get; set; }

        void AddSong();
        void RemoveSong();
        void UpdateSong(string newName, string newArtist, string newAlbumName, int newDurationInSeconds);

    }
}
