using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace web_browser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object notUsed = null;
            for (; ; )
            {
                axWebBrowser1.Navigate(textBox1.Text, ref notUsed, ref notUsed, ref notUsed, ref notUsed);
                System.Threading.Thread.Sleep(60);
            }
        }
    }
}