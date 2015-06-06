namespace MovieShow
{
    partial class Form5
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
            this.subtitlebox = new System.Windows.Forms.ListBox();
            this.Notext = new System.Windows.Forms.Timer(this.components);
            this.Showtext = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // subtitlebox
            // 
            this.subtitlebox.BackColor = System.Drawing.SystemColors.MenuText;
            this.subtitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitlebox.ForeColor = System.Drawing.Color.Lime;
            this.subtitlebox.FormattingEnabled = true;
            this.subtitlebox.ItemHeight = 20;
            this.subtitlebox.Location = new System.Drawing.Point(0, 0);
            this.subtitlebox.Name = "subtitlebox";
            this.subtitlebox.Size = new System.Drawing.Size(456, 104);
            this.subtitlebox.TabIndex = 0;
            // 
            // Notext
            // 
            this.Notext.Tick += new System.EventHandler(this.Notext_Tick);
            // 
            // Showtext
            // 
            this.Showtext.Tick += new System.EventHandler(this.Showtext_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 96);
            this.Controls.Add(this.subtitlebox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.SizeChanged += new System.EventHandler(this.Form5_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox subtitlebox;
        private System.Windows.Forms.Timer Notext;
        private System.Windows.Forms.Timer Showtext;
    }
}