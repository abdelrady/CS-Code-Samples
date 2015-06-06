using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Backup_files_filestream1
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK) file1 = openFileDialog1.FileName;
            textBox1.Text = file1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) file3 = saveFileDialog1.FileName;
            textBox3.Text = file3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] arr=new byte[1024];
            int NumOfBytes = 0;
            FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream fs3 = new FileStream(file3, FileMode.CreateNew , FileAccess.Write, FileShare.Read);
            MemoryStream ms1 = new MemoryStream();
            while((NumOfBytes=fs1.Read(arr,0,arr.Length))!=0)
            {
                ms1.Write(arr, 0, NumOfBytes);
                //fs3.Write(arr, 0, NumOfBytes);
            }
            ms1.WriteTo(fs3);

            ms1.Close();
            fs1.Close();
            fs3.Close();
            MessageBox.Show("Successfully Backing Up File.");
        }
    }
}