using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace cdaudio1
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(
            string command, StringBuilder returnValue,
            int returnLength, IntPtr Handle);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Command = "set CDAudio door open";
            mciSendString(Command, null, 0, IntPtr.Zero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Command = "set CDAudio door closed";
            mciSendString(Command, null, 0, IntPtr.Zero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Play Tracks")
            {

                this.textBox1.Enabled = true;
                this.textBox2.Enabled = true;
                button3.Text = "Play Now";
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else if (button3.Text == "Play Now" && textBox1.Text != "" && textBox2.Text != "")
            {
                mciSendString("set cdaudio time format hms", null, 0, IntPtr.Zero);
                string Command = "play cdaudio from "+textBox1.Text+" to "+textBox2.Text;
                mciSendString(Command, null, 0, IntPtr.Zero);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mciSendString("pause cdaudio", null, 0, IntPtr.Zero);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mciSendString("close cdaudio", null, 0, IntPtr.Zero);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
