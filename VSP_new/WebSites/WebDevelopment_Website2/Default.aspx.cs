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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        //MasterPage.Type = "Employee"; MasterPage.Login = false;
        string type = (Request.QueryString["Type"] == null) ? "emploee" : Request.QueryString["Type"];

        if (type.ToLower() == "employer")
        {
            Label1.Text = "<script type='text/javascript'>document.images.HeaderImg.src='Images/nav_empunauth_1_2.png';</script>";
        }
        else
        {
            Label1.Text = "<script type='text/javascript'>document.images.HeaderImg.src='Images/nav_empunauth_1_1.png';</script>";
        }
        
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Employer_SearchResult.aspx?Country=" + DropDownList2.SelectedItem.Text + "&Category=" + DropDownList1.SelectedItem.Text + "&KeyWord1=" + TextBox1.Text + "&KeyWord2=&KeyWord3=&KeyWord4=");
    }
}
