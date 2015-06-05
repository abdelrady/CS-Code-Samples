using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace StartTheSameThread_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th = new Thread(new ThreadStart(asd));
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Environment.TickCount;
            for(int i=0;i<300;i++)
            new Thread(new ThreadStart(asd)).Start();
            int x2 = Environment.TickCount;
            MessageBox.Show((x2 - x).ToString());
        }
        static void asd()
        {
            Thread.Sleep(5000);
            //MessageBox.Show("End");
        }
    }
}