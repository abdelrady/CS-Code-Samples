using System;
using System.Data;

using System.Data.SqlClient;
using System.Web.Security;


namespace funstore
{
	/// <summary>
	/// Summary description for order.
	/// </summary>
	/// 


	public class OrderDetails 
	{

		public DateTime  OrderDate;
		
		public decimal   OrderTotal;
		public DataSet   OrderItems;
	}

	public class order
	{
		public SqlDataReader GetCustomerOrders(String customerID) 
		{

			// Create Instance of Connection and Command Object
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("OrdersList", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterCustomerid = new SqlParameter("@CustomerID", SqlDbType.Int, 4);
			parameterCustomerid.Value = Int32.Parse(customerID);
			myCommand.Parameters.Add(parameterCustomerid);

			// Execute the command
			myConnection.Open();
			SqlDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

			// Return the datareader result
			return result;
		}


		public OrderDetails GetOrderDetails(int orderID, string customerID) 
		{

			// Create Instance of Connection and Command Object
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlDataAdapter myCommand = new SqlDataAdapter("OrdersDetail", myConnection);

			// Mark the Command as a SPROC
			myCommand.SelectCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterOrderID = new SqlParameter("@OrderID", SqlDbType.Int, 4);
			parameterOrderID.Value = orderID;
			myCommand.SelectCommand.Parameters.Add(parameterOrderID);

			SqlParameter parameterCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int, 4);
			parameterCustomerID.Value = Int32.Parse(customerID);
			myCommand.SelectCommand.Parameters.Add(parameterCustomerID);

			SqlParameter parameterOrderDate = new SqlParameter("@OrderDate", SqlDbType.DateTime, 8);
			parameterOrderDate.Direction = ParameterDirection.Output;
			myCommand.SelectCommand.Parameters.Add(parameterOrderDate);

			

			SqlParameter parameterOrderTotal = new SqlParameter("@OrderTotal", SqlDbType.Money, 8);
			parameterOrderTotal.Direction = ParameterDirection.Output;
			myCommand.SelectCommand.Parameters.Add(parameterOrderTotal);

			// Create and Fill the DataSet
			DataSet myDataSet = new DataSet();
			myCommand.Fill(myDataSet, "OrderItems");
            
			// ship date is null if order doesn't exist, or belongs to a different user
			if (parameterOrderDate.Value != DBNull.Value) 
			{
            
				// Create and Populate OrderDetails Struct using
				// Output Params from the SPROC, as well as the
				// populated dataset from the SqlDataAdapter

				OrderDetails myOrderDetails = new OrderDetails();

				myOrderDetails.OrderDate = (DateTime)parameterOrderDate.Value;
				
				myOrderDetails.OrderTotal = (decimal)parameterOrderTotal.Value;
				myOrderDetails.OrderItems = myDataSet;

				// Return the DataSet
				return myOrderDetails;
			}
			else
				return null;
		}
		public int PlaceOrder(String customerID, string cartID) 
		{
           
            
			// Create Instance of Connection and Command Object
			SqlConnection myConnection = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand("insert_Order", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterCustomerID = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 50);
			parameterCustomerID.Value = customerID;
			myCommand.Parameters.Add(parameterCustomerID);

			SqlParameter parameterCartID = new SqlParameter("@CartID", SqlDbType.NVarChar, 50);
			parameterCartID.Value = cartID;
			myCommand.Parameters.Add(parameterCartID);



			SqlParameter parameterOrderDate = new SqlParameter("@OrderDate", SqlDbType.DateTime, 8);
			parameterOrderDate.Value = DateTime.Now;
			myCommand.Parameters.Add(parameterOrderDate);

			SqlParameter parameterOrderID = new SqlParameter("@OrderID", SqlDbType.Int, 4);
			parameterOrderID.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterOrderID);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();

			// Return the OrderID
			return (int)parameterOrderID.Value;
			
		}



		public order()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
