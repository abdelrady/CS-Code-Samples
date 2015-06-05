using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace SoftwareLock_KeyGen
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmKeyGen : System.Windows.Forms.Form
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
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.btnGenKey = new System.Windows.Forms.Button();
			this.btnGenKey.Click += new System.EventHandler(btnGenKey_Click);
			this.txtAppName = new System.Windows.Forms.TextBox();
			this.txtAppPassword = new System.Windows.Forms.TextBox();
			this.txtCustRef = new System.Windows.Forms.TextBox();
			this.chkSaveToFile = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtSerialKey = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.rbMD5 = new System.Windows.Forms.RadioButton();
			this.rbSHA1 = new System.Windows.Forms.RadioButton();
			this.rbSHA256 = new System.Windows.Forms.RadioButton();
			this.rbSHA384 = new System.Windows.Forms.RadioButton();
			this.rbSHA512 = new System.Windows.Forms.RadioButton();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(21, 31);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(143, 18);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Application Name:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(21, 73);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(171, 18);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Application Password:";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(21, 115);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(168, 18);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Customer Reference:";
			//
			//btnGenKey
			//
			this.btnGenKey.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnGenKey.Location = new System.Drawing.Point(36, 260);
			this.btnGenKey.Name = "btnGenKey";
			this.btnGenKey.Size = new System.Drawing.Size(181, 29);
			this.btnGenKey.TabIndex = 5;
			this.btnGenKey.Text = "Generate Serial Key";
			this.btnGenKey.UseVisualStyleBackColor = true;
			//
			//txtAppName
			//
			this.txtAppName.Location = new System.Drawing.Point(202, 28);
			this.txtAppName.Name = "txtAppName";
			this.txtAppName.Size = new System.Drawing.Size(257, 26);
			this.txtAppName.TabIndex = 0;
			//
			//txtAppPassword
			//
			this.txtAppPassword.Location = new System.Drawing.Point(202, 70);
			this.txtAppPassword.Name = "txtAppPassword";
			this.txtAppPassword.Size = new System.Drawing.Size(257, 26);
			this.txtAppPassword.TabIndex = 1;
			//
			//txtCustRef
			//
			this.txtCustRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCustRef.Location = new System.Drawing.Point(202, 112);
			this.txtCustRef.Name = "txtCustRef";
			this.txtCustRef.Size = new System.Drawing.Size(257, 26);
			this.txtCustRef.TabIndex = 2;
			//
			//chkSaveToFile
			//
			this.chkSaveToFile.AutoSize = true;
			this.chkSaveToFile.Location = new System.Drawing.Point(347, 264);
			this.chkSaveToFile.Name = "chkSaveToFile";
			this.chkSaveToFile.Size = new System.Drawing.Size(114, 22);
			this.chkSaveToFile.TabIndex = 4;
			this.chkSaveToFile.Text = "Save to File";
			this.chkSaveToFile.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(21, 191);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(88, 18);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Serial Key:";
			//
			//txtSerialKey
			//
			this.txtSerialKey.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtSerialKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSerialKey.Font = new System.Drawing.Font("Sylfaen", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtSerialKey.ForeColor = System.Drawing.Color.Crimson;
			this.txtSerialKey.Location = new System.Drawing.Point(202, 188);
			this.txtSerialKey.Name = "txtSerialKey";
			this.txtSerialKey.ReadOnly = true;
			this.txtSerialKey.Size = new System.Drawing.Size(257, 29);
			this.txtSerialKey.TabIndex = 3;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.rbSHA512);
			this.GroupBox1.Controls.Add(this.rbSHA384);
			this.GroupBox1.Controls.Add(this.rbSHA256);
			this.GroupBox1.Controls.Add(this.rbSHA1);
			this.GroupBox1.Controls.Add(this.rbMD5);
			this.GroupBox1.Location = new System.Drawing.Point(486, 28);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(110, 258);
			this.GroupBox1.TabIndex = 10;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Hashes:";
			//
			//rbMD5
			//
			this.rbMD5.AutoSize = true;
			this.rbMD5.Checked = true;
			this.rbMD5.Location = new System.Drawing.Point(14, 41);
			this.rbMD5.Name = "rbMD5";
			this.rbMD5.Size = new System.Drawing.Size(60, 22);
			this.rbMD5.TabIndex = 0;
			this.rbMD5.TabStop = true;
			this.rbMD5.Text = "MD5";
			this.rbMD5.UseVisualStyleBackColor = true;
			//
			//rbSHA1
			//
			this.rbSHA1.AutoSize = true;
			this.rbSHA1.Location = new System.Drawing.Point(14, 83);
			this.rbSHA1.Name = "rbSHA1";
			this.rbSHA1.Size = new System.Drawing.Size(67, 22);
			this.rbSHA1.TabIndex = 1;
			this.rbSHA1.TabStop = true;
			this.rbSHA1.Text = "SHA1";
			this.rbSHA1.UseVisualStyleBackColor = true;
			//
			//rbSHA256
			//
			this.rbSHA256.AutoSize = true;
			this.rbSHA256.Location = new System.Drawing.Point(14, 125);
			this.rbSHA256.Name = "rbSHA256";
			this.rbSHA256.Size = new System.Drawing.Size(87, 22);
			this.rbSHA256.TabIndex = 2;
			this.rbSHA256.TabStop = true;
			this.rbSHA256.Text = "SHA256";
			this.rbSHA256.UseVisualStyleBackColor = true;
			//
			//rbSHA384
			//
			this.rbSHA384.AutoSize = true;
			this.rbSHA384.Location = new System.Drawing.Point(14, 167);
			this.rbSHA384.Name = "rbSHA384";
			this.rbSHA384.Size = new System.Drawing.Size(87, 22);
			this.rbSHA384.TabIndex = 3;
			this.rbSHA384.TabStop = true;
			this.rbSHA384.Text = "SHA384";
			this.rbSHA384.UseVisualStyleBackColor = true;
			//
			//rbSHA512
			//
			this.rbSHA512.AutoSize = true;
			this.rbSHA512.Location = new System.Drawing.Point(14, 210);
			this.rbSHA512.Name = "rbSHA512";
			this.rbSHA512.Size = new System.Drawing.Size(87, 22);
			this.rbSHA512.TabIndex = 4;
			this.rbSHA512.TabStop = true;
			this.rbSHA512.Text = "SHA512";
			this.rbSHA512.UseVisualStyleBackColor = true;
			//
			//frmKeyGen
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) 9.0, (float) 18.0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 315);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.txtSerialKey);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.chkSaveToFile);
			this.Controls.Add(this.txtCustRef);
			this.Controls.Add(this.txtAppPassword);
			this.Controls.Add(this.txtAppName);
			this.Controls.Add(this.btnGenKey);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKeyGen";
			this.Text = "SoftwareLock Key-Generator";
			this.TopMost = true;
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button btnGenKey;
		internal System.Windows.Forms.TextBox txtAppName;
		internal System.Windows.Forms.TextBox txtAppPassword;
		internal System.Windows.Forms.TextBox txtCustRef;
		internal System.Windows.Forms.CheckBox chkSaveToFile;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtSerialKey;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.RadioButton rbSHA512;
		internal System.Windows.Forms.RadioButton rbSHA384;
		internal System.Windows.Forms.RadioButton rbSHA256;
		internal System.Windows.Forms.RadioButton rbSHA1;
		internal System.Windows.Forms.RadioButton rbMD5;
		
	}
	
}
