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

public partial class Employers_Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label1.Text = "<script type='text/javascript'>document.images.HeaderImg.src='Images/nav_empunauth_1_2.png';</script>";
        if (!Page.IsPostBack)
        {
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Employer_SearchResult.aspx?Country=" + DropDownList2.SelectedValue + "&Category=" + DropDownList1.SelectedItem.Text + "&KeyWord1=" + TextBox1.Text + "&KeyWord2=" + TextBox2.Text + "&KeyWord3=" + TextBox4.Text + "&KeyWord4=" + TextBox5.Text);
    }
}
/*OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\db\JobSeekersDB.mdb;Persist Security Info=False");
        cnn.Open();
        OleDbCommand cmd = new OleDbCommand("Select * from Seekers Where Country='" + DropDownList1.SelectedItem.Text + "' or Education_Category='" + DropDownList1.SelectedItem.Text + "' or (Experts like %'" + TextBox1.Text + "'%) or (Experts like %'" + TextBox2.Text + "'%) or (Experts like %'" + TextBox5.Text + "'%) or (Experts like %'" + TextBox4.Text + "'%)");
        OleDbDataReader Reader= cmd.ExecuteReader();

*/