using System.Data;
using System.Security.Policy;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class MusicVault : Form
    {

        public MusicVault()
        {
            InitializeComponent();

            ListViewSong.View = View.Details;
            ListViewSong.Columns.Add("Artist", 150);
            ListViewSong.Columns.Add("Song", 150);
            ListViewSong.Columns.Add("Album", 150);
            ListViewSong.Columns.Add("Duration", 100);

            RemoveButton.Click += RemoveButton_Click;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            ArtistNameTextBox.Clear();
            SongNameTextBox.Clear();
            AlbumNameTextBox.Clear();
            DurationTextBox.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string artistName = ArtistNameTextBox.Text;
            string songName = SongNameTextBox.Text;
            string albumName = AlbumNameTextBox.Text;
            int durationInSeconds;

            if (!int.TryParse(DurationTextBox.Text, out durationInSeconds))
            {
                MessageBox.Show("Invalid duration. Please enter a valid number");
                return;
            }

            ISong song = LibraryManager.Instance.CreateSong(artistName, songName, albumName, durationInSeconds);

            LibraryManager.Instance.AddSong(song);

            ClearTextBoxes();

            UpdateListView(song);

        }

        private void UpdateListView(ISong song)
        {
            ListViewItem item = new ListViewItem(song.Name);

            item.SubItems.Add(song.Artist);
            item.SubItems.Add(song.AlbumName);
            item.SubItems.Add(song.DurationInSeconds.ToString());

            ListViewSong.Items.Add(item);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = SearchTextBox.Text;
            if (!String.IsNullOrEmpty(keyword))
            {
                List<ISong> searchResult = LibraryManager.Instance.SearchSong(keyword);
                UpdateListViewWithSearchResults(searchResult);
            }
            else
            {
                ListViewSearchedSongs.Items.Clear();
            }
        }

        private void UpdateListViewWithSearchResults(List<ISong> searchResult)
        {
            ListViewSearchedSongs.Items.Clear();

            foreach (ISong song in searchResult)
            {
                ListViewItem item = new ListViewItem(song.Name);
                item.SubItems.Add(song.Artist);
                item.SubItems.Add(song.AlbumName);
                item.SubItems.Add(song.DurationInSeconds.ToString());
                ListViewSearchedSongs.Items.Add(item);
            }
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewSong.SelectedItems.Count < 0)
                {
                    MessageBox.Show("Please select an artist to remove");
                    return;
                }

                foreach (ListViewItem selectedITem in ListViewSong.SelectedItems)
                {
                    string artistToRemove = selectedITem.SubItems[0].Text;
                    string songToRemove = selectedITem.SubItems[1].Text;

                    ISong song = LibraryManager.Instance.SearchSongToRemove(artistToRemove, songToRemove);

                    if (song != null)
                    {
                        LibraryManager.Instance.RemoveSong(song);
                        ListViewSong.Items.Remove(selectedITem);
                    }
                    else
                    {
                        MessageBox.Show("Artist not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void PlaylistButton_Click(object sender, EventArgs e)
        {
            PlaylistForm playlistForm = new PlaylistForm();
            playlistForm.ShowDialog();
        }
    }
}
