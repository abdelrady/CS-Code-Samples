namespace RDB_test.myControls
{
    partial class userLoginControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userLoginControl));
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loginRadioButton = new System.Windows.Forms.RadioButton();
            this.newAccountRadioButton = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.forgotPasswordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AdminUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sDASDBDataSet = new RDB_test.myData.SDASDBDataSet();
            this.adminUsersTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.AdminUsersTableAdapter();
            this.titleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminUsersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nameLabel.Location = new System.Drawing.Point(30, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.passwordLabel.Location = new System.Drawing.Point(3, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 16);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(89, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 21);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "ali";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(89, 69);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(203, 21);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "ali";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.cancelButton.BackgroundImage = global::RDB_test.Properties.Resources.button_smallBlue_search;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(217, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 35);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.BackColor = System.Drawing.Color.SteelBlue;
            this.okButton.BackgroundImage = global::RDB_test.Properties.Resources.button_smallBlue_search;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(136, 96);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 35);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.titleBarPanel.Controls.Add(this.forgotPasswordButton);
            this.titleBarPanel.Controls.Add(this.titleLabel);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(297, 24);
            this.titleBarPanel.TabIndex = 9;
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forgotPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forgotPasswordButton.BackgroundImage")));
            this.forgotPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forgotPasswordButton.FlatAppearance.BorderSize = 0;
            this.forgotPasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.forgotPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.forgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPasswordButton.Location = new System.Drawing.Point(276, 3);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(16, 16);
            this.forgotPasswordButton.TabIndex = 11;
            this.forgotPasswordButton.TabStop = false;
            this.forgotPasswordToolTip.SetToolTip(this.forgotPasswordButton, "Click here if you forgot your password");
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleLabel.Location = new System.Drawing.Point(6, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(206, 16);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Please fill out your User Info!";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // loginRadioButton
            // 
            this.loginRadioButton.AutoSize = true;
            this.loginRadioButton.Location = new System.Drawing.Point(6, 96);
            this.loginRadioButton.Name = "loginRadioButton";
            this.loginRadioButton.Size = new System.Drawing.Size(50, 17);
            this.loginRadioButton.TabIndex = 10;
            this.loginRadioButton.TabStop = true;
            this.loginRadioButton.Text = "Login";
            this.loginRadioButton.UseVisualStyleBackColor = true;
            // 
            // newAccountRadioButton
            // 
            this.newAccountRadioButton.AutoSize = true;
            this.newAccountRadioButton.Location = new System.Drawing.Point(6, 114);
            this.newAccountRadioButton.Name = "newAccountRadioButton";
            this.newAccountRadioButton.Size = new System.Drawing.Size(88, 17);
            this.newAccountRadioButton.TabIndex = 11;
            this.newAccountRadioButton.TabStop = true;
            this.newAccountRadioButton.Text = "New Account";
            this.newAccountRadioButton.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // forgotPasswordToolTip
            // 
            this.forgotPasswordToolTip.IsBalloon = true;
            // 
            // AdminUsersBindingSource1
            // 
            this.AdminUsersBindingSource1.DataMember = "AdminUsers";
            this.AdminUsersBindingSource1.DataSource = this.sDASDBDataSet;
            // 
            // sDASDBDataSet
            // 
            this.sDASDBDataSet.DataSetName = "SDASDBDataSet";
            this.sDASDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminUsersTableAdapter
            // 
            this.adminUsersTableAdapter.ClearBeforeFill = true;
            // 
            // userLoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.newAccountRadioButton);
            this.Controls.Add(this.loginRadioButton);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "userLoginControl";
            this.Size = new System.Drawing.Size(297, 143);
            this.Load += new System.EventHandler(this.userLoginControl_Load);
            this.ParentChanged += new System.EventHandler(this.userLoginControl_ParentChanged);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminUsersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton loginRadioButton;
        private System.Windows.Forms.RadioButton newAccountRadioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolTip forgotPasswordToolTip;
        private System.Windows.Forms.BindingSource AdminUsersBindingSource1;
        //private RDB_test.myData.SDASDBDataSet1TableAdapters.AdminUsersTableAdapter adminUsersTableAdapter1;
        private RDB_test.myData.SDASDBDataSet sDASDBDataSet;
        private RDB_test.myData.SDASDBDataSetTableAdapters.AdminUsersTableAdapter adminUsersTableAdapter;
    }
}
