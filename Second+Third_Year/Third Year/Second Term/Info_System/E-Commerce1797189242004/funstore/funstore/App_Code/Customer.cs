using System;
using System.Data;
using System.Data.SqlClient;


namespace funstore
{
	/// <summary>
	/// Summary description for Customer.
	/// </summary>
	/// 


	public class CustomerDetails
	{
		public string FirstName;
		public string LastName;
		public string Address;
		
		public string City;
		
		public string Phone;
		
		public string Email;
		public string Password;
		public string CardType;
		public string CardNO;


	}


	public class Customer
	{
		public String AddCustomer(string firstName, string lastName, string address,string city,string phone,string email,string password,string cardtype,string cardno) 
		{
          
			SqlConnection conn = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			//conn.Open();
			SqlCommand myCommand = new SqlCommand( "insert_Customer", conn );
			
			myCommand.CommandType = CommandType.StoredProcedure;



			// Add Parameters to SPROC
			SqlParameter parameterFirstName = new SqlParameter("@FirstName",SqlDbType.NVarChar, 50);
			parameterFirstName.Value = firstName;
			myCommand.Parameters.Add(parameterFirstName);
       
			SqlParameter parameterLastName = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
			parameterLastName.Value = lastName;
			myCommand.Parameters.Add(parameterLastName);
			
			SqlParameter parameterAddress = new SqlParameter("@Address",SqlDbType.NVarChar, 50);
			parameterAddress.Value = address;
			myCommand.Parameters.Add(parameterAddress);

			

			SqlParameter  parameterCity = new SqlParameter("@City",SqlDbType.NVarChar, 50);
			parameterCity.Value = city;
			myCommand.Parameters.Add(parameterCity);

			SqlParameter parameterPhone = new SqlParameter("@Phone",SqlDbType.NVarChar, 50);
			parameterPhone.Value = phone;
			myCommand.Parameters.Add(parameterPhone);


			SqlParameter parameterEmail = new SqlParameter("@Email",SqlDbType.NVarChar, 50);
			parameterEmail.Value = email;
			myCommand.Parameters.Add(parameterEmail);

			SqlParameter parameterPassword = new SqlParameter("@Password",SqlDbType.NVarChar, 50);
			parameterPassword.Value = password;
			myCommand.Parameters.Add(parameterPassword);

			SqlParameter parameterCard = new SqlParameter("@CardType",SqlDbType.NVarChar, 50);
			parameterCard.Value = cardtype;
			myCommand.Parameters.Add(parameterCard);


			SqlParameter parameterCardNO = new SqlParameter("@CardNO",SqlDbType.NVarChar, 50);
			parameterCardNO.Value = cardno;
			myCommand.Parameters.Add(parameterCardNO);



			SqlParameter parameterCustomerID = new SqlParameter("@CustomerID",SqlDbType.Int, 4);
			parameterCustomerID.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterCustomerID);

			try 
			{
				conn.Open();
				myCommand.ExecuteNonQuery();
				conn.Close();

				// Calculate the CustomerID using Output Param from SPROC
				String  customerId =(parameterCustomerID.Value).ToString();

				return customerId;
			}
			catch 
			{
				return String.Empty;
			}
		}

		
		public CustomerDetails GetCustomerDetails(String customerID) 
		{


			SqlConnection conn = new SqlConnection(("server=(local); database=funstore; integrated security=SSPI;").ToString());
			
			//conn.Open();
			SqlCommand myCommand = new SqlCommand( "Customer_Detail", conn );

			 myCommand.CommandType = CommandType.StoredProcedure;

			SqlParameter parameterCustomerID = new SqlParameter("@CustomerID",SqlDbType.Int, 4);
			parameterCustomerID.Value = Int32.Parse(customerID);
			myCommand.Parameters.Add(parameterCustomerID);

			SqlParameter parameterFirstName = new SqlParameter("@FirstName",SqlDbType.NVarChar, 50);
			parameterFirstName.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterFirstName);

			SqlParameter parameterLastName = new SqlParameter("@LastName",SqlDbType.NVarChar, 50);
			parameterLastName.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterLastName);
    

			SqlParameter parameterAddress = new SqlParameter("@Address",SqlDbType.NVarChar, 50);
			parameterAddress.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterAddress);

         
			SqlParameter parameterCity = new SqlParameter("@City",SqlDbType.NVarChar, 50);
			parameterCity.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterCity);
    

			SqlParameter parameterPhone = new SqlParameter("@Phone",SqlDbType.NVarChar, 50);
			parameterPhone.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterPhone);
           

	

			SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
			parameterEmail.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterEmail);

			SqlParameter parameterPassword = new SqlParameter("@Password",SqlDbType.NVarChar, 50);
			parameterPassword.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterPassword);

			SqlParameter parameterCard = new SqlParameter("@CardType",SqlDbType.NVarChar, 50);
			parameterCard.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterCard);

			SqlParameter parameterCardNO = new SqlParameter("@CardNO",SqlDbType.NVarChar, 50);
			parameterCardNO.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterCardNO);

			conn.Open();
			myCommand.ExecuteNonQuery();
			conn.Close();

			
			CustomerDetails myCustomerDetails = new CustomerDetails();

			
			myCustomerDetails.FirstName = (string)parameterFirstName.Value;
            myCustomerDetails.LastName = (string)parameterLastName.Value;
			myCustomerDetails.Password = (string)parameterPassword.Value;
			myCustomerDetails.Email = (string)parameterEmail.Value;
            myCustomerDetails.Address=(string)parameterAddress.Value;
			
			//myCustomerDetails.City=(string)parameterCity.Value;
			myCustomerDetails.Phone=(string)parameterPhone.Value;
			myCustomerDetails.CardType=(string)parameterCard.Value;
			myCustomerDetails.CardNO=(string)parameterCardNO.Value;


			return myCustomerDetails;
		}
		



		public String Login(string email, string password) 
		{
			// Create Instance of Connection and Command Object
			SqlConnection myConnection = new SqlConnection(("server =(local); database=funstore; integrated security=SSPI;").ToString());
			SqlCommand myCommand = new SqlCommand( "Customer_Login", myConnection);

			// Mark the Command as a SPROC
			myCommand.CommandType = CommandType.StoredProcedure;

			// Add Parameters to SPROC
			SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
			parameterEmail.Value = email;
			myCommand.Parameters.Add(parameterEmail);

			SqlParameter parameterPassword = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
			parameterPassword.Value = password;
			myCommand.Parameters.Add(parameterPassword);

			SqlParameter parameterCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int, 4);
			parameterCustomerID.Direction = ParameterDirection.Output;
			myCommand.Parameters.Add(parameterCustomerID);

			// Open the connection and execute the Command
			myConnection.Open();
			myCommand.ExecuteNonQuery();
			myConnection.Close();

			int customerId = (int)(parameterCustomerID.Value);

			if (customerId == 0) 
			{
				return null;
			}
			else 
			{
				return customerId.ToString();
			}
		
		}


		public Customer()
		{

			//
			// TODO: Add constructor logic here
			//
		}
	}
}
