using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class PlaylistForm : Form
    {

        private Dictionary<string, Playlist> playlists = new Dictionary<string, Playlist>();
        public PlaylistForm()
        {
            InitializeComponent();

            LibraryManager.Instance.SongAdded += OnSongAdded;
        }

        private void OnSongAdded(object? sender, SongAddedEventArgs e)
        {
            foreach(var playlist in playlists.Values)
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
                    if(selectedSong != null)
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
            string playlistName = "Q(^^Q)";
            List<ISong> newPlaylistSongs = new List<ISong>();

            Playlist newPlaylist = new Playlist(playlistName, newPlaylistSongs);
            playlists.Add(playlistName, newPlaylist);

            ListViewItem item = new ListViewItem(playlistName);
            ListViewPlaylist.Items.Add(item);
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {

        }

        private void ListViewPlaylistSong_SIC(object sender, EventArgs e)
        {

        }

        private void ListViewPlaylist_SIC(object sender, EventArgs e)
        {
            if (ListViewPlaylist.SelectedItems.Count < 0 )
            {
                string selectedPlaylistName = ListViewPlaylist.SelectedItems[0].Text;

                ListViewPlaylistSongs.Items.Clear();

                if (playlists.ContainsKey(selectedPlaylistName))
                {
                    foreach(var song in playlists[selectedPlaylistName].Song)
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
    }
}
