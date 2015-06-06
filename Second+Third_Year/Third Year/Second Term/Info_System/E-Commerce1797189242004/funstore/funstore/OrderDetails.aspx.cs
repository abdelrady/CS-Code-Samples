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

namespace funstore
{
	/// <summary>
	/// Summary description for OrderDetails1.
	/// </summary>
	public partial class OrderDetails1 : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			// Obtain Order ID from QueryString
			int OrderID = Int32.Parse(Request.Params["OrderID"]);

			// Get the customer ID too
			string CustomerId = User.Identity.Name;

			// Obtain Order Details from Database
			funstore.order orderHistory = new funstore.order();
			funstore.OrderDetails myOrderDetails = orderHistory.GetOrderDetails(OrderID, CustomerId);

			// if order was found, display it
			if (myOrderDetails != null) 
			{

				// Bind Items to GridControl
				this.DataGrid1.DataSource = myOrderDetails.OrderItems;
				this.DataGrid1.DataBind();

				// Update labels with summary details
				lbltotal.Text = String.Format( "{0:c}", myOrderDetails.OrderTotal);
				lblid.Text = OrderID.ToString();
				lbldate.Text = myOrderDetails.OrderDate.ToShortDateString();
				//lblShipDate.Text = myOrderDetails.ShipDate.ToShortDateString();
			}
				// otherwise display an error message
			else 
			{

				Label1.Text="Order Not found";
				//detailsTable.Visible = false;
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
	}
}
