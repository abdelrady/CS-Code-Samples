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

public partial class EmployersReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            Response.Redirect("BadRequest.aspx");
        }
        //Label2.Text="<div id=div1 style='position: relative; top: -1050px;'>  ";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text!=""&&TextBox2.Text!=""&&TextBox9.Text!=""&&TextBox11.Text!=""&&TextBox12.Text!=""){
        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db\JobSeekersDB.mdb;Persist Security Info=False");
        cnn.Open();
        OleDbCommand cmd = new OleDbCommand("Insert into employers values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.SelectedItem.Text +  "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text+"')", cnn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Redirect("Successful_registration.aspx");
            }
        }
        catch(Exception ex) { Label1.Text = "Errors Occured: <ul><li>"+ex.Message+"</li></ul>"; }
        }
        else
        {
            Label1.Text = "<div style='color:red;'>Errors Occured: <br />Please Make Sure that these fields filled correctly<ul><li>First Name</li><li>Last Name</li><li>Email Address for communication</li><li>User Id</li><li>User Password</li></ul></div>";
        }
    }
    protected void TextBox13_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {/*
        if (CheckBox1.Checked)
            Button1.Enabled = true;
        else
        {
            Button1.Enabled = false;
        }*/
    }
}
