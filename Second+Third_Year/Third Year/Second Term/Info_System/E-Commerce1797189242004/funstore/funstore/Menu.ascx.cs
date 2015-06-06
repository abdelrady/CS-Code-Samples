namespace funstore
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using System.Data.SqlClient;


	/// <summary>
	///		Summary description for Menu.
	/// </summary>
	public partial class Menu : System.Web.UI.UserControl
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Application["ConnectionString"].ToString());

			SqlDataAdapter myCommand = new SqlDataAdapter("SELECT * " +
				" from Category" ,conn);
			// Create and fill a DataSet.
			DataSet ds = new DataSet();
			myCommand.Fill(ds);
			// Bind MyDataList to the DataSet. MyDataList is the ID for 
			// the DataList control in the HTML section of the page.
			this.DataList1.DataSource = ds;
			this.DataList1.DataBind();         

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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion
	}
}
