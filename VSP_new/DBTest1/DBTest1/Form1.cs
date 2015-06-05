using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace DBTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            SqlCommand cmd = new SqlCommand("Select * from Groups", sqlConnection1);
            sqlConnection1.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.treeView1.Nodes[0].Nodes.Add(dr[0] + " " + dr[1],dr[0] + " " + dr[1]);
            }
            sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("E:\\DBAdapter.txt", true, Encoding.Default);
            sw.WriteLine("sqlConnectionString= "+this.sqlConnection1.ConnectionString.ToString());
            sw.WriteLine("SelectCommand= "+this.sqlSelectCommand1.CommandText.ToString());
            //sw.WriteLine("InsertCommand= "+this.sqlInsertCommand1.CommandText.ToString());
            //sw.WriteLine("updateCommand= "+this.sqlUpdateCommand1.CommandText.ToString());
            //sw.WriteLine("DeleteCommand= "+this.sqlDeleteCommand1.CommandText.ToString());
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sqlDataAdapter1.Fill(this.dataSet11.Groups);
            foreach (DataRow dr in this.dataSet11.Groups.Rows)
            {
                this.treeView1.Nodes[0].Nodes[dr[0] + " " + dr[1]].Nodes.Add(dr[2] + " " + dr[3]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.treeView1.Hide();
            this.dataGridView1.Show();
            SqlDataAdapter dba1 = new SqlDataAdapter("SELECT userID, userfName, userlName, userValid, userEmail, userPhone, userDescription, userStage,userImage FROM Users", @"Data Source=fcis\SQLEXPRESS;Initial Catalog=C:\db\SDASDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            DataSet ds = new DataSet();
            DataTable dtusers=new DataTable("Usr");
            dba1.FillSchema(dtusers, SchemaType.Source);
            ds.Tables.Add(dtusers);

            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "Usr";

            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "Usr.userID", true));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "Usr.userfName", true));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "Usr.userlName", true));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "Usr.userValid", true));
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "Usr.userEmail", true));
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "Usr.userStage", true));
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "Usr.userDescription", true));
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", ds, "Usr.userImage", true));

            dba1.Fill(ds, "Usr");
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
                this.pictureBox1.Image =new Bitmap(new MemoryStream(Encoding.Unicode.GetBytes(this.dataSet11.Tables["Usr"].Rows[this.dataGridView1.CurrentRow.Index][8].ToString())));
            }
            catch (Exception)
            { }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn =new SqlConnection( @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\db\SDASDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT userID, userfName, userlName, userValid, userEmail, userPhone, userDescription, userStage,userImage FROM Users";
            cnn.Open();
            SqlDataReader rd= cmd.ExecuteReader();
            rd.Read();
            rd.Read();
            textBox1.Text = rd[0].ToString();
            textBox2.Text = rd[1].ToString();
            textBox3.Text = rd[2].ToString();
            textBox4.Text = rd[3].ToString();
            textBox5.Text = rd[4].ToString();
            textBox6.Text = rd[5].ToString();
            
            pictureBox1.Image =new Bitmap( new MemoryStream(Encoding.Unicode.GetBytes(rd[8].ToString())));
        }
    }
}