using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieShow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AddFile.Items.Add(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PlayList.Items.Add(AddFile.SelectedItem.ToString());
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                PlayList.Items.RemoveAt(PlayList.SelectedIndex);
            }
            catch
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = PlayList.Items.Count;
            string s = Directory.GetCurrentDirectory();
            FileStream f = new FileStream(s+"\\test.ms", FileMode.Create, FileAccess.Write);
            int j;
            for (j = 0; j < i; j++)
            {
                PlayList.SelectedIndex = j;
                f.Write(System.Text.Encoding.ASCII.GetBytes(PlayList.SelectedItem.ToString()), 0, System.Text.Encoding.ASCII.GetBytes(PlayList.SelectedItem.ToString()).Length);
                f.Write(System.Text.Encoding.ASCII.GetBytes("@"), 0, 1);
            }
            f.Close();
            this.Close();
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}