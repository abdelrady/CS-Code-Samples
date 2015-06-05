using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Storedprocedure_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE UserStatus @barcodeNumber, @DoorNum, @Status OUTPUT", new SqlConnection());
            
            cmd.Parameters.Add(new SqlParameter("@barcodeNumber", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@DoorNum", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int));
            
            cmd.Parameters[0].Value = "2etewt22";
            cmd.Parameters[1].Value = 1;
            cmd.Parameters[2].Direction = ParameterDirection.Output;

            cmd.Connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='c:\db\SDASDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True";
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            //MessageBox.Show(dr[1].ToString());
            dr.Close(); //You Must Close DataReader Before reading OutPut Value
            
            MessageBox.Show(cmd.Parameters[2].Value.ToString());
            cmd.Connection.Close();

        }
    }
}