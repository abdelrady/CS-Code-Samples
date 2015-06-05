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

public partial class AcceptSeeker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["UserName"] != null)
        {
            string ID=Request.QueryString["ID"];
            string JobID=Request.QueryString["JobID"];
            if (ID != "" && JobID != "")
            {
                Response.Write("Not Equal Empty");
                OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db\JobSeekersDB.mdb;Persist Security Info=False");
                cnn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Employees_Hired values('" + ID + "','" + JobID + "')", cnn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Session["Msg"] = "Acceptance Operation Successfully Completed & Email Was Sent to Accepted Seeker";
                    Response.Redirect("Successful_registration.aspx");
                }
                else
                {
                    Response.Redirect("BadRequest.aspx");
                }
            }
            else
            {
                Response.Redirect("BadRequest.aspx");
            }
        }
        //else
        {
            Response.Redirect("BadRequest.aspx");
        }
        //Response.Write("Equal Empty");
    }
}
