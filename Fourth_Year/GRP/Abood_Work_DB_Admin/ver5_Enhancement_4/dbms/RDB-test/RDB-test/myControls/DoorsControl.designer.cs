namespace RDB_test.myControls {
    partial class DoorsControl {
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label DoorIPLabel;
            System.Windows.Forms.Label phoneLine2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoorsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DoorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.DoorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.peopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripLabel = new System.Windows.Forms.ToolStripDropDownButton();
            this.byFirstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.DoorNameTextBox = new System.Windows.Forms.TextBox();
            this.lastLogTextBox = new System.Windows.Forms.TextBox();
            this.DoorIPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DoorPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DoorMacTextBox = new System.Windows.Forms.TextBox();
            this.DoorsDataGridView = new System.Windows.Forms.DataGridView();
            this.doorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorLastLogRecievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorLastListUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorMACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.UsersDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.doorsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.DoorsTableAdapter();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            DoorIPLabel = new System.Windows.Forms.Label();
            phoneLine2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DoorsBindingNavigator)).BeginInit();
            this.DoorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.Location = new System.Drawing.Point(3, 38);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Location = new System.Drawing.Point(163, 38);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(64, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "Door Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Location = new System.Drawing.Point(5, 116);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(100, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Log Recieved:";
            // 
            // DoorIPLabel
            // 
            DoorIPLabel.AutoSize = true;
            DoorIPLabel.BackColor = System.Drawing.Color.Transparent;
            DoorIPLabel.Location = new System.Drawing.Point(3, 65);
            DoorIPLabel.Name = "DoorIPLabel";
            DoorIPLabel.Size = new System.Drawing.Size(46, 13);
            DoorIPLabel.TabIndex = 9;
            DoorIPLabel.Text = "Door IP:";
            // 
            // phoneLine2Label
            // 
            phoneLine2Label.AutoSize = true;
            phoneLine2Label.BackColor = System.Drawing.Color.Transparent;
            phoneLine2Label.Location = new System.Drawing.Point(138, 91);
            phoneLine2Label.Name = "phoneLine2Label";
            phoneLine2Label.Size = new System.Drawing.Size(82, 13);
            phoneLine2Label.TabIndex = 11;
            phoneLine2Label.Text = "Door Password:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.Color.Transparent;
            cityLabel.Location = new System.Drawing.Point(163, 65);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(57, 13);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "Door Mac:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(5, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 28;
            label1.Text = "Door Users:";
            // 
            // DoorsBindingNavigator
            // 
            this.DoorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.DoorsBindingNavigator.BindingSource = this.DoorsBindingSource1;
            this.DoorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.DoorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.DoorsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DoorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.showAllToolStripButton});
            this.DoorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.DoorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.DoorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.DoorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.DoorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.DoorsBindingNavigator.Name = "DoorsBindingNavigator";
            this.DoorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.DoorsBindingNavigator.Size = new System.Drawing.Size(842, 25);
            this.DoorsBindingNavigator.TabIndex = 0;
            this.DoorsBindingNavigator.Text = "bindingNavigator1";
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
            // DoorsBindingSource1
            // 
            this.DoorsBindingSource1.DataMember = "Doors";
            this.DoorsBindingSource1.DataSource = this.sDASDBDataSet;
            // 
            // sDASDBDataSet
            // 
            this.sDASDBDataSet.DataSetName = "SDASDBDataSet";
            this.sDASDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.byFirstNameToolStripMenuItem,
            this.lastNameToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.stateToolStripMenuItem,
            this.zipCodeToolStripMenuItem});
            this.findToolStripLabel.Name = "findToolStripLabel";
            this.findToolStripLabel.Size = new System.Drawing.Size(46, 22);
            this.findToolStripLabel.Text = "Find:";
            this.findToolStripLabel.ToolTipText = "Choose a column to search from";
            // 
            // byFirstNameToolStripMenuItem
            // 
            this.byFirstNameToolStripMenuItem.Name = "byFirstNameToolStripMenuItem";
            this.byFirstNameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.byFirstNameToolStripMenuItem.Tag = "UserfName";
            this.byFirstNameToolStripMenuItem.Text = "First Name";
            this.byFirstNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.lastNameToolStripMenuItem.Tag = "UserlName";
            this.lastNameToolStripMenuItem.Text = "Last Name";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cityToolStripMenuItem.Tag = "Uservalid";
            this.cityToolStripMenuItem.Text = "Valid";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stateToolStripMenuItem.Tag = "UserStage";
            this.stateToolStripMenuItem.Text = "Stage";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // zipCodeToolStripMenuItem
            // 
            this.zipCodeToolStripMenuItem.Name = "zipCodeToolStripMenuItem";
            this.zipCodeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.zipCodeToolStripMenuItem.Tag = "UserID";
            this.zipCodeToolStripMenuItem.Text = "ID";
            this.zipCodeToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
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
            this.showAllToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.showAllToolStripButton.Text = "Show All";
            this.showAllToolStripButton.Click += new System.EventHandler(this.showAllToolStripButton_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorNum", true));
            this.iDTextBox.Location = new System.Drawing.Point(49, 35);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(110, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // DoorNameTextBox
            // 
            this.DoorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorName", true));
            this.DoorNameTextBox.Location = new System.Drawing.Point(226, 35);
            this.DoorNameTextBox.Name = "DoorNameTextBox";
            this.DoorNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.DoorNameTextBox.TabIndex = 1;
            // 
            // lastLogTextBox
            // 
            this.lastLogTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorLastLogRecieved", true));
            this.lastLogTextBox.Location = new System.Drawing.Point(111, 113);
            this.lastLogTextBox.Name = "lastLogTextBox";
            this.lastLogTextBox.ReadOnly = true;
            this.lastLogTextBox.Size = new System.Drawing.Size(230, 20);
            this.lastLogTextBox.TabIndex = 6;
            // 
            // DoorIPTextBox
            // 
            this.DoorIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorIP", true));
            this.DoorIPTextBox.Location = new System.Drawing.Point(49, 62);
            this.DoorIPTextBox.Name = "DoorIPTextBox";
            this.DoorIPTextBox.PromptChar = ' ';
            this.DoorIPTextBox.Size = new System.Drawing.Size(111, 20);
            this.DoorIPTextBox.TabIndex = 2;
            // 
            // DoorPasswordTextBox
            // 
            this.DoorPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorPassword", true));
            this.DoorPasswordTextBox.Location = new System.Drawing.Point(226, 88);
            this.DoorPasswordTextBox.Name = "DoorPasswordTextBox";
            this.DoorPasswordTextBox.PromptChar = ' ';
            this.DoorPasswordTextBox.Size = new System.Drawing.Size(115, 20);
            this.DoorPasswordTextBox.TabIndex = 4;
            // 
            // DoorMacTextBox
            // 
            this.DoorMacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorMAC", true));
            this.DoorMacTextBox.Location = new System.Drawing.Point(226, 62);
            this.DoorMacTextBox.Name = "DoorMacTextBox";
            this.DoorMacTextBox.Size = new System.Drawing.Size(115, 20);
            this.DoorMacTextBox.TabIndex = 3;
            // 
            // DoorsDataGridView
            // 
            this.DoorsDataGridView.AllowUserToAddRows = false;
            this.DoorsDataGridView.AllowUserToDeleteRows = false;
            this.DoorsDataGridView.AllowUserToResizeRows = false;
            this.DoorsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DoorsDataGridView.AutoGenerateColumns = false;
            this.DoorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoorsDataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.DoorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DoorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doorNumDataGridViewTextBoxColumn,
            this.doorNameDataGridViewTextBoxColumn,
            this.doorLastLogRecievedDataGridViewTextBoxColumn,
            this.doorLastListUpdateDataGridViewTextBoxColumn,
            this.doorIPDataGridViewTextBoxColumn,
            this.doorPasswordDataGridViewTextBoxColumn,
            this.doorMACDataGridViewTextBoxColumn});
            this.DoorsDataGridView.DataSource = this.DoorsBindingSource1;
            this.DoorsDataGridView.EnableHeadersVisualStyles = false;
            this.DoorsDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DoorsDataGridView.Location = new System.Drawing.Point(347, 35);
            this.DoorsDataGridView.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DoorsDataGridView.MultiSelect = false;
            this.DoorsDataGridView.Name = "DoorsDataGridView";
            this.DoorsDataGridView.ReadOnly = true;
            this.DoorsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoorsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DoorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoorsDataGridView.Size = new System.Drawing.Size(492, 290);
            this.DoorsDataGridView.StandardTab = true;
            this.DoorsDataGridView.TabIndex = 0;
            this.DoorsDataGridView.SelectionChanged += new System.EventHandler(this.DoorsDataGridView_SelectionChanged);
            // 
            // doorNumDataGridViewTextBoxColumn
            // 
            this.doorNumDataGridViewTextBoxColumn.DataPropertyName = "doorNum";
            this.doorNumDataGridViewTextBoxColumn.HeaderText = "doorNum";
            this.doorNumDataGridViewTextBoxColumn.Name = "doorNumDataGridViewTextBoxColumn";
            this.doorNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorNameDataGridViewTextBoxColumn
            // 
            this.doorNameDataGridViewTextBoxColumn.DataPropertyName = "doorName";
            this.doorNameDataGridViewTextBoxColumn.HeaderText = "doorName";
            this.doorNameDataGridViewTextBoxColumn.Name = "doorNameDataGridViewTextBoxColumn";
            this.doorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorLastLogRecievedDataGridViewTextBoxColumn
            // 
            this.doorLastLogRecievedDataGridViewTextBoxColumn.DataPropertyName = "doorLastLogRecieved";
            this.doorLastLogRecievedDataGridViewTextBoxColumn.HeaderText = "doorLastLogRecieved";
            this.doorLastLogRecievedDataGridViewTextBoxColumn.Name = "doorLastLogRecievedDataGridViewTextBoxColumn";
            this.doorLastLogRecievedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorLastListUpdateDataGridViewTextBoxColumn
            // 
            this.doorLastListUpdateDataGridViewTextBoxColumn.DataPropertyName = "doorLastListUpdate";
            this.doorLastListUpdateDataGridViewTextBoxColumn.HeaderText = "doorLastListUpdate";
            this.doorLastListUpdateDataGridViewTextBoxColumn.Name = "doorLastListUpdateDataGridViewTextBoxColumn";
            this.doorLastListUpdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorIPDataGridViewTextBoxColumn
            // 
            this.doorIPDataGridViewTextBoxColumn.DataPropertyName = "doorIP";
            this.doorIPDataGridViewTextBoxColumn.HeaderText = "doorIP";
            this.doorIPDataGridViewTextBoxColumn.Name = "doorIPDataGridViewTextBoxColumn";
            this.doorIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorPasswordDataGridViewTextBoxColumn
            // 
            this.doorPasswordDataGridViewTextBoxColumn.DataPropertyName = "doorPassword";
            this.doorPasswordDataGridViewTextBoxColumn.HeaderText = "doorPassword";
            this.doorPasswordDataGridViewTextBoxColumn.Name = "doorPasswordDataGridViewTextBoxColumn";
            this.doorPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorMACDataGridViewTextBoxColumn
            // 
            this.doorMACDataGridViewTextBoxColumn.DataPropertyName = "doorMAC";
            this.doorMACDataGridViewTextBoxColumn.HeaderText = "doorMAC";
            this.doorMACDataGridViewTextBoxColumn.Name = "doorMACDataGridViewTextBoxColumn";
            this.doorMACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\db\\SDASDB.mdf;Integrated Security=True;User" +
                " Instance=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param", System.Data.SqlDbType.Int, 4, "doorNum")});
            // 
            // UsersDataAdapter1
            // 
            this.UsersDataAdapter1.SelectCommand = this.sqlSelectCommand2;
            this.UsersDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Users", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("userID", "userID"),
                        new System.Data.Common.DataColumnMapping("User Name", "User Name"),
                        new System.Data.Common.DataColumnMapping("Valid", "Valid")})});
            // 
            // doorsTableAdapter
            // 
            this.doorsTableAdapter.ClearBeforeFill = true;
            // 
            // UsersGridView
            // 
            this.UsersGridView.AllowUserToAddRows = false;
            this.UsersGridView.AllowUserToDeleteRows = false;
            this.UsersGridView.AutoGenerateColumns = false;
            this.UsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.validDataGridViewTextBoxColumn});
            this.UsersGridView.DataMember = "UsersInDoors";
            this.UsersGridView.DataSource = this.sDASDBDataSet;
            this.UsersGridView.Location = new System.Drawing.Point(1, 158);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.ReadOnly = true;
            this.UsersGridView.RowHeadersVisible = false;
            this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGridView.Size = new System.Drawing.Size(340, 167);
            this.UsersGridView.TabIndex = 27;
            this.UsersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validDataGridViewTextBoxColumn
            // 
            this.validDataGridViewTextBoxColumn.DataPropertyName = "Valid";
            this.validDataGridViewTextBoxColumn.HeaderText = "Valid";
            this.validDataGridViewTextBoxColumn.Name = "validDataGridViewTextBoxColumn";
            this.validDataGridViewTextBoxColumn.ReadOnly = true;
            this.validDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.validDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DoorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(label1);
            this.Controls.Add(this.UsersGridView);
            this.Controls.Add(this.DoorsDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.DoorNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastLogTextBox);
            this.Controls.Add(DoorIPLabel);
            this.Controls.Add(this.DoorIPTextBox);
            this.Controls.Add(phoneLine2Label);
            this.Controls.Add(this.DoorPasswordTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.DoorMacTextBox);
            this.Controls.Add(this.DoorsBindingNavigator);
            this.Name = "DoorsControl";
            this.Size = new System.Drawing.Size(842, 346);
            this.Load += new System.EventHandler(this.employeeControl_Load);
            this.ParentChanged += new System.EventHandler(this.DoorsControl_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DoorsBindingNavigator)).EndInit();
            this.DoorsBindingNavigator.ResumeLayout(false);
            this.DoorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator DoorsBindingNavigator;
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
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox DoorNameTextBox;
        private System.Windows.Forms.TextBox lastLogTextBox;
        private System.Windows.Forms.MaskedTextBox DoorIPTextBox;
        private System.Windows.Forms.MaskedTextBox DoorPasswordTextBox;
        private System.Windows.Forms.TextBox DoorMacTextBox;
        private System.Windows.Forms.DataGridView DoorsDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton showAllToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton findToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem byFirstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipCodeToolStripMenuItem;
        private System.Windows.Forms.BindingSource DoorsBindingSource1;
        private RDB_test.myData.SDASDBDataSet sDASDBDataSet;
        private RDB_test.myData.SDASDBDataSetTableAdapters.DoorsTableAdapter doorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorLastLogRecievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorLastListUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorMACDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter UsersDataAdapter1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn validDataGridViewTextBoxColumn;

    }
}
