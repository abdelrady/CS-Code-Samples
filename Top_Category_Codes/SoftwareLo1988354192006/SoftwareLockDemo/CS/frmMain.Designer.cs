using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace SoftwareLockDemo
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmMain : System.Windows.Forms.Form
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
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmMain_Load);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(Button1_Click);
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(26, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(304, 116);
			this.Label1.TabIndex = 0;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(71, 216);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(215, 35);
			this.Button1.TabIndex = 1;
			this.Button1.UseVisualStyleBackColor = true;
			//
			//frmMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) 9.0, (float) 18.0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 285);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmMain";
			this.Text = "SoftwareLock Demo";
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button1;
	}
	
}
