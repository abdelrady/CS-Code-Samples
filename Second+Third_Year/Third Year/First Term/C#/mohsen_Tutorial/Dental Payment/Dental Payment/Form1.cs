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
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("PLZ Enter Name And check atleast one item", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                total = 0;
            }
            else
            {
                total = 0;
                if (checkBox1.Checked == true)
                    total += 35;
                if (checkBox2.Checked == true)
                    total += 150;
                if (checkBox3.Checked == true)
                    total += 85;
                label7.Text = " Total of : " + textBox1.Text + " " + string.Format("{0:f}", total);
                textBox1.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                total = 0;
            }
        }
    }
}