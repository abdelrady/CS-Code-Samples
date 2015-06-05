using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wh = new WindowHooks();
            wh.InstallHook(this);
        }
        WindowHooks wh;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            wh.UnistallHook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "windowssss");
            Form ff = new Form();
            ff.Text = ";kcjva'djv";
            ff.Show();
        }

    }
}