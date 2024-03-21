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
    public partial class RenamePlaylistForm : Form
    {
        private readonly string originalName;
        public string NewName { get; private set; }

        public RenamePlaylistForm()
        {
            InitializeComponent();

            originalName = NewName;
            PlaylistTextBox.Text = originalName;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string newName = PlaylistTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || newName == originalName)
            {
                MessageBox.Show("Please enter a diffrent name");
                return;
            }

            NewName = newName;
            Close();
        }

        private void PlaylistTextBox_Enter(object sender, EventArgs e)
        {
            if(PlaylistTextBox.Text == originalName)
            {
                PlaylistTextBox.Text = "";
            }
        }

        private void PlaylistTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlaylistTextBox.Text))
            {
                PlaylistTextBox.Text = originalName;
            }
        }
    }
}
