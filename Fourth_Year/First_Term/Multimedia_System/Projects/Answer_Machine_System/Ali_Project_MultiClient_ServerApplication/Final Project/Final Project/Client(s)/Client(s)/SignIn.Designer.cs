namespace Client_s_
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.WorkBTN = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NickTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PortTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IpTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailTXT = new System.Windows.Forms.TextBox();
            this.statusLBL = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkBTN
            // 
            this.WorkBTN.BackColor = System.Drawing.SystemColors.Control;
            this.WorkBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WorkBTN.Font = new System.Drawing.Font("Tahoma", 8F);
            this.WorkBTN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WorkBTN.Location = new System.Drawing.Point(217, 146);
            this.WorkBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WorkBTN.Name = "WorkBTN";
            this.WorkBTN.Size = new System.Drawing.Size(94, 26);
            this.WorkBTN.TabIndex = 0;
            this.WorkBTN.Text = "&Connect";
            this.WorkBTN.UseVisualStyleBackColor = false;
            this.WorkBTN.Click += new System.EventHandler(this.WorkBTN_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(10, 32);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(38, 42);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 29;
            this.PictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(54, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nick Name";
            // 
            // NickTXT
            // 
            this.NickTXT.Location = new System.Drawing.Point(127, 59);
            this.NickTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NickTXT.Name = "NickTXT";
            this.NickTXT.Size = new System.Drawing.Size(124, 20);
            this.NickTXT.TabIndex = 31;
            this.NickTXT.Text = "Ali Hussien";
            this.NickTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Process ID";
            // 
            // PortTXT
            // 
            this.PortTXT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PortTXT.Location = new System.Drawing.Point(127, 107);
            this.PortTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PortTXT.Name = "PortTXT";
            this.PortTXT.Size = new System.Drawing.Size(124, 20);
            this.PortTXT.TabIndex = 30;
            this.PortTXT.Text = "5000";
            this.PortTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Server IP Address";
            // 
            // IpTXT
            // 
            this.IpTXT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.IpTXT.Location = new System.Drawing.Point(127, 83);
            this.IpTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IpTXT.Name = "IpTXT";
            this.IpTXT.Size = new System.Drawing.Size(124, 20);
            this.IpTXT.TabIndex = 26;
            this.IpTXT.Text = "127. 0 . 0 . 1";
            this.IpTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(82, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Email";
            // 
            // mailTXT
            // 
            this.mailTXT.Location = new System.Drawing.Point(127, 35);
            this.mailTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mailTXT.Name = "mailTXT";
            this.mailTXT.Size = new System.Drawing.Size(184, 20);
            this.mailTXT.TabIndex = 33;
            this.mailTXT.Text = "alihussien3400@hotmial.com";
            this.mailTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusLBL
            // 
            this.statusLBL.AutoSize = true;
            this.statusLBL.BackColor = System.Drawing.Color.Transparent;
            this.statusLBL.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.statusLBL.ForeColor = System.Drawing.Color.Blue;
            this.statusLBL.Location = new System.Drawing.Point(9, 9);
            this.statusLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(148, 13);
            this.statusLBL.TabIndex = 35;
            this.statusLBL.Text = "Fill in Sign in data . . .";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(9, 139);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 1);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // SigninFRM
            // 
            this.AcceptButton = this.WorkBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(328, 178);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mailTXT);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NickTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpTXT);
            this.Controls.Add(this.WorkBTN);
            this.Font = new System.Drawing.Font("Verdana", 8F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SigninFRM";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in . . .";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SigninFRM_FormClosing);
            this.Load += new System.EventHandler(this.SigninFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NickTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IpTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailTXT;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label statusLBL;
        public System.Windows.Forms.Button WorkBTN;
    }
}