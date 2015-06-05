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

namespace csharphome.manage
{
	/// <summary>
	/// This page allows for administrators to modify the message board
	/// </summary>
	public class bb : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Table tableBB;
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
						case "deletemsg":
							string[] mmCommand = Convert.ToString(frmWeb["__EVENTARGUMENT"] + ".").Split('.');
							f.updateThreadStatisics(Server.MapPath(strDatabase), mmCommand[1], "totalreplies", mmCommand[2]);
							DeleteMessage(mmCommand[0]);
							break;
						case "lockthread":
							ChangeThreadStatus(Convert.ToString(frmWeb["__EVENTARGUMENT"]));
							break;
					}
				}

				TableRow tblRow = new TableRow();
                TableCell tblCell; 
                tblCell = new TableCell(); // Message Id
                tblCell.Text = "<div class=\"header\"><b>MsgId</b></div>";
                tblCell.VerticalAlign = VerticalAlign.Top;
                tblRow.Cells.Add(tblCell);
                tblCell = new  TableCell(); // Reply Id
                tblCell.Text = "<div class=\"header\"><b>ReplyId</b></div>";
                tblCell.VerticalAlign = VerticalAlign.Top;
                tblRow.Cells.Add(tblCell);
                tblCell = new  TableCell(); // Topic
                tblCell.Text = "<div class=\"header\"><b>Topic</b></div>";
                tblCell.Style["Width"] = "60%";
                tblRow.Cells.Add(tblCell);
                tblCell = new TableCell(); // Total Replies
                tblCell.Text = "<div class=\"header\"><b>Replies</b></div>";
                tblCell.HorizontalAlign = HorizontalAlign.Center;
                tblRow.Cells.Add(tblCell);
                tblCell = new TableCell(); // Visits
                tblCell.Text = "<div class=\"header\"><b>Visits</b></div>";
                tblCell.HorizontalAlign = HorizontalAlign.Center;
                tblRow.Cells.Add(tblCell);
                tblCell = new TableCell(); // Lock?
                tblCell.Text = "<div class=\"header\"><b>Lock?</b></div>";
                tblCell.HorizontalAlign = HorizontalAlign.Center;
                tblRow.Cells.Add(tblCell);
                tblCell = new TableCell(); // Delete
                tblCell.Text = "<div class=\"header\"><b>Delete</b></div>";
                tblCell.HorizontalAlign = HorizontalAlign.Center;
                tblRow.Cells.Add(tblCell);
                tblCell = new TableCell(); // Edit
                tblCell.Text = "<div class=\"header\"><b>Edit</b></div>";
                tblCell.HorizontalAlign = HorizontalAlign.Center;
                tblRow.Cells.Add(tblCell);
                tableBB.Rows.Add(tblRow);
				
				ReadMessages();
			}
			else
			{
				liMessage.Text = "<b>Your are either not signed in, or you are not a system administrator.</b>";
			}
		}

		#region Tables
		private void ReadMessages()
		{
			// Read the messages database
			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM messages WHERE replyid=0 ORDER BY msgid DESC");
				TableRow tblRow;	
				TableCell tblCell;

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						tblRow = new TableRow();
						tblCell = new TableCell(); // Message Id
						tblCell.Text = Convert.ToString(dbRow["msgid"]);
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Reply Id
						tblCell.Text = Convert.ToString(dbRow["replyid"]);
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblRow.Cells.Add(tblCell);

						tblCell = new TableCell(); // Topic
						tblCell.Text = "&nbsp;" + f.HWImage("../images/icons/icon" + Convert.ToString(dbRow["posticon"]) + ".gif", 0, "Thread") + "&nbsp;" + f.HWHyperLink("../feat/bb/viewmsg.aspx?msgid=" + Convert.ToString(dbRow["msgid"]), Convert.ToString(dbRow["topic"]));
						tblCell.Style["Width"] = "60%";
						tblRow.Cells.Add(tblCell);

						tblCell = new TableCell(); // Total Replies
						tblCell.Text = Convert.ToString(dbRow["totalreplies"]);
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Visits
						tblCell.Text = Convert.ToString(dbRow["visits"]);
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);

						tblCell = new TableCell(); // Lock?
						tblCell.Text = f.HWHyperLink("javascript:__doPostBack('lockthread', '" + Convert.ToString(dbRow["msgid"]) + "-" + Convert.ToString(dbRow["replyid"]) + "-" + Convert.ToBoolean(dbRow["lockedthread"]).ToString() + "')", f.HWImage("../images/icons/" + (Convert.ToBoolean(dbRow["lockedthread"]) == true ? "open" : "closed") + ".gif", 0, "Lock/Unlock Message"));
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Delete
						tblCell.Text = f.HWHyperLink("javascript:__confirmBBDeletion('" + Convert.ToString(dbRow["msgid"]) + "." + Convert.ToString(dbRow["msgid"]) + "." + Convert.ToString(dbRow["totalreplies"]) + "')", f.HWImage("../images/icons/delete.gif", 0, "Delete Message"));
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Edit
						tblCell.Text = f.HWHyperLink("./editors/editbb.aspx?msgid=" + Convert.ToString(dbRow["msgid"]), f.HWImage("../images/icons/edit.gif", 0, "Edit Message"));
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tableBB.Rows.Add(tblRow);

						// Now get the message replies, if any.
						ReadMessageReplies(Convert.ToString(dbRow["msgid"]), Convert.ToInt32(dbRow["totalreplies"]));
					}		
				}
               
				dbSet.Dispose();
			}	
			catch (OleDbException ex)
			{
				liMessage.Text = "<h4>Error while attempting to read database information</h4>\n" + ex.Message;
			}
		}

		private void ReadMessageReplies(string strMsgId, int intTotalReplies)
		{
			// Read the messages database
			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM messages WHERE replyid=" + strMsgId + " ORDER BY msgid");
				TableRow tblRow;	
				TableCell tblCell;

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						tblRow = new TableRow();
						tblCell = new TableCell(); // Message Id
						tblCell.Text = Convert.ToString(dbRow["msgid"]);
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Reply Id
						tblCell.Text = Convert.ToString(dbRow["replyid"]);
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblRow.Cells.Add(tblCell);

						tblCell = new TableCell(); // Topic
						tblCell.Text = "&nbsp;&nbsp;&nbsp;" + f.HWImage("../images/icons/icon" + Convert.ToString(dbRow["posticon"]) + ".gif", 0, "Thread") + "&nbsp;" + f.HWHyperLink("../feat/bb/viewmsg.aspx?msgid=" + Convert.ToString(dbRow["msgid"]), Convert.ToString(dbRow["topic"]));
						tblCell.Style["Width"] = "60%";
						tblRow.Cells.Add(tblCell);

						tblCell = new TableCell(); // Total Replies
						tblCell.Text = Convert.ToString(dbRow["totalreplies"]);
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Visits
						tblCell.Text = Convert.ToString(dbRow["visits"]);
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);

						tblCell = new TableCell(); // Lock?
						tblCell.Text = f.HWHyperLink("javascript:__doPostBack('lockthread', '" + Convert.ToString(dbRow["msgid"]) + "-" + Convert.ToString(dbRow["replyid"]) + "-" + Convert.ToBoolean(dbRow["lockedthread"]).ToString() + "')", f.HWImage("../images/icons/" + (Convert.ToBoolean(dbRow["lockedthread"]) == true ? "open" : "closed") + ".gif", 0, "Lock/Unlock Message"));
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Delete
						tblCell.Text = f.HWHyperLink("javascript:__confirmBBDeletion('" + Convert.ToString(dbRow["msgid"]) + "." + Convert.ToString(dbRow["replyid"]) + "." + Convert.ToString(intTotalReplies - 1) + "')", f.HWImage("../images/icons/delete.gif", 0, "Delete Message"));
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Edit
						tblCell.Text = f.HWHyperLink("./editors/editbb.aspx?msgid=" + Convert.ToString(dbRow["msgid"]), f.HWImage("../images/icons/edit.gif", 0, "Edit Message"));
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tableBB.Rows.Add(tblRow);

						// Now get the message replies, if any.
						ReadMessageReplies(Convert.ToString(dbRow["msgid"]), Convert.ToInt32(dbRow["totalreplies"]));
					}		
				}
               
				dbSet.Dispose();
			}	
			catch (OleDbException ex)
			{
				liMessage.Text = "<h4>Error while attempting to read database information</h4>\n" + ex.Message;
			}
		}
		#endregion
		#region Database
		private void DeleteMessage(string strMsgId)
		{
			try
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					string[] strOleDbCmd = {"DELETE FROM messages WHERE msgid=" + strMsgId, "DELETE FROM messages WHERE replyid=" + strMsgId};
                    
					// Connect to the database and open it.
					for (int i = strOleDbCmd.GetLowerBound(0); i <= strOleDbCmd.GetUpperBound(0); i++)
					{
						f.SQLNonQuery(Server.MapPath(strDatabase), strOleDbCmd[i]);
					}
					Response.Redirect("./bb.aspx");
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

		private void ChangeThreadStatus(string strMM)
		{
			try
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					string[] strMsgInfo = strMM.Split('-');
                    string[] strUpdateWhat = {"msgid", strMsgInfo[0],
                    "replyid", (Convert.ToInt32(strMsgInfo[1]) == 0 ? strMsgInfo[0] : strMsgInfo[1]),
                    "msgid", (Convert.ToInt32(strMsgInfo[1]) != 0 ? strMsgInfo[1] : Convert.ToString(-1))};
			
					for (int a = strUpdateWhat.GetLowerBound(0); a <= strUpdateWhat.GetUpperBound(0); a = a + 2)
					{
                        string strOleDbCmd = "UPDATE messages SET lockedthread = " + (strMsgInfo[2] == "True" ? "No" : "Yes") + " WHERE " + strUpdateWhat[a] + " = " + strUpdateWhat[a + 1];

                       	// Connect to the database and open it.
						OleDbConnection odbConnect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath(strDatabase) + ";Persist Security Info=False;");
						odbConnect.Open();						
						// Update what we want.
						OleDbCommand odbCommand = new OleDbCommand(strOleDbCmd, odbConnect);
						odbCommand.ExecuteNonQuery();

						odbCommand.Dispose();
						odbConnect.Close();

						//Response.Write(strOleDbCmd + "<br>");
					}
                    
					Response.Redirect("./bb.aspx");
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
