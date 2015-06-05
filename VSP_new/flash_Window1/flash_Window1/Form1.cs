using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace flash_Window1
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int FlashWindow(System.IntPtr hwnd, int bInvert);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlashWindow(Handle, 1);
            Thread.Sleep(1000);
            FlashWindow(Handle, 0);
        }
    }
}