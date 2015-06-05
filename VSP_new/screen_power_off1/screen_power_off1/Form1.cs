using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace screen_power_off1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr handle, int msg, int wp, int lp);
        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0x170, 2);
            Thread.Sleep(2000);
            SendMessage(this.Handle, 0x112, 0x170, (-1));

        }
    }
}