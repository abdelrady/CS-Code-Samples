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
using System.Web.Security;



namespace funstore
{
	/// <summary>
	/// Summary description for register.
	/// </summary>
	public partial class register : System.Web.UI.Page
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

		protected void Button2_Click(object sender, System.EventArgs e)
		{
			txtfname.Text="";
			txtlname.Text="";
			txtaddress.Text="";
			
			txtcity.Text="";
			txtphone.Text="";
		

			txtfax.Text="";
			txtmail.Text="";
			txtpass.Text="";
			txtp1.Text="";
			txtcardno.Text="";


		}

		protected void btnRegister_Click(object sender, System.EventArgs e)
		{
			if (Page.IsValid == true) 
			{

				// Store off old temporary shopping cart ID
				funstore.cartDB shoppingCart = new funstore.cartDB();
				String tempCartId = shoppingCart.GetShoppingCartId();

//				// Add New Customer to CustomerDB database
			funstore.Customer accountSystem = new funstore.Customer();
			String  customerId = accountSystem.AddCustomer(txtfname.Text,txtlname.Text,txtaddress.Text ,txtcity.Text,txtphone.Text,txtmail.Text,txtpass.Text,txtcardt.Text,txtcardno.Text );

				


		if (customerId != "") 
			{

				// Set the user's authentication name to the customerId
				FormsAuthentication.SetAuthCookie(customerId, false);
               
					// Migrate any existing shopping cart items into the permanent shopping cart
				shoppingCart.MigrateCart(tempCartId, customerId);

					// Store the user's fullname in a cookie for personalization purposes
				Response.Cookies["funstore_FirstName"].Value = Server.HtmlEncode(txtfname.Text);

					// Redirect browser back to shopping cart page
				Response.Redirect("shoppingcart.aspx");
			}
			 else{
				
			lblerror.Text = customerId.ToString();				
		          }
			}



		}

	}
}
