using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        double  count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 4; i <= 1000; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double number = double.Parse(textBox1.Text);
                double fibonaci = checked(fib(number));
                label1.Text = fibonaci.ToString() + "  E  " + count;
                count = 0;
            
        }
        public double fib(double x)
        {
            double  first=1;
            double  last=0;
            double  next=0;
            if ( x <= 0) return 0;
            else if (x == 1) return 1;
            else
            {
                for (int i = 2; i <= x; i++)
                {
                    last = first + next;
                    next = first;
                    first = last;
                }
              if (last > 10000)
                {
                    while (last > 10000)
                    {
                        last /= 10000;
                        count += 4;
                    }
                }
                //in way if no last if statment way give the same value
            }
            return last;
           
        }
    }
}