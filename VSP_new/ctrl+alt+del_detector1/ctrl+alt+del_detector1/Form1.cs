using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ctrl_alt_del_detector1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            Process[] p1;
            p1 = Process.GetProcessesByName("explorer");
            ProcessStartInfo ps;
//            StreamWriter sw = new StreamWriter("f:\\q.txt",true);

            //foreach (Process p in p1)
            {
  //              sw.WriteLine(p.MainWindowTitle);
                //MessageBox.Show(p.MainWindowTitle);
                //ps=p.StartInfo;

                p1[0].Kill();
            }
           // sw.Close();*/
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] p1;
            p1 = Process.GetProcessesByName("taskmgr");
            //ProcessStartInfo ps;
            foreach (Process p in p1)
            {
                //MessageBox.Show(p.MainWindowTitle);
                //ps=p.StartInfo;
                
                p.Kill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = true;
            //MessageBox.Show("deactivate");
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("leave");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}