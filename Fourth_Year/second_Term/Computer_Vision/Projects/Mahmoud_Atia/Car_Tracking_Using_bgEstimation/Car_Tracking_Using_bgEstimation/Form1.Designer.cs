namespace Car_Tracking_Using_bgEstimation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputVideolabel = new System.Windows.Forms.Label();
            this.InputVideoPanel = new System.Windows.Forms.Panel();
            this.OutputVideolabel = new System.Windows.Forms.Label();
            this.OutputVideoPanel = new System.Windows.Forms.Panel();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miCloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.Video = new System.Windows.Forms.ToolStripMenuItem();
            this.miFraming = new System.Windows.Forms.ToolStripMenuItem();
            this.miBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.miThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.miGenerateOutVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteTempFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miProject = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BackgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ThresholdedVideopanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InputVideolabel
            // 
            this.InputVideolabel.AutoSize = true;
            this.InputVideolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputVideolabel.Location = new System.Drawing.Point(12, 26);
            this.InputVideolabel.Name = "InputVideolabel";
            this.InputVideolabel.Size = new System.Drawing.Size(81, 13);
            this.InputVideolabel.TabIndex = 10;
            this.InputVideolabel.Text = "Input Video : ";
            // 
            // InputVideoPanel
            // 
            this.InputVideoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InputVideoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputVideoPanel.Location = new System.Drawing.Point(17, 43);
            this.InputVideoPanel.Name = "InputVideoPanel";
            this.InputVideoPanel.Size = new System.Drawing.Size(179, 171);
            this.InputVideoPanel.TabIndex = 7;
            // 
            // OutputVideolabel
            // 
            this.OutputVideolabel.AutoSize = true;
            this.OutputVideolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputVideolabel.Location = new System.Drawing.Point(424, 26);
            this.OutputVideolabel.Name = "OutputVideolabel";
            this.OutputVideolabel.Size = new System.Drawing.Size(111, 13);
            this.OutputVideolabel.TabIndex = 15;
            this.OutputVideolabel.Text = "Thresholded Video";
            // 
            // OutputVideoPanel
            // 
            this.OutputVideoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OutputVideoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputVideoPanel.Location = new System.Drawing.Point(575, 43);
            this.OutputVideoPanel.Name = "OutputVideoPanel";
            this.OutputVideoPanel.Size = new System.Drawing.Size(179, 171);
            this.OutputVideoPanel.TabIndex = 12;
            // 
            // menu1
            // 
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Video,
            this.Delete,
            this.miAbout});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(766, 24);
            this.menu1.TabIndex = 17;
            this.menu1.Text = "menu1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenFile,
            this.miCloseForm});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(35, 20);
            this.File.Text = "&File";
            // 
            // miOpenFile
            // 
            this.miOpenFile.Name = "miOpenFile";
            this.miOpenFile.Size = new System.Drawing.Size(100, 22);
            this.miOpenFile.Text = "&Open";
            this.miOpenFile.Click += new System.EventHandler(this.miOpenFile_Click);
            // 
            // miCloseForm
            // 
            this.miCloseForm.Name = "miCloseForm";
            this.miCloseForm.Size = new System.Drawing.Size(100, 22);
            this.miCloseForm.Text = "&Exit";
            this.miCloseForm.Click += new System.EventHandler(this.miCloseForm_Click);
            // 
            // Video
            // 
            this.Video.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFraming,
            this.miBackground,
            this.miThreshold,
            this.miGenerateOutVideo});
            this.Video.Enabled = false;
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(45, 20);
            this.Video.Text = "&Video";
            // 
            // miFraming
            // 
            this.miFraming.Name = "miFraming";
            this.miFraming.Size = new System.Drawing.Size(169, 22);
            this.miFraming.Text = "&Framing";
            this.miFraming.Click += new System.EventHandler(this.miFraming_Click);
            // 
            // miBackground
            // 
            this.miBackground.Enabled = false;
            this.miBackground.Name = "miBackground";
            this.miBackground.Size = new System.Drawing.Size(169, 22);
            this.miBackground.Text = "&Extract Background";
            this.miBackground.Click += new System.EventHandler(this.miBackground_Click);
            // 
            // miThreshold
            // 
            this.miThreshold.Enabled = false;
            this.miThreshold.Name = "miThreshold";
            this.miThreshold.Size = new System.Drawing.Size(169, 22);
            this.miThreshold.Text = "&Thresholding";
            this.miThreshold.Click += new System.EventHandler(this.miThreshold_Click);
            // 
            // miGenerateOutVideo
            // 
            this.miGenerateOutVideo.Enabled = false;
            this.miGenerateOutVideo.Name = "miGenerateOutVideo";
            this.miGenerateOutVideo.Size = new System.Drawing.Size(169, 22);
            this.miGenerateOutVideo.Text = "Generate Out Video";
            this.miGenerateOutVideo.Click += new System.EventHandler(this.miGenerateOutVideo_Click);
            // 
            // Delete
            // 
            this.Delete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeleteTempFiles});
            this.Delete.Enabled = false;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(50, 20);
            this.Delete.Text = "&Delete";
            // 
            // miDeleteTempFiles
            // 
            this.miDeleteTempFiles.Name = "miDeleteTempFiles";
            this.miDeleteTempFiles.Size = new System.Drawing.Size(158, 22);
            this.miDeleteTempFiles.Text = "&Delete Temp Files";
            this.miDeleteTempFiles.Click += new System.EventHandler(this.miDeleteTempFiles_Click);
            // 
            // miAbout
            // 
            this.miAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProject});
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(48, 20);
            this.miAbout.Text = "&About";
            // 
            // miProject
            // 
            this.miProject.Name = "miProject";
            this.miProject.Size = new System.Drawing.Size(108, 22);
            this.miProject.Text = "P&roject";
            this.miProject.Click += new System.EventHandler(this.miProject_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(258, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(275, 20);
            this.progressBar1.TabIndex = 19;
            // 
            // BackgroundPictureBox
            // 
            this.BackgroundPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPictureBox.Location = new System.Drawing.Point(203, 43);
            this.BackgroundPictureBox.Name = "BackgroundPictureBox";
            this.BackgroundPictureBox.Size = new System.Drawing.Size(179, 171);
            this.BackgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundPictureBox.TabIndex = 20;
            this.BackgroundPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Background";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Output Video";
            // 
            // ThresholdedVideopanel
            // 
            this.ThresholdedVideopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ThresholdedVideopanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThresholdedVideopanel.Location = new System.Drawing.Point(389, 43);
            this.ThresholdedVideopanel.Name = "ThresholdedVideopanel";
            this.ThresholdedVideopanel.Size = new System.Drawing.Size(179, 171);
            this.ThresholdedVideopanel.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tracking Car Using Background Estimation ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "By Eng : Mahmoud Mohamed Atia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(539, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 250);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThresholdedVideopanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackgroundPictureBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.OutputVideolabel);
            this.Controls.Add(this.OutputVideoPanel);
            this.Controls.Add(this.InputVideolabel);
            this.Controls.Add(this.InputVideoPanel);
            this.Controls.Add(this.menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu1;
            this.MaximumSize = new System.Drawing.Size(774, 281);
            this.MinimumSize = new System.Drawing.Size(774, 281);
            this.Name = "Form1";
            this.Text = "Tracking Car Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputVideolabel;
        private System.Windows.Forms.Panel InputVideoPanel;
        private System.Windows.Forms.Label OutputVideolabel;
        private System.Windows.Forms.Panel OutputVideoPanel;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem miOpenFile;
        private System.Windows.Forms.ToolStripMenuItem miCloseForm;
        private System.Windows.Forms.ToolStripMenuItem Video;
        private System.Windows.Forms.ToolStripMenuItem miBackground;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miProject;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox BackgroundPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ThresholdedVideopanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem miThreshold;
        private System.Windows.Forms.ToolStripMenuItem miGenerateOutVideo;
        private System.Windows.Forms.ToolStripMenuItem miFraming;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem miDeleteTempFiles;

    }
}

