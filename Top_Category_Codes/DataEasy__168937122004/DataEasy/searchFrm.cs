//------------------------------------------------------------------------
//
// Author      : Anas S.
// Date        : 1 Jan 2004
// Version     : 1.0
// Description : This Form Filters and 
//               Searches the database the user either has
//               to right click a column header in the Data
//               grid and chose from the menu or type a text search
//              
//
//------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DataEasy
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class searchfrm : System.Windows.Forms.Form
	{
		#region "Private Declarations"
		private bool activateMouse = false; //a boolian to allow mouse click on the DGrid
		private object[][] elements;   //the filter menues' elements are stored here
		private string[] checkedMenu;  //the element you are looking for in the coulmn
		private DataSet accessDataSet = new DataSet();
		private OleDbConnection accessConnection = new  OleDbConnection();

		private string tableName="";  //DataBase table name
		private bool doUpdate = true; //Update the filter menues or not 
		private int columnHit;        //which column in the table is hit
		private System.Windows.Forms.DataGrid dGrid;
		private System.Windows.Forms.ContextMenu[] FilterMenu; //the filter menues for all the columns
		private System.Windows.Forms.ComboBox cBoxParamets;    //the combobox which holds the column names
		                                                       //to chose from in the search
		private System.Windows.Forms.TextBox searchTxt;        //the search element is put here
		                                                       //for the text based search
		private System.Windows.Forms.Button Findbtn;           //find row in data according to text based search
		private System.Windows.Forms.Button btnRestore;        //remove all filters button
		private Form MFRM;
		#endregion
		private System.Windows.Forms.TextBox lblSelectString;


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//The search class constructor
		public searchfrm(Form motherFrm,string datasource, string tablename,string SelectString)
		{
			InitializeComponent();

			//This refers to the parent form
			MFRM = motherFrm;
			//the tablename to do the search on
			tableName = tablename; 

			//Initializing the connection here to the source mdb file
			((System.ComponentModel.ISupportInitialize)(this.accessDataSet)).BeginInit();
			accessConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + datasource;
			accessConnection.Open();
			loadData(SelectString);
			lblSelectString.Text = "Select Command = " + SelectString;
			activateMouse = true;
			accessConnection.Close();
			
			DataTable myDataTable = accessDataSet.Tables[tableName];

			//Find all columns and put them in the combobox
			//cBoxParamets
			for (int i=0;i<myDataTable.Columns.Count;i++)
			{
				cBoxParamets.Items.Add(myDataTable.Columns[i].Caption);
				if (i==0) cBoxParamets.Text = myDataTable.Columns[i].Caption;
			}
			dGrid.Height = this.Height-135;
		}

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(searchfrm));
			this.dGrid = new System.Windows.Forms.DataGrid();
			this.cBoxParamets = new System.Windows.Forms.ComboBox();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.Findbtn = new System.Windows.Forms.Button();
			this.btnRestore = new System.Windows.Forms.Button();
			this.lblSelectString = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dGrid
			// 
			this.dGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
			this.dGrid.AllowSorting = false;
			this.dGrid.DataMember = "";
			this.dGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dGrid.Location = new System.Drawing.Point(0, 115);
			this.dGrid.Name = "dGrid";
			this.dGrid.ReadOnly = true;
			this.dGrid.Size = new System.Drawing.Size(528, 248);
			this.dGrid.TabIndex = 1;
			this.dGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dGrid_MouseDown);
			// 
			// cBoxParamets
			// 
			this.cBoxParamets.Location = new System.Drawing.Point(16, 8);
			this.cBoxParamets.Name = "cBoxParamets";
			this.cBoxParamets.Size = new System.Drawing.Size(121, 21);
			this.cBoxParamets.TabIndex = 2;
			this.cBoxParamets.Text = "Tables";
			// 
			// searchTxt
			// 
			this.searchTxt.Location = new System.Drawing.Point(16, 48);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(240, 20);
			this.searchTxt.TabIndex = 3;
			this.searchTxt.Text = "";
			this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
			// 
			// Findbtn
			// 
			this.Findbtn.Location = new System.Drawing.Point(144, 8);
			this.Findbtn.Name = "Findbtn";
			this.Findbtn.Size = new System.Drawing.Size(112, 32);
			this.Findbtn.TabIndex = 4;
			this.Findbtn.Text = "Find";
			this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Location = new System.Drawing.Point(264, 8);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(64, 60);
			this.btnRestore.TabIndex = 5;
			this.btnRestore.Text = "Restore";
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// lblSelectString
			// 
			this.lblSelectString.BackColor = System.Drawing.Color.Black;
			this.lblSelectString.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblSelectString.Location = new System.Drawing.Point(16, 80);
			this.lblSelectString.Name = "lblSelectString";
			this.lblSelectString.ReadOnly = true;
			this.lblSelectString.Size = new System.Drawing.Size(312, 20);
			this.lblSelectString.TabIndex = 6;
			this.lblSelectString.Text = "Select Command";
			// 
			// searchfrm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 363);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblSelectString,
																		  this.btnRestore,
																		  this.Findbtn,
																		  this.searchTxt,
																		  this.cBoxParamets,
																		  this.dGrid});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(352, 360);
			this.Name = "searchfrm";
			this.Text = "DataEasy: Search DataBase";
			this.Resize += new System.EventHandler(this.searchfrm_Resize);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.searchfrm_Closing);
			((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

        #region "load Data"
		//This routine loads data from a mdb file
		//into the DGrid
		private void loadData(string SelectString)
		{
			accessDataSet.RejectChanges();
			accessDataSet.Clear();

			OleDbCommand accessSelectCommand = new OleDbCommand();
			OleDbCommand accessInsertCommand = new OleDbCommand();
			OleDbDataAdapter accessDataAdapter = new OleDbDataAdapter();

			accessSelectCommand.CommandText = SelectString;
			accessSelectCommand.Connection =  accessConnection;
			accessDataAdapter.SelectCommand = accessSelectCommand;
				
			// Attempt to fill the dataset through the OleDbDataAdapter1.
			accessDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								   new System.Data.Common.DataTableMapping("Table", tableName)});				
			accessDataAdapter.Fill(accessDataSet);
				    
			dGrid.SetDataBinding(accessDataSet,tableName);

			int col = (accessDataSet.Tables[tableName].Columns.Count);
			int row = (accessDataSet.Tables[tableName].Rows.Count);
            
			if (doUpdate==true) checkedMenu = new String[col];
			elements = new object[col][];
			FilterMenu = new ContextMenu[col];

			for (int i = 0; i < col; i++) 
			{
				elements[i] = new object[row];
				if (doUpdate==true) checkedMenu[i] = "None";
			}

			for (int i=0; i < col; i++)
			{
				for (int j=0; j < row; j++)
				{ 
					if ((dGrid[j,i].GetType().Name == "Int32") ||
						(dGrid[j,i].GetType().Name == "DateTime")||
						(dGrid[j,i].GetType().Name == "Decimal"))
					{
						elements[i][j] = dGrid[j,i];
					}
					else elements[i][j] = dGrid[j,i].ToString();
				}
			}

			for (int i = 0; i < col; i++) 
			{
				try{Array.Sort(elements[i]);}
				catch
				{
					int newDim = 0;
					object[] tempArray = new object[elements[i].Length];
					for (int r = 0; r < elements[i].Length; r++)
					{
						if (elements[i][r].ToString()!= "")
						{
							tempArray[newDim] = elements[i][r];
							newDim++;
						}
					}
					elements[i] = new object[newDim];
					Array.Copy(tempArray,0,elements[i],0,newDim);
				}
				FilterMenu[i] = new ContextMenu();
				make_menues(elements[i],FilterMenu[i]);
			}
		}
		#endregion
		
		#region "Make Menues"
		//This routine makes and updates filter menus
		//inaccordance with the displayed data in the grid
		private void make_menues(object[] array_elements, System.Windows.Forms.ContextMenu cMenu)
		{
			string Prev_Element = "";

			System.Windows.Forms.MenuItem mfirstItems = new MenuItem("None");
			mfirstItems.Click +=  new System.EventHandler(this.cMenuClick);
			cMenu.MenuItems.Add(mfirstItems);

			System.Windows.Forms.MenuItem[] mItems = new MenuItem[array_elements.Length];
			for (int i = 0; i < array_elements.Length;i++)
			{
				if (Prev_Element!=array_elements[i].ToString())
				{
					mItems[i] = new MenuItem(array_elements[i].ToString());
					mItems[i].Click +=  new System.EventHandler(this.cMenuClick);
					cMenu.MenuItems.Add(mItems[i]);
					Prev_Element = array_elements[i].ToString();
				}
			}
		}
		#endregion

		#region "Filter Menu Click Event"
		//This routine handles the filter menu click event
		private void cMenuClick(object sender, System.EventArgs e)
		{
			doUpdate = false;
			MenuItem tempItem = (MenuItem)sender;
			DataTable accessDataTable = accessDataSet.Tables[tableName];

			if ((accessDataTable.Columns[columnHit].DataType.ToString() == "System.Byte[]"))
			{
				MessageBox.Show("This DataType Cannot Be Filtered", "Unable To Do Filter", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}

			checkedMenu[columnHit] = tempItem.Text;
			try
			{
				loadData(MakeSelectString(checkedMenu));
				lblSelectString.Text = "Select Command = " + MakeSelectString(checkedMenu); 
			}
			catch
			{
				MessageBox.Show("This DataType Cannot Be Filtered", "Unable To Do Filter", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				checkedMenu[columnHit] = "None";
				loadData(MakeSelectString(checkedMenu));
				lblSelectString.Text = "Select Command = " + MakeSelectString(checkedMenu); 
			}
		}
		#endregion

		#region "Make the Select Command"
		//This routine creates the seacrh command to be used
		//as a select command based on the options specified
		//by the user through text based search or menu based
		//filter
		private string MakeSelectString(string[] MenuChecked)
		{
			DataTable accessDataTable = accessDataSet.Tables[tableName];
			string STselect = "Select * From " + tableName + " Where ";
			bool there_is_Change = false;
			for (int i=0; i<MenuChecked.Length;i++)
			{
				
				string colType = accessDataTable.Columns[i].DataType.ToString();
				

				if (MenuChecked[i]!="None") 
				{
					if ((i!= 0) && (there_is_Change == true))
					{
						
						if (colType=="System.String")
						{
							STselect += " And [" + accessDataSet.Tables[tableName].Columns[i].Caption + " ] = '" + MenuChecked[i] + "'";
						}
						else if (colType=="System.DateTime")
						{
							STselect += " And [" + accessDataSet.Tables[tableName].Columns[i].Caption + " ] = #" + MenuChecked[i] + "#";
						}
						else	
						{
							STselect += " And [" + accessDataSet.Tables[tableName].Columns[i].Caption + " ] = " + MenuChecked[i];
						}
					}
					else 
					{
						if (colType=="System.String")
						{
							STselect += " [" + accessDataSet.Tables[tableName].Columns[i].Caption + " ] = '" + MenuChecked[i] + "'";
						}
						else if (colType=="System.DateTime")
						{
							STselect += " [" + accessDataSet.Tables[tableName].Columns[i].Caption + " ] = #" + MenuChecked[i] + "#";
						}
						else
						{
							STselect += " [" + accessDataSet.Tables[tableName].Columns[i].Caption + " ] = " + MenuChecked[i];
						}
					}
					there_is_Change = true;
				}
			}
			if (there_is_Change == false) STselect = "Select * From " + tableName;
			lblSelectString.Text = "Select Command = " + STselect; 
			return STselect;
		}
		#endregion

		#region "Data Grid Mouse Down Event"
		//This routine creates and loads filter menues for 
		//the datagrid and then displays them if the user right
		//clicks the header of any column
		private void dGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (activateMouse == false) return;
			if (e.Button != System.Windows.Forms.MouseButtons.Right) return;
			DataGrid myGrid = (DataGrid) sender;
			System.Windows.Forms.DataGrid.HitTestInfo hti;
			hti = myGrid.HitTest(e.X, e.Y);
			string message = "You clicked ";

			switch (hti.Type) 
			{
				case System.Windows.Forms.DataGrid.HitTestType.ColumnHeader :
					message += "the column header for column " + hti.Column;
					columnHit = hti.Column;
					FilterMenu[hti.Column].Show(dGrid,new Point(e.X,e.Y));
					break;
			}
		}
		#endregion

		#region "Text based search"
		//Button find is clicked
		private void Findbtn_Click(object sender, System.EventArgs e)
		{
			find_the_data();		
		}

		//based on the element required in the search string
		private void find_the_data()
		{
			int index=0;
			if (searchTxt.Text == "") return;
			DataTable accessDataTable = accessDataSet.Tables[tableName];
			string CommandText = "SELECT * FROM " + tableName + " Where [" +
				cBoxParamets.Text + "] = ";
			try
			{
				for (int i =0 ; i<accessDataSet.Tables[tableName].Columns.Count;i++)
				{
					if (cBoxParamets.Text==cBoxParamets.Items[i].ToString()){index = i;}
					checkedMenu[i] = "None";
				}

				if (accessDataTable.Columns[index].DataType.ToString() == "System.Byte[]")
				{
					MessageBox.Show("This DataType Cannot Be Filtered", "Unable To Do Filter", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					return;
				}

				if (accessDataTable.Columns[index].DataType.ToString()=="System.String")
				{
					CommandText += " '" +searchTxt.Text + "'";
				}
				else if (accessDataTable.Columns[index].DataType.ToString()=="System.DateTime")
				{
					CommandText += " #" + searchTxt.Text + "#";
				}
				else
				{
					CommandText += searchTxt.Text;
				}
				loadData(CommandText);
				lblSelectString.Text = "Select Command = " + CommandText;
			}
			catch
			{
				MessageBox.Show("This search string you specified does not match the datatype of the column!!" +
					" OR There is no data in the Table", "Unable To Do Filter", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				loadData("Select * From " + tableName);
				lblSelectString.Text = "Select Command = Select * From " + tableName;
				searchTxt.Text = "";
			}
		}

		//This routine removes all the filters
		//and displays all the data
		private void btnRestore_Click(object sender, System.EventArgs e)
		{
			for (int i =0 ; i<accessDataSet.Tables[tableName].Columns.Count;i++)
			{
				checkedMenu[i] = "None";
			}
			loadData("Select * From " + tableName);
			lblSelectString.Text = "Select Command = Select * From " + tableName;
		}

		//The user clicked enter instead of buttonFind
		//should give same affect
		private void searchTxt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{find_the_data();} 
		}

		#endregion

		#region "search Form events"
		//From Resize routine
		private void searchfrm_Resize(object sender, System.EventArgs e)
		{
			dGrid.Height = this.Height-135;
		}

		//Form Closing Routine
		private void searchfrm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			MFRM.Enabled = true;
		}
		#endregion
	
	}
}
