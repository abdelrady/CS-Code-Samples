using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace PicManager
{
	/// <summary>
	/// Summary description for WebForm2.
	/// </summary>
	public class WebForm2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			MemoryStream stream = new MemoryStream ();      
			SqlConnection connection = new SqlConnection (@"server=INDIA\INDIA;database=iSense;uid=sa;pwd=india");      
			try 
			{          
				connection.Open ();          
				SqlCommand command = new SqlCommand ("select Picture from Image", connection);
				byte[] image = (byte[]) command.ExecuteScalar ();          
				stream.Write (image, 0, image.Length);          
				Bitmap bitmap = new Bitmap (stream);          
				Response.ContentType = "image/gif";          
				bitmap.Save (Response.OutputStream, ImageFormat.Gif);      
			}      
			finally 
			{          
				connection.Close ();          
				stream.Close ();      
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
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("WebForm1.aspx");
		}
	}
}
