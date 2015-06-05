using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
/********************************************************************
	author:		Quartz (quartz@interviewinfo.net) Please keep the comments if you distribute
	created:	18:9:2004   5:55
	created:	11/11/2005
	file base:	Index.aspx
	purpose:	Login/ default page
*********************************************************************/

namespace AdminLite
{
	/// <summary>
	/// Summary description for Template.
	/// </summary>
	public partial class Index : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			if(!Page.IsPostBack)
			{

			}
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

		}
		#endregion

//		private void Log_Click(object sender, System.EventArgs e)
//		{
//			
//				string uname;
//				uname = txtemail.Text.ToString() ;
//  
//				string pass;
//				pass = txtpwd.Text.ToString()  ; 
//
//				string s;
//
//				s = "SELECT * FROM " + ConfigurationSettings.AppSettings["AdminTable"] + " where Username ='" + uname + "' AND Password ='" + pass + "'"  ;
//				clsDataAccess mylogin = new clsDataAccess();//Login class is called
//				SqlDataReader mydr1 = mylogin.Login(s);
//				
//				while(mydr1.Read())
//				{
//					if (mydr1.GetValue(5).ToString().Trim()  == "Admin")
//					{
//						Session["userfullname"]=mydr1.GetValue(3).ToString().Trim() + " " + mydr1.GetValue(4).ToString().Trim();
//						Session["Admin"] = "true";
//						Response.Redirect("DBMain.aspx");
//					}
//					else
//					{
//						lblError.Text=  "Error ! - Invalid Login"; 
//					}
//					
//				}
//				lblError.Text= "Error ! - Invalid Login 2" ; 
//				mydr1.Close();
//			
//		}
//		private void btnLogin_Click(object sender, System.EventArgs e)
//		{
//			txtemail.Text = "";
//			txtpwd.Text = "";
//		}

	}
}
