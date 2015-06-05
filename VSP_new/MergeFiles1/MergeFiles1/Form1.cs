using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MergeFiles1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox1.Text.Substring(0, textBox1.Text.LastIndexOf('.')), FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            byte[] data1=File.ReadAllBytes(textBox1.Text);
            byte[] data2=File.ReadAllBytes(textBox2.Text);
            fs.Write(data1, 0, data1.Length);
            fs.Write(data2, 0, data2.Length);
            fs.Close();
            MessageBox.Show("Successful Merge ");
        }
    }
}