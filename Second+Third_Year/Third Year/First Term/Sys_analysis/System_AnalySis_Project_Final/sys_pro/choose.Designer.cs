namespace WindowsApplication1
{
    partial class choose
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coarse_f = new System.Windows.Forms.Button();
            this.student_f = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coarse_f);
            this.groupBox1.Controls.Add(this.student_f);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // coarse_f
            // 
            this.coarse_f.BackgroundImage = global::WindowsApplication1.Properties.Resources.myCustomButton;
            this.coarse_f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coarse_f.Location = new System.Drawing.Point(306, 98);
            this.coarse_f.Name = "coarse_f";
            this.coarse_f.Size = new System.Drawing.Size(70, 35);
            this.coarse_f.TabIndex = 14;
            this.coarse_f.Text = "Coarses";
            this.coarse_f.Click += new System.EventHandler(this.coarse_f_Click_1);
            // 
            // student_f
            // 
            this.student_f.BackgroundImage = global::WindowsApplication1.Properties.Resources.myCustomButton;
            this.student_f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_f.Location = new System.Drawing.Point(32, 100);
            this.student_f.Name = "student_f";
            this.student_f.Size = new System.Drawing.Size(70, 35);
            this.student_f.TabIndex = 13;
            this.student_f.Text = "&Students";
            this.student_f.Click += new System.EventHandler(this.student_f_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 80);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please choose the table you want to connect to ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Name = "choose";
            this.Size = new System.Drawing.Size(408, 145);
            this.Load += new System.EventHandler(this.choose_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button coarse_f;
        private System.Windows.Forms.Button student_f;
        private System.Windows.Forms.Label label1;

    }
}
