using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hook_messagebox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kh = new KeyboardHook();
            
        }
        KeyboardHook kh;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("welcome back", "welcome back");
            Form frm = new Form();
            frm.Text = "text";
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kh.Dispose();   
        }
    }
}