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
            this.ConnectLst = new System.Windows.Forms.ImageList(this.components);
            this.WorkBTN = new System.Windows.Forms.Button();
            this.IpTXT = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.ToallCHK = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listenToClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortTXT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sentTXT = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.workInBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullServerMoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientVEW
            // 
            this.ClientVEW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientVEW.AutoArrange = false;
            this.ClientVEW.BackColor = System.Drawing.Color.White;
            this.ClientVEW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientVEW.BackgroundImage")));
            this.ClientVEW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientName,
            this.Time,
            this.Addresse});
            this.ClientVEW.ForeColor = System.Drawing.Color.Blue;
            this.ClientVEW.LargeImageList = this.ConnectLst;
            this.ClientVEW.Location = new System.Drawing.Point(22, 19);
            this.ClientVEW.Name = "ClientVEW";
            this.ClientVEW.Size = new System.Drawing.Size(306, 215);
            this.ClientVEW.SmallImageList = this.ConnectLst;
            this.ClientVEW.TabIndex = 4;
            this.ClientVEW.UseCompatibleStateImageBehavior = false;
            this.ClientVEW.View = System.Windows.Forms.View.Details;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Client Nickname";
            this.ClientName.Width = 109;
            // 
            // Time
            // 
            this.Time.Text = "Join Time";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 86;
            // 
            // Addresse
            // 
            this.Addresse.Text = "Address Family";
            this.Addresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Addresse.Width = 107;
            // 
            // ConnectLst
            // 
            this.ConnectLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ConnectLst.ImageStream")));
            this.ConnectLst.TransparentColor = System.Drawing.Color.Transparent;
            this.ConnectLst.Images.SetKeyName(0, "connected.ico");
            this.ConnectLst.Images.SetKeyName(1, "disconnected.ico");
            this.ConnectLst.Images.SetKeyName(2, "OFF.ico");
            this.ConnectLst.Images.SetKeyName(3, "ON.ico");
            // 
            // WorkBTN
            // 
            this.WorkBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WorkBTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WorkBTN.Location = new System.Drawing.Point(550, 307);
            this.WorkBTN.Name = "WorkBTN";
            this.WorkBTN.Size = new System.Drawing.Size(71, 46);
            this.WorkBTN.TabIndex = 0;
            this.WorkBTN.Text = "&Listen";
            this.WorkBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.WorkBTN.UseVisualStyleBackColor = true;
            this.WorkBTN.Click += new System.EventHandler(this.WorkBTN_Click);
            // 
            // IpTXT
            // 
            this.IpTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IpTXT.Location = new System.Drawing.Point(445, 307);
            this.IpTXT.Name = "IpTXT";
            this.IpTXT.Size = new System.Drawing.Size(99, 20);
            this.IpTXT.TabIndex = 2;
            this.IpTXT.Text = "127. 0 . 0 . 1";
            this.IpTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendBTN
            // 
            this.SendBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBTN.Enabled = false;
            this.SendBTN.Location = new System.Drawing.Point(250, 25);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(75, 36);
            this.SendBTN.TabIndex = 9;
            this.SendBTN.Text = "Send";
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
            this.ToallCHK.Location = new System.Drawing.Point(11, 68);
            this.ToallCHK.Name = "ToallCHK";
            this.ToallCHK.Size = new System.Drawing.Size(99, 17);
            this.ToallCHK.TabIndex = 11;
            this.ToallCHK.Text = "Send text to all";
            this.ToallCHK.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listenToClientsToolStripMenuItem,
            this.toolStripSeparator2,
            this.workInBackgroundToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // listenToClientsToolStripMenuItem
            // 
            this.listenToClientsToolStripMenuItem.Name = "listenToClientsToolStripMenuItem";
            this.listenToClientsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listenToClientsToolStripMenuItem.Text = "Listen to Clients";
            this.listenToClientsToolStripMenuItem.Click += new System.EventHandler(this.listenToClientsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About Server ...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.ClientVEW);
            this.groupBox1.Location = new System.Drawing.Point(9, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 251);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(370, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(361, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port Number";
            // 
            // PortTXT
            // 
            this.PortTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTXT.Location = new System.Drawing.Point(445, 333);
            this.PortTXT.Name = "PortTXT";
            this.PortTXT.Size = new System.Drawing.Size(99, 20);
            this.PortTXT.TabIndex = 18;
            this.PortTXT.Text = "5000";
            this.PortTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Log);
            this.groupBox2.Location = new System.Drawing.Point(361, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 251);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "log ";
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(14, 19);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(230, 213);
            this.Log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.sentTXT);
            this.groupBox3.Controls.Add(this.SendBTN);
            this.groupBox3.Controls.Add(this.ToallCHK);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 93);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Client from the list to send message";
            // 
            // sentTXT
            // 
            this.sentTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sentTXT.Location = new System.Drawing.Point(11, 25);
            this.sentTXT.MinimumSize = new System.Drawing.Size(234, 20);
            this.sentTXT.Multiline = true;
            this.sentTXT.Name = "sentTXT";
            this.sentTXT.Size = new System.Drawing.Size(237, 36);
            this.sentTXT.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLBL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(636, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLBL
            // 
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(110, 17);
            this.statusLBL.Text = "Server Disconnected.";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Server working in Background";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // workInBackgroundToolStripMenuItem
            // 
            this.workInBackgroundToolStripMenuItem.Enabled = false;
            this.workInBackgroundToolStripMenuItem.Name = "workInBackgroundToolStripMenuItem";
            this.workInBackgroundToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.workInBackgroundToolStripMenuItem.Text = "Work in Background";
            this.workInBackgroundToolStripMenuItem.Click += new System.EventHandler(this.workInBackgroundToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullServerMoodToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fullServerMoodToolStripMenuItem
            // 
            this.fullServerMoodToolStripMenuItem.Enabled = false;
            this.fullServerMoodToolStripMenuItem.Name = "fullServerMoodToolStripMenuItem";
            this.fullServerMoodToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fullServerMoodToolStripMenuItem.Text = "Full Server Mood";
            this.fullServerMoodToolStripMenuItem.Click += new System.EventHandler(this.fullServerMoodToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(151, 6);
            // 
            // Server
            // 
            this.AcceptButton = this.WorkBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 413);
            this.Controls.Add(this.WorkBTN);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PortTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpTXT);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(644, 447);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listenToClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortTXT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox sentTXT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLBL;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem workInBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fullServerMoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

