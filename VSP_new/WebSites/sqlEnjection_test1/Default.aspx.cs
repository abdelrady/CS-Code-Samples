using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\db\SDASDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        cnn.Open();
        SqlCommand cmd = new SqlCommand("", cnn);
        cmd.CommandText = "Select * from adminUsers where name='" + this.TextBox1.Text + "' and password='" + this.TextBox2.Text + "'";
        SqlDataReader rd= cmd.ExecuteReader();
        while (rd.Read())
        {
            Response.Write("<pre>User Name: " + rd[0] + "<     >Password: " + rd[1] + "</pre><br />");
        }
    }
}
