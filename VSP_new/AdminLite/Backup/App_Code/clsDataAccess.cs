//*****************************************************************************************************************
//Class name : clsDataAccess 
//Defination : This class is the most important class as it does all the updating,Inserting,deleting,Retrieving
//part in the database.The methods in this class is called by all the other methods in other classes.Connection
//with the database is set up here only.We have used Granth SQL database.We added this class after our analysis
//phase.As you will go through the code we have not used any attributes in any class the only thing we have used is
//a query and nothing else. 
//Date Added : 11/11/05
//Author     : Quartz 
//*****************************************************************************************************************
using System;
using System.Configuration;
using System.Data;
using System.Data.Common ;
using System.Data.SqlClient; 
namespace AdminLite
{
	public class clsDataAccess // Class defination
	{
		public clsDataAccess()
		{	}
		SqlConnection mycon = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);  
 		// SqlConnection mycon = new SqlConnection("Data Source=198.87.87.6;POOLING=FALSE;database=exactorder;User ID=exactorder;Password=exactorder");
		//private string query;
		
		public bool openConnection() // Opens database connection with Granth in SQL SERVER
		{
				mycon.Open();
 		return true;
		}
		public void closeConnection() // Closes database connection with Granth in SQL SERVER
		{

		mycon.Close(); 
		mycon = null;
		}
		public SqlDataReader getData(string query) // Getdata from the table required(given in query)in datareader
		{
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandText= query;
			sqlCommand.Connection=mycon;
			SqlDataReader myr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return myr;
			 
		}
		public void saveData(string query) // Save data usually,inserts and updates the data in table given in query
		{
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandText= query;
			sqlCommand.Connection=mycon;
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Dispose();  
			
		}
		public void saveNewData(string query) // Save data usually,inserts and updates the data in table given in query
		{
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandText= query;
			sqlCommand.Connection=mycon;
			sqlCommand.ExecuteNonQuery();
			sqlCommand.Dispose();  
			
		}
		
		public int DeleteData(string query) // Delete data in database depending on the tablename given in query.
		{
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandText= query;
			sqlCommand.Connection=mycon;
			return sqlCommand.ExecuteNonQuery();
			
		}
		public SqlDataAdapter getDataforUpdate(string query) // Get data by paging using datagrid which returns the dataset in datagris
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,mycon);
			DataSet dataSet = new DataSet();
			//sqlDataAdapter.Fill(dataSet,"NewData");
			return sqlDataAdapter;
		}
		public DataSet getDatabyPaging(string query) // Get data by paging using datagrid which returns the dataset in datagris
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,mycon);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			return dataSet;
			
		}
		public int getCheck(string query) // check a particular value to see the validity of mediaid and userid.This method is called in media and user class.
		{
			int i;
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandText= query;
			sqlCommand.Connection=mycon;
			i = Convert.ToInt32(sqlCommand.ExecuteScalar());
			return i;
		}
		public string getValue(string query,int j) // Get a value of limit from the database table Employees to check before issuing media.
		{
			string i ="0";
			
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandText= query;
			sqlCommand.Connection=mycon;
			SqlDataReader myReader = sqlCommand.ExecuteReader();
			
			if( myReader.Read()==true)
			{
				
				i=myReader.GetValue(j).ToString();
				
			}
			return i;
		}
		
		public SqlDataReader Login(string query)//Log in method for LA and Client.
		{
			clsDataAccess myclass = new clsDataAccess();
			myclass.openConnection();
			SqlDataReader dr = myclass.getData(query); //Class Data Access is called here
			return dr; 	
		}
		public DataTable getTablenames()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Information_Schema.Tables where Table_Type = 'BASE TABLE'", mycon);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;

		}

		public int TableWrite(string query) 
		{
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.CommandText= query;
			sqlCommand.Connection=mycon;
			return sqlCommand.ExecuteNonQuery();
			
		}



	}
}
