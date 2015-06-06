using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SmartDoor
{
    public partial class ServerFRM : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox MessageTXT;
        private TabControl tabControl;
        private TabPage tabPage1;
        private RichTextBox LogTXT;
        private TabPage tabPage2;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerFRM));
            this.MessageTXT = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LogTXT = new System.Windows.Forms.RichTextBox();
            this.Action_menu_Log = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Save_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SendBTN = new System.Windows.Forms.Button();
            this.DoorsView = new System.Windows.Forms.ListView();
            this.Action_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMD_ViewConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_Monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Hibernate = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_DownloadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutSmartDoorProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.networkStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClientCountLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Action_menu_Log.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Action_Menu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.ServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTXT
            // 
            this.MessageTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTXT.Location = new System.Drawing.Point(4, 448);
            this.MessageTXT.Multiline = true;
            this.MessageTXT.Name = "MessageTXT";
            this.MessageTXT.Size = new System.Drawing.Size(582, 30);
            this.MessageTXT.TabIndex = 0;
            this.MessageTXT.TextChanged += new System.EventHandler(this.MessageTXT_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(4, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(714, 510);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogTXT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Event Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogTXT
            // 
            this.LogTXT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LogTXT.ContextMenuStrip = this.Action_menu_Log;
            this.LogTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTXT.Location = new System.Drawing.Point(3, 3);
            this.LogTXT.Name = "LogTXT";
            this.LogTXT.ReadOnly = true;
            this.LogTXT.Size = new System.Drawing.Size(700, 478);
            this.LogTXT.TabIndex = 2;
            this.LogTXT.Text = "";
            this.LogTXT.TextChanged += new System.EventHandler(this.LogTXT_TextChanged);
            // 
            // Action_menu_Log
            // 
            this.Action_menu_Log.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_Action,
            this.Clear_Action});
            this.Action_menu_Log.Name = "Action_Menu";
            this.Action_menu_Log.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Action_menu_Log.Size = new System.Drawing.Size(129, 48);
            this.Action_menu_Log.Opening += new System.ComponentModel.CancelEventHandler(this.Action_menu_Log_Opening);
            // 
            // Save_Action
            // 
            this.Save_Action.Image = ((System.Drawing.Image)(resources.GetObject("Save_Action.Image")));
            this.Save_Action.Name = "Save_Action";
            this.Save_Action.Size = new System.Drawing.Size(128, 22);
            this.Save_Action.Text = "Save To ...";
            this.Save_Action.Click += new System.EventHandler(this.Save_Action_Click);
            // 
            // Clear_Action
            // 
            this.Clear_Action.Image = ((System.Drawing.Image)(resources.GetObject("Clear_Action.Image")));
            this.Clear_Action.Name = "Clear_Action";
            this.Clear_Action.Size = new System.Drawing.Size(128, 22);
            this.Clear_Action.Text = "Clear Log";
            this.Clear_Action.Click += new System.EventHandler(this.Clear_Action_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SendBTN);
            this.tabPage2.Controls.Add(this.DoorsView);
            this.tabPage2.Controls.Add(this.MessageTXT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doors ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SendBTN
            // 
            this.SendBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBTN.Enabled = false;
            this.SendBTN.Location = new System.Drawing.Point(591, 450);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(111, 27);
            this.SendBTN.TabIndex = 2;
            this.SendBTN.Text = "&Send Message";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // DoorsView
            // 
            this.DoorsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DoorsView.ContextMenuStrip = this.Action_Menu;
            this.DoorsView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DoorsView.ForeColor = System.Drawing.Color.Blue;
            this.DoorsView.LargeImageList = this.imageList;
            this.DoorsView.Location = new System.Drawing.Point(4, 5);
            this.DoorsView.MultiSelect = false;
            this.DoorsView.Name = "DoorsView";
            this.DoorsView.Size = new System.Drawing.Size(697, 438);
            this.DoorsView.TabIndex = 1;
            this.DoorsView.UseCompatibleStateImageBehavior = false;
            this.DoorsView.DoubleClick += new System.EventHandler(this.DoorsView_DoubleClick);
            // 
            // Action_Menu
            // 
            this.Action_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMD_ViewConfig,
            this.toolStripSeparator3,
            this.CMD_Monitor,
            this.toolStripSeparator4,
            this.CMD_Disconnect,
            this.CMD_Hibernate,
            this.CMD_Shutdown,
            this.CMD_DownloadConfig,
            this.viewDetailsToolStripMenuItem});
            this.Action_Menu.Name = "Action_Menu";
            this.Action_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Action_Menu.Size = new System.Drawing.Size(205, 170);
            this.Action_Menu.Opening += new System.ComponentModel.CancelEventHandler(this.Action_Menu_Opening);
            // 
            // CMD_ViewConfig
            // 
            this.CMD_ViewConfig.Name = "CMD_ViewConfig";
            this.CMD_ViewConfig.Size = new System.Drawing.Size(204, 22);
            this.CMD_ViewConfig.Text = "View Configuration ...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // CMD_Monitor
            // 
            this.CMD_Monitor.Name = "CMD_Monitor";
            this.CMD_Monitor.Size = new System.Drawing.Size(204, 22);
            this.CMD_Monitor.Text = "Monitor Door ...";
            this.CMD_Monitor.Click += new System.EventHandler(this.CMD_Monitor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // CMD_Disconnect
            // 
            this.CMD_Disconnect.Name = "CMD_Disconnect";
            this.CMD_Disconnect.Size = new System.Drawing.Size(204, 22);
            this.CMD_Disconnect.Text = "Disconnect Door Socket";
            this.CMD_Disconnect.Click += new System.EventHandler(this.CMD_Disconnect_Click);
            // 
            // CMD_Hibernate
            // 
            this.CMD_Hibernate.Name = "CMD_Hibernate";
            this.CMD_Hibernate.Size = new System.Drawing.Size(204, 22);
            this.CMD_Hibernate.Text = "Hibernate Remote Machine";
            // 
            // CMD_Shutdown
            // 
            this.CMD_Shutdown.Name = "CMD_Shutdown";
            this.CMD_Shutdown.Size = new System.Drawing.Size(204, 22);
            this.CMD_Shutdown.Text = "Shutdown Remote Machine";
            // 
            // CMD_DownloadConfig
            // 
            this.CMD_DownloadConfig.Name = "CMD_DownloadConfig";
            this.CMD_DownloadConfig.Size = new System.Drawing.Size(204, 22);
            this.CMD_DownloadConfig.Text = "Download Configuration ...";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.viewDetailsToolStripMenuItem.Text = "Properties ...";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "DoorOnline");
            this.imageList.Images.SetKeyName(1, "DoorOffline");
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.adminstrationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(723, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectBTN,
            this.ConnectToDB,
            this.toolStripSeparator1,
            this.CMD_Restart,
            this.ExitMBTN});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Image = global::SmartDoor.Properties.Resources.play;
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(178, 22);
            this.ConnectBTN.Text = "Connect Server";
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // ConnectToDB
            // 
            this.ConnectToDB.Image = ((System.Drawing.Image)(resources.GetObject("ConnectToDB.Image")));
            this.ConnectToDB.Name = "ConnectToDB";
            this.ConnectToDB.Size = new System.Drawing.Size(178, 22);
            this.ConnectToDB.Text = "Connect To Database";
            this.ConnectToDB.Click += new System.EventHandler(this.ConnectToDB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // CMD_Restart
            // 
            this.CMD_Restart.Name = "CMD_Restart";
            this.CMD_Restart.Size = new System.Drawing.Size(178, 22);
            this.CMD_Restart.Text = "Restart Server";
            this.CMD_Restart.Click += new System.EventHandler(this.CMD_Restart_Click);
            // 
            // ExitMBTN
            // 
            this.ExitMBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExitMBTN.Image")));
            this.ExitMBTN.Name = "ExitMBTN";
            this.ExitMBTN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMBTN.Size = new System.Drawing.Size(178, 22);
            this.ExitMBTN.Text = "Exit";
            this.ExitMBTN.Click += new System.EventHandler(this.ExitMBTN_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMD_Setting});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // CMD_Setting
            // 
            this.CMD_Setting.Image = ((System.Drawing.Image)(resources.GetObject("CMD_Setting.Image")));
            this.CMD_Setting.Name = "CMD_Setting";
            this.CMD_Setting.Size = new System.Drawing.Size(158, 22);
            this.CMD_Setting.Text = "Server Setting ...";
            this.CMD_Setting.Click += new System.EventHandler(this.CMD_Setting_Click);
            // 
            // adminstrationToolStripMenuItem
            // 
            this.adminstrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem,
            this.viewProfileToolStripMenuItem});
            this.adminstrationToolStripMenuItem.Name = "adminstrationToolStripMenuItem";
            this.adminstrationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.adminstrationToolStripMenuItem.Text = "Adminstration";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewUserToolStripMenuItem.Image")));
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileToolStripMenuItem.Image")));
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewProfileToolStripMenuItem.Text = "View My Profile";
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
            this.helpTopicsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpTopicsToolStripMenuItem.Image")));
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
            this.aboutSmartDoorProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutSmartDoorProjectToolStripMenuItem.Image")));
            this.aboutSmartDoorProjectToolStripMenuItem.Name = "aboutSmartDoorProjectToolStripMenuItem";
            this.aboutSmartDoorProjectToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aboutSmartDoorProjectToolStripMenuItem.Text = "About Smart Door Project";
            // 
            // ServerStatus
            // 
            this.ServerStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.networkStatus,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel2,
            this.dbStatus,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel5,
            this.ClientCountLBL});
            this.ServerStatus.Location = new System.Drawing.Point(0, 545);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(723, 22);
            this.ServerStatus.TabIndex = 7;
            this.ServerStatus.Text = "statusStrip1";
            this.ServerStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.ServerStatus_Paint);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Sever Status:";
            // 
            // networkStatus
            // 
            this.networkStatus.BackColor = System.Drawing.Color.Transparent;
            this.networkStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkStatus.ForeColor = System.Drawing.Color.Red;
            this.networkStatus.Image = global::SmartDoor.Properties.Resources.smallfail;
            this.networkStatus.Name = "networkStatus";
            this.networkStatus.Size = new System.Drawing.Size(59, 17);
            this.networkStatus.Text = "Offline";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel6.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel2.Text = "Database Status:";
            // 
            // dbStatus
            // 
            this.dbStatus.BackColor = System.Drawing.Color.Transparent;
            this.dbStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbStatus.ForeColor = System.Drawing.Color.Red;
            this.dbStatus.Image = global::SmartDoor.Properties.Resources.smallfail;
            this.dbStatus.Name = "dbStatus";
            this.dbStatus.Size = new System.Drawing.Size(177, 17);
            this.dbStatus.Text = "Not Connected to Database";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel7.Text = " ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel5.Text = "Doors Online :";
            // 
            // ClientCountLBL
            // 
            this.ClientCountLBL.BackColor = System.Drawing.Color.Transparent;
            this.ClientCountLBL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ClientCountLBL.ForeColor = System.Drawing.Color.Blue;
            this.ClientCountLBL.Name = "ClientCountLBL";
            this.ClientCountLBL.Size = new System.Drawing.Size(14, 17);
            this.ClientCountLBL.Text = "0";
            // 
            // ServerFRM
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(723, 567);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(565, 363);
            this.Name = "ServerFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Door Access - Server ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerFRM_FormClosing);
            this.Load += new System.EventHandler(this.ServerFRM_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Action_menu_Log.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Action_Menu.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ServerStatus.ResumeLayout(false);
            this.ServerStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private StatusStrip ServerStatus;
        private ToolStripMenuItem ConnectToDB;
        private ToolStripStatusLabel networkStatus;
        private ToolStripStatusLabel dbStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private IContainer components;
        private ContextMenuStrip Action_Menu;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel ClientCountLBL;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel7;
        private ContextMenuStrip Action_menu_Log;
        private ToolStripMenuItem Save_Action;
        private ToolStripMenuItem Clear_Action;
        private ListView DoorsView;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem CMD_Disconnect;
        private ToolStripMenuItem CMD_Hibernate;
        private ToolStripMenuItem CMD_Shutdown;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem CMD_ViewConfig;
        private ToolStripMenuItem CMD_DownloadConfig;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem CMD_Setting;
        private ToolStripMenuItem CMD_Monitor;
        private ToolStripMenuItem viewDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ImageList imageList;
        private ToolStripMenuItem CMD_Restart;
    }
}
