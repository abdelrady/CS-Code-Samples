namespace play_sound
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
            this.loadB = new System.Windows.Forms.Button();
            this.playB = new System.Windows.Forms.Button();
            this.pauseB = new System.Windows.Forms.Button();
            this.stopB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.trkSound = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSound)).BeginInit();
            this.SuspendLayout();
            // 
            // loadB
            // 
            this.loadB.Location = new System.Drawing.Point(2, 13);
            this.loadB.Name = "loadB";
            this.loadB.Size = new System.Drawing.Size(60, 31);
            this.loadB.TabIndex = 0;
            this.loadB.Text = "Load";
            this.loadB.UseVisualStyleBackColor = true;
            this.loadB.Click += new System.EventHandler(this.loadB_Click);
            // 
            // playB
            // 
            this.playB.Location = new System.Drawing.Point(62, 13);
            this.playB.Name = "playB";
            this.playB.Size = new System.Drawing.Size(60, 31);
            this.playB.TabIndex = 1;
            this.playB.Text = "Play";
            this.playB.UseVisualStyleBackColor = true;
            this.playB.Click += new System.EventHandler(this.playB_Click);
            // 
            // pauseB
            // 
            this.pauseB.Location = new System.Drawing.Point(122, 13);
            this.pauseB.Name = "pauseB";
            this.pauseB.Size = new System.Drawing.Size(60, 31);
            this.pauseB.TabIndex = 2;
            this.pauseB.Text = "Pause";
            this.pauseB.UseVisualStyleBackColor = true;
            this.pauseB.Click += new System.EventHandler(this.pauseB_Click);
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(182, 13);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(60, 31);
            this.stopB.TabIndex = 3;
            this.stopB.Text = "Stop";
            this.stopB.UseVisualStyleBackColor = true;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadB);
            this.groupBox1.Controls.Add(this.stopB);
            this.groupBox1.Controls.Add(this.playB);
            this.groupBox1.Controls.Add(this.pauseB);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.Location = new System.Drawing.Point(263, 94);
            this.trackBar_volume.Maximum = 0;
            this.trackBar_volume.Minimum = -3000;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(104, 45);
            this.trackBar_volume.TabIndex = 5;
            this.trackBar_volume.TickFrequency = 200;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "position";
            // 
            // trkSound
            // 
            this.trkSound.AutoSize = false;
            this.trkSound.Location = new System.Drawing.Point(-1, 49);
            this.trkSound.Name = "trkSound";
            this.trkSound.Size = new System.Drawing.Size(368, 30);
            this.trkSound.TabIndex = 13;
            this.trkSound.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkSound.Scroll += new System.EventHandler(this.trkSound_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "file name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trkSound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PLAY SOUND";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadB;
        private System.Windows.Forms.Button playB;
        private System.Windows.Forms.Button pauseB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkSound;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

