using System;
using System.IO;
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
	/// Summary description for counter.
	/// </summary>
	public class counter : System.Web.UI.Page
	{

		const string strCounterDirectory = "../counters/";
		private csharphome.common.GDIShortcuts errGraphic = new csharphome.common.GDIShortcuts();

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Declare variables.
			string strCounterFor = Request.QueryString["for"];
			StreamReader objReader;
			StreamWriter objWriter;
			int intCount;
			string strCounterText;
			FileInfo objFileInfo; 
			string strFilename;
			bool boolHourExpires = false;

			// Here we make sure no one can keep refreshing the page to get the counter up.
			if (Session["Counter_" + strCounterFor] == null) 
			{
				if (Request.ServerVariables["REMOTE_ADDR"] != "127.0.0.1") 
				{
					Session["Counter_" + strCounterFor] = "Yes";
					Session.Timeout = 60;
					boolHourExpires = true;
				}
			} 
			else 
			{
				// We don't want a new visit count from you until an hour has gone by.
				boolHourExpires = false;
			}

			try 
			{
				// If someone forgot to type there name...
				if (strCounterFor == string.Empty) 
				{
					byte[] errgrap = errGraphic.OutputErrorBitmap("No counter name was specified.\nCan not display counter.");
					Response.ContentType = "image/png";
					Response.OutputStream.Write(errgrap, 0, errgrap.Length);
					return;
				}

				// Setup our filename
				strFilename = Server.MapPath(strCounterDirectory) + strCounterFor + ".txt";

				// First check if the file we want exists or not, if not create a new file.
				objFileInfo = new FileInfo(strFilename);
				if (objFileInfo.Exists == false) 
				{
					objWriter = new StreamWriter(strFilename, false, new System.Text.ASCIIEncoding());
					objWriter.Write("5");
					objWriter.Close();
				}

				// Get the current count.
				objReader = new StreamReader(strFilename);
				intCount = Convert.ToInt32(objReader.ReadToEnd());
				objReader.Close();
				// Now write the new count. But if only boolHourExpires is True.
				if (boolHourExpires) 
				{
					objWriter = new StreamWriter(strFilename, false, new System.Text.ASCIIEncoding());
					objWriter.Write(intCount + 1);
					objWriter.Close();
				} 
				else 
				{
					intCount -= 1;
				}

				// Now display our results! (Hum.. looks like the output error code used under this sub...)
				Bitmap gphResult = new Bitmap(1, 1, PixelFormat.Format24bppRgb);
				Graphics gphGraphics = Graphics.FromImage(gphResult);
				Font fntFont = new Font("Courier New", 20, FontStyle.Bold); // Lucida Console
				SizeF textSize;
				MemoryStream streamMemory = new MemoryStream();
				strCounterText = string.Format("{0:#,#}", intCount + 1);

				// Draw our message!
				csharphome.common.GDIShortcuts g = new csharphome.common.GDIShortcuts();
				textSize = g.gdiMeasureString(strCounterText, fntFont);
				gphResult = new Bitmap(Convert.ToInt32(textSize.Width), Convert.ToInt32(textSize.Height), PixelFormat.Format24bppRgb);
				gphGraphics = Graphics.FromImage(gphResult);
				gphGraphics.Clear(Color.White);
				gphGraphics.DrawRectangle(Pens.Blue, new Rectangle(0, 0, Convert.ToInt32(textSize.Width) - 1, Convert.ToInt32(textSize.Height) - 1));
				gphGraphics.DrawString(strCounterText, fntFont, Brushes.Blue, 2, 1);
				// Setup and send a response.
				Response.ContentType = "image/png";
				gphResult.Save(streamMemory, ImageFormat.Png);
				Byte[] buffer = streamMemory.ToArray();
				Response.OutputStream.Write(buffer, 0, buffer.Length);
				// Clean up.
				streamMemory.Close();
				gphGraphics.Dispose();
				gphResult.Dispose();
				Response.End();
			}
			catch (Exception ex) 
			{
				byte[] errgrap = errGraphic.OutputErrorBitmap("There was an error while attempting to display counter.\n\n" + ex.Message.Replace(Server.MapPath("/"), ""));
				Response.ContentType = "image/png";
				Response.OutputStream.Write(errgrap, 0, errgrap.Length);
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
