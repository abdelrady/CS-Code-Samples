namespace FloppyStepper
{
    partial class MainForm
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
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.stepperMoveButton1 = new System.Windows.Forms.Button();
            this.stepperMoveButton2 = new System.Windows.Forms.Button();
            this.stepperGroupBox = new System.Windows.Forms.GroupBox();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.addressGroupBox.SuspendLayout();
            this.stepperGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(64, 19);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(52, 20);
            this.adressTextBox.TabIndex = 0;
            this.adressTextBox.Text = "378";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(6, 45);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(110, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply Address";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Controls.Add(this.label1);
            this.addressGroupBox.Controls.Add(this.adressTextBox);
            this.addressGroupBox.Controls.Add(this.applyButton);
            this.addressGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(122, 76);
            this.addressGroupBox.TabIndex = 0;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Parallel Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address:";
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(114, 19);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(48, 20);
            this.delayTextBox.TabIndex = 0;
            this.delayTextBox.Text = "100";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(6, 22);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(102, 13);
            this.delayLabel.TabIndex = 4;
            this.delayLabel.Text = "Delay (milliseconds):";
            // 
            // stepperMoveButton1
            // 
            this.stepperMoveButton1.Location = new System.Drawing.Point(9, 71);
            this.stepperMoveButton1.Name = "stepperMoveButton1";
            this.stepperMoveButton1.Size = new System.Drawing.Size(75, 23);
            this.stepperMoveButton1.TabIndex = 2;
            this.stepperMoveButton1.Text = "Forward";
            this.stepperMoveButton1.UseVisualStyleBackColor = true;
            this.stepperMoveButton1.Click += new System.EventHandler(this.stepperMoveButton1_Click);
            // 
            // stepperMoveButton2
            // 
            this.stepperMoveButton2.Location = new System.Drawing.Point(87, 71);
            this.stepperMoveButton2.Name = "stepperMoveButton2";
            this.stepperMoveButton2.Size = new System.Drawing.Size(75, 23);
            this.stepperMoveButton2.TabIndex = 3;
            this.stepperMoveButton2.Text = "Backward";
            this.stepperMoveButton2.UseVisualStyleBackColor = true;
            this.stepperMoveButton2.Click += new System.EventHandler(this.stepperMoveButton2_Click);
            // 
            // stepperGroupBox
            // 
            this.stepperGroupBox.Controls.Add(this.stepLabel);
            this.stepperGroupBox.Controls.Add(this.stepTextBox);
            this.stepperGroupBox.Controls.Add(this.delayLabel);
            this.stepperGroupBox.Controls.Add(this.stepperMoveButton2);
            this.stepperGroupBox.Controls.Add(this.delayTextBox);
            this.stepperGroupBox.Controls.Add(this.stepperMoveButton1);
            this.stepperGroupBox.Location = new System.Drawing.Point(140, 12);
            this.stepperGroupBox.Name = "stepperGroupBox";
            this.stepperGroupBox.Size = new System.Drawing.Size(169, 100);
            this.stepperGroupBox.TabIndex = 1;
            this.stepperGroupBox.TabStop = false;
            this.stepperGroupBox.Text = "Sepper Motor Control";
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(21, 48);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(87, 13);
            this.stepLabel.TabIndex = 8;
            this.stepLabel.Text = "Number of steps:";
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(114, 45);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(48, 20);
            this.stepTextBox.TabIndex = 1;
            this.stepTextBox.Text = "10";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(9, 99);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(111, 13);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Tag = "";
            this.linkLabel.Text = "By Ashish Derhgawen";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 120);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.stepperGroupBox);
            this.Controls.Add(this.addressGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floppy Stepper Motor Control";
            this.addressGroupBox.ResumeLayout(false);
            this.addressGroupBox.PerformLayout();
            this.stepperGroupBox.ResumeLayout(false);
            this.stepperGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox addressGroupBox;
        private System.Windows.Forms.TextBox delayTextBox;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Button stepperMoveButton1;
        private System.Windows.Forms.Button stepperMoveButton2;
        private System.Windows.Forms.GroupBox stepperGroupBox;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}

