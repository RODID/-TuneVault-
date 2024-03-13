﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    internal class Song : ISong
    {
        public Song(string name, string artist, string albumName, int durationInSeconds)
        {
            Name = name;
            Artist = artist;
            AlbumName = albumName;
            DurationInSeconds = durationInSeconds;
        }

        public string Name { get; set; }
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public int DurationInSeconds { get; set; }

        

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
