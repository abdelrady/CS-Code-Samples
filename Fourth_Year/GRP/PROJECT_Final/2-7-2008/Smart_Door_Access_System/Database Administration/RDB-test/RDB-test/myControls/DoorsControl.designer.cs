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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byFirstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.UsersDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.doorsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.DoorsTableAdapter();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorLastLogRecievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorLastListUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorMACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            iDLabel.Location = new System.Drawing.Point(9, 54);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(22, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Tag = "special";
            iDLabel.Text = "ID:";
            iDLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.iDLabel_Paint);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Location = new System.Drawing.Point(182, 54);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(64, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Tag = "special";
            firstNameLabel.Text = "Door Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Location = new System.Drawing.Point(9, 146);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(98, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Tag = "special";
            lastNameLabel.Text = "Last Log Recieved:";
            // 
            // DoorIPLabel
            // 
            DoorIPLabel.AutoSize = true;
            DoorIPLabel.BackColor = System.Drawing.Color.Transparent;
            DoorIPLabel.Location = new System.Drawing.Point(9, 81);
            DoorIPLabel.Name = "DoorIPLabel";
            DoorIPLabel.Size = new System.Drawing.Size(47, 13);
            DoorIPLabel.TabIndex = 9;
            DoorIPLabel.Tag = "special";
            DoorIPLabel.Text = "Door IP:";
            // 
            // phoneLine2Label
            // 
            phoneLine2Label.AutoSize = true;
            phoneLine2Label.BackColor = System.Drawing.Color.Transparent;
            phoneLine2Label.Location = new System.Drawing.Point(9, 124);
            phoneLine2Label.Name = "phoneLine2Label";
            phoneLine2Label.Size = new System.Drawing.Size(83, 13);
            phoneLine2Label.TabIndex = 11;
            phoneLine2Label.Tag = "special";
            phoneLine2Label.Text = "Door Password:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.Color.Transparent;
            cityLabel.Location = new System.Drawing.Point(190, 81);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(56, 13);
            cityLabel.TabIndex = 17;
            cityLabel.Tag = "special";
            cityLabel.Text = "Door Mac:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(155, 166);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 13);
            label1.TabIndex = 28;
            label1.Tag = "special";
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
            this.DoorsBindingNavigator.Size = new System.Drawing.Size(922, 25);
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
            this.cityToolStripMenuItem,
            this.byFirstNameToolStripMenuItem,
            this.lastNameToolStripMenuItem});
            this.findToolStripLabel.Name = "findToolStripLabel";
            this.findToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.findToolStripLabel.Text = "Find:";
            this.findToolStripLabel.ToolTipText = "Choose a column to search from";
            this.findToolStripLabel.Click += new System.EventHandler(this.findToolStripLabel_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cityToolStripMenuItem.Tag = "doorNum";
            this.cityToolStripMenuItem.Text = "Door ID";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // byFirstNameToolStripMenuItem
            // 
            this.byFirstNameToolStripMenuItem.Name = "byFirstNameToolStripMenuItem";
            this.byFirstNameToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.byFirstNameToolStripMenuItem.Tag = "doorName";
            this.byFirstNameToolStripMenuItem.Text = "Door Name";
            this.byFirstNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.lastNameToolStripMenuItem.Tag = "doorIP";
            this.lastNameToolStripMenuItem.Text = "IP Address";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
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
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorNum", true));
            this.iDTextBox.Location = new System.Drawing.Point(66, 51);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(110, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // DoorNameTextBox
            // 
            this.DoorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorName", true));
            this.DoorNameTextBox.Location = new System.Drawing.Point(246, 51);
            this.DoorNameTextBox.Name = "DoorNameTextBox";
            this.DoorNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.DoorNameTextBox.TabIndex = 1;
            // 
            // lastLogTextBox
            // 
            this.lastLogTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorLastLogRecieved", true));
            this.lastLogTextBox.Location = new System.Drawing.Point(113, 143);
            this.lastLogTextBox.Name = "lastLogTextBox";
            this.lastLogTextBox.ReadOnly = true;
            this.lastLogTextBox.Size = new System.Drawing.Size(248, 20);
            this.lastLogTextBox.TabIndex = 6;
            // 
            // DoorIPTextBox
            // 
            this.DoorIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorIP", true));
            this.DoorIPTextBox.Location = new System.Drawing.Point(66, 78);
            this.DoorIPTextBox.Name = "DoorIPTextBox";
            this.DoorIPTextBox.PromptChar = ' ';
            this.DoorIPTextBox.Size = new System.Drawing.Size(111, 20);
            this.DoorIPTextBox.TabIndex = 2;
            // 
            // DoorPasswordTextBox
            // 
            this.DoorPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorPassword", true));
            this.DoorPasswordTextBox.Location = new System.Drawing.Point(113, 117);
            this.DoorPasswordTextBox.Name = "DoorPasswordTextBox";
            this.DoorPasswordTextBox.PromptChar = ' ';
            this.DoorPasswordTextBox.Size = new System.Drawing.Size(248, 20);
            this.DoorPasswordTextBox.TabIndex = 4;
            this.DoorPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // DoorMacTextBox
            // 
            this.DoorMacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DoorsBindingSource1, "doorMAC", true));
            this.DoorMacTextBox.Location = new System.Drawing.Point(246, 78);
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
            this.DoorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DoorsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DoorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DoorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doorNumDataGridViewTextBoxColumn,
            this.doorNameDataGridViewTextBoxColumn,
            this.doorLastLogRecievedDataGridViewTextBoxColumn,
            this.doorLastListUpdateDataGridViewTextBoxColumn,
            this.doorIPDataGridViewTextBoxColumn,
            this.doorMACDataGridViewTextBoxColumn});
            this.DoorsDataGridView.DataSource = this.DoorsBindingSource1;
            this.DoorsDataGridView.GridColor = System.Drawing.SystemColors.ControlText;
            this.DoorsDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DoorsDataGridView.Location = new System.Drawing.Point(371, 40);
            this.DoorsDataGridView.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DoorsDataGridView.MultiSelect = false;
            this.DoorsDataGridView.Name = "DoorsDataGridView";
            this.DoorsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoorsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DoorsDataGridView.RowHeadersVisible = false;
            this.DoorsDataGridView.RowHeadersWidth = 45;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoorsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DoorsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DoorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoorsDataGridView.Size = new System.Drawing.Size(538, 323);
            this.DoorsDataGridView.StandardTab = true;
            this.DoorsDataGridView.TabIndex = 0;
            this.DoorsDataGridView.SelectionChanged += new System.EventHandler(this.DoorsDataGridView_SelectionChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\db\\SDASDB.mdf;Integrated Security=Tr" +
                "ue;User Instance=True";
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
            this.UsersGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.validDataGridViewTextBoxColumn});
            this.UsersGridView.DataMember = "UsersInDoors";
            this.UsersGridView.DataSource = this.sDASDBDataSet;
            this.UsersGridView.Location = new System.Drawing.Point(12, 182);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.ReadOnly = true;
            this.UsersGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.UsersGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGridView.Size = new System.Drawing.Size(349, 181);
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
            this.validDataGridViewTextBoxColumn.FalseValue = "0";
            this.validDataGridViewTextBoxColumn.HeaderText = "Valid";
            this.validDataGridViewTextBoxColumn.Name = "validDataGridViewTextBoxColumn";
            this.validDataGridViewTextBoxColumn.ReadOnly = true;
            this.validDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.validDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.validDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // doorNumDataGridViewTextBoxColumn
            // 
            this.doorNumDataGridViewTextBoxColumn.DataPropertyName = "doorNum";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doorNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.doorNumDataGridViewTextBoxColumn.FillWeight = 177.665F;
            this.doorNumDataGridViewTextBoxColumn.HeaderText = "Number";
            this.doorNumDataGridViewTextBoxColumn.Name = "doorNumDataGridViewTextBoxColumn";
            this.doorNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.doorNumDataGridViewTextBoxColumn.Width = 69;
            // 
            // doorNameDataGridViewTextBoxColumn
            // 
            this.doorNameDataGridViewTextBoxColumn.DataPropertyName = "doorName";
            this.doorNameDataGridViewTextBoxColumn.FillWeight = 256.2241F;
            this.doorNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.doorNameDataGridViewTextBoxColumn.Name = "doorNameDataGridViewTextBoxColumn";
            this.doorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.doorNameDataGridViewTextBoxColumn.Width = 59;
            // 
            // doorLastLogRecievedDataGridViewTextBoxColumn
            // 
            this.doorLastLogRecievedDataGridViewTextBoxColumn.DataPropertyName = "doorLastLogRecieved";
            this.doorLastLogRecievedDataGridViewTextBoxColumn.FillWeight = 66.43796F;
            this.doorLastLogRecievedDataGridViewTextBoxColumn.HeaderText = "Last Log";
            this.doorLastLogRecievedDataGridViewTextBoxColumn.Name = "doorLastLogRecievedDataGridViewTextBoxColumn";
            this.doorLastLogRecievedDataGridViewTextBoxColumn.ReadOnly = true;
            this.doorLastLogRecievedDataGridViewTextBoxColumn.Width = 72;
            // 
            // doorLastListUpdateDataGridViewTextBoxColumn
            // 
            this.doorLastListUpdateDataGridViewTextBoxColumn.DataPropertyName = "doorLastListUpdate";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doorLastListUpdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.doorLastListUpdateDataGridViewTextBoxColumn.FillWeight = 172.7387F;
            this.doorLastListUpdateDataGridViewTextBoxColumn.HeaderText = "Last List Rec.";
            this.doorLastListUpdateDataGridViewTextBoxColumn.Name = "doorLastListUpdateDataGridViewTextBoxColumn";
            this.doorLastListUpdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.doorLastListUpdateDataGridViewTextBoxColumn.Width = 96;
            // 
            // doorIPDataGridViewTextBoxColumn
            // 
            this.doorIPDataGridViewTextBoxColumn.DataPropertyName = "doorIP";
            this.doorIPDataGridViewTextBoxColumn.FillWeight = 8.978104F;
            this.doorIPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.doorIPDataGridViewTextBoxColumn.Name = "doorIPDataGridViewTextBoxColumn";
            this.doorIPDataGridViewTextBoxColumn.ReadOnly = true;
            this.doorIPDataGridViewTextBoxColumn.Width = 42;
            // 
            // doorMACDataGridViewTextBoxColumn
            // 
            this.doorMACDataGridViewTextBoxColumn.DataPropertyName = "doorMAC";
            this.doorMACDataGridViewTextBoxColumn.FillWeight = 8.978104F;
            this.doorMACDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.doorMACDataGridViewTextBoxColumn.Name = "doorMACDataGridViewTextBoxColumn";
            this.doorMACDataGridViewTextBoxColumn.ReadOnly = true;
            this.doorMACDataGridViewTextBoxColumn.Width = 54;
            // 
            // DoorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.Size = new System.Drawing.Size(922, 377);
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
        private System.Windows.Forms.BindingSource DoorsBindingSource1;
        private RDB_test.myData.SDASDBDataSet sDASDBDataSet;
        private RDB_test.myData.SDASDBDataSetTableAdapters.DoorsTableAdapter doorsTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter UsersDataAdapter1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn validDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorLastLogRecievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorLastListUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorMACDataGridViewTextBoxColumn;

    }
}
