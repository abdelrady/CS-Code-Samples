using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using System.Runtime.InteropServices;

namespace Memory
{
	public partial class frmMain : System.Windows.Forms.Form
	{
		
		#region " Windows Form Designer generated code "
		
		public frmMain()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.Button btnReduceMemory;
		internal System.Windows.Forms.Label lblInfo;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.btnReduceMemory = new System.Windows.Forms.Button();
			this.btnReduceMemory.Click += new System.EventHandler(btnReduceMemory_Click);
			this.lblInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//btnReduceMemory
			//
			this.btnReduceMemory.Location = new System.Drawing.Point(112, 8);
			this.btnReduceMemory.Name = "btnReduceMemory";
			this.btnReduceMemory.Size = new System.Drawing.Size(104, 23);
			this.btnReduceMemory.TabIndex = 0;
			this.btnReduceMemory.Text = "Reduce &Memory";
			//
			//lblInfo
			//
			this.lblInfo.Location = new System.Drawing.Point(8, 48);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(328, 48);
			this.lblInfo.TabIndex = 1;
			this.lblInfo.Text = "This program shows how to reduce the amount of used memory for one . NET program." + "  To start, see the used memory of the program and after that click the button a" + "nd check it out again.";
			//
			//frmMain
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 101);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.btnReduceMemory);
			this.Name = "frmMain";
			this.Text = " Main";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		[DllImport("kernel32.dll", ExactSpelling=true, CharSet=CharSet.Auto, SetLastError=true)]
		private static extern bool SetProcessWorkingSetSize(IntPtr procHandle, int min, int max);
		
		public void SetProcessWorkingSetSize()
		{
			try
			{
				Process Mem;
				Mem = Process.GetCurrentProcess();
				SetProcessWorkingSetSize(Mem.Handle, - 1, - 1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		private void btnReduceMemory_Click(System.Object sender, System.EventArgs e)
		{
			SetProcessWorkingSetSize();
			MessageBox.Show("See memory used now!");
		}
	}
	
}
