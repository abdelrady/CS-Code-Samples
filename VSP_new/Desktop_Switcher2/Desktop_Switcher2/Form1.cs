using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Onyeyiri;
using System.Diagnostics;

namespace Desktop_Switcher2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processes = Desktop.GetInputProcesses();
            Process thisProc = Process.GetCurrentProcess();
            foreach (Process p in processes)
            {
                if (p.ProcessName != thisProc.ProcessName)
                {
                    p.Kill();
                }
            }

        }
    }
}