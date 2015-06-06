
namespace ChatServer
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.PassWordTXT = new System.Windows.Forms.TextBox();
            this.UserCombo = new System.Windows.Forms.ComboBox();
            this.lblAuName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassWordTXT
            // 
            this.PassWordTXT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PassWordTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordTXT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PassWordTXT.ForeColor = System.Drawing.Color.Black;
            this.PassWordTXT.Location = new System.Drawing.Point(94, 156);
            this.PassWordTXT.Name = "PassWordTXT";
            this.PassWordTXT.PasswordChar = '*';
            this.PassWordTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PassWordTXT.Size = new System.Drawing.Size(229, 20);
            this.PassWordTXT.TabIndex = 1;
            // 
            // UserCombo
            // 
            this.UserCombo.FormattingEnabled = true;
            this.UserCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserCombo.Location = new System.Drawing.Point(94, 131);
            this.UserCombo.Name = "UserCombo";
            this.UserCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserCombo.Size = new System.Drawing.Size(246, 21);
            this.UserCombo.TabIndex = 0;
            // 
            // lblAuName
            // 
            this.lblAuName.AutoSize = true;
            this.lblAuName.BackColor = System.Drawing.Color.Transparent;
            this.lblAuName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblAuName.Location = new System.Drawing.Point(35, 158);
            this.lblAuName.Name = "lblAuName";
            this.lblAuName.Size = new System.Drawing.Size(53, 13);
            this.lblAuName.TabIndex = 22;
            this.lblAuName.Text = "Password";
            this.lblAuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(31, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "User name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.Location = new System.Drawing.Point(174, 246);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(101, 24);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EnterBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EnterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnterBtn.Location = new System.Drawing.Point(275, 246);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(96, 24);
            this.EnterBtn.TabIndex = 2;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Enabled = false;
            this.logo.Location = new System.Drawing.Point(9, 229);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(71, 13);
            this.logo.TabIndex = 34;
            this.logo.Text = "FCI Software";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 7);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(-2, -8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 63);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "You have to write your User Name and Password to log in";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 14);
            this.label2.TabIndex = 36;
            this.label2.Text = "Welcome in Smart Door Access Project ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AcceptButton = this.EnterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAuName);
            this.Controls.Add(this.UserCombo);
            this.Controls.Add(this.PassWordTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassWordTXT;
        private System.Windows.Forms.ComboBox UserCombo;
        private System.Windows.Forms.Label lblAuName;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button EnterBtn;
        public System.Windows.Forms.Button CancelBtn;
        internal System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}