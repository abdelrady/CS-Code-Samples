using System;

using System.ComponentModel;



using System.Windows.Forms;

namespace Client_s_
{
    public partial class SignIn : Form
    {
        public string nickName = "";
        public string ipAddr = "";
        public string eMail = "";
        public int portNum = 0;

        public SignIn()
        {
            InitializeComponent();
         
        }

        private void WorkBTN_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(mailTXT.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*") == false)
            {
                MessageBox.Show(this,"Email is invalid.         ","Sign in",MessageBoxButtons.OK,MessageBoxIcon.None);
                mailTXT.Focus();
                return;
            }
            try
            {
                nickName = NickTXT.Text;
                ipAddr = ParseIP(IpTXT.Text);
                eMail = mailTXT.Text;
                portNum = int.Parse(PortTXT.Text);
            }
            catch
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

        private void SigninFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}