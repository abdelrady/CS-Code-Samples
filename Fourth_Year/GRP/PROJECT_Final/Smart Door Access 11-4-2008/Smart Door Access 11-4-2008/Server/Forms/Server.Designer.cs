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
        private TabControl tabControl;
        private TabPage tabPage1;
        private RichTextBox LogTXT;
        private TabPage tabPage2;
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LogTXT = new System.Windows.Forms.RichTextBox();
            this.Action_menu_Log = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Save_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DoorsView = new System.Windows.Forms.ListView();
            this.Action_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMD_openDoor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_Monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_ViewConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_Restart_Remote_App = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Hibernate = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.ActionMon1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectDoorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedDoorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Action_menu_Log.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Action_Menu.SuspendLayout();
            this.ActionMon1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.ServerStatus.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(648, 497);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogTXT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Event Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogTXT
            // 
            this.LogTXT.BackColor = System.Drawing.Color.White;
            this.LogTXT.ContextMenuStrip = this.Action_menu_Log;
            this.LogTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTXT.Location = new System.Drawing.Point(3, 3);
            this.LogTXT.Name = "LogTXT";
            this.LogTXT.ReadOnly = true;
            this.LogTXT.Size = new System.Drawing.Size(634, 465);
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
            this.Action_menu_Log.Size = new System.Drawing.Size(148, 48);
            this.Action_menu_Log.Opening += new System.ComponentModel.CancelEventHandler(this.Action_menu_Log_Opening);
            // 
            // Save_Action
            // 
            this.Save_Action.Image = ((System.Drawing.Image)(resources.GetObject("Save_Action.Image")));
            this.Save_Action.Name = "Save_Action";
            this.Save_Action.Size = new System.Drawing.Size(147, 22);
            this.Save_Action.Text = "Save To File ...";
            this.Save_Action.Click += new System.EventHandler(this.Save_Action_Click);
            // 
            // Clear_Action
            // 
            this.Clear_Action.Image = ((System.Drawing.Image)(resources.GetObject("Clear_Action.Image")));
            this.Clear_Action.Name = "Clear_Action";
            this.Clear_Action.Size = new System.Drawing.Size(147, 22);
            this.Clear_Action.Text = "Clear Log";
            this.Clear_Action.Click += new System.EventHandler(this.Clear_Action_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DoorsView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doors ";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.DoorsView.Size = new System.Drawing.Size(631, 461);
            this.DoorsView.TabIndex = 1;
            this.DoorsView.UseCompatibleStateImageBehavior = false;
            this.DoorsView.DoubleClick += new System.EventHandler(this.DoorsView_DoubleClick);
            // 
            // Action_Menu
            // 
            this.Action_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMD_openDoor,
            this.toolStripSeparator3,
            this.CMD_Monitor,
            this.toolStripSeparator5,
            this.sendToolStripMenuItem,
            this.toolStripSeparator6,
            this.CMD_ViewConfig,
            this.toolStripSeparator7,
            this.CMD_Restart_Remote_App,
            this.CMD_Disconnect,
            this.CMD_Hibernate,
            this.CMD_Shutdown});
            this.Action_Menu.Name = "Action_Menu";
            this.Action_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Action_Menu.Size = new System.Drawing.Size(240, 204);
            this.Action_Menu.Opening += new System.ComponentModel.CancelEventHandler(this.Action_Menu_Opening);
            // 
            // CMD_openDoor
            // 
            this.CMD_openDoor.Name = "CMD_openDoor";
            this.CMD_openDoor.Size = new System.Drawing.Size(239, 22);
            this.CMD_openDoor.Text = "Open Door";
            this.CMD_openDoor.Click += new System.EventHandler(this.CMD_openDoor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(236, 6);
            // 
            // CMD_Monitor
            // 
            this.CMD_Monitor.Name = "CMD_Monitor";
            this.CMD_Monitor.Size = new System.Drawing.Size(239, 22);
            this.CMD_Monitor.Text = "Monitor Door ...";
            this.CMD_Monitor.Click += new System.EventHandler(this.CMD_Monitor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(236, 6);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.sendToolStripMenuItem.Text = "Send Voice Command ...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(236, 6);
            // 
            // CMD_ViewConfig
            // 
            this.CMD_ViewConfig.Name = "CMD_ViewConfig";
            this.CMD_ViewConfig.Size = new System.Drawing.Size(239, 22);
            this.CMD_ViewConfig.Text = "View && Download Configuration ...";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(236, 6);
            // 
            // CMD_Restart_Remote_App
            // 
            this.CMD_Restart_Remote_App.Name = "CMD_Restart_Remote_App";
            this.CMD_Restart_Remote_App.Size = new System.Drawing.Size(239, 22);
            this.CMD_Restart_Remote_App.Text = "Restart Remote Application";
            this.CMD_Restart_Remote_App.Click += new System.EventHandler(this.CMD_Restart_Remote_App_Click);
            // 
            // CMD_Disconnect
            // 
            this.CMD_Disconnect.Name = "CMD_Disconnect";
            this.CMD_Disconnect.Size = new System.Drawing.Size(239, 22);
            this.CMD_Disconnect.Text = "Disconnect Door Socket";
            this.CMD_Disconnect.Click += new System.EventHandler(this.CMD_Disconnect_Click);
            // 
            // CMD_Hibernate
            // 
            this.CMD_Hibernate.Name = "CMD_Hibernate";
            this.CMD_Hibernate.Size = new System.Drawing.Size(239, 22);
            this.CMD_Hibernate.Text = "Hibernate Remote Machine";
            // 
            // CMD_Shutdown
            // 
            this.CMD_Shutdown.Name = "CMD_Shutdown";
            this.CMD_Shutdown.Size = new System.Drawing.Size(239, 22);
            this.CMD_Shutdown.Text = "Shutdown Remote Machine";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "DoorOnline");
            this.imageList.Images.SetKeyName(1, "DoorOffline");
            // 
            // ActionMon1
            // 
            this.ActionMon1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDoorToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopMonitoringToolStripMenuItem});
            this.ActionMon1.Name = "ActionMon1";
            this.ActionMon1.Size = new System.Drawing.Size(184, 70);
            // 
            // selectDoorToolStripMenuItem
            // 
            this.selectDoorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedDoorsToolStripMenuItem});
            this.selectDoorToolStripMenuItem.Name = "selectDoorToolStripMenuItem";
            this.selectDoorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.selectDoorToolStripMenuItem.Text = "Select Monitored Door ";
            // 
            // connectedDoorsToolStripMenuItem
            // 
            this.connectedDoorsToolStripMenuItem.Enabled = false;
            this.connectedDoorsToolStripMenuItem.Name = "connectedDoorsToolStripMenuItem";
            this.connectedDoorsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.connectedDoorsToolStripMenuItem.Text = "Connected Doors";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pauseToolStripMenuItem.Text = "Pause Monitoring";
            // 
            // stopMonitoringToolStripMenuItem
            // 
            this.stopMonitoringToolStripMenuItem.Name = "stopMonitoringToolStripMenuItem";
            this.stopMonitoringToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.stopMonitoringToolStripMenuItem.Text = "Stop Monitoring";
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
            this.MainMenu.Size = new System.Drawing.Size(657, 24);
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
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            // 
            // viewProfileToolStripMenuItem
            // 
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
            this.aboutSmartDoorProjectToolStripMenuItem.Click += new System.EventHandler(this.aboutSmartDoorProjectToolStripMenuItem_Click);
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
            this.ClientCountLBL,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.ServerStatus.Location = new System.Drawing.Point(0, 532);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(657, 22);
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
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel3.Text = "Compression:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel4.Text = "25%";
            // 
            // ServerFRM
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(657, 554);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.Action_Menu.ResumeLayout(false);
            this.ActionMon1.ResumeLayout(false);
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
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem CMD_Setting;
        private ToolStripMenuItem CMD_Monitor;
        private ImageList imageList;
        private ToolStripMenuItem CMD_Restart;
        private ToolStripMenuItem CMD_openDoor;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem CMD_Restart_Remote_App;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ContextMenuStrip ActionMon1;
        private ToolStripMenuItem selectDoorToolStripMenuItem;
        private ToolStripMenuItem connectedDoorsToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem stopMonitoringToolStripMenuItem;
    }
}
