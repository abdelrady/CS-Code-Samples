using System;
using System.Text;
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
using System.Security.Cryptography;

namespace csharphome.feat
{
	/// <summary>
	/// This page allows a user to sign up to access member services
	/// </summary>
	public class signup : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtUsername;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.TextBox txtPasswordConfirm;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.TextBox txtInfo;
		protected System.Web.UI.WebControls.LinkButton lnkSignUp;

		const string strDatabase = "../home.mdb";
		protected System.Web.UI.WebControls.Literal liMessage;
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));
			
			// We don't want this to be stored locally
			Response.Cache.SetCacheability(HttpCacheability.NoCache);
		}

		#region Database
		private bool UserExists(string strUsername)
		{
			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members");
				bool boolWhatHappen = false;

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						if (Convert.ToString(dbRow["username"]).ToUpper() == strUsername.ToUpper())
						{
							boolWhatHappen = true;
						}
					}
				}

				dbSet.Dispose();
                
				return boolWhatHappen;
			}
			catch
			{
				liMessage.Text = "There was an error while accessing the database.<br>Please try agian later.";
				return true;
			}
		}

		private bool AddNewUser(string strUsername, string strPassword, string strEmail, string strInfo, string strIp)
		{
			try
			{
				strInfo = strInfo.Replace("\n", "<br>").Replace("'", "&#039;");

				/*strOleDbCmd = "INSERT INTO members (username, pass, mail, usrdescription, admin, signupdate, ipaddr) " & _
				"VALUES ('" & strUsername & "', '" & strPassword & "', '" & strEmail & "', '" & strInfo & "', OFF, '" & Format(Now(), "Short Date") & "', '" & strIp & "');"*/

				string strOleDbCmd = string.Format("INSERT INTO members (username, pass, mail, usrdescription, admin, signupdate, ipaddr) " +
					"VALUES ('{0}', '{1}', '{2}', '{3}', OFF, '{4}', '{5}');", strUsername,
					strPassword, strEmail, strInfo, DateTime.Now.ToShortDateString(), strIp);

				f.SQLNonQuery(Server.MapPath(strDatabase), strOleDbCmd);

				return true;
			}
			catch (OleDbException ex)
			{
				liMessage.Text = "Error while attempting to write database information<br>\n" + ex.Message;
				return false;
			}
		}
		#endregion

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
			this.lnkSignUp.Click += new System.EventHandler(this.lnkSignUp_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void lnkSignUp_Click(object sender, System.EventArgs e)
		{
			string strAccountInfo = "No information provided.";
            
			if (UserExists(txtUsername.Text) == false)
			{
				if (!(txtUsername.Text.Length > 7))
				{
					liMessage.Text = "Username too short";
					return;
				}
				if (!(txtPassword.Text.Length > 7))
				{
					liMessage.Text = "Password too short";
					return;
				}
				if (!(txtPassword.Text == txtPasswordConfirm.Text))
				{
					liMessage.Text = "Passwords don't match";
					return;
				}
				if (!(txtEmail.Text.Length > 0))
				{
					liMessage.Text = "You must type a vaild email address";
					return;
				}
				if (txtInfo.Text.Length > 0)
				{
					strAccountInfo = txtInfo.Text;
					strAccountInfo = strAccountInfo.Replace("\n", "<br>");
					strAccountInfo = strAccountInfo.Replace("'", "&#96;");
				}

				// Encrypt Password withPassword
				Encoding en = Encoding.Default;
				csharphome.common.SymmCrypto h = new csharphome.common.SymmCrypto(common.SymmCrypto.SymmProvEnum.DES);
				string pwd = Convert.ToBase64String(en.GetBytes(h.Encrypting(txtPassword.Text, "reset")));

				if (AddNewUser(txtUsername.Text, pwd, txtEmail.Text, strAccountInfo, Request.UserHostAddress))
				{
					Response.Redirect("./login.aspx");
				}
				else
				{
					liMessage.Text = "Could not add user to database.<br>Unknown error, contact administrator";
				}
			}
			else
			{
				liMessage.Text = "User exists already";
			}
		}
	}
}
