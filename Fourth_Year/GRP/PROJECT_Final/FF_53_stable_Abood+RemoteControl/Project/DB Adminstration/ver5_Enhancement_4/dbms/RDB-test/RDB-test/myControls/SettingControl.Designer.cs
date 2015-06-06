namespace RDB_test.myControls {
    partial class SettingControl
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.SettingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sDASDBDataSet = new RDB_test.myData.SDASDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.peopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripLabel = new System.Windows.Forms.ToolStripDropDownButton();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.serverSettingsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.ServerSettingsTableAdapter();
            this.SettingDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingNavigator)).BeginInit();
            this.UsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersBindingNavigator
            // 
            this.UsersBindingNavigator.AddNewItem = null;
            this.UsersBindingNavigator.BindingSource = this.SettingBindingSource1;
            this.UsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.UsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.UsersBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.UsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.peopleBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.findToolStripLabel,
            this.findToolStripTextBox,
            this.findToolStripButton,
            this.toolStripSeparator2,
            this.showAllToolStripButton,
            this.toolStripSeparator3,
            this.RefreshStripButton1});
            this.UsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.UsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.UsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.UsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.UsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.UsersBindingNavigator.Name = "UsersBindingNavigator";
            this.UsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.UsersBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.UsersBindingNavigator.TabIndex = 0;
            this.UsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // SettingBindingSource1
            // 
            this.SettingBindingSource1.AllowNew = true;
            this.SettingBindingSource1.DataMember = "ServerSettings";
            this.SettingBindingSource1.DataSource = this.sDASDBDataSet;
            this.SettingBindingSource1.Filter = "";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // peopleBindingNavigatorSaveItem
            // 
            this.peopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peopleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleBindingNavigatorSaveItem.Image")));
            this.peopleBindingNavigatorSaveItem.Name = "peopleBindingNavigatorSaveItem";
            this.peopleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.peopleBindingNavigatorSaveItem.Text = "Save Data";
            this.peopleBindingNavigatorSaveItem.Click += new System.EventHandler(this.peopleBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // findToolStripLabel
            // 
            this.findToolStripLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.ValueToolStripMenuItem});
            this.findToolStripLabel.Name = "findToolStripLabel";
            this.findToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.findToolStripLabel.Text = "Find:";
            this.findToolStripLabel.ToolTipText = "Choose a column to search from";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.byNameToolStripMenuItem.Tag = "name";
            this.byNameToolStripMenuItem.Text = "By Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // ValueToolStripMenuItem
            // 
            this.ValueToolStripMenuItem.Name = "ValueToolStripMenuItem";
            this.ValueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ValueToolStripMenuItem.Tag = "value";
            this.ValueToolStripMenuItem.Text = "By Value";
            this.ValueToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // findToolStripTextBox
            // 
            this.findToolStripTextBox.Name = "findToolStripTextBox";
            this.findToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.findToolStripTextBox.ToolTipText = "Enter text to search";
            // 
            // findToolStripButton
            // 
            this.findToolStripButton.BackColor = System.Drawing.Color.SteelBlue;
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
            this.showAllToolStripButton.Text = "Show All";
            this.showAllToolStripButton.Click += new System.EventHandler(this.showAllToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshStripButton1
            // 
            this.RefreshStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("RefreshStripButton1.Image")));
            this.RefreshStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshStripButton1.Name = "RefreshStripButton1";
            this.RefreshStripButton1.Size = new System.Drawing.Size(112, 22);
            this.RefreshStripButton1.Text = "Refresh Setting Data";
            this.RefreshStripButton1.Click += new System.EventHandler(this.RefreshStripButton1_Click);
            // 
            // serverSettingsTableAdapter
            // 
            this.serverSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // SettingDataGridView
            // 
            this.SettingDataGridView.AllowUserToAddRows = false;
            this.SettingDataGridView.AllowUserToDeleteRows = false;
            this.SettingDataGridView.AllowUserToResizeRows = false;
            this.SettingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingDataGridView.AutoGenerateColumns = false;
            this.SettingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SettingDataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.SettingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SettingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SettingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SettingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.SettingDataGridView.DataSource = this.SettingBindingSource1;
            this.SettingDataGridView.EnableHeadersVisualStyles = false;
            this.SettingDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SettingDataGridView.Location = new System.Drawing.Point(3, 50);
            this.SettingDataGridView.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.SettingDataGridView.MultiSelect = false;
            this.SettingDataGridView.Name = "SettingDataGridView";
            this.SettingDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SettingDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SettingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SettingDataGridView.Size = new System.Drawing.Size(632, 230);
            this.SettingDataGridView.StandardTab = true;
            this.SettingDataGridView.TabIndex = 25;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SettingDataGridView);
            this.Controls.Add(this.UsersBindingNavigator);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(645, 293);
            this.Load += new System.EventHandler(this.employeeControl_Load);
            this.ParentChanged += new System.EventHandler(this.SettingControl_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingNavigator)).EndInit();
            this.UsersBindingNavigator.ResumeLayout(false);
            this.UsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator UsersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton peopleBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton showAllToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton findToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ValueToolStripMenuItem;
        private RDB_test.myData.SDASDBDataSet sDASDBDataSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton RefreshStripButton1;
        private RDB_test.myData.SDASDBDataSetTableAdapters.ServerSettingsTableAdapter serverSettingsTableAdapter;
        private System.Windows.Forms.BindingSource SettingBindingSource1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.DataGridView SettingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;

    }
}
