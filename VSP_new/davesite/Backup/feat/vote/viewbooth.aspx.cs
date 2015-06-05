using System;
using System.Text;
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

namespace csharphome.feat.vote
{
	/// <summary>
	/// This page shows the current result for a booth and displays choices if available
	/// </summary>
	public class viewbooth : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.Table tableBooth;
		protected System.Web.UI.WebControls.Table tableChoices;

		const string strDatabase = "../../home.mdb";		
		private csharphome.common.homepage f;
		private Encoding en = Encoding.Default;

        public string strBoothName;
		public string strDescription;
		public double maxVotes = 0;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			string strBooth = en.GetString(Convert.FromBase64String(Request.QueryString["id"]));
            TableRow tblRow;
			TableCell tblCell;

			try
			{
				/* Check to see if the user requested updates to something first
				 * so that they don't get old data */
				NameValueCollection frmWeb = Request.Form;
				if (frmWeb != null) 
				{
					switch (frmWeb["__EVENTTARGET"])
					{
						case "update":
							string[] mmCommand = frmWeb["__EVENTARGUMENT"].Split('-');
							string mBooth = en.GetString(Convert.FromBase64String(mmCommand[0]));
							string mChoice = mmCommand[1];
							string mValue = mmCommand[2];
							Session["Voted_" + mBooth] = true;
							f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE " + mBooth + " SET votevalue=" + mValue + " WHERE voteid=" + mChoice);
							break;
					}
				}

				// Below load the booth data

				DataSet dbSetA = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM " + strBooth);
				DataSet dbSetB = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM booths WHERE votename='" + strBooth + "'");
				bool lockedBooth = false;

				if (dbSetB != null)
				{
					foreach (DataRow dbRow in dbSetB.Tables[0].Rows)
					{
						strBoothName = Convert.ToString(dbRow["displayname"]);
						strDescription = Convert.ToString(dbRow["description"]);
						lockedBooth = Convert.ToBoolean(dbRow["viewonly"]);
					}
					if (dbSetA != null)
					{
						foreach (DataRow dbRow in dbSetA.Tables[0].Rows)
						{
							maxVotes += Convert.ToInt32(dbRow["votevalue"]);
						}
						foreach (DataRow dbRow in dbSetA.Tables[0].Rows)
						{
							// Start on the values
							tblRow = new TableRow();
							tblCell = new TableCell(); // Vote name
							tblCell.Text = Convert.ToString(dbRow["votename"]);
							tblCell.Style["Width"] = "25%";
							tblRow.Cells.Add(tblCell);

							int percentage = (maxVotes == 0 ? 0: Convert.ToInt32(((Convert.ToDouble(dbRow["votevalue"]) / maxVotes) * 100)));

							tblCell = new TableCell(); // Value f.HWImage("../../images/dot.gif", 0, null, 10, percentage * 3) + "&nbsp;&nbsp;
							tblCell.Text = "<span class=\"header\" style=\"width:" + Convert.ToString(percentage * 3) + ";\">&nbsp;</span>&nbsp;&nbsp;<b>" + 
								percentage.ToString("0") + "%</b> (" + Convert.ToString(dbRow["votevalue"]) + ")";
							tblRow.Cells.Add(tblCell);
							tableBooth.Rows.Add(tblRow);

							// Now on the choices
							tblRow = new TableRow();
							tblCell = new TableCell();
							if (Convert.ToBoolean(Session["LoggedIn"]))
							{
								if ((!Convert.ToBoolean(Session["Voted_" + strBooth]) && !lockedBooth) || Convert.ToBoolean(Session["admin"]))
								{
									tblCell.Text = f.HWHyperLink("javascript:update('" +
										Convert.ToBase64String(en.GetBytes(strBooth)) + "', '" +
										Convert.ToString(dbRow["voteid"]) + "', '" +
										(Convert.ToInt32(dbRow["votevalue"]) + 1) + "')",
										Convert.ToString(dbRow["votename"]));
								}
							}
							tblRow.Cells.Add(tblCell);
							tableChoices.Rows.Add(tblRow);
						}
					}
					else
					{
						liMessage.Text = "<b>Booth does not exist.</b>";
					}
				}				
				else
				{
					liMessage.Text = "<b>Booth does not exist.</b>";
				}
			}
			catch (OleDbException ex)
			{
				liMessage.Text = "There was an error while accessing the database.<br>" +
					ex.Message;
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
