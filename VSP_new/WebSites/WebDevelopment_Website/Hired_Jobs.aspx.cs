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

public partial class Hired_Jobs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("login.aspx?type=employee");
        }
        Label2.Text = "<script type='text/javascript'>document.images.HeaderImg.src='Images/nav_empunauth_1_1.png';</script>";

        //Session["UserName"] = "1";
        AccessDataSource1.SelectCommand = "SELECT * FROM [Employees_Hired] where employeeID='"+Session["UserName"]+"'";
        AccessDataSource1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
