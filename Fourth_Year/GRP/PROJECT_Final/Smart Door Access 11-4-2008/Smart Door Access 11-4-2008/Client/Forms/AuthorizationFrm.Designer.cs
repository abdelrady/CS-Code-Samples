namespace ChatClient.Forms
{
    partial class AuthorizationFrm
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
            this.LblAuthorized = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerFrm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblAuthorized
            // 
            this.LblAuthorized.AutoSize = true;
            this.LblAuthorized.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthorized.ForeColor = System.Drawing.Color.Red;
            this.LblAuthorized.Location = new System.Drawing.Point(136, 225);
            this.LblAuthorized.Name = "LblAuthorized";
            this.LblAuthorized.Size = new System.Drawing.Size(161, 33);
            this.LblAuthorized.TabIndex = 0;
            this.LblAuthorized.Text = "You Are ....";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 800;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerFrm
            // 
            this.timerFrm.Enabled = true;
            this.timerFrm.Interval = 370;
            this.timerFrm.Tick += new System.EventHandler(this.timerFrm_Tick);
            // 
            // AuthorizationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 512);
            this.Controls.Add(this.LblAuthorized);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAuthorized;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerFrm;
    }
}