using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace PlaySound_Function1
{
    public partial class Form1 : Form
    {
        public const long SND_ASYNC = 0x1;
        public const long SND_FILENAME = 0x20000;
        [DllImport("winmm.dll",EntryPoint="PlaySoundA")]
        private static extern long PlaySound(string path,long hmodule,long dwFlags);
        public Form1()
        {
            InitializeComponent();
        }
        string fileName="";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf1 = new OpenFileDialog();
            opf1.Filter="Wave Files(*.wav) | *.wav";
            if (opf1.ShowDialog() == DialogResult.OK) fileName = opf1.FileName;
            else fileName = "f:\\ibrahiem.wav";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PlaySound("SystemExclamation", 0, 0x0); 

            PlaySound(fileName, 0,0x1);
            //Thread.Sleep(500);
            PlaySound(null, 0, 0x2 | 0x40);
            MessageBox.Show("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlaySound(null, 0, 0x2 | 0x40);
        }
    }
}
