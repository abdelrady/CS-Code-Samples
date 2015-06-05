namespace WindowsApplication3
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
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblIPS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(43, 91);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(35, 13);
            this.lblThreads.TabIndex = 0;
            this.lblThreads.Text = "label1";
            // 
            // lblIPS
            // 
            this.lblIPS.AutoSize = true;
            this.lblIPS.Location = new System.Drawing.Point(43, 48);
            this.lblIPS.Name = "lblIPS";
            this.lblIPS.Size = new System.Drawing.Size(35, 13);
            this.lblIPS.TabIndex = 1;
            this.lblIPS.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 132);
            this.Controls.Add(this.lblIPS);
            this.Controls.Add(this.lblThreads);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label lblIPS;
    }
}

