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
	/// Summary description for shoppingcart.
	/// </summary>
	public partial class shoppingcart : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			if (Page.IsPostBack == false) 
			{
				PopulateShoppingCartList();
			}


		}

		void PopulateShoppingCartList() 
		{
			funstore.cartDB cart = new funstore.cartDB();

			// Obtain current user's shopping cart ID
			String cartId = cart.GetShoppingCartId();

			// If no items, hide details and display message
			if (cart.GetItemCount(cartId) == 0) 
			{
				Panel1.Visible=false;
				lberror.Text = "There are currently no items in your shopping cart.";
			}
			else 
			{

				// Databind Gridcontrol with Shopping Cart Items
				this.DataGrid1.DataSource = cart.GetItems(cartId);
				this.DataGrid1.DataBind();

				//Update Total Price Label
				lblTotal.Text = String.Format( "{0:c}", cart.GetTotal(cartId));
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

		protected void btnUpdateCart_Click(object sender, System.EventArgs e)
		{
			UpdateShoppingCartDatabase();
			PopulateShoppingCartList();
			


		}
		void UpdateShoppingCartDatabase() 
		{

			funstore.cartDB cart = new funstore.cartDB();

			// Obtain current user's shopping cart ID
			String cartId = cart.GetShoppingCartId();

			// Iterate through all rows within shopping cart list
			for (int i=0; i < this.DataGrid1.Items.Count; i++) 
			{

				// Obtain references to row's controls
				TextBox quantityTxt = (TextBox) this.DataGrid1.Items[i].FindControl("Quantity");
				CheckBox remove = (CheckBox) this.DataGrid1.Items[i].FindControl("Remove");

				// Wrap in try/catch block to catch errors in the event that someone types in
				// an invalid value for quantity
				int quantity;
				try 
			{
					quantity = Int32.Parse(quantityTxt.Text);

					// If the quantity field is changed or delete is checked
//					if ( quantity != (int)this.DataGrid1.DataKeys[quantity] ||remove.Checked == true) 
//					{

						Label lblProductID = (Label) this.DataGrid1.Items[i].FindControl("ProductID");

						if (quantity == 0 || remove.Checked == true) 
						{
							cart.RemoveItem(cartId, Int32.Parse(lblProductID.Text));
						}
						else 
						{
							cart.UpdateItem(cartId, Int32.Parse(lblProductID.Text),quantity);
						}
//					}
			}
				catch 
				{
				lberror.Text = "There has been a problem with one or more of your inputs.";
			}
			}
		}


		protected void btnShopping_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("default.aspx");

		}

		protected void btnCheckout_Click(object sender, System.EventArgs e)
		{
			UpdateShoppingCartDatabase();

			// If cart is not empty, proceed on to checkout page
			funstore.cartDB cart = new funstore.cartDB();

			// Calculate shopping cart ID
			String cartId = cart.GetShoppingCartId();

			// If the cart isn't empty, navigate to checkout page
			if (cart.GetItemCount(cartId) !=0) 
			{
				Response.Redirect("checkout.aspx");
			}
			else 
			{
				lberror.Text = "You can't proceed to the Check Out page with an empty cart.";
			}


		}
	


		
		}
	
}
