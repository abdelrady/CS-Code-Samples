using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Œ—ÊÃToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void «÷«›…’‰›ÃœÌœToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProduct asd = new AddNewProduct();
            asd.ShowDialog();
        }

        private void «÷«›…„Ê—œÃœÌœToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSupp asd = new AddNewSupp();
            asd.ShowDialog();
           
        }

        private void «÷«ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            master mas = new master();
            mas.ShowDialog();
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t6.Text = "";
            t7.Text = "";
            t8.Text = "";
            t9.Text = "";
            t10.Text = "";
            t11.Text = "";
            t12.Text = "";
            
        }

        private void t9_TextChanged(object sender, EventArgs e)
        {
                      

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                t9.Enabled = true;
                t10.Enabled = true;
                t11.Enabled = true;
                t12.Enabled = true;
                l1.Enabled = true;
                l2.Enabled = true;
                l3.Enabled = true;
                l4.Enabled = true;
            }
            else
            {
                t9.Enabled = false; ;
                t10.Enabled = false;
                t11.Enabled = false;
                t12.Enabled = false;
                l1.Enabled = false;
                l2.Enabled = false;
                l3.Enabled = false;
                l4.Enabled = false;
            }

           
          }

        private void «÷«›…⁄„Ì·’Ì«‰ÂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ‘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainBill asd = new maintainBill();
            asd.ShowDialog();
        }

        private void hDAKSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            master asd = new master();
            asd.ShowDialog();
        }

        private void t4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection conect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=O:\\Alamia.mdb");
            OleDbCommand comand = new OleDbCommand();
            comand.CommandText = "INSERT INTO „»Ì⁄« (ﬂÊœ_„‰ Ã,«·„‰ Ã,«· «—ÌŒ,«·ﬂ„Ì…,«·”⁄—,—ﬁ„_«·›« Ê—…,«·«Ã„«·,SN) VALUES('" + t2.Text + "','" + t1.Text + "','" + t7.Text + "','" + t4.Text + "','" + t5.Text + "','" + t8.Text + "','" + t6.Text + "','" + t3.Text + "')";
            comand.Connection = conect;
            conect.Open();
            comand.ExecuteNonQuery();
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t6.Text = "";
            t7.Text = "";
            t8.Text = "";
        }
       
         
        /*private void timer1_Tick(object sender, EventArgs e)
        {

            this.Opacity += 0.1;
            if (this.Opacity == 1.0)
            {
            timer1.Stop();
                Form1 asd =new Form1 ();
                asd.FormBorderStyle

        }*/

      
    }
}