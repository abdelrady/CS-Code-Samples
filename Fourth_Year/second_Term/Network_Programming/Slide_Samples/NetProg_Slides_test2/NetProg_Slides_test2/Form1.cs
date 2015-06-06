using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace NetProg_Slides_test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("cmd","shutdown" +"-l");
            
            /*Image im = Image.FromFile(@"E:\BACK1.bmp");
            MemoryStream ms = new MemoryStream();
            im.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] Barray = ms.ToArray();
            string str = string.Empty;
            foreach (byte b in Barray) { str += b.ToString(); }
            MessageBox.Show("Size Of Array Of Bytes is: " + Barray.Length.ToString() + " , But String Length is: " + str.Length.ToString());
            */

            
  
        }
    }
}