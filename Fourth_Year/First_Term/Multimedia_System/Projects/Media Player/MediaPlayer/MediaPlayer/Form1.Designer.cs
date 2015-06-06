namespace MediaPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeB = new System.Windows.Forms.Button();
            this.ofl1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playB = new System.Windows.Forms.Button();
            this.fullB = new System.Windows.Forms.Button();
            this.stopB = new System.Windows.Forms.Button();
            this.openB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(252, 53);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(58, 27);
            this.closeB.TabIndex = 1;
            this.closeB.Text = "Close";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // ofl1
            // 
            this.ofl1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listB
            // 
            this.listB.Location = new System.Drawing.Point(134, 53);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(58, 27);
            this.listB.TabIndex = 4;
            this.listB.Text = " PlayList";
            this.listB.UseVisualStyleBackColor = true;
            this.listB.Click += new System.EventHandler(this.listB_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 386);
            this.panel1.TabIndex = 6;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // playB
            // 
            this.playB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playB.Location = new System.Drawing.Point(9, 51);
            this.playB.Name = "playB";
            this.playB.Size = new System.Drawing.Size(31, 30);
            this.playB.TabIndex = 0;
            this.playB.Text = ">";
            this.playB.UseVisualStyleBackColor = true;
            this.playB.Click += new System.EventHandler(this.playB_Click);
            // 
            // fullB
            // 
            this.fullB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullB.Location = new System.Drawing.Point(192, 53);
            this.fullB.Name = "fullB";
            this.fullB.Size = new System.Drawing.Size(58, 27);
            this.fullB.TabIndex = 1;
            this.fullB.Text = "Full screen";
            this.fullB.UseVisualStyleBackColor = true;
            this.fullB.Click += new System.EventHandler(this.fullB_Click);
            // 
            // stopB
            // 
            this.stopB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopB.Location = new System.Drawing.Point(41, 51);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(31, 30);
            this.stopB.TabIndex = 2;
            this.stopB.Text = "[]";
            this.stopB.UseVisualStyleBackColor = true;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // openB
            // 
            this.openB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openB.Location = new System.Drawing.Point(73, 51);
            this.openB.Name = "openB";
            this.openB.Size = new System.Drawing.Size(57, 30);
            this.openB.TabIndex = 3;
            this.openB.Text = "Open";
            this.openB.UseVisualStyleBackColor = true;
            this.openB.Click += new System.EventHandler(this.openB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.openB);
            this.groupBox1.Controls.Add(this.listB);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.stopB);
            this.groupBox1.Controls.Add(this.fullB);
            this.groupBox1.Controls.Add(this.playB);
            this.groupBox1.Controls.Add(this.closeB);
            this.groupBox1.Location = new System.Drawing.Point(-5, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Resize += new System.EventHandler(this.groupBox1_Resize);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "12";
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar2.AutoSize = false;
            this.trackBar2.LargeChange = 0;
            this.trackBar2.Location = new System.Drawing.Point(381, 51);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 25);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(-1, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(476, 36);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(479, -3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 485);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 489);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player By Mohammed Naggar";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.OpenFileDialog ofl1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button listB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playB;
        private System.Windows.Forms.Button fullB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.Button openB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox listBox1;
    }
}

