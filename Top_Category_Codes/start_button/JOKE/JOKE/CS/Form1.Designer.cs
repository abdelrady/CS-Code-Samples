using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace JOKE
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
			this.components = new System.ComponentModel.Container();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(Button1_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(Button2_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(Button3_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(Button4_Click);
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(Button5_Click);
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(Button6_Click);
			this.Button7 = new System.Windows.Forms.Button();
			this.Button7.Click += new System.EventHandler(Button7_Click);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(12, 12);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(168, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Hide Start Button";
			this.ToolTip1.SetToolTip(this.Button1, "HIDE START BUTON ON TASKBAR");
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(12, 51);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(168, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Show Start Button";
			this.ToolTip1.SetToolTip(this.Button2, "SHOW START BUTTON ON TASKBAR");
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(12, 94);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(168, 23);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "Change Text";
			this.ToolTip1.SetToolTip(this.Button3, "CHANGE TEXT ON START BUTTON ");
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(191, 12);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(168, 23);
			this.Button4.TabIndex = 3;
			this.Button4.Text = "Disable TaskBar";
			this.ToolTip1.SetToolTip(this.Button4, "DISABLE TASKBAR");
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(191, 51);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(168, 23);
			this.Button5.TabIndex = 4;
			this.Button5.Text = "Enable TaskBar";
			this.ToolTip1.SetToolTip(this.Button5, "ENABLE TASKBAR");
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(191, 94);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(81, 23);
			this.Button6.TabIndex = 5;
			this.Button6.Text = "Hide Clock";
			this.ToolTip1.SetToolTip(this.Button6, "HIDE CLOCK ON TASKBAR");
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Button7
			//
			this.Button7.Location = new System.Drawing.Point(278, 94);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(81, 23);
			this.Button7.TabIndex = 6;
			this.Button7.Text = "Show Clock";
			this.ToolTip1.SetToolTip(this.Button7, "SHOW CLOCK ON TASKBAR");
			this.Button7.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.TextBox1.Location = new System.Drawing.Point(141, 123);
			this.TextBox1.MaxLength = 4;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(86, 21);
			this.TextBox1.TabIndex = 7;
			this.TextBox1.Text = "Sasa";
			this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Label1
			//
			this.Label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Label1.Location = new System.Drawing.Point(0, 153);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(373, 23);
			this.Label1.TabIndex = 8;
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			//
			//ToolTip1
			//
			this.ToolTip1.BackColor = System.Drawing.Color.Black;
			this.ToolTip1.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.ToolTip1.IsBalloon = true;
			this.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ToolTip1.ToolTipTitle = "API EXAMPLE";
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) 6.0, (float) 13.0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 176);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button7);
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Joke";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.ToolTip ToolTip1;
		
	}
	
}
