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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string s = "";
        DataTable DT = new DataTable();
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;
   

        private void Form2_Load(object sender, EventArgs e)
        {
            
            c = new OleDbConnection(constr);
            c.Open();
            string ss = "SELECT * FROM pationt";  
            OleDbCommand com = new OleDbCommand(ss, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            adapt.Fill(DT);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                comboBox2.Items.Clear();
                return;
            }
            if (radioButton1.Checked == true)
            {
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«·«”„"];
                    comboBox2.Items.Add(s);
                    s = "";
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == false)
            {
                comboBox3.Items.Clear();
                return;
            }
            if (radioButton6.Checked == true)
            {
               // string ss = "";
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«·⁄‰Ê«‰"];
                    if(comboBox3.Items.Contains(s)==false)
                    comboBox3.Items.Add(s);
                    s = "";
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == false)
            {
                comboBox4.Items.Clear();
                return;
            }
            if (radioButton5.Checked == true)
            {
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«·—ﬁ„"];
                    if (comboBox4.Items.Contains(s) == false)
                    comboBox4.Items.Add(s);
                    s = "";
                }
            }
            c.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == false)
            {
                comboBox5.Items.Clear();
                return;
            }
            if (radioButton4.Checked == true)
            {
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«· Ì·Ì›Ê‰"];
                    if (comboBox5.Items.Contains(s) == false)
                    comboBox5.Items.Add(s);
                    s = "";
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == false)
            {
                comboBox6.Items.Clear();
                return;
            }
            if (radioButton3.Checked == true)
            {
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«· ‘ŒÌ’"];
                    if (comboBox6.Items.Contains(s) == false)
                    comboBox6.Items.Add(s);
                    s = "";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
            {
                comboBox7.Items.Clear();
                return;
            }
            if (radioButton2.Checked == true)
            {
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«Ã„«·Ï"];
                    if (comboBox7.Items.Contains(s) == false)
                    comboBox7.Items.Add(s);
                    s = "";
                }
            }
        }

   

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s1 = "SELECT * FROM pationt WHERE «·«”„ = '" + comboBox2.Text+"'";
            string s2 = "SELECT * FROM visitation WHERE «·«”„ = '" + comboBox2.Text + "'";
            OleDbCommand com1 = new OleDbCommand(s1, c);
            OleDbCommand com2 = new OleDbCommand(s2, c);
            
            OleDbDataAdapter adapt1 = new OleDbDataAdapter(com1);
            DataTable DT1 = new DataTable();
            adapt1.Fill(DT1);
            dataGridView1.DataSource = DT1;

            OleDbDataAdapter adapt2 = new OleDbDataAdapter(com2);
            DataTable DT2 = new DataTable();
            adapt2.Fill(DT2);
            dataGridView2.DataSource = DT2;
            //dataGridView2.DataBindings();
            //DataGrid1.DataSource = ds;
            //DataGrid1.DataBind();

        }
    

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s1 = "SELECT * FROM pationt WHERE «· Ì·Ì›Ê‰ = '" + comboBox5.Text + "'";
           OleDbCommand com1 = new OleDbCommand(s1, c);
           OleDbDataAdapter adapt1 = new OleDbDataAdapter(com1);
            DataTable DT1 = new DataTable();
            adapt1.Fill(DT1);
            dataGridView1.DataSource = DT1;

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = "SELECT * FROM pationt WHERE «Ã„«·Ï = " + comboBox7.Text ;
            OleDbCommand com = new OleDbCommand(s, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            DataTable DT = new DataTable();
            adapt.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "SELECT * FROM pationt WHERE «·⁄‰Ê«‰ = '" + comboBox3.Text + "'";
            OleDbCommand com = new OleDbCommand(s, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            DataTable DT = new DataTable();
            adapt.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "SELECT * FROM pationt WHERE «· ‘ŒÌ’ = '" + comboBox6.Text + "'";
            OleDbCommand com = new OleDbCommand(s, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            DataTable DT = new DataTable();
            adapt.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "SELECT * FROM pationt WHERE «·—ﬁ„ =" + comboBox4.Text ;
            OleDbCommand com = new OleDbCommand(s, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            DataTable DT = new DataTable();
            adapt.Fill(DT);
            dataGridView1.DataSource = DT;
        }

  

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            if (comboBox2.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «Œ Ì«— «·«”„");
                return;
            }
            string s = "SELECT —ﬁ„_«·“Ì«—… FROM visitation WHERE «·«”„= '" + comboBox2.Text + "'";
            OleDbCommand com = new OleDbCommand(s, c);
            OleDbDataAdapter adapt = new OleDbDataAdapter(com);
            DataTable DT = new DataTable();
            adapt.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                x++;
            }

            Form3 f = new Form3();
            f.asd(comboBox2.Text, x + 1);
            f.Show();
        }

    
    }
}