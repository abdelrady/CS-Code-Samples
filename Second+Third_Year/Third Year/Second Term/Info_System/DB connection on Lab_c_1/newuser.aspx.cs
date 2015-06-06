using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

public partial class newuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //int x;
        string newuser = "Insert into user_data (user_name,user_password,user_email,user_city,user_phone)values ";
        newuser += "('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";

        OleDbConnection Connection = new OleDbConnection();
        Connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\DB\users.mdb ";
        //OleDbCommand Command = new OleDbCommand(newuser, Connection);
        OleDbCommand Command = Connection.CreateCommand();
        Command.CommandText = newuser;
        Connection.CreateCommand();
        Connection.Open();
        try
        {
            Command.ExecuteNonQuery();
        }
        catch (OleDbException )
        {
            MessageBox.Show("The Fields May Be Entered In Errors.");
        }
        //if (x==0) { MessageBox.Show("The Fields May Be Entered In Errors."); }
        //Response.Write(x.ToString());
        Connection.Close();
    }
    
}
