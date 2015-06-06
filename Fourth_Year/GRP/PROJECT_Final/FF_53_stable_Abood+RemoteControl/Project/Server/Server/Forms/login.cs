using System;

using System.ComponentModel;
using System.Windows.Forms;
using SQLDMO;
using System.IO;


namespace SmartDoor
{
    public partial class login : Form
    {
        public bool mico = false;
        public string userName = "";       
        public string dblocationMain = ""; 
        SQLDMO.SQLServer2Class _SQLSVR;

        public login()
        {
            if (Configuration.Not_Valid())
            {
                MessageBox.Show(
                        this,
                        "Configuration file [Config.int] Not Exists,Or Unvalid configuration\nDefault Configuration had been written.",
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
                try { _CBO_Servers.SelectedIndex = 1; _CBO_DataBases.SelectedIndex = 0; }
                catch { }                
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        { System.Environment.Exit(System.Environment.ExitCode);}

        private void login_Load(object sender, EventArgs e)
        {            
        }
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}