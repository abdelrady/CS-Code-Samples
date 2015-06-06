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
	/// Summary description for checkout1.
	/// </summary>
	public partial class checkout1 : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			
			if (Page.IsPostBack == false) 
			{

				// Calculate end-user's shopping cart ID
				funstore.cartDB cart = new funstore.cartDB();
				String cartId = cart.GetShoppingCartId();

				// Populate datagrid with shopping cart data
				this.DataGrid1.DataSource = cart.GetItems(cartId);
				this.DataGrid1.DataBind();

				// Update total price label
				lbltotal.Text = String.Format( "{0:c}", cart.GetTotal(cartId));
			}
			
			
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

		protected void btnOrder_Click(object sender, System.EventArgs e)
		{
			funstore.cartDB cart = new funstore.cartDB();

			// Calculate end-user's shopping cart ID
			String cartId = cart.GetShoppingCartId();
            funstore.Customer c1= new Customer();
			//string customerID= c1.GetCustomerDetails(User.Identity.Name);

			// Calculate end-user's customerID
			String  id = (User.Identity.Name).ToString();
       if ((cartId != null)) 
			{

//			if ((cartId != null) && (id != "")) 
//			{

				// Place the order
				funstore.order ordersDatabase = new funstore.order();
				int orderId = ordersDatabase.PlaceOrder(id, cartId);

				//Update labels to reflect the fact that the order has taken place
				//Header.Text="Check Out Complete!";
				//Message.Text = "<b>Your Order Number Is: </b>" + orderId;
				//				SubmitBtn.Visible = false;

				Response.Redirect("thankyou.aspx");

			}
			

		
		}
	}
}
