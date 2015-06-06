using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interest_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "Year \t AmountIn Deposit \n"; ;
            double p,r,a,n;
           p = double.Parse(textBox1.Text);
            r = double.Parse(textBox2.Text);
           n = (double )numericUpDown1.Value;
            for(int i=1 ;i<=n ;i++)
            {
                a= p *Math.Pow((1+r ),i  );
                output +="\n"+i+"\t"+a + " \r\n" ;
            }
            textBox3.Text = output;
        }
    }
}