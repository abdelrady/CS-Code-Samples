using System;
using System.Data;
using System.Data.SqlClient;

namespace funstore
{
	/// <summary>
	/// Summary description for cartDB.
	/// </summary>
	public class cartDB
	{
		public SqlDataReader GetItems(string cartID) 
		{

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("Cart_List", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterCartID = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			parameterCartID.Value = cartID;
			myCommand.Parameters.Add(parameterCartID);

			// Execute the command
			myConnection.Open();
			SqlDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

			// Return the datareader result
			return result;
		}

		public void AddItem(string cartID, int productID, int quantity) 
		{

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server =(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("insert_Cart", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterProductID = new SqlParameter("@ProductID", SqlDbType.Int, 4);
			parameterProductID.Value = productID;
			myCommand.Parameters.Add(parameterProductID);

			SqlParameter parameterCartID = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			parameterCartID.Value = cartID;
			myCommand.Parameters.Add(parameterCartID);

			SqlParameter parameterQuantity = new SqlParameter("@Quantity", SqlDbType.Int, 4);
			parameterQuantity.Value = quantity;
			myCommand.Parameters.Add(parameterQuantity);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();
		}

		public void UpdateItem(string cartID, int productID, int quantity) 
		{

			// throw an exception if quantity is a negative number
			if (quantity < 0) 
			{
				throw new Exception("Quantity cannot be a negative number");
			}

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("update_Cart", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterProductID = new SqlParameter("@ProductID", SqlDbType.Int, 4);
			parameterProductID.Value = productID;
			myCommand.Parameters.Add(parameterProductID);

			SqlParameter parameterCartID = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			parameterCartID.Value = cartID;
			myCommand.Parameters.Add(parameterCartID);

			SqlParameter parameterQuantity = new SqlParameter("@Quantity", SqlDbType.Int, 4);
			parameterQuantity.Value = quantity;
			myCommand.Parameters.Add(parameterQuantity);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();
		}


		public void RemoveItem(string cartID, int productID) 
		{

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("Delete_Cart", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterProductID = new SqlParameter("@ProductID", SqlDbType.Int, 4);
			parameterProductID.Value = productID;
			myCommand.Parameters.Add(parameterProductID);

			SqlParameter parameterCartID = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			parameterCartID.Value = cartID;
			myCommand.Parameters.Add(parameterCartID);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();
		}

		public int GetItemCount(string cartID) 
		{

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("Cart_itemCount", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter parameterCartID = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			parameterCartID.Value = cartID;
			myCommand.Parameters.Add(parameterCartID);

			// Add Parameters to SPROC
			SqlParameter parameterItemCount = new SqlParameter("@ItemCount", SqlDbType.Int, 4);
			parameterItemCount.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterItemCount);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();

			// Return the ItemCount (obtained as out paramter of SPROC)
			return ((int)parameterItemCount.Value);
		}
		public decimal GetTotal(string cartID) 
		{

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("Cart_Total", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterCartID = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			parameterCartID.Value = cartID;
			myCommand.Parameters.Add(parameterCartID);

			SqlParameter parameterTotalCost = new SqlParameter("@TotalAmount", SqlDbType.Money, 8);
			parameterTotalCost.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterTotalCost);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();

			// Return the Total
			if (parameterTotalCost.Value.ToString() != "") 
			{
				return (decimal)parameterTotalCost.Value;
			}
			else 
			{
				return 0;
			}
		}
       

		public void MigrateCart(String oldCartId, String newCartId) 
		{

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("Migrate_Cart", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter cart1 = new SqlParameter("@OriginalCartId ", SqlDbType.NVarChar, 50);
			cart1.Value = oldCartId;
			myCommand.Parameters.Add(cart1);

			SqlParameter cart2 = new SqlParameter("@NewCartId ", SqlDbType.NVarChar, 50);
			cart2.Value = newCartId;
			myCommand.Parameters.Add(cart2);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();
		}

		public void EmptyCart(string cartID) 
		{

			// Create Instance of Connection and Command Object
			//SqlConnection myConnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("empty_cart", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter cartid = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			cartid.Value = cartID;
			myCommand.Parameters.Add(cartid);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();
		}
		public String GetShoppingCartId() 
		{

			// Obtain current HttpContext of ASP+ Request
			System.Web.HttpContext context = System.Web.HttpContext.Current;

			// If the user is authenticated, use their customerId as a permanent shopping cart id
			if (context.User.Identity.Name != "") 
			{
				return context.User.Identity.Name;
			}

			// If user is not authenticated, either fetch (or issue) a new temporary cartID
			if (context.Request.Cookies["funstore_CartID"] != null) 
			{
				return context.Request.Cookies["funstore_CartID"].Value;
			}
			else 
			{
				// Generate a new random GUID using System.Guid Class
				Guid tempCartId = Guid.NewGuid();

				// Send tempCartId back to client as a cookie
				context.Response.Cookies["funstore_CartID"].Value = tempCartId.ToString();

				// Return tempCartId
				return tempCartId.ToString();
			}
		}




		public cartDB()
		{

			//
			// TODO: Add constructor logic here
			//
		}
	}
}
