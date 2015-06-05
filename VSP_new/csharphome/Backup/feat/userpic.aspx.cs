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

namespace csharphome.feat
{
	/// <summary>
	/// This page results as a image from a database
	/// </summary>
	public class userpic : System.Web.UI.Page
	{
		const string strDatabase = "../home.mdb";
		private csharphome.common.homepage f;

		private void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
				f = new csharphome.common.homepage();

				string strImageSource = Request.QueryString["usrid"];
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members WHERE usrid = " + strImageSource);
				System.Drawing.Image imgOutput = null;

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						/*byte[] usrimage = Convert.FromBase64String(Convert.ToString(dbRow["pic"]));
						imgOutput = System.Drawing.Image.FromStream(new MemoryStream(usrimage));
						FileStream v = new FileStream(Server.MapPath("../images/users/" + strImageSource + ".png"), FileMode.Create);
						imgOutput.Save(v, System.Drawing.Imaging.ImageFormat.Png);
						v.Close();*/
						imgOutput = System.Drawing.Image.FromFile(Server.MapPath("../images/users/" + Convert.ToString(dbRow["usrid"]) + ".png"));
					}
				}
			
				MemoryStream objStreamMemory = new MemoryStream(); // I/O
				Response.ContentType = "image/x-png";
				imgOutput.Save(objStreamMemory, System.Drawing.Imaging.ImageFormat.Png);

				byte[] buffer = objStreamMemory.ToArray();
				Response.OutputStream.Write(buffer, 0, buffer.Length);

				// Clean up.
				imgOutput.Dispose();
				objStreamMemory.Close();
				Response.End();
			}
			catch
			{
				csharphome.common.GDIShortcuts g = new csharphome.common.GDIShortcuts();
				
				byte[] buffer = g.OutputErrorBitmap("Could not\nload user\nicon.");
				Response.OutputStream.Write(buffer, 0, buffer.Length);
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
