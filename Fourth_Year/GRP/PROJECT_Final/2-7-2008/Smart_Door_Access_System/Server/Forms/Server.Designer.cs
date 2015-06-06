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
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_Restart_Remote_App = new System.Windows.Forms.ToolStripMenuItem();
            this.CMD_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CMD_Proprities = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusCbo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usernamesCbo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.doornamesCbo = new System.Windows.Forms.ComboBox();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtrefreshrate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CMD_Refresh = new System.Windows.Forms.Button();
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
            this.Quality = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnIncQuality = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDecQuality = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResponseSZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Action_menu_Log.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Action_Menu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrefreshrate)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(4, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(818, 497);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogTXT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 471);
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
            this.LogTXT.Size = new System.Drawing.Size(804, 465);
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
            this.tabPage2.Size = new System.Drawing.Size(810, 471);
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
            this.DoorsView.Size = new System.Drawing.Size(801, 461);
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
            this.toolStripSeparator6,
            this.CMD_Restart_Remote_App,
            this.CMD_Disconnect,
            this.toolStripSeparator4,
            this.CMD_Proprities});
            this.Action_Menu.Name = "Action_Menu";
            this.Action_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Action_Menu.Size = new System.Drawing.Size(206, 132);
            this.Action_Menu.Opening += new System.ComponentModel.CancelEventHandler(this.Action_Menu_Opening);
            // 
            // CMD_openDoor
            // 
            this.CMD_openDoor.Name = "CMD_openDoor";
            this.CMD_openDoor.Size = new System.Drawing.Size(205, 22);
            this.CMD_openDoor.Text = "Open Door";
            this.CMD_openDoor.Click += new System.EventHandler(this.CMD_openDoor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // CMD_Monitor
            // 
            this.CMD_Monitor.Name = "CMD_Monitor";
            this.CMD_Monitor.Size = new System.Drawing.Size(205, 22);
            this.CMD_Monitor.Text = "Monitor Door ...";
            this.CMD_Monitor.Click += new System.EventHandler(this.CMD_Monitor_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(202, 6);
            // 
            // CMD_Restart_Remote_App
            // 
            this.CMD_Restart_Remote_App.Name = "CMD_Restart_Remote_App";
            this.CMD_Restart_Remote_App.Size = new System.Drawing.Size(205, 22);
            this.CMD_Restart_Remote_App.Text = "Restart Remote Application";
            this.CMD_Restart_Remote_App.Click += new System.EventHandler(this.CMD_Restart_Remote_App_Click);
            // 
            // CMD_Disconnect
            // 
            this.CMD_Disconnect.Name = "CMD_Disconnect";
            this.CMD_Disconnect.Size = new System.Drawing.Size(205, 22);
            this.CMD_Disconnect.Text = "Disconnect Door Socket";
            this.CMD_Disconnect.Click += new System.EventHandler(this.CMD_Disconnect_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(202, 6);
            // 
            // CMD_Proprities
            // 
            this.CMD_Proprities.Name = "CMD_Proprities";
            this.CMD_Proprities.Size = new System.Drawing.Size(205, 22);
            this.CMD_Proprities.Text = "&Properities";
            this.CMD_Proprities.Click += new System.EventHandler(this.DoorsView_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "DoorOnline");
            this.imageList.Images.SetKeyName(1, "DoorOffline");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnViewReport);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.CMD_Refresh);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(810, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs Records";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(305, 366);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Don\'t Filter";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.statusCbo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.usernamesCbo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.doornamesCbo);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 83);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering Criteria";
            // 
            // statusCbo
            // 
            this.statusCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCbo.FormattingEnabled = true;
            this.statusCbo.Items.AddRange(new object[] {
            "Enter",
            "Exit Door",
            "Standalone",
            "User Theif"});
            this.statusCbo.Location = new System.Drawing.Point(496, 35);
            this.statusCbo.Name = "statusCbo";
            this.statusCbo.Size = new System.Drawing.Size(121, 21);
            this.statusCbo.TabIndex = 20;
            this.statusCbo.SelectedIndexChanged += new System.EventHandler(this.statusCbo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Status";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(329, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker2.TabIndex = 18;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Action Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "User Name";
            // 
            // usernamesCbo
            // 
            this.usernamesCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usernamesCbo.FormattingEnabled = true;
            this.usernamesCbo.Location = new System.Drawing.Point(70, 52);
            this.usernamesCbo.Name = "usernamesCbo";
            this.usernamesCbo.Size = new System.Drawing.Size(121, 21);
            this.usernamesCbo.TabIndex = 13;
            this.usernamesCbo.SelectedIndexChanged += new System.EventHandler(this.usernamesCbo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Door Name";
            // 
            // doornamesCbo
            // 
            this.doornamesCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doornamesCbo.FormattingEnabled = true;
            this.doornamesCbo.Location = new System.Drawing.Point(70, 25);
            this.doornamesCbo.Name = "doornamesCbo";
            this.doornamesCbo.Size = new System.Drawing.Size(121, 21);
            this.doornamesCbo.TabIndex = 0;
            this.doornamesCbo.SelectedIndexChanged += new System.EventHandler(this.doornamesCbo_SelectedIndexChanged);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReport.Location = new System.Drawing.Point(675, 425);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(130, 26);
            this.btnViewReport.TabIndex = 16;
            this.btnViewReport.Text = "View Rerport";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtrefreshrate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(678, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 59);
            this.panel4.TabIndex = 15;
            // 
            // txtrefreshrate
            // 
            this.txtrefreshrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrefreshrate.Location = new System.Drawing.Point(23, 25);
            this.txtrefreshrate.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtrefreshrate.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtrefreshrate.Name = "txtrefreshrate";
            this.txtrefreshrate.Size = new System.Drawing.Size(67, 21);
            this.txtrefreshrate.TabIndex = 5;
            this.txtrefreshrate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Refresh rate";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ms";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(683, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Stop Auto Refresh";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(683, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 59);
            this.panel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Show Only";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(18, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 21);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Row";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(694, 318);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "All Rows";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(694, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 51);
            this.panel2.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Ascending";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Descending";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Location = new System.Drawing.Point(694, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 83);
            this.panel1.TabIndex = 10;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Action Time";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 37);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "User Name";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(8, 60);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 17);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.Text = "Door Name";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order By";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(663, 353);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DisplayDetails);
            // 
            // CMD_Refresh
            // 
            this.CMD_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CMD_Refresh.Location = new System.Drawing.Point(675, 396);
            this.CMD_Refresh.Name = "CMD_Refresh";
            this.CMD_Refresh.Size = new System.Drawing.Size(130, 26);
            this.CMD_Refresh.TabIndex = 1;
            this.CMD_Refresh.Text = "Reload Data";
            this.CMD_Refresh.UseVisualStyleBackColor = true;
            this.CMD_Refresh.Click += new System.EventHandler(this.CMD_Refresh_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(827, 24);
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
            this.serverToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Image = global::SmartDoor.Properties.Resources.play;
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(194, 22);
            this.ConnectBTN.Text = "Connect Server";
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // ConnectToDB
            // 
            this.ConnectToDB.Image = ((System.Drawing.Image)(resources.GetObject("ConnectToDB.Image")));
            this.ConnectToDB.Name = "ConnectToDB";
            this.ConnectToDB.Size = new System.Drawing.Size(194, 22);
            this.ConnectToDB.Text = "Connect To Database";
            this.ConnectToDB.Click += new System.EventHandler(this.ConnectToDB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // CMD_Restart
            // 
            this.CMD_Restart.Name = "CMD_Restart";
            this.CMD_Restart.Size = new System.Drawing.Size(194, 22);
            this.CMD_Restart.Text = "Restart Server";
            this.CMD_Restart.Click += new System.EventHandler(this.CMD_Restart_Click);
            // 
            // ExitMBTN
            // 
            this.ExitMBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExitMBTN.Image")));
            this.ExitMBTN.Name = "ExitMBTN";
            this.ExitMBTN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMBTN.Size = new System.Drawing.Size(194, 22);
            this.ExitMBTN.Text = "Exit";
            this.ExitMBTN.Click += new System.EventHandler(this.ExitMBTN_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMD_Setting,
            this.adminstrationToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
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
            this.viewProfileToolStripMenuItem});
            this.adminstrationToolStripMenuItem.Name = "adminstrationToolStripMenuItem";
            this.adminstrationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.adminstrationToolStripMenuItem.Text = "Adminstration";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.viewProfileToolStripMenuItem.Text = "View My Profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutSmartDoorProjectToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
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
            this.helpTopicsToolStripMenuItem.Click += new System.EventHandler(this.helpTopicsToolStripMenuItem_Click);
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
            this.Quality,
            this.toolStripStatusLabel8,
            this.btnIncQuality,
            this.btnDecQuality,
            this.toolStripStatusLabel4,
            this.ResponseSZ});
            this.ServerStatus.Location = new System.Drawing.Point(0, 530);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(827, 24);
            this.ServerStatus.TabIndex = 7;
            this.ServerStatus.Text = "statusStrip1";
            this.ServerStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.ServerStatus_Paint);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 19);
            this.toolStripStatusLabel1.Text = "Sever Status:";
            // 
            // networkStatus
            // 
            this.networkStatus.BackColor = System.Drawing.Color.Transparent;
            this.networkStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkStatus.ForeColor = System.Drawing.Color.Red;
            this.networkStatus.Image = global::SmartDoor.Properties.Resources.smallfail;
            this.networkStatus.Name = "networkStatus";
            this.networkStatus.Size = new System.Drawing.Size(59, 19);
            this.networkStatus.Text = "Offline";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(10, 19);
            this.toolStripStatusLabel6.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 19);
            this.toolStripStatusLabel2.Text = "Database Status:";
            // 
            // dbStatus
            // 
            this.dbStatus.BackColor = System.Drawing.Color.Transparent;
            this.dbStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbStatus.ForeColor = System.Drawing.Color.Red;
            this.dbStatus.Image = global::SmartDoor.Properties.Resources.smallfail;
            this.dbStatus.Name = "dbStatus";
            this.dbStatus.Size = new System.Drawing.Size(177, 19);
            this.dbStatus.Text = "Not Connected to Database";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 19);
            this.toolStripStatusLabel7.Text = " ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(75, 19);
            this.toolStripStatusLabel5.Text = "Doors Online :";
            // 
            // ClientCountLBL
            // 
            this.ClientCountLBL.BackColor = System.Drawing.Color.Transparent;
            this.ClientCountLBL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ClientCountLBL.ForeColor = System.Drawing.Color.Blue;
            this.ClientCountLBL.Name = "ClientCountLBL";
            this.ClientCountLBL.Size = new System.Drawing.Size(14, 19);
            this.ClientCountLBL.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(74, 19);
            this.toolStripStatusLabel3.Text = "Image Quality";
            // 
            // Quality
            // 
            this.Quality.BackColor = System.Drawing.Color.Transparent;
            this.Quality.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(34, 19);
            this.Quality.Text = "25%";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(10, 19);
            this.toolStripStatusLabel8.Text = " ";
            // 
            // btnIncQuality
            // 
            this.btnIncQuality.BackColor = System.Drawing.Color.Transparent;
            this.btnIncQuality.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncQuality.Name = "btnIncQuality";
            this.btnIncQuality.Size = new System.Drawing.Size(16, 19);
            this.btnIncQuality.Text = "+";
            this.btnIncQuality.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIncQuality_MouseDown);
            this.btnIncQuality.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIncQuality_MouseDown);
            this.btnIncQuality.Click += new System.EventHandler(this.btnIncQuality_Click);
            // 
            // btnDecQuality
            // 
            this.btnDecQuality.BackColor = System.Drawing.Color.Transparent;
            this.btnDecQuality.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDecQuality.Name = "btnDecQuality";
            this.btnDecQuality.Size = new System.Drawing.Size(16, 19);
            this.btnDecQuality.Text = "-";
            this.btnDecQuality.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDecQuality_MouseDown);
            this.btnDecQuality.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDecQuality_MouseDown);
            this.btnDecQuality.Click += new System.EventHandler(this.btnDecQuality_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(103, 19);
            this.toolStripStatusLabel4.Text = "Last Response Size:";
            // 
            // ResponseSZ
            // 
            this.ResponseSZ.BackColor = System.Drawing.Color.Transparent;
            this.ResponseSZ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseSZ.Name = "ResponseSZ";
            this.ResponseSZ.Size = new System.Drawing.Size(0, 19);
            // 
            // ServerFRM
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(827, 554);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(679, 581);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrefreshrate)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem CMD_Setting;
        private ToolStripMenuItem CMD_Monitor;
        private ImageList imageList;
        private ToolStripMenuItem CMD_Restart;
        private ToolStripMenuItem CMD_openDoor;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem CMD_Restart_Remote_App;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel Quality;
        private ToolStripMenuItem adminstrationToolStripMenuItem;
        private ToolStripMenuItem viewProfileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem CMD_Proprities;
        private TabPage tabPage3;
        private Button CMD_Refresh;
        private DataGridView dataGridView1;
        private Label label1;
        private NumericUpDown txtrefreshrate;
        private Label label2;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private CheckBox checkBox1;
        private Panel panel3;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripStatusLabel btnIncQuality;
        private ToolStripStatusLabel btnDecQuality;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel ResponseSZ;
        private CheckBox checkBox2;
        private Panel panel4;
        private Button btnViewReport;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private Label label6;
        private ComboBox doornamesCbo;
        private Label label7;
        private ComboBox usernamesCbo;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private ComboBox statusCbo;
    }
}
