
namespace SmartDoor
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
            this.PassWordTXT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UserCombo = new System.Windows.Forms.TextBox();
            this._CBO_Servers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._BTN_Connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._CBO_DataBases = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuName
            // 
            this.lblAuName.AutoSize = true;
            this.lblAuName.BackColor = System.Drawing.Color.Transparent;
            this.lblAuName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuName.Location = new System.Drawing.Point(91, 69);
            this.lblAuName.Name = "lblAuName";
            this.lblAuName.Size = new System.Drawing.Size(61, 13);
            this.lblAuName.TabIndex = 22;
            this.lblAuName.Text = "Password";
            this.lblAuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.Location = new System.Drawing.Point(175, 324);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(97, 24);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Close";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnterBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnterBtn.Location = new System.Drawing.Point(272, 324);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(96, 24);
            this.EnterBtn.TabIndex = 1;
            this.EnterBtn.Text = "Log in";
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 20);
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
            this.logo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(9, 310);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(79, 13);
            this.logo.TabIndex = 34;
            this.logo.Text = "FCI Software";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-1, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 7);
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
            this.groupBox2.Size = new System.Drawing.Size(384, 63);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.Location = new System.Drawing.Point(14, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "You have to write your User Name and Password to login.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 14);
            this.label2.TabIndex = 36;
            this.label2.Text = "Welcome in Smart Door Access Project ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassWordTXT
            // 
            this.PassWordTXT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTXT.Location = new System.Drawing.Point(158, 67);
            this.PassWordTXT.Name = "PassWordTXT";
            this.PassWordTXT.Size = new System.Drawing.Size(164, 21);
            this.PassWordTXT.TabIndex = 1;
            this.PassWordTXT.Text = "ali";
            this.PassWordTXT.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UserCombo);
            this.groupBox3.Controls.Add(this.PassWordTXT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.lblAuName);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 107);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doors Server";
            // 
            // UserCombo
            // 
            this.UserCombo.Location = new System.Drawing.Point(158, 44);
            this.UserCombo.Name = "UserCombo";
            this.UserCombo.Size = new System.Drawing.Size(164, 21);
            this.UserCombo.TabIndex = 0;
            this.UserCombo.Text = "ali";
            // 
            // _CBO_Servers
            // 
            this._CBO_Servers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CBO_Servers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CBO_Servers.FormattingEnabled = true;
            this._CBO_Servers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._CBO_Servers.Location = new System.Drawing.Point(75, 31);
            this._CBO_Servers.Name = "_CBO_Servers";
            this._CBO_Servers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._CBO_Servers.Size = new System.Drawing.Size(247, 21);
            this._CBO_Servers.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Server";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _BTN_Connect
            // 
            this._BTN_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._BTN_Connect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BTN_Connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Connect.Location = new System.Drawing.Point(262, 91);
            this._BTN_Connect.Name = "_BTN_Connect";
            this._BTN_Connect.Size = new System.Drawing.Size(89, 23);
            this._BTN_Connect.TabIndex = 2;
            this._BTN_Connect.Text = "Start SQL";
            this._BTN_Connect.Click += new System.EventHandler(this._BTN_Connect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Database";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _CBO_DataBases
            // 
            this._CBO_DataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CBO_DataBases.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CBO_DataBases.FormattingEnabled = true;
            this._CBO_DataBases.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._CBO_DataBases.Items.AddRange(new object[] {
            "<Configured Application Database>"});
            this._CBO_DataBases.Location = new System.Drawing.Point(75, 55);
            this._CBO_DataBases.Name = "_CBO_DataBases";
            this._CBO_DataBases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._CBO_DataBases.Size = new System.Drawing.Size(247, 21);
            this._CBO_DataBases.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._CBO_DataBases);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this._BTN_Connect);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this._CBO_Servers);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 120);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SQL Server";
            // 
            // login
            // 
            this.AcceptButton = this.EnterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(381, 357);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EnterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox PassWordTXT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox UserCombo;
        private System.Windows.Forms.ComboBox _CBO_Servers;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button _BTN_Connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _CBO_DataBases;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}