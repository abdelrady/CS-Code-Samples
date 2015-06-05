using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Security.Cryptography;

namespace csharphome.feat
{
	/// <summary>
	/// This page allows for the user to see and change personal settings
	/// </summary>
	public class usrsettings : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Literal liLinks;
		protected System.Web.UI.WebControls.TextBox txtEdited;
		protected System.Web.UI.WebControls.Button btnUpdateDesc;
		protected System.Web.UI.WebControls.Button btnUpdateEmailAddr;
		protected System.Web.UI.WebControls.TextBox txtEmailAddr;
		protected System.Web.UI.WebControls.Button cmbUpdatePwd;
		protected System.Web.UI.WebControls.TextBox txtConfirmNewPwd;
		protected System.Web.UI.WebControls.TextBox txtNewPwd;
		protected System.Web.UI.WebControls.TextBox txtOldPwd;
		protected System.Web.UI.WebControls.Literal liMessage;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.Button btnUploadPic;
		protected System.Web.UI.HtmlControls.HtmlTextArea txtInfo;

		string strDatabase = "../home.mdb";		
		private csharphome.common.homepage f;

		public string usrId;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			f = new csharphome.common.homepage();
			liLinks.Text = f.loadLinksList(Request.MapPath(strDatabase), Convert.ToBoolean(Session["admin"]));

			usrId = Convert.ToString(Session["UserId"]);

			// We don't want this to be stored locally
			Response.Cache.SetCacheability(HttpCacheability.NoCache);

			// Check the user has logged in
			if (!Convert.ToBoolean(Session["LoggedIn"])) 
			{
				Response.Redirect("./login.aspx");
			} 
			else 
			{
				// Load some values...
				if (txtEdited.Text != "YES") 
				{
					txtEmailAddr.Text = Convert.ToString(Session["User_Email"]);
					txtInfo.Value = Convert.ToString(Session["User_Info"]).Replace("<br>", "\n").Replace("&#96;", "'");

					if (txtEdited.Text == "NO") txtEdited.Text = "YES";
				}
			}

		}

		#region Database Stuff
		private void UpdateUserPwd(string newPassword, string strUsername) 
		{
			Encoding en = Encoding.Default;
			csharphome.common.SymmCrypto h = new csharphome.common.SymmCrypto(common.SymmCrypto.SymmProvEnum.DES);

			f = new csharphome.common.homepage();
			f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE members SET pass = '" + 
				Convert.ToBase64String(en.GetBytes(h.Encrypting(newPassword, "pwd"))) + "' WHERE username = '" + strUsername + "'");
		}

		private void UpdateUserEmail(string newEmailAddr, string strUsername) 
		{
			f = new csharphome.common.homepage();
			f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE members SET mail = '" + newEmailAddr + "' WHERE username = '" + strUsername + "'");
			
			Session["User_Email"] = newEmailAddr;
		}

		private void UpdateUserInfo(string newInfo, string strUsername) 
		{
			f = new csharphome.common.homepage();
			f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE members SET usrdescription = '" + newInfo + "' WHERE username = '" + strUsername + "'");
			
			Session["User_Info"] = newInfo;
		}
