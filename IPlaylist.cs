using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public interface IPlaylist
    {
        public interface IPlaylist
        {
            string Name { get; set; }
            List<ISong> Songs { get; set; }


            /*
            in here i include properties and methods for
            managing songs withing a playlist
            adding songs, removing songs, clear playlist
            and shuffle ('not neccessary')
            'shuffle meaning shuffle the order in playlist'
             */

            void AddSong(ISong song);
            void RemoveSong(ISong song);
            void ClearPlaylist();
            void Shuffle();
        }
    }
}
