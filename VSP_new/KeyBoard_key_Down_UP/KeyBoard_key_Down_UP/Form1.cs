using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyBoard_key_Down_UP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            richTextBox1.Text += "KeyUp: " + e.KeyCode.ToString()+Environment.NewLine;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            richTextBox1.Text += "KeyDown: " + e.KeyCode.ToString() + Environment.NewLine;
        }
    }
}