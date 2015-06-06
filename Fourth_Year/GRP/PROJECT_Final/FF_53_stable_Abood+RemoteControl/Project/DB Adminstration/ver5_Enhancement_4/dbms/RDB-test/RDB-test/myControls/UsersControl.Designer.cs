namespace RDB_test.myControls {
    partial class UsersControl {
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
            System.Windows.Forms.Label phoneLine1Label;
            System.Windows.Forms.Label DescLabel;
            System.Windows.Forms.Label EmailLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label Validlabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.UsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.importToolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLine1MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userfNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersTableAdapter1 = new RDB_test.myData.SDASDBDataSetTableAdapters.UsersTableAdapter();
            this.ValidcomboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StagecomboBox = new System.Windows.Forms.ComboBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneLine1Label = new System.Windows.Forms.Label();
            DescLabel = new System.Windows.Forms.Label();
            EmailLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            Validlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingNavigator)).BeginInit();
            this.UsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.Location = new System.Drawing.Point(8, 38);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(22, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Location = new System.Drawing.Point(165, 69);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(62, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Location = new System.Drawing.Point(165, 95);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneLine1Label
            // 
            phoneLine1Label.AutoSize = true;
            phoneLine1Label.BackColor = System.Drawing.Color.Transparent;
            phoneLine1Label.Location = new System.Drawing.Point(165, 123);
            phoneLine1Label.Name = "phoneLine1Label";
            phoneLine1Label.Size = new System.Drawing.Size(69, 13);
            phoneLine1Label.TabIndex = 9;
            phoneLine1Label.Text = "Phone Line1:";
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.BackColor = System.Drawing.Color.Transparent;
            DescLabel.Location = new System.Drawing.Point(8, 230);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new System.Drawing.Size(64, 13);
            DescLabel.TabIndex = 13;
            DescLabel.Text = "Description:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.BackColor = System.Drawing.Color.Transparent;
            EmailLabel.Location = new System.Drawing.Point(8, 256);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new System.Drawing.Size(35, 13);
            EmailLabel.TabIndex = 15;
            EmailLabel.Text = "Email:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.Color.Transparent;
            cityLabel.Location = new System.Drawing.Point(165, 173);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 13);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "Stage:";
            // 
            // Validlabel
            // 
            Validlabel.AutoSize = true;
            Validlabel.BackColor = System.Drawing.Color.Transparent;
            Validlabel.Location = new System.Drawing.Point(165, 197);
            Validlabel.Name = "Validlabel";
            Validlabel.Size = new System.Drawing.Size(33, 13);
            Validlabel.TabIndex = 25;
            Validlabel.Text = "Valid:";
            // 
            // UsersBindingNavigator
            // 
            this.UsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.UsersBindingNavigator.BindingSource = this.UsersBindingSource1;
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
            this.importToolStripButton,
            this.toolStripSeparator1,
            this.findToolStripLabel,
            this.findToolStripTextBox,
            this.findToolStripButton,
            this.toolStripSeparator2,
            this.showAllToolStripButton});
            this.UsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.UsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.UsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.UsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.UsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.UsersBindingNavigator.Name = "UsersBindingNavigator";
            this.UsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.UsersBindingNavigator.Size = new System.Drawing.Size(925, 25);
            this.UsersBindingNavigator.TabIndex = 0;
            this.UsersBindingNavigator.Text = "bindingNavigator1";
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
            // UsersBindingSource1
            // 
            this.UsersBindingSource1.DataMember = "Users";
            this.UsersBindingSource1.DataSource = this.sDASDBDataSet;
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
            // importToolStripButton
            // 
            this.importToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importToolStripButton.Image = global::RDB_test.Properties.Resources.folder_open_16;
            this.importToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripButton.Name = "importToolStripButton";
            this.importToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.importToolStripButton.Text = "Import Image";
            this.importToolStripButton.ToolTipText = "Import Image";
            this.importToolStripButton.Click += new System.EventHandler(this.importToolStripButton_Click);
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
            this.findToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.findToolStripLabel.Text = "Find:";
            this.findToolStripLabel.ToolTipText = "Choose a column to search from";
            // 
            // byFirstNameToolStripMenuItem
            // 
            this.byFirstNameToolStripMenuItem.Name = "byFirstNameToolStripMenuItem";
            this.byFirstNameToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.byFirstNameToolStripMenuItem.Tag = "UserfName";
            this.byFirstNameToolStripMenuItem.Text = "First Name";
            this.byFirstNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.lastNameToolStripMenuItem.Tag = "UserlName";
            this.lastNameToolStripMenuItem.Text = "Last Name";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cityToolStripMenuItem.Tag = "Uservalid";
            this.cityToolStripMenuItem.Text = "Valid";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.stateToolStripMenuItem.Tag = "UserStage";
            this.stateToolStripMenuItem.Text = "Stage";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.FindButtonsClick);
            // 
            // zipCodeToolStripMenuItem
            // 
            this.zipCodeToolStripMenuItem.Name = "zipCodeToolStripMenuItem";
            this.zipCodeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
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
            this.showAllToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.showAllToolStripButton.Text = "Show All";
            this.showAllToolStripButton.Click += new System.EventHandler(this.showAllToolStripButton_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userID", true));
            this.iDTextBox.Location = new System.Drawing.Point(69, 35);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(264, 20);
            this.iDTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userfName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(233, 66);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userlName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(233, 92);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // phoneLine1MaskedTextBox
            // 
            this.phoneLine1MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userPhone", true));
            this.phoneLine1MaskedTextBox.Location = new System.Drawing.Point(233, 120);
            this.phoneLine1MaskedTextBox.Mask = "(999) 000-0000";
            this.phoneLine1MaskedTextBox.Name = "phoneLine1MaskedTextBox";
            this.phoneLine1MaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneLine1MaskedTextBox.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userEmail", true));
            this.EmailTextBox.Location = new System.Drawing.Point(69, 253);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(264, 20);
            this.EmailTextBox.TabIndex = 9;
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AllowUserToResizeRows = false;
            this.UsersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataGridView.AutoGenerateColumns = false;
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.UsersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userfNameDataGridViewTextBoxColumn,
            this.userlNameDataGridViewTextBoxColumn,
            this.userValidDataGridViewCheckBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userDescriptionDataGridViewTextBoxColumn,
            this.userStageDataGridViewTextBoxColumn});
            this.UsersDataGridView.DataSource = this.UsersBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.UsersDataGridView.Location = new System.Drawing.Point(347, 35);
            this.UsersDataGridView.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.UsersDataGridView.MultiSelect = false;
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(575, 238);
            this.UsersDataGridView.StandardTab = true;
            this.UsersDataGridView.TabIndex = 11;
            this.UsersDataGridView.SelectionChanged += new System.EventHandler(this.UsersDataGridView_SelectionChanged);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userfNameDataGridViewTextBoxColumn
            // 
            this.userfNameDataGridViewTextBoxColumn.DataPropertyName = "userfName";
            this.userfNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.userfNameDataGridViewTextBoxColumn.Name = "userfNameDataGridViewTextBoxColumn";
            // 
            // userlNameDataGridViewTextBoxColumn
            // 
            this.userlNameDataGridViewTextBoxColumn.DataPropertyName = "userlName";
            this.userlNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.userlNameDataGridViewTextBoxColumn.Name = "userlNameDataGridViewTextBoxColumn";
            // 
            // userValidDataGridViewCheckBoxColumn
            // 
            this.userValidDataGridViewCheckBoxColumn.DataPropertyName = "userValid";
            this.userValidDataGridViewCheckBoxColumn.HeaderText = "Valid Status";
            this.userValidDataGridViewCheckBoxColumn.Name = "userValidDataGridViewCheckBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "User Email";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "userPhone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "User Phone";
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            // 
            // userDescriptionDataGridViewTextBoxColumn
            // 
            this.userDescriptionDataGridViewTextBoxColumn.DataPropertyName = "userDescription";
            this.userDescriptionDataGridViewTextBoxColumn.HeaderText = "User Description";
            this.userDescriptionDataGridViewTextBoxColumn.Name = "userDescriptionDataGridViewTextBoxColumn";
            // 
            // userStageDataGridViewTextBoxColumn
            // 
            this.userStageDataGridViewTextBoxColumn.DataPropertyName = "userStage";
            this.userStageDataGridViewTextBoxColumn.HeaderText = "User Stage";
            this.userStageDataGridViewTextBoxColumn.Name = "userStageDataGridViewTextBoxColumn";
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // ValidcomboBox
            // 
            this.ValidcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userValid", true));
            this.ValidcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValidcomboBox.FormattingEnabled = true;
            this.ValidcomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.ValidcomboBox.Location = new System.Drawing.Point(233, 194);
            this.ValidcomboBox.Name = "ValidcomboBox";
            this.ValidcomboBox.Size = new System.Drawing.Size(100, 21);
            this.ValidcomboBox.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // StagecomboBox
            // 
            this.StagecomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userStage", true));
            this.StagecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StagecomboBox.FormattingEnabled = true;
            this.StagecomboBox.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
            this.StagecomboBox.Location = new System.Drawing.Point(233, 168);
            this.StagecomboBox.Name = "StagecomboBox";
            this.StagecomboBox.Size = new System.Drawing.Size(100, 21);
            this.StagecomboBox.TabIndex = 6;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.Black;
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.UsersBindingSource1, "userImage", true));
            this.imagePictureBox.Location = new System.Drawing.Point(23, 61);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(136, 157);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 23;
            this.imagePictureBox.TabStop = false;
            // 
            // DescTextBox
            // 
            this.DescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindingSource1, "userDescription", true));
            this.DescTextBox.Location = new System.Drawing.Point(69, 224);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(264, 20);
            this.DescTextBox.TabIndex = 26;
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.StagecomboBox);
            this.Controls.Add(this.ValidcomboBox);
            this.Controls.Add(Validlabel);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneLine1Label);
            this.Controls.Add(this.phoneLine1MaskedTextBox);
            this.Controls.Add(DescLabel);
            this.Controls.Add(EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.UsersBindingNavigator);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(925, 293);
            this.Load += new System.EventHandler(this.employeeControl_Load);
            this.ParentChanged += new System.EventHandler(this.UsersControl_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingNavigator)).EndInit();
            this.UsersBindingNavigator.ResumeLayout(false);
            this.UsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDASDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator UsersBindingNavigator;
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
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneLine1MaskedTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.ToolStripButton importToolStripButton;
        private System.Windows.Forms.DataGridView UsersDataGridView;
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
        private RDB_test.myData.SDASDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource UsersBindingSource1;
        private RDB_test.myData.SDASDBDataSet sDASDBDataSet;
        private System.Windows.Forms.ComboBox ValidcomboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userfNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox StagecomboBox;
        private System.Windows.Forms.TextBox DescTextBox;

    }
}
