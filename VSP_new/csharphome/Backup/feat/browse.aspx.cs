using System;
using System.IO;
using System.Text;
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

namespace csharphome.feat
{
	/// <summary>
	/// This page allows users to browse for files, this uses the thumbnail maker to
	/// display thumbnails of pictures and provides ID3 tag info for MP3 files.
	/// </summary>
	public class browse : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnUpload;
		protected System.Web.UI.WebControls.Button btnNewFolder;
		protected System.Web.UI.WebControls.TextBox txtNewFldName;
		protected System.Web.UI.WebControls.Table tableFiles;
		protected System.Web.UI.WebControls.Table tableFolders;
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.Literal liBrowse;
		protected System.Web.UI.WebControls.TextBox txtBrowseTo;
		protected System.Web.UI.WebControls.Button btnBrowseTo;

		const string strDefaultIconDirectory = "../images/fldview/";
		const string strDatabase = "../home.mdb";
		const string strDefaultDirectory = "/pub/";
		const string strFileIcons = "../fileicons.txt";
		const string strFileDesc = "../filedesc.txt";
		const string strFilePictures = "../filepics.txt";
		const string strFileText = "../filetext.txt";
		private csharphome.common.homepage f;
		private Encoding en = Encoding.Default;
		bool isAdmin;

