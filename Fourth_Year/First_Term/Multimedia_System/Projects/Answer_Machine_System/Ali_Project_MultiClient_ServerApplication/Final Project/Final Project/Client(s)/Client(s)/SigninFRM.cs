using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client_s_
{
    public partial class SigninFRM : Form
    {
        public string nickName = "";
        public string ipAddr = "";
        public string eMail = "";
        public int portNum = 0;

        public SigninFRM()
        {
            InitializeComponent();
         
        }

        private void WorkBTN_Click(object sender, EventArgs e)
        {
            //System.Text.RegularExpressions.Regex.IsMatch();
            try
            {
                nickName = NickTXT.Text;
                ipAddr = ParseIP(IpTXT.Text);
                eMail = mailTXT.Text;
                portNum = int.Parse(PortTXT.Text);
            }
            catch(Exception exp)
            { MessageBox.Show(this, "You must enter numeric value in port number feild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Close();
        }
        private string ParseIP(string retIP)
        {
            for (int i = 0; i < retIP.Length; i++)
                if ((retIP.ToCharArray())[i] == ' ')
                {
                    retIP = retIP.Remove(i, 1);
                }
            return retIP;
        }

        private void SigninFRM_Load(object sender, EventArgs e)
        {
            CloseButtonRemove.Disable(this);
        }
    }
}