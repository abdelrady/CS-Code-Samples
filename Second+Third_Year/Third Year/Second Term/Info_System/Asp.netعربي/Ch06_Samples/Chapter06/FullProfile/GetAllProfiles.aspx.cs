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

public partial class GetAllProfiles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (MembershipUser temp in Membership.GetAllUsers())
        {
            Response.Write(temp.UserName + " - <a href=mailto:" 
                           + temp.Email + ">" + temp.Email + 
                           "</a> <img src=GetPhotoByName.aspx?Name=" 
                           + temp.UserName + "> <br> <hr>");
        }
    }
}
