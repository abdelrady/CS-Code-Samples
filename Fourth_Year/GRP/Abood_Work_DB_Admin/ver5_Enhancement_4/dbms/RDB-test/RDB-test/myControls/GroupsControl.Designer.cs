namespace RDB_test.myControls {
    partial class GroupsControl
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsControl));
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.GroupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sDASDBDataSet = new RDB_test.myData.SDASDBDataSet();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.GroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.peopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripLabel = new System.Windows.Forms.ToolStripDropDownButton();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupNumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Group_usersDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.Group_DoorsDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userfNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.includedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorsGridView = new System.Windows.Forms.DataGridView();
            this.doorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.includedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doorMACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.GroupsTableAdapter();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBindingNavigator)).BeginInit();
            this.GroupsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.Location = new System.Drawing.Point(3, 42);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(80, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "Group Number:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Location = new System.Drawing.Point(165, 42);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(70, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "Group Name:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GroupsBindingSource1, "groupNum", true));
            this.iDTextBox.Location = new System.Drawing.Point(82, 39);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(70, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // GroupsBindingSource1
            // 
            this.GroupsBindingSource1.DataMember = "Groups";
            this.GroupsBindingSource1.DataSource = this.sDASDBDataSet;
            // 
            // sDASDBDataSet
            // 
            this.sDASDBDataSet.DataSetName = "SDASDBDataSet";
            this.sDASDBDataSet.EnforceConstraints = false;
            this.sDASDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GroupsBindingSource1, "groupName", true));
            this.GroupNameTextBox.Location = new System.Drawing.Point(241, 39);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.GroupNameTextBox.TabIndex = 4;
            // 
            // GroupsDataGridView
            // 
            this.GroupsDataGridView.AllowUserToAddRows = false;
            this.GroupsDataGridView.AllowUserToDeleteRows = false;
            this.GroupsDataGridView.AllowUserToResizeRows = false;
            this.GroupsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupsDataGridView.AutoGenerateColumns = false;
            this.GroupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupsDataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.GroupsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn});
            this.GroupsDataGridView.DataSource = this.GroupsBindingSource1;
            this.GroupsDataGridView.EnableHeadersVisualStyles = false;
            this.GroupsDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.GroupsDataGridView.Location = new System.Drawing.Point(347, 35);
            this.GroupsDataGridView.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.GroupsDataGridView.MultiSelect = false;
            this.GroupsDataGridView.Name = "GroupsDataGridView";
            this.GroupsDataGridView.ReadOnly = true;
            this.GroupsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GroupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupsDataGridView.Size = new System.Drawing.Size(386, 195);
            this.GroupsDataGridView.StandardTab = true;
            this.GroupsDataGridView.TabIndex = 24;
            this.GroupsDataGridView.SelectionChanged += new System.EventHandler(this.GroupsDataGridView_SelectionChanged);
            // 
            // groupNumDataGridViewTextBoxColumn
            // 
            this.groupNumDataGridViewTextBoxColumn.DataPropertyName = "groupNum";
            this.groupNumDataGridViewTextBoxColumn.HeaderText = "Group Number";
            this.groupNumDataGridViewTextBoxColumn.Name = "groupNumDataGridViewTextBoxColumn";
            this.groupNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "groupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group Name";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GroupsBindingNavigator
            // 
            this.GroupsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.GroupsBindingNavigator.BindingSource = this.GroupsBindingSource1;
            this.GroupsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.GroupsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.GroupsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GroupsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton1});
            this.GroupsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.GroupsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.GroupsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.GroupsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.GroupsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.GroupsBindingNavigator.Name = "GroupsBindingNavigator";
            this.GroupsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.GroupsBindingNavigator.Size = new System.Drawing.Size(737, 25);
            this.GroupsBindingNavigator.TabIndex = 25;
            this.GroupsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
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
            this.GroupNumToolStripMenuItem});
            this.findToolStripLabel.Name = "findToolStripLabel";
            this.findToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.findToolStripLabel.Text = "Find:";
            this.findToolStripLabel.ToolTipText = "Choose a column to search from";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Checked = true;
            this.byNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.byNameToolStripMenuItem.Tag = "GroupName";
            this.byNameToolStripMenuItem.Text = "Group Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // GroupNumToolStripMenuItem
            // 
            this.GroupNumToolStripMenuItem.Name = "GroupNumToolStripMenuItem";
            this.GroupNumToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.GroupNumToolStripMenuItem.Tag = "GroupNum";
            this.GroupNumToolStripMenuItem.Text = "Group Number";
            this.GroupNumToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(119, 22);
            this.toolStripButton1.Text = "Load Data From DB";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Doors Open:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Users Included:";
            // 
            // Group_usersDataAdapter
            // 
            this.Group_usersDataAdapter.SelectCommand = this.sqlCommand7;
            this.Group_usersDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Users", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("userID", "userID"),
                        new System.Data.Common.DataColumnMapping("userfName", "userfName"),
                        new System.Data.Common.DataColumnMapping("userlName", "userlName"),
                        new System.Data.Common.DataColumnMapping("userEmail", "userEmail"),
                        new System.Data.Common.DataColumnMapping("userStage", "userStage"),
                        new System.Data.Common.DataColumnMapping("Included", "Included"),
                        new System.Data.Common.DataColumnMapping("userImage", "userImage")})});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            this.sqlCommand7.Connection = this.sqlConnection1;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@param", System.Data.SqlDbType.Int, 4, "GroupNum")});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = Configuration.connectionString;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Group_DoorsDataAdapter
            // 
            this.Group_DoorsDataAdapter.SelectCommand = this.sqlCommand8;
            this.Group_DoorsDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Doors", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("doorNum", "doorNum"),
                        new System.Data.Common.DataColumnMapping("doorName", "doorName"),
                        new System.Data.Common.DataColumnMapping("doorMAC", "doorMAC"),
                        new System.Data.Common.DataColumnMapping("Included", "Included")})});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlConnection1;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param", System.Data.SqlDbType.Int, 4, "groupNum")});
            // 
            // UsersGridView
            // 
            this.UsersGridView.AllowUserToAddRows = false;
            this.UsersGridView.AllowUserToDeleteRows = false;
            this.UsersGridView.AllowUserToResizeRows = false;
            this.UsersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersGridView.AutoGenerateColumns = false;
            this.UsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.UsersGridView.ColumnHeadersHeight = 20;
            this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userfNameDataGridViewTextBoxColumn,
            this.userlNameDataGridViewTextBoxColumn,
            this.includedDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.userStageDataGridViewTextBoxColumn});
            this.UsersGridView.DataMember = "UsersINGroup";
            this.UsersGridView.DataSource = this.sDASDBDataSet;
            this.UsersGridView.Location = new System.Drawing.Point(6, 259);
            this.UsersGridView.MultiSelect = false;
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.ReadOnly = true;
            this.UsersGridView.RowHeadersVisible = false;
            this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGridView.Size = new System.Drawing.Size(488, 163);
            this.UsersGridView.TabIndex = 27;
            this.UsersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userfNameDataGridViewTextBoxColumn
            // 
            this.userfNameDataGridViewTextBoxColumn.DataPropertyName = "userfName";
            this.userfNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.userfNameDataGridViewTextBoxColumn.Name = "userfNameDataGridViewTextBoxColumn";
            this.userfNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userlNameDataGridViewTextBoxColumn
            // 
            this.userlNameDataGridViewTextBoxColumn.DataPropertyName = "userlName";
            this.userlNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.userlNameDataGridViewTextBoxColumn.Name = "userlNameDataGridViewTextBoxColumn";
            this.userlNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // includedDataGridViewTextBoxColumn
            // 
            this.includedDataGridViewTextBoxColumn.DataPropertyName = "Included";
            this.includedDataGridViewTextBoxColumn.HeaderText = "Included";
            this.includedDataGridViewTextBoxColumn.Name = "includedDataGridViewTextBoxColumn";
            this.includedDataGridViewTextBoxColumn.ReadOnly = true;
            this.includedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.includedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "User Email";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            this.userEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userStageDataGridViewTextBoxColumn
            // 
            this.userStageDataGridViewTextBoxColumn.DataPropertyName = "userStage";
            this.userStageDataGridViewTextBoxColumn.HeaderText = "User Stage";
            this.userStageDataGridViewTextBoxColumn.Name = "userStageDataGridViewTextBoxColumn";
            this.userStageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DoorsGridView
            // 
            this.DoorsGridView.AllowUserToAddRows = false;
            this.DoorsGridView.AllowUserToDeleteRows = false;
            this.DoorsGridView.AllowUserToResizeRows = false;
            this.DoorsGridView.AutoGenerateColumns = false;
            this.DoorsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoorsGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.DoorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doorNumDataGridViewTextBoxColumn,
            this.doorNameDataGridViewTextBoxColumn,
            this.includedDataGridViewTextBoxColumn1,
            this.doorMACDataGridViewTextBoxColumn});
            this.DoorsGridView.DataMember = "DoorsInGroup";
            this.DoorsGridView.DataSource = this.sDASDBDataSet;
            this.DoorsGridView.Location = new System.Drawing.Point(6, 80);
            this.DoorsGridView.Name = "DoorsGridView";
            this.DoorsGridView.ReadOnly = true;
            this.DoorsGridView.RowHeadersVisible = false;
            this.DoorsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoorsGridView.Size = new System.Drawing.Size(335, 150);
            this.DoorsGridView.TabIndex = 26;
            this.DoorsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoorsGridView_CellContentClick);
            // 
            // doorNumDataGridViewTextBoxColumn
            // 
            this.doorNumDataGridViewTextBoxColumn.DataPropertyName = "doorNum";
            this.doorNumDataGridViewTextBoxColumn.HeaderText = "Door Number";
            this.doorNumDataGridViewTextBoxColumn.Name = "doorNumDataGridViewTextBoxColumn";
            this.doorNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorNameDataGridViewTextBoxColumn
            // 
            this.doorNameDataGridViewTextBoxColumn.DataPropertyName = "doorName";
            this.doorNameDataGridViewTextBoxColumn.HeaderText = "Door Name";
            this.doorNameDataGridViewTextBoxColumn.Name = "doorNameDataGridViewTextBoxColumn";
            this.doorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // includedDataGridViewTextBoxColumn1
            // 
            this.includedDataGridViewTextBoxColumn1.DataPropertyName = "Included";
            this.includedDataGridViewTextBoxColumn1.HeaderText = "Open";
            this.includedDataGridViewTextBoxColumn1.Name = "includedDataGridViewTextBoxColumn1";
            this.includedDataGridViewTextBoxColumn1.ReadOnly = true;
            this.includedDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.includedDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // doorMACDataGridViewTextBoxColumn
            // 
            this.doorMACDataGridViewTextBoxColumn.DataPropertyName = "doorMAC";
            this.doorMACDataGridViewTextBoxColumn.HeaderText = "Door MAC";
            this.doorMACDataGridViewTextBoxColumn.Name = "doorMACDataGridViewTextBoxColumn";
            this.doorMACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePictureBox.BackColor = System.Drawing.Color.Black;
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.sDASDBDataSet, "UsersINGroup.userImage", true));
            this.imagePictureBox.Location = new System.Drawing.Point(500, 259);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(233, 163);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 31;
            this.imagePictureBox.TabStop = false;
            // 
            // GroupsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersGridView);
            this.Controls.Add(this.DoorsGridView);
            this.Controls.Add(this.GroupsBindingNavigator);
            this.Controls.Add(this.GroupsDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.GroupNameTextBox);
            this.Name = "GroupsControl";
            this.Size = new System.Drawing.Size(737, 425);
            this.Load += new System.EventHandler(this.employeeControl_Load);
            this.ParentChanged += new System.EventHandler(this.GroupsControl_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBindingNavigator)).EndInit();
            this.GroupsBindingNavigator.ResumeLayout(false);
            this.GroupsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.DataGridView GroupsDataGridView;
        private RDB_test.myData.SDASDBDataSet sDASDBDataSet;
        private RDB_test.myData.SDASDBDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingNavigator GroupsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripDropDownButton findToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GroupNumToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton showAllToolStripButton;
        private System.Windows.Forms.DataGridView DoorsGridView;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource GroupsBindingSource1;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlDataAdapter Group_usersDataAdapter;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private System.Data.SqlClient.SqlDataAdapter Group_DoorsDataAdapter;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn includedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorMACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userfNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn includedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}
