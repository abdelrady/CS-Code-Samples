namespace Client_s_
{
    partial class ClientFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFRM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stopAudioChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioExchangeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSplashScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectLst = new System.Windows.Forms.ImageList(this.components);
            this.signInLnkLBL = new System.Windows.Forms.LinkLabel();
            this.SentTXT = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.ClientVEW = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rcvTXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToserverCHK = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ErrorTXT = new System.Windows.Forms.TextBox();
            this.SendFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.stopAudioChatToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.chatToolStripMenuItem.Text = "&Chat";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.disconnectToolStripMenuItem.Text = "S&ign out ...";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // stopAudioChatToolStripMenuItem
            // 
            this.stopAudioChatToolStripMenuItem.Name = "stopAudioChatToolStripMenuItem";
            this.stopAudioChatToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stopAudioChatToolStripMenuItem.Text = "Start Audio Chat";
            this.stopAudioChatToolStripMenuItem.Click += new System.EventHandler(this.stopAudioChatToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioExchangeSettingToolStripMenuItem,
            this.sdeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // audioExchangeSettingToolStripMenuItem
            // 
            this.audioExchangeSettingToolStripMenuItem.Name = "audioExchangeSettingToolStripMenuItem";
            this.audioExchangeSettingToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.audioExchangeSettingToolStripMenuItem.Text = "Audio Exchange Setting";
            this.audioExchangeSettingToolStripMenuItem.Click += new System.EventHandler(this.audioExchangeSettingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMessengerToolStripMenuItem,
            this.showSplashScreenToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMessengerToolStripMenuItem
            // 
            this.aboutMessengerToolStripMenuItem.Name = "aboutMessengerToolStripMenuItem";
            this.aboutMessengerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aboutMessengerToolStripMenuItem.Text = "About Messenger ...";
            this.aboutMessengerToolStripMenuItem.Click += new System.EventHandler(this.aboutMessengerToolStripMenuItem_Click);
            // 
            // showSplashScreenToolStripMenuItem
            // 
            this.showSplashScreenToolStripMenuItem.Name = "showSplashScreenToolStripMenuItem";
            this.showSplashScreenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showSplashScreenToolStripMenuItem.Text = "Show Splash Screen  ... ";
            this.showSplashScreenToolStripMenuItem.Click += new System.EventHandler(this.showSplashScreenToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLBL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(332, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLBL
            // 
            this.StatusLBL.BackColor = System.Drawing.Color.Transparent;
            this.StatusLBL.Name = "StatusLBL";
            this.StatusLBL.Size = new System.Drawing.Size(89, 17);
            this.StatusLBL.Text = " Disconnected ...";
            // 
            // ConnectLst
            // 
            this.ConnectLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ConnectLst.ImageStream")));
            this.ConnectLst.TransparentColor = System.Drawing.Color.Transparent;
            this.ConnectLst.Images.SetKeyName(0, "");
            this.ConnectLst.Images.SetKeyName(1, "");
            this.ConnectLst.Images.SetKeyName(2, "");
            this.ConnectLst.Images.SetKeyName(3, "");
            // 
            // signInLnkLBL
            // 
            this.signInLnkLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.signInLnkLBL.AutoSize = true;
            this.signInLnkLBL.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.signInLnkLBL.LinkArea = new System.Windows.Forms.LinkArea(5, 5);
            this.signInLnkLBL.Location = new System.Drawing.Point(98, 226);
            this.signInLnkLBL.Name = "signInLnkLBL";
            this.signInLnkLBL.Size = new System.Drawing.Size(137, 18);
            this.signInLnkLBL.TabIndex = 10;
            this.signInLnkLBL.TabStop = true;
            this.signInLnkLBL.Text = "Click here to Sign in . . . ";
            this.signInLnkLBL.UseCompatibleTextRendering = true;
            this.signInLnkLBL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signInLnkLBL_LinkClicked);
            // 
            // SentTXT
            // 
            this.SentTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SentTXT.Location = new System.Drawing.Point(6, 19);
            this.SentTXT.Multiline = true;
            this.SentTXT.Name = "SentTXT";
            this.SentTXT.Size = new System.Drawing.Size(221, 36);
            this.SentTXT.TabIndex = 14;
            this.SentTXT.TextChanged += new System.EventHandler(this.SentTXT_TextChanged);
            // 
            // SendBTN
            // 
            this.SendBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBTN.Enabled = false;
            this.SendBTN.Location = new System.Drawing.Point(230, 21);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(70, 34);
            this.SendBTN.TabIndex = 15;
            this.SendBTN.Text = "Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click_1);
            // 
            // ClientVEW
            // 
            this.ClientVEW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientVEW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientVEW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ClientVEW.ContextMenuStrip = this.contextMenuStrip1;
            this.ClientVEW.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientVEW.ForeColor = System.Drawing.Color.Blue;
            this.ClientVEW.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ClientVEW.LargeImageList = this.ConnectLst;
            this.ClientVEW.Location = new System.Drawing.Point(10, 19);
            this.ClientVEW.Name = "ClientVEW";
            this.ClientVEW.Size = new System.Drawing.Size(118, 345);
            this.ClientVEW.SmallImageList = this.ConnectLst;
            this.ClientVEW.TabIndex = 19;
            this.ClientVEW.UseCompatibleStateImageBehavior = false;
            this.ClientVEW.View = System.Windows.Forms.View.Details;
            this.ClientVEW.DoubleClick += new System.EventHandler(this.ClientVEW_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Frinds";
            this.columnHeader1.Width = 112;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.sToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 54);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // sendFileToolStripMenuItem
            // 
            this.sendFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendFileToolStripMenuItem.Image")));
            this.sendFileToolStripMenuItem.Name = "sendFileToolStripMenuItem";
            this.sendFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sendFileToolStripMenuItem.Text = "Send File ...";
            this.sendFileToolStripMenuItem.Click += new System.EventHandler(this.sendFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sToolStripMenuItem.Image")));
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sToolStripMenuItem.Text = "Send Nudge ...";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // rcvTXT
            // 
            this.rcvTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rcvTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rcvTXT.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rcvTXT.Location = new System.Drawing.Point(6, 19);
            this.rcvTXT.Multiline = true;
            this.rcvTXT.Name = "rcvTXT";
            this.rcvTXT.ReadOnly = true;
            this.rcvTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rcvTXT.Size = new System.Drawing.Size(151, 343);
            this.rcvTXT.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axShockwaveFlash);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 524);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // axShockwaveFlash
            // 
            this.axShockwaveFlash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlash.Enabled = true;
            this.axShockwaveFlash.Location = new System.Drawing.Point(0, 0);
            this.axShockwaveFlash.Name = "axShockwaveFlash";
            this.axShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash.OcxState")));
            this.axShockwaveFlash.Size = new System.Drawing.Size(332, 524);
            this.axShockwaveFlash.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ToserverCHK);
            this.groupBox1.Controls.Add(this.SentTXT);
            this.groupBox1.Controls.Add(this.SendBTN);
            this.groupBox1.Location = new System.Drawing.Point(8, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 85);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // ToserverCHK
            // 
            this.ToserverCHK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToserverCHK.AutoSize = true;
            this.ToserverCHK.Checked = true;
            this.ToserverCHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToserverCHK.Enabled = false;
            this.ToserverCHK.Location = new System.Drawing.Point(6, 62);
            this.ToserverCHK.Name = "ToserverCHK";
            this.ToserverCHK.Size = new System.Drawing.Size(100, 17);
            this.ToserverCHK.TabIndex = 16;
            this.ToserverCHK.Text = "Send To Server";
            this.ToserverCHK.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rcvTXT);
            this.groupBox2.Location = new System.Drawing.Point(8, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 374);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received text ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ClientVEW);
            this.groupBox3.Location = new System.Drawing.Point(180, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 374);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Clients";
            // 
            // ErrorTXT
            // 
            this.ErrorTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorTXT.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ErrorTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTXT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ErrorTXT.ForeColor = System.Drawing.Color.Red;
            this.ErrorTXT.Location = new System.Drawing.Point(-16, 246);
            this.ErrorTXT.Multiline = true;
            this.ErrorTXT.Name = "ErrorTXT";
            this.ErrorTXT.ReadOnly = true;
            this.ErrorTXT.Size = new System.Drawing.Size(365, 26);
            this.ErrorTXT.TabIndex = 16;
            this.ErrorTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ErrorTXT.Visible = false;
            // 
            // SendFileDialog
            // 
            this.SendFileDialog.Title = "Select single file to send";
            // 
            // sdeToolStripMenuItem
            // 
            this.sdeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sdeToolStripMenuItem.Image")));
            this.sdeToolStripMenuItem.Name = "sdeToolStripMenuItem";
            this.sdeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sdeToolStripMenuItem.Text = "Eject Video Preview";
            this.sdeToolStripMenuItem.Click += new System.EventHandler(this.sdeToolStripMenuItem_Click_1);
            // 
            // ClientFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 524);
            this.Controls.Add(this.ErrorTXT);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.signInLnkLBL);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(340, 558);
            this.Name = "ClientFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger Offline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ClientFRM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLBL;
        private System.Windows.Forms.ImageList ConnectLst;
        private System.Windows.Forms.LinkLabel signInLnkLBL;
        private System.Windows.Forms.TextBox SentTXT;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.ListView ClientVEW;
        private System.Windows.Forms.TextBox rcvTXT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox ErrorTXT;
        private System.Windows.Forms.CheckBox ToserverCHK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sendFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog SendFileDialog;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMessengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSplashScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAudioChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioExchangeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdeToolStripMenuItem;
    }
}

