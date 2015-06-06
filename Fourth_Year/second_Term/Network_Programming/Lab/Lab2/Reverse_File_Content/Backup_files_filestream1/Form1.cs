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
            string str = "";
            FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream fs3 = new FileStream(file3, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            StreamReader sw1 = new StreamReader(fs1);
            byte[] data = new byte[fs1.Length];
            fs1.Read(data, 0, (int)fs1.Length);

            Array.Reverse(data);
            fs3.Write(data, 0, data.Length);
            /*str=sw1.ReadToEnd();
            for (int i = 0; i < str.Length; i++)
            {
                fs3.WriteByte((byte)str[str.Length-i-1]);
            }*/
            fs1.Close();
            fs3.Close();
            MessageBox.Show("Successfully Reversing File.");
        }
    }
}