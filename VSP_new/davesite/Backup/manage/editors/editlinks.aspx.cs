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
	/// Summary description for editlinks.
	/// </summary>
	public class editlinks : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtId;
		protected System.Web.UI.WebControls.TextBox txtLinkData;
		protected System.Web.UI.WebControls.Button btnPostEditedLink;
		protected System.Web.UI.WebControls.TextBox txtEdited;
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal literalMessage;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));
			
			string strLinkId;
			strLinkId = Request.QueryString["id"];
			if (strLinkId == string.Empty) 
			{
				literalMessage.Text = "No article id was specified.";
				return;
			}
			
			txtId.Text = strLinkId;

			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					if (txtEdited.Text != "YES") 
					{
						DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM links WHERE linkid=" + strLinkId);
												
						if (dbSet != null) 
						{
							foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
							{
								txtLinkData.Text = Convert.ToString(dbRow["linkdata"]).Replace("<br>", "\n").Replace("&#039;", "'");
							}
						}
                        
						dbSet.Dispose();
                        
						if (txtEdited.Text == "NO") txtEdited.Text = "YES";
					}
				}
				else 
				{
					literalMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
				} 
			}
			catch (Exception ex) 
			{
				literalMessage.Text = "<b>An exception was thrown:</b><br>" + ex.Message;
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
			this.btnPostEditedLink.Click += new System.EventHandler(this.btnPostEditedLink_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnPostEditedLink_Click(object sender, System.EventArgs e)
		{
			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					f = new csharphome.common.homepage();
					f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE links SET linkdata='" + txtLinkData.Text.Replace("\n", "<br>").Replace("'", "&#039;") + "' WHERE linkid=" + txtId.Text);
			
					Response.Redirect("../");
				}
				else 
				{
					literalMessage.Text = "<b>Your are either not signed in, or you are not a system administrator.</b>";
				}
			}
			catch (OleDbException ex) 
			{ 
				literalMessage.Text = "<b>Error while attempting to write database information</b><br>\n" + ex.Message;
			}
		}
	}
}
