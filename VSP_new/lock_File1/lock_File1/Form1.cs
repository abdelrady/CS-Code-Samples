using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading;

namespace lock_File1
{
    public partial class Form1 : Form
    {
        FileStream fs;
        //byte[] fileContents;
        //AsyncCallback callback;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
            fs.Seek(0, SeekOrigin.Begin);
            fs.Lock(0, fs.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fs.Unlock(0, fs.Length);
            Application.Exit();
        }
    }
}