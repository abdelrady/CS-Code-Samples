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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Membership.GetUser() == null)
            FormsAuthentication.RedirectToLoginPage();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Profile.Photo = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);
        Profile.ImageName = FileUpload1.FileName;
        Profile.Save();
        ltrlStatus.Text = " „ Õ›Ÿ «·’Ê—… ›Ï „·›ﬂ «·‘Œ’Ì";
    }
}
