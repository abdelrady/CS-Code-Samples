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

public partial class EmployeeHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPage.Type = "Employee";
        Session["Type"] = "employee";
        Response.Redirect("Default.aspx?Type=Employee");
        
        /*if (Session["UserName"] != null)
        {
            MasterPage.Login = true;
        }
        else
        {
            Response.Redirect("BadRequest.aspx");
        }*/
    }
}
