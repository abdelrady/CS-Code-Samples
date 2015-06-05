using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Collections.Specialized;

namespace csharphome.feat.bb
{
	/// <summary>
	/// This page allows a user to post a message on the message board
	/// </summary>
	public class post : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.TextBox txtSubject;
		protected System.Web.UI.HtmlControls.HtmlTextArea txtBody;
		protected System.Web.UI.WebControls.Button btnSubmit;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			if (!Convert.ToBoolean(Session["LoggedIn"]))
			{
				// if not redirect to the login page...
				Response.Redirect("../login.aspx");
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
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			try
			{
				NameValueCollection frmWeb = Request.Form;
				string strFormattedBody = txtBody.Value;
				string strFormattedTitle = txtSubject.Text;
				
				strFormattedBody = strFormattedBody.Replace("\n", "<br>").Replace("'", "&#039;");
				strFormattedTitle = strFormattedTitle.Replace("\n", "<br>").Replace("'", "&#039;");

				f.SQLNonQuery(Server.MapPath(strDatabase), 
					string.Format("INSERT INTO messages ([date], posticon, topic, postedbyid, postedby, body) VALUES" +
					"(#{0}#, {1}, '{2}', {3}, '{4}', '{5}');", DateTime.Now, frmWeb["msg_icon"],
					strFormattedTitle, Session["UserId"], Session["User_name"], strFormattedBody));
				
				Response.Redirect("./");
			}
			catch (OleDbException ex)
			{
				liMessage.Text = "Error while attempting to write database information<br>\n" + ex.Message;
			}
		}
	}
}
