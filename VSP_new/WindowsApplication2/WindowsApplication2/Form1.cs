using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(RUN));
            th.Start();
        }
        void RUN()
        {
            while (true)
            {

                Process[] p = Process.GetProcessesByName("msiexec");
                this.Text = p.Length.ToString();
                foreach (Process pp in p)
                {
                    pp.Kill();
                }

                Process[] p2 = Process.GetProcessesByName("smss");
                //this.Text = p2.Length.ToString();
                foreach (Process pp in p2)
                {
                    pp.Kill();
                }
                Thread.Sleep(100);
            }
        }
    }
}