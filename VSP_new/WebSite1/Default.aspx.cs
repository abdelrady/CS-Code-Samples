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
        //Label2.Text+=AccessDataSource1.;
        string strUname, strPass, strEmail,strSQLQuery, CheckUname, Checkpass;
        strSQLQuery = "select * from ip_table";
        OleDbConnection BCon,cartCon;
    OleDbCommand bcmd,Mcmd,Tcmd,pcmd;
    OleDbDataReader objReader;
    OleDbDataReader dr,cdr,tempdr;
    int intStart;
    string INSERTSQL,updatesql;

    OleDbConnection Bcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\WebSite1\App_Data\ip.mdb;Persist Security Info=False");

        Bcon.Open();
        bcmd = new OleDbCommand(strSQLQuery, Bcon);
              objReader = bcmd.ExecuteReader();

              while (objReader.Read())
              {
                  Label2.Text = objReader["Ip"].ToString();
                 
              }
              Bcon.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strUname, strPass, strEmail, strSQLQuery, CheckUname, Checkpass;
        strSQLQuery = "update ip_table set ip='"+TextBox1.Text+"' where ip='"+Label2.Text+"'";
        OleDbConnection BCon, cartCon;
        OleDbCommand bcmd, Mcmd, Tcmd, pcmd;
        OleDbDataReader objReader;
        OleDbDataReader dr, cdr, tempdr;
        int intStart;
        string INSERTSQL, updatesql;

        OleDbConnection Bcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\WebSite1\App_Data\ip.mdb;Persist Security Info=False");

        Bcon.Open();
        bcmd = new OleDbCommand(strSQLQuery, Bcon);
        if(bcmd.ExecuteNonQuery()>0)Response.Redirect("Success2.aspx");

        Bcon.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("default2.aspx");
    }
}
