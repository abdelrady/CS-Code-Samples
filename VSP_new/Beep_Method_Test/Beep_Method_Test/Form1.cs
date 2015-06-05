using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Beep_Method_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("Kernel32.dll")]
        public static extern int Beep(int Freq, int Duration);

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 37; i < 32500;i++ )
            {
                Beep(i, 150);
            }
        }
    }
}