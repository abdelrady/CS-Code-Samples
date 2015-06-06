using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "t";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "u";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "v";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "w";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "x";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "s";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "y";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "z";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "a";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "b";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "c";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "d";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "e";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "f";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "g";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "h";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "i";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "j";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "k";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "l";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "n";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "m";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "o";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "p";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "q";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "r";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\t";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dial = new FontDialog();
            DialogResult res;
            res = dial.ShowDialog();
            textBox1.Font = dial.Font;
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            DialogResult dres;
            dres = col.ShowDialog();

            textBox1.BackColor = col.Color;

        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            DialogResult dres;
            dres = col.ShowDialog();

            textBox1.ForeColor  = col.Color;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\n";
        }

    }
}