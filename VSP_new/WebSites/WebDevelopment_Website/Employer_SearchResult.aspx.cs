using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class Employer_SearchResult : System.Web.UI.Page
{
    DataSet Seekers = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null )
        {
            Label1.Visible = false;
            ImageButton1.Visible = false;
        }
        
        //if (!Page.IsPostBack)
        {
            Label1.Text = "If you Want To accept Any Prefered Person For A job<br />You Have To Select (Click Accept This Person) Button";

            string country = Request.QueryString["Country"];
            string Category = Request.QueryString["Category"];
            string Keyword1 = "%" + ((Request.QueryString["KeyWord1"] != "") ? (Request.QueryString["KeyWord1"]) : "NULL") + "%";
            string Keyword2 = "%" + ((Request.QueryString["KeyWord2"] != "") ? (Request.QueryString["KeyWord2"]) : "NULL") + "%";
            string Keyword3 = "%" + ((Request.QueryString["KeyWord3"] != "") ? (Request.QueryString["KeyWord3"]) : "NULL") + "%";
            string Keyword4 = "%" + ((Request.QueryString["KeyWord4"] != "") ? (Request.QueryString["KeyWord4"]) : "NULL") + "%";
            AccessDataSource1.SelectCommand = "SELECT [ID],[FirstName], [LastName], [Address], [State], [Country], [Email_Address], [Experts], [Education_Category] FROM [Seekers] Where Country='" + country + "' or Education_Category='" + Category + "' or (Experts like '" + Keyword1 + "') or (Experts like '" + Keyword2 + "') or (Experts like '" + Keyword3 + "') or (Experts like '" + Keyword4 + "')";
            if (DetailsView1.Rows.Count< 2)
            {
                Label1.Visible = false;
                ImageButton1.Visible = false;
            }
            /*
            OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db\JobSeekersDB.mdb;Persist Security Info=False");
            cnn.Open();
            string cmd = "Select * from Seekers Where Country='" + country + "' or Education_Category='" + Category + "' or (Experts like '" + Keyword1 + "') or (Experts like '" + Keyword2 + "') or (Experts like '" + Keyword3 + "') or (Experts like '" + Keyword4 + "')";
            OleDbDataAdapter Adapter = new OleDbDataAdapter(cmd, cnn);

            Adapter.Fill(AccessDataSource1);
            //Response.Write( Adapter.Fill(Seekers).ToString());
            //DetailsView1.DataSource = AccessDataSource1;//Seekers.Tables[0];
            
            DetailsView1.AllowPaging = true;
            DetailsView1.DataBind();
            */
            /*foreach (DataRow dr in Seekers.Tables[0].Rows)
            {
                foreach (object dc in dr.ItemArray)
                {
                    Response.Write(dc.ToString()+" ");
                }
                Response.Write(Environment.NewLine);
            }*/
            //DetailsView1.DataMember = "JobSeekers";
        }
    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        //DetailsView1.=Seekers.Tables[0].Rows[e.NewPageIndex];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AcceptSeeker.aspx?id=" + DetailsView1.SelectedValue + "&JobId=" + Session["UserName"]);
    }
}/* "*/
