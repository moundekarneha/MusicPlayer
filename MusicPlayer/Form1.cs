using System;
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
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        //create global string type array to save the title and name of the track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select songs
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //code to select multiple files
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;//save the name of track 
                paths = openFileDialog.FileNames;//save the path of track

                //display the music title in list box
                for(int i=0;i<files.Length;i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }

            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play the music
            windowsPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //close the app
            this.Close();
        }
    }
}
