using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cursor_moving1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Position = new Point(i,j);
            
            i++; j++;
        }
        int i=0, j = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.PerformClick()
            this.timer1.Enabled = true;
        }
    }
}