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

public partial class Default_CS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
protected void Button1_Click(object sender, EventArgs e)
{
    Image imgHolder = (Image)Master.FindControl("img_BrowserImage");
    Label lblHolder = (Label)Master.FindControl("lbl_BrowserInfo");
    imgHolder.ImageUrl = "~\\Images\\" + Request.Browser.Browser + ".jpg";
    lblHolder.Text = string.Format("<pre>{0}</pre>",Request.Browser.Browser); 
}

}
