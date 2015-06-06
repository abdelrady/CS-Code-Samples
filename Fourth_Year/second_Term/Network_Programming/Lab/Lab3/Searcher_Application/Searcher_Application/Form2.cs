using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Searcher_Application
{
    public partial class Form2 : Form
    {
        string filePath;
        public Form2(string path)
        {
            InitializeComponent();
            filePath = path;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
            this.richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}