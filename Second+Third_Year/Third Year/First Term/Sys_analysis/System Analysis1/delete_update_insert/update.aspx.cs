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

public partial class update : System.Web.UI.Page
{
    OleDbConnection cnADONetConnection = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        cnADONetConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\faculty\student.mdb";
    }
    //search about student////////////////////////////
    public void search(int id)
    {
        int count;
        OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter();
        DataTable m_dtContacts = new DataTable();
        cnADONetConnection.Open();
        m_daDataAdapter = new OleDbDataAdapter("select * From first_year where id=" + id, cnADONetConnection);
        OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter);
        count=m_daDataAdapter.Fill(m_dtContacts);
        if (count == 0)
        {
            Label8.Visible = true;
            Label8.Text = " «·ÿ«·» €Ì— „ÊÃÊœ ";
        }
        else
        {
            string f, s, t, fh;
            f = m_dtContacts.Rows[0][0].ToString();
            s = m_dtContacts.Rows[0][2].ToString();
            t = m_dtContacts.Rows[0][3].ToString();
            fh = m_dtContacts.Rows[0][1].ToString();
            TextBox1.Text = f + " " + s + " " + t + " " + fh;
            TextBox5.Text = m_dtContacts.Rows[0]["address"].ToString();
            TextBox3.Text = m_dtContacts.Rows[0]["city1"].ToString();
            TextBox6.Text = m_dtContacts.Rows[0]["city2"].ToString();
            TextBox2.Text = m_dtContacts.Rows[0]["phone"].ToString();
            DropDownList2.Text = m_dtContacts.Rows[0]["sex"].ToString();
            TextBox7.Text = m_dtContacts.Rows[0]["id"].ToString();
        }
        cnADONetConnection.Close();
        

    }
    //check for student id if it was found.//////////
    public bool check(int id)
    {
        int count;
        OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter();
        DataTable m_dtContacts = new DataTable();
        cnADONetConnection.Open();
        m_daDataAdapter = new OleDbDataAdapter("select * From first_year where id=" + id, cnADONetConnection);
        OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter);
        count=m_daDataAdapter.Fill(m_dtContacts);
        if (count == 0)
        {
            cnADONetConnection.Close();
            return false;
        }
        else
        {
            cnADONetConnection.Close();
            return true;
        }

        
    }
    //add new student////////////////////////////////////////
    public void Add(string FirstName, string LastName,string FatherName,string GfName,string phone,string sex,int id,string address,string city1,string city2)
    {
        int rv = 0;

        if (this.check(id))
        {
            Label8.Visible = true;
            Label8.Text = " «·ÿ«·» „ÊÃÊœ ";
        }
        else
        {
            string myAddQuery = @"INSERT INTO [first_year] " +
            @"(FirstName, LastName,FatherName,GF_name,phone,sex,id,address,city1,city2) " +
            "VALUES ( \"" + FirstName + "\",\"" + LastName + "\",\"" + FatherName + "\",\"" + GfName + "\",\"" + phone + "\",\"" + sex + "\",\"" + id + "\",\"" + address + "\",\"" + city1 + "\",\"" + city2 + "\")";
            //myConnection = new OleDbConnection(myConnectionString);
            OleDbCommand myCommand =
            new OleDbCommand(myAddQuery, cnADONetConnection);
            cnADONetConnection.Open();
            rv = myCommand.ExecuteNonQuery();
            Label8.Visible = true;
            Label8.Text = "ﬁœ  „ √÷«›… ÿ«·» ÃœÌœ";
            cnADONetConnection.Close();
       
        }
            

    }
    //function update student data////////////////////////////////////
    public void update5(string FirstName, string LastName, string FatherName, string GfName, string phone, string sex, int id, string address, string city1, string city2)
    {
       
            System.Data.OleDb.OleDbConnection cnn;
            System.Data.OleDb.OleDbCommand cmd;
            cnn = cnADONetConnection;
            cnn.Open();
   
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.CommandText = "UPDATE [first_year] SET FirstName= \"" + FirstName + "\"" + "," + " LastName = \"" + LastName + "\"" + "," + " FatherName = \"" + FatherName + "\"" + "," + " GF_name = \"" + GfName + "\"" + "," + " phone = \"" + phone + "\"" + "," + " sex = \"" + sex + "\"" + "," + " id = \"" + id + "\"" + "," + " address = \"" + address + "\"" + "," + " city1 = \"" + city1 + "\"" + "," + " city2 = \"" + city2 + "\"" + "WHERE id = " + id;
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            Label8.Visible = true;
            Label8.Text = "ﬁœ  „  ⁄œÌ· »Ì«‰«  «·ÿ«·»";
            //grdStudents.EditItemIndex = -1;
            cnn.Close();
       
    }
    //function delete student.//////////////////////////////////
    public void delete2(int id)
    {
        System.Data.OleDb.OleDbConnection cnn;
        System.Data.OleDb.OleDbCommand cmd;
        cnn = cnADONetConnection;
        cnn.Open();
        cmd = new System.Data.OleDb.OleDbCommand();
        cmd.CommandText = "DELETE FROM [first_year] WHERE id =" + id;
        cmd.Connection = cnn;
        cmd.ExecuteNonQuery();
        
        Label8.Visible = true;
        Label8.Text = "ﬁœ  „ „”Õ »Ì«‰«  «·ÿ«·»";

        //grdStudents.EditItemIndex = -1;
        cnn.Close();
    }
        
            

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
   //action add////////////////////
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        string s = TextBox1.Text;
        string f, l, t, fh;
        int i = s.LastIndexOf(" ");
        fh = s.Substring(i+1);
        s=this.sptract(s.Length, s);
         i = s.LastIndexOf(" ");
        t = s.Substring(i + 1);
        s = this.sptract(s.Length, s);
         i = s.LastIndexOf(" ");
        l = s.Substring(i + 1);
        s = this.sptract(s.Length, s);
         i = s.LastIndexOf(" ");
        f = s.Substring(i + 1);
        if (TextBox1.Text.CompareTo("") == 0 || TextBox2.Text.CompareTo("") == 0 || TextBox3.Text.CompareTo("") == 0 || TextBox5.Text.CompareTo("") == 0 | TextBox6.Text.CompareTo("") == 0 || TextBox7.Text.CompareTo("") == 0)
        {
            Label8.Visible = true;
            Label8.Text = "ÌÊÃœ Œ«‰… Œ«·Ì…";
        }
        else
            this.Add(f, fh, l, t, TextBox2.Text, DropDownList2.Text, Int32.Parse(TextBox7.Text), TextBox5.Text, TextBox3.Text, TextBox6.Text);
 
    }
    //function for partation the name.//////////////////
    public string sptract(int length,string name)
    {
        string s="";
        int j = name.LastIndexOf(" ");
        for (int i = 0; i < length; i++)
        {
            if (i == j)
                break;
            else
                s += name[i];

        }
        return s;
    }

    //action update.///////////////////
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string s = TextBox1.Text;
        string f, l, t, fh;
        int i = s.LastIndexOf(" ");
        fh = s.Substring(i+1);
        s=this.sptract(s.Length, s);
         i = s.LastIndexOf(" ");
        t = s.Substring(i + 1);
        s = this.sptract(s.Length, s);
         i = s.LastIndexOf(" ");
        l = s.Substring(i + 1);
        s = this.sptract(s.Length, s);
         i = s.LastIndexOf(" ");
        f = s.Substring(i + 1);

        this.update5(f, fh, l, t, TextBox2.Text, DropDownList2.Text,Int32.Parse(TextBox7.Text), TextBox5.Text, TextBox3.Text, TextBox6.Text);

    }
    //action search by id.//////////////////////
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (TextBox7.Text == "")
        {
            Label8.Visible = true;
            Label8.Text = "√œŒ· —ﬁ„ «·ÿ«·»";
        }
        else
        {
            Label8.Visible = false;
            this.search(Int32.Parse(TextBox7.Text));
        }
    }
    //action for delete student data.//////////////////////
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        this.delete2(Int32.Parse(TextBox7.Text));

    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
              
    }
}
