namespace RDB_test.myControls {
    partial class LogControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.LogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sDASDBDataSet = new RDB_test.myData.SDASDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripLabel = new System.Windows.Forms.ToolStripDropDownButton();
            this.byFirstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.doorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.entertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.LogsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingNavigator)).BeginInit();
            this.LogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogBindingNavigator
            // 
            this.LogBindingNavigator.AddNewItem = null;
            this.LogBindingNavigator.BindingSource = this.LogBindingSource1;
            this.LogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.LogBindingNavigator.DeleteItem = null;
            this.LogBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.LogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.findToolStripLabel,
            this.findToolStripTextBox,
            this.findToolStripButton,
            this.toolStripSeparator2,
            this.showAllToolStripButton,
            this.toolStripButton1});
            this.LogBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.LogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.LogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.LogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.LogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.LogBindingNavigator.Name = "LogBindingNavigator";
            this.LogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.LogBindingNavigator.Size = new System.Drawing.Size(761, 25);
            this.LogBindingNavigator.TabIndex = 0;
            this.LogBindingNavigator.Text = "bindingNavigator1";
            // 
            // LogBindingSource1
            // 
            this.LogBindingSource1.AllowNew = false;
            this.LogBindingSource1.DataMember = "Logs";
            this.LogBindingSource1.DataSource = this.sDASDBDataSet;
            this.LogBindingSource1.Filter = "";
            // 
            // sDASDBDataSet
            // 
            this.sDASDBDataSet.DataSetName = "SDASDBDataSet";
            this.sDASDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // findToolStripLabel
            // 
            this.findToolStripLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byFirstNameToolStripMenuItem,
            this.lastNameToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.stateToolStripMenuItem});
            this.findToolStripLabel.Name = "findToolStripLabel";
            this.findToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.findToolStripLabel.Text = "Find:";
            this.findToolStripLabel.ToolTipText = "Choose a column to search from";
            // 
            // byFirstNameToolStripMenuItem
            // 
            this.byFirstNameToolStripMenuItem.Name = "byFirstNameToolStripMenuItem";
            this.byFirstNameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.byFirstNameToolStripMenuItem.Tag = "Enter_Time";
            this.byFirstNameToolStripMenuItem.Text = "Enter Time";
            this.byFirstNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.lastNameToolStripMenuItem.Tag = "ID";
            this.lastNameToolStripMenuItem.Text = "ID";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cityToolStripMenuItem.Tag = "DoorNumber";
            this.cityToolStripMenuItem.Text = "Door Number";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.stateToolStripMenuItem.Tag = "Allowed";
            this.stateToolStripMenuItem.Text = "Allowed";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // findToolStripTextBox
            // 
            this.findToolStripTextBox.Name = "findToolStripTextBox";
            this.findToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.findToolStripTextBox.ToolTipText = "Enter text to search";
            // 
            // findToolStripButton
            // 
            this.findToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.findToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findToolStripButton.Image = global::RDB_test.Properties.Resources.icon_magnifyingGlass;
            this.findToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findToolStripButton.Name = "findToolStripButton";
            this.findToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.findToolStripButton.ToolTipText = "Click to find";
            this.findToolStripButton.Click += new System.EventHandler(this.findToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // showAllToolStripButton
            // 
            this.showAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("showAllToolStripButton.Image")));
            this.showAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAllToolStripButton.Name = "showAllToolStripButton";
            this.showAllToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.showAllToolStripButton.Text = "&Show All";
            this.showAllToolStripButton.Click += new System.EventHandler(this.showAllToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton1.Text = "&Refresh Data";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // doorName
            // 
            this.doorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.doorName.DataPropertyName = "doorName";
            this.doorName.Frozen = true;
            this.doorName.HeaderText = "Door Name";
            this.doorName.Name = "doorName";
            this.doorName.ReadOnly = true;
            this.doorName.Width = 167;
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AllowUserToOrderColumns = true;
            this.UsersDataGridView.AutoGenerateColumns = false;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entertimeDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.doorNumberDataGridViewTextBoxColumn,
            this.allowedDataGridViewCheckBoxColumn,
            this.doorNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.UsersDataGridView.DataSource = this.LogBindingSource1;
            this.UsersDataGridView.GridColor = System.Drawing.SystemColors.ControlText;
            this.UsersDataGridView.Location = new System.Drawing.Point(1, 25);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.UsersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGridView.Size = new System.Drawing.Size(757, 392);
            this.UsersDataGridView.TabIndex = 26;
            // 
            // entertimeDataGridViewTextBoxColumn
            // 
            this.entertimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.entertimeDataGridViewTextBoxColumn.DataPropertyName = "Enter_time";
            this.entertimeDataGridViewTextBoxColumn.HeaderText = "Enter Time";
            this.entertimeDataGridViewTextBoxColumn.Name = "entertimeDataGridViewTextBoxColumn";
            this.entertimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorNumberDataGridViewTextBoxColumn
            // 
            this.doorNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doorNumberDataGridViewTextBoxColumn.DataPropertyName = "doorNumber";
            this.doorNumberDataGridViewTextBoxColumn.HeaderText = "door Number";
            this.doorNumberDataGridViewTextBoxColumn.Name = "doorNumberDataGridViewTextBoxColumn";
            this.doorNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allowedDataGridViewCheckBoxColumn
            // 
            this.allowedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allowedDataGridViewCheckBoxColumn.DataPropertyName = "allowed";
            this.allowedDataGridViewCheckBoxColumn.HeaderText = "Allowed";
            this.allowedDataGridViewCheckBoxColumn.Name = "allowedDataGridViewCheckBoxColumn";
            this.allowedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // doorNameDataGridViewTextBoxColumn
            // 
            this.doorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doorNameDataGridViewTextBoxColumn.DataPropertyName = "doorName";
            this.doorNameDataGridViewTextBoxColumn.HeaderText = "Door Name";
            this.doorNameDataGridViewTextBoxColumn.Name = "doorNameDataGridViewTextBoxColumn";
            this.doorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // LogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.LogBindingNavigator);
            this.Name = "LogControl";
            this.Size = new System.Drawing.Size(761, 425);
            this.Load += new System.EventHandler(this.employeeControl_Load);
            this.ParentChanged += new System.EventHandler(this.LogControl_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingNavigator)).EndInit();
            this.LogBindingNavigator.ResumeLayout(false);
            this.LogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator LogBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton showAllToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton findToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem byFirstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.BindingSource LogBindingSource1;
        private RDB_test.myData.SDASDBDataSet sDASDBDataSet;
        private RDB_test.myData.SDASDBDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorName;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;

    }
}
