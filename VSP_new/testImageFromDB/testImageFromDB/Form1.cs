using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace testImageFromDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MemoryStream GetImageData()
        {
            //Create the return memorystream object that will hold the buffered data.
            MemoryStream ReturnStream;// = new MemoryStream();
            //Put together the connection string
            string cn = @"Persist Security Info=False;Integrated Security=false;User ID=sa;Pwd=sa;database=c:\db\sdasdb.mdf;server=.\sqlexpress;Connect Timeout=30";
            try
            {
                //Get the sql string
                string SqlString = "select * from dbo.users";
                //Create a new command object
                SqlCommand sc = new SqlCommand();
                //Set the connection
                sc.Connection = new SqlConnection(cn);
                //sc.Connection.EnlistDistributedTransaction()
                //Open the connection
                sc.Connection.Open();
                //Set the command type
                sc.CommandType = CommandType.Text;
                //Set the SQL String
                sc.CommandText = SqlString;
                //Execute the SQL Statement/Procedure
                SqlDataReader RS = sc.ExecuteReader();
                //Create a streamwriter to write to the memory stream 
                //BinaryWriter br = new BinaryWriter(ReturnStream);
                if (RS.HasRows)
                {
                    RS.Read(); RS.Read();
                    //Create a header for the file from the names of the columns that we are retrieving
                    ReturnStream = new MemoryStream(Encoding.Unicode.GetBytes(RS["userImage"].ToString()));
                    //Loop through the data row and write the contents to the memory stream.
                    do
                    {
                    }
                    while (RS.Read());
                    return ReturnStream;
                }
                //br.Flush();
                //br.Close();
                //Clean up the data reader
                RS.Close();
                //Clean up the command object
                sc.Connection.Close();
                sc.Dispose();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            //Return the memory Stream
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(GetImageData());
        }
    }
}