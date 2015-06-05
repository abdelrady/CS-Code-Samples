using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RemoteSQLServer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char x = (char)57;
            MessageBox.Show((x).ToString());
           /* SqlConnection mySqlConnection =
  			new SqlConnection(
    		"server="+this.textBox1.Text+";database=c:\\db\\sdasdb;uid=sa;pwd=sa;");// +
    		//"max pool size=10;min pool size=5"  );*/
            //SqlConnection cnn = new SqlConnection(/*@"Data Source=172.31.8.79;initial catalog=master;Integrated Security=true;Persist Security Info=False;User ID=sa;Password=asd;Connect Timeout=120;Encrypt=False");*/"server=lab3d-19\\SQLEXPRESS;initial catalog=SDASDB;uid=asd;pwd=asd1;Integrated Security=SSPI;user Instance=false");
            //SqlConnection cnn = new SqlConnection(@"Password=asd;Persist Security Info=false;User ID=sa;Initial Catalog=smartdoor_db;Data Source="+textBox1.Text+"\\SQLEXPRESS");
            SqlConnection cnn = new SqlConnection(@"Data Source=172.31.8.95;Initial Catalog=SMARTDOOR_DB;Persist Security Info=True;User ID=sa;password=asd");
            SqlDataAdapter dbadapter = new SqlDataAdapter("Select * from users", /*mySqlConnection*/cnn);
            DataTable dt = new DataTable("users");
            dbadapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
    }
}