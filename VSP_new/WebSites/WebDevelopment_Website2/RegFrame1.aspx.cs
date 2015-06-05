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

public partial class RegFrame1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckBox1.Text = "I am Agree With </strong></span>                <a href='Policy.aspx'> <strong><span style='font-size: 7pt'>Website               Policy</span></strong></a> ....<br />";
        Button1.Enabled=false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("Successful_registration.aspx");

        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db\JobSeekersDB.mdb;Persist Security Info=False");
        cnn.Open();
        OleDbCommand cmd = new OleDbCommand("Insert into employers values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "','" + DropDownList1.SelectedItem.Text + "','" + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "')", cnn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Redirect("Successful_registration.aspx");
            }
        }
        catch (Exception ex) { Label1.Text = "Errors Occured: <ul><li>" + ex.Message + "</li></ul>"; }
        
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
            Button1.Enabled = true;
        else
        {
            Button1.Enabled = false;
        }
    }
}
