using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        int n,m;
        Color x = new Color();
        bool paint = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
             paint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                Graphics asd = base.CreateGraphics();
                asd.FillEllipse(new SolidBrush(x ), e.X, e.Y, m , n );
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                x = Color.Green ;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            x = Color.Black;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            m = 3;
            n = 3;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            m = 5;
            n = 5;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            m = 8;
            n = 8;
        }
           
    }
        }
    
