using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Searcher_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You Must Type File Name & Folder Whre You Want To Search In.!!!!", "Missing Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Search();
        }

        private void Search()
        {

            DirectoryInfo dir1 = new DirectoryInfo(this.textBox2.Text);
            
            try
            {
                FileInfo[] filesList = dir1.GetFiles(this.textBox1.Text, SearchOption.AllDirectories);
                foreach (FileInfo file in filesList)
                {
                    this.listView1.Items.Add(file.FullName, file.Name, 0);
                }
            }
            catch { }

                /*
            foreach (DirectoryInfo dir in dir1.GetDirectories())
            {
                
                //    MessageBox.Show(dir.Name);
            }*/
        }

        private void readFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this.listView1.SelectedItems[0].Name);
            frm.Show();
        }

        private void compressFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog();
            if (svg.ShowDialog() == DialogResult.OK)
            {
                GZipStream gz = new GZipStream(new FileStream(svg.FileName, FileMode.Create), CompressionMode.Compress);
                StreamWriter sw = new StreamWriter(gz);
                sw.Write(File.ReadAllText(this.listView1.SelectedItems[0].Name));
                sw.Close();
                MessageBox.Show("File Compressed Successfuly");
            }
        }
    }
}