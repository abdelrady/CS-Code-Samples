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
using System.Web.Security;


namespace funstore
{
	/// <summary>
	/// Summary description for login.
	/// </summary>
	public partial class login : System.Web.UI.Page
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

		private void LinkRegister_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("register.aspx");

		}

		protected void btnLogin_Click(object sender, System.EventArgs e)
		{
			if (Page.IsValid == true) 
			{

				// Save old ShoppingCartID
				funstore.cartDB shoppingCart = new funstore.cartDB();
				String tempCartID = shoppingCart.GetShoppingCartId();

				// Attempt to Validate User Credentials using Customers class
				funstore.Customer accountSystem = new funstore.Customer();
				String customerId = accountSystem.Login(txtmail.Text, txtpass.Text);
                 //funstore.CustomerDetails cutomerId= accountSystem.GetCustomerDetails(customerId);
				

				if (customerId != "") 
				{

					// Migrate any existing shopping cart items into the permanent shopping cart
					shoppingCart.MigrateCart(tempCartID, customerId);

					// Lookup the customer's full account details
					funstore.CustomerDetails customerDetails = accountSystem.GetCustomerDetails(customerId);
                    

					// Store the user's fullname in a cookie for personalization purposes
					Response.Cookies["funstore_FirstName"].Value = customerDetails.FirstName;
                    
					


					// Make the cookie persistent only if the user selects "persistent" login checkbox
					if (this.CheckBox1.Checked == true) 
					{
						Response.Cookies["funstore_FirstName"].Expires = DateTime.Now.AddMonths(1);
					}

					// Redirect browser back to originating page
					FormsAuthentication.RedirectFromLoginPage(customerId, this.CheckBox1.Checked);
				}
				else 
				{
					lblerror.Text = "Failed To Login";
				}
			}
		}

		private void btnRegister_Click(object sender, System.EventArgs e)
		{
		   Response.Redirect("register.aspx");
		}

		protected void btnReset_Click(object sender, System.EventArgs e)
		{
			txtmail.Text="";
			txtpass.Text="";

		}

		private void Linkregister_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("register.aspx");

		}

		
	}
}
