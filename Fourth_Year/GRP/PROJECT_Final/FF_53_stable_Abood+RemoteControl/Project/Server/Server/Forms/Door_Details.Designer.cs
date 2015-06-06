namespace SmartDoor
{
    partial class Door_Details
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
            this.SocIDTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.doorMac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastlog = new System.Windows.Forms.TextBox();
            this.lastupdate = new System.Windows.Forms.TextBox();
            this.doorip = new System.Windows.Forms.TextBox();
            this.DoorNameTXT = new System.Windows.Forms.TextBox();
            this.DoorNumTXt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OKBTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SocIDTXT);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.doorMac);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lastlog);
            this.tabPage2.Controls.Add(this.lastupdate);
            this.tabPage2.Controls.Add(this.doorip);
            this.tabPage2.Controls.Add(this.DoorNameTXT);
            this.tabPage2.Controls.Add(this.DoorNumTXt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proprities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SocIDTXT
            // 
            this.SocIDTXT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocIDTXT.Location = new System.Drawing.Point(85, 12);
            this.SocIDTXT.Name = "SocIDTXT";
            this.SocIDTXT.ReadOnly = true;
            this.SocIDTXT.Size = new System.Drawing.Size(91, 21);
            this.SocIDTXT.TabIndex = 21;
            this.SocIDTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Socket ID";
            // 
            // doorMac
            // 
            this.doorMac.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doorMac.Location = new System.Drawing.Point(85, 154);
            this.doorMac.Name = "doorMac";
            this.doorMac.ReadOnly = true;
            this.doorMac.Size = new System.Drawing.Size(246, 21);
            this.doorMac.TabIndex = 19;
            this.doorMac.Text = "NOT_CONFIGURED";
            this.doorMac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Door Name";
            // 
            // lastlog
            // 
            this.lastlog.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lastlog.Location = new System.Drawing.Point(85, 131);
            this.lastlog.Name = "lastlog";
            this.lastlog.ReadOnly = true;
            this.lastlog.Size = new System.Drawing.Size(246, 20);
            this.lastlog.TabIndex = 17;
            this.lastlog.Text = "NOT_CONFIGURED";
            this.lastlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastupdate
            // 
            this.lastupdate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lastupdate.Location = new System.Drawing.Point(85, 108);
            this.lastupdate.Name = "lastupdate";
            this.lastupdate.ReadOnly = true;
            this.lastupdate.Size = new System.Drawing.Size(246, 20);
            this.lastupdate.TabIndex = 16;
            this.lastupdate.Text = "NOT_CONFIGURED";
            this.lastupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doorip
            // 
            this.doorip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doorip.Location = new System.Drawing.Point(85, 84);
            this.doorip.Name = "doorip";
            this.doorip.ReadOnly = true;
            this.doorip.Size = new System.Drawing.Size(246, 21);
            this.doorip.TabIndex = 15;
            this.doorip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoorNameTXT
            // 
            this.DoorNameTXT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorNameTXT.Location = new System.Drawing.Point(85, 60);
            this.DoorNameTXT.Name = "DoorNameTXT";
            this.DoorNameTXT.ReadOnly = true;
            this.DoorNameTXT.Size = new System.Drawing.Size(246, 21);
            this.DoorNameTXT.TabIndex = 14;
            this.DoorNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoorNumTXt
            // 
            this.DoorNumTXt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorNumTXt.Location = new System.Drawing.Point(85, 36);
            this.DoorNumTXt.Name = "DoorNumTXt";
            this.DoorNumTXt.ReadOnly = true;
            this.DoorNumTXt.Size = new System.Drawing.Size(246, 21);
            this.DoorNumTXt.TabIndex = 13;
            this.DoorNumTXt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Door MAC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Door Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Update";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Door IP";
            // 
            // OKBTN
            // 
            this.OKBTN.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.OKBTN.Location = new System.Drawing.Point(264, 222);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(93, 23);
            this.OKBTN.TabIndex = 1;
            this.OKBTN.Text = "&OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // Door_Details
            // 
            this.AcceptButton = this.OKBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 250);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Door_Details";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OKBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastlog;
        private System.Windows.Forms.TextBox lastupdate;
        private System.Windows.Forms.TextBox doorip;
        private System.Windows.Forms.TextBox DoorNumTXt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DoorNameTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox doorMac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SocIDTXT;
        private System.Windows.Forms.Label label5;
    }
}