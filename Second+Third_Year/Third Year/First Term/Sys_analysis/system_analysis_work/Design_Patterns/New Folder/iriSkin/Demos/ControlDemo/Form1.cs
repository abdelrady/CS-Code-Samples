using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace ControlDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ContextMenu contextMenu2;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolBar toolBar1;
		private Sunisoft.IrisSkin.SkinEngine skinEngine1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button9;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem1;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem2;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem3;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem4;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem5;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			InitializeComponent();

			textBox2.Text = 
@"IrisSkin(WinForms) is the easiest-to-use skin component for .NET. 
It provides you the ability to make skin-supported application automatically. 
You will never spend many time on programming skin supports.

Using IrisSkin, you don't need make any modification for your existing projects 
just drop the skin engine component onto the main form and set some 
properties, that's all. It can skin all forms in one application automatically. 
And the skin files can be compiled into the EXE file so that you 
don't need distribute the skin files with the EXE. At run-time, you can switch the 
skins very easily and you can switch to unskinned easily too.

The skins are mostly designed by our UI artists. That's means, 
you can use the professional -UI-designed skins we provided with IrisSkin now. 
Please note, we not only provide the UI controls, but also UI design!

Key features:
* Easiest to use - One component for one application only
* Fully automatic - Skins all .NET forms automatically
* Professional-UI-designed skins from professional UI artists
* Make your existing project with skin easily
* Switch from skin to unskin easily
* Supports one or more skin files to be built-into the EXE file
* Provides SkinBuilder tool
* Fully MDI supported
";
			String str = Application.StartupPath;
			button7_Click(this, null);

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.button6 = new System.Windows.Forms.Button();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button5 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.contextMenu2 = new System.Windows.Forms.ContextMenu();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
			this.skinCollectionItem1 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem2 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem3 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem4 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem5 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3,
																					  this.menuItem8});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "&File";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.F12;
			this.menuItem2.Text = "E&xit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7});
			this.menuItem3.Text = "&Online";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "&Order IrisSkin";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "&Product Page";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "&Sunisoft homepage";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem9,
																					  this.menuItem19,
																					  this.menuItem18});
			this.menuItem8.Text = "&Help";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.menuItem9.Text = "&IrisSkin Help";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 1;
			this.menuItem19.Text = "-";
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 2;
			this.menuItem18.Text = "&About";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2,
																					  this.tabPage3,
																					  this.tabPage4});
			this.tabControl1.ItemSize = new System.Drawing.Size(110, 22);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(552, 224);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button4,
																				   this.checkBox5,
																				   this.button6,
																				   this.checkBox3,
																				   this.checkBox4,
																				   this.radioButton6,
																				   this.checkBox2,
																				   this.checkBox1,
																				   this.radioButton1,
																				   this.button5,
																				   this.button3,
																				   this.button2,
																				   this.button1});
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(544, 194);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Normal controls1";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(8, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(216, 28);
			this.button4.TabIndex = 3;
			this.button4.Text = "Switch to main \'built in\' skin";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(256, 152);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(280, 24);
			this.checkBox5.TabIndex = 12;
			this.checkBox5.Text = "More professional skin implementation";
			// 
			// button6
			// 
			this.button6.Image = ((System.Drawing.Bitmap)(resources.GetObject("button6.Image")));
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.ImageIndex = 1;
			this.button6.ImageList = this.imageList2;
			this.button6.Location = new System.Drawing.Point(8, 152);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 28);
			this.button6.TabIndex = 5;
			this.button6.Text = "  &Help";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(18, 18);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Olive;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(256, 128);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(280, 24);
			this.checkBox3.TabIndex = 11;
			this.checkBox3.Text = "60+ components";
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(256, 104);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(280, 24);
			this.checkBox4.TabIndex = 10;
			this.checkBox4.Text = "What you see is what you get";
			// 
			// radioButton6
			// 
			this.radioButton6.Location = new System.Drawing.Point(232, 80);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.TabIndex = 9;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "SUIPack";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(256, 56);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(280, 24);
			this.checkBox2.TabIndex = 8;
			this.checkBox2.Text = "Make your existing project in skin easily";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(256, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(280, 24);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Easiest to use";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(232, 8);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 6;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "SUIskin";
			// 
			// button5
			// 
			this.button5.Image = ((System.Drawing.Bitmap)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.ImageIndex = 0;
			this.button5.ImageList = this.imageList2;
			this.button5.Location = new System.Drawing.Point(8, 120);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 28);
			this.button5.TabIndex = 4;
			this.button5.Text = "  &All";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 48);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(216, 28);
			this.button3.TabIndex = 2;
			this.button3.Text = "Switch to other \'built in\' skin";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.ContextMenu = this.contextMenu2;
			this.button2.Location = new System.Drawing.Point(120, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 28);
			this.button2.TabIndex = 1;
			this.button2.Text = "Remove skin";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// contextMenu2
			// 
			this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem14,
																						 this.menuItem15,
																						 this.menuItem16,
																						 this.menuItem17});
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.Text = "dfsfsdf";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Text = "dfsdfsd";
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 2;
			this.menuItem16.Text = "fdsfdsfsd";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 3;
			this.menuItem17.Text = "fdssss";
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "Load skin...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.textBox2,
																				   this.progressBar1,
																				   this.trackBar1});
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(544, 194);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Normal controls2";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(16, 8);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(520, 88);
			this.textBox2.TabIndex = 16;
			this.textBox2.Text = "textBox2";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(16, 152);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(512, 28);
			this.progressBar1.TabIndex = 15;
			this.progressBar1.Value = 50;
			// 
			// trackBar1
			// 
			this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
			this.trackBar1.LargeChange = 2;
			this.trackBar1.Location = new System.Drawing.Point(16, 104);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(520, 45);
			this.trackBar1.SmallChange = 2;
			this.trackBar1.TabIndex = 14;
			this.trackBar1.Tag = "";
			this.trackBar1.TickFrequency = 4;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 50;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.comboBox1,
																				   this.listBox1,
																				   this.textBox1,
																				   this.button8,
																				   this.button7,
																				   this.groupBox1});
			this.tabPage3.Location = new System.Drawing.Point(4, 26);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(544, 194);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Normal controls3";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "ComboBoxItem1",
														   "ComboBoxItem2",
														   "ComboBoxItem3",
														   "ComboBoxItem4",
														   "ComboBoxItem5",
														   "ComboBoxItem6",
														   "ComboBoxItem7",
														   "ComboBoxItem8",
														   "ComboBoxItem9",
														   "ComboBoxItem10",
														   "ComboBoxItem11",
														   "ComboBoxItem12",
														   "ComboBoxItem13",
														   "ComboBoxItem14"});
			this.comboBox1.Location = new System.Drawing.Point(320, 160);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(124, 20);
			this.comboBox1.TabIndex = 21;
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Items.AddRange(new object[] {
														  "ListBoxItem1",
														  "ListBoxItem2",
														  "ListBoxItem3",
														  "ListBoxItem4",
														  "ListBoxItem5",
														  "ListBoxItem6",
														  "ListBoxItem7",
														  "ListBoxItem8",
														  "ListBoxItem9",
														  "ListBoxItem10",
														  "ListBoxItem11",
														  "ListBoxItem12",
														  "ListBoxItem13",
														  "ListBoxItem14"});
			this.listBox1.Location = new System.Drawing.Point(320, 48);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(124, 100);
			this.listBox1.TabIndex = 20;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(320, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(124, 21);
			this.textBox1.TabIndex = 19;
			this.textBox1.Text = "textBox1";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(200, 96);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(112, 32);
			this.button8.TabIndex = 18;
			this.button8.Text = "Remove an item";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(200, 56);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(112, 32);
			this.button7.TabIndex = 17;
			this.button7.Text = "Add an item";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButton4,
																					this.radioButton5,
																					this.radioButton3,
																					this.radioButton2});
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 176);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(16, 116);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(148, 24);
			this.radioButton4.TabIndex = 54;
			this.radioButton4.Text = "radioButton";
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(16, 88);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(148, 24);
			this.radioButton5.TabIndex = 53;
			this.radioButton5.Text = "radioButton";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(16, 60);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(148, 24);
			this.radioButton3.TabIndex = 52;
			this.radioButton3.Text = "radioButton";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(16, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(148, 24);
			this.radioButton2.TabIndex = 51;
			this.radioButton2.Text = "radioButton";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button9,
																				   this.button15,
																				   this.button14});
			this.tabPage4.Location = new System.Drawing.Point(4, 26);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(544, 194);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Dialog & other forms";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(16, 56);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(140, 28);
			this.button9.TabIndex = 24;
			this.button9.Text = "MessageBox";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(184, 16);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(140, 28);
			this.button15.TabIndex = 23;
			this.button15.Text = "Show modal form";
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(16, 16);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(140, 28);
			this.button14.TabIndex = 22;
			this.button14.Text = "Show form";
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem10,
																						 this.menuItem11,
																						 this.menuItem12,
																						 this.menuItem13});
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "Context Menu Item&1";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.Text = "Context Menu Item&2";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.Text = "-";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 3;
			this.menuItem13.Text = "Context Menu Item&3";
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.tabControl1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(568, 243);
			this.panel1.TabIndex = 1;
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(568, 33);
			this.toolBar1.TabIndex = 2;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.ToolTipText = "Load skin";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 1;
			this.toolBarButton3.ToolTipText = "Switch to other \'built in\' skin";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 2;
			this.toolBarButton5.ToolTipText = "Order";
			// 
			// skinEngine1
			// 
			this.skinEngine1.Active = true;
			this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem1);
			this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem2);
			this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem3);
			this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem4);
			this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem5);
			this.skinEngine1.SerialNumber = "";
			this.skinEngine1.SkinFile = "D:\\Debug\\Skins\\Midsummer.ssk";
			this.skinEngine1.SkinPassword = null;
			this.skinEngine1.SkinStream = null;
			this.skinEngine1.SkinStreamMain = ((System.IO.MemoryStream)(resources.GetObject("skinEngine1.SkinStreamMain")));
			// 
			// skinCollectionItem1
			// 
			this.skinCollectionItem1.SkinPassword = null;
			this.skinCollectionItem1.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem1.SkinSteam")));
			// 
			// skinCollectionItem2
			// 
			this.skinCollectionItem2.SkinPassword = null;
			this.skinCollectionItem2.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem2.SkinSteam")));
			// 
			// skinCollectionItem3
			// 
			this.skinCollectionItem3.SkinPassword = null;
			this.skinCollectionItem3.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem3.SkinSteam")));
			// 
			// skinCollectionItem4
			// 
			this.skinCollectionItem4.SkinPassword = null;
			this.skinCollectionItem4.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem4.SkinSteam")));
			// 
			// skinCollectionItem5
			// 
			this.skinCollectionItem5.SkinPassword = null;
			this.skinCollectionItem5.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem5.SkinSteam")));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(568, 276);
			this.ContextMenu = this.contextMenu1;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.toolBar1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Tag = "";
			this.Text = "ControlDemo";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button14_Click(object sender, System.EventArgs e)
		{
			Form2 fm = new Form2();
			fm.Show();
		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			Form2 fm = new Form2();
			fm.ShowDialog();
		}


		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenu1.Show(this, new Point(e.X, e.Y));
			}
		}

		private int current;
		private void button3_Click(object sender, System.EventArgs e)
		{
			if (skinEngine1.AddtionalBuiltInSkins.Count - 1 > current)
				current ++;
			else
				current = 0;

			skinEngine1.ApplyAdditionalBuiltInSkins(current);
			if (! skinEngine1.Active)
				skinEngine1.Active = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Sunisoft skin file (ssk file) | *.ssk";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				skinEngine1.SkinFile = dialog.FileName;
				if (! skinEngine1.Active)
					skinEngine1.Active = true;
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			RadioButton btn = new RadioButton();
			btn.Text = "radioButton";
			groupBox1.Controls.Add(btn);
			Control control;
			for (int i = 0; i < groupBox1.Controls.Count; i ++)
			{
				control = groupBox1.Controls [i];
				control.Location = new Point(groupBox1.Left + 10, 
					i * (groupBox1.Height - 10) / groupBox1.Controls.Count + 10);
			}
		}
		private void button8_Click(object sender, System.EventArgs e)
		{
			if (groupBox1.Controls.Count > 0)
				groupBox1.Controls.Remove(groupBox1.Controls [0]);

			Control control;
			for (int i = 0; i < groupBox1.Controls.Count; i ++)
			{
				control = groupBox1.Controls [i];
				control.Location = new Point(groupBox1.Left + 10, 
					i * (groupBox1.Height - 10) / groupBox1.Controls.Count + 10);
			}
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
			progressBar1.Value = trackBar1.Value;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			skinEngine1.Active = false;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("IEXPLORE.EXE","http://www.sunisoft.com/irisskin/buy.htm");
			}
			catch {}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("IEXPLORE.EXE","http://www.sunisoft.com/irisskin/");
			}
			catch {}
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("IEXPLORE.EXE","http://www.sunisoft.com");
			}
			catch {}
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("IrisSkin.chm");
			}
			catch {}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			if (! checkBox1.Checked)
			{
				checkBox1.Checked = true;
				checkBox2.Checked = true;
				checkBox3.Checked = true;
				checkBox4.Checked = true;
				checkBox5.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
				checkBox2.Checked = false;
				checkBox3.Checked = false;
				checkBox4.Checked = false;
				checkBox5.Checked = false;
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("IrisSkin.chm");
			}
			catch {}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			skinEngine1.ApplyMainBuiltInSkin();
			if (! skinEngine1.Active)
				skinEngine1.Active = true;
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button == toolBarButton1)
				button1_Click(this, null);
			if (e.Button == toolBarButton3)
				button3_Click(this, null);
			if (e.Button == toolBarButton5)
				menuItem4_Click(this, null);
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			Form3 fm = new Form3();
			fm.Top = this.Top + 50;
			fm.Left = this.Left + 40;
			fm.Width = 496;
			fm.Height = 304;
			fm.Show();
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Thanks for uing IrisSkin product!", "IrisSkin");
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.ShowDialog();
		}

		private void button10_Click_1(object sender, System.EventArgs e)
		{
			MessageBox.Show("OK");
		}

	}
}