#endregion
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

		private byte[] sendFile(byte[] source)
		{
			try
			{
				// Declare all of our variables and create the thumbnail!
				System.Drawing.Image gphImage = System.Drawing.Image.FromStream(new MemoryStream(source));
				MemoryStream objStreamMemory = new MemoryStream(); // I/O
				Size thumbSize = NewthumbSize(gphImage.Width, gphImage.Height);

				Bitmap imgOutput = new Bitmap(gphImage, thumbSize);
				//Dim gphGraphics As Graphics = Graphics.FromImage(imgOutput)

				// Send a response.
				Response.ContentType = "image/x-png";
				imgOutput.Save(objStreamMemory, System.Drawing.Imaging.ImageFormat.Png);
				byte[] buffer = objStreamMemory.ToArray();
				
				// Clean up.
				objStreamMemory.Close();
				gphImage.Dispose();
				gphImage = null;

				return buffer;
			}
			catch
			{
				return null;
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
			this.cmbUpdatePwd.Click += new System.EventHandler(this.cmbUpdatePwd_Click);
			this.btnUpdateEmailAddr.Click += new System.EventHandler(this.btnUpdateEmailAddr_Click);
			this.btnUpdateDesc.Click += new System.EventHandler(this.btnUpdateDesc_Click);
			this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void cmbUpdatePwd_Click(object sender, System.EventArgs e)
		{
			try
			{
				Encoding en = Encoding.Default;
				csharphome.common.SymmCrypto h = new csharphome.common.SymmCrypto(common.SymmCrypto.SymmProvEnum.DES);

				f = new csharphome.common.homepage();
				DataSet dbSet = f.loadDatabase(Server.MapPath(strDatabase), "SELECT * FROM members WHERE username ='" + Convert.ToString(Session["User_Name"]) + "'");
				bool boolSuccess = false;

				if (dbSet != null)
				{
					foreach (DataRow dbRow in dbSet.Tables[0].Rows)
					{
						if (h.Decrypting(en.GetString(Convert.FromBase64String(Convert.ToString(dbRow["pass"]))), "pwd") == txtOldPwd.Text)
						{       
							boolSuccess = true;    
						}
					}
				}

				dbSet.Dispose();
                
				if (boolSuccess)
				{            
					if (!(txtNewPwd.Text.Length > 7)) 
					{
						liMessage.Text = "Password too short";
						return;
					}
					if (!(txtConfirmNewPwd.Text.Length > 7)) 
					{
						liMessage.Text = "Password too short";
						return;
					}
					if (txtNewPwd.Text == txtConfirmNewPwd.Text)
					{
						UpdateUserPwd(txtNewPwd.Text, Convert.ToString(Session["User_Name"]));
						liMessage.Text = "Changed password successfully.";
						return;
					}
					else 
					{
						liMessage.Text = "Your new password don't match.";
					}
				}
                
				liMessage.Text = "Your [old] password does not match.";
			}
			catch
			{
				liMessage.Text = "There was an error while accessing the database.<br>Please try agian later.";
			}
		}

		private void btnUpdateEmailAddr_Click(object sender, System.EventArgs e)
		{
			try 
			{
				UpdateUserEmail(txtEmailAddr.Text, Convert.ToString(Session["User_Name"]));
				liMessage.Text = "Updated email information successfully."; }
			catch 
			{
				liMessage.Text = "There was an error while accessing the database.<br>Please try agian later.";
			}
		}

		private void btnUpdateDesc_Click(object sender, System.EventArgs e)
		{
			try 
			{
				UpdateUserInfo(txtInfo.Value.Replace("\n", "<br>").Replace("'", "&#039;"), Convert.ToString(Session["User_Name"]));
				liMessage.Text = "Updated user information."; }
			catch 
			{
				liMessage.Text = "There was an error while accessing the database.<br>Please try agian later.";
			}
		}

		private void btnUploadPic_Click(object sender, System.EventArgs e)
		{
			try
			{
				//Response.Write("Attempting to save to database...<br>");
				if (Convert.ToBoolean(Session["LoggedIn"]))
				{
					HttpFileCollection MyFileCollection = Request.Files;
					//Response.Write("Count=" + (MyFileCollection.Count - 1) + "<br>");
                    
					for (int i = 0; i <= MyFileCollection.Count - 1; i++)
					{
						/*Response.Write("i==" + i + "<br>");
						Response.Write("filename==" + MyFileCollection[i].FileName + "<br>");*/
						if (MyFileCollection[i].FileName != string.Empty)
						{
							// Save the file to the memory
							byte[] pic = new byte[MyFileCollection[i].ContentLength];
							Stream s = MyFileCollection[i].InputStream;
							s.Read(pic, 0, MyFileCollection[i].ContentLength);

							// Read the file into the byte array.
							s.Read(pic, 0, MyFileCollection[i].ContentLength);
							pic = sendFile(pic);

							FileStream v = new FileStream(Server.MapPath("../images/users/" + Convert.ToString(Session["UserID"]) + ".png"), FileMode.Create);
							v.Write(pic, 0, pic.Length);
							v.Close();

							//f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE members SET pic = '" + Convert.ToBase64String(pic) + "' WHERE usrid = " + Convert.ToString(Session["UserID"]));
							//f.SQLNonQuery(Server.MapPath(strDatabase), "UPDATE members SET pic = '" + "../images/users/" + Convert.ToString(Session["UserID"]) + ".png" + "' WHERE usrid = " + Convert.ToString(Session["UserID"]));
                                
							//Response.Write("\"" + MyFileCollection[i].FileName + "\"" + "(" + f.FormatKB(MyFileCollection[i].ContentLength) + ") was saved.<br>");
						}
					}
						//Response.Redirect("./browse.aspx?fldr=" + Convert.ToBase64String(en.GetBytes(strRequestDirectory)));
				}
				else
				{
					liMessage.Text = "<b><font color=\"#EE0000\">An user function has been attempted and has been prevented.</font></b>";
				}
			}
			catch (Exception ex)
			{
				liMessage.Text = "<b>And exception was thrown:</b><br>" + ex.Message;
			}
		}
	}
}
