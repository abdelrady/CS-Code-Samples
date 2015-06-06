using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Merge2Files1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string file1, file2, file3;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)file1 = openFileDialog1.FileName;
            textBox1.Text = file1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) file2 = openFileDialog1.FileName;
            textBox2.Text = file2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) file3 = saveFileDialog1.FileName;
            textBox3.Text = file3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Merge2Files(file1, file2, file3);

        }

        private void Merge2Files(string file1, string file2, string file3)
        {
            int bytesReaded;

            FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream fs3 = new FileStream(file3, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            byte[] buffer=new byte[1000];
            while((bytesReaded=fs1.Read(buffer,0,1000))!=0)
            {
                fs3.Write(buffer, 0, bytesReaded);
            }
            fs1.Close();
            while ((bytesReaded = fs2.Read(buffer, 0, 1000)) != 0)
            {
                fs3.Write(buffer, 0, bytesReaded);
            }
            fs2.Close();
            fs3.Close();

        }

    }
}