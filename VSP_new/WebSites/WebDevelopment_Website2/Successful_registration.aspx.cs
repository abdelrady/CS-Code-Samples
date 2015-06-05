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

public partial class Successful_registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Msg"] != null)
        {
            Label1.Text = (string)Session["Msg"];
        }
        else
        {
            Label1.Text = "Database Modified Successfully & you now Can login With Your Account.";
        }


    }
}
