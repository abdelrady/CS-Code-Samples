using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bindingSource2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dt= this.myReportDataSet1.Users.FindByID(1);
            dt.BeginEdit();
            dt[1] = "a";
            dt[2] = "a";
            dt.EndEdit();
            //myReportDataSet1.e
            MessageBox.Show(this.usersTableAdapter1.Update(myReportDataSet1.Users).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder();

            //SqlDataAdapter sqlda = new SqlDataAdapter(this.usersTableAdapter1.Connection);
            //scb.GetUpdateCommand(sqlda);
            //this.usersTableAdapter1.Fill(myReportDataSet1.Users);
            this.usersTableAdapter1.Fill(this.myReportDataSet1.Users);
        }
    }
}