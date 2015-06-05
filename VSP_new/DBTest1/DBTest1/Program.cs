using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DBTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=fcis");
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT CustomerID,City,Country FROM [customers]";
            SqlDataAdapter DA = new SqlDataAdapter(cmd.CommandText, cnn);
            DataSet ds = new DataSet();
            DA.FillSchema(ds, SchemaType.Mapped, "Customers");
            DA.Fill(ds, "Customers");
            DA.FillSchema(ds, SchemaType.Mapped, "Customers");
            ds.Tables[0].TableName = "Customers";
            foreach (DataTable dat in ds.Tables)
            {
                Console.WriteLine(dat.TableName);
            }
            DataColumn[] pk = new DataColumn[] { ds.Tables[0].Columns[0] };
            ds.Tables[0].PrimaryKey = pk;
            //ds.Tables["customers"].Constraints.Add("pk_prime", new DataColumn(ds.Tables[0].Columns[0].ColumnName), true);
            DataRow dtr2 = ds.Tables["customers"].Rows.Find("ALFKI");
            string str=Console.ReadLine();
            if ( str== "1")
            {   
                dtr2.BeginEdit();
                dtr2[1] = "asdasd";
                dtr2[2] = "luxor";
                dtr2.EndEdit();
                //SqlCommandBuilder sqlcb = new SqlCommandBuilder(DA);
                DA.UpdateCommand.CommandText="UPDATE Customers"+Environment.NewLine+
                    "SET City=@c1 ,Country=@c2 "+Environment.NewLine+
                    "Where CustomerID=@c3"/*sqlcb.GetUpdateCommand()*/;
                DA.UpdateCommand.Parameters.Add("@c3", SqlDbType.NChar,5, "CustomerID");
                DA.UpdateCommand.Parameters.Add("@c1", SqlDbType.NChar, 5, "City");
                DA.UpdateCommand.Parameters.Add("@c2", SqlDbType.NChar, 5, "Country");
                DA.UpdateCommand.Parameters["@c3"].SourceVersion = DataRowVersion.Original;

                DA.Update(ds);
            }
            else if (str == "2")
            {
                Console.WriteLine(dtr2[0].ToString() + "\t" + dtr2[1].ToString() + "\t" + dtr2[2].ToString());
                //cnn.Close();
            }
            cnn.Close();

        }
    }
}
