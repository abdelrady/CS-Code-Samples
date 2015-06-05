using System;
using System.Management;
using System.Diagnostics;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using Org.Mentalis.Utilities;

namespace csharphome.manage
{
	/// <summary>
	/// This page allows administrators with Super User access to control some aspects of
	/// the server computer remotely
	/// </summary>
	public class system : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Table tableProcesses;
		protected System.Web.UI.WebControls.Literal liMessage;

		const string strDatabase = "../home.mdb";
		protected System.Web.UI.WebControls.Label lblSystemUptime;
		private csharphome.common.homepage f;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]) && Convert.ToBoolean(Session["su"]))
			{
				/* Check to see if the user requested updates to something first
				 * so that they don't get old data */
				NameValueCollection frmWeb = Request.Form;
				if (frmWeb != null) 
				{
					switch (frmWeb["__EVENTTARGET"])
					{
						case "killprocess":
							try
							{
								Process kprc = Process.GetProcessById(Convert.ToInt32(frmWeb["__EVENTARGUMENT"]));
								kprc.Kill();
							}
							catch (Exception ex)
							{
								liMessage.Text = "Error while killing process <b>" + frmWeb["__EVENTARGUMENT"] +
									"</b><br>" + ex.Message;
							}
							break;
						case "power":
							try
							{
								/*SelectQuery query = new SelectQuery("select name from Win32_OperatingSystem where primary=true");
								ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

								foreach(ManagementObject os in searcher.Get())
								{            
									os.Scope.Options.EnablePrivileges = true;
									ManagementBaseObject outParams = os.InvokeMethod
										(frmWeb["__EVENTARGUMENT"], null, null);
								}*/
								switch (frmWeb["__EVENTARGUMENT"].ToLower())
								{
									case "shutdown":
										Response.Write("Shutting down...");
										WindowsController.ExitWindows(RestartOptions.ShutDown, true);
										Response.Write("done. This might take a few seconds.");
										break;
									case "restart":
										Response.Write("Restarting...");
										WindowsController.ExitWindows(RestartOptions.Reboot, true);
										Response.Write("done. This might take a few seconds.");
										break;
									case "hibernate":
										Response.Write("Hibernating...");
										WindowsController.ExitWindows(RestartOptions.Hibernate, true);
										Response.Write("done. This might take a few seconds.");
										break;
									case "suspend":
										Response.Write("Suspending...");
										WindowsController.ExitWindows(RestartOptions.Suspend, true);
										Response.Write("done. This might take a few seconds.");
										break;
								}								
							}
							catch (Exception ex)
							{
								liMessage.Text = "Error while attempting to invoke power control: " + ex.Message;
							}
							break;
					}
				}

				FillProcessList();

				// Get the system uptime
				PerformanceCounter pc = new PerformanceCounter("System",
					"System Up Time");

				//Normally starts with zero. do Next Value always.
				pc.NextValue(); 
				TimeSpan ts = TimeSpan.FromSeconds(pc.NextValue());
    
				lblSystemUptime.Text = "This system " + Environment.MachineName + 
					" has been up for " + ts.Days + " days, " + ts.Hours + 
					" hours, " + ts.Minutes + " minutes and " + ts.Seconds + 
					" seconds.";

			}
			else
			{
				liMessage.Text = "<b>Your are either not signed in, or you are not a system administrator with Super User access.</b>";
			}
		}

		#region Process Viewer
		private void FillProcessList()
		{
			Process prc;
			TableRow tblRow;
			TableCell tblCell;

			tblRow = new TableRow();
			tblCell = new TableCell(); // Image Name
			tblCell.Text = "<div class=\"header\">Image Name</div>";
			tblCell.Style["Width"] = "25%";
			tblRow.Cells.Add(tblCell);
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // User
			tblCell.Text = "<div class=\"header\">User</div>";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Memory Usage
			tblCell.Text = "<div class=\"header\">Memory Usage</div>";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Responding
			tblCell.Text = "<div class=\"header\">Responding</div>";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Process Id
			tblCell.Text = "<div class=\"header\">Process Id</div>";
			tblRow.Cells.Add(tblCell);
			tableProcesses.Rows.Add(tblRow);

			try
			{
				// Get process info including a method to return the user who is running it
				ConnectionOptions oConn = new ConnectionOptions();
				ManagementScope oMs = new System.Management.ManagementScope("\\\\localhost", oConn);
				ObjectQuery oQuery = new System.Management.ObjectQuery("SELECT * FROM Win32_Process");
				ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
				ManagementObjectCollection oReturnCollection = oSearcher.Get();

				foreach (ManagementObject oReturn in oReturnCollection) 
				{
					// Get the Owner and the Process Id
					string[] owner = new string[2];
		            oReturn.InvokeMethod("GetOwner", (object[]) owner);

					// Populate the above information into a Process object
					prc = Process.GetProcessById(Convert.ToInt32(oReturn["ProcessId"]));

					// Continue with the making the tables
					tblRow = new TableRow();
					tblCell = new TableCell(); // Image Name
					tblCell.Text = (Convert.ToString(oReturn["Name"]).ToLower() == "aspnet_wp.exe" ?
						f.HWHyperLink("javascript:__killProcess('" + oReturn["ProcessId"] + "', 'aspnet_wp.exe')",
						f.HWImage("../images/icons/delete.gif", 0, "Kill ASP.NET Worker Process")) +
						"&nbsp;" : null) + Convert.ToString(oReturn["Name"]).ToLower();
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // User
					tblCell.Text = owner[1] + "\\" + owner[0];
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // Memory Usage
					tblCell.Text = f.FormatKB((double) prc.WorkingSet);
					tblRow.Cells.Add(tblCell);
					tblCell = new TableCell(); // Responding
					tblCell.Text = prc.Responding.ToString();
					tblRow.Cells.Add(tblCell);					
					tblCell = new TableCell(); // Process Id
					tblCell.Text = oReturn["ProcessId"].ToString();
					tblRow.Cells.Add(tblCell);

					tableProcesses.Rows.Add(tblRow);
				}
			}
			catch (Exception ex)
			{
				liMessage.Text = "An exception has occurred: " + ex.Message;
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
