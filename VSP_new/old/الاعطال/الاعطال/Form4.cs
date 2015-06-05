using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace الاعطال
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int n;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if (textBox1.Text == "")
            {
                MessageBox.Show("أدخل الرقم السرى ");
                return;
            }
            n = Int32.Parse(textBox1.Text);
            if (n != 246)
            {
                MessageBox.Show("الرقم خطأ");
                f.Enabled = false;
                return;
            }
            if (n == 246)
            {
                this.Close();
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text == "" || n != 246)
                Application.Exit();
        }
    }
}