using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;
namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        
        //----------------------------------------------
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        public static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
        [DllImport("winmm.dll", EntryPoint = "mciGetErrorStringA")]
        public static extern int mciGetErrorString(int fdwError, string lpszErrorText, int textLength);

        //---------------------------------------------
        public string filepath = ""; int len = 0; int step = 10;
        public int leftx, topy, widthx, heighty;
       
        public bool fullscreen = false;
        public ArrayList playlist;
        public int playindex = 0;
        public int listboxw = 0;
        //---------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }
//--------------------------------------------------------------
        private void closeB_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
//-----------------------------------------------------------
        private void openB_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
           // close_Vedio();
           // panel1.BackColor = Color.Black;
            ofl1.InitialDirectory = Directory.GetCurrentDirectory();
            ofl1.Filter = "*.avi|*.avi|*.mpg|*.mpg|*.wmv|*.wmv|wav (*.wav)|*.wav|mp3(*.mp3)|*.mp3|mid(*.mid)|*.mid|allfiles(*.*)|*.*";
            if (ofl1.ShowDialog() == DialogResult.OK)
            {
                filepath = ofl1.FileName.ToString();
                //MessageBox.Show(filepath);

                System.IO.FileInfo file = new System.IO.FileInfo(filepath);
                listBox1.Items.Add(file.Name);
                playlist.Add(filepath);
            }
        }
//--------------------------------------------------------------
        public void playB_Click(object sender, EventArgs e)
        {
            if (playB.Text == ">")
            {
                
                if (filepath != "")
                {
                    try
                    {

                       int ret= play_Vedio();
                       if (ret != 0)
                       {
                           int ret2 = play_sound();
                           if (ret2 == 0)
                           {
                               panel1.Visible = true;
                              
                               trackBar2_Scroll(sender, e);
                               playB.Text = "||";
                           }
                           else
                           {
                               MessageBox.Show("can not play item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }

                       }
                       else
                       {
                           panel1.Visible = false;
                           trackBar2_Scroll(sender, e);
                           playB.Text = "||";
                       }
                    }
                    catch
                    {
                        MessageBox.Show("can not play item","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                playB.Text = ">";
                mciSendString("pause asd", null, 0, IntPtr.Zero);
            }
        }

//----------------------------------------------------------------
        private void fullB_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listB_Click(sender, e);
            fullscreen = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Top = 0; topy = this.Top;
            this.Left = 0;leftx = this.Left;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width; widthx = this.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height+30; heighty = this.Height-groupBox1.Height;
            panel1.Height = this.Height - groupBox1.Height;
            mciSendString("PUT asd WINDOW AT " + leftx + " " + topy + " " + widthx + " " + heighty, null, 0, IntPtr.Zero);
            groupBox1.Left=((widthx-groupBox1.Width)/2);
            groupBox1.Top = heighty;
           // groupBox1.Visible = false;
           
        }
//------------------------------------------------
        public void stopB_Click(object sender, EventArgs e)
        {
            stop_Vedio();
            playB.Text = ">";
           
        }
//--------------------------------------------------------
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value * step);
            mciSendString("SEEK asd TO " + textBox1.Text, null, 0, IntPtr.Zero);
            mciSendString("play asd", null, 0, IntPtr.Zero);
        }
//------------------------------------------------------
       StringBuilder buffer2 = new StringBuilder(260);
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int ret = mciSendString("STATUS asd POSITION", buffer2, buffer2.Capacity, IntPtr.Zero);
             textBox1.Text = int.Parse(buffer2.ToString()).ToString();
             trackBar1.Value = int.Parse(buffer2.ToString()) / step;
            if (int.Parse(buffer2.ToString())>= len)
            {
                timer1.Enabled = false;
                stop_Vedio();
             
            }
        }
//----------------------------------------------------------
        public int play_Vedio()
        {
            close_Vedio();
            mciSendString("open " + filepath + " alias asd TYPE MPEGVIDEO PARENT " + this.panel1.Handle.ToString() + " STYLE child", null, 0, IntPtr.Zero);
           int ret= mciSendString("play asd", null, 0, IntPtr.Zero);
            //StringBuilder st=new StringBuilder(128);
           //string st = "";
           // mciGetErrorString( ret,st,128);
           //MessageBox.Show(st.ToString());
           if (ret == 0)
           {
               mciSendString("PUT asd WINDOW AT " + leftx + " " + topy + " " + widthx + " " + heighty, null, 0, IntPtr.Zero);
               //--------------------------------------------------
               length_media();
           }
           return ret;
        }
//-------------------------------------------------------------
        private int play_sound()
        {
            close_Vedio();
            mciSendString("open " + filepath + " alias asd ", null, 0, IntPtr.Zero);
            int ret = mciSendString("play asd", null, 0, IntPtr.Zero);
            if (ret == 0)
            {
                
                //--------------------------------------------------
                length_media();
            }
            return ret;
        }
//-------------------------------------------------------------
        public void stop_Vedio()
        {
            textBox1.Text = Convert.ToString(0);
            mciSendString("SEEK asd TO " + textBox1.Text, null, 0, IntPtr.Zero);
            trackBar1.Value = 0;
            timer1.Enabled = false;
            
        }
//------------------------------------------------------------
        public void close_Vedio()
        {
            mciSendString("CLOSE asd", null, 0, IntPtr.Zero);
        }
//------------------------------------------------------------
        public void length_media()
        {
            StringBuilder buffer = new StringBuilder(260);
            int ret = mciSendString("STATUS asd LENGTH", buffer, buffer.Capacity, IntPtr.Zero);
            len = int.Parse(buffer.ToString());
            textBox1.Text = len.ToString();
            trackBar1.Maximum = ((len / step));
            timer1.Enabled = true;
            playB.Text = "||";
        }
//------------------------------------------------------------

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            mciSendString("SETAUDIO asd VOLUME TO " + Convert.ToString(trackBar2.Value * 10), null, 0, IntPtr.Zero);
            // mciSendString("play asd", null, 0, IntPtr.Zero);
        }
