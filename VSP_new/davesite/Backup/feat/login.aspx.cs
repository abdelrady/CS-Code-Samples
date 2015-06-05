using System;
using System.IO;
using System.Text;
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
using System.Security.Cryptography;

namespace csharphome.feat
{
	/// <summary>
	/// This is the login page for my web site
	/// </summary>
	public class login : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtUsername;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.Button btnSignin;
		protected System.Web.UI.WebControls.Button btnSignout;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.LinkButton lnkForgotPassword;

		const string strDatabase = "../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));
			Response.Cache.SetCacheability(HttpCacheability.NoCache); // Don't allow this page to be saved to client

			if (Convert.ToBoolean(Session["LoggedIn"]) == false)
			{
				liMessage.Text = "Please sign in below";
			}
			else
			{
				liMessage.Text = Session["User_Name"] + " is currently signed in. Please sign out if this isn't you.";
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
			this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
			this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
			this.lnkForgotPassword.Click += new System.EventHandler(this.lnkForgotPassword_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnSignin_Click(object sender, System.EventArgs e)
		{
			try 
			{
				Encoding en = Encoding.Default;
				csharphome.common.SymmCrypto h = new csharphome.common.SymmCrypto(common.SymmCrypto.SymmProvEnum.DES);
				//Response.Write(Convert.ToBase64String(en.GetBytes(h.Encrypting("reset", "pwd"))));
				//return;
				
				f = new csharphome.common.homepage();
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members WHERE username ='" + txtUsername.Text + "'"); // new DataSet();
				bool boolSuccess = false;

				if (dbSet != null) 
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
					{
						if (h.Decrypting(en.GetString(Convert.FromBase64String(Convert.ToString(dbRow["pass"]))), "pwd") == txtPassword.Text) 
						{
							liMessage.Text = "Login Successfully<br>";
							// Logged in?
							Session["LoggedIn"] = true;
							Session.Timeout = 60;
							// User info
							Session["User_Name"] = dbRow["username"];
							Session["UserID"] = dbRow["usrid"];
							Session["User_Email"] = dbRow["mail"];
							Session["User_Info"] = dbRow["usrdescription"];
							Session["admin"] = dbRow["admin"];
							Session["su"] = dbRow["superuser"];
							Session["User_SignupDate"] = dbRow["signupdate"];
							Session["User_LastIP"] = dbRow["ipaddr"];
							Session["User_LastLogin"] = dbRow["lastlogindate"];
							boolSuccess = true;
						}
					}
				}

				dbSet.Dispose();

				if (boolSuccess) 
				{
					string v = "ipaddr\t'" + Request.ServerVariables["REMOTE_ADDR"] + "'\t" +
						"lastlogindate\t'" + DateTime.Now.ToString() + "'";
					UpdateUserStatistics(Convert.ToString(Session["User_Name"]), v);
					Response.Redirect("../");
					return;
				}

				liMessage.Text = "Could not log you in, please check your username and password.";
			}
			catch
			{
				liMessage.Text = "There was an error while accessing the database.<br>Please try agian later.";
			}
		}

		private void btnSignout_Click(object sender, System.EventArgs e)
		{
			Session.Abandon();
			Response.Redirect("../");
		}

		private void UpdateUserStatistics(string strUsername, string statistic) 
		{
			f = new csharphome.common.homepage();
			string[] statistics = statistic.Split('\t');
			for (int i = statistics.GetLowerBound(0); i <= statistics.GetUpperBound(0); i = i + 2)
			{
				f.SQLNonQuery(Server.MapPath(strDatabase),
					string.Format("UPDATE members SET {0}={1} WHERE username = '" + strUsername + "'", statistics[i], statistics[i + 1])); // '" + ipAddress + "' );	
			}
		}

		private string[] GetUserEmail(string strUsername) 
		{
			f = new csharphome.common.homepage();
			DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members WHERE username ='" + strUsername + "'");
			string strUserInfo = string.Empty;

			if (dbSet != null) 
			{
				foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
				{
					strUserInfo += Convert.ToString(dbRow["mail"]) + '\n' + Convert.ToString(dbRow["pass"]);
				}
			}

			dbSet.Dispose();

			return strUserInfo.Split('\n');
		}

		private void lnkForgotPassword_Click(object sender, System.EventArgs e)
		{
			if (txtUsername.Text == string.Empty)
			{
				liMessage.Text = "<b>Please type your username</b>";
				return;
			}
			
			try
			{
				string strWebmaster;
				StreamReader objReader = new StreamReader(Server.MapPath("../webmaster.txt"));
				strWebmaster = objReader.ReadToEnd();
				objReader.Close();
				
				MailMessage objMail = new MailMessage();
				string[] strUser = GetUserEmail(txtUsername.Text);
				
				objMail.From = "David's C# Web Site <no-reply@davehome>";
				objMail.To = strUser[0];
				objMail.Subject = "Your password";
				objMail.BodyFormat = MailFormat.Text;
				objMail.Body = string.Format("Please do not reply to this email message!\n" + 
					"No one will be able to respond. If you have any questions please contact the webmaster at:\n\n{0}\n\n\n" +
					"This email is in regard of your password for the site:\n\n" +
					"Your password for:\t{1}\n\t\t\t\t{2}\n\n" + 
					"Please visit! http://www26.brinkster.com/bgdave12/ (redirection site)\n\n\n\n" +
					"Your password was requested from: {3}", strWebmaster, txtUsername.Text, strUser[1], Request.ServerVariables["remote_host"]);

				// Load the mailserver config file
				StreamReader m = new StreamReader(Server.MapPath("../mailserver.txt"));
				SmtpMail.SmtpServer = m.ReadToEnd();
				m.Close();

				SmtpMail.Send(objMail);
				
				liMessage.Text = "<b>Sent email to:  " + strUser[0] + "</b>";
			}
			catch (Exception ex)
			{
				liMessage.Text = "Could not send mail to user: '" + txtUsername.Text + "': " + ex.Message;
			}
		}
	}
}
