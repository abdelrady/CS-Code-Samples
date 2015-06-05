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

namespace csharphome.manage.editors
{
	/// <summary>
	/// This page allows administrators to post new voting booths
	/// </summary>
	public class postbooth : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.TextBox txtBoothName;
		protected System.Web.UI.WebControls.TextBox txtBooth;
		protected System.Web.UI.WebControls.TextBox txtDescription;
		protected System.Web.UI.WebControls.Button btnSubmit;

		const string strDatabase = "../../home.mdb";
		protected System.Web.UI.WebControls.TextBox txtBaseName;		
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			// We don't want this to be stored locally
			Response.Cache.SetCacheability(HttpCacheability.NoCache);
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
			if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
			{
				string basename = txtBaseName.Text.Replace("'", "&#039;");
				f.SQLNonQuery(Server.MapPath(strDatabase),
					string.Format("INSERT INTO booths (votename, displayname, description) VALUES ('{0}', '{1}', '{2}');",
					basename,
                    txtBoothName.Text.Replace("'", "&#039;"),
					txtDescription.Text.Replace("'", "&#039;").Replace("\n", "<br>")));
				f.SQLNonQuery(Server.MapPath(strDatabase),
					"CREATE TABLE " + basename + " (voteid COUNTER, votename TEXT, votevalue TEXT)");
				string[] choices = txtBooth.Text.Replace("'", "&#039;").Split('\n');
				for (int i = choices.GetLowerBound(0); i <= choices.GetUpperBound(0); i++)
				{
					f.SQLNonQuery(Server.MapPath(strDatabase),
						string.Format("INSERT INTO " + basename + " (votename, votevalue) VALUES ('{0}', '{1}');",
						choices[i], "0"));
				}

				Response.Redirect("../vote.aspx");
			}
			else
			{
				liMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
			}
		}
	}
}
