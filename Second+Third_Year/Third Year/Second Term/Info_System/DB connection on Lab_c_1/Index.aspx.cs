using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("newuser.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (checkUser())
            Response.Write("success");
        else
            Response.Write("failed");
    }

    public bool checkUser()
    {
        bool result = false;
        OleDbConnection Myconnection;
        OleDbDataReader dbReader;

        Myconnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source='\DB\users.mdb'");
        Myconnection.Open();

        string query = "SELECT * FROM user_data where user_name='" + TextBox1.Text+ "' and user_password='" + TextBox2.Text + "'";

        OleDbCommand cmd = Myconnection.CreateCommand();
        cmd.CommandText = query;
        dbReader = cmd.ExecuteReader();

        if (dbReader.Read())
            result = true;
        else
            result = false;

        dbReader.Close();
        Myconnection.Close();
        return result;
    }
}
