namespace WindowsApplication1
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
            this.barCodeCtrl1 = new DSBarCode.BarCodeCtrl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barCodeCtrl1
            // 
            this.barCodeCtrl1.BarCode = "1234567890";
            this.barCodeCtrl1.BarCodeHeight = 50;
            this.barCodeCtrl1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barCodeCtrl1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.barCodeCtrl1.HeaderText = "BarCode Demo";
            this.barCodeCtrl1.LeftMargin = 10;
            this.barCodeCtrl1.Location = new System.Drawing.Point(5, 12);
            this.barCodeCtrl1.Name = "barCodeCtrl1";
            this.barCodeCtrl1.ShowFooter = false;
            this.barCodeCtrl1.ShowHeader = false;
            this.barCodeCtrl1.Size = new System.Drawing.Size(777, 70);
            this.barCodeCtrl1.TabIndex = 0;
            this.barCodeCtrl1.TopMargin = 10;
            this.barCodeCtrl1.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Center;
            this.barCodeCtrl1.Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Ali Hussien Ahmed";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "String";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barCodeCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarCode Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSBarCode.BarCodeCtrl barCodeCtrl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

