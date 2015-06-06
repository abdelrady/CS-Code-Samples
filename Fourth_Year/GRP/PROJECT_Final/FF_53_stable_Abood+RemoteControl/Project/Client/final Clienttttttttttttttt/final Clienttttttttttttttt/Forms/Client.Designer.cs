using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDoor
{
    public partial class ClientFrm : System.Windows.Forms.Form
    {

       
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFrm));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userdescriptiontxt = new System.Windows.Forms.TextBox();
            this.userphonetxt = new System.Windows.Forms.TextBox();
            this.useremailtxt = new System.Windows.Forms.TextBox();
            this.userlnametxt = new System.Windows.Forms.TextBox();
            this.userfnametxt = new System.Windows.Forms.TextBox();
            this.userstagecbo = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.displayREdit = new System.Windows.Forms.RichTextBox();
            this.Action_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Save_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mode_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBLUpdates = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLastUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RestartApp_CMD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigureBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_KeyB_HID = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutSmartDoorProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CMD_Eject = new System.Windows.Forms.Button();
            this.HandelTXT = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Action_Menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Stage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Barcode Number";
            // 
            // userdescriptiontxt
            // 
            this.userdescriptiontxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userdescriptiontxt.Location = new System.Drawing.Point(99, 182);
            this.userdescriptiontxt.Multiline = true;
            this.userdescriptiontxt.Name = "userdescriptiontxt";
            this.userdescriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userdescriptiontxt.Size = new System.Drawing.Size(266, 52);
            this.userdescriptiontxt.TabIndex = 5;
            // 
            // userphonetxt
            // 
            this.userphonetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userphonetxt.Location = new System.Drawing.Point(99, 89);
            this.userphonetxt.Name = "userphonetxt";
            this.userphonetxt.Size = new System.Drawing.Size(266, 21);
            this.userphonetxt.TabIndex = 2;
            // 
            // useremailtxt
            // 
            this.useremailtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.useremailtxt.Location = new System.Drawing.Point(99, 145);
            this.useremailtxt.Name = "useremailtxt";
            this.useremailtxt.Size = new System.Drawing.Size(266, 21);
            this.useremailtxt.TabIndex = 4;
            // 
            // userlnametxt
            // 
            this.userlnametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userlnametxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlnametxt.ForeColor = System.Drawing.Color.Blue;
            this.userlnametxt.Location = new System.Drawing.Point(99, 53);
            this.userlnametxt.Name = "userlnametxt";
            this.userlnametxt.Size = new System.Drawing.Size(266, 21);
            this.userlnametxt.TabIndex = 1;
            this.userlnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userfnametxt
            // 
            this.userfnametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userfnametxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userfnametxt.ForeColor = System.Drawing.Color.Blue;
            this.userfnametxt.Location = new System.Drawing.Point(99, 29);
            this.userfnametxt.Name = "userfnametxt";
            this.userfnametxt.Size = new System.Drawing.Size(266, 21);
            this.userfnametxt.TabIndex = 0;
            this.userfnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userstagecbo
            // 
            this.userstagecbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userstagecbo.Location = new System.Drawing.Point(99, 117);
            this.userstagecbo.Name = "userstagecbo";
            this.userstagecbo.Size = new System.Drawing.Size(266, 21);
            this.userstagecbo.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(6, 70);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(573, 385);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 46;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.button2);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.userdescriptiontxt);
            this.groupBox.Controls.Add(this.userstagecbo);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.image);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.userphonetxt);
            this.groupBox.Controls.Add(this.userfnametxt);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.userlnametxt);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.useremailtxt);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(573, 254);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Student Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.image.BackColor = System.Drawing.SystemColors.ControlText;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(372, 20);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(190, 214);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 24;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.displayREdit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 127);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Log";
            // 
            // displayREdit
            // 
            this.displayREdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.displayREdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayREdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayREdit.ContextMenuStrip = this.Action_Menu;
            this.displayREdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.displayREdit.Location = new System.Drawing.Point(10, 21);
            this.displayREdit.Name = "displayREdit";
            this.displayREdit.ReadOnly = true;
            this.displayREdit.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.displayREdit.Size = new System.Drawing.Size(552, 95);
            this.displayREdit.TabIndex = 0;
            this.displayREdit.Text = "";
            this.displayREdit.TextChanged += new System.EventHandler(this.displayREdit_TextChanged);
            // 
            // Action_Menu
            // 
            this.Action_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_Action,
            this.Clear_Action});
            this.Action_Menu.Name = "Action_Menu";
            this.Action_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Action_Menu.Size = new System.Drawing.Size(129, 48);
            this.Action_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Action_Menu_Paint);
            this.Action_Menu.Opening += new System.ComponentModel.CancelEventHandler(this.Action_Menu_Opening);
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
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.Mode_Status,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel1,
            this.toolStripStatus,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel6,
            this.LBLUpdates,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.LblLastUpdate,
            this.toolStripStatusLabel10});
            this.statusStrip.Location = new System.Drawing.Point(0, 475);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(583, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 47;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Paint += new System.Windows.Forms.PaintEventHandler(this.statusStrip1_Paint);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel2.Text = "Mode:";
            // 
            // Mode_Status
            // 
            this.Mode_Status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode_Status.ForeColor = System.Drawing.Color.Green;
            this.Mode_Status.Name = "Mode_Status";
            this.Mode_Status.Size = new System.Drawing.Size(47, 17);
            this.Mode_Status.Text = "Normal";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = " ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatus.Image")));
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatus.Text = "Disconnected";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel4.Text = " ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel6.Text = "Updates Status:";
            // 
            // LBLUpdates
            // 
            this.LBLUpdates.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUpdates.ForeColor = System.Drawing.Color.Blue;
            this.LBLUpdates.Name = "LBLUpdates";
            this.LBLUpdates.Size = new System.Drawing.Size(29, 17);
            this.LBLUpdates.Text = "Idle";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel7.Text = " ";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel8.Text = "Last Update:";
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastUpdate.ForeColor = System.Drawing.Color.Blue;
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(126, 17);
            this.LblLastUpdate.Text = "No Updates Received";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(0, 17);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.adminstrationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(583, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdConnect,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.RestartApp_CMD,
            this.toolStripSeparator3,
            this.ExitMBTN});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.serverToolStripMenuItem.Text = "Door";
            // 
            // CmdConnect
            // 
            this.CmdConnect.Image = ((System.Drawing.Image)(resources.GetObject("CmdConnect.Image")));
            this.CmdConnect.Name = "CmdConnect";
            this.CmdConnect.Size = new System.Drawing.Size(186, 22);
            this.CmdConnect.Text = "&Connect";
            this.CmdConnect.Click += new System.EventHandler(this.CmdConnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // RestartApp_CMD
            // 
            this.RestartApp_CMD.Image = ((System.Drawing.Image)(resources.GetObject("RestartApp_CMD.Image")));
            this.RestartApp_CMD.Name = "RestartApp_CMD";
            this.RestartApp_CMD.Size = new System.Drawing.Size(186, 22);
            this.RestartApp_CMD.Text = "Restart Application";
            this.RestartApp_CMD.Click += new System.EventHandler(this.RestartApp_CMD_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // ExitMBTN
            // 
            this.ExitMBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExitMBTN.Image")));
            this.ExitMBTN.Name = "ExitMBTN";
            this.ExitMBTN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMBTN.Size = new System.Drawing.Size(186, 22);
            this.ExitMBTN.Text = "Exit";
            this.ExitMBTN.Click += new System.EventHandler(this.ExitMBTN_Click);
            // 
            // adminstrationToolStripMenuItem
            // 
            this.adminstrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigureBTN,
            this.CMD_KeyB_HID});
            this.adminstrationToolStripMenuItem.Name = "adminstrationToolStripMenuItem";
            this.adminstrationToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.adminstrationToolStripMenuItem.Text = "Tools";
            // 
            // ConfigureBTN
            // 
            this.ConfigureBTN.Name = "ConfigureBTN";
            this.ConfigureBTN.Size = new System.Drawing.Size(163, 22);
            this.ConfigureBTN.Text = "Door Setting ...";
            this.ConfigureBTN.Click += new System.EventHandler(this.ConfigureBTN_Click);
            // 
            // CMD_KeyB_HID
            // 
            this.CMD_KeyB_HID.Name = "CMD_KeyB_HID";
            this.CMD_KeyB_HID.Size = new System.Drawing.Size(163, 22);
            this.CMD_KeyB_HID.Text = "Keyboards && HID\'s";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(95, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 37);
            this.panel1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(116, 6);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(273, 22);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CMD_Eject
            // 
            this.CMD_Eject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CMD_Eject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CMD_Eject.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CMD_Eject.Location = new System.Drawing.Point(500, 26);
            this.CMD_Eject.Name = "CMD_Eject";
            this.CMD_Eject.Size = new System.Drawing.Size(59, 21);
            this.CMD_Eject.TabIndex = 48;
            this.CMD_Eject.Text = "8";
            this.CMD_Eject.UseVisualStyleBackColor = true;
            this.CMD_Eject.Click += new System.EventHandler(this.CMD_Eject_Click);
            // 
            // HandelTXT
            // 
            this.HandelTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HandelTXT.Location = new System.Drawing.Point(500, 48);
            this.HandelTXT.Name = "HandelTXT";
            this.HandelTXT.Size = new System.Drawing.Size(59, 21);
            this.HandelTXT.TabIndex = 39;
            this.HandelTXT.Text = "65666";
            this.HandelTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HandelTXT.TextChanged += new System.EventHandler(this.HandelTXT_TextChanged);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(6, 26);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 49;
            this.btnTest.Text = "Test Fast";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Unblock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem1.Text = "Connect To SQL Server";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ClientFrm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(583, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.HandelTXT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CMD_Eject);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(591, 524);
            this.Name = "ClientFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "unC:\\WINDOWS\\hinhem.scr ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ClientFrm_Paint);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientFrm_FormClosing);
            this.Load += new System.EventHandler(this.ClientFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.Action_Menu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userdescriptiontxt;
        private System.Windows.Forms.TextBox userphonetxt;
        private System.Windows.Forms.TextBox useremailtxt;
        private System.Windows.Forms.TextBox userlnametxt;
        private System.Windows.Forms.TextBox userfnametxt;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox userstagecbo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox displayREdit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CmdConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMBTN;
        private System.Windows.Forms.ToolStripMenuItem adminstrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigureBTN;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutSmartDoorProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel Mode_Status;
        private System.Windows.Forms.ContextMenuStrip Action_Menu;
        private System.Windows.Forms.ToolStripMenuItem Save_Action;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem Clear_Action;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel LBLUpdates;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;      
        private System.Windows.Forms.ToolStripStatusLabel LblLastUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem RestartApp_CMD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CMD_KeyB_HID;
        private System.Windows.Forms.Button CMD_Eject;
        private System.Windows.Forms.TextBox HandelTXT;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
