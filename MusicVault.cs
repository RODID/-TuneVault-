using System.Data;
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

            ISong song = LibraryManager.Instance.CreateSong(artistName, artistName, albumName, durationInSeconds);

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
    }
}
