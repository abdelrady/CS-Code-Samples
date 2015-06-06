using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using SmartDoor.Properties;

namespace SmartDoor.Classes
{
    public partial class UserDetail : Form
    {       
        public UserDetail(string Barcode, SqlConnection Con)
        {
            InitializeComponent();

            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Users WHERE userID='" + Barcode+"'", Con);
            DataTable Dtable = new DataTable();
            Adapter.Fill(Dtable);
            DataRow dr = Dtable.Rows[0];

            userfnametxt.Text = dr["userfName"].ToString();
            userlnametxt.Text = dr["userlName"].ToString();
            userphonetxt.Text = dr["userPhone"].ToString();
            userstagecbo.Text = dr["userStage"].ToString();
            useremailtxt.Text = dr["userEmail"].ToString();
            userdescriptiontxt.Text = dr["userDescription"].ToString();

            if (dr.IsNull(8) == false)
            {
               image.Image =Image.FromStream(new MemoryStream((byte[])dr["UserImage"]));
            }
            else { image.Image = Resources.UnknownCharacter; }



        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}