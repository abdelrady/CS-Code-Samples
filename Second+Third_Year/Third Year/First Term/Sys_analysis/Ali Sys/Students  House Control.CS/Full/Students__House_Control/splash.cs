using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class splash : System.Windows.Forms.Form
    {

        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private float real;
        private System.Windows.Forms.Timer timer1;

        public splash(bool Show)
        {
            real = 0.0F;
            InitializeComponent();
            bool flag = !Show;
            if (!flag)
            {
                progressBar1.Visible = false;
                label1.Visible = false;
            }
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.splash));
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            timer1.Interval = 150;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            progressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            progressBar1.Location = new System.Drawing.Point(12, 216);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(209, 10);
            progressBar1.Step = 20;
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(4, 182);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(228, 16);
            label1.TabIndex = 1;
            label1.Text = "Connecting To The Database  Please Wait . . .";
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(28, 161);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 15);
            label3.TabIndex = 3;
            label3.Text = "UNREGESTRED COPY TO";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(172, 163);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 13);
            label4.TabIndex = 4;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            label2.Font = new System.Drawing.Font("Book Antiqua", 24.0F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            label2.ForeColor = System.Drawing.Color.Transparent;
            label2.Image = (System.Drawing.Image)componentResourceManager.GetObject("label2.Image");
            label2.Location = new System.Drawing.Point(0, 201);
            label2.Name = "label2";
            label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label2.Size = new System.Drawing.Size(528, 37);
            label2.TabIndex = 26;
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            BackgroundImage = (System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(528, 238);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "splash";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "splash";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(splash_FormClosing);
            Load += new System.EventHandler(splash_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private void splash_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            // trial
        }

        private void splash_Load(object sender, System.EventArgs e)
        {
            // trial
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            bool flag = real >= 1.0F;
            if (!flag)
            {
                real += 0.1F;
                progressBar1.Value += 10;
                flag = progressBar1.Value != 30;
                if (!flag)
                    label1.Text = "Extracting Data ... ";
                flag = progressBar1.Value != 60;
                if (!flag)
                    label1.Text = "Inittilizing Components ... ";
                flag = progressBar1.Value != 90;
                if (!flag)
                    label1.Text = "Finishing ...";
            }
            else
            {
                timer1.Stop();
                base.Dispose();
            }
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class splash

}

