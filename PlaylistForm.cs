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
        public PlaylistForm()
        {
            InitializeComponent();

            LibraryManager.Instance.SongAdded += OnSongAdded;
        }

        private void OnSongAdded(object? sender, SongAddedEventArgs e)
        {
            ListViewItem songItem = new ListViewItem(e.Song.Name);
            songItem.SubItems
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string playlistName = "Q(^^Q)";
            Playlist newPlaylist = new Playlist(playlistName);

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
                string gselectedPlaylistName = ListViewPlaylist.SelectedItems[0].Text;

                ListViewPlaylistSongs.Items.Clear();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
