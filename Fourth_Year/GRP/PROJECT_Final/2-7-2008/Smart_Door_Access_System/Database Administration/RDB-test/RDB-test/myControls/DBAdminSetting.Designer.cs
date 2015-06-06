namespace RDB_test.myControls {
    partial class DBAdminSetting {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnReload = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtUsrName = new System.Windows.Forms.TextBox();
            this.txtUsrPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.chkIntegSec = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(610, 155);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BtnReload
            // 
            this.BtnReload.Location = new System.Drawing.Point(504, 19);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(112, 23);
            this.BtnReload.TabIndex = 1;
            this.BtnReload.Text = "Load Configuration";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(504, 52);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save Configuration";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(86, 26);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(130, 20);
            this.txtServerName.TabIndex = 3;
            this.txtServerName.Text = "LAB3D-20\\SQLEXPRESS";
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // txtUsrName
            // 
            this.txtUsrName.Location = new System.Drawing.Point(86, 54);
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.Size = new System.Drawing.Size(130, 20);
            this.txtUsrName.TabIndex = 4;
            this.txtUsrName.Text = "eagle";
            this.txtUsrName.TextChanged += new System.EventHandler(this.txtUsrName_TextChanged);
            // 
            // txtUsrPassword
            // 
            this.txtUsrPassword.Location = new System.Drawing.Point(303, 26);
            this.txtUsrPassword.Name = "txtUsrPassword";
            this.txtUsrPassword.Size = new System.Drawing.Size(175, 20);
            this.txtUsrPassword.TabIndex = 5;
            this.txtUsrPassword.Text = "traceandcopy";
            this.txtUsrPassword.UseSystemPasswordChar = true;
            this.txtUsrPassword.TextChanged += new System.EventHandler(this.txtUsrPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Tag = "special";
            this.label1.Text = "Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Tag = "special";
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Tag = "special";
            this.label3.Text = "User Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Tag = "special";
            this.label5.Text = "Initial Catalog";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(302, 52);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(176, 20);
            this.txtDBName.TabIndex = 12;
            this.txtDBName.Text = "SDASDB";
            this.txtDBName.TextChanged += new System.EventHandler(this.txtDBName_TextChanged);
            // 
            // chkIntegSec
            // 
            this.chkIntegSec.AutoSize = true;
            this.chkIntegSec.Location = new System.Drawing.Point(6, 92);
            this.chkIntegSec.Name = "chkIntegSec";
            this.chkIntegSec.Size = new System.Drawing.Size(148, 17);
            this.chkIntegSec.TabIndex = 14;
            this.chkIntegSec.Text = "Allow Integrated Security";
            this.chkIntegSec.UseVisualStyleBackColor = true;
            this.chkIntegSec.CheckedChanged += new System.EventHandler(this.chkIntegSec_CheckedChanged);
            // 
            // DBAdminSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chkIntegSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsrPassword);
            this.Controls.Add(this.txtUsrName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DBAdminSetting";
            this.Size = new System.Drawing.Size(639, 294);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DBAdminSetting_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtUsrName;
        private System.Windows.Forms.TextBox txtUsrPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.CheckBox chkIntegSec;


    }
}
