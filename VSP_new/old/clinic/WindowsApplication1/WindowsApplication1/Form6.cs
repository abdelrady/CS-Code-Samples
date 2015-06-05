using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string s = "";
        DataTable DT = new DataTable();
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;

        private void Form6_Load(object sender, EventArgs e)
        {
            c = new OleDbConnection(constr);
            c.Open();
            string ss = "SELECT * FROM pationt";
            OleDbCommand com = new OleDbCommand(ss, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            adapt.Fill(DT);


            foreach (DataRow dr in DT.Rows)
            {
                s = s + dr["«·«”„"];
                comboBox2.Items.Add(s);
                s = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex < 0 )
            {
                MessageBox.Show("·« ÌÊÃœ „—÷Ï", "ﬁ«⁄œ… «·»Ì«‰«  ›«—€…", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «Œ Ì«— «·«”„");
                return;
            }
            DialogResult result = MessageBox.Show("Â· √‰  „ √ﬂœ „‰ Õ–› " + comboBox2.Text, " √ﬂÌœ «·Õ–› ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OleDbCommand com = new OleDbCommand("DELETE FROM pationt WHERE «·«”„= '" + comboBox2.Text+"'", c);
                com.ExecuteNonQuery();
                OleDbCommand com1 = new OleDbCommand("DELETE FROM visitation WHERE «·«”„= '" + comboBox2.Text + "'", c);
                com1.ExecuteNonQuery();
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
            }
            if (result == DialogResult.No)
                return;
        }
    }
}