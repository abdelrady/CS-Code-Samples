using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb ;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class AddMantainCustomer : Form
    {
        public AddMantainCustomer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                t4.Enabled = true;
                t5.Enabled = true;
                t6.Enabled = true;
                t7.Enabled = true;
                t8.Enabled = true;
                t9.Enabled = true;
                t10.Enabled = true;
                t11.Enabled = true;
                t12.Enabled = true;
                l1.Enabled = true;
                l2.Enabled = true;
                l3.Enabled = true;
                l4.Enabled = true;
                l5.Enabled = true;
                l6.Enabled = true;
                l7.Enabled = true;
                l8.Enabled = true;
                l9.Enabled = true;
            }
            else
            {
                t4.Enabled = false;
                t5.Enabled = false;
                t6.Enabled = false;
                t7.Enabled = false;
                t8.Enabled = false;
                t9.Enabled = false;
                t10.Enabled = false;
                t11.Enabled = false;
                t12.Enabled = false;
                l1.Enabled = false;
                l2.Enabled = false;
                l3.Enabled = false;
                l4.Enabled = false;
                l5.Enabled = false;
                l6.Enabled = false;
                l7.Enabled = false;
                l8.Enabled = false;
                l9.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=O:\\Alamia.mdb");
            OleDbCommand comand = new OleDbCommand();
            comand.CommandText = "INSERT INTO «·÷„«‰(«”„_⁄„Ì·,«·„‰ Ã,«· «—ÌŒ,«”„_„Ê—œ,«·⁄ÿ·,SN) VALUES('" + t1.Text + "','" + t2.Text + "','" + t11.Text + "','" + t7.Text + "','" + t3.Text + "','" + t5.Text + "')";
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
            t9.Text = "";
            t11.Text = "";
            t12.Text = "";
            

        }
    }
}