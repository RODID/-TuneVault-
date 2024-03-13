using System.Data;

namespace Music_Library
{
    public partial class MusicVault : Form
    {
        public MusicVault()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
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
            string durationInSeconds = DurationTextBox.Text;
        }
    }
}
