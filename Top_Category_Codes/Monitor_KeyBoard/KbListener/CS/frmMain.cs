using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace KbListener
{
	public partial class Form1 : System.Windows.Forms.Form
	{
        static void Main(string[] args)
        {
            Application.Run(new Form1());
        }
		
		#region " Windows Form Designer generated code "
		
		public Form1()
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
		internal System.Windows.Forms.Button btnListen;
		internal System.Windows.Forms.Button btnStop;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.btnListen = new System.Windows.Forms.Button();
			this.btnListen.Click += new System.EventHandler(btnListen_Click);
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStop.Click += new System.EventHandler(btnStop_Click);
			this.SuspendLayout();
			//
			//btnListen
			//
			this.btnListen.Location = new System.Drawing.Point(8, 8);
			this.btnListen.Name = "btnListen";
			this.btnListen.Size = new System.Drawing.Size(112, 120);
			this.btnListen.TabIndex = 0;
			this.btnListen.Text = "Click on this button to start listening to the keyboard events. If Escape key is " + "pressed anywhere a message box will come up...";
			//
			//btnStop
			//
			this.btnStop.Location = new System.Drawing.Point(128, 8);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(112, 120);
			this.btnStop.TabIndex = 0;
			this.btnStop.Text = "Click on this button to stop  listening ...";
			//
			//Form1
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(250, 136);
			this.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnListen, this.btnStop });
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Keyboard Listener";
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		cKBHook obj = new cKBHook();
		
		private void obj_KeyPressed(int KeyChar)
		{
			if ((Keys)KeyChar == Keys.Escape)
			{
				MessageBox.Show("Escape key pressed: "+(Keys)KeyChar);
			}
		}
		
		private void btnListen_Click(System.Object sender, System.EventArgs e)
		{
			obj.Listen();
            obj.KeyPressed += new cKBHook.KeyPressedEventHandler(obj_KeyPressed);
		}
		
		private void btnStop_Click(System.Object sender, System.EventArgs e)
		{
			obj.StopListening();
		}
	}
	
}
