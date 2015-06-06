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

public partial class previewpic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Membership.GetUser() == null)
        {
            FormsAuthentication.RedirectToLoginPage();
        }
        else
        {
            System.Drawing.Bitmap temp;
            if (Profile.Photo == null)
                temp = new System.Drawing.Bitmap(Server.MapPath("NoImage.JPG"));
            else
                temp = new System.Drawing.Bitmap(Profile.Photo);
            temp.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
