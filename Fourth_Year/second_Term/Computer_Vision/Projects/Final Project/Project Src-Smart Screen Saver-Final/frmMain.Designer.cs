namespace sss
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnClosePreviewWnd = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.picDetectFaces = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.btnStartPreviewWnd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBarPoll = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tBarFCount = new System.Windows.Forms.TrackBar();
            this.BarAuthebtication = new System.Windows.Forms.ProgressBar();
            this.btnTestScreenSaver = new System.Windows.Forms.Button();
            this.lblRatio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFeatureLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetectFaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarPoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarFCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClosePreviewWnd
            // 
            this.btnClosePreviewWnd.Enabled = false;
            this.btnClosePreviewWnd.Location = new System.Drawing.Point(440, 41);
            this.btnClosePreviewWnd.Name = "btnClosePreviewWnd";
            this.btnClosePreviewWnd.Size = new System.Drawing.Size(129, 28);
            this.btnClosePreviewWnd.TabIndex = 15;
            this.btnClosePreviewWnd.Text = "Close Preview Window";
            this.btnClosePreviewWnd.UseVisualStyleBackColor = true;
            this.btnClosePreviewWnd.Click += new System.EventHandler(this.btnClosePreviewWnd_Click);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(208, 154);
            this.picPreview.TabIndex = 14;
            this.picPreview.TabStop = false;
            // 
            // picDetectFaces
            // 
            this.picDetectFaces.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picDetectFaces.Location = new System.Drawing.Point(226, 12);
            this.picDetectFaces.Name = "picDetectFaces";
            this.picDetectFaces.Size = new System.Drawing.Size(208, 154);
            this.picDetectFaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDetectFaces.TabIndex = 16;
            this.picDetectFaces.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.PollTimer_Tick);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(440, 70);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(129, 28);
            this.btnCreateProfile.TabIndex = 18;
            this.btnCreateProfile.Text = "Create Profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // btnStartPreviewWnd
            // 
            this.btnStartPreviewWnd.Location = new System.Drawing.Point(440, 12);
            this.btnStartPreviewWnd.Name = "btnStartPreviewWnd";
            this.btnStartPreviewWnd.Size = new System.Drawing.Size(129, 28);
            this.btnStartPreviewWnd.TabIndex = 19;
            this.btnStartPreviewWnd.Text = "Start Preview Window";
            this.btnStartPreviewWnd.UseVisualStyleBackColor = true;
            this.btnStartPreviewWnd.Click += new System.EventHandler(this.btnStartPreviewWnd_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Polling Timer (Sec)";
            // 
            // tBarPoll
            // 
            this.tBarPoll.Location = new System.Drawing.Point(104, 194);
            this.tBarPoll.Maximum = 10000;
            this.tBarPoll.Minimum = 100;
            this.tBarPoll.Name = "tBarPoll";
            this.tBarPoll.Size = new System.Drawing.Size(284, 45);
            this.tBarPoll.TabIndex = 10;
            this.tBarPoll.TickFrequency = 100;
            this.tBarPoll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tBarPoll.Value = 2000;
            this.tBarPoll.Scroll += new System.EventHandler(this.tBarPoll_Scroll);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "False Count";
            // 
            // tBarFCount
            // 
            this.tBarFCount.Location = new System.Drawing.Point(104, 223);
            this.tBarFCount.Maximum = 100;
            this.tBarFCount.Minimum = 1;
            this.tBarFCount.Name = "tBarFCount";
            this.tBarFCount.Size = new System.Drawing.Size(284, 45);
            this.tBarFCount.TabIndex = 11;
            this.tBarFCount.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tBarFCount.Value = 10;
            this.tBarFCount.Scroll += new System.EventHandler(this.tBarFCount_Scroll);
            // 
            // BarAuthebtication
            // 
            this.BarAuthebtication.Location = new System.Drawing.Point(86, 172);
            this.BarAuthebtication.Name = "BarAuthebtication";
            this.BarAuthebtication.Size = new System.Drawing.Size(302, 16);
            this.BarAuthebtication.TabIndex = 20;
            // 
            // btnTestScreenSaver
            // 
            this.btnTestScreenSaver.Location = new System.Drawing.Point(440, 99);
            this.btnTestScreenSaver.Name = "btnTestScreenSaver";
            this.btnTestScreenSaver.Size = new System.Drawing.Size(129, 28);
            this.btnTestScreenSaver.TabIndex = 21;
            this.btnTestScreenSaver.Text = "&Test Screen Saver";
            this.btnTestScreenSaver.UseVisualStyleBackColor = true;
            this.btnTestScreenSaver.Click += new System.EventHandler(this.btnTestScreenSaver_Click);
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(402, 173);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(0, 13);
            this.lblRatio.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Authorization";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFeatureLevel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblFeatureLevel
            // 
            this.lblFeatureLevel.Name = "lblFeatureLevel";
            this.lblFeatureLevel.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "10 Frame";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.btnTestScreenSaver);
            this.Controls.Add(this.BarAuthebtication);
            this.Controls.Add(this.btnStartPreviewWnd);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.picDetectFaces);
            this.Controls.Add(this.btnClosePreviewWnd);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.tBarFCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBarPoll);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Screen Saver- By  Ali Hussien Ahmed, Abd El rady  El Agamy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetectFaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarPoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarFCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosePreviewWnd;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.PictureBox picDetectFaces;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Button btnStartPreviewWnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tBarPoll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tBarFCount;
        private System.Windows.Forms.ProgressBar BarAuthebtication;
        private System.Windows.Forms.Button btnTestScreenSaver;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblFeatureLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

