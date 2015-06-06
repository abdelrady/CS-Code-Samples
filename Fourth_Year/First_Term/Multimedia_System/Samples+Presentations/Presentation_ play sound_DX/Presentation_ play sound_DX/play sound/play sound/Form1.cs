using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;

namespace play_sound
{
    public partial class Form1 : Form
    {
        //--------------------------------
        	private Device device = null;
            private SecondaryBuffer sound = null;
            private BufferDescription desc;
            private string filepath = "";
            private int position = 0;
            private int len = 0;
        private Boolean playing = false;
        //---------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            device = new Device();
            device.SetCooperativeLevel(this, CooperativeLevel.Normal);
            desc = new BufferDescription();
            desc.GlobalFocus = true; // Why every time I click on another window my wav player dont pause?
            desc.ControlVolume = true;
            pauseB.Enabled = false;
            stopB.Enabled = false;
            
           
        }

        private void loadB_Click(object sender, EventArgs e)
        {
           openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
           openFileDialog1.Filter = "Wav File(*.wav)|*.wav";
           if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName.ToString();
                 
                position = 0;
            }
        }

        private void playB_Click(object sender, EventArgs e)
        {
            if (filepath != "")
            {

                sound = new SecondaryBuffer(filepath, desc, device);
                sound.SetCurrentPosition(position);

                len = sound.Caps.BufferBytes;
                trkSound.Minimum = 0;
                trkSound.Maximum = len;
                trkSound.SmallChange = 1;
                trkSound.LargeChange = 1;
                trkSound.TickFrequency = len;
                playing = true;

                sound.Play(0, BufferPlayFlags.Default);
                timer1.Enabled = true;
                timer1.Start();
                label2.Text = filepath;
                pauseB.Enabled = true;
                stopB.Enabled = true;
            }
        }

        private void pauseB_Click(object sender, EventArgs e)
        {
            position = sound.PlayPosition;
            sound.Stop();
            
        }

        private void stopB_Click(object sender, EventArgs e)
        {
            position = 0;
            sound.Stop();
            timer1.Enabled = false;
            trkSound.Value = 0;
            playing = false;
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (trackBar_volume.Value == trackBar_volume.Minimum)
                {
                    sound.Volume = -10000;
                }
                else
                {
                    sound.Volume = trackBar_volume.Value;
                }
            }
            catch { }
        }

        private void trkSound_Scroll(object sender, EventArgs e)
        {
            if (trkSound.Value < len)
            {
                if (playing)
                {
                    sound.Stop();
                    sound.SetCurrentPosition(trkSound.Value);
                    
                    sound.Play(0, BufferPlayFlags.Default);
                }
                else
                {
                    sound.SetCurrentPosition(trkSound.Value);
                }
            }
            else
            {
                sound.SetCurrentPosition(0);
                
            }
        }
            int h = 0;
           int m = 0;
           int s = 0; int now;
        private void timer1_Tick(object sender, EventArgs e)
        {
            position = sound.PlayPosition;
            trkSound.Value = position;


           now = sound.PlayPosition / sound.Format.AverageBytesPerSecond;
           h = now / 3600;
           m = (now - (h * 3600)) / 60;
           s = now - (h * 3600) - (m * 60);

           label1.Text = h.ToString() + ":" + m.ToString() + ":" + s.ToString();
        }


       

    }
}