using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Compressed_PictureBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Text Files(*.Images)|(*.bmp;*.jpg;*.png;*.gif)";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image =Image.FromFile( openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs3 = new FileStream( saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                GZipStream gs = new GZipStream(fs3, CompressionMode.Compress);
                MemoryStream ms=new MemoryStream();
                pictureBox1.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                gs.Write(ms.ToArray(), 0,Convert.ToInt32( ms.Length));
                gs.Close();
                ms.Close();
                MessageBox.Show("Successfully Saving Image To File.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] arr;
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Text Files(*.rar)|*.rar";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.FileName);
                FileStream fs3 = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                GZipStream gs = new GZipStream(fs3, CompressionMode.Decompress);
                arr=new byte[fs3.Length];
                
                gs.Read(arr, 0, arr.Length);
                pictureBox1.Image = Image.FromStream(new MemoryStream(arr));

                gs.Close();
                //MessageBox.Show("Successfully Saving Image To File.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}