using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class PlaylistForm : Form, ISongObserver
    {
        public MusicVault musicVault = new MusicVault();
        private Dictionary<string, Playlist> playlists = new Dictionary<string, Playlist>();
        public PlaylistForm()
        {
            InitializeComponent();

            LibraryManager.Instance.RegisterObserver(this);
            LibraryManager.Instance.SongAdded += OnSongAdded;
        }

        private void OnSongAdded(object? sender, SongAddedEventArgs e)
        {
            foreach (var playlist in playlists.Values)
            {
                playlist.AddSong(e.Song);
            }
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            if (ListViewPlaylist.SelectedItems.Count > 0 && ListViewSearchSongs.SelectedItems.Count > 0)
            {
                string selectedPlaylistName = ListViewPlaylist.SelectedItems[0].Text;
                string selectedSongName = ListViewSearchSongs.SelectedItems[0].Text;

                if (playlists.ContainsKey(selectedPlaylistName))
                {
                    ISong selectedSong = LibraryManager.Instance.GetSongByName(selectedSongName);
                    if (selectedSong != null)
                    {
                        playlists[selectedPlaylistName].AddSong(selectedSong);
                        ListViewPlaylist_SIC(sender, e);
                    }
                }
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string playlistName = GenerateRandomPlaylistName();
            List<ISong> newPlaylistSongs = new List<ISong>();

            Playlist newPlaylist = new Playlist(playlistName, newPlaylistSongs);
            playlists.Add(playlistName, newPlaylist);

            ListViewItem item = new ListViewItem(playlistName);
            ListViewPlaylist.Items.Add(item);

            item.Selected = true;
            item.Focused = true;
            ListViewPlaylist.Select();

            RenameButton_Click(sender, e);
        }

        private string GenerateRandomPlaylistName()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTVWXYZ0123456789";

            const int nameLength = 6;

            Random random = new Random();

            string randomName = new string(Enumerable.Repeat(chars, nameLength).Select(s => s[random.Next(s.Length)]).ToArray());

            return randomName;
        }


        private void RenameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewPlaylist.SelectedItems != null)
                {
                    string selectedPlaylistName = ListViewPlaylist.SelectedItems[0].Text;
                    RenamePlaylistForm renamePlaylistForm = new RenamePlaylistForm(selectedPlaylistName);
                    if(renamePlaylistForm.ShowDialog() == DialogResult.OK)
                    {
                        string newName = renamePlaylistForm.NewPlaystationName;
                        if(!string.IsNullOrEmpty(newName))
                        {
                            ListViewPlaylist.SelectedItems[0].Text = newName;

                            var playlist = playlists[selectedPlaylistName];
                            playlists.Remove(selectedPlaylistName );
                            playlists.Add(newName, playlist);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListViewPlaylistSong_SIC(object sender, EventArgs e)
        {

        }

        private void ListViewPlaylist_SIC(object sender, EventArgs e)
        {
            if (ListViewPlaylist.SelectedItems.Count < 0)
            {
                string selectedPlaylistName = ListViewPlaylist.SelectedItems[0].Text;

                ListViewPlaylistSongs.Items.Clear();

                if (playlists.ContainsKey(selectedPlaylistName))
                {
                    foreach (var song in playlists[selectedPlaylistName].Song)
                    {
                        ListViewItem songItem = new ListViewItem(song.Name);
                        ListViewPlaylistSongs.Items.Add(songItem);
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateSong(ISong song)
        {
            ListViewItem item = new ListViewItem(song.Name);
            item.SubItems.Add(song.Artist);
            item.SubItems.Add(song.AlbumName);
            item.SubItems.Add(song.DurationInSeconds.ToString());
            ListViewSearchSongs.Items.Add(item);
        }

        private void SearchSongPlaylistTextBox_TxtChng(object sender, EventArgs e)
        {
            
            string keyword = SearchPlaylistTextBox.Text;
            if (!String.IsNullOrEmpty(keyword))
            {
                List<ISong> searchResult = LibraryManager.Instance.SearchSong(keyword);
                musicVault.UpdateListViewWithSearchResults(searchResult);
            }
            else
            {
                SearchPlaylistTextBox.Clear();
            }
        }
    }
}
