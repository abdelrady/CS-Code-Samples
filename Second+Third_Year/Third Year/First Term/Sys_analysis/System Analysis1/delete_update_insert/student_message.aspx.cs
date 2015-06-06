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

public partial class student_message : System.Web.UI.Page
{
    OleDbConnection cnADONetConnection = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {

        cnADONetConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\faculty\student.mdb";
    
       
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        int count;
        OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter();
        DataTable m_dtContacts = new DataTable();
        cnADONetConnection.Open();
        m_daDataAdapter = new OleDbDataAdapter("select * From message where name=" +"\""+TextBox2.Text+"\"" , cnADONetConnection);
        OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter);
        count = m_daDataAdapter.Fill(m_dtContacts);

        Label7.Text = count.ToString();
        Label2.Text = m_dtContacts.Rows[0][2].ToString();
        Label4.Text = m_dtContacts.Rows[0][3].ToString();
        TextBox1.Text = m_dtContacts.Rows[0][1].ToString();
           
       }
        
        




        
    
   }
