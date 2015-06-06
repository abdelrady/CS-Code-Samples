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
            this.chkIntegSec.Checked = (Configuration.IntegratedSecurity == "True") ? true : false;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Configuration.Write_Config(this.txtUsrName.Text,this.txtUsrPassword.Text,
            //    this.txtServerName.Text,this.txtDBName.Text,this.chkIntegSec.Checked.ToString(),this.cnnTimeout.Value.ToString(),this.chkAllowUserInstance.Checked.ToString());
            Configuration.Write_Config(this.richTextBox1.Text);
            Parent.setToolTip("Loading Successfully.");
        }

        private void txtUsrName_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";" + "Persist Security Info=" + chkIntegSec.Checked.ToString() + ";User ID=" + txtUsrName.Text + ";password=" + txtUsrPassword.Text;
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";" + "Persist Security Info=" + chkIntegSec.Checked.ToString() + ";User ID=" + txtUsrName.Text + ";password=" + txtUsrPassword.Text;
    
        }

        private void txtUsrPassword_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";" + "Persist Security Info=" + chkIntegSec.Checked.ToString() + ";User ID=" + txtUsrName.Text + ";password=" + txtUsrPassword.Text;
    
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";" + "Persist Security Info=" + chkIntegSec.Checked.ToString() + ";User ID=" + txtUsrName.Text + ";password=" + txtUsrPassword.Text;
    
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Configuration.Parse_Values(richTextBox1.Text);
        }

        private void chkIntegSec_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";" + "Persist Security Info=" + chkIntegSec.Checked.ToString() + ";User ID=" + txtUsrName.Text + ";password=" + txtUsrPassword.Text;
    
        }

        private void DBAdminSetting_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Tag == (object)"special")
                {
                    c.BackColor = this.BackColor;
                }
            }
        }

       
    }
    }
