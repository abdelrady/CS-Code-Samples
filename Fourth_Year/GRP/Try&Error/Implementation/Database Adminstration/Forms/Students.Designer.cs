namespace Database_Adminstration
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.vaildCHK = new System.Windows.Forms.CheckBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.userIdtxt = new System.Windows.Forms.TextBox();
            this.userfnametxt = new System.Windows.Forms.TextBox();
            this.userlnametxt = new System.Windows.Forms.TextBox();
            this.useremailtxt = new System.Windows.Forms.TextBox();
            this.userphonetxt = new System.Windows.Forms.TextBox();
            this.userdescriptiontxt = new System.Windows.Forms.TextBox();
            this.BTNBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.insertBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.userstagecbo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // vaildCHK
            // 
            this.vaildCHK.Appearance = System.Windows.Forms.Appearance.Button;
            this.vaildCHK.Checked = true;
            this.vaildCHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vaildCHK.Location = new System.Drawing.Point(102, 261);
            this.vaildCHK.Name = "vaildCHK";
            this.vaildCHK.Size = new System.Drawing.Size(56, 23);
            this.vaildCHK.TabIndex = 6;
            this.vaildCHK.UseVisualStyleBackColor = true;
            this.vaildCHK.CheckedChanged += new System.EventHandler(this.vaildCHK_CheckedChanged);
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(335, 16);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(120, 148);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // userIdtxt
            // 
            this.userIdtxt.Location = new System.Drawing.Point(102, 16);
            this.userIdtxt.Name = "userIdtxt";
            this.userIdtxt.Size = new System.Drawing.Size(216, 21);
            this.userIdtxt.TabIndex = 2;
            // 
            // userfnametxt
            // 
            this.userfnametxt.Location = new System.Drawing.Point(102, 45);
            this.userfnametxt.Name = "userfnametxt";
            this.userfnametxt.Size = new System.Drawing.Size(216, 21);
            this.userfnametxt.TabIndex = 0;
            // 
            // userlnametxt
            // 
            this.userlnametxt.Location = new System.Drawing.Point(102, 74);
            this.userlnametxt.Name = "userlnametxt";
            this.userlnametxt.Size = new System.Drawing.Size(216, 21);
            this.userlnametxt.TabIndex = 1;
            // 
            // useremailtxt
            // 
            this.useremailtxt.Location = new System.Drawing.Point(102, 103);
            this.useremailtxt.Name = "useremailtxt";
            this.useremailtxt.Size = new System.Drawing.Size(216, 21);
            this.useremailtxt.TabIndex = 2;
            // 
            // userphonetxt
            // 
            this.userphonetxt.Location = new System.Drawing.Point(102, 132);
            this.userphonetxt.Name = "userphonetxt";
            this.userphonetxt.Size = new System.Drawing.Size(216, 21);
            this.userphonetxt.TabIndex = 3;
            // 
            // userdescriptiontxt
            // 
            this.userdescriptiontxt.Location = new System.Drawing.Point(102, 190);
            this.userdescriptiontxt.Multiline = true;
            this.userdescriptiontxt.Name = "userdescriptiontxt";
            this.userdescriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userdescriptiontxt.Size = new System.Drawing.Size(353, 68);
            this.userdescriptiontxt.TabIndex = 5;
            // 
            // BTNBrowse
            // 
            this.BTNBrowse.Location = new System.Drawing.Point(421, 165);
            this.BTNBrowse.Name = "BTNBrowse";
            this.BTNBrowse.Size = new System.Drawing.Size(35, 22);
            this.BTNBrowse.TabIndex = 7;
            this.BTNBrowse.Text = ". . .";
            this.BTNBrowse.UseVisualStyleBackColor = true;
            this.BTNBrowse.Click += new System.EventHandler(this.BTNBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Barcode Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(53, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Unvalid";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(358, 306);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(101, 24);
            this.insertBTN.TabIndex = 8;
            this.insertBTN.Text = "&Insert";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-1, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 9);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(257, 306);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(101, 24);
            this.CancelBTN.TabIndex = 20;
            this.CancelBTN.Text = "&Close";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // userstagecbo
            // 
            this.userstagecbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userstagecbo.FormattingEnabled = true;
            this.userstagecbo.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
            this.userstagecbo.Location = new System.Drawing.Point(102, 161);
            this.userstagecbo.Name = "userstagecbo";
            this.userstagecbo.Size = new System.Drawing.Size(113, 21);
            this.userstagecbo.TabIndex = 21;
            // 
            // Students
            // 
            this.AcceptButton = this.insertBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(471, 337);
            this.Controls.Add(this.userstagecbo);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNBrowse);
            this.Controls.Add(this.userdescriptiontxt);
            this.Controls.Add(this.userphonetxt);
            this.Controls.Add(this.useremailtxt);
            this.Controls.Add(this.userlnametxt);
            this.Controls.Add(this.userfnametxt);
            this.Controls.Add(this.userIdtxt);
            this.Controls.Add(this.image);
            this.Controls.Add(this.vaildCHK);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Students";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox vaildCHK;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox userIdtxt;
        private System.Windows.Forms.TextBox userfnametxt;
        private System.Windows.Forms.TextBox userlnametxt;
        private System.Windows.Forms.TextBox useremailtxt;
        private System.Windows.Forms.TextBox userphonetxt;
        private System.Windows.Forms.TextBox userdescriptiontxt;
        private System.Windows.Forms.Button BTNBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.ComboBox userstagecbo;
    }
}

