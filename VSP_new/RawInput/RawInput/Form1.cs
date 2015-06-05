using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RawInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                //case 0x00ff: MessageBox.Show("sads"); break;
                default: listBox1.Items.Add(m.Msg.ToString()); label1.Text = m.Msg.ToString(); break;
            }
            base.WndProc(ref m);
        }
    }
}