//-------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            leftx = panel1.Left;
            topy = panel1.Top;
            widthx = panel1.Width;
            heighty = panel1.Height;
            playlist = new ArrayList();
            listboxw = listBox1.Width;
            
        }
        //----------------------------------------------------
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left = leftx;
            panel1.Top = topy;
            panel1.Height = this.Height - groupBox1.Height-50;
            panel1.Width = this.Width - (2 * leftx)-listboxw;
            listBox1.Left = leftx + panel1.Width;
            listBox1.Top = topy;
            listBox1.Height =this.Height;
           
        }
        private void groupBox1_Resize(object sender, EventArgs e)
        {
            trackBar2.Left = groupBox1.Right-trackBar2.Width - 10;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            heighty = panel1.Height;
            widthx = panel1.Width;
            groupBox1.Width = panel1.Width+10;
            mciSendString("PUT asd WINDOW AT " + leftx + " " + topy + " " + widthx + " " + heighty, null, 0, IntPtr.Zero);
        }
        //-------------------------------------------------------------
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          /* if (fullscreen)
           {
                panel1.Height -= groupBox1.Height-30;
                groupBox1.Visible = true;
           }*/
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // loop through the string array, adding each filename to the ListBox
            foreach (string file in files)
            {
                filepath = file;
                playB_Click(sender, e);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                // allow them to continue
                // (without this, the cursor stays a "NO" symbol
                e.Effect = DragDropEffects.All;
        }
        //*****************************************************
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            // foreach loop in place of "files", but this is easier to understand.)
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // loop through the string array, adding each filename to the ListBox
            foreach (string file in files)
            {
                System.IO.FileInfo fil = new System.IO.FileInfo(file);
                listBox1.Items.Add(fil.Name);
                playlist.Add(file);
            }
        }
        //---------------------------------------------------------------
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                // allow them to continue
                // (without this, the cursor stays a "NO" symbol
                e.Effect = DragDropEffects.All;
        }
        //------------------------------------------------------------
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int index = listBox1.SelectedIndex;
                if (index != playindex)
                {
                    listBox1.Items.RemoveAt(index);
                    playlist.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("This item running", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
      
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //f.timer1.Enabled = false;
            playindex = listBox1.SelectedIndex;
            if (playindex >= 0 && playindex < listBox1.Items.Count)
            {
                filepath = playlist[playindex].ToString();
                stop_Vedio();
                close_Vedio();
                play_Vedio();
            }
        }

        private void listB_Click(object sender, EventArgs e)
        {
            if (!fullscreen)
            {
                if (listBox1.Visible == true)
                {
                    listBox1.Visible = false;
                    panel1.Width = this.Width;
                    widthx = panel1.Width;
                    listboxw = 0;
                    panel1_Resize(sender, e);
                }
                else if (listBox1.Visible == false)
                {
                    listBox1.Visible = true;
                    panel1.Width = this.Width - listBox1.Width;
                    widthx = panel1.Width;
                    listboxw = listBox1.Width;
                    panel1_Resize(sender, e);
                }
            }
        }
 
 

    }
}