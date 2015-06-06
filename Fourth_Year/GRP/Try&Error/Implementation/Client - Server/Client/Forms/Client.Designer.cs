using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClient
{
    public partial class Client : System.Windows.Forms.Form
    {

       
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userdescriptiontxt = new System.Windows.Forms.TextBox();
            this.userphonetxt = new System.Windows.Forms.TextBox();
            this.useremailtxt = new System.Windows.Forms.TextBox();
            this.userlnametxt = new System.Windows.Forms.TextBox();
            this.userfnametxt = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.vaildCHK = new System.Windows.Forms.CheckBox();
            this.ConnectBTN = new System.Windows.Forms.Button();
            this.userstagecbo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(101, 32);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(225, 21);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(10, 323);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(344, 48);
            this.displayTextBox.TabIndex = 1;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(360, 323);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(101, 24);
            this.CancelBTN.TabIndex = 41;
            this.CancelBTN.Text = "&Close";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-1, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 8);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(53, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Unvalid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Stage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Barcode Number";
            // 
            // userdescriptiontxt
            // 
            this.userdescriptiontxt.Location = new System.Drawing.Point(102, 203);
            this.userdescriptiontxt.Multiline = true;
            this.userdescriptiontxt.Name = "userdescriptiontxt";
            this.userdescriptiontxt.ReadOnly = true;
            this.userdescriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userdescriptiontxt.Size = new System.Drawing.Size(353, 68);
            this.userdescriptiontxt.TabIndex = 28;
            // 
            // userphonetxt
            // 
            this.userphonetxt.Location = new System.Drawing.Point(102, 145);
            this.userphonetxt.Name = "userphonetxt";
            this.userphonetxt.ReadOnly = true;
            this.userphonetxt.Size = new System.Drawing.Size(224, 21);
            this.userphonetxt.TabIndex = 27;
            // 
            // useremailtxt
            // 
            this.useremailtxt.Location = new System.Drawing.Point(102, 116);
            this.useremailtxt.Name = "useremailtxt";
            this.useremailtxt.ReadOnly = true;
            this.useremailtxt.Size = new System.Drawing.Size(224, 21);
            this.useremailtxt.TabIndex = 25;
            // 
            // userlnametxt
            // 
            this.userlnametxt.Location = new System.Drawing.Point(102, 87);
            this.userlnametxt.Name = "userlnametxt";
            this.userlnametxt.ReadOnly = true;
            this.userlnametxt.Size = new System.Drawing.Size(224, 21);
            this.userlnametxt.TabIndex = 23;
            // 
            // userfnametxt
            // 
            this.userfnametxt.Location = new System.Drawing.Point(102, 58);
            this.userfnametxt.Name = "userfnametxt";
            this.userfnametxt.ReadOnly = true;
            this.userfnametxt.Size = new System.Drawing.Size(224, 21);
            this.userfnametxt.TabIndex = 22;
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(335, 32);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(120, 163);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 24;
            this.image.TabStop = false;
            // 
            // vaildCHK
            // 
            this.vaildCHK.Appearance = System.Windows.Forms.Appearance.Button;
            this.vaildCHK.Checked = true;
            this.vaildCHK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vaildCHK.Location = new System.Drawing.Point(102, 274);
            this.vaildCHK.Name = "vaildCHK";
            this.vaildCHK.Size = new System.Drawing.Size(56, 23);
            this.vaildCHK.TabIndex = 29;
            this.vaildCHK.UseVisualStyleBackColor = true;
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Location = new System.Drawing.Point(360, 348);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(101, 23);
            this.ConnectBTN.TabIndex = 43;
            this.ConnectBTN.Text = "&Connect";
            this.ConnectBTN.UseVisualStyleBackColor = true;
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // userstagecbo
            // 
            this.userstagecbo.Location = new System.Drawing.Point(102, 174);
            this.userstagecbo.Name = "userstagecbo";
            this.userstagecbo.ReadOnly = true;
            this.userstagecbo.Size = new System.Drawing.Size(223, 21);
            this.userstagecbo.TabIndex = 44;
            // 
            // Client
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(475, 383);
            this.Controls.Add(this.userstagecbo);
            this.Controls.Add(this.ConnectBTN);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userdescriptiontxt);
            this.Controls.Add(this.userphonetxt);
            this.Controls.Add(this.useremailtxt);
            this.Controls.Add(this.userlnametxt);
            this.Controls.Add(this.userfnametxt);
            this.Controls.Add(this.image);
            this.Controls.Add(this.vaildCHK);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Door Access - Client ";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Client_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userdescriptiontxt;
        private System.Windows.Forms.TextBox userphonetxt;
        private System.Windows.Forms.TextBox useremailtxt;
        private System.Windows.Forms.TextBox userlnametxt;
        private System.Windows.Forms.TextBox userfnametxt;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.CheckBox vaildCHK;
        private System.Windows.Forms.Button ConnectBTN;
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.TextBox userstagecbo;
    }
}
