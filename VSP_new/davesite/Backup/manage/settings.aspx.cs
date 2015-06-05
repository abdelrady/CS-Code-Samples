using System;
using System.IO;
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

namespace csharphome.manage
{
	/// <summary>
	/// This page allows administrators to modify more advance settings
	/// </summary>
	public class settings : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtStyleSheet;
		protected System.Web.UI.WebControls.TextBox txtWebmasterEmail;
		protected System.Web.UI.WebControls.TextBox txtSMTPServer;
		protected System.Web.UI.WebControls.Literal liMessage;

		const string strDatabase = "../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			/* If the Session[] object shows that the person is signed in and
			 * an admin do the following */

			if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
			{
				/* Check to see if the user requested updates to something first
				 * so that they don't get old data */
				NameValueCollection frmWeb = Request.Form;
				if (frmWeb != null) 
				{
					switch (frmWeb["__EVENTTARGET"])
					{
						case "updatecss":
							StreamWriter a = new StreamWriter(Server.MapPath("../styles.css"), false);
							a.Write(txtStyleSheet.Text);
							a.Close();
							Response.Redirect("./settings.aspx");
							break;
						case "updateadminemail":
							StreamWriter w = new StreamWriter(Server.MapPath("../webmaster.txt"), false);
							w.Write(txtWebmasterEmail.Text);
							w.Close();
							break;
						case "updatemailserver":
							StreamWriter b = new StreamWriter(Server.MapPath("../mailserver.txt"), false);
							b.Write(txtSMTPServer.Text);
							b.Close();
							break;
					}
				}

				// Load the Style Sheet first
				StreamReader s = new StreamReader(Server.MapPath("../styles.css"));
				txtStyleSheet.Text = s.ReadToEnd();
				s.Close();
				// Load the webmaster config file
				StreamReader p = new StreamReader(Server.MapPath("../webmaster.txt"));
				txtWebmasterEmail.Text = p.ReadToEnd();
				p.Close();
				// Load the mailserver config file
				StreamReader m = new StreamReader(Server.MapPath("../mailserver.txt"));
				txtSMTPServer.Text = m.ReadToEnd();
				m.Close();

			}
			else
			{
				liMessage.Text = "<b>Your are either not signed in, or you are not a system administrator.</b>";
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
