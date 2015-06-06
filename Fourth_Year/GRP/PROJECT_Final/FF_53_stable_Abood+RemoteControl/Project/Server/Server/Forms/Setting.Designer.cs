namespace SmartDoor
{
    partial class Settingfrm
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
            this.label5 = new System.Windows.Forms.Label();
            this.sendupdatestxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updatesporttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainpornumbertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Connectionstrtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.OKbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 188);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.sendupdatestxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.updatesporttxt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.mainpornumbertxt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Connectionstrtxt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(398, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ms";
            // 
            // sendupdatestxt
            // 
            this.sendupdatestxt.Location = new System.Drawing.Point(124, 129);
            this.sendupdatestxt.Name = "sendupdatestxt";
            this.sendupdatestxt.Size = new System.Drawing.Size(100, 20);
            this.sendupdatestxt.TabIndex = 16;
            this.sendupdatestxt.Text = "60000";
            this.sendupdatestxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Send Updates Every";
            // 
            // updatesporttxt
            // 
            this.updatesporttxt.Location = new System.Drawing.Point(124, 105);
            this.updatesporttxt.Name = "updatesporttxt";
            this.updatesporttxt.Size = new System.Drawing.Size(100, 20);
            this.updatesporttxt.TabIndex = 14;
            this.updatesporttxt.Text = "5001";
            this.updatesporttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Updates Port Number";
            // 
            // mainpornumbertxt
            // 
            this.mainpornumbertxt.Location = new System.Drawing.Point(124, 81);
            this.mainpornumbertxt.Name = "mainpornumbertxt";
            this.mainpornumbertxt.Size = new System.Drawing.Size(100, 20);
            this.mainpornumbertxt.TabIndex = 12;
            this.mainpornumbertxt.Text = "5000";
            this.mainpornumbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Main Port Number";
            // 
            // Connectionstrtxt
            // 
            this.Connectionstrtxt.ForeColor = System.Drawing.Color.Blue;
            this.Connectionstrtxt.Location = new System.Drawing.Point(124, 24);
            this.Connectionstrtxt.Multiline = true;
            this.Connectionstrtxt.Name = "Connectionstrtxt";
            this.Connectionstrtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Connectionstrtxt.Size = new System.Drawing.Size(257, 53);
            this.Connectionstrtxt.TabIndex = 10;
            this.Connectionstrtxt.Text = "Data Source=\r\n.\\SQLEXPRESS;\r\nAttachDbFilename=\'C:\\db\\SDASDB.mdf\';\r\nIntegrated Sec" +
                "urity=True;\r\nConnect Timeout=30;\r\nUser Instance=True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = " Connection String";
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(336, 204);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(79, 25);
            this.CancelBTN.TabIndex = 18;
            this.CancelBTN.Text = "&Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(254, 204);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(79, 25);
            this.OKbtn.TabIndex = 17;
            this.OKbtn.Text = "&Save && Exit";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // Settingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 236);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settingfrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server&& Setting";
            this.Load += new System.EventHandler(this.Settingfrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sendupdatestxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updatesporttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mainpornumbertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Connectionstrtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button OKbtn;

    }
}