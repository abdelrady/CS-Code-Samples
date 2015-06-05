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

public partial class EmployeeReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            Response.Redirect("BadRequest.aspx");
        }
        //Button1.Enabled = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Label2.Text = "<script type='text/javascript'>validate1();</script>";
        //RegexStringValidator obj = new RegexStringValidator("");
        //if(){
        //obj.Validate(TextBox9.Text);
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox9.Text != "" && TextBox11.Text != "" && TextBox12.Text != "")
        {
            string Experts = TextBox3.Text + " " + TextBox4.Text + " " + TextBox10.Text;

            OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db\JobSeekersDB.mdb;Persist Security Info=False");
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Seekers values('" + TextBox11.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.SelectedItem.Text + "','" + TextBox9.Text + "','" + TextBox12.Text + "','" + Experts + "','" + DropDownList2.SelectedItem.Text + "')", cnn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Response.Redirect("Successful_registration.aspx");
                }
            }
            catch (Exception ex) { Label1.Text = "<div style='color:red;'>Errors Occured: <ul><li>" + ex.Message + "</li></ul></div>"; }

        }
        else
        {
            Label1.Text = "<div style='color:red;'>Errors Occured: <br />Please Make Sure that these fields filled correctly<ul><li>First Name</li><li>Last Name</li><li>List Of Experts</li><li>Email Address for communication</li><li>User Id</li><li>User Password</li></ul></div>";
        }
    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {

    }
}
