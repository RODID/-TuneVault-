namespace Music_Library
{
    partial class RenamePlaylistForm
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
            PlaylistTextBox = new TextBox();
            ChangeButton = new Button();
            label1 = new Label();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // PlaylistTextBox
            // 
            PlaylistTextBox.Location = new Point(44, 59);
            PlaylistTextBox.Name = "PlaylistTextBox";
            PlaylistTextBox.Size = new Size(332, 27);
            PlaylistTextBox.TabIndex = 0;
            PlaylistTextBox.Enter += PlaylistTextBox_Enter;
            PlaylistTextBox.Leave += PlaylistTextBox_Leave;
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = Color.BlanchedAlmond;
            ChangeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ChangeButton.ForeColor = SystemColors.ActiveCaptionText;
            ChangeButton.Location = new Point(282, 92);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 1;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Name ur Playlist";
            // 
            // GoBackButton
            // 
            GoBackButton.BackColor = Color.Red;
            GoBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            GoBackButton.Location = new Point(282, 134);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(94, 29);
            GoBackButton.TabIndex = 3;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = false;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // RenamePlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 175);
            Controls.Add(GoBackButton);
            Controls.Add(label1);
            Controls.Add(ChangeButton);
            Controls.Add(PlaylistTextBox);
            Name = "RenamePlaylistForm";
            Text = "RenamePlaylistForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PlaylistTextBox;
        private Button ChangeButton;
        private Label label1;
        private Button GoBackButton;
    }
}