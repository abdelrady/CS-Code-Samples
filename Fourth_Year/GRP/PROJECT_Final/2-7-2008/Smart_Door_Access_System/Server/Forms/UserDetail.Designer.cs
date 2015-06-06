namespace SmartDoor.Classes
{
    partial class UserDetail
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.image = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userdescriptiontxt = new System.Windows.Forms.TextBox();
            this.userstagecbo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userphonetxt = new System.Windows.Forms.TextBox();
            this.userfnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userlnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.useremailtxt = new System.Windows.Forms.TextBox();
            this.OKBTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 219);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.image);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.userdescriptiontxt);
            this.tabPage2.Controls.Add(this.userstagecbo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.userphonetxt);
            this.tabPage2.Controls.Add(this.userfnametxt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.userlnametxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.useremailtxt);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    Details    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.Location = new System.Drawing.Point(358, 9);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(149, 176);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 51;
            this.image.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Description";
            // 
            // userdescriptiontxt
            // 
            this.userdescriptiontxt.Location = new System.Drawing.Point(91, 139);
            this.userdescriptiontxt.Multiline = true;
            this.userdescriptiontxt.Name = "userdescriptiontxt";
            this.userdescriptiontxt.ReadOnly = true;
            this.userdescriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userdescriptiontxt.Size = new System.Drawing.Size(260, 46);
            this.userdescriptiontxt.TabIndex = 44;
            // 
            // userstagecbo
            // 
            this.userstagecbo.Location = new System.Drawing.Point(91, 87);
            this.userstagecbo.Name = "userstagecbo";
            this.userstagecbo.ReadOnly = true;
            this.userstagecbo.Size = new System.Drawing.Size(260, 21);
            this.userstagecbo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Stage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Phone Number";
            // 
            // userphonetxt
            // 
            this.userphonetxt.Location = new System.Drawing.Point(91, 61);
            this.userphonetxt.Name = "userphonetxt";
            this.userphonetxt.ReadOnly = true;
            this.userphonetxt.Size = new System.Drawing.Size(260, 21);
            this.userphonetxt.TabIndex = 41;
            // 
            // userfnametxt
            // 
            this.userfnametxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userfnametxt.ForeColor = System.Drawing.Color.Blue;
            this.userfnametxt.Location = new System.Drawing.Point(91, 9);
            this.userfnametxt.Name = "userfnametxt";
            this.userfnametxt.ReadOnly = true;
            this.userfnametxt.Size = new System.Drawing.Size(260, 21);
            this.userfnametxt.TabIndex = 39;
            this.userfnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Last Name";
            // 
            // userlnametxt
            // 
            this.userlnametxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlnametxt.ForeColor = System.Drawing.Color.Blue;
            this.userlnametxt.Location = new System.Drawing.Point(91, 35);
            this.userlnametxt.Name = "userlnametxt";
            this.userlnametxt.ReadOnly = true;
            this.userlnametxt.Size = new System.Drawing.Size(260, 21);
            this.userlnametxt.TabIndex = 40;
            this.userlnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email Address";
            // 
            // useremailtxt
            // 
            this.useremailtxt.Location = new System.Drawing.Point(91, 113);
            this.useremailtxt.Name = "useremailtxt";
            this.useremailtxt.ReadOnly = true;
            this.useremailtxt.Size = new System.Drawing.Size(260, 21);
            this.useremailtxt.TabIndex = 43;
            // 
            // OKBTN
            // 
            this.OKBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKBTN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBTN.Location = new System.Drawing.Point(433, 233);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(95, 24);
            this.OKBTN.TabIndex = 2;
            this.OKBTN.Text = "&OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // UserDetail
            // 
            this.AcceptButton = this.OKBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 266);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Details";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userdescriptiontxt;
        private System.Windows.Forms.TextBox userstagecbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userphonetxt;
        private System.Windows.Forms.TextBox userfnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userlnametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox useremailtxt;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button OKBTN;
    }
}