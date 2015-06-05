using System;
using System.IO;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace csharphome.feat
{
	/// <summary>
	/// This page is really a PNG image that loads a local image and makes a thumbnail
	/// of it
	/// </summary>
	public class imageengine : System.Web.UI.Page
	{
		//private csharphome.common.homepage f;

		private void Page_Load(object sender, System.EventArgs e)
		{
			string strImageSource = Request.QueryString["src"];
			Encoding en = Encoding.Default;
			sendFile(en.GetString(Convert.FromBase64String(strImageSource)));
			//sendFile(strImageSource);
		}

		#region Imaging Functions
		private Size NewthumbSize(int currentwidth, int currentheight)
		{
			double tempMultiplier;

			if (currentheight > currentwidth) // portrait  
			{
				tempMultiplier = 120 / (double) currentheight;
				if ((currentwidth * tempMultiplier) > currentwidth)
				{
					tempMultiplier /= 2;
				}
			}
			else
			{
				tempMultiplier = 120 / (double) currentwidth;
				if ((currentheight * tempMultiplier) > currentheight)
				{
					tempMultiplier /= 2;
				}
			}
			
			return new Size(Convert.ToInt32(currentwidth * tempMultiplier), Convert.ToInt32(currentheight * tempMultiplier));
		}

		private void sendFile(string strSource)
		{
			try
			{
				// Declare all of our variables and create the thumbnail!
				System.Drawing.Image gphImage = System.Drawing.Image.FromFile(Server.MapPath(strSource));
				MemoryStream objStreamMemory = new MemoryStream(); // I/O
				Size thumbSize = NewthumbSize(gphImage.Width, gphImage.Height);

				Bitmap imgOutput = new Bitmap(gphImage, thumbSize);
				//Dim gphGraphics As Graphics = Graphics.FromImage(imgOutput)

				// Send a response.
				Response.ContentType = "image/x-png";
				imgOutput.Save(objStreamMemory, System.Drawing.Imaging.ImageFormat.Png);
				byte[] buffer = objStreamMemory.ToArray();
				Response.OutputStream.Write(buffer, 0, buffer.Length);

				// Clean up.
				objStreamMemory.Close();
				gphImage.Dispose();
				gphImage = null;
				Response.End();
			}
			catch (Exception ex)
			{
				csharphome.common.GDIShortcuts g = new csharphome.common.GDIShortcuts();
				
				byte[] buffer = g.OutputErrorBitmap("An exception has occurred while creating thumbnail\n\n" + ex.Message);
				Response.OutputStream.Write(buffer, 0, buffer.Length);
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
