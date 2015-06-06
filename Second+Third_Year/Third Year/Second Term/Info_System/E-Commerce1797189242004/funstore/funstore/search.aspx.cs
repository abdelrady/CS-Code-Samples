using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;


namespace funstore
{
	/// <summary>
	/// Summary description for search.
	/// </summary>
	public partial class search : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			
			
				BindGrid();
			


		}

		public void DataGrid_page(object sender,DataGridPageChangedEventArgs e)
		{
			this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
	
			
			BindGrid();




		}

		
		private void BindGrid()
		{
			SqlConnection conn = new SqlConnection(Application["ConnectionString"].ToString());
			//SqlConnection con = new SqlConnection(Application["ConnectionString"].ToString());
			SqlDataAdapter da = new SqlDataAdapter("Select ProductID, ProductName, Description, " +
				"UnitPrice From Product Where ProductName Like '%" +
				txtsearch.Text + "%' or Description " +
				"Like '%" + txtsearch.Text + "%' Order By " +
				"ProductName",conn );
				
			
				DataSet nds = new DataSet();
				da.Fill(nds);
				this.DataGrid1.DataSource = nds;
				this.DataGrid1.PagerStyle.Mode  = PagerMode.NumericPages;
				this.DataGrid1.DataSource = nds;
			
				this.DataGrid1.PagerStyle.Mode  = PagerMode.NumericPages;
				this.DataGrid1.DataBind();
				conn.Close();
			 
			
//				lblresults.Text="Sorry No Matches Found";
//				this.DataGrid1.DataSource="";
//				this.DataGrid1.DataBind();

			

			


			//ShowStats();



		}

		protected void btnSearch_Click(object sender, System.EventArgs e)
		{
			BindGrid();
		
		}


		
	}
}
