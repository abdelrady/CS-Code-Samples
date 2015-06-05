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

public partial class Inbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
       Label2.Text = "<script type='text/javascript'>document.images.HeaderImg.src='Images/nav_empunauth_1_1.png';</script>";
       
        //DetailsView DetailsView1 = DetailsView1;
        AccessDataSource1.SelectCommand = "SELECT [ID],[FirstName], [LastName], [CompanyName], [City], [Country], [Email], [Website] FROM [Employers] where ID='"+Request.QueryString["EID"]+"'";
        AccessDataSource1.DataBind();
        //DetailsView1.DataSourceID = "AccessDataSource1";
        //Label1.Text = "<script langauge='text/javascript' >alert(" + DetailsView1.Rows.Count.ToString() + ")</script>";*/
        Label1.Text = "<br /><span style='font-size: 12pt; color: Green'>This Message from Employer (" + DetailsView1.Rows[0].Cells[1].Text + " " + DetailsView1.Rows[1].Cells[1].Text + ") <br />Who admire you as an employee In his " + DetailsView1.Rows[2].Cells[1].Text + " Company ,<br />In City: " + DetailsView1.Rows[3].Cells[1].Text + " ,In Country: " + DetailsView1.Rows[4].Cells[1].Text + "<Br />You Have To Contact Him @ his Email: <a href='mailto:" + DetailsView1.Rows[5].Cells[1].Text + "' >" + DetailsView1.Rows[5].Cells[1].Text + "</a> <br />Or From His Website: <a href='" + DetailsView1.Rows[6].Cells[1].Text + "'>" + DetailsView1.Rows[6].Cells[1].Text + "</a><br />Good Luck</span>";

        DetailsView1.Visible = false;
    }
}
