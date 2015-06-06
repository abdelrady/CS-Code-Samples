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
        int z = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random x = new Random();
            int n = x.Next(1, 10);
            int y = x.Next(1, 10);
            z = n * y;
            label1.Text="How much  "+n  +"  Times  "+ y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = int.Parse(textBox1.Text);
            if (l == z)
                MessageBox.Show("Very Good!","True Answer",MessageBoxButtons .OK ,MessageBoxIcon.Information );
            else
            {
                MessageBox.Show("Try Again", "False answer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox1.Text="";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random x = new Random();
            int n = x.Next(1, 10);
            int y = x.Next(1, 10);
            z = n * y;
            label1.Text = "How much  " + n + "  Times  " + y;
        }
    }
}