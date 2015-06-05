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

namespace csharphome.manage
{
	/// <summary>
	/// This page manages voting booths
	/// </summary>
	public class vote : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liMessage;

		const string strDatabase = "../home.mdb";
		private csharphome.common.homepage f;
		protected System.Web.UI.WebControls.Table tableBooths;
		private Encoding en = Encoding.Default;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			
			try
			{
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
							case "changeboothstatus":
								string[] mmCommand = frmWeb["__EVENTARGUMENT"].Split('-');
								f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE booths SET viewonly=" + (mmCommand[1] == "True" ? "No" : "Yes") + " WHERE voteid=" + mmCommand[0]);
								break;
							case "deletebooth":
								string booth = en.GetString(Convert.FromBase64String(frmWeb["__EVENTARGUMENT"]));
								f.SQLNonQuery(Server.MapPath(strDatabase), "DELETE FROM booths WHERE votename='" + booth + "'");
								f.SQLNonQuery(Server.MapPath(strDatabase), "DROP TABLE " + booth + ";");
								break;
						}
					}

					LoadPage();
				}
				else
				{
					liMessage.Text = "<b>Your are either not signed in, or you are not a system administrator.</b>";
				}
			}
			catch (OleDbException ex)
			{
				liMessage.Text = "There was an error while accessing the database.<br>" +
					ex.Message;
			}
		}

		#region Private Functions
		private void LoadPage()
		{
			TableRow tblRow;
			TableCell tblCell;

			tblRow = new TableRow();
			tblCell = new TableCell(); // Booth Id
			tblCell.Text = "<div class=\"header\"><b>Booth Id</b></div>";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Booth Name
			tblCell.Text = "<div class=\"header\"><b>Booth Name</b></div>";
			tblCell.Style["Width"] = "15%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Booth Description
			tblCell.Text = "<div class=\"header\"><b>Booth Description</b></div>";
			//tblCell.Style["Width"] = "25%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // View Only
			tblCell.Text = "<div class=\"header\"><b>View Only</b></div>";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Delete
			tblCell.Text = "<div class=\"header\"><b>Delete</b></div>";
			tblCell.HorizontalAlign = HorizontalAlign.Center;
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Edit
			tblCell.Text = "<div class=\"header\"><b>Edit</b></div>";
			tblCell.HorizontalAlign = HorizontalAlign.Center;
			tblRow.Cells.Add(tblCell);
			tableBooths.Rows.Add(tblRow);

			DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM booths");

			if (dbSet != null)
			{
				foreach (DataRow dbRow in dbSet.Tables[0].Rows)
				{
					tblRow = new TableRow();
					tblCell = new TableCell(); // Booth Id
					tblCell.Text = Convert.ToString(dbRow["voteid"]);
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // Booth Name
					tblCell.Text = f.HWHyperLink("../feat/vote/viewbooth.aspx?id=" + Convert.ToBase64String(en.GetBytes(Convert.ToString(dbRow["votename"]))),
						Convert.ToString(dbRow["displayname"]));
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // Booth Description
					tblCell.Text = Convert.ToString(dbRow["description"]);
					tblCell.VerticalAlign = VerticalAlign.Top;
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // View Only
					tblCell.Text = Convert.ToString(dbRow["viewonly"]) + " (" + f.HWHyperLink("javascript:__doPostBack('changeboothstatus', '" + Convert.ToString(dbRow["voteid"]) + "-" + Convert.ToBoolean(dbRow["viewonly"]).ToString() + "')", "Change") + ")";
					// Convert.ToBase64String(en.GetBytes(Convert.ToString(dbRow["votename"])))
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // Delete
					tblCell.Text = f.HWHyperLink("javascript:__confirmBoothDeletion('" + Convert.ToBase64String(en.GetBytes(Convert.ToString(dbRow["votename"]))) + "')", f.HWImage("../images/icons/delete.gif", 0, "Delete Booth"));
					tblCell.HorizontalAlign = HorizontalAlign.Center;
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // Edit
					tblCell.Text = f.HWHyperLink("./editors/editbooth.aspx?id=" + Convert.ToBase64String(en.GetBytes(Convert.ToString(dbRow["votename"]))), f.HWImage("../images/icons/edit.gif", 0, "Edit Booth"));
					tblCell.HorizontalAlign = HorizontalAlign.Center;
					tblRow.Cells.Add(tblCell);
                        
					tableBooths.Rows.Add(tblRow);
				}
			}
			else
			{
				liMessage.Text = "<b>No booths do exist.</b>";
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
