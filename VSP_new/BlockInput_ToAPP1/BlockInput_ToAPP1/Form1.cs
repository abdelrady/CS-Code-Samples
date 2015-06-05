using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace BlockInput_ToAPP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern int EnableWindow(IntPtr hwnd, bool enable);
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process[] ps = Process.GetProcessesByName("explorer");
            Process[] ps = Process.GetProcesses();
            for (int i = 0; i < ps.Length; i++)
            {
                try
                {
                    EnableWindow(ps[i].Handle, false);
                }
                catch { }
            }
            EnableWindow(Handle/*ps[0].Handle*/, true);
            //Thread.Sleep(10000);
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] ps = Process.GetProcesses();
            for (int i = 0; i < ps.Length; i++)
            {
                try
                {
                    EnableWindow(ps[i].Handle, true);
                }
                catch { }
            }
            EnableWindow(Handle/*ps[0].Handle*/, true);

            timer1.Stop();
            MessageBox.Show("");
        }
    }
}