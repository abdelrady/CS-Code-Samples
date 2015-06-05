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
using System.Security.Cryptography;

namespace csharphome.feat
{
	/// <summary>
	/// This page displays information about a given user
	/// </summary>
	public class userinfo : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Table tableUser;
		protected System.Web.UI.WebControls.Literal liMessage;

		string strDatabase = "../home.mdb";
		public string strUsername;
		public string usrId;
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));
			
			int strUsrId = Convert.ToInt32(Request.QueryString["usrid"]);
			usrId = Request.QueryString["usrid"];

			if (strUsrId != 0)
			{
				try
				{
					DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members WHERE usrid=" + strUsrId);
					TableCell tCell;
					TableRow tRow;
					
					if ((dbSet != null) && !(dbSet.Tables[0].Rows.Count < 1))
					{
						foreach (DataRow dbRow in dbSet.Tables[0].Rows) 
						{
							tRow = new TableRow(); // User name
							tCell = new TableCell();
							tCell.Text = "<b>User</b>";
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.Style["Width"] = "25%";
							tRow.Cells.Add(tCell);
							tCell = new TableCell();
							strUsername = Convert.ToString(dbRow["username"]); // This is used for serveral things...
							tCell.Text = strUsername;
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.Style["Width"] = "75%";
							
							tRow.Cells.Add(tCell);
							tableUser.Rows.Add(tRow);
							if (Convert.ToBoolean(Session["Admin"]))
							{            
								tRow = new TableRow(); // Password
								tCell = new TableCell();
								tCell.Text = "<b>Password</b>";
								tCell.HorizontalAlign = HorizontalAlign.Left;
								tCell.Style["Width"] = "25%";
								tRow.Cells.Add(tCell);
								tCell = new TableCell();
								if (Convert.ToBoolean(dbRow["superuser"]) && !(Convert.ToBoolean(Session["Admin"]) && Convert.ToBoolean(Session["su"])))
								{
									tCell.Text = "<code>Super User Passwords not provided.</code>";
								}
								else
								{
									Encoding en = Encoding.Default;
									csharphome.common.SymmCrypto h = new csharphome.common.SymmCrypto(common.SymmCrypto.SymmProvEnum.DES);

									tCell.Text = "<code>" + h.Decrypting(en.GetString(Convert.FromBase64String(Convert.ToString(dbRow["pass"]))), "pwd") + "</code>";
								}
								tCell.HorizontalAlign = HorizontalAlign.Left;
								tCell.Style["Width"] = "75%";
								tRow.Cells.Add(tCell);
								tableUser.Rows.Add(tRow);
							}
                            
							tRow = new TableRow(); // Member since.
							tCell = new TableCell();
							tCell.Text = "<b>Member since</b>";
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.Style["Width"] = "25%";
							tRow.Cells.Add(tCell);
							tCell = new TableCell();
							tCell.Text = Convert.ToString(dbRow["signupdate"]);
							tCell.HorizontalAlign = HorizontalAlign.Left;							
							tCell.Style["Width"] = "75%";
							tRow.Cells.Add(tCell);
							tableUser.Rows.Add(tRow);

							tRow = new TableRow(); // Last login
							tCell = new TableCell();
							tCell.Text = "<b>Last login</b>";
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.Style["Width"] = "25%";
							tRow.Cells.Add(tCell);
							tCell = new TableCell();

							if (Convert.ToString(dbRow["lastlogindate"]) != string.Empty)
							{
								DateTime origin = DateTime.Parse(Convert.ToString(dbRow["lastlogindate"]));
								long diff = DateTime.Now.Ticks - origin.Ticks;
							    
								tCell.Text = TimeString(diff / TimeSpan.TicksPerSecond) + " ago (" + Convert.ToString(dbRow["lastlogindate"]) + ")";
							}
							else
							{
								tCell.Text = "Unknown";
							}

							tCell.HorizontalAlign = HorizontalAlign.Left;							
							tCell.Style["Width"] = "75%";
							tRow.Cells.Add(tCell);
							tableUser.Rows.Add(tRow);
							
							tRow = new TableRow(); // Administrator?
							tCell = new TableCell();
							tCell.Text = "<b>Administrator</b>";               
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.Style["Width"] = "25%";
							tRow.Cells.Add(tCell);
							tCell = new TableCell();
							tCell.Text = Convert.ToString(dbRow["admin"]);
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.Style["Width"] = "75%";
							tRow.Cells.Add(tCell);
							tableUser.Rows.Add(tRow);

							if (Convert.ToBoolean(Session["LoggedIn"]))
							{
								tRow = new TableRow(); // Email
								tCell = new TableCell();
								tCell.Text = "<b>Email</b>";
								tCell.HorizontalAlign = HorizontalAlign.Left;
								tCell.Style["Width"] = "25%";
								tRow.Cells.Add(tCell);
								tCell = new TableCell();
								tCell.Text = f.HWHyperLink("mailto:" + Convert.ToString(dbRow["mail"]), Convert.ToString(dbRow["mail"]).Replace("@", " at "), "Email");
								tCell.HorizontalAlign = HorizontalAlign.Left;
								tCell.Style["Width"] = "75%";
								tRow.Cells.Add(tCell);
								tableUser.Rows.Add(tRow);
							}
							
							tRow = new TableRow(); // Description
							tCell = new TableCell();
							tCell.Text = "<b>Description</b>";
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.VerticalAlign = VerticalAlign.Top;
							tCell.Style["Width"] = "25%";
							tRow.Cells.Add(tCell);
							tCell = new TableCell();
							tCell.Text = Convert.ToString(dbRow["usrdescription"]);
							tCell.HorizontalAlign = HorizontalAlign.Left;
							tCell.VerticalAlign = VerticalAlign.Top;
							tCell.Style["Width"] = "75%";
							tRow.Cells.Add(tCell);
							tableUser.Rows.Add(tRow);
						}
					}
					else
					{
						strUsername = "Mr. Nobody";
						liMessage.Text = "Sorry but there is no user with the id of <b>" + strUsrId + "</b>";
					}
                
					dbSet.Dispose();					
				}
				catch
				{
					liMessage.Text = "There was an error while accessing the database.<br>Please try agian later.";
				}
			}
			else
			{
				liMessage.Text = "No <b>userid</b> was specified.";
			}
		}

		#region Private Functions
		private string TimeString(long Seconds)
		{
			long lDays;
			long lHrs;
			long lMinutes;
			long lSeconds;
			string sAns = string.Empty;

			lSeconds = Seconds;

			lDays = (lSeconds / 3600) / 24;
			lHrs = (lSeconds / 3600) - (lDays * 24);
			lMinutes = (lSeconds / 60) - ((lHrs + (lDays * 24)) * 60);
			lSeconds = (lSeconds % 60);

			if (lDays != 0)
			{
				sAns += lDays.ToString("n0") + " day";
				if (lDays > 1) sAns += "s";
			}
			if (lHrs != 0)
			{
				sAns += " " + lHrs.ToString("n0") + " hour";
				if (lHrs > 1) sAns += "s";
			}
			if (lMinutes != 0) 
			{
				sAns += " " + lMinutes.ToString("n0") + " minute";
				if (lMinutes > 1) sAns += "s";
			}
			if (lSeconds != 0) 
			{
				sAns += " " + lSeconds.ToString("n0") + " second";
				if (lSeconds > 1) sAns += "s";
			}

			return sAns;
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
