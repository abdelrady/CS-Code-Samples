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

public partial class GetPhotoByName : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["Name"] != null)
        {
            string strName = Request.QueryString["Name"];
            ProfileCommon tempProfile = Profile.GetProfile(strName);
            System.Drawing.Bitmap tempImage;
            if (tempProfile.Photo == null)
                tempImage = new System.Drawing.Bitmap
                            (Server.MapPath("NoImage.JPG"));
            else
                tempImage = new System.Drawing.Bitmap(tempProfile.Photo);
            tempImage.Save(Response.OutputStream, 
                            System.Drawing.Imaging.ImageFormat.Jpeg);
        }

    }
}
