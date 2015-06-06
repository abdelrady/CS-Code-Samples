using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using SpeechLib;

namespace WindowsApplication1
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
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.MenuItem menuItem37;
		private System.Windows.Forms.MenuItem menuItem38;
		private System.Windows.Forms.MenuItem menuItem39;
		public System.Windows.Forms.ImageList imageList1;
		public System.Windows.Forms.ImageList imageList2;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem38 = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.menuItem36 = new System.Windows.Forms.MenuItem();
            this.menuItem28 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.menuItem37 = new System.Windows.Forms.MenuItem();
            this.menuItem31 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6,
            this.menuItem13,
            this.menuItem21,
            this.menuItem17});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MdiList = true;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem2,
            this.menuItem4,
            this.menuItem9,
            this.menuItem5});
            this.menuItem1.Text = "File";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItem3.Text = "New";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItem2.Text = "Open";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItem4.Text = "Save";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItem9.Text = "Print";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItem5.Text = "Close";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.menuItem10,
            this.menuItem18,
            this.menuItem12,
            this.menuItem19,
            this.menuItem20});
            this.menuItem6.Text = "Edit";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.menuItem7.Text = "Undo";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItem8.Text = "Redo";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.menuItem10.Text = "Font ";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 3;
            this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11});
            this.menuItem18.Text = "Insert";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Image From File";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 4;
            this.menuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItem12.Text = "Copy";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 5;
            this.menuItem19.Text = "Cut";
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 6;
            this.menuItem20.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuItem20.Text = "Paste";
            this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem14,
            this.menuItem15,
            this.menuItem16});
            this.menuItem13.Text = "Position";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 0;
            this.menuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR;
            this.menuItem14.Text = "Right";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
            this.menuItem15.Text = "Center";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 2;
            this.menuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftL;
            this.menuItem16.Text = "Left";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 3;
            this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem27,
            this.menuItem22,
            this.menuItem28,
            this.menuItem31});
            this.menuItem21.Text = "Speak";
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 0;
            this.menuItem27.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem38,
            this.menuItem39});
            this.menuItem27.Text = "Text";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // menuItem38
            // 
            this.menuItem38.Index = 0;
            this.menuItem38.Text = "All The Text";
            this.menuItem38.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // menuItem39
            // 
            this.menuItem39.Index = 1;
            this.menuItem39.Text = "Selected Text";
            this.menuItem39.Click += new System.EventHandler(this.menuItem39_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 1;
            this.menuItem22.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem23,
            this.menuItem24,
            this.menuItem25,
            this.menuItem26,
            this.menuItem35,
            this.menuItem36});
            this.menuItem22.Text = "Rate";
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 0;
            this.menuItem23.Text = "0";
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 1;
            this.menuItem24.Text = "1";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 2;
            this.menuItem25.Text = "2";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 3;
            this.menuItem26.Text = "3";
            this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 4;
            this.menuItem35.Text = "4";
            this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
            // 
            // menuItem36
            // 
            this.menuItem36.Index = 5;
            this.menuItem36.Text = "5";
            this.menuItem36.Click += new System.EventHandler(this.menuItem36_Click);
            // 
            // menuItem28
            // 
            this.menuItem28.Index = 2;
            this.menuItem28.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem29,
            this.menuItem30,
            this.menuItem37});
            this.menuItem28.Text = "Voice";
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 0;
            this.menuItem29.Text = "Mary";
            this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 1;
            this.menuItem30.Text = "Mike";
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem37
            // 
            this.menuItem37.Index = 2;
            this.menuItem37.Text = "Sam";
            this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItem31
            // 
            this.menuItem31.Index = 3;
            this.menuItem31.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem32,
            this.menuItem33,
            this.menuItem34});
            this.menuItem31.Text = "Volume";
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 0;
            this.menuItem32.Text = "100";
            this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 1;
            this.menuItem33.Text = "50";
            this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 2;
            this.menuItem34.Text = "10";
            this.menuItem34.Click += new System.EventHandler(this.menuItem34_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 4;
            this.menuItem17.Text = "About";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // toolBar1
            // 
            this.toolBar1.AutoSize = false;
            this.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton5,
            this.toolBarButton6});
            this.toolBar1.ButtonSize = new System.Drawing.Size(30, 30);
            this.toolBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolBar1.ImageList = this.imageList2;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(518, 43);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.ToolTipText = "New";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.ToolTipText = "Save";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.ToolTipText = "Copy";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.ToolTipText = "Cut";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 4;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.ToolTipText = "Paste";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 5;
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.ToolTipText = "Font";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(518, 316);
            this.Controls.Add(this.toolBar1);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
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

		 
		private void menuItem3_Click(object sender, System.EventArgs e)
        {
		    TextArea ta=new TextArea();
			ta.MdiParent=this;
			ta.Show();
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				ta.RightAlignment();
			}

			catch
			{
				MessageBox.Show("Please Make a new file or Open an existing one first","Error");
			}
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				ta.CenterAlignment();
			}

			catch
			{
				MessageBox.Show("Please Make a new file or Open an existing one first","Error");
			}
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				ta.LeftAlignment();
			}

			catch
			{
				MessageBox.Show("Please Make a new file or Open an existing one first","Error");
			}
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{			
				ta.UndoCmd();
			}

			catch
			{
				MessageBox.Show("Please Make a new file or Open an existing one first","Error");
			}
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				ta.RedoCmd();
			}

			catch
			{
				MessageBox.Show("Please Make a new file or Open an existing one first","Error");
			}
		
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;

			if(ta != null)
			{
                  fontDialog1.Font=ta.richTextBox1.Font;
			}
			if(fontDialog1.ShowDialog()==DialogResult.OK)
			{
				Color sc=fontDialog1.Color;
                Font fo=fontDialog1.Font;
				try
				{
                     ta.TextColor(sc);
					 ta.FontChange(fo);
				}
				catch
				{
					MessageBox.Show("Please Make a new file or Open an existing one first","Error");
				}
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			TextArea ta=new TextArea();	
			openFileDialog1.Filter="Text files (*.txt)|*.txt|Word files (*.doc)|*.doc";

			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				string FileName=openFileDialog1.FileName;
				if(FileName != "")
				{
					StreamReader sr=new StreamReader(FileName);
					ta.richTextBox1.Text=sr.ReadToEnd();
					ta.MdiParent=this;
					ta.Show();
				}
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
            
			saveFileDialog1.Filter="Text files (*.txt)|*.txt|Word files (*.doc)|*.doc";
			if(saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				try
				{
					ta.richTextBox1.SaveFile(saveFileDialog1.InitialDirectory+saveFileDialog1.FileName);
				}
				catch
				{
					MessageBox.Show("Failed to save the file","Error");
				}
		  }		
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			foreach(TextArea ta in this.MdiChildren)
			ta.Close();
			this.Close();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			if(ta != null)
			{
				if(printDialog1.ShowDialog()==DialogResult.OK)
				{
					printDocument1.Print();
				}
			}

			else
				MessageBox.Show("No Content To Print");
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				string text = ta.richTextBox1.Text;
				System.Drawing.Font printFont = ta.richTextBox1.Font;

				e.Graphics.DrawString(text, printFont, 
					System.Drawing.Brushes.Black, 10, 10);
			}

			catch
			{
                 MessageBox.Show("Printing File Failed","Error");
			}

		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			if(ta != null)
			{
				openFileDialog2.Filter="GIF files (*.gif)|*.gif|Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
				
				if(openFileDialog2.ShowDialog()==DialogResult.OK)
				{
					Image a=new Bitmap(openFileDialog2.FileName);
					try
					{
                     Clipboard.SetDataObject(a);
						Panel p=new Panel();
						p.BackgroundImage=a;
                        p.Width=a.Width/2;
						p.Height=a.Height/2;
						p.Top=ta.richTextBox1.TextLength;
						p.Left=ta.richTextBox1.TextLength;
						p.Select();
						p.Cursor=Cursors.Hand;
						p.BorderStyle=BorderStyle.FixedSingle;
						p.MouseMove+=new MouseEventHandler(p_MouseMove);
						p.MouseUp+=new MouseEventHandler(p_MouseUp);
						p.MouseDown+=new MouseEventHandler(p_MouseDown);
					    ta.richTextBox1.Controls.Add(p);
					}

					catch
					{
					}
				}
			}
		}

		private void p_MouseMove(object sender, MouseEventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;

			Panel p=(Panel)ta.richTextBox1.GetNextControl(new Panel(),false);
				
					if(mouseDown==true)
					{
						MouseNewPos=Control.MousePosition;            
						formNewPos.X=MouseNewPos.X-MouseCurrrnetPos.X+formPos.X;
						formNewPos.Y=MouseNewPos.Y-MouseCurrrnetPos.Y+formPos.Y;
						p.Location=formNewPos;
						formPos=formNewPos;
						MouseCurrrnetPos=MouseNewPos;
					}
				
		}

		Point MouseCurrrnetPos,MouseNewPos,formPos,formNewPos;

		bool mouseDown=false;
		private void p_MouseUp(object sender, MouseEventArgs e)
		{
				if(e.Button==MouseButtons.Left)
			 mouseDown=false;
		}

		private void p_MouseDown(object sender, MouseEventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;

            Panel p=(Panel)ta.richTextBox1.GetNextControl(new Panel(),false);
			if(e.Button==MouseButtons.Left)
			{	
						mouseDown = true;
						MouseCurrrnetPos = Control.MousePosition;
						formPos =p.Location;	
			}			
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Simple Text Editor Program\nby : Muneer Essa","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				ta.richTextBox1.Copy();
			}
			catch
			{
				MessageBox.Show("Nothing To Copy","Error");
			}
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				ta.richTextBox1.Cut();
			}
			catch
			{
				MessageBox.Show("Nothing To Cut","Error");
			}
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			try
			{
				ta.richTextBox1.Paste();
			}
			catch
			{
				MessageBox.Show("Nothing To Paste\nClipboard Is Empty","Error");
			}
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button.ImageIndex==0)
				menuItem3_Click(sender,null);
			else
				if(e.Button.ImageIndex==1)
				menuItem4_Click(sender,null);              
			else
				if(e.Button.ImageIndex==2)
				menuItem12_Click(sender,null);			
			else
				if(e.Button.ImageIndex==3)
				menuItem19_Click(sender,null);			
			else
				if(e.Button.ImageIndex==4)
				menuItem20_Click(sender,null);			
			else
				if(e.Button.ImageIndex==5)
				menuItem10_Click(sender,null);
		}

		string voice="name=Microsoft Sam";
		int volume=50;
		int rate=3;

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			rate=0;
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			rate=1;
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			rate=2;
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			rate=3;
		}

		private void menuItem35_Click(object sender, System.EventArgs e)
		{
			rate=4;
		}

		private void menuItem36_Click(object sender, System.EventArgs e)
		{
			rate=5;
		}

		private void menuItem29_Click(object sender, System.EventArgs e)
		{
			voice="name=Microsoft Mary";
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			voice="name=Microsoft Mike";
		}

		private void menuItem37_Click(object sender, System.EventArgs e)
		{
		    voice="name=Microsoft Sam";
		}

		private void menuItem32_Click(object sender, System.EventArgs e)
		{
			volume=100;
		}

		private void menuItem33_Click(object sender, System.EventArgs e)
		{
			volume=50;
		}

		private void menuItem34_Click(object sender, System.EventArgs e)
		{
			volume=10;
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
		}

		private void menuItem38_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			SpeechVoiceSpeakFlags SpFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
			SpVoice Vr = new SpVoice();			
			Vr.Rate=rate;
			Vr.Volume=volume;
			SpeechLib.SpObjectToken tok;
			tok=Vr.Voice;			
			Vr.Voice=Vr.GetVoices(voice,"").Item(0);
			try
			{
				Vr.Speak(ta.richTextBox1.Text, SpFlags);
			}
			catch
			{
				MessageBox.Show("Nothing To Read\nPlease Open A Document And Write Some Text First","Error");
			}
		}

		private void menuItem39_Click(object sender, System.EventArgs e)
		{
			TextArea ta;
			ta=(TextArea)this.ActiveMdiChild;
			SpeechVoiceSpeakFlags SpFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
			SpVoice Vr = new SpVoice();			
			Vr.Rate=rate;
			Vr.Volume=volume;
			SpeechLib.SpObjectToken tok;
			tok=Vr.Voice;			
			Vr.Voice=Vr.GetVoices(voice,"").Item(0);
			try
			{
				Vr.Speak(ta.richTextBox1.SelectedText, SpFlags);
			}
			catch
			{
				MessageBox.Show("Nothing To Read\nPlease Open A Document And Write Some Text First","Error");
			}
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			toolBar1.ImageList=imageList1;
			toolBar1.Invalidate(true);
			toolBar1.Refresh();
			toolBar1.Update();			
		}
	}
}