using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace create_table1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\vs.net_projects\create_table1\create_table1\bin\Debug\db.mdb;Persist Security Info=False");
            OleDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = //"if exist persons Drop table persons"+
                "CREATE TABLE Persons ( PersonID int constraint asd PRIMARY KEY,FirstName nvarchar(15),LastName nvarchar(15))";
            try
            {

                cnn.Open();
                this.Text = cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}