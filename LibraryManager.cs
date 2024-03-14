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
        private readonly IMusicFactory _factory;
        public static LibraryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LibraryManager(new MusicFactory());
                return _instance;
            }
        }

        private List<ISong> _songs;

        private LibraryManager(IMusicFactory factory)
        {
            _factory = _factory;
            _songs = new List<ISong>();
        }

        //Abstract Factory Pattern
        /*
         Facttory pattern with a slight variation,
        by delegating the creation of ISong objects
        to another class '_factory' that implements the 
        'IMusicFactory Interface

        skapade denna för att möjliggöra för användaren
        att skapa egna spelistor.
         */

        public ISong CreateSong(string name, string artist, string albumName, int durationInSeconds)
        {
            return _factory.CreateSong(name, artist, albumName, durationInSeconds);
        }

        public  IPlaylist CreatePlaylist(string name)
        {
            return _factory.CreatePlaylist(name);
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
            var searchResults = new List<ISong>();

            searchResults.AddRange(_songs.Where(song => song.Name.Contains(keyword)));

            searchResults.AddRange(_songs.Where(song => song.AlbumName.Contains(keyword) && !searchResults.Contains(song)));

            searchResults.AddRange(_songs.Where(song => song.Artist.Contains(keyword) && !searchResults.Contains(song)));

            return searchResults;
        }
    }
}
