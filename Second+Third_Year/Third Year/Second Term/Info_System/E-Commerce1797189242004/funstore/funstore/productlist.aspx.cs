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
	/// Summary description for productlist.
	/// </summary>
	public partial class productlist : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataList DataList1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
           int categoryId = Int32.Parse(Request.Params["CategoryID"]);

			SqlConnection conn = new SqlConnection(Application["ConnectionString"].ToString());
			SqlCommand cmdSelectAuthors;
			SqlDataReader dtrAuthors;
			//conn = new OleDbConnection( "PROVIDER=Microsoft.Jet.OLEDB.4.0;DATA Source=c:\\funstore.mdb" );
			
			conn.Open();
			cmdSelectAuthors = new SqlCommand( "Select *  FROM  Product where CategoryID="+ categoryId, conn );
			dtrAuthors = cmdSelectAuthors.ExecuteReader();
			
	   
			this.DataList2.DataSource= dtrAuthors;
			this.DataList2.DataBind();

			dtrAuthors.Close();
			conn.Close();





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

		private void DataList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
