using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace SmartDoor
{
    public partial class ConfigurationLogin : Form
    {
        public string PWD;
        public ConfigurationLogin()
        {
            InitializeComponent();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void writeUsernameAndPw(string username, string password)
        {

            RijndaelManaged ri = new RijndaelManaged();
            Rfc2898DeriveBytes rf = new Rfc2898DeriveBytes("cms.com", Encoding.ASCII.GetBytes("smartsoor by ali and abdelrady"));


            ri.Key = rf.GetBytes(ri.KeySize / 8);

            ri.IV = rf.GetBytes(ri.BlockSize / 8);


            CryptoStream cs = new CryptoStream(File.Create("KEYConfig.cfg"), ri.CreateEncryptor(), CryptoStreamMode.Write);

            StreamWriter sr = new StreamWriter(cs);

            sr.WriteLine(username);

            sr.Close();
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            //writeUsernameAndPw("asd");
            RijndaelManaged ri = new RijndaelManaged();
            Rfc2898DeriveBytes rf = new Rfc2898DeriveBytes("cms.com", Encoding.ASCII.GetBytes("smartsoor by ali and abdelrady"));

            ri.Key = rf.GetBytes(ri.KeySize / 8);

            ri.IV = rf.GetBytes(ri.BlockSize / 8);

            FileStream fs = new FileStream("KEYConfig.cfg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            CryptoStream cs = new CryptoStream(fs, ri.CreateDecryptor(), CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(cs);

            string password = sr.ReadLine();

            // MessageBox.Show(username + " " + password);

            if (password == txtpassword.Text)
            {

                this.DialogResult = DialogResult.OK;
                PWD = password;

            }
            else
            {
                MessageBox.Show(this, "Invalid password or username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtpassword.Clear();
                txtpassword.Focus();
                this.DialogResult = DialogResult.Cancel;

            }
            fs.Close();
            sr.Close();
        }


    }
    class LoginToConfiguration
    {
        public string Password;
        internal bool ShowDialogModel()
        {
            ConfigurationLogin cl = new ConfigurationLogin();
            cl.ShowDialog();
            if (cl.DialogResult == DialogResult.OK)
            {
                Password = cl.PWD;
                return true;
            }
            else return false;
        }
    }
}