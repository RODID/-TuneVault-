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
        public string NewPlaystationName { get; internal set; }

        public RenamePlaylistForm(string originalName)
        {
            InitializeComponent();

            this.originalName = originalName;
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

            NewName = originalName;
            Close();
        }
    }
}
