using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb ;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class AddNewSupp : Form
    {
        public AddNewSupp()
        {
            InitializeComponent();
        }

        private void AddNewSupp_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=O:\\Alamia.mdb");
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "INSERT INTO «·„Ê—œ(«”„_„Ê—œ,«·⁄‰Ê«‰,ﬂÊœ_„Ê—œ,«Ì„Ì·,«· ·›Ê‰)VALUES ('" + t1.Text + "' , '" +t2.Text + "','" + t3.Text + "','"+t4.Text +"','" + t5.Text + "')";
            con.Open();
            command.ExecuteNonQuery();
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
           

        



        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}