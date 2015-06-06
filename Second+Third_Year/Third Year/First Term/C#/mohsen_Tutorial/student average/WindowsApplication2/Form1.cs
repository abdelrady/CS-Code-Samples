using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        string str= "";
        float grade = 0, x, y, z;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text ==""  || textBox4.Text=="" ||  textBox3.Text == "")
            {
                MessageBox.Show("You must enter three grade and name", "asd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                x = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);
                z = float.Parse(textBox3.Text);
                grade = x + y + z;
                grade /= 3;
                listBox1.Items.Add(grade);
                label2.Text =textBox4.Text+ "  Grade is " +  grade.ToString();
                button1.Enabled = false;
            }
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton2.Checked == true)
            {
                if (grade >= 90 && grade <= 100)
                    str = "A";
                else
                if (grade >=80 && grade <= 89)
                    str = "B";
                else
                if (grade >= 70 && grade <= 79)
                    str = "C";
                else
                if (grade >= 60 && grade <= 69)
                    str = "D";
                else
                    str = "F";
    label2.Text = textBox4.Text + "  Grade is " + str;
                listBox1.Items.Add(str );

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = textBox4.Text + "  Grade is " + grade.ToString();
            listBox1.Items.Add(grade);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button1.Enabled = true;
            listBox1.Items.Clear();
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button1.Enabled = true;
            listBox1.Items.Clear();
            label2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button1.Enabled = true;
            listBox1.Items.Clear();
            label2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            button1.Enabled = true;
            listBox1.Items.Clear();
            label2.Text = "";
        }
        }
    }
