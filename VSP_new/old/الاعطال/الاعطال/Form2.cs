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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("لا بد من ادخال العطل");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("لا بد من ادخال طريقة الاصلاح");
                return;
            }
            DialogResult result = MessageBox.Show("هل أنت متأكد من اضافة " + textBox1.Text, "تأكيد التسجيل ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OleDbCommand command1 = new OleDbCommand("INSERT INTO Table1 VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')", c);
                command1.ExecuteNonQuery();
            }
            if (result == DialogResult.Yes)
                return;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            c = new OleDbConnection(constr);
            c.Open();
        }
    }
}