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

namespace csharphome.manage.editors
{
	/// <summary>
	/// This page allows for administrators to edit voting booths
	/// </summary>
	public class editbooth : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtBoothName;
		protected System.Web.UI.WebControls.TextBox txtId;
		protected System.Web.UI.WebControls.Table tableBooth;
		protected System.Web.UI.WebControls.TextBox txtEdited;
		protected System.Web.UI.WebControls.Button btnSubmit;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.WebControls.TextBox txtDescription;

		const string strDatabase = "../../home.mdb";		
		private csharphome.common.homepage f;
		private Encoding en = Encoding.Default;		
		private string strId;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			// We don't want this to be stored locally
			Response.Cache.SetCacheability(HttpCacheability.NoCache);

			strId = en.GetString(Convert.FromBase64String(Request.QueryString["id"]));
			txtId.Text = strId;
			if (strId == String.Empty) 
			{
				liMessage.Text = "No booth id was specified.";
				return;
			}

			try 
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					/* Check to see if the user requested updates to something first
					 * so that they don't get old data */
					NameValueCollection frmWeb = Request.Form;
					if (frmWeb != null) 
					{
						switch (frmWeb["__EVENTTARGET"])
						{
							case "deletechoice":
								f.SQLNonQuery(Server.MapPath(strDatabase), "DELETE FROM " + strId + " WHERE voteid=" + frmWeb["__EVENTARGUMENT"]);
								txtEdited.Text = "NO";
								break;
						}
					}

					if (txtEdited.Text != "YES") 
					{
						DataSet dbSetA = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM " + strId);
						DataSet dbSetB = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM booths WHERE votename='" + strId + "'");						

						TableRow tblRow;
						TableCell tblCell;

						if (dbSetB != null)
						{
							foreach (DataRow dbRow in dbSetB.Tables[0].Rows)
							{
								txtBoothName.Text = Convert.ToString(dbRow["displayname"]);
								txtDescription.Text = Convert.ToString(dbRow["description"]).Replace("<br>", "\n");
							}

							if (dbSetA != null) 
							{
								foreach (DataRow dbRow in dbSetA.Tables[0].Rows) 
								{
									tblRow = new TableRow();
									tblCell = new TableCell(); // Vote Choice
									tblCell.Text = "<input type=\"text\" name=\"VoteChoice_" +
										Convert.ToString(dbRow["voteid"]) +
										"\" value=\"" + Convert.ToString(dbRow["votename"]) + "\">";
									tblRow.Cells.Add(tblCell);
									tblCell = new TableCell(); // Vote Value
									tblCell.Text = "<input type=\"text\" name=\"VoteValue_" +
										Convert.ToString(dbRow["voteid"]) +
										"\" value=\"" + Convert.ToString(dbRow["votevalue"]) + "\">";
									tblRow.Cells.Add(tblCell);
									tblCell = new TableCell(); // Delete this choice
									tblCell.Text = f.HWHyperLink("javascript:__confirmDeletion('" + Convert.ToString(dbRow["voteid"]) + "')", f.HWImage("../../images/icons/delete.gif", 0, "Delete Choice"));
									tblRow.Cells.Add(tblCell);
									tableBooth.Rows.Add(tblRow);
								}
							}
						}						

						if (txtEdited.Text == "NO") txtEdited.Text = "YES";
					}
				} 
				else 
				{
					liMessage.Text = "<b>Your either not logged in, or you are not a system administrator.</b>";
				}
			}
			catch (Exception ex)
			{
				liMessage.Text = "<b>An exception was thrown:</b><br>" + ex.Message;
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
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
			{                               
				try
				{
					// Update the booth
					strId = en.GetString(Convert.FromBase64String(Request.QueryString["id"]));
					NameValueCollection frmWeb = Request.Form;
            
					if (frmWeb != null) 
					{
						f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE booths SET displayname='" + txtBoothName.Text.Replace("'", "&#039;") + "' WHERE votename='" + strId + "'");
						f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE booths SET description='" + txtDescription.Text.Replace("'", "&#039;").Replace("\n", "<br>") + "' WHERE votename='" + strId + "'");
						for (int i = 0; i <= (frmWeb.Count - 1); i++)
						{
							string whatis = frmWeb.GetKey(i);
							if (whatis.StartsWith("VoteChoice_"))
							{
								// Update the choices names     Response.Write(frmWeb.GetKey(i) + "==" + frmWeb[i] + "<br>");
								f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE " + strId + " SET votename='" + frmWeb[i].Replace("'", "&#039;") + "' WHERE voteid=" + whatis.Replace("VoteChoice_", string.Empty));
								//Response.Write("UPDATE " + strId + " SET votename='" + frmWeb[i] + "' WHERE voteid=" + whatis.Replace("VoteChoice_", string.Empty) + "<br>");
							}
							else if (whatis.StartsWith("VoteValue_"))
							{
								// Update the choices values
								f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE " + strId + " SET votevalue=" + frmWeb[i].Replace("'", "&#039;") + " WHERE voteid=" + whatis.Replace("VoteValue_", string.Empty));
								//Response.Write("UPDATE " + strId + " SET votevalue=" + frmWeb[i] + " WHERE voteid=" + whatis.Replace("VoteValue_", string.Empty) + "<br>");
							}
						}
					}
                    
					//Response.Redirect("./editbooth.aspx?id=" + Convert.ToBase64String(en.GetBytes(strId)));
					Response.Redirect("../vote.aspx");
				}
				catch (Exception ex)
				{
					liMessage.Text = "<b>An exception was thrown:</b><br>" + ex.Message;
				}
			}
		}
	}
}
