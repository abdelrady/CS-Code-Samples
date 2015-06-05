using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace WriteProcessMemory
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Form1 : System.Windows.Forms.Form
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
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(Button1_Click);
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(63, 39);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(99, 54);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Go";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) 6.0, (float) 13.0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(219, 148);
			this.Controls.Add(this.Button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Button Button1;
		
	}
	
}
