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
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string viewStateString = TextBox1.Text;//Request["__VIEWSTATE"];
        byte[] stringBytes = Convert.FromBase64String(viewStateString);
        // Deserialize and display the string.
        string decodedViewState = System.Text.Encoding.ASCII.GetString(stringBytes);
        Response.Write(decodedViewState + "<br />");
    }
}
