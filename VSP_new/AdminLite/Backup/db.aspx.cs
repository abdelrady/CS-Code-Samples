using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
/********************************************************************
	author:		Quartz (quartz@interviewinfo.net) Please keep the comments if you distribute
	created:	18:9:2004   5:55
	created:	11/11/2005
	file base:	db.aspx
	purpose:	list all the records in the table
*********************************************************************/

namespace AdminLite
{
	/// <summary>
	/// Summary description for Template.
	/// </summary>
	public partial class DB : System.Web.UI.Page
	{
		DataTable TempTable;
		DataView TempTableView;
		DataSet mydr;
		//protected System.Web.UI.WebControls.Label lblstatus;
		public string SortField;
		public string sQuery = "";
		public bool userQuery = false;

	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			//			if ((string)Session["Admin"] == "true")
			//			{
			//				
			//				//lblstatus.Text = (string)Session["FirstKey"];
			//			}
			//			else
			//				Response.Redirect("index.aspx");

			    
			if (!IsPostBack) 
			{
				Session["tName"] = Request.QueryString["table"].ToString().Trim();
				Session["qry"] = "Select * from " + Session["tName"];
				lblSQLError.Text = "<font face = 'courier new' size = 2>Enter your SQL query above (<a href='http://www.w3schools.com/sql/sql_where.asp' target = '_blank' >Learn SQL query ^</a>)</font>";
				BindDataGrid();
			} 
			else
			{
				try
				{
					Session["qry"] = txtSQL.Text  ;
					BindDataGrid();
					lblSQLError.Text = "<font face = 'courier new' size = 2>Enter your SQL query above (<a href='http://www.w3schools.com/sql/sql_where.asp' target = '_blank' >Learn SQL query ^</a>)</font>";
				}
				catch(Exception e1)
				{
					Session["qry"] = "Select * from " + Session["tName"];
					txtSQL.Text = "Select * from " + Session["tName"];
					BindDataGrid();
					lblSQLError.Text = "<font face = 'courier new' size = 2><a href='http://www.w3schools.com/sql/sql_where.asp' target = '_blank' >Error:" + e1.Message + " </a></font>";
				}
			}
		
			//lblstatus.Text = "Results of the query: [<b>" + txtSQL.Text + "</b>]";
			
		}
		

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.DGtable.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DGtable_PageIndexChanged);
			this.DGtable.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.DGtable_SortCommand);

		}
		#endregion
		private string GetFirstKeys()
		{
			string returnvalue = "Node";
			DataTable dt = new DataTable();
			
			string query;
			query = "Select * from " + Request.QueryString["table"].ToString().Trim()   ;
				
			clsDataAccess myclass = new clsDataAccess();
			myclass.openConnection();
			mydr = myclass.getDatabyPaging(query);
			returnvalue = mydr.Tables[0].Columns[0].Caption;  
			mydr.Clear();
			return returnvalue;
		}
		private void DGtable_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DGtable.CurrentPageIndex=e.NewPageIndex;
			BindDataGrid();
		}
		private void BindDataGrid()//All the queries are done int his method which send the query to search class which in turns sends it to dataaccess class.
		{
			DGtable.Columns.Clear();  
			Session["FirstKey"] = GetFirstKeys();
			HyperLinkColumn urlView = new HyperLinkColumn();
			urlView.Text = "View";
			urlView.DataNavigateUrlField = Session["FirstKey"].ToString() ;
			urlView.HeaderText = "View";
			urlView.DataNavigateUrlFormatString = "Viewdata.aspx?id={0}"; 

			HyperLinkColumn urlEdit = new HyperLinkColumn();
			urlEdit.Text = "Edit";
			urlEdit.DataNavigateUrlField = Session["FirstKey"].ToString() ;
			urlEdit.HeaderText = "Edit";
			urlEdit.DataNavigateUrlFormatString = "Editdata.aspx?id={0}";

			HyperLinkColumn urlDelete= new HyperLinkColumn();
			urlDelete.Text = "Delete";
			urlDelete.DataNavigateUrlField = Session["FirstKey"].ToString() ;
			urlDelete.HeaderText = "Delete";
			urlDelete.DataNavigateUrlFormatString = "Deletedata.aspx?id={0}";

			// Add three columns to collection.
			DGtable.Columns.Add(urlView);
			DGtable.Columns.Add(urlEdit);
			DGtable.Columns.Add(urlDelete);

			DGtable.DataSource = CreateDataSource(); 
			DGtable.DataBind();
		}

		private void DGtable_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			SortField = (string)e.SortExpression;
			Session["qry"] = "Select * from " + Session["tName"].ToString();
			txtSQL.Text =  Session["qry"].ToString() + " Order by " + SortField ;
			//lblstatus.Text = "Results of the query: [<b>" + txtSQL.Text + "</b>]";
			
			BindDataGrid();
			//txtSQL.Text =   txtSQL.Text + " SortField2:" + SortField;	

		}
		ICollection CreateDataSource() 
		{
			
			DataTable dt = new DataTable();
			Session["tName"] = Request.QueryString["table"].ToString().Trim();
			string query;

			query = Session["qry"].ToString() ;
			
			if (SortField != null)
				{
					if (SortField.Length > 0) 
					{
						txtSQL.Text =   query + " order by " + SortField;	
					}

				}
				else
				{
					txtSQL.Text =   Session["qry"].ToString()  ;
				}
			
			sQuery = txtSQL.Text;
		
			clsDataAccess myclass = new clsDataAccess();
			myclass.openConnection();
			mydr = myclass.getDatabyPaging(query);
							
			//'mydr.Tables[0].PrimaryKey  
			TempTable = new DataTable();
			TempTable = mydr.Tables[0];
			TempTableView = new DataView(TempTable);
			TempTableView.Sort = SortField;
			// Get the number of elements in the array.
			return TempTableView;
		}

		

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("AddData.aspx"); 
		}

		protected void Button2_Click(object sender, System.EventArgs e)
		{
				Session["qry"] = txtSQL.Text  ;
		}

		private void lblSQLError_Click(object sender, System.EventArgs e)
		{
		
		}
		
	}
}
