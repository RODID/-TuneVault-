using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    internal class LibraryManager
    {
        private static LibraryManager _instance;
        public static LibraryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LibraryManager();
                return _instance;
            }
        }
        private List<ISong> _songs;

        private LibraryManager()
        {
            _songs = new List<ISong>();
        }

        //Factory Pattern
        public Song CreateSong(string name, string artist, string albumName, int durationInSeconds)
        {
            return new Song(name, artist, albumName, durationInSeconds);
        }

        //Observer pattern
        public event EventHandler<SongAddedEventArgs> SongAdded;

        public void AddSong(ISong song)
        {
            _songs.Add(song);
            OnSongAdded(new Music_Library.SongAddedEventArgs(song));
        }

        private void OnSongAdded(Music_Library.SongAddedEventArgs e)
        {
            SongAdded?.Invoke(this, e);
        }

        //Linnear search - Alghorithm
        public List<ISong> SearchSong(string keyword)
        {
            return _songs.Where (song =>
                song.Name.Contains(keyword) ||
                song.Artist.Contains(keyword) ||
                song.AlbumName.Contains(keyword)).ToList();
        }
    }
}
