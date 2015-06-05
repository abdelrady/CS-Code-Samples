using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Diagnostics;
using System.Threading;

namespace GameKiller
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class GKForm : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Input;
		protected System.Web.UI.WebControls.Button Add;
		protected System.Web.UI.WebControls.Button Display;
		protected System.Web.UI.WebControls.Button Kill;
		protected System.Web.UI.WebControls.Button Restart;
		protected System.Web.UI.HtmlControls.HtmlGenericControl ErrMsg;
		protected System.Web.UI.WebControls.Button Command;
		protected System.Web.UI.WebControls.Button Filter1;
		protected System.Web.UI.WebControls.Button Filter2;
		protected System.Web.UI.HtmlControls.HtmlTable All;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			ErrMsg.InnerText = "";
			if(IsPostBack==false) Display_Click(null, null);
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
			this.Display.Click += new System.EventHandler(this.Display_Click);
			this.Filter1.Click += new System.EventHandler(this.Filter1_Click);
			this.Filter2.Click += new System.EventHandler(this.Filter2_Click);
			this.Add.Click += new System.EventHandler(this.Add_Click);
			this.Kill.Click += new System.EventHandler(this.Kill_Click);
			this.Restart.Click += new System.EventHandler(this.Restart_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Display_List(string sFilter, bool bFilter)
		{
			try
			{
				for(int i = All.Rows.Count-1;i>=1;i--)
					All.Rows.Remove(All.Rows[i]);
				HtmlTableRow oRow = null;
				HtmlTableCell oCell = null;
				DateTime oNow = DateTime.Now;
				Process[] pList = Process.GetProcesses();
				for(int i=0;i<pList.Length;i++)
				{
					oRow = new HtmlTableRow();
					oCell = new HtmlTableCell();
					oRow.Cells.Add(oCell);
					oCell = new HtmlTableCell();
					oCell.InnerText = pList[i].Id.ToString();
					oRow.Cells.Add(oCell);
					oCell = new HtmlTableCell();
					oCell.InnerText = ((oNow.Ticks-pList[i].StartTime.Ticks)/(10000000*60)).ToString();
					oRow.Cells.Add(oCell);
					oCell = new HtmlTableCell();
					try
					{
						oCell.InnerText = pList[i].MainModule.FileName;
					}
					catch(Exception)
					{
						oCell.InnerText = pList[i].ProcessName;
					}
					bool bInclude = (sFilter==null||sFilter=="")?true:(oCell.InnerText.ToLower().IndexOf(sFilter)>=0);
					oRow.Cells.Add(oCell);
					oCell = new HtmlTableCell();
					oRow.Cells.Add(oCell);
					if(bInclude&&bFilter||bInclude==false&&bFilter==false) All.Rows.Add(oRow);
				}
			}
			catch(Exception oBug)
			{
				ErrMsg.InnerText = oBug.Message;
			}
		}

		private void Display_Click(object sender, System.EventArgs e)
		{
			Input.Text = "";
			Display_List(null,true);
		}

		private void Add_Click(object sender, System.EventArgs e)
		{
			try
			{
				string[] pInput = Input.Text.Trim().Split(";".ToCharArray());
				for(int i=0;i<pInput.Length;i++)
				{
					string[] pItem = pInput[i].Split(",".ToCharArray());
					if(pItem.Length>=2)
					{
						string sGame = pItem[0].Trim ().ToLower();
						int nTime = Convert.ToInt32(pItem[1]);
						int nDelay = (pItem.Length==2)?0:Convert.ToInt32(pItem[2]);
						Global.Add(sGame,nTime,nDelay);
					}	
				}
				Display_Click(null, null);
			}
			catch(Exception oBug)
			{
				ErrMsg.InnerText = oBug.Message;
			}
		}

		private void Kill_Click(object sender, System.EventArgs e)
		{
			try
			{
				Global.Kill(Convert.ToInt32(Input.Text));
				Display_Click(null, null);
			}
			catch(Exception oBug)
			{
				ErrMsg.InnerText = oBug.Message;
			}
		}

		private void Restart_Click(object sender, System.EventArgs e)
		{
			try
			{
				Global.Restart();
				Display_Click(null, null);
			}
			catch(Exception oBug)
			{
				ErrMsg.InnerText = oBug.Message;
			}	
		}

		private void Filter1_Click(object sender, System.EventArgs e)
		{
			Display_List(Input.Text.Trim().ToLower(),true);
		}

		private void Filter2_Click(object sender, System.EventArgs e)
		{
			Display_List(Input.Text.Trim().ToLower(),false);
		}
	}
}
