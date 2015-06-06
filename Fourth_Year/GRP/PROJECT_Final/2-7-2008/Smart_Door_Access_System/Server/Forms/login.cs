using System;
using System.ComponentModel;
using System.Windows.Forms;
using SQLDMO;
using System.IO;
using System.Data.SqlClient;


namespace SmartDoor
{
    public partial class login : Form
    {
        private bool mico = false;
        private bool Ulogi = false;
        public string username;
        private static SqlConnection sqlLocal;
        SQLDMO.SQLServer2Class _SQLSVR;

        public login()
        {
            if (Configuration.Not_Valid())
            {
                MessageBox.Show(
                        this,
                        "Configuration file [Config.ini] Not Exists,Or Unvalid configuration\nDefault Configuration had been written.",
                        "Fetal Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            
            }          
                InitializeComponent();
                Ali_API.CloseButtonRemove.Disable(this);
                _SQLSVR = new SQLServer2Class();
                _SQLSVR.LoginSecure = true;
                _SQLSVR.LoginTimeout = 10;
                _CBO_Servers.Items.Add(Environment.MachineName);
                for (int i = 2; i <= _SQLSVR.ListInstalledInstances(null).Count; i++)
                    _CBO_Servers.Items.Add(_SQLSVR.ListInstalledInstances(null).Item(i));
                try { _CBO_Servers.SelectedIndex = 0; _CBO_DataBases.SelectedIndex = 0; }
                catch { }          
      
            
        }
        public static void ShowThis( ref string Uname,ref SqlConnection sql)
        {
            login Log = new login();
            Log.ShowDialog();
            Uname = Log.UserCombo.Text;
            sql = sqlLocal;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        { System.Environment.Exit(System.Environment.ExitCode);}
        DBUtility loginUtil;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            username = UserCombo.Text;
            string password = PassWordTXT.Text;
            loginUtil = new DBUtility(this);
            sqlLocal=loginUtil.ConnectToSQL();

            string passwordFromDb = (string)loginUtil.Get_Single_Value("SELECT Password FROM AdminUsers WHERE Name = '" + username.Trim() + "'");

            if (passwordFromDb == null)
            {
                MessageBox.Show(this, "Invalid password or username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                PassWordTXT.Clear();
                PassWordTXT.Focus();
            }
            else
            {
                if (passwordFromDb.Trim() == password)
                {
                    Ulogi = true;
                    Close();
                }
                else
                {
                    MessageBox.Show(this, "Invalid password or username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PassWordTXT.Clear();
                    PassWordTXT.Focus();
                }
            }
        }
       private void _BTN_Connect_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            _BTN_Connect.Enabled = false;
            try{_SQLSVR.Start(true, _CBO_Servers.SelectedItem.ToString(), null, null);}
            catch{
                /*(Exception ee){
                MessageBox.Show(this, ee.Message, "Smart Door", MessageBoxButtons.OK, MessageBoxIcon.Information);*/            
            }            
           try
            {
                foreach (SQLDMO.Database db in _SQLSVR.Databases)
                {
                    _CBO_DataBases.Items.Add(db.Name);
                }
                if (_CBO_DataBases.Items.Count != 0)
                    _CBO_DataBases.SelectedIndex = 0;
            }
            catch { }
            this.Cursor = Cursors.Default;
           
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginUtil.ConnectToSQL();
            if(!Ulogi)
            System.Environment.Exit(System.Environment.ExitCode);
        }

      
      
    }
}