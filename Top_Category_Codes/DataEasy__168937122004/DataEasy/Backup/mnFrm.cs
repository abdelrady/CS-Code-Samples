//------------------------------------------------------------------------
//
// Author      : Anas S.
// Date        : 1 Jan 2004
// Version     : 1.0
// Description : An easy Application to link with an access mdb
//               file to allow the user to Delete, Select
//               Update the dataloaded
//               Filter and Search capabilities are also
//               included
//               NiceMenu and CreateControls classes are done by 
//               other authors I downloaded them from planet-source-code
//               site I thank them for sharing their codes here in planet-source-code
//
//------------------------------------------------------------------------


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Utility.NiceMenu;
using System.Data.OleDb;

namespace DataEasy
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainFrm : System.Windows.Forms.Form
	{
		#region "Private Declarations"
		private System.Windows.Forms.Button btnNavPrev;
		private System.Windows.Forms.Label lblNavLocation;
		private System.Windows.Forms.Button btnNavNext;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGrid dGrid;
		private System.Windows.Forms.ImageList imageMenu;
		private System.Windows.Forms.MainMenu menuFile;
		private System.Windows.Forms.MenuItem menuF;
		private System.Windows.Forms.MenuItem menuF_open;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuF_save;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuF_exit;
		private System.Windows.Forms.MenuItem menuSearch;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ComboBox comboTables;
		
		private string[] colType;         //This array holds all the columnTypes;
		private System.Windows.Forms.ContextMenu[] AutoMenu; //AutoDate or AutoNumber Options
		private int GPostion;             //DataGrid's postion from Top
		private bool DataLoaded = false;  //Check if the data is loaded into the system
		private NiceMenu myNiceMenu;      //the menues with icons
		private DataSet accessDataSet;    //the main DataSet
		private string ComboBoxText="";   //the item selected in the ComboTables control
		private string dataSourceFile=""; //source file of the .mdb file
		private OleDbDataAdapter accessDataAdapter; //the adapter to be used in conjunction with
		                                            //the database file 
		private System.Windows.Forms.MenuItem mSearch; 
		private OleDbConnection accessConnection = new  OleDbConnection();
		#endregion

		public MainFrm()
		{
			InitializeComponent();
			InitializeNiceMenu(); //Modify our menues to ones
			                      //with icons using NiceMenu class
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainFrm));
			System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
			this.btnNavPrev = new System.Windows.Forms.Button();
			this.lblNavLocation = new System.Windows.Forms.Label();
			this.btnNavNext = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.dGrid = new System.Windows.Forms.DataGrid();
			this.imageMenu = new System.Windows.Forms.ImageList(this.components);
			this.menuFile = new System.Windows.Forms.MainMenu();
			this.menuF = new System.Windows.Forms.MenuItem();
			this.menuF_open = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuF_save = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuF_exit = new System.Windows.Forms.MenuItem();
			this.mSearch = new System.Windows.Forms.MenuItem();
			this.menuSearch = new System.Windows.Forms.MenuItem();
			this.comboTables = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNavPrev
			// 
			this.btnNavPrev.Location = new System.Drawing.Point(288, 56);
			this.btnNavPrev.Name = "btnNavPrev";
			this.btnNavPrev.Size = new System.Drawing.Size(35, 23);
			this.btnNavPrev.TabIndex = 50;
			this.btnNavPrev.Text = "<";
			this.btnNavPrev.Visible = false;
			this.btnNavPrev.Click += new System.EventHandler(this.btnNavPrev_Click);
			// 
			// lblNavLocation
			// 
			this.lblNavLocation.BackColor = System.Drawing.Color.White;
			this.lblNavLocation.Location = new System.Drawing.Point(320, 56);
			this.lblNavLocation.Name = "lblNavLocation";
			this.lblNavLocation.Size = new System.Drawing.Size(95, 23);
			this.lblNavLocation.TabIndex = 51;
			this.lblNavLocation.Text = "No Records";
			this.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblNavLocation.Visible = false;
			// 
			// btnNavNext
			// 
			this.btnNavNext.Location = new System.Drawing.Point(416, 56);
			this.btnNavNext.Name = "btnNavNext";
			this.btnNavNext.Size = new System.Drawing.Size(35, 23);
			this.btnNavNext.TabIndex = 52;
			this.btnNavNext.Text = ">";
			this.btnNavNext.Visible = false;
			this.btnNavNext.Click += new System.EventHandler(this.btnNavNext_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(216, 88);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 53;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Visible = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(296, 88);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 54;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(376, 88);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 55;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(80, 88);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 49;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.Visible = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// dGrid
			// 
			this.dGrid.AllowSorting = false;
			this.dGrid.DataMember = "";
			this.dGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dGrid.Location = new System.Drawing.Point(0, 222);
			this.dGrid.Name = "dGrid";
			this.dGrid.Size = new System.Drawing.Size(536, 144);
			this.dGrid.TabIndex = 47;
			this.dGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dGrid_MouseDown);
			this.dGrid.CurrentCellChanged += new System.EventHandler(this.dGrid_CurrentCellChanged);
			// 
			// imageMenu
			// 
			this.imageMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageMenu.ImageSize = new System.Drawing.Size(16, 16);
			this.imageMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageMenu.ImageStream")));
			this.imageMenu.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// menuFile
			// 
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuF,
																					 this.mSearch});
			// 
			// menuF
			// 
			this.menuF.Index = 0;
			this.menuF.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuF_open,
																				  this.menuItem4,
																				  this.menuF_save,
																				  this.menuItem7,
																				  this.menuF_exit});
			this.menuF.OwnerDraw = ((bool)(configurationAppSettings.GetValue("menuItem1.OwnerDraw", typeof(bool))));
			this.menuF.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuF.ShowShortcut = ((bool)(configurationAppSettings.GetValue("menuItem1.ShowShortcut", typeof(bool))));
			this.menuF.Text = "&File";
			// 
			// menuF_open
			// 
			this.menuF_open.Index = 0;
			this.menuF_open.Text = "01&Open";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// menuF_save
			// 
			this.menuF_save.Enabled = false;
			this.menuF_save.Index = 2;
			this.menuF_save.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuF_save.Text = "02&Save";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "-";
			// 
			// menuF_exit
			// 
			this.menuF_exit.Index = 4;
			this.menuF_exit.Text = "03E&xit";
			// 
			// mSearch
			// 
			this.mSearch.Index = 1;
			this.mSearch.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.menuSearch});
			this.mSearch.Text = "&Search";
			// 
			// menuSearch
			// 
			this.menuSearch.Enabled = false;
			this.menuSearch.Index = 0;
			this.menuSearch.Shortcut = System.Windows.Forms.Shortcut.F12;
			this.menuSearch.Text = "04Search &Data";
			// 
			// comboTables
			// 
			this.comboTables.Location = new System.Drawing.Point(160, 56);
			this.comboTables.Name = "comboTables";
			this.comboTables.Size = new System.Drawing.Size(121, 21);
			this.comboTables.TabIndex = 56;
			this.comboTables.Text = "Tables";
			this.comboTables.Visible = false;
			this.comboTables.SelectedValueChanged += new System.EventHandler(this.comboTables_SelectedValueChanged);
			// 
			// MainFrm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 366);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dGrid,
																		  this.comboTables,
																		  this.btnNavPrev,
																		  this.lblNavLocation,
																		  this.btnNavNext,
																		  this.btnAdd,
																		  this.btnDelete,
																		  this.btnCancel,
																		  this.btnUpdate});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuFile;
			this.MinimumSize = new System.Drawing.Size(460, 200);
			this.Name = "MainFrm";
			this.Text = "DataEasy";
			this.Resize += new System.EventHandler(this.MainFrm_Resize);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainFrm_Closing);
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainFrm());
		}

		#region "Initialize Nice Menu"
		private void InitializeNiceMenu()
		{
			// Here the menues are defined as Nice Menu
			myNiceMenu = new NiceMenu();
			
			// The icons are attached Here
			myNiceMenu.MenuImages = imageMenu;

			//The click event is declared
			myNiceMenu.UpdateMenu(this.menuFile, new NiceMenuClickEvent(menuClickEvent));
		}
		#endregion

		#region "Nice Menu Click Event"
		// Nice Menu Click Event
		// this event is fired when someone clicks an
		// item in the menu
		public void menuClickEvent(object sender, System.EventArgs e)
		{
			NiceMenu item = (NiceMenu)sender;
			
			switch (item.Text)
			{
				//Open item is clicked
				case "&Open":
					//Check for any data changes!!
					if (Check_If_Data_Changed()==true)
					{
						//Alert the user that data is not saved!!
						DialogResult r  = MessageBox.Show("The database file changed, are sure you want open file without saving this file ?","Open File Without Saving this File",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
						if (r==DialogResult.No) break;
					}
					menuOpenClick();
					break;
				case "Search &Data":
					//Search the data using simple search techniques
					//or by using filters
					//in order to show correct data check if the data
					//is changed without save or not
					if (DataLoaded == false) break;
					menuSearchClick();
					break;
				case "&Save":
					//Save the changes to the source database the mdb file
					btnUpdate.Focus();
					DialogResult R = MessageBox.Show("Are you sure you want to save, changes will be permenant","Save Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
					if (R==DialogResult.Yes) Save_File();
					break;
				case "E&xit":
					//Exit the application
					//Check and Alert the user if data changed and is not saved!!
					if (Check_If_Data_Changed()==true)
					{
						DialogResult r  = MessageBox.Show("The database file changed, are sure you want exit without saving ?","Exit Without Save",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
					    if (r==DialogResult.Yes) Application.Exit();
					}
					else Application.Exit();
					break;
			}
		}
		#endregion

		#region "Save"
		//This routine handles saving
		//data changes to the main file
		private void Save_File()
		{		
			// Create a new dataset to hold the changes that have
			// been made to the main dataset.
			DataSet objDataSetChanges = new DataSet();
			// Stop any current edits.
			this.BindingContext[accessDataSet,comboTables.Text].EndCurrentEdit();
			// Get the changes that have been made to the main dataset.
			objDataSetChanges = ((DataSet)(accessDataSet.GetChanges()));
			// Check to see if any changes have been made.
			if ((objDataSetChanges != null)) 
			{
				// There are changes that need to be made, so attempt to update the datasource by
				// calling the update method and passing the dataset and any parameters.
				UpdateDataSource(objDataSetChanges);

				//Make sure the database connection is closed!!
				if (this.accessConnection.State.ToString()!="Closed") this.accessConnection.Close();
			}
		}
		#endregion

		#region "Menu Open"
		// Menu Open Click routine!!
		public void menuOpenClick()
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.FileName = "";
			//Make sure only *.mdb files can be opened
			//by using a filter
			openFile.Filter = "Microsoft Access Application (*.mdb)|*.mdb"; 

			System.Windows.Forms.DialogResult res = openFile.ShowDialog();
			if (res==System.Windows.Forms.DialogResult.Cancel) return;

			//Change the mouse icon and caption 
			//of the form to inform the user that
            //the data is being loaded
			this.Cursor = Cursors.WaitCursor;
			this.Text = "DataEasy: Loading Data Please Wait...";

			//The connection parameters
			accessConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + openFile.FileName;
			string stDataSource = openFile.FileName;
			dataSourceFile = openFile.FileName;
			//remove any dunamically created controls from the form
			removeMadeControls();

			try 
			{
				// Attempt to fill the temporary dataset.
				// Turn off constraint checking before the dataset is ed.
				// This allows the adapters to fill the dataset without concern
				// for dependencies between the tables.
				accessDataSet = new DataSet();
				accessDataSet.EnforceConstraints = false;

				((System.ComponentModel.ISupportInitialize)(this.accessDataSet)).BeginInit();
				
				try 
				{
					// Open the connection.
					accessConnection.Open();

					//Get how many tables this datafile has
					DataTable schemaTable = accessConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
						new object[] {null, null, null, "TABLE"});

					//Update the comboBox to have all
					//the tables in the database
					//and keep the first table in the database
					//as the combobox's text
					comboTables.Items.Clear();

					int i = 0;

					foreach (DataRow r in schemaTable.Rows)
					{
						if (i==0) 
						{
							comboTables.Text=(r["TABLE_NAME"].ToString());
							comboTables.Items.Add(r["TABLE_NAME"].ToString());
						}
						else comboTables.Items.Add(r["TABLE_NAME"].ToString());
						i++;
					}

					//load data
					ComboBoxText = comboTables.Text;
					if (menuSearch.Enabled == true) removeMadeControls();
					//Call the LoadData Routine!!
					LoadData("Select * From [" + comboTables.Text + "]");
				}
				catch (System.Data.OleDb.OleDbException fillException) 
				{
					//report error incase of failure in loading data
					MessageBox.Show(fillException.Message);
				}
				finally 
				{
					// Turn constraint checking back on.
					accessDataSet.EnforceConstraints = true;
					// Close the connection whether or not the exception was thrown.
					accessConnection.Close();
				}
			}
			catch (System.Data.OleDb.OleDbException eFillDataSet) 
			{
				throw eFillDataSet;
			}
			//Return the cursor and form's caption to their normal state
			this.Cursor = Cursors.Arrow;
			this.Text = "DataEasy";
		}
		#endregion

		#region "Menu Search Click"
		//Search Menu is clicked
		private void menuSearchClick()
		{

			//Create a new instance of the search form
			//Specifying the datasource and table to view
			Form sfrm =  new searchfrm(this,dataSourceFile, "[" +comboTables.Text +"]" ,"Select * From [" + comboTables.Text +" ]");
			// Create a new dataset to hold the changes that have been made to the main dataset.
			DataSet objDataSetChanges = new DataSet();
			// Stop any current edits.
			this.BindingContext[accessDataSet,comboTables.Text].EndCurrentEdit();
			// Get the changes that have been made to the main dataset.
			objDataSetChanges = ((DataSet)(accessDataSet.GetChanges()));
			// Check to see if any changes have been made.
			if ((objDataSetChanges != null)) 
			{
				//alert the user that in order to view the same data
				//in the search he/she has to save the file
				DialogResult r  = MessageBox.Show("The database file changed, in oder to see your changes in the search form you have to save, continue any way?","Change In Data File Detected",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
				if (r==DialogResult.No) return;
			}
			Form.ActiveForm.Enabled = false;
			sfrm.Show();
		}
		#endregion

		#region "LoadData"
		//Here data is read from the database
		//and all the parameters are set
		//Select string is the SQL command required 
		//to view the data
		public void LoadData(string SelectString)
		{			
			this.Cursor = Cursors.WaitCursor;
			this.Text = "DataEasy: Loading Data Please Wait...";
			try	
			{
				accessDataSet = new DataSet();

				DataTable accessDataTable;
				//create new instances for select, insert and update
				//and delete commands to be used with the adapter
				OleDbCommand accessSelectCommand = new OleDbCommand();
				OleDbCommand accessInsertCommand = new OleDbCommand();
				OleDbCommand accessUpdateCommand = new OleDbCommand();
				OleDbCommand accessDeleteCommand = new OleDbCommand();
				
				accessDataAdapter = null;
				accessDataAdapter = new OleDbDataAdapter();

				accessSelectCommand.CommandText = SelectString;
				accessSelectCommand.Connection =  accessConnection;
				accessDataAdapter.SelectCommand = accessSelectCommand;

				// Attempt to fill the dataset through the accessDataAdapter
				accessDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {																								   
																									   new System.Data.Common.DataTableMapping("Table", comboTables.Text)});
				//populate the DataSet with existing constraints information from a data source
				accessDataAdapter.FillSchema(accessDataSet, SchemaType.Source,comboTables.Text);
				
				// Fill the dataser
				accessDataAdapter.Fill(accessDataSet);
				
				//create an instance for a datatable
				accessDataTable = accessDataSet.Tables[comboTables.Text];
     			
				// Make dynamic Insert Commands and Parameters
				accessInsertCommand.Connection = accessConnection;
				make_Insert_Command(accessDataTable,accessInsertCommand);
				accessDataAdapter.InsertCommand = accessInsertCommand;
 
				// The dynamic Update Commands and Parameters
				accessUpdateCommand.Connection = accessConnection;			
				make_Update_Command(accessDataTable,accessUpdateCommand);
				accessDataAdapter.UpdateCommand = accessUpdateCommand;

				// The dynamic Delete Commands and Parameters
				accessDeleteCommand.Connection = accessConnection;			
				make_Delete_Command(accessDataTable,accessDeleteCommand);
				accessDataAdapter.DeleteCommand = accessDeleteCommand;

				// Dynamic Controls Postions
				int controlTop = 10;
				int controlLeft = 10;
				
				//Get all the System.DataTypes of all the
				//columns in the table and assign them to the
				//array colType
				colType = new string[accessDataTable.Columns.Count];

				//Here AutoMenu is created which would allow the user
				//to insert automatic incrementation of numbers (+1 on the
				//last cell) or insert today's date for datetime type
				//columns
				AutoMenu = new ContextMenu[accessDataTable.Columns.Count];

				//Create dynamically all the textboxes and labels
				//which will hold and link information to the database
				//making it easier to input data
				for (int i=0;i< accessDataTable.Columns.Count;i++)
				{
					colType[i] = accessDataTable.Columns[i].DataType.ToString();
	
					//Create the control (Label)
					Label LabelControl = (Label)CreateControls.MakeControl("Label",30,100,
						controlLeft,controlTop+3,
						accessDataTable.Columns[i].Caption + " :","cLabel"+i);						

					//Create the control (TextBox)
					TextBox TextControl =(TextBox)CreateControls.MakeControl("TextBox",30,100,
						controlLeft + 100 ,controlTop,
						accessDataTable.Columns[i].Caption,"cText"+i);			
                    
					//Assign the TabIndex sequentially to the created
					//textbox control
					TextControl.TabIndex = i;

					//Bind the textbox control to the database table column
					TextControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accessDataSet, comboTables.Text + "." + accessDataSet.Tables[comboTables.Text].Columns[i]));
					
					//Finally add the controls to the form
					this.Controls.Add (TextControl);
					this.Controls.Add (LabelControl);
             
					//Here we arrange the controls on the form
					if (i == accessDataTable.Columns.Count-1) break;
					
					if (controlLeft == 10){controlLeft = 220;}
					else if ((controlLeft==220) &&  (accessDataTable.Columns.Count>6))
					{
						controlLeft=430;
						this.Width = 680;
					}
					else
					{
						controlTop += LabelControl.Height + 10;
						controlLeft = 10;
					}
				}

				arrange_Controls(controlTop, accessDataTable.Columns.Count);
				    
				//Bind the datagrid control to the database table
				dGrid.SetDataBinding(accessDataSet,comboTables.Text);

              
				//Create AutoInsertion of Date for only 'DateTime' Type
				//columns and
				//AutoNumber to only 'Integer' type columns
				for (int i = 0; i< accessDataTable.Columns.Count ;i++) 
				{
					if (colType[i] == "System.Int32")
					{
						MenuItem Item1 = new MenuItem("Automatic Incrementation");
						Item1.Click += new System.EventHandler(this.cMenuClick);
						AutoMenu[i] = new ContextMenu(new MenuItem[]{Item1});
					}
					else if (colType[i] =="System.DateTime")
					{
						MenuItem Item1 = new MenuItem("Automatic Insertion of Today's Date");
						Item1.Click += new System.EventHandler(this.cMenuClick);
						AutoMenu[i] = new ContextMenu(new MenuItem[]{Item1});
					}
				}
				
				//refresh the database view in the grid
				DataSet_PositionChanged();
			}
			// catch any errors and display them
			catch(System.Data.OleDb.OleDbException e)
			{MessageBox.Show(e.Message);}

			this.Cursor = Cursors.Arrow;
			this.Text = "DataEasy";
		}
		#endregion

		#region "make_Insert_Command"
		//Here the command string and the parameters are
		//assigned dynamically for the insert command
		private void make_Insert_Command(DataTable datatable, OleDbCommand insertcommand)
		{
			string insertString1 = "INSERT INTO [" + comboTables.Text + "] (";
			string insertString2="";
			
			for (int i=0;i< datatable.Columns.Count;i++)
			{
				insertString1 += "[" + datatable.Columns[i].Caption + "]";  
				insertString2 += "?"; 
						
				if (i!= datatable.Columns.Count-1)
				{
					insertString1 +=",";
					insertString2 +=",";
				}
				else {insertString1 +=") VALUES (" + insertString2 + ")";}

				insertcommand.Parameters.Add(new System.Data.OleDb.OleDbParameter(datatable.Columns[i].Caption, System.Data.OleDb.OleDbType.Variant, 16, datatable.Columns[i].Caption));
			}
			insertcommand.CommandText = insertString1;
		}
		#endregion

		#region "make_Update_Command"
		//Here the command string and the parameters are
		//assigned for the update command
		private void make_Update_Command(DataTable datatable, OleDbCommand updatecommand)
		{
			string updateString1 = "UPDATE [" + comboTables.Text + "] SET ";
			string updateString2="";

			for (int i=0;i< datatable.Columns.Count;i++)
			{
				if (datatable.Columns[i].AutoIncrement!=true)
				{
					updateString1 += "[" + datatable.Columns[i].Caption + "]  = ? ";
					if (i!= datatable.Columns.Count-1) updateString1 +=" , ";
					OleDbType colSQLType = Return_OleDBType(datatable.Columns[i].DataType.ToString());
				    updatecommand.Parameters.Add(new OleDbParameter(datatable.Columns[i].Caption, colSQLType,0, datatable.Columns[i].Caption));
				}

				updateString2 += "([" + datatable.Columns[i].Caption + "] = ? OR ? IS NULL AND [" + datatable.Columns[i].Caption + "] IS NULL)"; 
						
				if (i!= datatable.Columns.Count-1) updateString2 +=" AND ";

				else {updateString1 += " WHERE (" + updateString2 + ")";}
			}

			for (int i=0;i< datatable.Columns.Count;i++)
			{
				OleDbType colSQLType = Return_OleDBType(datatable.Columns[i].DataType.ToString());
				updatecommand.Parameters.Add(new OleDbParameter("Original_" + datatable.Columns[i].Caption, colSQLType, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(10)), datatable.Columns[i].Caption, System.Data.DataRowVersion.Original, null));
				updatecommand.Parameters.Add(new OleDbParameter("Original_" + datatable.Columns[i].Caption + "1", colSQLType, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(10)), datatable.Columns[i].Caption, System.Data.DataRowVersion.Original, null));
			}

			updatecommand.CommandText = updateString1;
		}

		private OleDbType Return_OleDBType(string SystemType)
		{
			switch(SystemType)
			{

				case "System.Boolean":
					return OleDbType.Boolean;
				case "System.Byte":
					return OleDbType.UnsignedTinyInt;
				case "System.Byte[]":
					return OleDbType.VarBinary;
				case "System.Binary":
					return OleDbType.VarBinary;
				case "System.DateTime":
					return OleDbType.DBTimeStamp;
				case "System.Decimal":
					return OleDbType.Decimal;
				case "System.Double":
					return OleDbType.Double;
				case "System.Single":
					return OleDbType.Single;
				case "System.Guid":
					return OleDbType.Guid;
				case "System.Int16":
					return OleDbType.SmallInt;
				case "System.Int32":
					return OleDbType.Integer;
				case "System.Int64":
					return OleDbType.BigInt;
				case "System.Object":
					return OleDbType.Variant;
				case "System.String":
					return OleDbType.VarWChar;
				case "System.UInt16":
					return OleDbType.UnsignedSmallInt;
				case "System.UInt32":
					return OleDbType.UnsignedInt;
				case "System.UInt64":
					return OleDbType.UnsignedBigInt;
				case "System.AnsiString":
					return OleDbType.VarChar;
				case "System.Currency":
					return OleDbType.Currency;
				case "System.Date":
					return OleDbType.DBDate;
				case "System.SByte":
					return OleDbType.TinyInt;
				case "System.Time":
					return OleDbType.DBTime;
				case "VarNumeric":
					return OleDbType.VarNumeric;
				default:
					return OleDbType.Variant;
			}
		}
		#endregion

		#region "make_Delete_Command"
		//Here the command string and the parameters are
		//assigned for the delete command
		private void make_Delete_Command(DataTable datatable, OleDbCommand deletecommand)
		{
			string deleteString = "DELETE FROM [" + comboTables.Text + "] WHERE ";

			for (int i=0;i< datatable.Columns.Count;i++)
			{
				deleteString +="( [" + datatable.Columns[i].Caption + "] = ? OR ? IS NULL AND [" + datatable.Columns[i].Caption + "] IS NULL )"; 
						
				if (i!= datatable.Columns.Count-1){deleteString +=" AND ";}
				
				deletecommand.Parameters.Add(new OleDbParameter("Original_" + datatable.Columns[i].Caption, System.Data.OleDb.OleDbType.Variant, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(10)), datatable.Columns[i].Caption, System.Data.DataRowVersion.Original, null));
				deletecommand.Parameters.Add(new OleDbParameter("Original_" + datatable.Columns[i].Caption + "1", System.Data.OleDb.OleDbType.Variant, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(10)), datatable.Columns[i].Caption, System.Data.DataRowVersion.Original, null));
			}

			deletecommand.CommandText = deleteString;
		}
		#endregion

		#region "Check_If_Data_Changed"
		// Here we check if the data has changed
		private bool Check_If_Data_Changed()
		{
			try
			{	
				// Create a new dataset to hold the changes that have been made to the main dataset.
				DataSet objDataSetChanges = new DataSet();
				// Stop any current edits.
				this.BindingContext[accessDataSet,comboTables.Text].EndCurrentEdit();
				// Get the changes that have been made to the main dataset.
				objDataSetChanges = ((DataSet)(accessDataSet.GetChanges()));
				// Check to see if any changes have been made.
				if ((objDataSetChanges != null)) return true;
				else return false;
			}
			catch
			{return false;}
		}
		#endregion

		#region "arrange_Controls"
		//Here the control positions and other control paramters are
		//set based on the data loaded
		private void arrange_Controls(int startingPos, int TabIndex_start)
		{
			btnAdd.TabIndex = TabIndex_start+1;
			btnCancel.TabIndex = TabIndex_start+2;
			btnDelete.TabIndex = TabIndex_start+3;
			btnUpdate.TabIndex = TabIndex_start+5;

			startingPos += 10 ;
			comboTables.Top = startingPos + 42;
			comboTables.Left = 90;

			//lblcombo.Top = startingPos + 45;
			//lblcombo.Left = 10;

			btnNavNext.Top = startingPos + 40;
			btnNavNext.Left = 385;

			lblNavLocation.Top = startingPos + 40;
			lblNavLocation.Left = 290;

			btnNavPrev.Top = startingPos + 40;
			btnNavPrev.Left = 255;

			btnUpdate.Top = startingPos + 42;//;80;
			btnUpdate.Left = 10;

			btnCancel.Top = startingPos + 80;
			btnCancel.Left = 345;

			btnDelete.Top = startingPos + 80;
			btnDelete.Left = 270;

			btnAdd.Top = startingPos + 80;
			btnAdd.Left = 190;

			DataLoaded = true;

			NiceMenu.myModifyNiceMenu[0].MenuItems[2].Enabled = true;
			NiceMenu.myModifyNiceMenu[0].MenuItems[3].Enabled = true;
			NiceMenu.myModifyNiceMenu[1].MenuItems[0].Enabled = true;

			btnAdd.Visible = true;
			btnCancel.Visible = true;
			btnDelete.Visible = true;
			btnUpdate.Visible = true;
			btnNavPrev.Visible = true;
			btnNavNext.Visible = true;
			comboTables.Visible = true;
			lblNavLocation.Visible = true;

			GPostion = startingPos + 170;
			dGrid.Height= this.Height-GPostion;
		}
		#endregion
		
		#region "DataHighlighted Position Change"
		//update the lblnavlocation text
		private void DataSet_PositionChanged()
		{
			this.lblNavLocation.Text = ((((this.BindingContext[accessDataSet,comboTables.Text].Position + 1)).ToString() + " of  ") 
				+ this.BindingContext[accessDataSet,comboTables.Text].Count.ToString());
		}
		#endregion

		#region "Update Records in database"
		//This routine handles and perfroms the update
		//procedure to save changes in the main source
		public void UpdateDataSet()
		{
			// Create a new dataset to hold the changes that have been made to the main dataset.
			DataSet objDataSetChanges = new DataSet();
			// Stop any current edits.
			this.BindingContext[accessDataSet,comboTables.Text].EndCurrentEdit();
			// Get the changes that have been made to the main dataset.
			objDataSetChanges = ((DataSet)(accessDataSet.GetChanges()));
			// Check to see if any changes have been made.
			if ((objDataSetChanges != null)) 
			{
				UpdateDataSource(objDataSetChanges);
				if (this.accessConnection.State.ToString()!="Closed") this.accessConnection.Close();
			}
		}

		public void UpdateDataSource(DataSet ChangedRows)
		{
			// The data source only needs to be updated if there are changes pending.
			if ((ChangedRows != null)) 
			{
				// Open the connection.
				this.accessConnection.Open();
				// Attempt to update the data source.
				try
				{
					accessDataAdapter.Update(ChangedRows);
					accessDataSet.AcceptChanges();
				}
				//Catch all the erros and report them
				catch(System.Data.DBConcurrencyException e)
				{
					accessDataSet.AcceptChanges();
					MessageBox.Show("Unfortunately this data file cannot be saved as " +
						"Concurrency violation, (please exit the " +
						"all data are rejected, please renter your data)","Cannot Update File");
				}
				finally 
				{
					this.accessConnection.Close();
				}
			}
		}
		#endregion

		#region "This Form's All Button Click Events"
		//This section holds all the click events for all
		//the controls on the form

		//Navigate Previous Routine
		private void btnNavPrev_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[accessDataSet,comboTables.Text].Position = (this.BindingContext[accessDataSet,comboTables.Text].Position - 1);
			this.DataSet_PositionChanged();
		}

		//Navigate Next Routine
		private void btnNavNext_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[accessDataSet,comboTables.Text].Position = (this.BindingContext[accessDataSet,comboTables.Text].Position + 1);
			this.DataSet_PositionChanged();
		}

		//Add Data Routine
		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Clear out the current edits
				this.BindingContext[accessDataSet,comboTables.Text].EndCurrentEdit();
				this.BindingContext[accessDataSet,comboTables.Text].AddNew();
			}
			catch (System.Exception eEndEdit) 
			{
				System.Windows.Forms.MessageBox.Show(eEndEdit.Message);
			}

			this.DataSet_PositionChanged();
		}

		//Delet Data Routine
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if ((this.BindingContext[accessDataSet,comboTables.Text].Count > 0)) 
			{
				this.BindingContext[accessDataSet,comboTables.Text].RemoveAt(this.BindingContext[accessDataSet,comboTables.Text].Position);
				this.DataSet_PositionChanged();
			}
		}

		//Cancel Current Data Entry Routine
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[accessDataSet,comboTables.Text].CancelCurrentEdit();
			this.DataSet_PositionChanged();
		}

		//Update and Save Data Changes in the source file
		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Attempt to update the datasource.
				this.UpdateDataSet();
			}
			catch (System.Data.OleDb.OleDbException eUpdate) 
			{
				// Add your error handling code here.
				// Display error message, if any.
				System.Windows.Forms.MessageBox.Show(eUpdate.Message);
			}
			
			this.DataSet_PositionChanged();
		}

		//AutoNumber or Automatic Current Date Entry Routine
		private void cMenuClick(object sender, System.EventArgs e)
		{
			MenuItem tempItem = (MenuItem)sender;
			tempItem.Checked = !tempItem.Checked;
		}

		#endregion

		#region "removeMadeControls"
		//Here all the made controls are removed
		private void removeMadeControls()
		{
			for (int i=0;i<this.Controls.Count;i++) 
			{
				if ((this.Controls[i].GetType().Name == "Label") &&
					(this.Controls[i].Name != "lblNavLocation"))
				{
					this.Controls[i].Dispose();
					i=0;
				}
				else if (this.Controls[i].GetType().Name == "TextBox")
				{
					this.Controls[i].Dispose();
					i=0;
				}
			}
		}
		#endregion

		#region "comboTables_SelectedValueChanged"		
		//ComboTables Value Changed Routine
		private void comboTables_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (ComboBoxText == comboTables.Text) return;
			else ComboBoxText = comboTables.Text;

			removeMadeControls();
			LoadData("SELECT * FROM [" + comboTables.Text + "]");
		}
		#endregion

		#region "Form Closing and Resizing Event"
		private void MainFrm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (Check_If_Data_Changed()==true)
			{
				DialogResult r  = MessageBox.Show("The database file changed, are sure you want exit without saving !!","Exit Without Save",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
				if (r==DialogResult.Yes) Application.Exit();
				else e.Cancel = true;
			}
			else Application.Exit();
		}

		private void MainFrm_Resize(object sender, System.EventArgs e)
		{
			dGrid.Height= this.Height-GPostion;
		}
		#endregion

		#region "Data Grid's Event"

		//Show AutoNumber Incrementation or Automatic Date
		//Insertion menu creation routine 
		private void dGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//Runs for right mouse down
			DataGrid myGrid = (DataGrid) sender;
			System.Windows.Forms.DataGrid.HitTestInfo hti;

			hti = myGrid.HitTest(e.X, e.Y);

			switch (hti.Type) 
			{
				case System.Windows.Forms.DataGrid.HitTestType.ColumnHeader :
					if ((colType[hti.Column]=="System.Int32")|| (colType[hti.Column]=="System.DateTime"))
					{
						if (e.Button != System.Windows.Forms.MouseButtons.Right) return;
						AutoMenu[hti.Column].Show(dGrid,new Point(e.X,e.Y));
					}
					break;
			}
		}

		//The Grid's update routine if any of the menue's are
		//checked
		private void dGrid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			this.DataSet_PositionChanged();
			string[] getRow = lblNavLocation.Text.Split(' ');
			if (getRow[0]!=getRow[3]) return;
			
			DataGrid myGrid = (DataGrid) sender;
			int row = Convert.ToInt32(getRow[0]);
					
			for (int i=0;i<accessDataSet.Tables[comboTables.Text].Columns.Count;i++)
			{
				if ((colType[i]=="System.Int32")&&(AutoMenu[i].MenuItems[0].Checked==true))
				{
					if (row > 1)
					{
						try 
						{
							UpdateTextBoxes(i, Convert.ToString((int)dGrid[dGrid.CurrentCell.RowNumber-1, i]+1));
						}
						catch(System.InvalidCastException)
						{
							return;
						}
					}
				}
				if ((colType[i]=="System.DateTime")&&(AutoMenu[i].MenuItems[0].Checked==true))
				{
					{
						UpdateTextBoxes(i, System.DateTime.Now.Date.ToString());
					}
				}
			}
		}
		
		//Menu Updates done in the textbox controls
		//after editing here
		private void UpdateTextBoxes(int Col, string newValue)
		{
			for (int i=0; i< this.Controls.Count;i++)
			{
				if (this.Controls[i].Name ==("cText"+Col.ToString()))
				{
					if (this.Controls[i].Text!="") return;
					this.Controls[i].Text = newValue;
				}
			}
		}
		#endregion
	}
}
