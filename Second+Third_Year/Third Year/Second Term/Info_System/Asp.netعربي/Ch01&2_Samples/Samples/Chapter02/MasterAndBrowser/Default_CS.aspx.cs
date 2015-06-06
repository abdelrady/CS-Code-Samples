using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        switch(Request.Browser.Browser.ToLower())
        {
            case "ie":
                MasterPageFile = "MasterForIE.master";
                break;
            case "opera":
                MasterPageFile = "MasterForOpera.master";
                break;
            case "firefox":
                MasterPageFile = "MasterForFireFox.master";
                break;
            default :
                MasterPageFile = "MasterForDefault.master";
                break;
        }
    }
}
