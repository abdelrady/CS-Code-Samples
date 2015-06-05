using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReduceFormFlicker_Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        e.Graphics.FillEllipse(Brushes.DarkBlue, new
            Rectangle(10,10,60,60));
        e.Graphics.FillRectangle(Brushes.Khaki, new
            Rectangle(20,30,60,10));
        e.Graphics.CopyFromScreen(new Point(10, 10), new Point(100, 100), 
            new Size(70, 70));


        }
    }
}