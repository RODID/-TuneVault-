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
            _factory = factory;
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

        public void RemoveSong(ISong song)
        {
            _songs.Remove(song);
        }

        //Linnear search - Alghorithm
        /*
        this is a simple linear search algorithm that continiously
        cheacks each element of the collection until a matching element
        is found or the entire collection has crossed

        in my case i iterate over each song in the '_songs' collection
        and cheack if the keyword matches the songs name,album name and/or artist

        detta gör så att flexibiliteten för användaren blir användbar
        då användaren kan söka efter låtar baserad på visa kriterier,
        utan att användaren behöver komma ihåg exakta detaljer.

        detta leder till en bättre prestanda för programmet

        !!kanske ändrar detta till en binary search eller hash-based search!!
         */

        public List<ISong> SearchSong(string keyword)
        {
            var searchResults = new List<ISong>();

            searchResults.AddRange(_songs.Where(song => song.Name.Contains(keyword)));

            searchResults.AddRange(_songs.Where(song => song.AlbumName.Contains(keyword) && !searchResults.Contains(song)));

            searchResults.AddRange(_songs.Where(song => song.Artist.Contains(keyword) && !searchResults.Contains(song)));

            return searchResults;
        }

        public ISong SearchSongToRemove(string songName, string artistName)
        {
            return _songs.FirstOrDefault(song => song.Name == songName && song.Artist == artistName);
        }
    }
}
