using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Serial_control_Module
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p1_TextChanged(object sender, EventArgs e)
        {
            if(p1.Text.Length==1)
            p2.Focus();

        }

        private void p7_TextChanged(object sender, EventArgs e)
        {

            if (p7.Text.Length == 1)
                p8.Focus();
            else if (p7.Text.Length == 0)
                p6.Focus();

        }

        private void p6_TextChanged(object sender, EventArgs e)
        {

            if (p6.Text.Length == 1)
                p7.Focus();
            else if (p6.Text.Length == 0)
                p5.Focus();
        }

        private void p5_TextChanged(object sender, EventArgs e)
        {

            if (p5.Text.Length == 1)
                p6.Focus();
            else if (p5.Text.Length == 0)
                p4.Focus();
        }

        private void p4_TextChanged(object sender, EventArgs e)
        {

            if (p4.Text.Length == 1)
                p5.Focus();
            else if (p4.Text.Length == 0)
                p3.Focus();
        }

        private void p3_TextChanged(object sender, EventArgs e)
        {
             if(p3.Text.Length==1)
            p4.Focus();
        else if (p3.Text.Length == 0)
            p2.Focus();
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
             if(p2.Text.Length==1)
            p3.Focus();
        else if (p2.Text.Length == 0)
            p1.Focus();
        }

        private void p8_TextChanged(object sender, EventArgs e)
        {

            if (p8.Text.Length == 1)
            {
                applayToallBtn.Focus();
                this.AcceptButton = applayToallBtn;
            }

            else if (p7.Text.Length == 0)
                p7.Focus();
        }

        private void p8_Leave(object sender, EventArgs e)
        {
             if (((TextBox)sender).Text == "0")return;
           else if (((TextBox)sender).Text != "0" || ((TextBox)sender).Text != "1")
                ((TextBox)sender).Text = "1";
        }
    }
}