using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
/********************************************************************
	author:		Quartz (quartz@interviewinfo.net) Please keep the comments if you distribute
	created:	18:9:2004   5:55
	created:	11/11/2005
	file base:	EditData.aspx
	purpose:	edit/update a records in the table
*********************************************************************/
namespace AdminLite
{
	public partial class Editdata : System.Web.UI.Page
	{
		protected int NumberOfControls
		{
			get{return (int)ViewState["NumControls"];}
			set{ViewState["NumControls"] = 10;}
		}
		protected void Page_Load(object sender, System.EventArgs e)
		{
//			if ((string)Session["Admin"] == "true")
//			{
//			}
//			else
//				Response.Redirect("index.aspx");

				
			if (IsPostBack) 
			{
					
			}   
			ShowData();
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
		
		private void InitializeComponent()
		{    

		}
		#endregion

		private void ShowData()
		{
			// Put user code to initialize the page here
			string s="";
			
			SqlDataReader myReader;
			int i =0, j=0,k=0;
				
			i = Convert.ToInt32(Request.QueryString["id"]); 
			s = "SELECT * FROM " + Session["tName"].ToString() + " where " + Session["FirstKey"] + " =" + i ; 

			clsDataAccess myclass = new clsDataAccess();
			myclass.openConnection();
			myReader = myclass.getData(s);

			while (myReader.Read()) 
			{
				for(j=-1; j<myReader.FieldCount;j++) 
				{
					
					TableRow r = new TableRow();
					for (k=0; k<4; k++) 
					{
						TableCell c = new TableCell();
						 
						if (j==-1)
						{
							if (k == 0) 
							{
								c.Width = 15;
								c.Controls.Add(new LiteralControl("<b>Sno.</b>"));
							}
							if (k == 1) 
							{
								c.Width = 50;
								c.Controls.Add(new LiteralControl("<b>Column</b>"));
							}
							if (k == 2) 
							{
								c.Width = 50;
								c.Controls.Add(new LiteralControl("<b>Value</b>"));
							}
							if (k == 3) 
							{
								c.Width = 35;
								c.Controls.Add(new LiteralControl("<b>&nbsp;Datatype</b>"));
							}
						}
						if(j>-1) 
						{
							TextBox TextBox1 = new TextBox();
							TextBox1.ID = "Text" + j;
							TextBox1.Text =  myReader.GetValue(j).ToString();

							if (myReader.GetName(j).ToString()== Session["FirstKey"].ToString() )
							{
								TextBox1.ReadOnly = true;
								TextBox1.BackColor = Color.GhostWhite ; 
							}

							TextBox1.Width = 200;
					
									 
							if (k == 0) 
							{
								c.Width = 15;
								c.Controls.Add(new LiteralControl((j+1).ToString()));
							}
							if (k == 1) 
							{
								c.Width = 50;
								if (myReader.GetName(j).ToString()==Session["FirstKey"].ToString()  )
									c.Controls.Add(new LiteralControl("<i>&nbsp;"  + myReader.GetName(j).ToString() + "</i>"));
								else
									c.Controls.Add(new LiteralControl("&nbsp;" + myReader.GetName(j).ToString() + "&nbsp;" ));
							}
							if (k == 2) 
							{
								c.Width = 300;
								c.Controls.Add(TextBox1);  
							}
							if (k == 3) 
							{
								c.Width = 35;
								c.Controls.Add(new LiteralControl("&nbsp;" + myReader.GetFieldType(j).ToString() + "&nbsp;" ));
							}
						}
						r.Cells.Add(c);
					}
					Table2.Rows.Add(r);
				}
			}		
			myReader.Close();
			myclass.closeConnection(); 
		
		}
		protected void btnSubmit_Click(object sender, System.EventArgs e)
		{
			string tname;
			tname = Session["tName"].ToString();
			try
			{
				string s;
				SqlDataAdapter myDA = new SqlDataAdapter();
				DataSet myDataSet = new DataSet(); 
				int i =0;//, j=0
			
				i = Convert.ToInt32(Request.QueryString["id"]); 
				s = "SELECT * FROM " + Session["tName"].ToString() + " where " + Session["FirstKey"] + " =" + i ; 
				clsDataAccess myclass = new clsDataAccess();
				myclass.openConnection();
				myDA = myclass.getDataforUpdate(s); 
			
				SqlCommandBuilder mySCB = new SqlCommandBuilder(myDA); 
				myDA.Fill(myDataSet,tname); 
				DataTable myTable;
				myTable =myDataSet.Tables[0] ;
				
				for (i =1;i < Request.Form.Count-2;i++)
				{
					myTable.Rows[0][i] = Request.Form[i+1].ToString();
				} 
				myDA.Update(myDataSet,tname); 
				myDataSet.AcceptChanges();
						
				lblstatus.Text = " Updated Successfully !!!"; 
 
			}
			catch(Exception f)
			{
				lblstatus.Text = f.Message + " Error while Updating";
				lblstatus.Font.Bold = true; 
				lblstatus.ForeColor = Color.Red; 
			}
			finally
			{
						
						
			}
		}

		protected void btnBack_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("db.aspx?table=" + Session["tName"]);   
		}

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("db.aspx?table=" + Session["tName"]);   
		}

		protected void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Deletedata.aspx?id=" + Convert.ToInt32(Request.QueryString["id"]));
		}

	}
}
