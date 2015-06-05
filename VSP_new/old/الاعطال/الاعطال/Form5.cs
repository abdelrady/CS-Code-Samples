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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string s = "";
        DataTable DT = new DataTable();
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;

        private void Form5_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("لا بد من اختيار العطل");
                return;
            }
            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف " + comboBox1.Text, "تأكيد الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OleDbCommand com = new OleDbCommand("DELETE FROM Table1 WHERE العطل= '" + comboBox1.Text + "'", c);
                com.ExecuteNonQuery();
            }
            if (result == DialogResult.No)
                return;
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

    }
}