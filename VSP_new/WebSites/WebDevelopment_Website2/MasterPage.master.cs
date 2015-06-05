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

public partial class MasterPage : System.Web.UI.MasterPage
{
    public static string Type = "";
    public static bool Login=false;
    public static string ImaheHreader="";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Label1.Text = ImaheHreader;

        if (Session["UserName"] != null)
        {
            Login = true;
        }
        else
        {
            Login = false;
        }
        //Response.Write(AccessDataSource1.DataFile);
        //Session["DBPath"] = @"c:\db\JobSeekersDB.mdb"; //AccessDataSource1.DataFile;

        if (Type == "Employee")
        {
           // Label1.Text = "<script type='text/javascript'>document.images.HeaderImg.src='Images/nav_candunauth_1_1.png';alert('');</script>";

            Label1.Text = "Job Seeker: ";

        }
        else
        {
           // Label1.Text = "<script type='text/javascript'>document.images.HeaderImg.src='Images/nav_candunauth_1_2.png';alert('');</script>";
            Label1.Text = "Employers: ";
        }

        if (Login)
        {
            LinkButton2.Visible = false;
            LinkButton3.Visible = false;
            LinkButton1.Text = "LogOut";
        }
        else
        {
            LinkButton1.Text = "LogIn";
            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
            LinkButton3.Visible = true;
        }
        if (Session["UserName"] != null)
        {
            Label2.Text = "Welcome: "+(string)Session["UserName"];
        }

        //Label lbl = new Label();
        //lbl.Text = "<script type='text/javascript'>document.form1.HeaderImg.src='Images/nav_candunauth_1_2.png';</script>";
        //Page.Controls.Add(lbl);

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (LinkButton1.Text == "LogOut")
        {
            Session["UserName"] = null;
            Response.Redirect("Default.aspx");
        }
        else
        {
            if (Type == "Employee") Response.Redirect("Login.aspx?Type=Employee");
            else Response.Redirect("Login.aspx?Type=Employer");
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        if (Type == "Employee") Response.Redirect("EmployeeReg.aspx");
        else Response.Redirect("EmployersReg.aspx");
    }
    static void Hide()
    {
        
    }
}
