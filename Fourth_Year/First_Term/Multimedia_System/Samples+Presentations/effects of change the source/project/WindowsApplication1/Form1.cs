using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace multimedia
{
    public partial class Form1 : Form
    {
        int value1 = 0;
        public string filepath="";
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet=CharSet.Ansi )]
        protected static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
      

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            value1 = e.Y;
            mciSendString("SETAUDIO asd VOLUME TO "+ Convert.ToString(value1*3), null, 0, IntPtr.Zero);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            mciSendString("close asd", null, 0, IntPtr.Zero);
            opfile.InitialDirectory = "Media";
            opfile.Filter = "wav (*.wav)|*.wav|mp3(*.mp3)|*.mp3|mid(*.mid)|*.mid|allfiles(*.*)|*.*";
            if (opfile.ShowDialog() == DialogResult.OK)
            {
                filepath = opfile.FileName.ToString();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mciSendString("open " + filepath + "  alias asd", null, 0, IntPtr.Zero);
            mciSendString("play asd ", null, 0, IntPtr.Zero);

        }
    }
}