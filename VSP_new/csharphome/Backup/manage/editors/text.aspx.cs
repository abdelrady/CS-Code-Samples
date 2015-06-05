using System;
using System.Text;
using System.IO;
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
	/// This page allows administartors to edit text files
	/// </summary>
	public class text : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtEditor;
		protected System.Web.UI.WebControls.TextBox txtFilename;
		protected System.Web.UI.WebControls.Button btnSave;
		protected System.Web.UI.WebControls.Button btnOpen;
		protected System.Web.UI.WebControls.Literal liMessage;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
		private Encoding en = Encoding.Default;
		protected System.Web.UI.WebControls.TextBox txtEdited;
		bool isAdmin;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			isAdmin = Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]);

			try
			{
				if (isAdmin)
				{
					if (txtEdited.Text != "YES") 
					{
						string RequestFile = Request.QueryString["file"];
						if (RequestFile != null)
						{
							txtFilename.Text = en.GetString(Convert.FromBase64String(RequestFile));
							StreamReader m = new StreamReader(Server.MapPath(en.GetString(Convert.FromBase64String(RequestFile))));
							txtEditor.Text = m.ReadToEnd();
							m.Close();
						}

						if (txtEdited.Text == "NO") txtEdited.Text = "YES";
					}
				}
				else
				{
					liMessage.Text = "<b><font color=\"#EE0000\">An administrator function has been attempted and has been prevented.</font></b>";
				}
			}
			catch (Exception ex)
			{
				liMessage.Text = "<b>And exception was thrown:</b><br>" + ex.Message;
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
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("./text.aspx?file=" + Convert.ToBase64String(en.GetBytes(txtFilename.Text)));
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (isAdmin)
			{
				StreamWriter m = new StreamWriter(Server.MapPath(txtFilename.Text));
				m.Write(txtEditor.Text);
				m.Close();
				liMessage.Text = "<b>Saved file.</b>";
			}
		}
	}
}
