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
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            AddButton = new Button();
            button2 = new Button();
            button3 = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // ArtistNameTextBox
            // 
            ArtistNameTextBox.Location = new Point(135, 70);
            ArtistNameTextBox.Name = "ArtistNameTextBox";
            ArtistNameTextBox.Size = new Size(125, 27);
            ArtistNameTextBox.TabIndex = 0;
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Location = new Point(135, 122);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(125, 27);
            SongNameTextBox.TabIndex = 0;
            // 
            // AlbumNameTextBox
            // 
            AlbumNameTextBox.Location = new Point(135, 170);
            AlbumNameTextBox.Name = "AlbumNameTextBox";
            AlbumNameTextBox.Size = new Size(125, 27);
            AlbumNameTextBox.TabIndex = 0;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(135, 224);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(18, 125);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Song name";
            // 
            // ArtistName
            // 
            ArtistName.AutoSize = true;
            ArtistName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ArtistName.Location = new Point(18, 73);
            ArtistName.Name = "ArtistName";
            ArtistName.Size = new Size(92, 20);
            ArtistName.TabIndex = 2;
            ArtistName.Text = "Artist name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(18, 227);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 1;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(18, 173);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 2;
            label4.Text = "Album name";
            // 
            // ListViewSong
            // 
            ListViewSong.Location = new Point(278, 42);
            ListViewSong.Name = "ListViewSong";
            ListViewSong.Size = new Size(265, 125);
            ListViewSong.TabIndex = 3;
            ListViewSong.UseCompatibleStateImageBehavior = false;
            ListViewSong.View = View.List;
            // 
            // listView1
            // 
            listView1.Location = new Point(578, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(188, 355);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // listView2
            // 
            listView2.Location = new Point(278, 192);
            listView2.Name = "listView2";
            listView2.Size = new Size(265, 125);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            // 
            // listView3
            // 
            listView3.Location = new Point(278, 337);
            listView3.Name = "listView3";
            listView3.Size = new Size(265, 125);
            listView3.TabIndex = 3;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.List;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LawnGreen;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            AddButton.Location = new Point(166, 312);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(166, 360);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(166, 410);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Gold;
            ClearButton.Location = new Point(166, 267);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // MusicVault
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 502);
            Controls.Add(ClearButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(AddButton);
            Controls.Add(listView1);
            Controls.Add(listView3);
            Controls.Add(listView2);
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
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private Button button2;
        private Button button3;
        private Button ClearButton;
        private Button AddButton;
    }
}
