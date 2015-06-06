namespace Client_s_.Classes
{
    partial class DownloadGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadGUI));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.BTNDownload = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FilenameLBL = new System.Windows.Forms.Label();
            this.sizeLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientNameLBL = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "doc.ico");
            this.imageList.Images.SetKeyName(1, "rar.ico");
            this.imageList.Images.SetKeyName(2, "txt.ico");
            this.imageList.Images.SetKeyName(3, "void.ico");
            this.imageList.Images.SetKeyName(4, "xls.ico");
            this.imageList.Images.SetKeyName(5, "mp3.ico");
            this.imageList.Images.SetKeyName(6, "pdf.ico");
            this.imageList.Images.SetKeyName(7, "ppt.ico");
            this.imageList.Images.SetKeyName(8, "avi.ico");
            // 
            // BTNDownload
            // 
            this.BTNDownload.Location = new System.Drawing.Point(245, 135);
            this.BTNDownload.Name = "BTNDownload";
            this.BTNDownload.Size = new System.Drawing.Size(81, 23);
            this.BTNDownload.TabIndex = 0;
            this.BTNDownload.Text = "&Download";
            this.BTNDownload.UseVisualStyleBackColor = true;
            this.BTNDownload.Click += new System.EventHandler(this.BTNDownload_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(163, 135);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(81, 23);
            this.BTNCancel.TabIndex = 1;
            this.BTNCancel.Text = "&Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 2);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(14, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FilenameLBL
            // 
            this.FilenameLBL.AutoSize = true;
            this.FilenameLBL.Location = new System.Drawing.Point(66, 54);
            this.FilenameLBL.Name = "FilenameLBL";
            this.FilenameLBL.Size = new System.Drawing.Size(35, 13);
            this.FilenameLBL.TabIndex = 4;
            this.FilenameLBL.Text = "label1";
            // 
            // sizeLBL
            // 
            this.sizeLBL.AutoSize = true;
            this.sizeLBL.Location = new System.Drawing.Point(66, 71);
            this.sizeLBL.Name = "sizeLBL";
            this.sizeLBL.Size = new System.Drawing.Size(35, 13);
            this.sizeLBL.TabIndex = 5;
            this.sizeLBL.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do you want to receive this file from   ";
            // 
            // ClientNameLBL
            // 
            this.ClientNameLBL.AutoSize = true;
            this.ClientNameLBL.Location = new System.Drawing.Point(203, 22);
            this.ClientNameLBL.Name = "ClientNameLBL";
            this.ClientNameLBL.Size = new System.Drawing.Size(57, 13);
            this.ClientNameLBL.TabIndex = 7;
            this.ClientNameLBL.Text = "-NAME  - ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click Download to browse destination";
            // 
            // DownloadGUI
            // 
            this.AcceptButton = this.BTNDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(338, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientNameLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeLBL);
            this.Controls.Add(this.FilenameLBL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Download";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button BTNDownload;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label FilenameLBL;
        private System.Windows.Forms.Label sizeLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ClientNameLBL;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
    }
}