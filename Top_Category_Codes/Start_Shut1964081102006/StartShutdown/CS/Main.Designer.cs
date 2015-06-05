using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;

namespace StartShutdown
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Main : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Main_Load);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.lblRight = new System.Windows.Forms.Label();
			this.lblLeft = new System.Windows.Forms.Label();
			this.lblWarning = new System.Windows.Forms.Label();
			this.prgShutdown = new System.Windows.Forms.ProgressBar();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.tmrShutdown = new System.Windows.Forms.Timer(this.components);
			this.tmrShutdown.Tick += new System.EventHandler(tmrShutdown_Tick);
			this.chkDisableBeeps = new System.Windows.Forms.CheckBox();
			this.chkDisableBeeps.CheckedChanged += new System.EventHandler(chkDisableBeeps_CheckedChanged);
			this.picShutdown = new System.Windows.Forms.PictureBox();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.picShutdown).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor = System.Drawing.Color.White;
			this.Panel1.Controls.Add(this.lblRight);
			this.Panel1.Controls.Add(this.lblLeft);
			this.Panel1.Controls.Add(this.lblWarning);
			this.Panel1.Controls.Add(this.picShutdown);
			this.Panel1.Controls.Add(this.prgShutdown);
			this.Panel1.Controls.Add(this.cmdCancel);
			this.Panel1.Location = new System.Drawing.Point(0, 41);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(306, 120);
			this.Panel1.TabIndex = 0;
			//
			//lblRight
			//
			this.lblRight.BackColor = System.Drawing.Color.Red;
			this.lblRight.Location = new System.Drawing.Point(305, 0);
			this.lblRight.Name = "lblRight";
			this.lblRight.Size = new System.Drawing.Size(1, 120);
			this.lblRight.TabIndex = 5;
			this.lblRight.Text = "Label3";
			//
			//lblLeft
			//
			this.lblLeft.BackColor = System.Drawing.Color.Red;
			this.lblLeft.Location = new System.Drawing.Point(0, 0);
			this.lblLeft.Name = "lblLeft";
			this.lblLeft.Size = new System.Drawing.Size(1, 120);
			this.lblLeft.TabIndex = 4;
			//
			//lblWarning
			//
			this.lblWarning.Font = new System.Drawing.Font("Verdana", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblWarning.Location = new System.Drawing.Point(79, 13);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(200, 44);
			this.lblWarning.TabIndex = 3;
			this.lblWarning.Text = "This computer is scheduled to shutdown in 3:00 minutes. Click the button to Cance" + "l.";
			//
			//prgShutdown
			//
			this.prgShutdown.Location = new System.Drawing.Point(17, 68);
			this.prgShutdown.Maximum = 180;
			this.prgShutdown.Name = "prgShutdown";
			this.prgShutdown.Size = new System.Drawing.Size(272, 12);
			this.prgShutdown.TabIndex = 1;
			//
			//cmdCancel
			//
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.cmdCancel.Location = new System.Drawing.Point(113, 88);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(80, 24);
			this.cmdCancel.TabIndex = 0;
			this.cmdCancel.TabStop = false;
			this.cmdCancel.Text = "&Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(44, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(218, 23);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Shutdown Warning";
			//
			//tmrShutdown
			//
			this.tmrShutdown.Enabled = true;
			this.tmrShutdown.Interval = 1000;
			//
			//chkDisableBeeps
			//
			this.chkDisableBeeps.AutoSize = true;
			this.chkDisableBeeps.BackColor = System.Drawing.Color.Transparent;
			this.chkDisableBeeps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.chkDisableBeeps.ForeColor = System.Drawing.Color.White;
			this.chkDisableBeeps.Location = new System.Drawing.Point(101, 173);
			this.chkDisableBeeps.Name = "chkDisableBeeps";
			this.chkDisableBeeps.Size = new System.Drawing.Size(104, 17);
			this.chkDisableBeeps.TabIndex = 6;
			this.chkDisableBeeps.Text = "Disable Beeps";
			this.chkDisableBeeps.UseVisualStyleBackColor = false;
			//
			//picShutdown
			//
			this.picShutdown.Image = global::StartShutdown.My.Resources.Resources.StartShutdown;
			this.picShutdown.Location = new System.Drawing.Point(16, 11);
			this.picShutdown.Name = "picShutdown";
			this.picShutdown.Size = new System.Drawing.Size(48, 48);
			this.picShutdown.TabIndex = 2;
			this.picShutdown.TabStop = false;
			//
			//Main
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) 6.0, (float) 13.0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(306, 203);
			this.Controls.Add(this.chkDisableBeeps);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Main";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.picShutdown).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button cmdCancel;
		internal System.Windows.Forms.ProgressBar prgShutdown;
		internal System.Windows.Forms.PictureBox picShutdown;
		internal System.Windows.Forms.Label lblWarning;
		internal System.Windows.Forms.Timer tmrShutdown;
		internal System.Windows.Forms.Label lblRight;
		internal System.Windows.Forms.Label lblLeft;
		internal System.Windows.Forms.CheckBox chkDisableBeeps;
		
	}
	
}
