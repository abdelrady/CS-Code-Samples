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
	/// This page allows administrators to modify basic settings
	/// </summary>
	public class _default : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.Table tableLinks;
		protected System.Web.UI.WebControls.Table tableArticles;

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
						case "changarticlestatus":
							ChangeArticleStatus(frmWeb["__EVENTARGUMENT"]);
							break;
						case "deletearticle":
							DeleteArticle(frmWeb["__EVENTARGUMENT"]);
							break;
					}
				}

				// Load the tables to display our stuff and stuff...
                dLoadLinksList();
				dLoadArticleList();
			}
			else
			{
				liMessage.Text = "<b>Your are either not signed in, or you are not a system administrator.</b>";
			}
		}

		#region Displaying List Functions
		private void dLoadLinksList() 
		{
			f = new csharphome.common.homepage();
			DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM links");

			TableCell tCell; 
			TableRow tRow;

			tRow = new TableRow();
			tCell = new TableCell(); // Link Id
			tCell.Text = "<div class=\"header\"><b>Link Id</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Left;
			tCell.Style["Width"] = "10%";
			tRow.Cells.Add(tCell);
			tCell = new TableCell(); // Preview
			tCell.Text = "<div class=\"header\"><b>Link Data</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Left;
			tCell.Style["Width"] = "75%";
			tRow.Cells.Add(tCell);
			tCell = new TableCell(); // Edit
			tCell.Text = "<div class=\"header\"><b>Edit</b></div>";
			tCell.Style["Width"] = "5%";
			tCell.HorizontalAlign = HorizontalAlign.Center;
			tRow.Cells.Add(tCell);
			tableLinks.Rows.Add(tRow);

			if (dbSet != null) 
			{
				foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
				{
					f = new csharphome.common.homepage();

					tRow = new TableRow();
					tCell = new TableCell(); // Link Id
					tCell.Text = Convert.ToString(dbRow["linkid"]);
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tCell.VerticalAlign = VerticalAlign.Top;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Preview
					tCell.Text = Convert.ToString(dbRow["linkdata"]).Replace("<br>", ".. ").Replace("img", "img height=\"20\" width=\"20\"");

					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Edit
					tCell.Text = f.HWHyperLink("./editors/editlinks.aspx?id=" + Convert.ToString(dbRow["linkid"]), f.HWImage("../images/icons/edit.gif", 0, "Edit Link page"));
					tCell.HorizontalAlign = HorizontalAlign.Center;
					tRow.Cells.Add(tCell);
					tableLinks.Rows.Add(tRow);
				}
			}

			dbSet.Dispose();
		}

		private void dLoadArticleList()
		{			
			f = new csharphome.common.homepage();
			DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM articles ORDER BY displayimage ASC, articledate DESC");

			TableCell tCell;
			TableRow tRow;

			tRow = new TableRow();
			tCell = new TableCell(); // Article Id
			tCell.Text = "<div class=\"header\"><b>Article Id</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Left;
			tRow.Cells.Add(tCell);
			tCell = new TableCell(); // Subject
			tCell.Text = "<div class=\"header\"><b>Subject</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Left;
			tRow.Cells.Add(tCell);
			tCell = new TableCell(); // Date
			tCell.Text = "<div class=\"header\"><b>Date</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Left;
			tRow.Cells.Add(tCell);
			tCell = new TableCell(); // Hidden?
			tCell.Text = "<div class=\"header\"><b>Hidden</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Left;
			tRow.Cells.Add(tCell);
			tCell = new TableCell(); // Delete
			tCell.Text = "<div class=\"header\"><b>Delete</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Center;
			tRow.Cells.Add(tCell);
			tCell = new TableCell(); // Edit
			tCell.Text = "<div class=\"header\"><b>Edit</b></div>";
			tCell.HorizontalAlign = HorizontalAlign.Center;
			tRow.Cells.Add(tCell);
			tableArticles.Rows.Add(tRow);

			if (dbSet != null) 
			{
				foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
				{
					tRow = new TableRow();
					tCell = new TableCell(); // Article Id
					tCell.Text = Convert.ToString(dbRow["articleid"]);
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Subject
					tCell.Text = (Convert.ToBoolean(dbRow["outsidelink"]) == true ? f.HWImage("../images/icons/hyperlink.gif", 0 , "Article Hyperlink") : f.HWImage("../images/icons/thread.gif", 0, "Article")) + f.HWHyperLink("../viewarticle.aspx?id=" + Convert.ToString(dbRow["articleid"]), Convert.ToString(dbRow["articlename"]), Convert.ToString(dbRow["articlename"]));
						tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Date
					tCell.Text = Convert.ToString(dbRow["articledate"]);
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Hidden?
					tCell.Text = string.Format("{0}&nbsp;({1})", Convert.ToString(dbRow["hidden"]), 
						f.HWHyperLink(string.Format("javascript:__doPostBack('changarticlestatus\', '{0}-{1}')", Convert.ToString(dbRow["articleid"]), Convert.ToString(dbRow["hidden"])), "Change", (Convert.ToBoolean(dbRow["hidden"]) == false ? "Change article status to Hidden" : "Change article status to Visible")));
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Delete
					tCell.Text = f.HWHyperLink("javascript:__confirmArticleDeletion('" + Convert.ToString(dbRow["articleid"]) + "')", f.HWImage("../images/icons/delete.gif", 0, "Delete Article"));
					tCell.HorizontalAlign = HorizontalAlign.Center;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Edit
					tCell.Text = f.HWHyperLink("./editors/editarticle.aspx?id=" + Convert.ToString(dbRow["articleid"]), f.HWImage("../images/icons/edit.gif", 0, "Edit Article"));
					tCell.HorizontalAlign = HorizontalAlign.Center;
					tRow.Cells.Add(tCell);
					tableArticles.Rows.Add(tRow);
				}
			}

			dbSet.Dispose();
		}
		#endregion
		#region Article Database Functions
		private void ChangeArticleStatus(string strArticleId) 
		{
			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					string strOleDbCmd;
					string[] strUsrInfo = strArticleId.Split('-');

					strOleDbCmd = "UPDATE articles SET hidden=" + (strUsrInfo[1] == "True" ? "No" : "Yes") + " WHERE articleid=" + strUsrInfo[0];

					f = new csharphome.common.homepage();
					f.SQLNonQuery(Server.MapPath(strDatabase), strOleDbCmd);

					Response.Redirect("./");
				} 
				else 
				{
					liMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
				}
			}
			catch (OleDbException ex) 
			{
				liMessage.Text = "There was an error while accessing the database<br>" + ex.Message;
			}
		}

		private void DeleteArticle(string strMsgId) 
		{
			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					f = new csharphome.common.homepage();
					f.SQLNonQuery(Server.MapPath(strDatabase), "DELETE FROM articles WHERE articleid=" + strMsgId);

					Response.Redirect("./");
				} 
				else 
				{
					liMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
				}
			}      
			catch (OleDbException ex) 
			{
				liMessage.Text = "There was an error while accessing the database<br>" + ex.Message;
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
