using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime startTime;
        int myIncrementor = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            int workerThreads = 0;
            int IOThreads = 0;
            ThreadPool.GetMaxThreads(out workerThreads, out IOThreads);
            lblThreads.Text = "Threads: " + workerThreads;
            startTime = DateTime.Now;
            for (int threads = 0; threads < workerThreads; threads++)
            {
                ThreadPool.QueueUserWorkItem(new
                WaitCallback(this.Increment), this);
            }
            
        }
        public void Increment(object state)
        {
            Thread.Sleep(1);
            while (true)
            {   
                myIncrementor++;
                long ticks = DateTime.Now.Ticks - startTime.Ticks;
                lock (this)
                {
                    lblIPS.Text = "Increments per second:" +
                    ((double)(myIncrementor) / ticks) * 10000000;
                }
            }
        }
    }
}