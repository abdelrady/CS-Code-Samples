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

namespace csharphome.feat.vote
{
	/// <summary>
	/// This page shows all the closed and open voting booths on the site
	/// </summary>
	public class _default : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.Table tableBooths;
		protected System.Web.UI.WebControls.Table tableClosed;
		protected System.Web.UI.WebControls.Literal liLinks;

		const string strDatabase = "../../home.mdb";
		private csharphome.common.homepage f;
		private Encoding en = Encoding.Default;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			TableRow tblRow;
			TableCell tblCell;

			tblRow = new TableRow();
			tblCell = new TableCell(); // Booth Name
			tblCell.Text = "<div class=\"header\"><b>Booth Name</b></div>";
			tblCell.Style["Width"] = "25%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Booth Description
			tblCell.Text = "<div class=\"header\"><b>Booth Description</b></div>";
			tblRow.Cells.Add(tblCell);
			tableBooths.Rows.Add(tblRow);

			tblRow = new TableRow();
			tblCell = new TableCell(); // Booth Name
			tblCell.Text = "<div class=\"header\"><b>Booth Name</b></div>";
			tblCell.Style["Width"] = "25%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Booth Description
			tblCell.Text = "<div class=\"header\"><b>Booth Description</b></div>";
			tblRow.Cells.Add(tblCell);
			tableClosed.Rows.Add(tblRow);

			try
			{
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM booths");

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						tblRow = new TableRow();
						tblCell = new TableCell(); // Booth Name
						tblCell.Text = f.HWHyperLink("./viewbooth.aspx?id=" + Convert.ToBase64String(en.GetBytes(Convert.ToString(dbRow["votename"]))),
							Convert.ToString(dbRow["displayname"]));
						tblCell.Style["Width"] = "25%";
						tblRow.Cells.Add(tblCell);
						tblCell = new TableCell(); // Booth Description
						tblCell.Text = Convert.ToString(dbRow["description"]);
						tblRow.Cells.Add(tblCell);

						if (!Convert.ToBoolean(dbRow["viewonly"]))
						{
							tableBooths.Rows.Add(tblRow);
						}
						else
						{
							tableClosed.Rows.Add(tblRow);
						}
					}
				}
				else
				{
					liMessage.Text = "<b>No booths do exist.</b>";
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
