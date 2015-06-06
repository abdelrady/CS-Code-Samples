using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class login : Form  
    {
        master msa = new master();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;
            if (x.CompareTo("msa") == 0 && y.CompareTo("asd") == 0)
            {
                button1.Enabled = false;
                Close();
                msa.Enabled = true;
              
               
              
            }
            else
            {


                if (textBox1.Text != "msa" & textBox2.Text != "asd")
                    MessageBox.Show("‰«”› »—Ã«¡ «œŒ«· »Ì«‰«  ’ÕÌÕ…", "Œÿ«¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    if (textBox1.Text != "msa")
                        MessageBox.Show("‰«”› »—Ã«¡ «œŒ«· »Ì«‰«  „” Œœ„ ’ÕÌÕ…", "Œÿ«¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("‰«”› »—Ã«¡ «œŒ«· ﬂ·„… „—Ê— ’ÕÌÕ…", "Œÿ«¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}