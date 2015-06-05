using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Data_Compression_and_Encryption;
using Spy_Client;
using System.IO;

namespace Compression_Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //compression.Compress();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imageData;
            imageData=DesktopCapture.GetDesktopImage();
            MemoryStream ms = new MemoryStream(imageData);
            pictureBox1.Image = null;
            pictureBox1.Image = Image.FromStream((Stream)ms);
            ms.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageData;
            imageData = DesktopCapture.GetDesktopImage();
            MessageBox.Show(imageData.Length.ToString());
            imageData=compression.Compress(imageData);
            MessageBox.Show(imageData.Length.ToString());
            imageData = compression.DeCompress(imageData);
            MessageBox.Show(imageData.Length.ToString());
            MemoryStream ms = new MemoryStream(imageData);
            pictureBox1.Image = null;
            pictureBox1.Image = Image.FromStream((Stream)ms);
            ms.Close();
        }
    }
}