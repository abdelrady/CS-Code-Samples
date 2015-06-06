using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_2
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int x =( int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
           label4.Text = x.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "  ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "  ";
        }
    }
}