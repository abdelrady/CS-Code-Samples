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

public partial class search : System.Web.UI.Page
{
    int n, i;
    int l;

    OleDbConnection con = new OleDbConnection();
    OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter();
    DataTable m_dtContacts = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\faculty\student.mdb";
        con.Open();
        m_daDataAdapter = new OleDbDataAdapter("select * From first_year", con);
        OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter);
        m_daDataAdapter.Fill(m_dtContacts);
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        n = m_dtContacts.Rows.Count;
        string name=TextBox1.Text;
        string f,ft,gf,fm;
        string n2,n3,n4;
        for (i = 0; i < n; i++)
            {
                f = m_dtContacts.Rows[i]["FirstName"].ToString();
                ft = m_dtContacts.Rows[i]["FatherName"].ToString();
                gf = m_dtContacts.Rows[i]["GF_name"].ToString();
                fm = m_dtContacts.Rows[i]["LastName"].ToString();
                n2 = f + " " + ft;
                n3 = f + " " + ft + " " + gf;
                n4=f + " " + ft + " " + gf+" "+fm;
                if (name.CompareTo(n4) == 0 || name.CompareTo(f) == 0 || name.CompareTo(n2) == 0 || name.CompareTo(n3) == 0)
                {
                    l = i;
                    Table1.Visible = true;
                    Label2.Visible = false;
                    na.Text = n4;
                    a.Text = m_dtContacts.Rows[i]["city1"].ToString() + "/" + m_dtContacts.Rows[i]["city2"].ToString() + "/" + m_dtContacts.Rows[i]["address"].ToString();
                  p.Text=m_dtContacts.Rows[i]["phone"].ToString();
                  break;
                   

                }
                else
                {
                  Label2.Visible = true;
                  Table1.Visible = false;
                  Label2.Text = "Student not found";
                  TextBox1.Text="";
                }
        }

    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        
        string name = TextBox1.Text;
        string f, ft, gf, fm;
        string n2, n3, n4;
        for (int j= l; j < n; j++)
        {
            f = m_dtContacts.Rows[j]["FirstName"].ToString();
            ft = m_dtContacts.Rows[j]["FatherName"].ToString();
            gf = m_dtContacts.Rows[j]["GF_name"].ToString();
            fm = m_dtContacts.Rows[j]["LastName"].ToString();
            n2 = f + " " + ft;
            n3 = f + " " + ft + " " + gf;
            n4 = f + " " + ft + " " + gf + " " + fm;
            if (name.CompareTo(n4) == 0 || name.CompareTo(f) == 0 || name.CompareTo(n2) == 0 || name.CompareTo(n3) == 0)
            {
                Table1.Visible = true;
                Label2.Visible = false;
                na.Text = n4;
                a.Text = m_dtContacts.Rows[i]["city1"].ToString() + "/" + m_dtContacts.Rows[i]["city2"].ToString() + "/" + m_dtContacts.Rows[i]["address"].ToString();
                p.Text = m_dtContacts.Rows[i]["phone"].ToString();
                if (j < n)
                    continue;
                
            }
            else
            {
                Table1.Visible = false;
                Label2.Visible = true;
                Label2.Text = "Student not found";
                TextBox1.Text = "";
            }
        }

    }
}
