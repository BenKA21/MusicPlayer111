namespace MusicPlayer
{
    partial class MusicPlayer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.songLibraryListBox = new System.Windows.Forms.ListBox();
			this.shuffleButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.playlistListBox = new System.Windows.Forms.ListBox();
			this.newPlaylistButton = new System.Windows.Forms.Button();
			this.renamePlaylistButton = new System.Windows.Forms.Button();
			this.playlistLabel = new System.Windows.Forms.Label();
			this.renameTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.playlistSelectSongsButton = new System.Windows.Forms.Button();
			this.selectSongsButton = new System.Windows.Forms.Button();
			this.sortButton = new System.Windows.Forms.Button();
			this.searchListBox = new System.Windows.Forms.ListBox();
			this.closeSearchButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.songLibraryButton = new System.Windows.Forms.Button();
			this.playlistButton = new System.Windows.Forms.Button();
			this.songLibraryPanel = new System.Windows.Forms.Panel();
			this.playlistPanel = new System.Windows.Forms.Panel();
			this.shufflePlaylistButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.songLibraryPanel.SuspendLayout();
			this.playlistPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(414, 36);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(424, 277);
			this.axWindowsMediaPlayer1.TabIndex = 0;
			// 
			// songLibraryListBox
			// 
			this.songLibraryListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.songLibraryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.songLibraryListBox.ForeColor = System.Drawing.Color.White;
			this.songLibraryListBox.FormattingEnabled = true;
			this.songLibraryListBox.ItemHeight = 18;
			this.songLibraryListBox.Location = new System.Drawing.Point(0, 32);
			this.songLibraryListBox.Name = "songLibraryListBox";
			this.songLibraryListBox.Size = new System.Drawing.Size(250, 274);
			this.songLibraryListBox.TabIndex = 1;
			this.songLibraryListBox.SelectedIndexChanged += new System.EventHandler(this.songLibraryListBox_SelectedIndexChanged);
			// 
			// shuffleButton
			// 
			this.shuffleButton.BackColor = System.Drawing.Color.Black;
			this.shuffleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shuffleButton.ForeColor = System.Drawing.Color.White;
			this.shuffleButton.Location = new System.Drawing.Point(572, 319);
			this.shuffleButton.Name = "shuffleButton";
			this.shuffleButton.Size = new System.Drawing.Size(80, 35);
			this.shuffleButton.TabIndex = 3;
			this.shuffleButton.Text = "Shuffle";
			this.shuffleButton.UseVisualStyleBackColor = false;
			this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click_1);
			// 
			// searchTextBox
			// 
			this.searchTextBox.ForeColor = System.Drawing.Color.Gray;
			this.searchTextBox.Location = new System.Drawing.Point(3, 3);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(153, 20);
			this.searchTextBox.TabIndex = 4;
			this.searchTextBox.Text = "Search song name or artist";
			this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
			// 
			// searchButton
			// 
			this.searchButton.BackColor = System.Drawing.Color.DarkGreen;
			this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.searchButton.Location = new System.Drawing.Point(162, 3);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(56, 23);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = false;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
			// 
			// playlistListBox
			// 
			this.playlistListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.playlistListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playlistListBox.ForeColor = System.Drawing.Color.White;
			this.playlistListBox.FormattingEnabled = true;
			this.playlistListBox.ItemHeight = 18;
			this.playlistListBox.Location = new System.Drawing.Point(0, 32);
			this.playlistListBox.Name = "playlistListBox";
			this.playlistListBox.Size = new System.Drawing.Size(250, 274);
			this.playlistListBox.TabIndex = 6;
			this.playlistListBox.Visible = false;
			this.playlistListBox.SelectedIndexChanged += new System.EventHandler(this.playlistListBox_SelectedIndexChanged);
			// 
			// newPlaylistButton
			// 
			this.newPlaylistButton.BackColor = System.Drawing.Color.Black;
			this.newPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newPlaylistButton.ForeColor = System.Drawing.Color.White;
			this.newPlaylistButton.Location = new System.Drawing.Point(33, 137);
			this.newPlaylistButton.Name = "newPlaylistButton";
			this.newPlaylistButton.Size = new System.Drawing.Size(182, 69);
			this.newPlaylistButton.TabIndex = 7;
			this.newPlaylistButton.Text = "New Playlist";
			this.newPlaylistButton.UseVisualStyleBackColor = false;
			this.newPlaylistButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// renamePlaylistButton
			// 
			this.renamePlaylistButton.BackColor = System.Drawing.Color.Black;
			this.renamePlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.renamePlaylistButton.ForeColor = System.Drawing.Color.White;
			this.renamePlaylistButton.Location = new System.Drawing.Point(-2, 385);
			this.renamePlaylistButton.Name = "renamePlaylistButton";
			this.renamePlaylistButton.Size = new System.Drawing.Size(125, 35);
			this.renamePlaylistButton.TabIndex = 8;
			this.renamePlaylistButton.Text = "Rename";
			this.renamePlaylistButton.UseVisualStyleBackColor = false;
			this.renamePlaylistButton.Visible = false;
			this.renamePlaylistButton.Click += new System.EventHandler(this.renamePlaylist_Click);
			// 
			// playlistLabel
			// 
			this.playlistLabel.AutoSize = true;
			this.playlistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playlistLabel.ForeColor = System.Drawing.Color.White;
			this.playlistLabel.Location = new System.Drawing.Point(1, 8);
			this.playlistLabel.Name = "playlistLabel";
			this.playlistLabel.Size = new System.Drawing.Size(61, 16);
			this.playlistLabel.TabIndex = 9;
			this.playlistLabel.Text = "Playlist 1";
			this.playlistLabel.Visible = false;
			// 
			// renameTextBox
			// 
			this.renameTextBox.Location = new System.Drawing.Point(0, 7);
			this.renameTextBox.Name = "renameTextBox";
			this.renameTextBox.Size = new System.Drawing.Size(181, 22);
			this.renameTextBox.TabIndex = 10;
			this.renameTextBox.Visible = false;
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.Green;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(187, 5);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(50, 23);
			this.saveButton.TabIndex = 11;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Visible = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
			// 
			// playlistSelectSongsButton
			// 
			this.playlistSelectSongsButton.BackColor = System.Drawing.Color.Black;
			this.playlistSelectSongsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playlistSelectSongsButton.ForeColor = System.Drawing.Color.White;
			this.playlistSelectSongsButton.Location = new System.Drawing.Point(0, 315);
			this.playlistSelectSongsButton.Name = "playlistSelectSongsButton";
			this.playlistSelectSongsButton.Size = new System.Drawing.Size(250, 35);
			this.playlistSelectSongsButton.TabIndex = 12;
			this.playlistSelectSongsButton.Text = "Select songs";
			this.playlistSelectSongsButton.UseVisualStyleBackColor = false;
			this.playlistSelectSongsButton.Visible = false;
			this.playlistSelectSongsButton.Click += new System.EventHandler(this.playlistSelectSongsButton_Click);
			// 
			// selectSongsButton
			// 
			this.selectSongsButton.BackColor = System.Drawing.Color.Black;
			this.selectSongsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectSongsButton.ForeColor = System.Drawing.Color.White;
			this.selectSongsButton.Location = new System.Drawing.Point(0, 315);
			this.selectSongsButton.Name = "selectSongsButton";
			this.selectSongsButton.Size = new System.Drawing.Size(250, 35);
			this.selectSongsButton.TabIndex = 13;
			this.selectSongsButton.Text = "Select Songs";
			this.selectSongsButton.UseVisualStyleBackColor = false;
			this.selectSongsButton.Click += new System.EventHandler(this.selectSongsButton_Click);
			// 
			// sortButton
			// 
			this.sortButton.BackColor = System.Drawing.Color.Black;
			this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sortButton.ForeColor = System.Drawing.Color.White;
			this.sortButton.Location = new System.Drawing.Point(0, 356);
			this.sortButton.Name = "sortButton";
			this.sortButton.Size = new System.Drawing.Size(70, 35);
			this.sortButton.TabIndex = 14;
			this.sortButton.Text = "Sort";
			this.sortButton.UseVisualStyleBackColor = false;
			this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
			// 
			// searchListBox
			// 
			this.searchListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.searchListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchListBox.ForeColor = System.Drawing.Color.White;
			this.searchListBox.FormattingEnabled = true;
			this.searchListBox.ItemHeight = 18;
			this.searchListBox.Location = new System.Drawing.Point(0, 32);
			this.searchListBox.Name = "searchListBox";
			this.searchListBox.Size = new System.Drawing.Size(250, 274);
			this.searchListBox.TabIndex = 15;
			this.searchListBox.SelectedIndexChanged += new System.EventHandler(this.searchListBox_SelectedIndexChanged);
			// 
			// closeSearchButton
			// 
			this.closeSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closeSearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.closeSearchButton.Location = new System.Drawing.Point(221, 3);
			this.closeSearchButton.Name = "closeSearchButton";
			this.closeSearchButton.Size = new System.Drawing.Size(29, 23);
			this.closeSearchButton.TabIndex = 16;
			this.closeSearchButton.Text = "X";
			this.closeSearchButton.UseVisualStyleBackColor = false;
			this.closeSearchButton.Visible = false;
			this.closeSearchButton.Click += new System.EventHandler(this.closeSearchButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Location = new System.Drawing.Point(0, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(144, 836);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// songLibraryButton
			// 
			this.songLibraryButton.BackColor = System.Drawing.Color.Orange;
			this.songLibraryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.songLibraryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.songLibraryButton.Location = new System.Drawing.Point(12, 31);
			this.songLibraryButton.Name = "songLibraryButton";
			this.songLibraryButton.Size = new System.Drawing.Size(120, 60);
			this.songLibraryButton.TabIndex = 18;
			this.songLibraryButton.Text = "Song Library";
			this.songLibraryButton.UseVisualStyleBackColor = false;
			this.songLibraryButton.Click += new System.EventHandler(this.songLibraryButton_Click);
			// 
			// playlistButton
			// 
			this.playlistButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.playlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playlistButton.ForeColor = System.Drawing.Color.White;
			this.playlistButton.Location = new System.Drawing.Point(12, 107);
			this.playlistButton.Name = "playlistButton";
			this.playlistButton.Size = new System.Drawing.Size(120, 60);
			this.playlistButton.TabIndex = 19;
			this.playlistButton.Text = "Playlist";
			this.playlistButton.UseVisualStyleBackColor = false;
			this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
			// 
			// songLibraryPanel
			// 
			this.songLibraryPanel.Controls.Add(this.searchTextBox);
			this.songLibraryPanel.Controls.Add(this.searchButton);
			this.songLibraryPanel.Controls.Add(this.closeSearchButton);
			this.songLibraryPanel.Controls.Add(this.sortButton);
			this.songLibraryPanel.Controls.Add(this.selectSongsButton);
			this.songLibraryPanel.Controls.Add(this.songLibraryListBox);
			this.songLibraryPanel.Controls.Add(this.searchListBox);
			this.songLibraryPanel.Location = new System.Drawing.Point(150, 4);
			this.songLibraryPanel.Name = "songLibraryPanel";
			this.songLibraryPanel.Size = new System.Drawing.Size(280, 432);
			this.songLibraryPanel.TabIndex = 20;
			// 
			// playlistPanel
			// 
			this.playlistPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.playlistPanel.Controls.Add(this.renameTextBox);
			this.playlistPanel.Controls.Add(this.newPlaylistButton);
			this.playlistPanel.Controls.Add(this.playlistLabel);
			this.playlistPanel.Controls.Add(this.playlistListBox);
			this.playlistPanel.Controls.Add(this.playlistSelectSongsButton);
			this.playlistPanel.Controls.Add(this.saveButton);
			this.playlistPanel.Controls.Add(this.renamePlaylistButton);
			this.playlistPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playlistPanel.ForeColor = System.Drawing.Color.White;
			this.playlistPanel.Location = new System.Drawing.Point(950, 4);
			this.playlistPanel.Name = "playlistPanel";
			this.playlistPanel.Size = new System.Drawing.Size(258, 432);
			this.playlistPanel.TabIndex = 21;
			this.playlistPanel.Visible = false;
			// 
			// shufflePlaylistButton
			// 
			this.shufflePlaylistButton.BackColor = System.Drawing.Color.Black;
			this.shufflePlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shufflePlaylistButton.ForeColor = System.Drawing.Color.White;
			this.shufflePlaylistButton.Location = new System.Drawing.Point(572, 319);
			this.shufflePlaylistButton.Name = "shufflePlaylistButton";
			this.shufflePlaylistButton.Size = new System.Drawing.Size(80, 35);
			this.shufflePlaylistButton.TabIndex = 17;
			this.shufflePlaylistButton.Text = "Shuffle";
			this.shufflePlaylistButton.UseVisualStyleBackColor = false;
			this.shufflePlaylistButton.Visible = false;
			this.shufflePlaylistButton.Click += new System.EventHandler(this.shufflePlaylistButton_Click);
			// 
			// MusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1501, 835);
			this.Controls.Add(this.shufflePlaylistButton);
			this.Controls.Add(this.playlistPanel);
			this.Controls.Add(this.playlistButton);
			this.Controls.Add(this.songLibraryButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.songLibraryPanel);
			this.Controls.Add(this.shuffleButton);
			this.Name = "MusicPlayer";
			this.Text = "MusicPlayer";
			this.Load += new System.EventHandler(this.MusicPlayer_Load);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.songLibraryPanel.ResumeLayout(false);
			this.songLibraryPanel.PerformLayout();
			this.playlistPanel.ResumeLayout(false);
			this.playlistPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox songLibraryListBox;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.Button newPlaylistButton;
        private System.Windows.Forms.Button renamePlaylistButton;
        private System.Windows.Forms.Label playlistLabel;
        private System.Windows.Forms.TextBox renameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button playlistSelectSongsButton;
        private System.Windows.Forms.Button selectSongsButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button closeSearchButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button songLibraryButton;
		private System.Windows.Forms.Button playlistButton;
		private System.Windows.Forms.Panel songLibraryPanel;
		private System.Windows.Forms.Panel playlistPanel;
		private System.Windows.Forms.Button shufflePlaylistButton;
	}
}

