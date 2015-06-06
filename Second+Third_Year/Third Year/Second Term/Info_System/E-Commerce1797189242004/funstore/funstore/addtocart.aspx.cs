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
	/// Summary description for addtocart.
	/// </summary>
	public partial class addtocart : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if (Request.Params["ProductID"] != null) 
			{
        
				funstore.cartDB cart = new funstore.cartDB();
            
				// Obtain current user's shopping cart ID  
				String cartId = cart.GetShoppingCartId();   
            
				// Add Product Item to Cart
				cart.AddItem(cartId, Int32.Parse(Request.Params["ProductID"]), 1);
			}  
        
			Response.Redirect("shoppingcart.aspx");
	
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
	}
}
