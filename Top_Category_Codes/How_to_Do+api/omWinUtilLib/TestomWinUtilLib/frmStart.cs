using System;
using System.Diagnostics;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using om.Win.Util.Lib;


namespace TestomWinUtilLib
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmStart : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Button btnDisClose;

		private WinDisplay pWinDisplay;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnActive;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.Button btnMax;
		private System.Windows.Forms.Button btnNor;
		private DisableClose pDisClose;

		public frmStart()
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
			this.btnHide = new System.Windows.Forms.Button();
			this.btnRestore = new System.Windows.Forms.Button();
			this.btnDisClose = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnActive = new System.Windows.Forms.Button();
			this.btnMin = new System.Windows.Forms.Button();
			this.btnMax = new System.Windows.Forms.Button();
			this.btnNor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnHide
			// 
			this.btnHide.Location = new System.Drawing.Point(16, 8);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(88, 24);
			this.btnHide.TabIndex = 0;
			this.btnHide.Text = "&Hide";
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Location = new System.Drawing.Point(16, 40);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(88, 24);
			this.btnRestore.TabIndex = 1;
			this.btnRestore.Text = "&Restore";
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// btnDisClose
			// 
			this.btnDisClose.Location = new System.Drawing.Point(216, 24);
			this.btnDisClose.Name = "btnDisClose";
			this.btnDisClose.Size = new System.Drawing.Size(88, 24);
			this.btnDisClose.TabIndex = 2;
			this.btnDisClose.Text = "Disable Close";
			this.btnDisClose.Click += new System.EventHandler(this.btnDisClose_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(200, 160);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(96, 24);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnActive
			// 
			this.btnActive.Location = new System.Drawing.Point(16, 72);
			this.btnActive.Name = "btnActive";
			this.btnActive.Size = new System.Drawing.Size(88, 24);
			this.btnActive.TabIndex = 4;
			this.btnActive.Text = "&Active";
			this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
			// 
			// btnMin
			// 
			this.btnMin.Location = new System.Drawing.Point(16, 104);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(88, 24);
			this.btnMin.TabIndex = 5;
			this.btnMin.Text = "Mi&nimized";
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// btnMax
			// 
			this.btnMax.Location = new System.Drawing.Point(16, 136);
			this.btnMax.Name = "btnMax";
			this.btnMax.Size = new System.Drawing.Size(88, 24);
			this.btnMax.TabIndex = 6;
			this.btnMax.Text = "&Maximized";
			this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
			// 
			// btnNor
			// 
			this.btnNor.Location = new System.Drawing.Point(16, 168);
			this.btnNor.Name = "btnNor";
			this.btnNor.Size = new System.Drawing.Size(88, 24);
			this.btnNor.TabIndex = 7;
			this.btnNor.Text = "&Normal";
			this.btnNor.Click += new System.EventHandler(this.btnNor_Click);
			// 
			// frmStart
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 197);
			this.Controls.Add(this.btnNor);
			this.Controls.Add(this.btnMax);
			this.Controls.Add(this.btnMin);
			this.Controls.Add(this.btnActive);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDisClose);
			this.Controls.Add(this.btnRestore);
			this.Controls.Add(this.btnHide);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "frmStart";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Windows Utility Test";
			this.Load += new System.EventHandler(this.frmStart_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmStart());
		}

		private void frmStart_Load(object sender, System.EventArgs e)
		{
			pWinDisplay = new WinDisplay("Calculator");
			pDisClose = new DisableClose();
		}

		private void btnHide_Click(object sender, System.EventArgs e)
		{
			pWinDisplay.onAction(WinDisplay.WinAct.Hide);
		}

		private void btnRestore_Click(object sender, System.EventArgs e)
		{
			pWinDisplay.onAction(WinDisplay.WinAct.Restore);
		}

		private void btnDisClose_Click(object sender, System.EventArgs e)
		{
			pDisClose.WindowName = "Calculator";
			pDisClose.disableClose();		
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void btnActive_Click(object sender, System.EventArgs e)
		{
			pWinDisplay.onAction(WinDisplay.WinAct.Active);
		}

		private void btnMin_Click(object sender, System.EventArgs e)
		{
			pWinDisplay.onAction(WinDisplay.WinAct.Minimized);
		}

		private void btnMax_Click(object sender, System.EventArgs e)
		{
			pWinDisplay.onAction(WinDisplay.WinAct.Maximized);
		}

		private void btnNor_Click(object sender, System.EventArgs e)
		{
			pWinDisplay.onAction(WinDisplay.WinAct.Normal);
			Process[] proc = Process.GetProcessesByName("MemTest","nameless");
			ProcessModuleCollection mod = proc[0].Modules;
			//ProcessModule[] pm = proc[0].MainModule.FileName

			Console.WriteLine(proc[0].ProcessName);
			foreach(ProcessModule oMod in mod)
			{
				Console.WriteLine(oMod.FileName);
				if(oMod.FileName == @"r:\dshaw\temp\memtest\memtest\bin\debug\iphelp.dll")
				{
					Console.WriteLine(oMod.ModuleMemorySize);
					MethodInfo[] myArrayMethodInfo = oMod.GetType().GetMethods(BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly);
					foreach(MethodInfo minfo in myArrayMethodInfo)
					{
						Console.WriteLine(minfo.Name);
						//minfo.GetType().(
						MethodInfo mi = minfo.GetType().GetMethod("get_ModuleName");
						if(mi!=null) mi.Invoke(minfo, null);
					}
					//Console.WriteLine( t.Length);
				}
			}
			
			Console.WriteLine( proc[0].Modules.Count);


			//object mi = proc[0].GetType().Assembly.EntryPoint.Name;


			//MethodInfo mi = proc[0].GetType().GetMethod("myVal");

			//object o =mi.Invoke(proc[0].CreateObjRef(proc[0].GetType()),null);
			
			/*foreach(MethodInfo mi in proc[0].GetType().GetMethods())
			{
				Console.WriteLine( mi.Name);
			}*/
			proc = null;

		}
	}
}
