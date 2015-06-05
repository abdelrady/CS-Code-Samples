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

namespace csharphome.feat
{
	/// <summary>
	/// This page displays all the users that have joined
	/// </summary>
	public class users : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Table tableUsers;
		protected System.Web.UI.WebControls.Literal liMessage;

		const string strDatabase = "../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			try
			{
				// We don't want this to be stored locally
				Response.Cache.SetCacheability(HttpCacheability.NoCache);
				
				if (Convert.ToBoolean(Session["LoggedIn"]))
				{
					DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members ORDER BY username ASC");
					TableCell tCell;
					TableRow tRow;

					tRow = new TableRow();
					tCell = new TableCell(); // Username
					tCell.Text = "<div class=\"header\"><b>Username</b></div>";
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Email Addr
					tCell.Text = "<div class=\"header\"><b>Email Addr</b></div>";
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Administrator
					tCell.Text = "<div class=\"header\"><b>Administrator</b></div>";
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tableUsers.Rows.Add(tRow);

					if (dbSet != null)
					{
						foreach (DataRow dbRow in dbSet.Tables[0].Rows)
						{
							tRow = new TableRow();
							tCell = new TableCell(); // Username
							tCell.Text = f.HWHyperLink("../feat/userinfo.aspx?usrid=" + Convert.ToString(dbRow["usrid"]), f.HWImage("../images/icons/person.gif", 0, Convert.ToString(dbRow["username"])) + Convert.ToString(dbRow["username"]), Convert.ToString(dbRow["username"]));
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tCell = new TableCell(); // Email Addr
							tCell.Text = Convert.ToString(dbRow["mail"]);
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tCell = new TableCell(); // Administrator
							tCell.Text = Convert.ToString(dbRow["admin"]);
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tableUsers.Rows.Add(tRow);
						}
					}

					dbSet.Dispose();
				}
				else
				{
					Response.Redirect("./login.aspx");
				}
			}
			catch (Exception ex)
			{
				liMessage.Text = "<b>And error occurred while attempting to read config file.</b><br>\n" + f.HWFontSize(ex.Message, 2);
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
