using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    struct student
    {
        public string name;
        public string class1;
        public int id;

        public void add(student a)
        {
            name = a.name;
            class1 = a.class1;
            id = a.id;
        }
    }
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        static student[] s;
        static int i;
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            student s2;
            s2.class1=textBox2.Text;
            s2.name=textBox1.Text;
            s2.id=Int32.Parse( textBox3.Text);
            
            s[i++].add(s2);
            count = i;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count < i-1)
            {
                count++;
                textBox1.Text = s[count].name;
                textBox2.Text = s[count].class1;
                textBox3.Text = s[count].id.ToString();
        
                //   show2(count);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count--;
                textBox1.Text = s[count-1].name;
                textBox2.Text = s[count-1].class1;
                textBox3.Text = s[count-1].id.ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox1.Text = s[0].name;
            textBox2.Text = s[0].class1;
            textBox3.Text = s[0].id.ToString();
        
            //    show2(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = i;
            textBox1.Text = s[i-1].name;
            textBox2.Text = s[i - 1].class1;
            textBox3.Text = s[i - 1].id.ToString();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
            count = 0;
            s = new student[100];
        }
    }
}