namespace Server
{
    partial class AudioSetting
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
            this.SaveBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.rateC = new System.Windows.Forms.ComboBox();
            this.bitsC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.channelC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sizeC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buffersC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBTN
            // 
            this.SaveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBTN.Enabled = false;
            this.SaveBTN.Location = new System.Drawing.Point(200, 143);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(66, 23);
            this.SaveBTN.TabIndex = 0;
            this.SaveBTN.Text = "&Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBTN.Location = new System.Drawing.Point(134, 143);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(66, 23);
            this.CancelBTN.TabIndex = 1;
            this.CancelBTN.Text = "&Close";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // rateC
            // 
            this.rateC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rateC.FormattingEnabled = true;
            this.rateC.Items.AddRange(new object[] {
            "8000",
            "44100"});
            this.rateC.Location = new System.Drawing.Point(63, 25);
            this.rateC.Name = "rateC";
            this.rateC.Size = new System.Drawing.Size(84, 21);
            this.rateC.TabIndex = 2;
            this.rateC.SelectedIndexChanged += new System.EventHandler(this.rateC_SelectedIndexChanged);
            // 
            // bitsC
            // 
            this.bitsC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitsC.FormattingEnabled = true;
            this.bitsC.Items.AddRange(new object[] {
            "8",
            "16"});
            this.bitsC.Location = new System.Drawing.Point(63, 48);
            this.bitsC.Name = "bitsC";
            this.bitsC.Size = new System.Drawing.Size(84, 21);
            this.bitsC.TabIndex = 3;
            this.bitsC.SelectedIndexChanged += new System.EventHandler(this.bitsC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sample per Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bit per Sample";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. of Bits";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.channelC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rateC);
            this.groupBox1.Controls.Add(this.bitsC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound Quality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Channels";
            // 
            // channelC
            // 
            this.channelC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelC.FormattingEnabled = true;
            this.channelC.Items.AddRange(new object[] {
            "1",
            "2"});
            this.channelC.Location = new System.Drawing.Point(63, 71);
            this.channelC.Name = "channelC";
            this.channelC.Size = new System.Drawing.Size(45, 21);
            this.channelC.TabIndex = 8;
            this.channelC.SelectedIndexChanged += new System.EventHandler(this.channelC_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(8, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 17);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.sizeC);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buffersC);
            this.groupBox2.Location = new System.Drawing.Point(8, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Advanced Send  Options";
            this.groupBox2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Byte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Buffer Size";
            // 
            // sizeC
            // 
            this.sizeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeC.FormattingEnabled = true;
            this.sizeC.Items.AddRange(new object[] {
            "256",
            "512",
            "1024",
            "2048",
            "8192"});
            this.sizeC.Location = new System.Drawing.Point(102, 50);
            this.sizeC.Name = "sizeC";
            this.sizeC.Size = new System.Drawing.Size(69, 21);
            this.sizeC.TabIndex = 12;
            this.sizeC.SelectedIndexChanged += new System.EventHandler(this.sizeC_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of Buffers";
            // 
            // buffersC
            // 
            this.buffersC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buffersC.FormattingEnabled = true;
            this.buffersC.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.buffersC.Location = new System.Drawing.Point(102, 26);
            this.buffersC.Name = "buffersC";
            this.buffersC.Size = new System.Drawing.Size(69, 21);
            this.buffersC.TabIndex = 10;
            this.buffersC.SelectedIndexChanged += new System.EventHandler(this.buffersC_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(24, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "Advanced Options";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Caution:Attributes must be seriallized with the\r\n other end points";
            // 
            // AudioSetting
            // 
            this.AcceptButton = this.SaveBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 169);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audio Setting";
            this.Load += new System.EventHandler(this.AudioSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.ComboBox rateC;
        private System.Windows.Forms.ComboBox bitsC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox channelC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox buffersC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sizeC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}