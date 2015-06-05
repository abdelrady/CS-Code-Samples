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
using System.Windows.Forms;

public partial class Login : System.Web.UI.Page
{
    string TableName = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (Request.QueryString["Type"].ToLower() == "Employee".ToLower())
        {
            Label1.Text += "You can:<ul><li>Get notified every time new jobs match your resumes and search terms.</li><li>Apply for jobs with a few mouse clicks by saving your resumes and cover letters online.</li><li>Take online job interviews and save the results for employers to view. </li></ul>";
            DropDownList1.SelectedIndex = 1;
        }
        else if (Request.QueryString["Type"].ToLower() == "Employer".ToLower())
        {
            Label1.Text = "Registered employers can post jobs, search for candidates, and provide job candidates more information by creating a Company Profile. ";
            DropDownList1.SelectedIndex = 0;
        }
        else
        {
            DropDownList1.SelectedIndex = -1;
            //Response.Redirect("BadRequest.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Employer")
        {
            TableName = "Employers";
        }
        else if (DropDownList1.SelectedItem.Text == "Job Seeker")
        {
            TableName = "Seekers";
        }
        else{
            Label1.Text += "<br /><div style='font-size:13pt;'>Error Occured:<ul><li>You Have To Choose Your Type Firstly, Either<li>Job Seeker</li>Or<li>Employer</li></ul></div>";
            return;
        }
        OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db\JobSeekersDB.mdb;Persist Security Info=False");
        cnn.Open();
        OleDbCommand cmd = new OleDbCommand("select * from "+TableName+" where ID='"+TextBox1.Text+"' and Password='"+TextBox2.Text+"'", cnn);
        OleDbDataReader reader= cmd.ExecuteReader();
        if (reader.HasRows)
        {
            reader.Read();
            Session["UserName"] = reader["ID"];
            //MessageBox.Show((string)Session["UserName"]);
            if (TableName == "Seekers")
                Response.Redirect("EmployeeHome.aspx");
            else
            {
                Response.Redirect("EmployersHome.aspx");
            }
        }
        else
        {
            Label1.Text = "<br /><div style='color:red;'>Error Occured:<br />Either Your Name Or Password Are Incorrect,Please Try Again</div>";
        }
        //Response.Write(reader.HasRows);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if(TableName=="Seekers")
            Response.Redirect("EmployeeReg.aspx");
        else
            Response.Redirect("EmployersReg.aspx");

    }
}
