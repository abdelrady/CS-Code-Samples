using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using audio;


namespace WaveOutOpen_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void showMsg(string str)
        {
            MessageBox.Show(str);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == audio.audio.MM_WOM_DONE)
            {
                button4.Enabled = false;
                audio.audio.Free();
            }
            base.WndProc(ref m);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Wave Files|*.wav|all files|*.*";
            openFileDialog.ShowDialog();
            tbWave.Text = openFileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Resume")
            {
                audio.audio.Resume();
                return;
            }
            string filename = tbWave.Text;
            audio.audio.LoadFile(ref filename);
            audio.audio.Play(-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            audio.audio.Pause();
            button2.Text = "Resume";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            audio.audio.Stop();
            button2.Text = "Play";
        }
    }
}