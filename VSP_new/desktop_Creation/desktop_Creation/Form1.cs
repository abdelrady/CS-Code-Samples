using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Locker;
using System.Diagnostics;

namespace desktop_Creation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.FocuseWindows(this.Handle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLocker.Enabled = false;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            ProcessStartInfo psi = new ProcessStartInfo("explorer.exe");
            Process ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("explorer.exe");
            Process ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(Environment.SystemDirectory + "\\shutdown.exe", "-l");
            Process ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CLocker.switchDesktopMethod(288);
        }
    }
}