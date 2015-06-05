using System;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Data.OleDb;
using System.Globalization;

namespace csharphome.common
{
	/// <summary>
	/// Common routines used throughout my web application.
	/// </summary>
	public class homepage
	{
		public string loadLinksList(string strFileDB, bool boolShowAdmin)
		{
			try
			{
				DataSet dbSet = new DataSet();
				string strBuffer = string.Empty;

				// Connect to the database and open it.
				OleDbConnection odbConnect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strFileDB + ";Persist Security Info=False");
				odbConnect.Open();
				OleDbDataAdapter dbAdapter = new OleDbDataAdapter();
				// Get what we want.
				dbAdapter.SelectCommand = new OleDbCommand("SELECT * FROM links", odbConnect);
				// Get all of our data and store it in memory.
				dbAdapter.Fill(dbSet);

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						if ((Convert.ToInt32(dbRow["linkid"]) > dbSet.Tables[0].Rows.Count - 1) && (boolShowAdmin == false))
						{
							break;
						}
						strBuffer += string.Format("<!-- Linkid={0} -->{1}<!-- EOF --><br><br>", dbRow["linkid"], dbRow["linkdata"]);
					}	
				}		 
				
				dbSet.Dispose();
				dbAdapter.Dispose();
				odbConnect.Close();
				
