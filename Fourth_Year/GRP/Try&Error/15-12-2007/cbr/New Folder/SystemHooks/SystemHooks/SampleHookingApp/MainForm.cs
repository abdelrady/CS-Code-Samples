// /////////////////////////////////////////////////////////////
// File: MainForm.cs		Class: Kennedy.SampleHookingApp.MainForm
// Date: 2/25/2004			Author: Michael Kennedy
// Language: C#				Framework: .NET
//
// Copyright: Copyright (c) Michael Kennedy, 2004-2005
// /////////////////////////////////////////////////////////////
// License: See License.txt file included with application.
// Description: See compiled documentation (Managed Hooks.chm)
// /////////////////////////////////////////////////////////////

#region using ...
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
#endregion

namespace Kennedy.ManagedHooks.SampleHookingApp
{
	public class MainForm : System.Windows.Forms.Form
	{
		#region Member Variables

		private System.Windows.Forms.Button buttonInstall;
		private System.Windows.Forms.Button buttonUninstall;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.TextBox textBoxMessages;
		private System.Windows.Forms.Button buttonAbout;
		
		#endregion

		// EXAMPLE CODE SECTION
		private Kennedy.ManagedHooks.MouseHook mouseHook = null;
        private Button ClearBTN;
		private Kennedy.ManagedHooks.KeyboardHook keyboardHook = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// Add any constructor code after InitializeComponent call
			//

			// EXAMPLE CODE SECTION

			mouseHook = new Kennedy.ManagedHooks.MouseHook();
			mouseHook.MouseEvent += new Kennedy.ManagedHooks.MouseHook.MouseEventHandler(mouseHook_MouseEvent);
		
			keyboardHook = new Kennedy.ManagedHooks.KeyboardHook();
			keyboardHook.KeyboardEvent += new Kennedy.ManagedHooks.KeyboardHook.KeyboardEventHandler(keyboardHook_KeyboardEvent);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				// EXAMPLE CODE SECTION
				if (mouseHook != null)
				{
					mouseHook.Dispose();
					mouseHook = null;
				}
				if (keyboardHook != null)
				{
					keyboardHook.Dispose();
					keyboardHook = null;
				}
			
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
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInstall.Location = new System.Drawing.Point(8, 8);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(268, 32);
            this.buttonInstall.TabIndex = 0;
            this.buttonInstall.Text = "&Install Mouse and Keyboard Hooks";
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUninstall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUninstall.Location = new System.Drawing.Point(8, 44);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(268, 32);
            this.buttonUninstall.TabIndex = 1;
            this.buttonUninstall.Text = "&Uninstall Mouse and Keyboard Hooks";
            this.buttonUninstall.Click += new System.EventHandler(this.buttonUninstall_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessages.BackColor = System.Drawing.Color.White;
            this.textBoxMessages.Location = new System.Drawing.Point(0, 84);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessages.Size = new System.Drawing.Size(348, 320);
            this.textBoxMessages.TabIndex = 2;
            this.textBoxMessages.TabStop = false;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 404);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(348, 22);
            this.statusBar1.TabIndex = 3;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAbout.Location = new System.Drawing.Point(280, 8);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(56, 34);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "&About";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearBTN.Location = new System.Drawing.Point(280, 44);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(56, 32);
            this.ClearBTN.TabIndex = 5;
            this.ClearBTN.Text = "&Clean";
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(348, 426);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonUninstall);
            this.Controls.Add(this.buttonInstall);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Hook Test Application";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Main Method
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			//
			// Give our app an XP theme look.
			//
			Application.EnableVisualStyles();
			Application.DoEvents();

			Application.Run(new MainForm());
		}

		#endregion

		private void buttonInstall_Click(object sender, System.EventArgs e)
		{
			// EXAMPLE CODE SECTION

			//AddText("Adding mouse hook.");
		//	mouseHook.InstallHook();

			AddText("Adding keyboard hook.");
			keyboardHook.InstallHook();

			buttonInstall.Enabled = false;
			buttonUninstall.Enabled = true;
		}

		private void buttonUninstall_Click(object sender, System.EventArgs e)
		{
			// EXAMPLE CODE SECTION

			//mouseHook.UninstallHook();
			//AddText("Mouse hook removed.");

			keyboardHook.UninstallHook();
			AddText("Keyboard hook removed.");

			buttonInstall.Enabled = true;
			buttonUninstall.Enabled = false;
		}

		// EXAMPLE CODE SECTION
		private void mouseHook_MouseEvent(Kennedy.ManagedHooks.MouseEvents mEvent, Point point)
		{
			string msg = string.Format("Mouse event: {0}: ({1},{2}).", mEvent.ToString(), point.X, point.Y);
			AddText(msg);
		}

		// EXAMPLE CODE SECTION
		private void keyboardHook_KeyboardEvent(Kennedy.ManagedHooks.KeyboardEvents kEvent, Keys key)
		{
			string msg = string.Format("Keyboard event: {0}: {1}.", kEvent.ToString(), Convert.ToInt16( key)-48);
			AddText(msg);
		}

		#region Utility Methods

		private void AddText(string message)
		{
			if (message == null)
			{
				return;
			}

			int length = textBoxMessages.Text.Length + message.Length;
			if (length >= textBoxMessages.MaxLength)
			{
				textBoxMessages.Text = "";
			}

			if (!message.EndsWith("\r\n"))
			{
				message += "\r\n";
			}

			textBoxMessages.Text = message + textBoxMessages.Text;
		}

		private void buttonAbout_Click(object sender, System.EventArgs e)
		{
			new AboutForm().ShowDialog();
		}

		#endregion

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            textBoxMessages.Clear();
        }

	}
}
