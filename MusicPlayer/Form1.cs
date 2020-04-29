using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        String[] paths, files;

        String[] pathsP, filesP;

        private void songLibraryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[songLibraryListBox.SelectedIndex]; //Plays the selected song

        }


        private void button1_Click(object sender, EventArgs e)
        {
            playlistLabel.Visible = true;
            playlistListBox.Visible = true;
            renamePlaylistButton.Visible = true;
			playlistSelectSongsButton.Visible = true;

            newPlaylistButton.Enabled = false;
            newPlaylistButton.Visible = false;

			newPlaylistButton.Visible = false;

			

        }

        private void renamePlaylist_Click(object sender, EventArgs e)
        {
            
            renameTextBox.Visible = true;
            saveButton.Visible = true;
        }

        private void playlistSelectSongsButton_Click(object sender, EventArgs e)
        {
            //Code to select songs
            OpenFileDialog ofdP = new OpenFileDialog();

            //Code to select multiple files
            ofdP.Multiselect = true;

            if (ofdP.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filesP = ofdP.SafeFileNames; //Save the names of the track in files array
                pathsP = ofdP.FileNames; //Save the paths of the tracks in paths array


                //Display the music titles in listbox

                for (int i = 0; i < filesP.Length; i++)
                {
                    playlistListBox.Items.Add(filesP[i]);
                }


            }
        }

        private void playlistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pathsP[playlistListBox.SelectedIndex];
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            //Checks every item for the text in search box
            for (int i = 0; i < songLibraryListBox.Items.Count; i++)
            {
                if (songLibraryListBox.Items[i].ToString().ToLower().Contains(searchTextBox.Text.ToLower()))

                {
                    searchListBox.Items.Add(songLibraryListBox.Items[i]);
                }

            }

            this.searchListBox.BringToFront();

            closeSearchButton.Visible = true;

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            //Code to sort items in list box
            ArrayList q = new ArrayList();
            foreach (object o in songLibraryListBox.Items)
                q.Add(o);
            {
                q.Sort();
                songLibraryListBox.Items.Clear();

                foreach (object o in q)
                {
                    songLibraryListBox.Items.Add(o);
                }
            }
        }

        private void shuffleButton_Click_1(object sender, EventArgs e)
        {
            //Finds how many songs are currently in library
            int numberOfSongs = songLibraryListBox.Items.Count;

            //Chooses random number between 0 and total amount of songs in library
            Random rnd = new Random();
            int shufflePick = rnd.Next(0, numberOfSongs);

            //Selects song based on random number
            songLibraryListBox.SelectedIndex = shufflePick;
        }


            
        

        private void searchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[searchListBox.SelectedIndex]; //Plays the selected song
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

		private void playlistButton_Click(object sender, EventArgs e)
		{
			playlistPanel.Visible = true;

			songLibraryPanel.Visible = false;

			playlistButton.BackColor = Color.Orange;
			songLibraryButton.BackColor = Color.Black;

			shuffleButton.Visible = false;
			shufflePlaylistButton.Visible = true;
		}

		private void songLibraryButton_Click(object sender, EventArgs e)
		{
			playlistPanel.Visible = false; 

			songLibraryPanel.Visible = true;

			shuffleButton.Visible = true;
			shufflePlaylistButton.Visible = false;

			songLibraryButton.BackColor = Color.Orange;
			playlistButton.BackColor = Color.Black;
		}

		private void shufflePlaylistButton_Click(object sender, EventArgs e)
		{
			//Finds how many songs are currently in library
			int playlistNumberOfSongs = playlistListBox.Items.Count;

			//Chooses random number between 0 and total amount of songs in library
			Random rnd = new Random();
			int playlistShufflePick = rnd.Next(0, playlistNumberOfSongs);

			//Selects song based on random number
			songLibraryListBox.SelectedIndex = playlistShufflePick;
		}

		private void closeSearchButton_Click(object sender, EventArgs e)
		{
			//makes UI changes
			this.searchListBox.SendToBack();
			closeSearchButton.Visible = false;

			//resets search textbox, and search listbox
			searchTextBox.Text = "";
			searchListBox.Items.Clear();

		}

		private void selectSongsButton_Click(object sender, EventArgs e)
        {
            //Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            //Code to select multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames; //Save the paths of the tracks in paths array

                //Display the music titles in listbox

                for (int i = 0; i < files.Length; i++)
                {
                    songLibraryListBox.Items.Add(files[i]);
                }

            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            playlistLabel.Text = renameTextBox.Text;
            renameTextBox.Visible = false;
            saveButton.Visible = false;
        }

    }
    
}
