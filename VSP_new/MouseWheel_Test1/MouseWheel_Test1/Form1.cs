using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MouseWheel_Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Form1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Text = e.Delta.ToString();
        }
    }
}