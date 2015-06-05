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

namespace csharphome.test
{
	/// <summary>
	/// Summary description for punnett.
	/// </summary>
	public class punnett : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Table punnetttable;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			TableRow tblRow;
			TableCell tblCell;            
            
			string ParentA = Request.QueryString["a"];
			string ParentB = Request.QueryString["b"];
            
			string[] ParentATraits = {ParentA.Substring(0, 1) + ParentA.Substring(2, 1),
										  ParentA.Substring(0, 1) + ParentA.Substring(3, 1),
										  ParentA.Substring(1, 1) + ParentA.Substring(2, 1),
										  ParentA.Substring(1, 1) + ParentA.Substring(3, 1)};

			string[] ParentBTraits = {ParentB.Substring(0, 1) + ParentB.Substring(2, 1),
										 ParentB.Substring(0, 1) + ParentB.Substring(3, 1),
										 ParentB.Substring(1, 1) + ParentB.Substring(2, 1),
										 ParentB.Substring(1, 1) + ParentB.Substring(3, 1)};

			tblRow = new TableRow();

			tblCell = new TableCell();
			tblCell.Text = "&nbsp;";
			tblRow.Cells.Add(tblCell);

			for (int i = 0; i <= 3; i++)
			{
				tblCell = new TableCell();
				tblCell.Text = ParentATraits[i];
				tblRow.Cells.Add(tblCell);
			}
			punnetttable.Rows.Add(tblRow);

			for (int i = 0; i <= 3; i++)
			{
				/*string[] ParentAResultingTraits = {ParentATraits[i].Substring(i, 1) + ParentBTraits[i].Substring(i, 1),
													  ParentATraits[i].Substring(i, 1) + ParentBTraits[i].Substring(i, 1),
											 ParentATraits[i].Substring(1, 1) + ParentBTraits[i].Substring(1, 1),
											 ParentATraits[i].Substring(1, 1) + ParentBTraits[i].Substring(1, 1)};*/

				tblRow = new TableRow();

				tblCell = new TableCell();
				tblCell.Text = ParentBTraits[i];
				tblRow.Cells.Add(tblCell);
				
				for (int b = 0; b <= 3; b++)
				{
					tblCell = new TableCell();
					//tblCell.Text = (ParentATraits[b].Substring(0, 1) == ParentATraits[b].Substring(0, 1).ToUpper() ? ParentATraits[b].Substring(0, 1) + ParentBTraits[b].Substring(0, 1): ParentBTraits[b].Substring(0, 1) + ParentATraits[b].Substring(0, 1));
						//(ParentBTraits[b].Substring(0, 1) == ParentBTraits[b].Substring(0, 1).ToUpper() ? ParentBTraits[b].Substring(0, 1) : ParentATraits[b].Substring(0, 1));
					tblCell.Text = ParentATraits[b].Substring(0, 1) + ParentBTraits[i].Substring(0, 1) +
						ParentATraits[b].Substring(1, 1) + ParentBTraits[i].Substring(1, 1);
					tblRow.Cells.Add(tblCell);				
				}
				punnetttable.Rows.Add(tblRow);
			}
			
			
		}

		#region OldStuuf
		/*TableRow tblRow;
			TableCell tblCell;

			char[] ParentTrait1 = "BbTT".ToCharArray();
			char[] ParentTrait2 = "bbTt".ToCharArray();

			string ParentTrait1Base = string.Empty;
			string[] ParentWorker;

			tblRow = new TableRow();

			tblCell = new TableCell();
			tblCell.Text = "&nbsp;";
			tblRow.Cells.Add(tblCell);
			for (int i = ParentTrait1.GetLowerBound(0); i <= ParentTrait1.GetUpperBound(0) - 2; i++)
			{
				tblCell = new TableCell();
				tblCell.Text = ParentTrait1[i].ToString() + ParentTrait1[(i <= ParentTrait1.GetUpperBound(0) ? 2 : 3)].ToString();
				ParentTrait1Base += tblCell.Text + "\t";
				tblRow.Cells.Add(tblCell);

				tblCell = new TableCell();
				tblCell.Text = ParentTrait1[i].ToString() + ParentTrait1[(i <= ParentTrait1.GetUpperBound(0) ? 3 : 2)].ToString();
				ParentTrait1Base += tblCell.Text + "\t";
				tblRow.Cells.Add(tblCell);
			}	
			punnetttable.Rows.Add(tblRow);

			ParentWorker = ParentTrait1Base.Split('\t');
		
			for (int i = ParentTrait2.GetLowerBound(0); i <= ParentTrait2.GetUpperBound(0) - 2; i++)
			{
				tblRow = new TableRow();

				tblCell = new TableCell();
				tblCell.Text = ParentTrait2[i].ToString() + ParentTrait2[(i <= ParentTrait1.GetUpperBound(0) ? 2 : 3)].ToString();
                tblRow.Cells.Add(tblCell);
				for (int a = ParentWorker.GetLowerBound(0); a <= ParentWorker.GetUpperBound(0) - 1; a++)
				{
					tblCell = new TableCell();
					//tblCell.Text = v[v.GetLowerBound(0)].ToString() + "!";
					tblCell.Text = ParentWorker[a].Substring(0, (ParentWorker[a].Length > 0 ? 1 : 0)) +
						ParentTrait2[i].ToString().Substring(0, (ParentTrait2[i].ToString().Length > 0 ? 1 : 0)) +
						ParentWorker[a].Substring((ParentWorker[a].Length > 0 ? 1 : 0), (ParentWorker[a].Length > 0 ? 1 : 0)) +
						ParentTrait2[i].ToString().Substring(0, (ParentTrait2[i].ToString().Length > 0 ? 1 : 0));
					tblRow.Cells.Add(tblCell);
				}
				punnetttable.Rows.Add(tblRow);

				tblRow = new TableRow();
				tblCell = new TableCell();
				tblCell.Text = ParentTrait2[i].ToString() + ParentTrait2[(i <= ParentTrait1.GetUpperBound(0) ? 3 : 2)].ToString();
				tblRow.Cells.Add(tblCell);
				for (int a = ParentWorker.GetLowerBound(0); a <= ParentWorker.GetUpperBound(0); a++)
				{
					tblCell = new TableCell();
					tblCell.Text = ParentWorker[a].Substring(0, (ParentWorker[a].Length > 0 ? 1 : 0)) +
						ParentTrait2[i].ToString().Substring(0, (ParentTrait2[i].ToString().Length > 0 ? 1 : 0));
					tblRow.Cells.Add(tblCell);
				}
				punnetttable.Rows.Add(tblRow);
			}	*/
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
