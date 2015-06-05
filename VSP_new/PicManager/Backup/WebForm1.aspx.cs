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

namespace PicManager
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button;
		protected System.Web.UI.WebControls.TextBox Comment;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.HtmlControls.HtmlInputFile Upload;
	
		private void Page_Load(object sender, System.EventArgs e)
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
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		public void OnUpload(Object sender, EventArgs e)
		{
			// Create a byte[] from the input file      
			int len = Upload.PostedFile.ContentLength;      
			byte[] pic = new byte[len];      
			Upload.PostedFile.InputStream.Read (pic, 0, len);     
			// Insert the image and comment into the database     
			SqlConnection connection = new SqlConnection (@"server=INDIA\INDIA;database=iSense;uid=sa;pwd=india");  
			try 
			{        
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

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("WebForm2.aspx");
		}

	}
}
