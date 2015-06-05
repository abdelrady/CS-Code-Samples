using System;
using System.Collections;
using System.Collections.Specialized;
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
	/// This page allows administrators to edit a message on the message board
	/// </summary>
	public class editbb : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.TextBox txtSubject;
		protected System.Web.UI.WebControls.Button btnSubmit;
		protected System.Web.UI.HtmlControls.HtmlTextArea txtBody;
		protected System.Web.UI.WebControls.TextBox txtEdited;
		protected System.Web.UI.WebControls.TextBox txtId;

		const string strDatabase = "../../home.mdb";		
		private csharphome.common.homepage f;
		public string strIcon;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			// We don't want this to be stored locally
			Response.Cache.SetCacheability(HttpCacheability.NoCache);

			string strMsgId = Request.QueryString["msgid"];
			if (strMsgId == String.Empty) 
			{
				liMessage.Text = "No message id was specified.";
				return;
			}

			txtId.Text = strMsgId;

			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					if (txtEdited.Text != "YES") 
					{
						DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM messages WHERE msgid=" + strMsgId);

						if (dbSet != null) 
						{
							foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
							{
								txtSubject.Text = Convert.ToString(dbRow["topic"]).Replace("<br>", "\n").Replace("&#039;", "'");
								txtBody.Value = Convert.ToString(dbRow["body"]).Replace("<br>", "\n").Replace("&#039;", "'");
								strIcon = Convert.ToString(dbRow["posticon"]);
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

				string[] strUpdateWhat = {"[date]", "#" + DateTime.Now + "#", "topic", "'" + strFormattedTitle + "'", "body", "'" + strFormattedBody + "'", "posticon", Convert.ToString(frmWeb["msg_icon"])};
            
				for (int a = strUpdateWhat.GetLowerBound(0); a <= strUpdateWhat.GetUpperBound(0); a = a + 2)
				{
					string strOleDbCmd = "UPDATE messages SET " + strUpdateWhat[a] + " = " + strUpdateWhat[a + 1] + " WHERE msgid = " + Request.QueryString["msgid"];

					f.SQLNonQuery(Server.MapPath(strDatabase), strOleDbCmd);
				}

				Response.Redirect("../bb.aspx");
			}
			catch (Exception ex)
			{
				liMessage.Text = "Error while attempting to write database information<br>\n" + ex.Message;
			}
		}
	}
}
