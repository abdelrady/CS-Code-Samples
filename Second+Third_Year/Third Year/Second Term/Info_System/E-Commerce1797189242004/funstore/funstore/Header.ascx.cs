namespace funstore
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for Header.
	/// </summary>
	public partial class Header : System.Web.UI.UserControl
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
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{

		}
		#endregion

		protected void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("default.aspx");

		}

		protected void btnRegister_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("register.aspx");

		}

		protected void btnCart_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("shoppingcart.aspx");

		}

		protected void btnAbout_Click(object sender, System.EventArgs e)
		{
			
		}

		protected void btnSearch_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("search.aspx");

		}

		protected void btnLogin_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("login.aspx");

		}

		
		
	}
}
