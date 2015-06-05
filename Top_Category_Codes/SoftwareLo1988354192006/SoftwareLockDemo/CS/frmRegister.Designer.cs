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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmRegister : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(Form1_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.lblCustRef = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtSK1 = new System.Windows.Forms.TextBox();
			this.txtSK1.KeyUp += new System.Windows.Forms.KeyEventHandler(txtSK1_KeyUp);
			this.txtSK2 = new System.Windows.Forms.TextBox();
			this.txtSK2.KeyUp += new System.Windows.Forms.KeyEventHandler(txtSK1_KeyUp);
			this.txtSK3 = new System.Windows.Forms.TextBox();
			this.txtSK3.KeyUp += new System.Windows.Forms.KeyEventHandler(txtSK1_KeyUp);
			this.txtSK4 = new System.Windows.Forms.TextBox();
			this.txtSK4.KeyUp += new System.Windows.Forms.KeyEventHandler(txtSK1_KeyUp);
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnRegister.Click += new System.EventHandler(btnRegister_Click);
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(18, 18);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(469, 81);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "In order to use this software you need to contact the program\'s vendor and quote " + "the reference below upon which you will be given a Serial Key, which you can ent" + "er below to register your software.";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(28, 118);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(168, 18);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Customer Reference:";
			//
			//lblCustRef
			//
			this.lblCustRef.AutoSize = true;
			this.lblCustRef.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblCustRef.ForeColor = System.Drawing.Color.SeaGreen;
			this.lblCustRef.Location = new System.Drawing.Point(202, 118);
			this.lblCustRef.Name = "lblCustRef";
			this.lblCustRef.Size = new System.Drawing.Size(0, 18);
			this.lblCustRef.TabIndex = 2;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(41, 195);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(412, 18);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Enter your Serial Key below to register your software:";
			//
			//txtSK1
			//
			this.txtSK1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSK1.Location = new System.Drawing.Point(66, 232);
			this.txtSK1.MaxLength = 10;
			this.txtSK1.Name = "txtSK1";
			this.txtSK1.Size = new System.Drawing.Size(81, 26);
			this.txtSK1.TabIndex = 4;
			//
			//txtSK2
			//
			this.txtSK2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSK2.Location = new System.Drawing.Point(153, 232);
			this.txtSK2.MaxLength = 10;
			this.txtSK2.Name = "txtSK2";
			this.txtSK2.Size = new System.Drawing.Size(81, 26);
			this.txtSK2.TabIndex = 5;
			//
			//txtSK3
			//
			this.txtSK3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSK3.Location = new System.Drawing.Point(240, 232);
			this.txtSK3.MaxLength = 10;
			this.txtSK3.Name = "txtSK3";
			this.txtSK3.Size = new System.Drawing.Size(81, 26);
			this.txtSK3.TabIndex = 6;
			//
			//txtSK4
			//
			this.txtSK4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSK4.Location = new System.Drawing.Point(327, 232);
			this.txtSK4.MaxLength = 10;
			this.txtSK4.Name = "txtSK4";
			this.txtSK4.Size = new System.Drawing.Size(81, 26);
			this.txtSK4.TabIndex = 7;
			//
			//btnRegister
			//
			this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnRegister.Location = new System.Drawing.Point(240, 285);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(112, 33);
			this.btnRegister.TabIndex = 8;
			this.btnRegister.Text = "&Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			//
			//btnCancel
			//
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(122, 285);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 33);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//frmRegister
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) 9.0, (float) 18.0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 330);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtSK4);
			this.Controls.Add(this.txtSK3);
			this.Controls.Add(this.txtSK2);
			this.Controls.Add(this.txtSK1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.lblCustRef);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRegister";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Software Registration Demo";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label lblCustRef;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtSK1;
		internal System.Windows.Forms.TextBox txtSK2;
		internal System.Windows.Forms.TextBox txtSK3;
		internal System.Windows.Forms.TextBox txtSK4;
		internal System.Windows.Forms.Button btnRegister;
		internal System.Windows.Forms.Button btnCancel;
		
	}
	
}
