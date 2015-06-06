namespace Server
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.ClientVEW = new System.Windows.Forms.ListView();
            this.ClientName = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.Addresse = new System.Windows.Forms.ColumnHeader();
            this.contextMenu2 = new System.Windows.Forms.ContextMenu();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.ConnectLst = new System.Windows.Forms.ImageList(this.components);
            this.WorkBTN = new System.Windows.Forms.Button();
            this.IpTXT = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.ToallCHK = new System.Windows.Forms.CheckBox();
            this.PortTXT = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sentTXT = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.fullServerMoodToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.MenuItem();
            this.ClientsTXT = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.listenToClientsToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.workInBackgroundToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.statusLBL = new System.Windows.Forms.StatusBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LocalView = new System.Windows.Forms.PictureBox();
            this.StopBTN = new System.Windows.Forms.Button();
            this.SCaptureBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.device_number_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientVEW
            // 
            this.ClientVEW.AutoArrange = false;
            this.ClientVEW.BackColor = System.Drawing.Color.White;
            this.ClientVEW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientVEW.BackgroundImage")));
            this.ClientVEW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientName,
            this.Time,
            this.Addresse});
            this.ClientVEW.ContextMenu = this.contextMenu2;
            this.ClientVEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientVEW.ForeColor = System.Drawing.Color.Blue;
            this.ClientVEW.LargeImageList = this.ConnectLst;
            this.ClientVEW.Location = new System.Drawing.Point(3, 3);
            this.ClientVEW.Name = "ClientVEW";
            this.ClientVEW.Size = new System.Drawing.Size(325, 235);
            this.ClientVEW.SmallImageList = this.ConnectLst;
            this.ClientVEW.TabIndex = 4;
            this.ClientVEW.UseCompatibleStateImageBehavior = false;
            this.ClientVEW.View = System.Windows.Forms.View.Details;
            this.ClientVEW.DoubleClick += new System.EventHandler(this.ClientVEW_DoubleClick);
            // 
            // ClientName
            // 
            this.ClientName.Text = "Client Nickname";
            this.ClientName.Width = 124;
            // 
            // Time
            // 
            this.Time.Text = "Join Time";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 80;
            // 
            // Addresse
            // 
            this.Addresse.Text = "IP address";
            this.Addresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Addresse.Width = 113;
            // 
            // contextMenu2
            // 
            this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem11,
            this.menuItem12,
            this.menuItem13});
            this.contextMenu2.Popup += new System.EventHandler(this.contextMenu2_Popup);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "Dismss";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 1;
            this.menuItem11.Text = "Send Nudge";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.Text = "Start Video Exchange";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 3;
            this.menuItem13.Text = "Start Audio Exchange";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // ConnectLst
            // 
            this.ConnectLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ConnectLst.ImageStream")));
            this.ConnectLst.TransparentColor = System.Drawing.Color.Transparent;
            this.ConnectLst.Images.SetKeyName(0, "connected.ico");
            this.ConnectLst.Images.SetKeyName(1, "disconnected.ico");
            this.ConnectLst.Images.SetKeyName(2, "OFF.ico");
            this.ConnectLst.Images.SetKeyName(3, "ON.ico");
            this.ConnectLst.Images.SetKeyName(4, "107.ico");
            // 
            // WorkBTN
            // 
            this.WorkBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WorkBTN.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.WorkBTN.Image = ((System.Drawing.Image)(resources.GetObject("WorkBTN.Image")));
            this.WorkBTN.Location = new System.Drawing.Point(365, 228);
            this.WorkBTN.Name = "WorkBTN";
            this.WorkBTN.Size = new System.Drawing.Size(108, 51);
            this.WorkBTN.TabIndex = 0;
            this.WorkBTN.Text = "Start Server";
            this.WorkBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WorkBTN.UseVisualStyleBackColor = true;
            this.WorkBTN.Click += new System.EventHandler(this.WorkBTN_Click);
            // 
            // IpTXT
            // 
            this.IpTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IpTXT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.IpTXT.Location = new System.Drawing.Point(365, 50);
            this.IpTXT.Name = "IpTXT";
            this.IpTXT.ReadOnly = true;
            this.IpTXT.Size = new System.Drawing.Size(108, 20);
            this.IpTXT.TabIndex = 2;
            this.IpTXT.Text = "127. 0 . 0 . 1";
            this.IpTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendBTN
            // 
            this.SendBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBTN.Enabled = false;
            this.SendBTN.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.SendBTN.Location = new System.Drawing.Point(265, 24);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(63, 36);
            this.SendBTN.TabIndex = 9;
            this.SendBTN.Text = "&Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // ToallCHK
            // 
            this.ToallCHK.AutoSize = true;
            this.ToallCHK.BackColor = System.Drawing.Color.Transparent;
            this.ToallCHK.Checked = true;
            this.ToallCHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToallCHK.Enabled = false;
            this.ToallCHK.Location = new System.Drawing.Point(12, 64);
            this.ToallCHK.Name = "ToallCHK";
            this.ToallCHK.Size = new System.Drawing.Size(74, 17);
            this.ToallCHK.TabIndex = 11;
            this.ToallCHK.Text = "Broadcast";
            this.ToallCHK.UseVisualStyleBackColor = false;
            // 
            // PortTXT
            // 
            this.PortTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTXT.Location = new System.Drawing.Point(365, 100);
            this.PortTXT.Name = "PortTXT";
            this.PortTXT.ReadOnly = true;
            this.PortTXT.Size = new System.Drawing.Size(108, 20);
            this.PortTXT.TabIndex = 18;
            this.PortTXT.Text = "5000";
            this.PortTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.White;
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.ForeColor = System.Drawing.Color.Black;
            this.Log.Location = new System.Drawing.Point(3, 3);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(325, 235);
            this.Log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.sentTXT);
            this.groupBox3.Controls.Add(this.SendBTN);
            this.groupBox3.Controls.Add(this.ToallCHK);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 88);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Client from the list to send message";
            // 
            // sentTXT
            // 
            this.sentTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sentTXT.Enabled = false;
            this.sentTXT.Location = new System.Drawing.Point(12, 24);
            this.sentTXT.MinimumSize = new System.Drawing.Size(234, 20);
            this.sentTXT.Multiline = true;
            this.sentTXT.Name = "sentTXT";
            this.sentTXT.Size = new System.Drawing.Size(251, 35);
            this.sentTXT.TabIndex = 12;
            this.sentTXT.TextChanged += new System.EventHandler(this.sentTXT_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Server Disconnected";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fullServerMoodToolStripMenuItem,
            this.menuItem5,
            this.toolStripMenuItem2,
            this.menuItem7,
            this.menuItem3,
            this.menuItem10,
            this.toolStripMenuItem1});
            // 
            // fullServerMoodToolStripMenuItem
            // 
            this.fullServerMoodToolStripMenuItem.Enabled = false;
            this.fullServerMoodToolStripMenuItem.Index = 0;
            this.fullServerMoodToolStripMenuItem.Text = "Full Server Mood";
            this.fullServerMoodToolStripMenuItem.Click += new System.EventHandler(this.fullServerMoodToolStripMenuItem_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Index = 2;
            this.toolStripMenuItem2.Text = "Work in Background";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Enabled = false;
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "Stop ...";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 5;
            this.menuItem10.Text = "-";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Index = 6;
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ClientsTXT
            // 
            this.ClientsTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsTXT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ClientsTXT.Location = new System.Drawing.Point(365, 150);
            this.ClientsTXT.Name = "ClientsTXT";
            this.ClientsTXT.ReadOnly = true;
            this.ClientsTXT.Size = new System.Drawing.Size(108, 20);
            this.ClientsTXT.TabIndex = 31;
            this.ClientsTXT.Text = "30";
            this.ClientsTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem14,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.listenToClientsToolStripMenuItem,
            this.menuItem4,
            this.workInBackgroundToolStripMenuItem,
            this.menuItem6,
            this.exitToolStripMenuItem});
            this.menuItem1.Text = "Server";
            // 
            // listenToClientsToolStripMenuItem
            // 
            this.listenToClientsToolStripMenuItem.Index = 0;
            this.listenToClientsToolStripMenuItem.Text = "Listen to Clients";
            this.listenToClientsToolStripMenuItem.Click += new System.EventHandler(this.listenToClientsToolStripMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // workInBackgroundToolStripMenuItem
            // 
            this.workInBackgroundToolStripMenuItem.Enabled = false;
            this.workInBackgroundToolStripMenuItem.Index = 2;
            this.workInBackgroundToolStripMenuItem.Text = "Work in Background";
            this.workInBackgroundToolStripMenuItem.Click += new System.EventHandler(this.workInBackgroundToolStripMenuItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "-";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Index = 4;
            this.exitToolStripMenuItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15});
            this.menuItem14.Text = "Tools";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 0;
            this.menuItem15.Text = "Audio Options";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8});
            this.menuItem2.Text = "Help";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "About Server ...";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // statusLBL
            // 
            this.statusLBL.Location = new System.Drawing.Point(0, 383);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(485, 22);
            this.statusLBL.TabIndex = 32;
            this.statusLBL.Text = "Disconnected.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 267);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Log);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClientVEW);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(331, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Video Capture";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(135, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 42);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LocalView);
            this.panel1.Controls.Add(this.StopBTN);
            this.panel1.Controls.Add(this.SCaptureBtn);
            this.panel1.Location = new System.Drawing.Point(43, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 210);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(218, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 15);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LocalView
            // 
            this.LocalView.BackColor = System.Drawing.SystemColors.ControlText;
            this.LocalView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LocalView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LocalView.Image = ((System.Drawing.Image)(resources.GetObject("LocalView.Image")));
            this.LocalView.InitialImage = null;
            this.LocalView.Location = new System.Drawing.Point(13, 16);
            this.LocalView.Name = "LocalView";
            this.LocalView.Size = new System.Drawing.Size(219, 171);
            this.LocalView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LocalView.TabIndex = 0;
            this.LocalView.TabStop = false;
            // 
            // StopBTN
            // 
            this.StopBTN.BackColor = System.Drawing.Color.Red;
            this.StopBTN.Enabled = false;
            this.StopBTN.Location = new System.Drawing.Point(193, 192);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(12, 13);
            this.StopBTN.TabIndex = 41;
            this.StopBTN.UseVisualStyleBackColor = false;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // SCaptureBtn
            // 
            this.SCaptureBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.SCaptureBtn.Location = new System.Drawing.Point(205, 192);
            this.SCaptureBtn.Name = "SCaptureBtn";
            this.SCaptureBtn.Size = new System.Drawing.Size(12, 13);
            this.SCaptureBtn.TabIndex = 38;
            this.SCaptureBtn.UseVisualStyleBackColor = false;
            this.SCaptureBtn.Click += new System.EventHandler(this.SCaptureBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(358, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Capturing Device ID";
            // 
            // device_number_textBox
            // 
            this.device_number_textBox.Location = new System.Drawing.Point(365, 202);
            this.device_number_textBox.Name = "device_number_textBox";
            this.device_number_textBox.Size = new System.Drawing.Size(108, 20);
            this.device_number_textBox.TabIndex = 39;
            this.device_number_textBox.Text = "0";
            this.device_number_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Local Machine IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Main Chat Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Max Clients";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 405);
            this.Controls.Add(this.device_number_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusLBL);
            this.Controls.Add(this.ClientsTXT);
            this.Controls.Add(this.WorkBTN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.IpTXT);
            this.Controls.Add(this.PortTXT);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocalView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ClientVEW;
        private System.Windows.Forms.ImageList ConnectLst;
        private System.Windows.Forms.Button WorkBTN;
        private System.Windows.Forms.TextBox IpTXT;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Addresse;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.CheckBox ToallCHK;
        private System.Windows.Forms.TextBox PortTXT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox sentTXT;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox ClientsTXT;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem listenToClientsToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem workInBackgroundToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem fullServerMoodToolStripMenuItem;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusBar statusLBL;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.ContextMenu contextMenu2;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox device_number_textBox;
        private System.Windows.Forms.Button SCaptureBtn;
        private System.Windows.Forms.PictureBox LocalView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem15;
    }
}

