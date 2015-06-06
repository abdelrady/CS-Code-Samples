using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using setup;
/////////////////////////////////////////////////////////////////////////
namespace Setup
{
    public partial class Form1 : Form
    {
        //--------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
           // TBAgree.Enabled = false;
        //    TBAgree.BackColor = Color.White;
        }
        //--------------------------------------------------------------


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
        //--------------------------------------------------------------
        public Form2 form2 = null;
        private void PBNext_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (form2 == null)
                new Form2(this).ShowDialog();
            else
                form2.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }

        //--------------------------------------------------------------
    }
    //------------------------------------------------------------------
}
/////////////////////////////////////////////////////////////////////////