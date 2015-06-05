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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbCommand command, command1, command2, command3;
        string s = "";
        DataTable DT = new DataTable();
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;

        private void Form5_Load(object sender, EventArgs e)
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

 

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «Œ Ì«— «·«”„ Ê —ﬁ„ «·“Ì«—… „⁄«");
                return;
            }

            if (add.Text == "" && number.Text == "" && textBox1.Text == "" && tele.Text == "" && age.Text == "" && foor.Text == "" && cases.Text == "" && textBox10.Text == "" && textBox9.Text == "" && datofvisit.Text == "" && visitfor.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«·  €ÌÌ— Ê«Õœ ⁄·Ï «·«ﬁ·");
                return;
            }
            int n1, n2, n3, n4,n5,n6;
            n1 = Int32.Parse(comboBox1.Text);

            if (add.Text != "")
            {
                command = new OleDbCommand("UPDATE pationt SET" + " «·⁄‰Ê«‰ ='" + add.Text + "' WHERE «·«”„ = '" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }
            if (number.Text != "")
            {
                command = new OleDbCommand("UPDATE pationt SET" + " «·—ﬁ„ ='" + number.Text + "' WHERE «·«”„ = '" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }
            if (textBox1.Text != "")
            {
                command = new OleDbCommand("UPDATE pationt SET" + " «·«”„ ='" + textBox1.Text + "' WHERE «·«”„ = '" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }

            if (tele.Text != "")
            {
                try
                {
                    n6 = Int32.Parse(tele.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("·« »œ „‰ «œŒ«· —ﬁ„ ›Ï «· Ì·Ì›Ê‰", "Œÿ√ ›Ï «œŒ«· «· Ì·Ì›Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                command = new OleDbCommand("UPDATE pationt SET" + " «· Ì·Ì›Ê‰ ='" + tele.Text + "' WHERE  «·«”„ = '" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }
            if (age.Text != "")
            {
                try
                {
                    n5 = Int32.Parse(age.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("·« »œ „‰ «œŒ«· —ﬁ„ ›Ï «·”‰", "Œÿ√ ›Ï «œŒ«· «·”‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (n5 < 0)
                {
                    MessageBox.Show("·« »œ „‰ «œŒ«· —ﬁ„ «·”‰ „ÊÃ»", "Œÿ√ ›Ï «œŒ«· «·”‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                command = new OleDbCommand("UPDATE pationt SET" + " «·”‰ ='" + age.Text + "' WHERE  «·«”„ = '" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }

            if (foor.Text != "")
            {
                command = new OleDbCommand("UPDATE pationt SET" + " «·„ﬁ«»· ='" + foor.Text + "' WHERE «·«”„ ='" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }
            if (cases.Text != "")
            {

                command = new OleDbCommand("UPDATE pationt SET" + " «· ‘ŒÌ’ ='" + cases.Text + "' WHERE «·«”„ ='" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }
            if (datofvisit.Text != "")
            {
                command = new OleDbCommand("UPDATE visitation SET" + "  «—ÌŒ_«·“Ì«—… ='" + datofvisit.Text + "' WHERE —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();

            }
            if (visitfor.Text != "")
            {
                command = new OleDbCommand("UPDATE visitation SET" + " «·Œœ„…_«·„ƒœ«… ='" + visitfor.Text + "' WHERE —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                command.ExecuteNonQuery();
            }
            if (textBox9.Text != "" || allacount.Text!= "" || textBox10.Text != "")
            {
                if(textBox9.Text == "" || allacount.Text== "" || textBox10.Text == "")
                {
                    MessageBox.Show("·«»œ „‰ «œŒ«· «Ã„«·Ï «·Õ”«» Ê «·„œ›Ê⁄ Ê «·„ »ﬁÏ „⁄« ");
                    return;
                }
                try
                {
                    n2 = Int32.Parse(allacount.Text);
                    n3 = Int32.Parse(textBox10.Text);
                    n4 = Int32.Parse(textBox9.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("·« »œ „‰ «œŒ«· «—ﬁ«„ ›Ï «·«Ã„«·Ï Ê «·„œ›Ê⁄ Ê «·„ »ﬁÏ ", "«œŒ«· Õ—Ê› „ﬂ«‰ «—ﬁ«„", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (n2 != (n3 + n4))
                {
                    MessageBox.Show(" √ﬂœ „‰ «·⁄„·Ì… «·Õ”«»Ì… ");
                    return;
                }
                if (n1 == 1)
                {
                    command1 = new OleDbCommand("UPDATE pationt SET" + " «Ã„«·Ï ='" + n2 + "' WHERE  «·«”„ = '" + comboBox2.Text + "'", c);
                    command1.ExecuteNonQuery();
                    command2 = new OleDbCommand("UPDATE visitation SET" + " «Ã„«·Ï_«·Õ”«» ='" + n2 + "' WHERE  —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                    command2.ExecuteNonQuery();
                    command3 = new OleDbCommand("UPDATE visitation SET" + " «·„œ›Ê⁄ ='" + n4 + "' WHERE  —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                    command3.ExecuteNonQuery();
                    command3 = new OleDbCommand("UPDATE visitation SET" + " «·„ »ﬁÏ ='" + n3 + "' WHERE  —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                    command3.ExecuteNonQuery();
                }
                if (n1 > 1)
                {
                    command2 = new OleDbCommand("UPDATE visitation SET" + " «Ã„«·Ï_«·Õ”«» ='" + n2 + "' WHERE  —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                    command2.ExecuteNonQuery();
                    command3 = new OleDbCommand("UPDATE visitation SET" + " «·„œ›Ê⁄ ='" + n4 + "' WHERE  —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                    command3.ExecuteNonQuery();
                    command3 = new OleDbCommand("UPDATE visitation SET" + " «·„ »ﬁÏ ='" + n3 + "' WHERE  —ﬁ„_«·“Ì«—…='" + comboBox1.Text + "'" + "AND «·«”„ ='" + comboBox2.Text + "'", c);
                    command3.ExecuteNonQuery();
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string ss1 = "SELECT * FROM visitation WHERE «·«”„ ='" + comboBox2.Text + "'";
            OleDbCommand com1 = new OleDbCommand(ss1, c);
            OleDbDataAdapter adapt1 = new OleDbDataAdapter(com1);
            adapt1.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                s = s + dr["—ﬁ„_«·“Ì«—…"];
                comboBox1.Items.Add(s);
                s = "";
            }

        }
    }
}