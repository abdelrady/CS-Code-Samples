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

namespace csharphome
{
	/// <summary>
	/// This page allows the user to view articles
	/// </summary>
	public class viewarticle : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liArticle;

		const string strDatabase = "./home.mdb";
		public string strArticleTitle;
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			string strMsgId;
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			strMsgId = Request.QueryString["id"];
				if (strMsgId == string.Empty) 
				{
					liArticle.Text = "No article id was specified.";
					return;
				}

			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM articles WHERE articleid=" + strMsgId);

				if (dbSet != null) 
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
					{
						strArticleTitle = Convert.ToString(dbRow["articlename"]);
						liArticle.Text = "<h3>" + Convert.ToString(dbRow["articlename"]) + "</h3>\n\n" +
							"<h5>" + Convert.ToString(dbRow["description"]) + "</h5>\n" + Convert.ToString(dbRow["article"]);
						}
				}

				dbSet.Dispose();
			}
			catch (Exception ex) 
			{
				liArticle.Text = "An exception was thrown:<br>" + ex.Message;
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
