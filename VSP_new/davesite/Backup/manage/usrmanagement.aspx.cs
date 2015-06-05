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
using System.Collections.Specialized;

namespace csharphome.manage
{
	/// <summary>
	/// This page allows for administrators to manage users
	/// </summary>
	public class usrmanagement : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Table tableUsers;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.Literal liLinks;

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
				
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					NameValueCollection frmWeb = Request.Form;
					switch (frmWeb["__EVENTTARGET"])
					{
						case "deleteusr":
							DeleteUser(frmWeb["__EVENTARGUMENT"]);
							break;
						case "changeadminstatus":
							if (Convert.ToBoolean(Session["su"]))
							{
								ChangeUserStatus(frmWeb["__EVENTARGUMENT"], "admin");
							}
							else
							{
								liMessage.Text = "Only users with Super User access are allowed to change this field.";
							}
							break;
						case "changesustatus":
							if (Convert.ToBoolean(Session["su"]))
							{
								ChangeUserStatus(frmWeb["__EVENTARGUMENT"], "superuser");
							}
							else
							{
								liMessage.Text = "Only users with Super User access are allowed to change this field.";
							}
							break;                            
					}

					DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members");
					TableCell tCell;
					TableRow tRow;

					tRow = new TableRow();
					tCell = new TableCell(); // User Id
					tCell.Text = "<div class=\"header\"><b>User Id</b></div>";
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
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
					tCell = new TableCell(); // Administrator
					tCell.Text = "<div class=\"header\"><b>Super User</b></div>";
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tRow.Cells.Add(tCell);
					tCell = new TableCell(); // Delete
					tCell.Text = "<div class=\"header\"><b>Delete</b></div>";
					tCell.HorizontalAlign = HorizontalAlign.Center;
					tRow.Cells.Add(tCell);
					tableUsers.Rows.Add(tRow);

					if (dbSet != null)
					{
						foreach (DataRow dbRow in dbSet.Tables[0].Rows)
						{
							tRow = new TableRow();
							tCell = new TableCell(); // User Id
							tCell.Text = Convert.ToString(dbRow["usrid"]);
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tCell = new TableCell(); // Username
							tCell.Text = f.HWHyperLink("../feat/userinfo.aspx?usrid=" + Convert.ToString(dbRow["usrid"]), f.HWImage("../images/icons/person.gif", 0, Convert.ToString(dbRow["username"])) + Convert.ToString(dbRow["username"]), Convert.ToString(dbRow["username"]));
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tCell = new TableCell(); // Email Addr
							tCell.Text = Convert.ToString(dbRow["mail"]);
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tCell = new TableCell(); // Administrator
							tCell.Text = Convert.ToString(dbRow["admin"]) + "&nbsp;(" + f.HWHyperLink("javascript:__doPostBack('changeadminstatus', '" + Convert.ToString(dbRow["usrid"]) + "-" + Convert.ToString(dbRow["admin"]) + "')", "Change", (Convert.ToBoolean(dbRow["admin"]) == false ? "Change user status to Administrator" : "Change user status to Normal User")) + ")";
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tCell = new TableCell(); // Super User
							tCell.Text = Convert.ToString(dbRow["superuser"]) + "&nbsp;(" + f.HWHyperLink("javascript:__doPostBack('changesustatus', '" + Convert.ToString(dbRow["usrid"]) + "-" + Convert.ToString(dbRow["superuser"]) + "')", "Change", (Convert.ToBoolean(dbRow["superuser"]) == false ? "Change user status to Super User" : "Change user status to non-Super User")) + ")";
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tRow.Cells.Add(tCell);
							tCell = new TableCell(); // Delete
							tCell.Text = f.HWHyperLink("javascript:__confirmUserDeletion('" + Convert.ToString(dbRow["usrid"]) + "')", f.HWImage("../images/icons/delete.gif", 0, "Delete User"));
							tCell.HorizontalAlign = HorizontalAlign.Center;
							tRow.Cells.Add(tCell);
							tableUsers.Rows.Add(tRow);
						}
					}

					dbSet.Dispose();
				}
				else
				{
					liMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
				}
			}
			catch (Exception ex)
			{
				liMessage.Text = "<b>And error occurred while attempting to read config file.</b><br>\n" + f.HWFontSize(ex.Message, 2);
			}
		}

		#region Database
		private void DeleteUser(string strUsrId) 
		{
			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) 
				{
					DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members WHERE usrid=" + strUsrId);
					if (dbSet != null) 
					{
						foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
						{
							if (!Convert.ToBoolean(dbRow["superuser"]))
							{
								f.SQLNonQuery(Server.MapPath(strDatabase), "DELETE FROM members WHERE usrid=" + strUsrId);
							}
							else
							{
								liMessage.Text = "Only other Super Users can delete other Super Users.";
								return;
							}
						}					
		
						Response.Redirect("./usrmanagement.aspx");
					}
					else
					{
						liMessage.Text = "Unable to find user for confirmation.";
					}					
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

		private void ChangeUserStatus(string strUsrId, string statusField) 
		{
			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"])) 
				{
					string[] strUsrInfo = strUsrId.Split('-');
					f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE members SET " + statusField + "=" + (strUsrInfo[1] == "True" ? "No" : "Yes") + " WHERE usrid=" + strUsrInfo[0]);

					Response.Redirect("./usrmanagement.aspx");
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
