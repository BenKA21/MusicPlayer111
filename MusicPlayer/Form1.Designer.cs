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
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(483, 34);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(400, 274);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // songLibraryListBox
            // 
            this.songLibraryListBox.FormattingEnabled = true;
            this.songLibraryListBox.Location = new System.Drawing.Point(12, 31);
            this.songLibraryListBox.Name = "songLibraryListBox";
            this.songLibraryListBox.Size = new System.Drawing.Size(250, 277);
            this.songLibraryListBox.TabIndex = 1;
            this.songLibraryListBox.SelectedIndexChanged += new System.EventHandler(this.songLibraryListBox_SelectedIndexChanged);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(12, 343);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(56, 23);
            this.shuffleButton.TabIndex = 3;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextBox.Location = new System.Drawing.Point(12, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(153, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.Text = "Search song name or artist";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkGreen;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(171, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.Location = new System.Drawing.Point(283, 31);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(183, 277);
            this.playlistListBox.TabIndex = 6;
            this.playlistListBox.Visible = false;
            this.playlistListBox.SelectedIndexChanged += new System.EventHandler(this.playlistListBox_SelectedIndexChanged);
            // 
            // newPlaylistButton
            // 
            this.newPlaylistButton.Location = new System.Drawing.Point(285, 311);
            this.newPlaylistButton.Name = "newPlaylistButton";
            this.newPlaylistButton.Size = new System.Drawing.Size(181, 23);
            this.newPlaylistButton.TabIndex = 7;
            this.newPlaylistButton.Text = "New Playlist";
            this.newPlaylistButton.UseVisualStyleBackColor = true;
            this.newPlaylistButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // renamePlaylistButton
            // 
            this.renamePlaylistButton.Location = new System.Drawing.Point(285, 340);
            this.renamePlaylistButton.Name = "renamePlaylistButton";
            this.renamePlaylistButton.Size = new System.Drawing.Size(125, 23);
            this.renamePlaylistButton.TabIndex = 8;
            this.renamePlaylistButton.Text = "Rename";
            this.renamePlaylistButton.UseVisualStyleBackColor = true;
            this.renamePlaylistButton.Visible = false;
            this.renamePlaylistButton.Click += new System.EventHandler(this.renamePlaylist_Click);
            // 
            // playlistLabel
            // 
            this.playlistLabel.AutoSize = true;
            this.playlistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistLabel.Location = new System.Drawing.Point(283, 6);
            this.playlistLabel.Name = "playlistLabel";
            this.playlistLabel.Size = new System.Drawing.Size(61, 16);
            this.playlistLabel.TabIndex = 9;
            this.playlistLabel.Text = "Playlist 1";
            this.playlistLabel.Visible = false;
            // 
            // renameTextBox
            // 
            this.renameTextBox.Location = new System.Drawing.Point(283, 369);
            this.renameTextBox.Name = "renameTextBox";
            this.renameTextBox.Size = new System.Drawing.Size(181, 20);
            this.renameTextBox.TabIndex = 10;
            this.renameTextBox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(416, 340);
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
            this.playlistSelectSongsButton.Location = new System.Drawing.Point(283, 311);
            this.playlistSelectSongsButton.Name = "playlistSelectSongsButton";
            this.playlistSelectSongsButton.Size = new System.Drawing.Size(123, 23);
            this.playlistSelectSongsButton.TabIndex = 12;
            this.playlistSelectSongsButton.Text = "Select songs";
            this.playlistSelectSongsButton.UseVisualStyleBackColor = true;
            this.playlistSelectSongsButton.Click += new System.EventHandler(this.playlistSelectSongsButton_Click);
            // 
            // selectSongsButton
            // 
            this.selectSongsButton.Location = new System.Drawing.Point(12, 314);
            this.selectSongsButton.Name = "selectSongsButton";
            this.selectSongsButton.Size = new System.Drawing.Size(123, 23);
            this.selectSongsButton.TabIndex = 13;
            this.selectSongsButton.Text = "Select Songs";
            this.selectSongsButton.UseVisualStyleBackColor = true;
            this.selectSongsButton.Click += new System.EventHandler(this.selectSongsButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(74, 343);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(56, 23);
            this.sortButton.TabIndex = 14;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(12, 31);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(227, 277);
            this.searchListBox.TabIndex = 15;
            this.searchListBox.SelectedIndexChanged += new System.EventHandler(this.searchListBox_SelectedIndexChanged);
            // 
            // closeSearchButton
            // 
            this.closeSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeSearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeSearchButton.Location = new System.Drawing.Point(233, 3);
            this.closeSearchButton.Name = "closeSearchButton";
            this.closeSearchButton.Size = new System.Drawing.Size(29, 23);
            this.closeSearchButton.TabIndex = 16;
            this.closeSearchButton.Text = "X";
            this.closeSearchButton.UseVisualStyleBackColor = false;
            this.closeSearchButton.Visible = false;
            this.closeSearchButton.Click += new System.EventHandler(this.closeSearchButton_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 567);
            this.Controls.Add(this.closeSearchButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.selectSongsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.renameTextBox);
            this.Controls.Add(this.playlistLabel);
            this.Controls.Add(this.renamePlaylistButton);
            this.Controls.Add(this.newPlaylistButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.playlistListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.songLibraryListBox);
            this.Controls.Add(this.playlistSelectSongsButton);
            this.Controls.Add(this.searchListBox);
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

