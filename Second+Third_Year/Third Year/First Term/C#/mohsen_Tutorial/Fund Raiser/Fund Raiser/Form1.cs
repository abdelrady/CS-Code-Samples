using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fund_Raiser
{
    public partial class Form1 : Form
    {
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("PLZ Enter NUmber to your program: ", "ASd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Class1 asd = new Class1();
                decimal d;
                d = asd.asd(decimal.Parse(textBox1.Text));
                total += d;
                label4.Text = d.ToString();
                label5.Text = total.ToString();
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("PLZ Enter NUmber to your program: ", "ASd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Class1 asd = new Class1();
                decimal d;
                d = asd.asd(decimal.Parse(textBox1.Text));
                total += d;
                label4.Text = d.ToString();
                label5.Text = total.ToString();
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
    }
}