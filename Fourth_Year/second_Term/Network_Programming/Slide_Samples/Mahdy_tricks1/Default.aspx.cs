using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private MemoryStream GetData()
    {
        //Create the return memorystream object that will hold the buffered data.
        MemoryStream ReturnStream = new MemoryStream();
        //Put together the connection string
        string cn = @"Persist Security Info=False;Integrated Security=false;User ID=sa;Pwd=sa;database=c:\db\sdasdb.mdf;server=.\sqlexpress;Connect Timeout=30";
        try
        {
            //Get the sql string
            string SqlString = "select * from dbo.users";
            //Create a new command object
            SqlCommand sc = new SqlCommand();
            //Set the connection
            sc.Connection = new SqlConnection(cn);
            //Open the connection
            sc.Connection.Open();
            //Set the command type
            sc.CommandType = CommandType.Text;
            //Set the SQL String
            sc.CommandText = SqlString;
            //Execute the SQL Statement/Procedure
            SqlDataReader RS = sc.ExecuteReader();
            //Create a streamwriter to write to the memory stream 
            StreamWriter sw = new StreamWriter(ReturnStream);
            if (RS.HasRows)
            {
                RS.Read();
                //Create a header for the file from the names of the columns that we are retrieving
                string tempstring = "";
                for (int counter = 0; counter < RS.FieldCount; counter++)
                {
                    tempstring += RS.IsDBNull(counter) ? "" : RS.GetName(counter) + "\t";
                }
                //Write the row of data to the Memory Stream.
                sw.WriteLine(tempstring);
                //Loop through the data row and write the contents to the memory stream.
                do
                {
                    //Put each columns' data value into a string separated by a tab.
                    tempstring = "";
                    for (int counter = 0; counter < RS.FieldCount; counter++)
                    {
                        tempstring += RS.IsDBNull(counter) ? "" : RS.GetValue(counter).ToString() + "\t";
                    }
                    //Write the row of data to the Memory Stream. 
                    sw.WriteLine(tempstring);
                }
                while (RS.Read());
            }
            //Clean up the stream writer
            sw.Flush();
            sw.Close();
            //Clean up the data reader
            RS.Close();
            //Clean up the command object
            sc.Connection.Close();
            sc.Dispose();
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        //Return the memory Stream
        return ReturnStream;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Create and populate a memorystream with the contents of the  database table
        System.IO.MemoryStream mstream = GetData();
        //Convert the memorystream to an array of bytes.
        byte[] byteArray = mstream.ToArray();
        //Clean up the memory stream
        mstream.Flush();
        mstream.Close();
        // Clear all content output from the buffer stream
        Response.Clear();
        // Add a HTTP header to the output stream that specifies the default filename
        // for the browser's download dialog
        Response.AddHeader("Content-Disposition", "attachment; filename=foo.txt");
        // Add a HTTP header to the output stream that contains the
        // content length File Size). This lets the browser know how much data is being transfered
        //Response.AddHeader("Content-Length", byteArray.Length.ToString());
        // Set the HTTP MIME type of the output stream
        Response.ContentType = "text/plain";
        // Write the data out to the client.
        Response.BinaryWrite(byteArray);
        Response.BinaryWrite(new byte[] { 1, 2, 4, 3 });

    }
}
