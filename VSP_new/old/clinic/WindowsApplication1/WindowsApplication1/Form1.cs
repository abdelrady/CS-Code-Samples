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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n1,n2,n3,n4,n5,n6;
        string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=asd.mdb";
        OleDbConnection c;
        public void asd ()
    {
       this.Enabled=true;
    }
        private void Form1_Load(object sender, EventArgs e)
        {
           // Regesitry.LocalMachine.createSubkey(DateTime.Now.Date, true);
            Form4 f = new Form4();
            f.ShowDialog(this);
            c = new OleDbConnection(constr);
            c.Open();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (name.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·«”„");
                return;
            }
            if (add.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·⁄‰Ê«‰");
                return;
            }
            if (tele.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· —ﬁ„ «· Ì·Ì›Ê‰");
                return;
            }
            if (age.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·”‰");
                return;
            }
            if (allacount.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «Ã„«·Ï «·Õ”«»");
                return;
            }
            if (foor.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·„ﬁ«»·");
                return;
            }
            if (cases.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «· ‘ŒÌ’");
                return;
            }
       
            if (datofvisit.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«·  «—ÌŒ «·“Ì«—…");
                return;
            }
            if (visitfor.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·Œœ„… «·„ƒœ«…");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·„œ›Ê⁄");
                return;
            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· «·„ »ﬁÏ");
                return;
            }
             try
            {
                n6 = Int32.Parse(tele.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("·« »œ „‰ «œŒ«· —ﬁ„ ›Ï «· Ì·Ì›Ê‰", "Œÿ√ ›Ï «œŒ«· «· Ì·Ì›Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            try
            {
                n1 = Int32.Parse(allacount.Text);
                n2 = Int32.Parse(textBox9.Text);
                n3 = Int32.Parse(textBox10.Text);
                n4 = Int32.Parse(age.Text);
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
                  DialogResult result = MessageBox.Show("Â· √‰  „ √ﬂœ „‰ «÷«›… " + name.Text, " √ﬂÌœ «· ”ÃÌ· ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  if (result == DialogResult.Yes)
                  {
                      OleDbCommand command1 = new OleDbCommand("INSERT INTO pationt VALUES ('" + name.Text + "','" + age.Text + "','" + add.Text + "','" + number.Text + "','" + tele.Text + "','" + n1 + "','" + cases.Text + "','" + foor.Text + "','" + label14.Text + "')", c);
                      command1.ExecuteNonQuery();
                      OleDbCommand command2 = new OleDbCommand("INSERT INTO visitation VALUES ('" + label14.Text + "','" + datofvisit.Text + "','" + visitfor.Text + "','" + n2 + "','" + n3 + "','" + name.Text + "','" + n1 + "')", c);
                      command2.ExecuteNonQuery();
                  }
                  if (result == DialogResult.No)
                      return;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }
    }
}