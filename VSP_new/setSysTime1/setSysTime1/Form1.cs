using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace setSysTime1
{
  
    public partial class Form1 : Form
    {
        struct TimeStruct
        {
            int year, month, dayofweek, day, hour, minute, second, msecond;
        }
        [DllImport("Kernel32")]
        public static extern int SetSystemTime(TimeStruct ts);
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            TimeStruct x = new TimeStruct();
            x.year = 2007;
            x.month = 12;
            x.day = 15;
            x.hour = 5;
            x.minute = 8;
            x.second = 10;
            x.msecond = 19;
            x.dayofweek = 0;
           MessageBox.Show( SetSystemTime(x).ToString());
        }
    }
}