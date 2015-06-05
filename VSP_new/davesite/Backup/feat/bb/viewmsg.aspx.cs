using System;
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
using System.Text.RegularExpressions;

namespace csharphome.feat.bb
{
	/// <summary>
	/// This page allows the user to see the message requested
	/// </summary>
	public class viewmsg : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.Table tableBB;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
		public string MessageTitle;
		bool boolLocked;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			try
			{
				string strMsgId = Request.QueryString["msgid"];
				
				if (strMsgId != null)
				{
					ReadMessage(strMsgId);
				}
			}
			catch (OleDbException ex)
			{
				liMessage.Text = "<h4>Error while attempting to read database information</h4>\n" + ex.Message;
			}
		}

		#region Private Functions
		private void ReadMessage(string strMsgId) 
		{
			// Read the messages database
			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM messages WHERE msgid=" + strMsgId);
				TableRow tblRow;
				TableCell tblCell;
				string strMsgInfo;

				if ((dbSet != null) && !(dbSet.Tables[0].Rows.Count < 1)) 
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						MessageTitle = Convert.ToString(dbRow["topic"]);

						// Setup the message info...
						strMsgInfo = "<b>" + f.HWHyperLink("../userinfo.aspx?usrid=" + 
							Convert.ToString(dbRow["postedbyid"]), Convert.ToString(dbRow["postedby"]),
							Convert.ToString(dbRow["postedby"])) + "</a><br>" +
							f.HWFontSize(Convert.ToString(dbRow["date"]), 1) +
							"<p><div class=\"header\" align=\"center\">" + f.HWImage("../userpic.aspx?usrid=" + Convert.ToString(dbRow["postedbyid"]),
							0, Convert.ToString(dbRow["postedby"])) + "</div></p>";

						tblRow = new TableRow();
						tblCell = new TableCell(); // Date, Posted by, etc
						tblCell.Text = "<div class=\"header\">" + strMsgInfo + "</div>";
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblCell.Style["Width"] = "15%";
						tblRow.Cells.Add(tblCell);

						StringWriter objStringWriter = new StringWriter();
						HtmlTextWriter objHtmlWriter = new HtmlTextWriter(objStringWriter);
						string result;
						Table tableBody = new Table();
						TableRow tblRowBody = new TableRow(); // The body of the message
						tableBody.Style["Width"] = "100%";
						tblCell = new TableCell();
						tblCell.Text = CheckMsgCodes(Convert.ToString(dbRow["body"]));
						tblRowBody.Cells.Add(tblCell);
						tableBody.Rows.Add(tblRowBody);
						tableBody.RenderControl(objHtmlWriter);
						result = objStringWriter.ToString();

						if (Convert.ToBoolean(dbRow["lockedthread"])) boolLocked = true;
						if ((Convert.ToBoolean(Session["LoggedIn"]) && boolLocked == false) || Convert.ToBoolean(Session["Admin"]))
						{
							liMessage.Text = f.HWHyperLink("./reply.aspx?msgid=" + strMsgId, "Reply", "Reply");
						}

						tblCell = new TableCell(); // Topic
						tblCell.Text = "<div class=\"header\">&nbsp;" + f.HWImage("../../images/icons/icon" + Convert.ToString(dbRow["posticon"]) + ".gif", 0, "Thread") + "&nbsp;" + Convert.ToString(dbRow["topic"]) + "<br>" + result + "</div>";
						tblCell.Style["Width"] = "80%";
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblRow.Cells.Add(tblCell);
						tableBB.Rows.Add(tblRow);

						f.updateThreadStatisics(Server.MapPath(strDatabase), strMsgId, "visits", Convert.ToString(Convert.ToInt32(dbRow["visits"]) + 1));
					}
					ReadMessageReplies(strMsgId);
				}
				else					
				{
					liMessage.Text = "Sorry that message does not exist.<br>This message might of been removed, try agian later.";
				}

				dbSet.Dispose();
			}
			catch (OleDbException ex)
			{
				liMessage.Text = "<h4>Error while attempting to read database information</h4>\n" + ex.Message;
			}
		}

		private void ReadMessageReplies(string strMsgId) 
		{
			// Read the messages database
			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM messages WHERE replyid=" + strMsgId + " ORDER BY msgid");
				TableRow tblRow;
				TableCell tblCell;
				string strMsgInfo;

				if ((dbSet != null) && !(dbSet.Tables[0].Rows.Count < 1)) 
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						// Setup the message info...
						//strMsgInfo = "<b>" + f.HWHyperLink("../userinfo.aspx?usrid=" + Convert.ToString(dbRow["postedbyid"]), Convert.ToString(dbRow["postedby"]), Convert.ToString(dbRow["postedby"])) + "</a><br>" + f.HWFontSize(Convert.ToString(dbRow["date"]), 1);
						strMsgInfo = "<b>" + f.HWHyperLink("../userinfo.aspx?usrid=" + 
							Convert.ToString(dbRow["postedbyid"]), Convert.ToString(dbRow["postedby"]),
							Convert.ToString(dbRow["postedby"])) + "</a><br>" +
							f.HWFontSize(Convert.ToString(dbRow["date"]), 1) +
							"<p><div class=\"header\" align=\"center\">" + f.HWImage("../userpic.aspx?usrid=" + Convert.ToString(dbRow["postedbyid"]),
							0, Convert.ToString(dbRow["postedby"])) + "</div></p>";

						tblRow = new TableRow();
						tblCell = new TableCell(); // Date, Posted by, etc
						tblCell.Text = "<div class=\"header\">" + strMsgInfo + "</div>";
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblCell.Style["Width"] = "15%";
						tblRow.Cells.Add(tblCell);

						StringWriter objStringWriter = new StringWriter();
						HtmlTextWriter objHtmlWriter = new HtmlTextWriter(objStringWriter);
						string result;
						Table tableBody = new Table();
						TableRow tblRowBody = new TableRow(); // The body of the message
						tableBody.Style["Width"] = "100%";
						tblCell = new TableCell();
						tblCell.Text = CheckMsgCodes(Convert.ToString(dbRow["body"]));
						tblRowBody.Cells.Add(tblCell);
						tableBody.Rows.Add(tblRowBody);
						tableBody.RenderControl(objHtmlWriter);
						result = objStringWriter.ToString();

						if (Convert.ToBoolean(dbRow["lockedthread"])) boolLocked = true;
						if ((Convert.ToBoolean(Session["LoggedIn"]) && boolLocked == false) || Convert.ToBoolean(Session["Admin"]))
						{
							liMessage.Text = f.HWHyperLink("./reply.aspx?msgid=" + strMsgId, "Reply", "Reply");
						}

						tblCell = new TableCell(); // Topic
						tblCell.Text = "<div class=\"header\">&nbsp;" + f.HWImage("../../images/icons/icon" + Convert.ToString(dbRow["posticon"]) + ".gif", 0, "Thread") + "&nbsp;" + Convert.ToString(dbRow["topic"]) + "<br>" + result + "</div>";
						tblCell.Style["Width"] = "80%";
						tblCell.VerticalAlign = VerticalAlign.Top;
						tblRow.Cells.Add(tblCell);
						tableBB.Rows.Add(tblRow);

						//updateThreadStatisics(Server.MapPath(strDatabase), strMsgId, "visits", Convert.ToInt32(dbRow["visits"]) + 1);
					}
				}

				dbSet.Dispose();
			}
			catch (OleDbException ex)
			{
				liMessage.Text = "<h4>Error while attempting to read database information</h4>\n" + ex.Message;
			}
		}

		private string CheckMsgCodes(string strSource)
		{
			f = new csharphome.common.homepage();
			string strBuffer = strSource;

			strBuffer = strBuffer.Replace(":)", f.HWImage("../../images/icons/smile.gif", 0, ":)"));
			strBuffer = strBuffer.Replace(":(", f.HWImage("../../images/icons/frown.gif", 0, ":("));
			strBuffer = strBuffer.Replace(":o", f.HWImage("../../images/icons/redface.gif", 0, ":o"));
			strBuffer = strBuffer.Replace(":D", f.HWImage("../../images/icons/biggrin.gif", 0, ":D"));
			strBuffer = strBuffer.Replace(";)", f.HWImage("../../images/icons/wink.gif", 0, ";)"));
			strBuffer = strBuffer.Replace(":p", f.HWImage("../../images/icons/tongue.gif", 0, ":p"));
			strBuffer = strBuffer.Replace(":cool:", f.HWImage("../../images/icons/cool.gif", 0, ":cool:"));
			strBuffer = strBuffer.Replace(":rolleyes:", f.HWImage("../../images/icons/rolleyes.gif", 0, ":rolleyes:"));
			strBuffer = strBuffer.Replace(":mad:", f.HWImage("../../images/icons/mad.gif", 0, ":mad:"));
			strBuffer = strBuffer.Replace(":eek:", f.HWImage("../../images/icons/eek.gif", 0, ":eek:"));
			strBuffer = strBuffer.Replace(":confused:", f.HWImage("../../images/icons/confused.gif", 0, ":confused:"));

			while (strBuffer.IndexOf("[UL]") != -1)
			{
				strBuffer = strBuffer.Replace("[UL]", "<ul>");
				strBuffer = strBuffer.Replace("[LI]", "<li>");
				strBuffer = strBuffer.Replace("[/LI]", "</li>");
				strBuffer = strBuffer.Replace("[/UL]", "</ul>");
			}
			while (strBuffer.IndexOf("[URL]") != -1)
			{
				strBuffer = strBuffer.Replace("[URL]", "<a href=\"");
				strBuffer = strBuffer.Replace("[URLX]", "\" target=\"top\">");
				strBuffer = strBuffer.Replace("[/URL]", "</a>");
			}
			while (strBuffer.IndexOf("[IMG]") != -1)
			{
				strBuffer = strBuffer.Replace("[IMG]", "<img src=\"");
				strBuffer = strBuffer.Replace("[/IMG]", "\" border=\"0\">");
			}
			while (strBuffer.IndexOf("[B]") != -1)
			{
				strBuffer = strBuffer.Replace("[B]", "<b>");
				strBuffer = strBuffer.Replace("[/B]", "</b>");
			}
			while (strBuffer.IndexOf("[I]") != -1)
			{
				strBuffer = strBuffer.Replace("[I]", "<i>");
				strBuffer = strBuffer.Replace("[/I]", "</i>");
			}
			while (strBuffer.IndexOf("[U]") != -1)
			{
				strBuffer = strBuffer.Replace("[U]", "<u>");
				strBuffer = strBuffer.Replace("[/U]", "</u>");
			}


			return strBuffer;
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
