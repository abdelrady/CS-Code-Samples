namespace SmartDoor
{
    partial class VideoFrm
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
            this.PicBImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barQuality = new System.Windows.Forms.TrackBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Requstedlbl = new System.Windows.Forms.Label();
            this.LBL_Received = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barQuality)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBImage
            // 
            this.PicBImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBImage.BackColor = System.Drawing.SystemColors.GrayText;
            this.PicBImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBImage.Location = new System.Drawing.Point(11, 11);
            this.PicBImage.Name = "PicBImage";
            this.PicBImage.Size = new System.Drawing.Size(272, 207);
            this.PicBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBImage.TabIndex = 3;
            this.PicBImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Frame Quality";
            // 
            // barQuality
            // 
            this.barQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.barQuality.Location = new System.Drawing.Point(92, 230);
            this.barQuality.Maximum = 100;
            this.barQuality.Name = "barQuality";
            this.barQuality.Size = new System.Drawing.Size(195, 42);
            this.barQuality.TabIndex = 11;
            this.barQuality.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barQuality.Value = 10;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(289, 98);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(89, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartMonitor.Enabled = false;
            this.btnStartMonitor.Location = new System.Drawing.Point(289, 122);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(89, 23);
            this.btnStartMonitor.TabIndex = 9;
            this.btnStartMonitor.Text = "&Resume";
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(290, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source";
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Desktop";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 49);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Camera";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Requstedlbl
            // 
            this.Requstedlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Requstedlbl.AutoSize = true;
            this.Requstedlbl.Location = new System.Drawing.Point(297, 180);
            this.Requstedlbl.Name = "Requstedlbl";
            this.Requstedlbl.Size = new System.Drawing.Size(0, 13);
            this.Requstedlbl.TabIndex = 13;
            // 
            // LBL_Received
            // 
            this.LBL_Received.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Received.AutoSize = true;
            this.LBL_Received.Location = new System.Drawing.Point(297, 206);
            this.LBL_Received.Name = "LBL_Received";
            this.LBL_Received.Size = new System.Drawing.Size(0, 13);
            this.LBL_Received.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(289, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Enable control";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VideoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBL_Received);
            this.Controls.Add(this.Requstedlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barQuality);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStartMonitor);
            this.Controls.Add(this.PicBImage);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(378, 300);
            this.Name = "VideoFrm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PicBImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barQuality)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStartMonitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label Requstedlbl;
        private System.Windows.Forms.Label LBL_Received;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TrackBar barQuality;
    }
}