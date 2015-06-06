using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MiniPlayer
{
    public partial class Form1 : Form
    {
        private Media media;

        public Form1()
        {
            InitializeComponent();
            media = new Media();
            RefreshStop(false);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            media.Stop();
            Application.Exit();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            browseDialog.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            browseDialog.ShowDialog();
            if (browseDialog.FileName != "")
                mediaFileTextBox.Text = browseDialog.FileName;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(mediaFileTextBox.Text))
            {
                media.Play(mediaFileTextBox.Text, this);
                RefreshStop(true);
            }
            else
            {
                MessageBox.Show("The media file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            media.Stop();
        }

        //Override the WndProc function in the form
        //to receive the notify message when the playback complete
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Media.MM_MCINOTIFY)
            {
                RefreshStop(false);
            }
            base.WndProc(ref m);
        }


        private void RefreshStop(bool stop)
        {
            stopButton.Enabled = stop;
        }
    }
}