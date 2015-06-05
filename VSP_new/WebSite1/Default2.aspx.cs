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
using System.Data.OleDb;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strUname, strPass, strEmail, strSQLQuery, CheckUname, Checkpass;
        strSQLQuery = "select * from ip_table";
        //OleDbConnection  cartCon;
        OleDbCommand bcmd, Mcmd, Tcmd, pcmd;
        OleDbDataReader objReader;
        OleDbDataReader dr, cdr, tempdr;
        int intStart;
        string str="";

        OleDbConnection Bcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\WebSite1\App_Data\ip.mdb;Persist Security Info=False");

        Bcon.Open();
        bcmd = new OleDbCommand(strSQLQuery, Bcon);
        objReader = bcmd.ExecuteReader();

        while (objReader.Read())
        {
            str = objReader["Ip"].ToString();
        }
        Bcon.Close();

        Response.Redirect("http://" + str + ":6789/");
    }
}
