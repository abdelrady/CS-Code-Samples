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
	/// This page allows for the administrator to edit articles
	/// </summary>
	public class editarticle : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtArticleSubject;
		protected System.Web.UI.WebControls.TextBox txtId;
		protected System.Web.UI.WebControls.TextBox txtPostedBy;
		protected System.Web.UI.WebControls.TextBox txtImage;
		protected System.Web.UI.WebControls.TextBox txtDescription;
		protected System.Web.UI.WebControls.CheckBox chkOutside;
		protected System.Web.UI.WebControls.TextBox txtArticle;
		protected System.Web.UI.WebControls.Button btnPostArticle;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.TextBox txtEdited;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			// We don't want this to be stored locally
			Response.Cache.SetCacheability(HttpCacheability.NoCache);

			string strMsgId = Request.QueryString["id"];
			if (strMsgId == String.Empty) 
			{
				liMessage.Text = "No article id was specified.";
				return;
			}

			txtId.Text = strMsgId;

			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					if (txtEdited.Text != "YES") 
					{
						DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM articles WHERE articleid=" + strMsgId);

						if (dbSet != null) 
						{
							foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
							{
								txtArticleSubject.Text = Convert.ToString(dbRow["articlename"]).Replace("&#039;", "'");
								txtPostedBy.Text = Convert.ToString(dbRow["postedby"]).Replace("&#039;", "'");
								txtImage.Text = Convert.ToString(dbRow["displayimage"]);
								txtDescription.Text = Convert.ToString(dbRow["description"]).Replace("&#039;", "'");
								chkOutside.Checked = Convert.ToBoolean(dbRow["outsidelink"]);
								txtArticle.Text = Convert.ToString(dbRow["article"]).Replace("&#039;", "'");
							}
						}

						dbSet.Dispose();

						if (txtEdited.Text == "NO") txtEdited.Text = "YES";
					}
				} 
				else 
				{
					liMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
				}
			}
			catch (Exception ex)
			{
				liMessage.Text = "<b>An exception was thrown:</b><br>" + ex.Message;
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

					OleDbConnection odbConnect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath(strDatabase) + ";Persist Security Info=False;");
					odbConnect.Open();

					string[] strUpdateWhat = {"[articledate]=#" + DateTime.Now + "#", "articlename='" + txtArticleSubject.Text.Replace("'", "&#039;") + "'", "article='" + txtArticle.Text.Replace("'", "&#039;") + "'", "description='" + txtDescription.Text.Replace("'", "&#039;") + "'", "displayimage='" + txtImage.Text + "'", "outsidelink=" + (chkOutside.Checked == true ? "True" : "False"), "postedby='" + txtPostedBy.Text.Replace("'", "&#039;") + "'"};

					for (int i = strUpdateWhat.GetLowerBound(0); i <= strUpdateWhat.GetUpperBound(0); i++) 
					{
						// Update what we want.
						OleDbCommand odbCommand = new OleDbCommand("UPDATE articles SET " + strUpdateWhat[i] + " WHERE articleid=" + txtId.Text, odbConnect);
						odbCommand.ExecuteNonQuery();
						odbCommand.Dispose();

						liMessage.Text = "UPDATE articles SET " + strUpdateWhat[i] + " WHERE articleid=" + txtId.Text + "<br>";
					}
					odbConnect.Close();

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
