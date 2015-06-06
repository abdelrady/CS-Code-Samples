using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
public partial class _Default : System.Web.UI.Page 
{
protected void Page_PreInit(object sender, EventArgs e)
{
    if (Request["DropDownList1"] != null)
    {
        Page.Theme = Request["DropDownList1"];
    }
}
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        string[] strPath=Directory.GetDirectories(
            Request.PhysicalApplicationPath + "app_themes");
        foreach (string strTemp in strPath)
        {
            DropDownList1.Items.Add(strTemp.Substring(strTemp.LastIndexOf('\\') + 1));
        }
    }
}
}
