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

public partial class account : System.Web.UI.Page
{
    OleDbConnection cnADONetConnection = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        cnADONetConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\faculty\student.mdb";

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (this.search(Int32.Parse(TextBox2.Text),TextBox3.Text,TextBox1.Text))
        {
            int d=Int32.Parse(TextBox2.Text);
            if (d % 10 == 1)
                Server.Transfer("update.aspx");
            else if (d % 10 == 2||d%10==3||d%10==4)
                Server.Transfer("course.aspx");
            

        }
        else
        {
            Label3.Visible = true;
            Label3.Text = " √‰  €Ì— „‘ —ﬂ ";
        }

    }
    public bool search(int id,string password,string user)
    {
        int count;
        OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter();
        DataTable m_dtContacts = new DataTable();
        cnADONetConnection.Open();
        m_daDataAdapter = new OleDbDataAdapter("select * From account where id=" + id, cnADONetConnection);
        OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter);
        count = m_daDataAdapter.Fill(m_dtContacts);

        if (count == 0)
        {
            Label3.Visible = true;
            Label3.Text = " √‰  €Ì— „‘ —ﬂ ";
            return false;
        }
        else if (m_dtContacts.Rows[0]["password"].ToString().CompareTo(password) == 0 && m_dtContacts.Rows[0]["username"].ToString().CompareTo(user) == 0)
        {

            cnADONetConnection.Close();
            return true;

        }
        else
            return false;


    }
    
}
