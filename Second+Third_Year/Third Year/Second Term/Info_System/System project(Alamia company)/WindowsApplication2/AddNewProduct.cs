using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data .OleDb ;

namespace WindowsApplication1
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x = Int32.Parse(t2.Text);
            if (listBox1.Items.Count < x)
            {

                if (t4.Text == "")
                {
                    // button2.Enabled = false;
                    return;
                }
                else
                {

                    listBox1.Items.Add(t4.Text);
                    t4.Text = "";
                    
                }
            }
            else
            {
                MessageBox.Show("you must Enter serial the same amount of product");
                t4.Text = "";

            }

            

        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        string asd = "";

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
               asd += listBox1.Items[i]+"\n";
            }


            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=O:\\Alamia.mdb");
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "INSERT INTO  ÇáãäÊÌ(ÇÓã_ãäÊÌ,ÇáßãíÉ,SN,ßæÏ_ãäÊÌ,ÇÓã_ãæÑÏ)    VALUES('"+t1 .Text + "','" +t2 .Text +"','" + t4 .Text +"','"+t5.Text +"','"+t3.Text +"')";
            con.Open();
            command.ExecuteNonQuery();
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";

        }
    }
}