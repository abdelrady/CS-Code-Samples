using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Server : System.Windows.Forms.Form
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.TextBox MessageTXT;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox LogTXT;
        private TabPage tabPage2;
        private ListView listView1;
        private Button SendBTN;
        private MenuStrip MainMenu;
        private ToolStripMenuItem serverToolStripMenuItem;
        private ToolStripMenuItem ConnectBTN;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ExitMBTN;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpTopicsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem aboutSmartDoorProjectToolStripMenuItem;
        private ToolStripMenuItem adminstrationToolStripMenuItem;
        private ToolStripMenuItem createNewUserToolStripMenuItem;
        private ToolStripMenuItem viewProfileToolStripMenuItem;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageTXT = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LogTXT = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SendBTN = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToDB = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutSmartDoorProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerStatus = new System.Windows.Forms.StatusStrip();
            this.networkStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.ServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTXT
            // 
            this.MessageTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTXT.Location = new System.Drawing.Point(4, 327);
            this.MessageTXT.Multiline = true;
            this.MessageTXT.Name = "MessageTXT";
            this.MessageTXT.Size = new System.Drawing.Size(365, 44);
            this.MessageTXT.TabIndex = 0;
            this.MessageTXT.TextChanged += new System.EventHandler(this.MessageTXT_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogTXT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Event View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogTXT
            // 
            this.LogTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTXT.Location = new System.Drawing.Point(3, 3);
            this.LogTXT.Name = "LogTXT";
            this.LogTXT.Size = new System.Drawing.Size(460, 371);
            this.LogTXT.TabIndex = 2;
            this.LogTXT.Text = "";
            this.LogTXT.TextChanged += new System.EventHandler(this.LogTXT_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SendBTN);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.MessageTXT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SendBTN
            // 
            this.SendBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBTN.Enabled = false;
            this.SendBTN.Location = new System.Drawing.Point(372, 329);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(90, 41);
            this.SendBTN.TabIndex = 2;
            this.SendBTN.Text = "&Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(457, 317);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.adminstrationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(499, 24);
            this.MainMenu.TabIndex = 6;
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectBTN,
            this.ConnectToDB,
            this.connectToBoth,
            this.toolStripSeparator1,
            this.ExitMBTN});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(178, 22);
            this.ConnectBTN.Text = "Connect";
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // ConnectToDB
            // 
            this.ConnectToDB.Name = "ConnectToDB";
            this.ConnectToDB.Size = new System.Drawing.Size(178, 22);
            this.ConnectToDB.Text = "Connect To Database";
            this.ConnectToDB.Click += new System.EventHandler(this.ConnectToDB_Click);
            // 
            // connectToBoth
            // 
            this.connectToBoth.Name = "connectToBoth";
            this.connectToBoth.Size = new System.Drawing.Size(178, 22);
            this.connectToBoth.Text = "Connect To Both";
            this.connectToBoth.Click += new System.EventHandler(this.connectToBoth_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // ExitMBTN
            // 
            this.ExitMBTN.Name = "ExitMBTN";
            this.ExitMBTN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMBTN.Size = new System.Drawing.Size(178, 22);
            this.ExitMBTN.Text = "Exit";
            this.ExitMBTN.Click += new System.EventHandler(this.ExitMBTN_Click);
            // 
            // adminstrationToolStripMenuItem
            // 
            this.adminstrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem,
            this.viewProfileToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.adminstrationToolStripMenuItem.Name = "adminstrationToolStripMenuItem";
            this.adminstrationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.adminstrationToolStripMenuItem.Text = "Adminstration";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutSmartDoorProjectToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpTopicsToolStripMenuItem
            // 
            this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.helpTopicsToolStripMenuItem.Text = "Help Topics";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // aboutSmartDoorProjectToolStripMenuItem
            // 
            this.aboutSmartDoorProjectToolStripMenuItem.Name = "aboutSmartDoorProjectToolStripMenuItem";
            this.aboutSmartDoorProjectToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aboutSmartDoorProjectToolStripMenuItem.Text = "About Smart Door Project";
            // 
            // ServerStatus
            // 
            this.ServerStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkStatus,
            this.dbStatus});
            this.ServerStatus.Location = new System.Drawing.Point(0, 446);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(499, 22);
            this.ServerStatus.TabIndex = 7;
            this.ServerStatus.Text = "statusStrip1";
            // 
            // networkStatus
            // 
            this.networkStatus.Name = "networkStatus";
            this.networkStatus.Size = new System.Drawing.Size(39, 17);
            this.networkStatus.Text = "Offline";
            // 
            // dbStatus
            // 
            this.dbStatus.Name = "dbStatus";
            this.dbStatus.Size = new System.Drawing.Size(141, 17);
            this.dbStatus.Text = "Not Connected to Database";
            // 
            // Server
            // 
            this.AcceptButton = this.SendBTN;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(499, 468);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(306, 363);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Door Access - Server ";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Server_Closing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ServerStatus.ResumeLayout(false);
            this.ServerStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private StatusStrip ServerStatus;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem ConnectToDB;
        private ToolStripStatusLabel networkStatus;
        private ToolStripStatusLabel dbStatus;
        private ToolStripMenuItem connectToBoth;
    }
}
