using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Setup;

namespace setup
{
    public partial class Form2 : Form
    {
        Form1 asd;
        //--------------------------------------------------------------
        public Form2(Form1 eagle)
        {

            InitializeComponent();
            asd = eagle;
            asd.form2 = this;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }   
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }
        public Form3 form3 = null;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (form3 == null)
                new Form3(this).Show();
            else
                form3.Visible = !false;
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            this.Visible = false;
            asd.Visible = !false;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
    }
}