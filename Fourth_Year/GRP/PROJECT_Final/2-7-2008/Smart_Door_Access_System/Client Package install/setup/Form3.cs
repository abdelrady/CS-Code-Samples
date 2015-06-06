using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Data.SqlClient;
using setup;

/////////////////////////////////////////////////////////////////////////
namespace Setup
{
    public partial class Form3 : Form
    {

        public bool Is_Exist = false;
        Form2 asd;
        //--------------------------------------------------------------
        public Form3(Form2 eagle)
        {
          
            InitializeComponent();
            asd = eagle;
            asd.form3 = this;
           
        }
             //--------------------------------------------------------------
        private void Form3_Load(object sender, EventArgs e)
        {
            //CloseButtonRemove.Disable(this);
        }
       
        //--------------------------------------------------------------
        
        private void Attach_DB()
        {
            lbl_Status.Text = "Connecting to Server, Wait Please...";
            lbl_Status.ForeColor = Color.Blue;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SqlConnection con;
                string comstr = "Integrated Security=SSPI;"+
                                "Persist Security Info=False;"+
                                "Initial Catalog=master;"+
                                "Data Source="+textBox3.Text+"\\SQLEXPRESS;timeout=10000;";
                con = new SqlConnection(comstr);
                con.Open();
                string command = "select count(*) from" +
                    " sysdatabases where name='" + textBox2.Text+ "'";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[0].ToString() == "1")
                    {
                        try
                        {
                            reader.Close();
                        }
                        catch { }
                        command = "select filename from" +
                                  "sysdatabases where name='" + textBox2.Text + "'";
                        com = new SqlCommand(command, con);
                        reader = com.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string DBDir = reader[0].ToString();
                            DBDir = DBDir.Substring(0, DBDir.LastIndexOf('\\'));
                            MessageBox.Show(this, " There an Existing Database with the same name Attached to Server." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          //  if (DBDir != TBNameLocation.Text)
                            {
                                try
                                {
                                  //  System.IO.File.Delete(textBox1.Text);
                                 //   System.IO.File.Delete(Path.GetFileNameWithoutExtension( textBox1.Text)+".LDF");
                                }
                                catch { }
                            }
                            try
                            {
                                reader.Close();
                            }
                            catch { }
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            reader.Close();
                        }
                        catch { }
                    }
                }
                else
                {
                    lbl_Status.Text="Unspecified Error Occured While Attaching Database.";

                }
                try
                {
                    reader.Close();
                }
                catch { }
               
                command = "declare @ret int " +
                "EXEC @ret=sp_attach_db @dbname = N'" + textBox2.Text + "'," +
                    "@filename1 = N'"+ textBox1.Text + "'," +
                    "@filename2 = N'" + Path.GetDirectoryName(textBox1.Text) + "\\" + Path.GetFileNameWithoutExtension(textBox1.Text) + "_log.LDF';" +
                    " select @ret";
                com = new SqlCommand(command, con);
                reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[0].ToString() == "0")
                    {
                        button6.Enabled = true;
                        lbl_Status.Text = "Database Attached Successfully.";
                        lbl_Status.ForeColor = Color.Green;
                        this.Cursor = Cursors.Arrow;
                    }
                    else
                    {

                        lbl_Status.Text = "Unspecified Error Occured While Attaching Database.";
                        lbl_Status.ForeColor = Color.Red;
                        this.Cursor = Cursors.Arrow;//  Environment.Exit(Environment.ExitCode);
                    }
                    reader.Close();
                }
                else
                {
                    lbl_Status.Text = "Unspecified Error Occured While Attaching Database.";
                    lbl_Status.ForeColor = Color.Red;
                    this.Cursor = Cursors.Arrow;// Environment.Exit(Environment.ExitCode);
                }
            }
            catch (Exception ex)
            {

                lbl_Status.Text = "There are already an existing Database with the same name, you have to detach it or proceed.";
                button6.Enabled = true;
                lbl_Status.ForeColor = Color.Red;
                this.Cursor = Cursors.Arrow;// Environment.Exit(Environment.ExitCode);
            }
        }
        //--------------------------------------------------------------
        public void Try_to_Connect_To_Server()
        {
            try
            {
                SqlConnection con;
                string comstr = "Integrated Security=SSPI;" +
                               "Persist Security Info=False;" +
                               "Initial Catalog=master;" +
                               "Data Source=" + textBox3.Text + "\\SQLEXPRESS;timeout=10000;";
                con = new SqlConnection(comstr);
                con.Open();

                con.Close();
                button3.Enabled = true;

                lbl_Status.Text = "Success.";
                lbl_Status.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error Connecting To Server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             //   Environment.Exit(Environment.ExitCode);
            }
        }
        //--------------------------------------------------------------
        private void PBFinish_Click(object sender, EventArgs e)
        {
            //check database location path
         
         //   Setup();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Attach_DB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Try_to_Connect_To_Server();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                button5.Enabled = true;
            }
        }       

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            asd.Visible = !false;
        }

        //--------------------------------------------------------------

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
        public Form4 form4 = null;
        private void button3_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            if (form4 == null)
                new Form4(this).ShowDialog();
            else
                form4.Visible = true;
        }

        
       
    }
}
/////////////////////////////////////////////////////////////////////////