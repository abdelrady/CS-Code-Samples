using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace auto_show_pic
{
    public partial class Form1 : Form
    {
        int number =1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //button1. 
            //timer1.Enabled = true;
            //timer1.Interval = 1000;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (number > 10)
                number = 1;
            //label1.Text = number.ToString("00");
            
            int r = x.Next(1,11);
            if (!i[r])
            {
                i[r] = true;
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory()
                + "\\pic\\1 (" + r.ToString() + ").jpg");
                number++;
            }
            else pictureBox1_Click(sender, e);
        }
        Random x;
        bool[] i = new bool[11];
        private void Form1_Load(object sender, EventArgs e)
        {
            x = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}