		public int intDisplay = 0;
		public int intOffset = 0;
		public string strRawRequestDirectory;		
		public string strRequestDirectory;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			isAdmin = Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]);

			try
			{
				/* Check to see if the user requested updates to something first
				 * so that they don't get old data */
				NameValueCollection frmWeb = Request.Form;
				if (frmWeb != null) 
				{
					// First check if an administrator tried to do something
					if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
					{
						switch (frmWeb["__EVENTTARGET"])
						{
							case "renamefile":
								/* rn string format
								 * orginal filename+path{newline}orginal path{newline}
								 * new filename */
								string[] rn = Convert.ToString(frmWeb["__EVENTARGUMENT"]).Split('\n');
								File.Move(Server.MapPath(en.GetString(Convert.FromBase64String(rn[0]))), Server.MapPath(en.GetString(Convert.FromBase64String(rn[1])) + rn[2]));
								break;
							case "deletefile":
								File.Delete(Server.MapPath(en.GetString(Convert.FromBase64String(Convert.ToString(frmWeb["__EVENTARGUMENT"])))));
								break;
							case "movefile":
								/* the mv string format
								 * orginal filename+path{newline}new (filename)+path */
								string[] mv = Convert.ToString(frmWeb["__EVENTARGUMENT"]).Split('\n');
								File.Move(Server.MapPath(en.GetString(Convert.FromBase64String(mv[0]))), Server.MapPath(mv[1]));
								break;
							case "copyfile":
								/* the cp string format
								 * orginal filename+path{newline}new (filename)+path */
								string[] cp = Convert.ToString(frmWeb["__EVENTARGUMENT"]).Split('\n');
								File.Copy(Server.MapPath(en.GetString(Convert.FromBase64String(cp[0]))), Server.MapPath(cp[1]));
								break;
							case "deletefolder":								
								Directory.Delete(Server.MapPath(en.GetString(Convert.FromBase64String(Convert.ToString(frmWeb["__EVENTARGUMENT"])))), true);
								break;
							case "renamefolder":
								/* rf string format
								 * orginal path{newline}orginal path{newline}
								 * new filename */
								string[] rf = Convert.ToString(frmWeb["__EVENTARGUMENT"]).Split('\n');
								Directory.Move(Server.MapPath(en.GetString(Convert.FromBase64String(rf[0]))), Server.MapPath(en.GetString(Convert.FromBase64String(rf[1])) + rf[2]));
								break;
						}
					}
					else
					{
						liBrowse.Text = "<b><font color=\"#EE0000\">An administrator function has been attempted and has been prevented.</font></b>";
					}
				}
                
				// Declare our variables!
				object[] arrDirectorys;
				object[] arrFiles;
				TableCell tCell; 
				TableRow tRow;

				/* Now read our requests. First check if there is a specified location
				 * at all, if so decode the Base64 encoding back to plain text. */
				strRequestDirectory = (Request.QueryString["fldr"] == null ? strDefaultDirectory : fromB64());
				strRequestDirectory = strRequestDirectory.Replace("\\", "/");
				
				strRawRequestDirectory = (Request.QueryString["fldr"] == null ? Convert.ToBase64String(en.GetBytes(strDefaultDirectory)) : Request.QueryString["fldr"]);
				
				// Add to our list the directorys.
				arrDirectorys = ReadDirectorys(strRequestDirectory);

				// Add to our list the files.
				arrFiles = ReadDirectory(strRequestDirectory);
                
				/* Check for an offset and how many the items per-page the user wants
				 * to see If the values are null, set the defaults */
				intDisplay = (Request.QueryString["display"] == null ||
					Convert.ToInt32(Request.QueryString["display"]) == 0 ? 35 : Convert.ToInt32(Request.QueryString["display"]));

				intOffset = (Convert.ToInt32(Request.QueryString["offset"]) > (arrFiles.GetUpperBound(0) == -1 ? 0 : arrFiles.GetUpperBound(0)) ? Convert.ToInt32(Request.QueryString["offset"]) - intDisplay :
					(Request.QueryString["offset"] == null ||
					Convert.ToInt32(Request.QueryString["offset"]) < 0 ? 0 : Convert.ToInt32(Request.QueryString["offset"])));
                
				// Setup a little quick launch (for going back and forward in directorys)
				string[] strSplitDirectory;
				string strTemp;
				strSplitDirectory = strRequestDirectory.Split('/');
				liBrowse.Text = "<b>Skip To:</b> ";

				// Here set the "virtual" root of the folder browser
				strTemp = "/";

				for (int i = strSplitDirectory.GetLowerBound(0) + 1; i <= strSplitDirectory.GetUpperBound(0) - 1; i++)
				{
					strTemp += strSplitDirectory[i] + "/";
					liBrowse.Text += f.HWHyperLink("browse.aspx?fldr=" + Convert.ToBase64String(en.GetBytes(strTemp)) + "&offset=0&display=" + intDisplay, strTemp, "Browse to: " + strTemp) + "&nbsp;&nbsp;";
				}

				// Setup our listing, this shows the directorys.
				for (int i = arrDirectorys.GetLowerBound(0); i <= arrDirectorys.GetUpperBound(0); i++)
				{
					tRow = new TableRow();
					tCell = new TableCell();
					tCell.Text = f.HWImage(strDefaultIconDirectory + "folder.gif", 0, "Folder") +
						f.HWHyperLink("browse.aspx?fldr=" +
						Convert.ToBase64String(en.GetBytes(Convert.ToString(arrDirectorys[i]))) + "&offset=0&display=" +
						intDisplay, Convert.ToString(arrDirectorys[i]), "Browse to: " +
						arrDirectorys[i]) + "&nbsp;" +
						(isAdmin == true ? f.HWHyperLink("javascript:__renameFolder('" +
						Convert.ToBase64String(en.GetBytes(Convert.ToString(arrDirectorys[i]))) + "', '" +
						Convert.ToBase64String(en.GetBytes(strRequestDirectory)) + "', '" +
						f.SplitString(Convert.ToString(arrDirectorys[i]), '/', -3) + "')", 
						f.HWImage("../images/icons/edit.gif", 0, "Rename Directory")) +
						f.HWHyperLink("javascript:__deleteFolder('" +
						Convert.ToBase64String(en.GetBytes(Convert.ToString(arrDirectorys[i]))) + "', '" +
						f.SplitString(Convert.ToString(arrDirectorys[i]), '/', -3) + "')",
						f.HWImage("../images/icons/delete.gif", 0, "Delete Folder")): null);
					tCell.HorizontalAlign = HorizontalAlign.Left;
					tCell.Style["Width"] = "100%";
					tRow.Cells.Add(tCell);
					tableFolders.Rows.Add(tRow);
				}

				// Setup our listing, agian this time showing the files.
				string[] strFile;
				int intThumbs = 0;
				int intAmountDisplayed = 0;
				int intFolderSize = 0;
				tRow = new TableRow(); // This is used only once.
				
				if (Convert.ToBoolean(arrFiles.GetUpperBound(0) + 1))
				{
					for (int i = intOffset; i <= arrFiles.GetUpperBound(0); i++)
					{
						intAmountDisplayed += 1;
						if (intAmountDisplayed == intDisplay + 1)
						{
							break;
						}

						/*Response.Write(intOffset + "&nbsp;&nbsp");
						Response.Write((i + 1) + "<br>");*/

						strFile = Convert.ToString(arrFiles[i]).Split('\t');
						intThumbs += 1;

						// Check to see if its really a shortcut
						string strDefaultFilename;
						if (strFile[0].ToLower().IndexOf("browse.aspx") == 0)
						{
							strDefaultFilename = strFile[0];
						}
						else
						{
							if (Convert.ToBoolean(Session["LoggedIn"]))
							{
								strDefaultFilename = strFile[0]; //"download.aspx?url=" + Convert.ToBase64String(en.GetBytes(strFile[0]));
							}
							else
							{
								strDefaultFilename = "./login.aspx";
							}
						}

						if (intThumbs == 5)
						{
							// Here we change some variables and start a new row.
							intThumbs = 0;

							intFolderSize += Convert.ToInt32(strFile[2]);

							tCell = new TableCell();
							tCell.Text = f.HWHyperLink(strDefaultFilename,
								f.HWImage(CheckThumbnailType(strFile[0], strFile[1]),
								1, f.SplitString(strFile[1], '/', -2) + "\nSize: " +
								f.FormatKB(Convert.ToDouble(strFile[2])) + "\nType: " +
								FileTypeDesc(strFile[1]) + strFile[3])) + "<br>" +
								f.SplitString(strFile[1], '/', -2) + "<br>" +
								(isAdmin == true ? CreateAdminFunctions(strFile[0], strFile[1]) : null);
							tCell.HorizontalAlign = HorizontalAlign.Center;                    
							tCell.Style["Width"] = "20%";
							tRow.Cells.Add(tCell);
							tableFiles.Rows.Add(tRow);
							tRow = new TableRow();
						}
						else
						{
							// If the counter hasn't reached the max, then simple add another cell.
							intFolderSize += Convert.ToInt32(strFile[2]);
							tCell = new TableCell();
							//tCell.Text = f.HWHyperLink(strDefaultFilename, f.HWImage(CheckThumbnailType(strFile[0], strFile[1]), 1, f.SplitString(strFile[1], '/', -2) + "\nSize: " + f.FormatKB(Convert.ToDouble(strFile[2])) + "\nType: " + FileTypeDesc(strFile[1]) + strFile[3])) + "<br>" + f.SplitString(strFile[1], '/', -2);
							tCell.Text = f.HWHyperLink(strDefaultFilename,
								f.HWImage(CheckThumbnailType(strFile[0], strFile[1]),
								1, f.SplitString(strFile[1], '/', -2) + "\nSize: " +
								f.FormatKB(Convert.ToDouble(strFile[2])) + "\nType: " +
								FileTypeDesc(strFile[1]) + strFile[3])) + "<br>" +
								f.SplitString(strFile[1], '/', -2) + "<br>" +
								(isAdmin == true ? CreateAdminFunctions(strFile[0], strFile[1]) : null);
							tCell.HorizontalAlign = HorizontalAlign.Center;
							tCell.Style["Width"] = "20%";
							tRow.Cells.Add(tCell);
						}
						
						tableFiles.Rows.Add(tRow); // Add anything left over
					}

					// Show our file information at the top of the screen.
					liBrowse.Text += "<br>\n";
					liBrowse.Text += "<b>Total Files:</b> " + (arrFiles.GetUpperBound(0) + 1) + " <b>Folder Size:</b> " + f.FormatKB(intFolderSize) + "</font>";
				}
			}
			catch (Exception ex)
			{
				liBrowse.Text = "<b>An exception was thrown:</b><br>" + ex.Message.Replace(Server.MapPath("/"), "");
			}
		}
		
		private string fromB64()
		{
			if (Request.QueryString["fldr"] != null)
			{
				return en.GetString(Convert.FromBase64String(Request.QueryString["fldr"]));
			}
			return null;

		}

		private string CreateAdminFunctions(string strFile0, string strFile1)
		{
			string[] istext = strFile1.Split('.');
			return f.HWHyperLink("javascript:__renameFile('" + 
				Convert.ToBase64String(en.GetBytes(strFile0)) + "', '" +
				Convert.ToBase64String(en.GetBytes(strRequestDirectory)) + "', '" +
				f.SplitString(strFile1, '/', -2) + "')",
				f.HWImage("../images/icons/edit.gif", 0, "Rename File")) +
				f.HWHyperLink("javascript:__confirmFileDeletion('" +
				Convert.ToBase64String(en.GetBytes((strFile1.IndexOf("sht") > 0 ? strRequestDirectory + strFile1 : strFile0))) + "', '" +
				f.SplitString(strFile1, '/', -2) + "')",
				f.HWImage("../images/icons/delete.gif", 0, "Delete File")) +
				f.HWHyperLink("javascript:__copyFile('" +
				Convert.ToBase64String(en.GetBytes(strFile0)) + "', '" +
				strRequestDirectory + strFile1 + "')",
				f.HWImage("../images/icons/copy.gif", 0, "Copy File")) +
				f.HWHyperLink("javascript:__moveFile('" +
				Convert.ToBase64String(en.GetBytes(strFile0)) + "', '" +
				strRequestDirectory + strFile1 + "')",
				f.HWImage("../images/icons/move.gif", 0, "Move File")) +
				IsTextFile(strFile0);
		}

		#region I/O System
		private object[] ReadDirectorys(string strPath)
		{
			DirectoryInfo diDirectorys;
			ArrayList arrDirectorys = new ArrayList();

			diDirectorys = new DirectoryInfo(Server.MapPath(strPath));

			foreach (DirectoryInfo diDirectory in diDirectorys.GetDirectories())
			{
				switch (diDirectory.Attributes)
				{
					case FileAttributes.Compressed | (FileAttributes.Hidden | FileAttributes.Directory):
						break;
					case FileAttributes.Hidden | FileAttributes.Directory:
						break;
					case FileAttributes.Compressed | (FileAttributes.System | FileAttributes.Directory):
						break;
					case FileAttributes.System | FileAttributes.Directory:
						break;
					case FileAttributes.Compressed | (FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory):
						break;
					case FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory:
						break;
					default:
						arrDirectorys.Add(strPath + diDirectory.Name + "/");
						break;
				}
			}

			diDirectorys = null;
			return arrDirectorys.ToArray();
		}

		private object[] ReadDirectory(string strPath)
		{
			DirectoryInfo diDirectorys;
			ArrayList arrDirectory = new ArrayList();

			/* File format:
			 * link{tab}filename{tab}size{tab}otherinfo */

			diDirectorys = new DirectoryInfo(Server.MapPath(strPath));
			foreach (FileInfo diFiles in diDirectorys.GetFiles("*.*"))
			{
				switch (diFiles.Attributes)
				{
					case FileAttributes.Compressed | FileAttributes.Hidden:
						break;
					case FileAttributes.Compressed | FileAttributes.System:
						break;
					case FileAttributes.Compressed | (FileAttributes.System | FileAttributes.Hidden):
						break;
					case FileAttributes.Hidden:
						break;
					case FileAttributes.System:
						break;
					case FileAttributes.System | FileAttributes.Hidden:
						break;
					default:
						if (f.SplitString(diFiles.Name, '.', -2).ToLower() == "sht")
						{
							// If we hit on a shortcut
							StreamReader objReader;
							string strShortcut;
							objReader = new StreamReader(Server.MapPath(strPath + diFiles.Name));
							strShortcut = objReader.ReadToEnd();
							objReader.Close();
							arrDirectory.Add("browse.aspx?fldr=" + Convert.ToBase64String(en.GetBytes(strShortcut)) + "&offset=0&display=" + intDisplay + '\t' +
								diFiles.Name + '\t' +
								diFiles.Length + '\t' +
								"\nLinks to: " + strShortcut);
						}
							/* ElseIf LCase(SplitString(diFiles.Name, ".", -2)) = "mp3" Then
								Dim objID3Reader As New clsID3Reader(Server.MapPath(strPath & diFiles.Name))

								arrDirectory.Add(strPath & diFiles.Name & "<bdata>" & _
								diFiles.Name & "<bdata>" & _
								diFiles.Length & "<bdata>" & _
								vbCrLf & vbCrLf & "Title: " & objID3Reader.Songname & _
								vbCrLf & "Artist: " & objID3Reader.Artist & _
								vbCrLf & "Bitrate:" & objID3Reader.BitRate & " kbps (VBR: " & objID3Reader.VBR & ")" & _
								vbCrLf & "Length: " & objID3Reader.Duration) */
						else
						{
							arrDirectory.Add(strPath + diFiles.Name + '\t' +
								diFiles.Name + '\t' +
								diFiles.Length + '\t');
						}
						break;
				}
			}

			diDirectorys = null;
			return arrDirectory.ToArray();
		}
		#endregion
		#region Private functions
		private string IsTextFile(string filename)
		{
			// Get the file extenstion
			string[] strTemp = filename.Split('.');
			string v = strTemp[strTemp.GetUpperBound(0)].ToLower();
			string unknownext = string.Empty;

			StreamReader m = new StreamReader(Server.MapPath(strFileText));
			string[] metadata = m.ReadToEnd().Split('\n');
			m.Close();

			for (int i = metadata.GetLowerBound(0); i <= metadata.GetUpperBound(0); i++)
			{
				if (metadata[i].StartsWith(";"))
				{
					// Get the possible file types in an array
					string[] fileext = metadata[i].Replace(";", string.Empty).Trim().Split(',');
					for (int a = fileext.GetLowerBound(0); a <= fileext.GetUpperBound(0); a++)
					{
						if (v == fileext[a])
						{
							return f.HWHyperLink("../manage/editors/text.aspx?file=" +
								Convert.ToBase64String(en.GetBytes(filename)),
								f.HWImage("../images/icons/texteditor.gif",
								0, "Edit Text File"));
						}
					}
				}
			}

			return null;
		}

		private string FileTypeDesc(string strBaseFilename)
		{
			// Get the file extenstion
			string[] strTemp = strBaseFilename.Split('.');
			string v = strTemp[strTemp.GetUpperBound(0)].ToLower();
			string unknownext = string.Empty;

			StreamReader m = new StreamReader(Server.MapPath(strFileDesc));
			string[] metadata = m.ReadToEnd().Split('\n');
			m.Close();

			for (int i = metadata.GetLowerBound(0); i <= metadata.GetUpperBound(0); i++)
			{
				if (metadata[i].StartsWith(";"))
				{
					// Get the possible file types in an array
					string[] fileext = metadata[i].Replace(";", string.Empty).Trim().Split(',');
					for (int a = fileext.GetLowerBound(0); a <= fileext.GetUpperBound(0); a++)
					{
						if (v == fileext[a])
						{
							return metadata[i + 1].Trim();
						}
						else if (fileext[a] == "?")
						{
							unknownext = metadata[i + 1].Trim();
						}
					}
				}
			}

			return unknownext;
		}

		private string FileTypeIcon(string strFilename)
		{
			// Get the file extenstion
			string[] strTemp = strFilename.Split('.');
			string v = strTemp[strTemp.GetUpperBound(0)].ToLower();
			string unknownext = string.Empty;

			StreamReader m = new StreamReader(Server.MapPath(strFileIcons));
			string[] metadata = m.ReadToEnd().Split('\n');
			m.Close();

			for (int i = metadata.GetLowerBound(0); i <= metadata.GetUpperBound(0); i++)
			{
				if (metadata[i].StartsWith(";"))
				{
					// Get the possible file types in an array
					string[] fileext = metadata[i].Replace(";", string.Empty).Trim().Split(',');
					for (int a = fileext.GetLowerBound(0); a <= fileext.GetUpperBound(0); a++)
					{
						//Response.Write(a + ", ");
						//Response.Write(fileext.GetLowerBound(0) + ", " + fileext.GetUpperBound(0) + ", " + metadata[i].Replace(";", string.Empty) + "<br>");
						if (v == fileext[a])
						{
							return metadata[i + 1].Trim();
						}
						else if (fileext[a] == "?")
						{
							unknownext = metadata[i + 1].Trim();
						}
					}
					//Response.Write("<br>");
				}
			}

			return unknownext;
		}

		private string CheckThumbnailType(string strFilename, string strBaseFilename)
		{
			string[] strTemp = strBaseFilename.Split('.');
			string v = strTemp[strTemp.GetUpperBound(0)].ToLower();

			StreamReader m = new StreamReader(Server.MapPath(strFilePictures));
			string[] metadata = m.ReadToEnd().Split('\n');
			m.Close();

			for (int i = metadata.GetLowerBound(0); i <= metadata.GetUpperBound(0); i++)
			{
				if (metadata[i].StartsWith(";"))
				{
					// Get the possible file types in an array
					string[] fileext = metadata[i].Replace(";", string.Empty).Trim().Split(',');
					for (int a = fileext.GetLowerBound(0); a <= fileext.GetUpperBound(0); a++)
					{
						if (v == fileext[a])
						{
							return "./imageengine.aspx?src=" + Convert.ToBase64String(en.GetBytes(strFilename));
						}						
					}
				}
			}

			return FileTypeIcon(strBaseFilename);
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
			this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			this.btnBrowseTo.Click += new System.EventHandler(this.btnBrowseTo_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnNewFolder_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					Directory.CreateDirectory(Server.MapPath(strRequestDirectory) + txtNewFldName.Text);
					Response.Redirect("./browse.aspx?fldr=" + Convert.ToBase64String(en.GetBytes(strRequestDirectory)));
				}
				else
				{
					liBrowse.Text = "An administrator function has been attempted. This is not allowed.";
				}
			}
			catch (Exception ex)
			{
				liBrowse.Text = "<b>And exception was thrown:</b><br>" + ex.Message;
			}
		}

		private void btnUpload_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
				{
					if (Directory.Exists(Server.MapPath(strRequestDirectory)))
					{
						string TempFileName;
						HttpFileCollection MyFileCollection = Request.Files;
                        
						for (int i = 0; i <= MyFileCollection.Count - 1; i++)
						{
							if (MyFileCollection[i].FileName != string.Empty)
							{
								// Create a new file name.
								TempFileName = Path.GetFileName(MyFileCollection[i].FileName);
								// Save the file.
								MyFileCollection[i].SaveAs(Server.MapPath(strRequestDirectory) + TempFileName);
								Response.Write("\"" + MyFileCollection[i].FileName + "\" was saved.<br>");
							}
						}
						//Response.Write("Click " + f.HWHyperLink("./browse.aspx?fldr=" + Convert.ToBase64String(en.GetBytes(strRequestDirectory)), "here") + " to see an updated page.");
						Response.Redirect("./browse.aspx?fldr=" + Convert.ToBase64String(en.GetBytes(strRequestDirectory)));
					}
				}
				else
				{
					liBrowse.Text = "<b><font color=\"#EE0000\">An administrator function has been attempted and has been prevented.</font></b>";
				}
			}
			catch (Exception ex)
			{
				liBrowse.Text = "<b>And exception was thrown:</b><br>" + ex.Message;
			}
		}

		private void btnBrowseTo_Click(object sender, System.EventArgs e)
		{
			if (Convert.ToBoolean(Session["LoggedIn"]) && Convert.ToBoolean(Session["admin"]))
			{
				Response.Redirect("./browse.aspx?fldr=" + Convert.ToBase64String(en.GetBytes(txtBrowseTo.Text)));
			}
		}
	}
}
