using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace MDIDemo
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
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private Sunisoft.IrisSkin.SkinEngine skinEngine1;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem1;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem2;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem3;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem4;
		private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();

			Form2 fm2 = new Form2();
			fm2.MdiParent = this;
			fm2.Show();

			Form3 fm3 = new Form3();
			fm3.MdiParent = this;
			fm3.Show();

			Form4 fm4 = new Form4();
			fm4.MdiParent = this;
			fm4.Show();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
			this.skinCollectionItem1 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem2 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem3 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem4 = new Sunisoft.IrisSkin.SkinCollectionItem();
			this.skinCollectionItem5 = new Sunisoft.IrisSkin.SkinCollectionItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4,
																					  this.menuItem6});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem12,
																					  this.menuItem13});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Tile";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "&Cascade";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.Text = "-";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 3;
			this.menuItem13.Text = "&Exit";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem4.Text = "F&orm";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "&Add";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem8,
																					  this.menuItem7,
																					  this.menuItem10});
			this.menuItem6.Text = "&Skin";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 0;
			this.menuItem8.Text = "&NextBuiltInSkin";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "&MainBuiltInSkin";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "&Load Skin ...";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
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
			this.skinEngine1.SkinFile = "D:\\Debug\\Skins\\Emerald.ssk";
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
			this.ClientSize = new System.Drawing.Size(496, 521);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";

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

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			index ++;
			if (index >= skinEngine1.AddtionalBuiltInSkins.Count)
				index = 0;
			skinEngine1.ApplyAdditionalBuiltInSkins(index);
			if (! skinEngine1.Active)
				skinEngine1.Active = true;
		}

		private int index = -1;

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Form4 fm = new Form4();
			fm.MdiParent = this;
			fm.Show();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			skinEngine1.ApplyMainBuiltInSkin();
			if (! skinEngine1.Active)
				skinEngine1.Active = true;
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
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

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
