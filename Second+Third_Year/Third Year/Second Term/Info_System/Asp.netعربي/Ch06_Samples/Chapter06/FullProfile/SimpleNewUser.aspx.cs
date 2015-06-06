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

public partial class SimpleNewUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.Validate();
        MembershipCreateStatus tempCreateStatus;
        Membership.CreateUser(txtName.Text, txtPassword.Text,txtEmail.Text,txtQuestion.Text,txtAnswer.Text , true,out tempCreateStatus);
        ltrlResult.Text = string.Format("<font color=red> <b> {0} <b> </font>",tempCreateStatus.ToString());
        if (tempCreateStatus == MembershipCreateStatus.Success)
            Response.Redirect("ImageIntoProfile.aspx");
    }
}
