using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Class_Average
{
    public partial class Form1 : Form
    {
        int cout = 0;
        int total = 0;
        double averge = 0;
        public Form1()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 0 || int.Parse(textBox1.Text) > 100 || (textBox1.Text == ""))
                {
                    MessageBox.Show("Invalid number ", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Clear();
                }
                else
                {
                    cout++;
                   
                    if (cout < 10)
                    {
                        button1.Enabled = true;
                       
                    }
                    else
                    {
                        button1.Enabled = false ;
                        button2.Enabled =true ;
                    }

                    listBox1.Items.Add(int.Parse(textBox1.Text));
                    textBox1.Clear();
                    textBox1.Focus();
                }
                
            }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < 10; x++)
            {
                int y= (int)listBox1.Items[x];
                total += y;
            }
            averge = total / 10;
            label4.Text = averge.ToString();
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}