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

namespace My_First
{
	/// <summary>
	/// Summary description for WebForm2.
	/// </summary>
	public class WebForm2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		private double total;
	
		private void Page_Load(object sender, System.EventArgs e)
		{

			total=0;
			//Build some sample data into the datagrid
			DataTable dt = new DataTable("TestTable");

			DataColumn col0 = new DataColumn("Name");
			DataColumn col1 = new DataColumn("Points");

			dt.Columns.Add(col0);
			dt.Columns.Add(col1);

			object[] row0 = {"anu","1"};
			object[] row1 = {"kavi","2"};
			object[] row2 = {"manu","3"};
	

			dt.Rows.Add(row0);
			dt.Rows.Add(row1);
			dt.Rows.Add(row2);
	
			
			DataGrid1.DataSource = dt;
			DataGrid1.DataBind();
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
			this.DataGrid1.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGrid1_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemType==ListItemType.AlternatingItem ||e.Item.ItemType==ListItemType.Item)		
			{
				total+= double.Parse(e.Item.Cells[1].Text);
			}
			if(e.Item.ItemType==ListItemType.Footer)	
			{
                e.Item.Cells[0].Text="Total";
				e.Item.Cells[1].Text=total.ToString();
			}
		}
	}
}
