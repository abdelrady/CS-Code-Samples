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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;
        string sname,eq=""; int z;
      public  void asd(string s,int x)
        {
            sname = s;
          z=x;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            c = new OleDbConnection(constr);
            c.Open();
            label3.Text = z.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Visible = true;
                allacount.Visible = true;
                label6.Visible = true;
                foor.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                textBox10.Visible = true;
                textBox9.Visible = true;
            }
            if (radioButton2.Checked == false)
            {
                label2.Visible = false;
                allacount.Visible = false;
                label6.Visible = false;
                foor.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBox10.Visible = false;
                textBox9.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label9.Visible = true;
                textBox9.Visible = true;
            }
            if (radioButton1.Checked == false)
            {
                label9.Visible = false;
                textBox9.Visible = false;
            }
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("·« »œ „‰ «Œ Ì«— ‰Ê⁄ «·“Ì«—…");
                return;
            }
            if (visitfor.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·Œœ„… «·„ƒœ«… ");
                return;
            }
            int n1,n2,n33=0,n3,n4=0;string s="",ss;
            int n;
            ss = z.ToString();
            if (textBox9.Text != "")
                try
                {
                    n33 = Int32.Parse(textBox9.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("·« »œ „‰ «œŒ«· «—ﬁ«„ ›Ï  «·„œ›Ê⁄", "«œŒ«· Õ—Ê› „ﬂ«‰ «—ﬁ«„", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            n1 = z - 1;
            s = n1.ToString();
            if (radioButton1.Checked == true)
            {
                //string s = "SELECT * FROM pationt WHERE «·⁄‰Ê«‰ = '" + comboBox3.Text + "'";

                string s1 = "SELECT * FROM visitation WHERE —ﬁ„_«·“Ì«—…='" + n1 + "'"+ "AND «·«”„ ='" + sname+"'";
                OleDbCommand com = new OleDbCommand(s1, c);
                OleDbDataAdapter adapt = new OleDbDataAdapter(com);
                DataTable DT = new DataTable();
                adapt.Fill(DT);
                s = "";
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«·„ »ﬁÏ"];
                    eq = eq + dr[" «—ÌŒ_«·“Ì«—…"];
                    if (datofvisit.Text == eq)
                    {
                        MessageBox.Show(" √ﬂœ „‰ «· «—ÌŒ");
                        return;
                    }
                }
                try
                {
                    n2 = Int32.Parse(textBox9.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("·« »œ „‰ «œŒ«· «—ﬁ«„ ›Ï  «·„œ›Ê⁄", "«œŒ«· Õ—Ê› „ﬂ«‰ «—ﬁ«„", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                n1 = Int32.Parse(s);//«·„ »ﬁÏ
                if (n2 > n1)
                {
                    MessageBox.Show("«·„œ›Ê⁄ √ﬂÀ— „‰ «·„ »ﬁÏ");
                    return;
                }
                n4 = n1 - n2;

                OleDbCommand command2 = new OleDbCommand("INSERT INTO visitation VALUES ('" + ss + "','" + datofvisit.Text + "','" + visitfor.Text + "','" + n33 + "','" + n4 + "','" + sname + "','" +0+ "')", c);
                command2.ExecuteNonQuery();
                 
            }
            if (radioButton2.Checked == true)
            {
                n1 = z - 1;
                string s1 = "SELECT * FROM visitation WHERE —ﬁ„_«·“Ì«—…='" + n1 + "'" + "AND «·«”„ ='" + sname + "'";
                OleDbCommand com = new OleDbCommand(s1, c);
                OleDbDataAdapter adapt = new OleDbDataAdapter(com);
                DataTable DT = new DataTable();
                adapt.Fill(DT);
                try
                {
                    n1 = Int32.Parse(allacount.Text);//«·„ »ﬁÏ
                    n2 = Int32.Parse(textBox10.Text);
                    n3 = Int32.Parse(textBox9.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("·« »œ „‰ «œŒ«· «—ﬁ«„ ›Ï «·«Ã„«·Ï Ê «·„œ›Ê⁄ Ê «·„ »ﬁÏ ", "«œŒ«· Õ—Ê› „ﬂ«‰ «—ﬁ«„", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (n1 != (n2 + n3))
                {
                    MessageBox.Show(" √ﬂœ „‰ «·⁄„·Ì… «·Õ”«»Ì… ");
                    return;
                }
                s = "";
                foreach (DataRow dr in DT.Rows)
                {
                    s = s + dr["«·„ »ﬁÏ"];
                }
                n1 = Int32.Parse(s);//«·„ »ﬁÏ
                n2 = Int32.Parse(textBox10.Text);
                n2 = n2 + n1;
                n = Int32.Parse(allacount.Text);
                OleDbCommand command2 = new OleDbCommand("INSERT INTO visitation VALUES ('" + ss + "','" + datofvisit.Text + "','" + visitfor.Text + "','" + n33 + "','" + n2 + "','" + sname + "','" + n + "')", c);
                command2.ExecuteNonQuery();
              
            }
            if (radioButton3.Checked == true)
            {
                n = n2 = n33 = 0;
                OleDbCommand command2 = new OleDbCommand("INSERT INTO visitation VALUES ('" + ss + "','" + datofvisit.Text + "','" + visitfor.Text + "','" + n33 + "','" + n2 + "','" + sname + "','" + n + "')", c);
                command2.ExecuteNonQuery();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false || radioButton2.Checked == true)
            {
                label2.Visible = false;
                allacount.Visible = false;
                label6.Visible = false;
                foor.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                textBox10.Visible = false;
                textBox9.Visible = false;
            }
        }
    }
}