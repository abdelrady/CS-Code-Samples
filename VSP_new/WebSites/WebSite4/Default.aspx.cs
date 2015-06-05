using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MailMessage msg = new MailMessage("abdelrady@gmail.com", "abdelrady2030@yahoo.com");
        msg.Body = "test test test.";
        //msg.From = "test test test.";
        //msg.To= "test test test.";
        msg.Subject = "test test test.";

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Credentials = new System.Net.NetworkCredential("abdelrady", "amr_fci2010");
        smtp.EnableSsl = true;
        smtp.Port = 587;
        smtp.Send(msg);
    }
}
