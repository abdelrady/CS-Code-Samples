using System;
using System.Threading;
using System.Globalization;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Resources;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHello.Text = Thread.CurrentThread.CurrentCulture.Name;
        if (!IsPostBack)
        {
            CultureInfo[] AllCul = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo temp in AllCul)
            {
                ListItem t = new ListItem(temp.DisplayName, temp.Name);
                DropDownList1.Items.Add(t);
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo(DropDownList1.SelectedValue);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strMSG = "window.alert('{0}')";
        if (Thread.CurrentThread.CurrentCulture.Name == "ar-EG" )
           strMSG = string.Format(strMSG, Resources.Messages.ArabicHello);
        else
           strMSG = string.Format(strMSG, Resources.Messages.EnglishHello);
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "JustHello", strMSG, true);
    }
}
