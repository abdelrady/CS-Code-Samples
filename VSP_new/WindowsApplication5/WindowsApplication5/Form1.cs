using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Locker;

namespace WindowsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.FocuseWindows(this.Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Global.FocuseWindows(this.Handle);
        }
    }
}