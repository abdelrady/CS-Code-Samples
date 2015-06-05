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

namespace csharphome.manage.editors
{
	/// <summary>
	/// This page allows an administrator to post articles
	/// </summary>
	public class postarticle : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtArticleSubject;
		protected System.Web.UI.WebControls.TextBox txtPostedBy;
		protected System.Web.UI.WebControls.TextBox txtImage;
		protected System.Web.UI.WebControls.TextBox txtDescription;
		protected System.Web.UI.WebControls.CheckBox chkOutside;
		protected System.Web.UI.WebControls.Button btnPostArticle;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.TextBox txtArticle;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			if (!Convert.ToBoolean(Session["LoggedIn"]) && !Convert.ToBoolean(Session["admin"]))
			{
				liMessage.Text = "<b>Your are either not signed in, or you are not a system administrator.</b>";
			}
			else
			{
				Response.Cache.SetCacheability(HttpCacheability.NoCache);
				txtPostedBy.Text = Convert.ToString(Session["User_Name"]);
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
			this.btnPostArticle.Click += new System.EventHandler(this.btnPostArticle_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnPostArticle_Click(object sender, System.EventArgs e)
		{
			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) 
				{
					/* format:  date & time,
							  title,
							  article,
							  description,
							  image link,
							  is outside link,
							  posted by */

					string strOleDbCmd = 
						string.Format("INSERT INTO articles ([articledate], articlename, article, description, displayimage, outsidelink, postedby, postedbyid) VALUES (#{0}#, '{1}', '{2}', '{3}', '{4}', {5}, '{6}', {7});", 
						DateTime.Now,
						txtArticleSubject.Text.Replace("'", "&#039;"), 
						txtArticle.Text.Replace("'", "&#039;"), 
						txtDescription.Text.Replace("'", "&#039;"), 
						txtImage.Text,
						(chkOutside.Checked == true ? "True" : "False"),
						txtPostedBy.Text.Replace("'", "&#039;"),
						Session["UserID"]);

					f = new csharphome.common.homepage();
					f.SQLNonQuery(Server.MapPath(strDatabase), strOleDbCmd);

					Response.Redirect("../");
				} 
				else 
				{ 
					liMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
				}
			} 
			catch (OleDbException ex) 
			{
				liMessage.Text = "<b>Error while attempting to write database information</b><br>\n" + ex.Message;
			}
		}
	}
}
