using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Skin_detection_Via_Hue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();
            opg.Filter = "Image Files(*.*) | *.bmp";
            if (opg.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(opg.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ThreadPool.QueueUserWorkItem(new WaitCallback(test),null);
            Bitmap bmp = new Bitmap(this.pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);

            MachineVision.Vision.DetectSkin(bmp, ref bmp2);
            Thread.Sleep(100);
            this.pictureBox2.Image = bmp2;

            
        }
        private void test(object state)
        {
            Bitmap bmp = new Bitmap(this.pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int i, rg, by;
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {

                }
        }
    }
}