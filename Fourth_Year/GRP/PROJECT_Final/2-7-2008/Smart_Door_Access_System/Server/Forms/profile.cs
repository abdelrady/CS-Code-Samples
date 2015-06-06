using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartDoor.Forms
{
    public partial class profile : Form
    {
        DBUtility dbUtil;
        ServerFRM ServerForm;
        public profile(SqlConnection connection,string UserName,ServerFRM sf)
        {
            InitializeComponent();          
            dbUtil = new DBUtility(this);
            dbUtil.m_DbConnection = connection;
            ServerForm = sf;
            txtoldUserName.Text = UserName;
            txtOldPassword.Text = ((string)dbUtil.Get_Single_Value("SELECT Password FROM AdminUsers WHERE Name = '" + UserName + "'")).Trim();

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtNewPassword2.Text)
            {
                MessageBox.Show(this, "Passwords Does not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Text = "";
                txtNewPassword2.Text = "";
            }
            else 
            {
                dbUtil.ExcuteQuery("UPDATE AdminUsers SET Password='" + txtNewPassword.Text + "',Name='" + txtnewUsername.Text + "' WHERE Name = '" + txtoldUserName.Text + "'");
            MessageBox.Show(this, "Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnApply.Enabled = false;
            ServerForm.UserName = txtnewUsername.Text;


            }

        }

        private void txtnewUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtnewUsername.Text.Length + txtNewPassword2.Text.Length + txtNewPassword.Text.Length == 0||
                txtnewUsername.Text.Length==0||
                txtNewPassword2.Text.Length==0||
                txtNewPassword.Text.Length == 0)
                btnApply.Enabled = false;
            else
                btnApply.Enabled = !false;
        }

        private void txtNewPassword2_TextChanged(object sender, EventArgs e)
        {

            if (txtnewUsername.Text.Length + txtNewPassword2.Text.Length + txtNewPassword.Text.Length == 0 ||
                txtnewUsername.Text.Length == 0 ||
                txtNewPassword2.Text.Length == 0 ||
                txtNewPassword.Text.Length == 0)
                btnApply.Enabled = false;
            else
                btnApply.Enabled = !false;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtnewUsername.Text.Length + txtNewPassword2.Text.Length + txtNewPassword.Text.Length == 0 ||
                 txtnewUsername.Text.Length == 0 ||
                 txtNewPassword2.Text.Length == 0 ||
                 txtNewPassword.Text.Length == 0)
                btnApply.Enabled = false;
            else
                btnApply.Enabled = !false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(btnApply.Enabled==true)
                btnApply.PerformClick();
            Close();

        }
    }
}