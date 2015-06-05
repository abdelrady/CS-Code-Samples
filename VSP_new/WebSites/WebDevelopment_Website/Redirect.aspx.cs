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

public partial class Redirect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Type"] == null) Response.Redirect("EmployersHome.aspx");

        if (((string)Session["Type"]).ToLower() == "employer")
        {
            Response.Redirect("Employers_Search.aspx");
        }
        else
        {
            Response.Redirect("Hired_jobs.aspx");
        }
    }
}
