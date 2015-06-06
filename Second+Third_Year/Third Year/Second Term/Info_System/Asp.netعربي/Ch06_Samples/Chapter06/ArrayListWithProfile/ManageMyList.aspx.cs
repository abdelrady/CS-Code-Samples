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
        if(!IsPostBack)
            for (int i = 0; i < Profile.UserList.Count; i++)
                ListBox1.Items.Add(Profile.UserList[i].ToString());
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Profile.UserList.Add(TextBox1.Text);
        ListBox1.Items.Add(TextBox1.Text);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Profile.UserList.Remove(ListBox1.SelectedItem.Text);
        ListBox1.Items.Remove(ListBox1.SelectedItem);
    }
}
