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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectLst = new System.Windows.Forms.ImageList(this.components);
            this.signInLnkLBL = new System.Windows.Forms.LinkLabel();
            this.SentTXT = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.ClientVEW = new System.Windows.Forms.ListView();
            this.rcvTXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.chatToolStripMenuItem.Text = "Chat";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLBL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(387, 22);
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
            this.ConnectLst.Images.SetKeyName(0, "connected.ico");
            this.ConnectLst.Images.SetKeyName(1, "disconnected.ico");
            this.ConnectLst.Images.SetKeyName(2, "OFF.ico");
            this.ConnectLst.Images.SetKeyName(3, "ON.ico");
            // 
            // signInLnkLBL
            // 
            this.signInLnkLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.signInLnkLBL.AutoSize = true;
            this.signInLnkLBL.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.signInLnkLBL.LinkArea = new System.Windows.Forms.LinkArea(5, 5);
            this.signInLnkLBL.Location = new System.Drawing.Point(122, 226);
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
            this.SentTXT.Location = new System.Drawing.Point(3, 20);
            this.SentTXT.Multiline = true;
            this.SentTXT.Name = "SentTXT";
            this.SentTXT.Size = new System.Drawing.Size(263, 36);
            this.SentTXT.TabIndex = 14;
            // 
            // SendBTN
            // 
            this.SendBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBTN.Location = new System.Drawing.Point(272, 20);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(82, 37);
            this.SendBTN.TabIndex = 15;
            this.SendBTN.Text = "Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click_1);
            // 
            // ClientVEW
            // 
            this.ClientVEW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientVEW.BackColor = System.Drawing.Color.White;
            this.ClientVEW.ForeColor = System.Drawing.Color.Blue;
            this.ClientVEW.LargeImageList = this.ConnectLst;
            this.ClientVEW.Location = new System.Drawing.Point(8, 19);
            this.ClientVEW.Name = "ClientVEW";
            this.ClientVEW.Size = new System.Drawing.Size(103, 345);
            this.ClientVEW.SmallImageList = this.ConnectLst;
            this.ClientVEW.TabIndex = 19;
            this.ClientVEW.UseCompatibleStateImageBehavior = false;
            this.ClientVEW.View = System.Windows.Forms.View.List;
            // 
            // rcvTXT
            // 
            this.rcvTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rcvTXT.Location = new System.Drawing.Point(3, 19);
            this.rcvTXT.Multiline = true;
            this.rcvTXT.Name = "rcvTXT";
            this.rcvTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rcvTXT.Size = new System.Drawing.Size(223, 345);
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
            this.panel1.Size = new System.Drawing.Size(387, 511);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SentTXT);
            this.groupBox1.Controls.Add(this.SendBTN);
            this.groupBox1.Location = new System.Drawing.Point(8, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 66);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received text ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rcvTXT);
            this.groupBox2.Location = new System.Drawing.Point(8, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 376);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received text ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClientVEW);
            this.groupBox3.Location = new System.Drawing.Point(252, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 376);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Clients";
            // 
            // axShockwaveFlash
            // 
            this.axShockwaveFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axShockwaveFlash.Enabled = true;
            this.axShockwaveFlash.Location = new System.Drawing.Point(1, 27);
            this.axShockwaveFlash.Name = "axShockwaveFlash";
            this.axShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash.OcxState")));
            this.axShockwaveFlash.Size = new System.Drawing.Size(384, 484);
            this.axShockwaveFlash.TabIndex = 25;
            // 
            // ClientFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(387, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.signInLnkLBL);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(395, 545);
            this.Name = "ClientFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ali Messenger Offline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).EndInit();
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
    }
}

