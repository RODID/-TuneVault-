namespace Music_Library
{
    partial class PlaylistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistForm));
            AddButton = new Button();
            RemoveButton = new Button();
            ListViewPlaylistSongs = new ListView();
            ListViewPlaylist = new ListView();
            CreateButton = new Button();
            RenameButton = new Button();
            BackButton = new Button();
            ListViewSearchSongs = new ListView();
            SearchPlaylistTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.ForeColor = SystemColors.ActiveCaptionText;
            AddButton.Location = new Point(155, 217);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add song";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddSongButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.ForeColor = SystemColors.ActiveCaptionText;
            RemoveButton.Location = new Point(436, 252);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(94, 29);
            RemoveButton.TabIndex = 0;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ListViewPlaylistSongs
            // 
            ListViewPlaylistSongs.Location = new Point(12, 299);
            ListViewPlaylistSongs.Name = "ListViewPlaylistSongs";
            ListViewPlaylistSongs.Size = new Size(518, 139);
            ListViewPlaylistSongs.TabIndex = 1;
            ListViewPlaylistSongs.UseCompatibleStateImageBehavior = false;
            ListViewPlaylistSongs.View = View.List;
            ListViewPlaylistSongs.SelectedIndexChanged += ListViewPlaylistSong_SIC;
            // 
            // ListViewPlaylist
            // 
            ListViewPlaylist.Location = new Point(39, 47);
            ListViewPlaylist.Name = "ListViewPlaylist";
            ListViewPlaylist.Size = new Size(210, 164);
            ListViewPlaylist.TabIndex = 1;
            ListViewPlaylist.UseCompatibleStateImageBehavior = false;
            ListViewPlaylist.View = View.List;
            ListViewPlaylist.SelectedIndexChanged += ListViewPlaylist_SIC;
            // 
            // CreateButton
            // 
            CreateButton.ForeColor = SystemColors.ActiveCaptionText;
            CreateButton.Location = new Point(39, 217);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(94, 29);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // RenameButton
            // 
            RenameButton.ForeColor = SystemColors.ActiveCaptionText;
            RenameButton.Location = new Point(39, 252);
            RenameButton.Name = "RenameButton";
            RenameButton.Size = new Size(94, 29);
            RenameButton.TabIndex = 0;
            RenameButton.Text = "Rename";
            RenameButton.UseVisualStyleBackColor = true;
            RenameButton.Click += RenameButton_Click;
            // 
            // BackButton
            // 
            BackButton.ForeColor = SystemColors.ActiveCaptionText;
            BackButton.Location = new Point(155, 264);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ListViewSearchSongs
            // 
            ListViewSearchSongs.Location = new Point(272, 47);
            ListViewSearchSongs.Name = "ListViewSearchSongs";
            ListViewSearchSongs.Size = new Size(262, 199);
            ListViewSearchSongs.TabIndex = 1;
            ListViewSearchSongs.UseCompatibleStateImageBehavior = false;
            ListViewSearchSongs.View = View.List;
            ListViewSearchSongs.SelectedIndexChanged += ListViewPlaylist_SIC;
            // 
            // SearchPlaylistTextBox
            // 
            SearchPlaylistTextBox.Location = new Point(272, 14);
            SearchPlaylistTextBox.Name = "SearchPlaylistTextBox";
            SearchPlaylistTextBox.Size = new Size(258, 27);
            SearchPlaylistTextBox.TabIndex = 3;
            SearchPlaylistTextBox.TextChanged += SearchSongPlaylistTextBox_TxtChng;
            // 
            // PlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(542, 450);
            Controls.Add(SearchPlaylistTextBox);
            Controls.Add(BackButton);
            Controls.Add(ListViewSearchSongs);
            Controls.Add(ListViewPlaylist);
            Controls.Add(ListViewPlaylistSongs);
            Controls.Add(RenameButton);
            Controls.Add(CreateButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            Name = "PlaylistForm";
            Text = "PlaylistForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button RemoveButton;
        private ListView ListViewPlaylistSongs;
        private ListView ListViewPlaylist;
        private Button CreateButton;
        private Button RenameButton;
        private Button BackButton;
        private ListView ListViewSearchSongs;
        private TextBox SearchPlaylistTextBox;
    }
}