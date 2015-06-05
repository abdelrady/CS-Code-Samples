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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Byte;

namespace PicManager
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.LinkButton lk_upload;
		protected System.Web.UI.WebControls.TextBox Comment;
		protected System.Web.UI.WebControls.Button Upload;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			
		
		}

		private void InitializeComponent()
		{
			this.Comment.TextChanged += new System.EventHandler(this.Comment_TextChanged);

		}

		private void Comment_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		
//		public void CreateMyOleDbCommand() 
//		{
//			string mySelectQuery = "SELECT * FROM PicCategory ORDER BY ID";
//			OleDbCommand myCommand = new OleDbCommand(mySelectQuery);
//			myCommand.Connection = new OleDbConnection
//				("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PicManager.MDB");
//			myCommand.CommandTimeout = 20;
			//foreach (DataRow datarow in dataTable.Rows)
			//{
			//	ddl_category.Items.Add(datarow["PicCategoryList"]+"("+datarow["ID"]+")");
			//}
		}
		
//		public void InsertRow(string myConnectionString) 
//		{
			// If the connection string is null, use a default.
//			if(myConnectionString == "") 
//			{
//				myConnectionString = "Provider=SQLOLEDB;Data Source=localhost;Initial Catalog=Northwind;" + 
//					"Integrated Security=SSPI;";
//			}
//			OleDbConnection myConnection = new OleDbConnection(myConnectionString);
//			string myInsertQuery = "INSERT INTO Customers (CustomerID, CompanyName) Values('NWIND', 'Northwind Traders')";
//			OleDbCommand myCommand = new OleDbCommand(myInsertQuery);
//			myCommand.Connection = myConnection;
//			myConnection.Open();
//			myCommand.ExecuteNonQuery();
//			myCommand.Connection.Close();
//		}


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
			this.Upload.Click += new System.EventHandler(this.OnUpload);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		

		private void OnUpload(object sender, System.EventArgs e)
		{
			
			int len = Upload.PostedFile.ContentLength;      
			byte[] pic = new byte[len];      
			Upload.PostedFile.InputStream.Read (pic, 0, len);


			// Insert the image and comment into the database      
			SqlConnection connection = new SqlConnection("server=localhost;database=iSense;uid=sa;pwd=");
			try {        
				connection.Open ();        
				SqlCommand cmd = new SqlCommand ("insert into Image " + "(Picture, Comment) values (@pic, @text)", connection);        
				cmd.Parameters.Add ("@pic", pic);        
				cmd.Parameters.Add ("@text", Comment.Text);        
				cmd.ExecuteNonQuery ();      
				}      
			finally 
			{        
				connection.Close ();      
			}
		}
}
