namespace Music_Library
{
    partial class MusicVault
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ArtistNameTextBox = new TextBox();
            SongNameTextBox = new TextBox();
            AlbumNameTextBox = new TextBox();
            DurationTextBox = new TextBox();
            label1 = new Label();
            ArtistName = new Label();
            label3 = new Label();
            label4 = new Label();
            ListViewSong = new ListView();
            ListViewSearchedSongs = new ListView();
            AddButton = new Button();
            RemoveButton = new Button();
            UpdateButton = new Button();
            ClearButton = new Button();
            label2 = new Label();
            SearchTextBox = new TextBox();
            PlayListButton = new Button();
            SuspendLayout();
            // 
            // ArtistNameTextBox
            // 
            ArtistNameTextBox.Location = new Point(135, 44);
            ArtistNameTextBox.Name = "ArtistNameTextBox";
            ArtistNameTextBox.Size = new Size(125, 27);
            ArtistNameTextBox.TabIndex = 0;
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Location = new Point(135, 96);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(125, 27);
            SongNameTextBox.TabIndex = 0;
            // 
            // AlbumNameTextBox
            // 
            AlbumNameTextBox.Location = new Point(135, 144);
            AlbumNameTextBox.Name = "AlbumNameTextBox";
            AlbumNameTextBox.Size = new Size(125, 27);
            AlbumNameTextBox.TabIndex = 0;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(135, 198);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(18, 99);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Song name";
            // 
            // ArtistName
            // 
            ArtistName.AutoSize = true;
            ArtistName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ArtistName.Location = new Point(18, 47);
            ArtistName.Name = "ArtistName";
            ArtistName.Size = new Size(92, 20);
            ArtistName.TabIndex = 2;
            ArtistName.Text = "Artist name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(18, 201);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 1;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(18, 147);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 2;
            label4.Text = "Album name";
            // 
            // ListViewSong
            // 
            ListViewSong.Location = new Point(289, 44);
            ListViewSong.Name = "ListViewSong";
            ListViewSong.Size = new Size(597, 181);
            ListViewSong.TabIndex = 3;
            ListViewSong.UseCompatibleStateImageBehavior = false;
            ListViewSong.View = View.List;
            // 
            // ListViewSearchedSongs
            // 
            ListViewSearchedSongs.Location = new Point(370, 288);
            ListViewSearchedSongs.Name = "ListViewSearchedSongs";
            ListViewSearchedSongs.Size = new Size(516, 229);
            ListViewSearchedSongs.TabIndex = 3;
            ListViewSearchedSongs.UseCompatibleStateImageBehavior = false;
            ListViewSearchedSongs.View = View.List;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LawnGreen;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            AddButton.Location = new Point(135, 288);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.Red;
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            RemoveButton.Location = new Point(23, 243);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(94, 29);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.Cyan;
            UpdateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            UpdateButton.Location = new Point(23, 288);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Gold;
            ClearButton.Location = new Point(135, 243);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.Location = new Point(291, 246);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 6;
            label2.Text = "Search :";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(370, 245);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(516, 27);
            SearchTextBox.TabIndex = 7;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // PlayListButton
            // 
            PlayListButton.Location = new Point(23, 334);
            PlayListButton.Name = "PlayListButton";
            PlayListButton.Size = new Size(94, 29);
            PlayListButton.TabIndex = 8;
            PlayListButton.Text = "Playlist";
            PlayListButton.UseVisualStyleBackColor = true;
            PlayListButton.Click += PlaylistButton_Click;
            // 
            // MusicVault
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(944, 543);
            Controls.Add(PlayListButton);
            Controls.Add(SearchTextBox);
            Controls.Add(label2);
            Controls.Add(ClearButton);
            Controls.Add(UpdateButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ListViewSearchedSongs);
            Controls.Add(ListViewSong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ArtistName);
            Controls.Add(label1);
            Controls.Add(DurationTextBox);
            Controls.Add(AlbumNameTextBox);
            Controls.Add(SongNameTextBox);
            Controls.Add(ArtistNameTextBox);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MusicVault";
            Text = "Music_Vault";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ArtistNameTextBox;
        private TextBox SongNameTextBox;
        private TextBox AlbumNameTextBox;
        private TextBox DurationTextBox;
        private Label label1;
        private Label ArtistName;
        private Label label3;
        private Label label4;
        private ListView ListViewSong;
        private ListView ListViewSearchedSongs;
        private Button RemoveButton;
        private Button UpdateButton;
        private Button ClearButton;
        private Button AddButton;
        private Label label2;
        private TextBox SearchTextBox;
        private Button PlayListButton;
    }
}
