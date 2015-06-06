using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Database_Adminstration
{
    public partial class Students : Form
    {
        public SqlConnection connection;
        private DBUtility StudentsUtility;        
        FileStream ImageStream;
        public Students()
        {
            InitializeComponent();
            StudentsUtility = new DBUtility();
        }

        private void BTNBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                ImageStream = new FileStream( openFileDialog.FileName, FileMode.Open);
                image.Image = System.Drawing.Image.FromStream(ImageStream);              
            }
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            if (All_Data_Is_Vaild())
            {
                Insert_Data();
            }                
        }

        private void Insert_Data()
        {
            string vaild;
            if (vaildCHK.Checked == true) vaild = "1"; else vaild = "0";

            string data = "exec add_new_student '" + userIdtxt.Text + "'" +
                ",'" + userfnametxt.Text + "'" +
                ",'" + userlnametxt.Text + "',"
                     + vaild +
                ",'" + useremailtxt.Text + "'" +
                ",'" + userphonetxt.Text + "'" +
                ",'" + userdescriptiontxt.Text + "'" +
                ",'" + userstagecbo.Text + "'";

            //
            //inserting primitive data
            //
            if (StudentsUtility.ExcuteQuery(data, connection) == -1) return;

            //
            //storing the image 
            //       

            StudentsUtility.InsertImage(ImageStream, userIdtxt.Text, connection);

            //
            //MessageBox
            //
            StudentsUtility.Notify(this, "Record added successfully to database");
        }

        private bool All_Data_Is_Vaild()
        {
            //
            //i'll implement it later
            //
            return true;
        }

        private void vaildCHK_CheckedChanged(object sender, EventArgs e)
        {
            if (vaildCHK.Checked == true)
            {
                label9.Text = "Valid";
                label9.ForeColor = Color.Black;
            }
            else
            {
                label9.Text = "Invalid";
                label9.ForeColor = Color.Red;
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}