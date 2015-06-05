using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace read_webpage_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Library.SDS.Web.Http.HttpReader red = new Library.SDS.Web.Http.HttpReader();
            textBox1.Text = red.readWebPageSource(textBox2.Text);
        }
    }
}