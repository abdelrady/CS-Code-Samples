#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
#endregion

namespace RDB_test.myControls {
    public partial class DBAdminSetting : UserControl
    {
        MainForm Parent;
        //
        //  Constructor
        //
        public DBAdminSetting(MainForm Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }
     
        private void BtnReload_Click(object sender, EventArgs e)
        {
            Configuration.Valid();
            this.richTextBox1.Text = Configuration.connectionString;
            this.txtUsrName.Text=Configuration.userName;
            this.txtUsrPassword.Text=Configuration.userPassword;
            this.txtServerName.Text=Configuration.ServerName;
            this.txtDBName.Text=Configuration.DBName;
            this.cnnTimeout.Value=int.Parse(Configuration.ConnectionTimeout);
            this.chkAllowUserInstance.Checked = (Configuration.UserInstance=="True")?true:false;
            this.chkIntegSec.Checked = (Configuration.IntegratedSecurity == "True") ? true : false;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Configuration.Write_Config(this.txtUsrName.Text,this.txtUsrPassword.Text,
                this.txtServerName.Text,this.txtDBName.Text,this.chkIntegSec.Checked.ToString(),this.cnnTimeout.Value.ToString(),this.chkAllowUserInstance.Checked.ToString());
            Parent.setToolTip("Loading Successfully.");
        }
    }
    }
