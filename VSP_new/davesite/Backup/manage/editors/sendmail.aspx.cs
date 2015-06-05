using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Web;
using System.Web.Mail;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace csharphome.manage.editors
{
	/// <summary>
	/// This page allows for an administrator to send mail through a web browser
	/// </summary>
	public class sendmail : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.TextBox txtFromAddr;
		protected System.Web.UI.WebControls.TextBox txtToAddr;
		protected System.Web.UI.WebControls.TextBox txtSubject;
		protected System.Web.UI.WebControls.TextBox txtBody;
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Button cmbSendEmail;
		protected System.Web.UI.WebControls.CheckBox chkSendHTML;

		const string strDatabase = "../../home.mdb";
		protected System.Web.UI.WebControls.CheckBox chkSendDiff;
		protected System.Web.UI.WebControls.TextBox txtMailServer;
		protected System.Web.UI.WebControls.TextBox txtEdited;
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
				if (txtEdited.Text != "YES") 
				{
					// Load the webmaster config file
					StreamReader objReader = new StreamReader(Server.MapPath("../../webmaster.txt"));
					txtFromAddr.Text = objReader.ReadToEnd();	
					objReader.Close();
					// Load the mailserver config file
					StreamReader p = new StreamReader(Server.MapPath("../../mailserver.txt"));
					txtMailServer.Text = p.ReadToEnd();
					p.Close();

					if (txtEdited.Text == "NO") txtEdited.Text = "YES";
				}
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
			this.cmbSendEmail.Click += new System.EventHandler(this.cmbSendEmail_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void cmbSendEmail_Click(object sender, System.EventArgs e)
		{
			if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
			{
				try
				{
					MailMessage objMail = new MailMessage();
				
					objMail.From = txtFromAddr.Text;
					objMail.To = txtToAddr.Text;
					objMail.Subject = txtSubject.Text;

					objMail.BodyFormat = (chkSendHTML.Checked == false ? MailFormat.Text : MailFormat.Html);
					objMail.Body = txtBody.Text;
					if (chkSendDiff.Checked == true)
					{
						SmtpMail.SmtpServer = txtMailServer.Text;
					}
					else
					{
						// Load the mailserver config file
						StreamReader p = new StreamReader(Server.MapPath("../../mailserver.txt"));
						SmtpMail.SmtpServer = p.ReadToEnd();
						p.Close();
					}
					SmtpMail.Send(objMail);
				
					liMessage.Text = "Sent email to:  <b>'" + txtToAddr.Text.Replace("<", "&lt;").Replace(">", "&gt;") + "'</b>";
				}
				catch (Exception ex)
				{
					liMessage.Text = "Could not send mail to:  '" + txtToAddr.Text.Replace("<", "&lt;").Replace(">", "&gt;") + "':<br>" + ex.Message;
				}
			}
		}
	}
}
