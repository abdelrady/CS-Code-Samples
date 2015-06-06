using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Wave_Player
{
    public partial class Form1 : Form
    {
        private Media mm_media;
        private int z = 0;
        public Array  x ;
        public int xx = 0;
        private bool press_in = false;
        
        public Form1()
        {
            InitializeComponent();
            mm_media = new Media();
            RefreshStop(false);
            toolTip1.SetToolTip(button5, "Eject / Inject CD.");
            toolTip1.SetToolTip(button1, "Search For Media File.");
            toolTip1.SetToolTip(button4, "Exit The Program.");
            toolTip1.SetToolTip(button3, "Stop Playing The Media File.");
            toolTip1.SetToolTip(button2, "Playing The Media File.");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mm_media.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(label2.Text))
            {
                x = File.ReadAllBytes(label2.Text);
                mm_media.Play(label2.Text, this);
                RefreshStop(true);
                timer1.Enabled = true;
               
            }
            else
            {
                MessageBox.Show("The media file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RefreshStop(bool stop)
        {
            button3.Enabled = stop;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label3.Text = "";
           // label3.AutoSize = true;

            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Media File(*.mp3,*.wav,*.avi,*.mpg,*.dat,*.wmv)|*.mp3;*.wav;*mpg;*.wmv;*.avi;*.dat";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                label2.Text = openFileDialog1.FileName;
                label3.Text = label2.Text;
            }

            else
            {
                timer1.Enabled = false;
                label3.Text = "Eng :Hossam El-Dien Hassan";
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
        
            if (xx <= (-1) * this.Width/3)
            { xx = this.Width; }
            else
            {label3.Location = new Point(--xx, label3.Location.Y);}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (press_in == false)
            {
                mm_media.Eject();
                press_in = true;
                button5.BackColor = Color.ForestGreen;
            }
            else
            {
                mm_media.Inject();
                button5.BackColor = Color.Gold;
                press_in = false;
            }

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                string ext1 = Path.GetExtension(files[0].ToString());
                string ext=ext1.ToLower();
                if (ext==".mp3"|| ext==".wav"|| ext==".avi"||ext==".wmv"||ext==".mpg"||ext==".dat")
                    label2.Text = Path.GetFullPath(files[0].ToString()).ToString();
                else { }
//               
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
              
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xx = label3.Location.X;
        }
       
    }
}