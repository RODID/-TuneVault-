using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public class SongAddedEventArgs : EventArgs
    {
        public ISong Song { get; set; }

        public  SongAddedEventArgs(ISong song)
        {
            Song = song;
        }
    }
}
