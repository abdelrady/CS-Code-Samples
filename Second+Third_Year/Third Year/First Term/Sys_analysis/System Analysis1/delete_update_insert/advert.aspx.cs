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

public partial class advert : System.Web.UI.Page
{
    OleDbConnection cnADONetConnection = new OleDbConnection();
    //OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter();
    //DataTable m_dtContacts = new DataTable();
    //  DataSet s = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        cnADONetConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\faculty\student.mdb";
        //cnADONetConnection.Open();

        //m_daDataAdapter = new OleDbDataAdapter("Select * From Table1", cnADONetConnection);
        //OleDbCommandBuilder m_cbCommandBuilder = new OleDbCommandBuilder(m_daDataAdapter);


        // m_daDataAdapter.Fill(m_dtContacts);


    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        this.Add(TextBox1.Text, TextBox1.Text);
        //DataRow drNewRow = m_dtContacts.NewRow();
        //drNewRow["text"] = "asd";
        //m_dtContacts.Rows.Add(drNewRow);
        //m_dtContacts.Rows[0][0] = "sa";
        //m_daDataAdapter.Update(m_dtContacts);

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    public void Add(string FirstName, string LastName)
    {
        int rv = 0;

        string myAddQuery = @"INSERT INTO [Names] " +
        @"(FirstName, LastName) " +
        "VALUES ( \"" + FirstName + "\",\"" + LastName + "\")";


        //myConnection = new OleDbConnection(myConnectionString);

        OleDbCommand myCommand =
        new OleDbCommand(myAddQuery, cnADONetConnection);

        cnADONetConnection.Open();

        rv = myCommand.ExecuteNonQuery();

        cnADONetConnection.Close();
    }
    public void delete(string firstname)
    {
        System.Data.OleDb.OleDbConnection cnn;
        System.Data.OleDb.OleDbCommand cmd;
        cnn = cnADONetConnection;
        cnn.Open();
        cmd = new System.Data.OleDb.OleDbCommand();

        cmd.CommandText = "DELETE FROM [Names] WHERE FirstName = \"" + TextBox1.Text + "\"";
        cmd.Connection = cnn;
        cmd.ExecuteNonQuery();
        //grdStudents.EditItemIndex = -1;
        cnn.Close();
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        this.update();
    }
    public void update()
    {
        System.Data.OleDb.OleDbConnection cnn;
        System.Data.OleDb.OleDbCommand cmd;
        cnn = cnADONetConnection;
        cnn.Open();
        cmd = new System.Data.OleDb.OleDbCommand();

        string sFirstName, sLastName;

       
        sFirstName = TextBox1.Text;
        sLastName = TextBox2.Text;
         cmd.CommandText = "UPDATE [Names] SET FirstName= \"" + sFirstName +"\""+","+" LastName = \"" + sLastName + "\" WHERE LastName = \"" + sLastName + "\"";
	 //cmd.CommandText = "UPDATE [Names] SET FirstName= \"" + sFirstName + "\""+","+"\" LastName = \"" + sLastName + " WHERE [LastName] = \"" + sLastName + "\"";
        cmd.Connection = cnn;
        cmd.ExecuteNonQuery();
        //grdStudents.EditItemIndex = -1;
        cnn.Close();
      		
			
    }
}
