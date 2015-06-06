using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class DBManagement
{
    private DBManagement()
	{
	}
    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["pubsConnectionString"].ConnectionString;
    }
    private static DataSet ExecuteProcedure(string strCommandName, params SqlParameter[] Inputs)
    {
        SqlConnection con = new SqlConnection(GetConnectionString());
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = strCommandName;
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Connection = con;
        foreach (SqlParameter tempParam in Inputs)
        {
            cmd.Parameters.Add(tempParam);
        }
        
        SqlDataAdapter adbt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adbt.Fill(ds);

        cmd.Dispose();
        adbt.Dispose();
        con.Close();
        return ds;
    }
    public static DataSet GetAuthorInformation()
    {
        return ExecuteProcedure("spGetAuthors");
    }
    public static DataSet GetAuthorInformationWithPremission(int intPremission)
    {
        if (intPremission==1)
            return ExecuteProcedure("spGetAuthors");
        else
            return ExecuteProcedure("spGetAuthorByIDWithPremission");        
    }
}