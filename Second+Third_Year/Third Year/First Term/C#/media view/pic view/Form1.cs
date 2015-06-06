using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           dirListBox1.Path =driveListBox1.Drive;
           
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path=dirListBox1.Path;
            fileListBox1.Refresh();
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL =fileListBox1.Path +"\\" + fileListBox1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}