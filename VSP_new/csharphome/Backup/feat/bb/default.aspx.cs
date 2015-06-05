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

namespace csharphome.feat.bb
{
	/// <summary>
	/// This page shows all the messages in the message board and allows users to post
	/// new postings'
	/// </summary>
	public class _default : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.Table tableBB;
		protected System.Web.UI.WebControls.Literal liLinks;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

            // Read the messages database
			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM messages WHERE replyid=0 ORDER BY msgid DESC");
				TableRow tblRow;
				TableCell tblCell;
                
				if (dbSet.Tables[0].Rows.Count < 1)
				{
					liMessage.Text = "<p><b>Sorry. But there is no messages!</b><br>Please login and make one!</p>";
					return;
				}
                
				// Create the headers for the table
				tblRow = new TableRow();
				tblCell = new TableCell(); // Locked Thread?
				tblCell.Text = "<div class=\"header\"><b>Locked</b></div>";
				tblCell.HorizontalAlign = HorizontalAlign.Center;
				tblRow.Cells.Add(tblCell);
				tblCell = new TableCell(); // Subject
				tblCell.Text = "<div class=\"header\"><b>Subject</b></div>";
				tblCell.Style["Width"] = "60%";
				tblRow.Cells.Add(tblCell);
				tblCell = new TableCell(); // Replies
				tblCell.Text = "<div class=\"header\"><b>Replies</b></div>";
				tblRow.Cells.Add(tblCell);
				tblCell = new TableCell(); // Visits
				tblCell.Text = "<div class=\"header\"><b>Visits</b></div>";
				tblRow.Cells.Add(tblCell);
				tblCell = new TableCell(); // Date
				tblCell.Text = "<div class=\"header\"><b>Date</b></div>";
				tblRow.Cells.Add(tblCell);
				tableBB.Rows.Add(tblRow);

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						tblRow = new TableRow();
						tblCell = new TableCell(); // Locked Thread?
						tblCell.Text = f.HWImage("../../images/icons/" + (Convert.ToBoolean(dbRow["lockedthread"]) == false ? "closed" : "open") + ".gif", 0, "Status of Thread");
						tblCell.HorizontalAlign = HorizontalAlign.Center;
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Subject
						tblCell.Text = "&nbsp;" + f.HWImage("../../images/icons/icon" + Convert.ToString(dbRow["posticon"]) + ".gif", 0, "Thread") + "&nbsp;" + f.HWHyperLink("./viewmsg.aspx?msgid=" + Convert.ToString(dbRow["msgid"]), Convert.ToString(dbRow["topic"]), Convert.ToString(dbRow["topic"]));
						tblCell.Style["Width"] = "60%";
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Replies
						tblCell.Text = Convert.ToString(dbRow["totalreplies"]);
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Visits
						tblCell.Text = Convert.ToString(dbRow["visits"]);
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Date
						tblCell.Text = f.HWFontSize(Convert.ToString(dbRow["date"]), 1);
						tblRow.Cells.Add(tblCell);
						tableBB.Rows.Add(tblRow);
					}
					
					dbSet.Dispose();
				}
			}
			catch (OleDbException ex) 
			{
				liMessage.Text = "<h4>Error while attempting to read database information</h4>\n" + ex.Message;
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
