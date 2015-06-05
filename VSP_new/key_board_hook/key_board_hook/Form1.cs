using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace key_board_hook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            KeyboardHook khk = new KeyboardHook();
           // khk.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(khk_KeyIntercepted);
        }

        void khk_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            MessageBox.Show(e.PassThrough.ToString());
            throw new Exception("The method or operation is not implemented.");
        }
    }
}