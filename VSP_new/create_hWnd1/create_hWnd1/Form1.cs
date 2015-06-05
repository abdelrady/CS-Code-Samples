using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace create_hWnd1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "CreateWindowExA")]
        private static extern long CreateWindowExAsString(long a, string str1,string str2,long b,long c,long d,long e,long f,long g,long h,long i,string str3);
        [DllImport("Msvfw32.dll")]
        private static extern long MCIWndRegisterClass();
        [DllImport("user32.dll")]
        private static extern long DestroyWindow(long a);
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern long SendMessageAsString(long a,long b,long c,string str);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MCIWndRegisterClass();
            long hwnd = CreateWindowExAsString(0, "MCIWndClass", "TEST", 0x800000 | 0x40000000 | 0x10000000 | 0x70 | 0x1F00, 10, 10, 0, 0,long.Parse( this.Handle.ToString()), 
                            0,
                            long.Parse(this.Handle.ToString()), 
                            Application.StartupPath+ "\\macnica.avi");
            SendMessageAsString(hwnd, 0x465, 0, "play repeat");
        }
    }
}