				return strBuffer;
			}
			catch (Exception ex)
			{
				return "<b>And error occurred while attempting to read links config file.</b><br>\n" + HWFontSize(ex.Message, 2);
			}
		}

		public string loadArticleList(string strFileDB, bool boolShowAll)
		{
			try
			{
				DataSet dbSet = new DataSet();
				string strBuffer = string.Empty; 
				string strLinkPrefix;
				bool boolOutsideLink;
				bool boolSeparatorNotAgain = false;

				// Connect to the database and open it.
				OleDbConnection odbConnect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strFileDB + ";Persist Security Info=False");
				odbConnect.Open();
				OleDbDataAdapter dbAdapter = new OleDbDataAdapter();
				// Get what we want.
				dbAdapter.SelectCommand = new OleDbCommand("SELECT * FROM articles ORDER BY displayimage ASC, articledate DESC", odbConnect); // 
				// Get all of our data and store it in memory.
				dbAdapter.Fill(dbSet);

				if (dbSet != null)
				{
					if (boolShowAll) strBuffer = RenderShowAllListHeaders(); // If boolShowAll is true, first render the header for our table.
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						// Get the article link
						if (Convert.ToBoolean(dbRow["outsidelink"]) == false)
						{
							strLinkPrefix = "viewarticle.aspx?id=" + dbRow["articleid"];
							boolOutsideLink = false;
						} 
						else 
						{
							strLinkPrefix = Convert.ToString(dbRow["article"]);
							boolOutsideLink = true;
						}

						// Now display it
						if (boolShowAll) 
						{
							if ((Convert.ToString(dbRow["displayimage"]).ToUpper() == "NOIMAGE") && (boolSeparatorNotAgain == false))
							{
								strBuffer += RenderShowAllListHeaders();
								boolSeparatorNotAgain = true;
							}
							strBuffer += RenderShowAllList(Convert.ToString(dbRow["articledate"]), strLinkPrefix, Convert.ToString(dbRow["articlename"]), boolOutsideLink, Convert.ToString(dbRow["postedby"]), Convert.ToString(dbRow["postedbyid"]));
						} 
						else 
						{
							// Normal displays
							if (Convert.ToBoolean(dbRow["hidden"]) != true) 
							{
								if (Convert.ToString(dbRow["displayimage"]).ToUpper() == "NOIMAGE") 
								{
									strBuffer += "<b>" + HWHyperLink(strLinkPrefix, Convert.ToString(dbRow["articlename"]), Convert.ToString(dbRow["articlename"]), (boolOutsideLink == true ? "_blank" : "_top")) + "</b><br>" +
										HWFontSize(Convert.ToString(dbRow["description"]), 2) + "<br>" + HWFontSize("Posted by " + HWHyperLink("./feat/userinfo.aspx?usrid=" + Convert.ToString(dbRow["postedbyid"]), Convert.ToString(dbRow["postedby"]), Convert.ToString(dbRow["postedby"])) + " Created " + Convert.ToString(dbRow["articledate"]), 1) + "<br><br>";
								} 
								else 
								{
									strBuffer += RenderImageArticle(Convert.ToString(dbRow["articledate"]), Convert.ToString(dbRow["displayimage"]), strLinkPrefix, Convert.ToString(dbRow["articlename"]), boolOutsideLink, Convert.ToString(dbRow["postedby"]), Convert.ToString(dbRow["postedbyid"]), Convert.ToString(dbRow["description"]));
								}
							}
						}
					}
				}

				dbSet.Dispose();
				dbAdapter.Dispose();
				odbConnect.Close();

				return strBuffer;
			}
			catch (Exception ex)
			{
				return "<b>And error occurred while attempting to read article config file.</b><br>\n" + HWFontSize(ex.Message, 2);
				}
		}

		#region Basic Functions
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
			lMinutes = (lSeconds / 60) - (lHrs + (lDays * 24) * 60);
			lSeconds = lSeconds %= 60;

			if (lDays != 0)
			{
				sAns += lDays.ToString("#####0") + " day";
			}
			if (lHrs != 0)
			{
				sAns += " " + lHrs.ToString("#####0") + " hour";
			}
			if (lMinutes != 0)
			{
				sAns += " " + lMinutes.ToString("##0") + " minute";
			}
			if (lSeconds != 0)
			{
				sAns += " " + lSeconds.ToString("00") + " second";
			}

			return sAns;
		}

		public string SplitString(string strOrginalString, char charDelimiter, int intArrayItem)
		{
			string[] strTemp;
			strTemp = strOrginalString.Split(charDelimiter);
			
			int tArrayItem;

			switch (intArrayItem)
			{
				case -3: // foldername with / at the end
					tArrayItem = strTemp.GetUpperBound(0) - 1;
					break;
				case -2: // Ubound
					tArrayItem = strTemp.GetUpperBound(0);
					break;
				case -1: // Lbound
					tArrayItem = strTemp.GetLowerBound(0);
					break;
				default:
					tArrayItem = intArrayItem;
					break;
			}

			return strTemp[tArrayItem];
		}

		public string FormatKB(double lSize) 
		{
			//Format number to KB 
			string stringSize = ""; 
			NumberFormatInfo myNfi = new NumberFormatInfo();
			double lKBSize = 0; 
	
			if (lSize < 1024) 
			{ 
				if (lSize == 0) 
				{ 
					//zero byte 
					stringSize = "0"; 
				} 
				else 
				{ 
					//less than 1K but not zero byte 
					lKBSize = lSize;
		
					//format number with default format
					stringSize = lKBSize.ToString("n0", myNfi);
		
					//remove decimal
					stringSize = stringSize + " bytes";
				} 
			} 
			else
			{
				if (lSize < 1048576)
				{
					//convert to KB
					lKBSize = lSize / 1024;
		
					//format number with default format
					stringSize = lKBSize.ToString("n0", myNfi);
		
					//remove decimal
					stringSize = stringSize + " KB";
				} 
				else
				{
					//convert to MB
					lKBSize = lSize / 1048576;
		
					//format number with default format
					stringSize = lKBSize.ToString("n", myNfi);
		
					//remove decimal
					stringSize = stringSize + " MB";
				}
			}
	
			return stringSize; 
		}
		#endregion
		#region loadArticleList Helper functions
		private string RenderShowAllListHeaders()
		{
			StringWriter objStringWriter = new StringWriter();
			HtmlTextWriter objHtmlWriter = new HtmlTextWriter(objStringWriter);
			Table tableOldArticles = new Table();
			TableCell tblCell;
			TableRow tblRow = new TableRow();
			tableOldArticles.Style["Width"] = "100%";
			
			tblCell = new TableCell(); // Article Date
			tblCell.Text = "<div class=\"header\">Article Date</div>";
			tblCell.Style["Width"] = "25%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Subject
			tblCell.Text = "<div class=\"header\">Subject</div>";
			tblCell.Style["Width"] = "60%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Posted By
			tblCell.Text = "<div class=\"header\">Posted By</div>";
			tblRow.Cells.Add(tblCell);
			tableOldArticles.Rows.Add(tblRow);
			tableOldArticles.RenderControl(objHtmlWriter);

			return objStringWriter.ToString();
		}

		private string RenderShowAllList(string strDate, string strLinkPrefix, string strSubject, bool boolOutsideLink, string strPostedBy, string strPostedById)
		{
			StringWriter objStringWriter = new StringWriter();
			HtmlTextWriter objHtmlWriter = new HtmlTextWriter(objStringWriter);
			Table tableOldArticles = new Table();
			TableCell tblCell;
			TableRow tblRow = new TableRow();
			tableOldArticles.Style["Width"] = "100%";

			tblCell = new TableCell(); // Article Date
			tblCell.Text = strDate;
			tblCell.Style["Width"] = "25%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Subject
			tblCell.Text = HWHyperLink(strLinkPrefix, strSubject, strSubject, (boolOutsideLink == true ? "_blank" : null));
			tblCell.Style["Width"] = "60%";
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Posted By
			tblCell.Text = HWHyperLink("./feat/userinfo.aspx?usrid=" + strPostedById, strPostedBy, strPostedBy);
			tblRow.Cells.Add(tblCell);
			tableOldArticles.Rows.Add(tblRow);
			tableOldArticles.RenderControl(objHtmlWriter);

			return objStringWriter.ToString();
		}

		private string RenderImageArticle(string strDate, string strDisplayImage, string strLinkPrefix, string strSubject, bool boolOutsideLink, string strPostedBy, string strPostedById, string strDescription)
		{
			StringWriter objStringWriter = new StringWriter();
			HtmlTextWriter objHtmlWriter = new HtmlTextWriter(objStringWriter);
			Table tableArticles = new Table();
			TableCell tblCell;
			TableRow tblRow = new TableRow();
			tableArticles.CellPadding = 6;
			tableArticles.CellSpacing = 0;

			tblCell = new TableCell(); // Article Image
			tblCell.Text = HWHyperLink(strLinkPrefix, HWImage(strDisplayImage, -1, strSubject), strSubject, (boolOutsideLink == true ? "_blank" : "_top"));
			tblRow.Cells.Add(tblCell);
			tblCell = new TableCell(); // Article Information
			tblCell.Text = "<b>" + HWHyperLink(strLinkPrefix, strSubject, strSubject) + "</b><br>" + strDescription;
			tblRow.Cells.Add(tblCell);
			tableArticles.Rows.Add(tblRow);
			tableArticles.RenderControl(objHtmlWriter);

			return objStringWriter.ToString() + HWFontSize("Posted by " + HWHyperLink("./feat/userinfo.aspx?usrid=" + strPostedById, strPostedBy, strPostedBy) + " Created " + strDate, 1) + "<br><br>";
		}
			
		#endregion
		#region Database Functions
		public void updateThreadStatisics(string strDatabase, string strMsgId, string strKey, string strValue)
		{
			SQLNonQuery(strDatabase, "UPDATE messages SET " + strKey + " = " + strValue + " WHERE msgid = " + strMsgId);
		}

		public DataSet loadDatabase(string DatabaseFilename, string SQLStatement)
		{
			DataSet dbSet = new DataSet();

			// Connect to the database and open it.
			OleDbConnection odbConnect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DatabaseFilename + ";Persist Security Info=False");
			odbConnect.Open();
			OleDbDataAdapter dbAdapter = new OleDbDataAdapter();
			// Get what we want.
			dbAdapter.SelectCommand = new OleDbCommand(SQLStatement, odbConnect);
			// Get all of our data and store it in memory.
			dbAdapter.Fill(dbSet);

			dbAdapter.Dispose();
			odbConnect.Close();

			return dbSet;
		}

		public void SQLNonQuery(string DatabaseFilename, string SQLStatement)
		{
			// Connect to the database and open it.			
			OleDbConnection odbConnect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DatabaseFilename + ";Persist Security Info=False;");
			odbConnect.Open();				
			// Update what we want.
			OleDbCommand odbCommand = new OleDbCommand(SQLStatement, odbConnect);
			odbCommand.ExecuteNonQuery();
			
			odbCommand.Dispose();
			odbConnect.Close();
		}
		#endregion
		#region HTML
		public string HWFontSize(string Content, int Size)
		{
			return string.Format("<font size=\"{0}\">{1}</font>", Size, Content);
		}

		public virtual string HWHyperLink(string linkto, string linktext)
		{
			return string.Format("<a href=\"{0}\">{1}</a>", linkto, linktext);
		}

		public virtual string HWHyperLink(string linkto, string linktext, string tooltip)
		{
			return string.Format("<a href=\"{0}\" title=\"{1}\">{2}</a>", linkto, tooltip, linktext);
		}

		public virtual string HWHyperLink(string linkto, string linktext, string tooltip, string targetto)
		{
			return string.Format("<a href=\"{0}\" title=\"{1}\" target=\"{2}\">{3}</a>", linkto, tooltip, targetto, linktext);
		}		

		public virtual string HWImage(string imagesrc, int bordersize, string alt)
		{
			string bordersizetext;
			string alttext;
			
			if (bordersize == -1) 
			{
				bordersizetext = null;
			}
			else
			{
				bordersizetext = " border=\"" + Convert.ToString(bordersize) + "\" ";
			}

			if (alt == string.Empty)
			{
				alttext = null;
			}
			else
			{
				alttext = " alt=\"" + alt + "\"";
			}
			
			return string.Format("<img src=\"{0}\"{1}{2}>", imagesrc, bordersizetext, alttext);
		}

		public virtual string HWImage(string imagesrc, int bordersize, string alt, int height, int width)
		{
			string bordersizetext;
			string alttext;
			string heighttext;
			string widthtext;
			
			if (bordersize == -1) 
			{
				bordersizetext = null;
			}
			else
			{
				bordersizetext = " border=\"" + Convert.ToString(bordersize) + "\"";
			}

			if (alt == string.Empty)
			{
				alttext = null;
			}
			else
			{
				alttext = " alt=\"" + alt + "\"";
			}

			if (height == -1)
			{
				heighttext = null;
			}
			else
			{
				heighttext = " height=\"" + height + "\"";
			}

			if (width == -1)
			{
				widthtext = null;
			}
			else
			{
				widthtext = " width=\"" + width + "\"";
			}

			
			return string.Format("<img src=\"{0}\"{1}{2}{3}{4}>", imagesrc, bordersizetext, alttext, heighttext, widthtext);
		}

		public virtual string HWImage(string imagesrc, int bordersize, string alt, string alignment)
		{
			string bordersizetext;
			string alttext;
			string align;
			
			if (bordersize == -1) 
			{
				bordersizetext = null;
			}
			else
			{
				bordersizetext = " border=\"" + Convert.ToString(bordersize) + "\" ";
			}

			if (alt == string.Empty)
			{
				alttext = null;
			}
			else
			{
				alttext = " alt=\"" + alt + "\"";
			}

			if (alignment == string.Empty)
			{
				align = null;
			}
			else
			{
				align = " align=\"" + alignment + "\"";
			}
			
			return string.Format("<img src=\"{0}\"{1}{2}{3}>", imagesrc, bordersizetext, alttext, align);
		}

		#endregion
	}

	public class GDIShortcuts
	{
		/// <summary>
		/// Some shortcuts for GDI+
		/// </summary>
		public SizeF gdiMeasureString(string text, Font font)
		{
			StringFormat vbStringFormat = StringFormat.GenericDefault;
			SizeF size;
			Bitmap gphResult = new Bitmap(1, 1, PixelFormat.Format24bppRgb);
			Graphics gphGraphics = Graphics.FromImage(gphResult);

			gphGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

			vbStringFormat.FormatFlags = StringFormatFlags.LineLimit;
			size = gphGraphics.MeasureString(text, font, SizeF.Empty, vbStringFormat);

			return size;
		}

		public byte[] OutputErrorBitmap(String strErrorMessage)
		{
			Bitmap gphResult = new Bitmap(1, 1, PixelFormat.Format24bppRgb);
			Graphics gphGraphics = Graphics.FromImage(gphResult);
			Font fntFont = new Font("Tahoma", 9, FontStyle.Bold);
			SizeF textSize;
			MemoryStream streamMemory = new MemoryStream();
			
			// Draw our error message!
			textSize = gdiMeasureString(strErrorMessage, fntFont);
			gphResult = new Bitmap(Convert.ToInt32(textSize.Width), Convert.ToInt32(textSize.Height), PixelFormat.Format24bppRgb);
			gphGraphics = Graphics.FromImage(gphResult);
			gphGraphics.Clear(Color.FromArgb(182, 109, 109));
			gphGraphics.DrawRectangle(Pens.Maroon, new Rectangle(0, 0, Convert.ToInt32(textSize.Width) - 1, Convert.ToInt32(textSize.Height) - 1));
			gphGraphics.DrawString(strErrorMessage, fntFont, Brushes.Black, 2, 1);
			// Setup and send a response.
			gphResult.Save(streamMemory, ImageFormat.Png);
			byte[] buffer = streamMemory.ToArray();	
			// Clean up.
			streamMemory.Close();
			gphGraphics.Dispose();
			gphResult.Dispose();

			return buffer;
		}
	}
}
