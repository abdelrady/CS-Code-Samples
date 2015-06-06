using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class message : System.Web.UI.Page
{

    OleDbConnection cnADONetConnection = new OleDbConnection();
     protected void Page_Load(object sender, EventArgs e)
    {
        cnADONetConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\faculty\student.mdb";
     
     }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
       
            

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string myAddQuery = @"INSERT INTO [message] " +
       @"(name,message,subject,sender) " +
       "VALUES ( \"" + TextBox3.Text + "\",\"" + TextBox1.Text + "\",\"" + TextBox2.Text + "\",\"" + TextBox4.Text + "\")";
        OleDbCommand myCommand =
        new OleDbCommand(myAddQuery, cnADONetConnection);
        cnADONetConnection.Open();
        myCommand.ExecuteNonQuery();
        cnADONetConnection.Close();
       
    }
}
