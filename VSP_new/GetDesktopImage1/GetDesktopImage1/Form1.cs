using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace GetDesktopImage1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MemoryStream io;
        byte[] arr1, arr2,arr3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            arr1 = Spy_Client.DesktopCapture.GetDesktopImage();
            arr2 = new byte[arr1.Length];
            arr3 = new byte[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = (byte)(arr1[i] - arr2[i]);
            }
            arr2 = arr1;
           io=new MemoryStream();
           GZipStream compressedzipStream = new GZipStream(io, CompressionMode.Compress, true);
           compressedzipStream.Write(arr3, 0, arr3.Length);
           // Close the stream.
           compressedzipStream.Close();
           pictureBox1.Image = Image.FromStream(new MemoryStream(arr3));
           this.Text ="Org. Length: "+arr1.Length.ToString()+"  Commpressed Length: " + io.ToArray().Length.ToString();
           arr1 = null;
           arr2 = null;
           arr3 = null;
           GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}