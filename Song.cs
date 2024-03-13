using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    internal class Song : ISong
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int DurationInSeconds { get; set; }

        public Song(string name, string artist, int durationInSeconds)
        {
            Name = name;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
        }

        public void AddSong()
        {

        }

        public void RemoveSong()
        {

        }

        public void UpdateSong()
        {

        }
    }
}
