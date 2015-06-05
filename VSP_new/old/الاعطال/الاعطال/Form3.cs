using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace الاعطال
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string s = "";
        DataTable DT = new DataTable();
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;
        private void Form3_Load(object sender, EventArgs e)
        {
            c = new OleDbConnection(constr);
            c.Open();
            string ss = "SELECT * FROM Table1";
            OleDbCommand com = new OleDbCommand(ss, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            adapt.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                s = s + dr["العطل"];
                if (comboBox1.Items.Contains(s) == false)
                    comboBox1.Items.Add(s);
                s = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s="";
            string s1 = "SELECT * FROM Table1 WHERE العطل = '" + comboBox1.Text + "'";
            OleDbCommand com1 = new OleDbCommand(s1, c);
            OleDbDataAdapter adapt1 = new OleDbDataAdapter(com1);
            DataTable DT1 = new DataTable();
            adapt1.Fill(DT1);
            foreach (DataRow dr in DT1.Rows)
            {
                s = s + dr["التصليح"];
            }
            textBox1.Text = s;
            s = "";
        }
    }
}