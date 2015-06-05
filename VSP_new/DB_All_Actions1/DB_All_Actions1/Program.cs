/*
  UsingIdentityColumn.cs illustrates how to retrieve
  the ProductID indentity value from a newly added row in the
  Products table
*/

using System;
using System.Data;
using System.Data.SqlClient;

class UsingIdentityCOlumn
{
    public static void DisplayDataRow(
      DataRow myDataRow, DataTable myDataTable
    )
    {
        Console.WriteLine("\nIn DisplayDataRow()");
        foreach (DataColumn myDataColumn in myDataTable.Columns)
        {
            Console.WriteLine(myDataColumn + " = " +
              myDataRow[myDataColumn]);
        }
    }

    public static int AddDataRow(
      DataTable myDataTable,
      SqlDataAdapter mySqlDataAdapter,
      SqlConnection mySqlConnection
    )
    {
        Console.WriteLine("\nIn AddDataRow()");

        // use the NewRow() method of the DataTable to
        // create a new DataRow
        Console.WriteLine("Calling myDataTable.NewRow()");
        DataRow myNewDataRow = myDataTable.NewRow();
        Console.WriteLine("myNewDataRow.RowState = " +
          myNewDataRow.RowState);

        // set the values for the DataColumn objects of
        // the new DataRow
        myNewDataRow["ProductName"] = "Widget";
        myNewDataRow["UnitPrice"] = 10.99;

        // use the Add() method through the Rows property
        // to add the new DataRow to the DataTable
        Console.WriteLine("Calling myDataTable.Rows.Add()");
        myDataTable.Rows.Add(myNewDataRow);
        Console.WriteLine("myNewDataRow.RowState = " +
          myNewDataRow.RowState);
        Console.WriteLine("myNewDataRow[\"ProductID\"] = " +
          myNewDataRow["ProductID"]);

        // use the Update() method to push the new
        // row to the database
        Console.WriteLine("Calling mySqlDataAdapter.Update()");
        mySqlConnection.Open();
        int numOfRows = mySqlDataAdapter.Update(myDataTable);
        mySqlConnection.Close();
        Console.WriteLine("numOfRows = " + numOfRows);
        Console.WriteLine("myNewDataRow.RowState = " +
          myNewDataRow.RowState);
        Console.WriteLine("myNewDataRow[\"ProductID\"] = " +
          myNewDataRow["ProductID"]);

        DisplayDataRow(myNewDataRow, myDataTable);

        // return the ProductID of the new DataRow
        return (int)myNewDataRow["ProductID"];
    }

    public static void ModifyDataRow(
      DataTable myDataTable,
      int productID,
      SqlDataAdapter mySqlDataAdapter,
      SqlConnection mySqlConnection
    )
    {
        Console.WriteLine("\nIn ModifyDataRow()");

        // use the Find() method to locate the DataRow
        // in the DataTable using the primary key value
        DataRow myEditDataRow = myDataTable.Rows.Find(productID);

        // change the DataColumn values of the DataRow
        myEditDataRow["ProductName"] = "Advanced Widget";
        myEditDataRow["UnitPrice"] = 24.99;
        Console.WriteLine("myEditDataRow.RowState = " +
          myEditDataRow.RowState);
        Console.WriteLine("myEditDataRow[\"ProductID\", " +
          "DataRowVersion.Original] = " +
          myEditDataRow["ProductID", DataRowVersion.Original]);
        Console.WriteLine("myEditDataRow[\"ProductName\", " +
          "DataRowVersion.Original] = " +
          myEditDataRow["ProductName", DataRowVersion.Original]);
        Console.WriteLine("myEditDataRow[\"UnitPrice\", " +
          "DataRowVersion.Original] = " +
          myEditDataRow["UnitPrice", DataRowVersion.Original]);
        Console.WriteLine("myEditDataRow[\"ProductName\", " +
          "DataRowVersion.Current] = " +
          myEditDataRow["ProductName", DataRowVersion.Current]);
        Console.WriteLine("myEditDataRow[\"UnitPrice\", " +
          "DataRowVersion.Current] = " +
          myEditDataRow["UnitPrice", DataRowVersion.Current]);

        // use the Update() method to push the update
        // to the database
        Console.WriteLine("Calling mySqlDataAdapter.Update()");
        mySqlConnection.Open();
        int numOfRows = mySqlDataAdapter.Update(myDataTable);
        mySqlConnection.Close();
        Console.WriteLine("numOfRows = " + numOfRows);
        Console.WriteLine("myEditDataRow.RowState = " +
          myEditDataRow.RowState);

        DisplayDataRow(myEditDataRow, myDataTable);
    }

    public static void RemoveDataRow(
      DataTable myDataTable,
      int productID,
      SqlDataAdapter mySqlDataAdapter,
      SqlConnection mySqlConnection
    )
    {
        Console.WriteLine("\nIn RemoveDataRow()");

        // use the Find() method to locate the DataRow
        DataRow myRemoveDataRow = myDataTable.Rows.Find(productID);

        // use the Delete() method to remove the DataRow
        Console.WriteLine("Calling myRemoveDataRow.Delete()");
        myRemoveDataRow.Delete();
        Console.WriteLine("myRemoveDataRow.RowState = " +
          myRemoveDataRow.RowState);

        // use the Update() method to push the delete
        // to the database
        Console.WriteLine("Calling mySqlDataAdapter.Update()");
        mySqlConnection.Open();
        int numOfRows = mySqlDataAdapter.Update(myDataTable);
        mySqlConnection.Close();
        Console.WriteLine("numOfRows = " + numOfRows);
        Console.WriteLine("myRemoveDataRow.RowState = " +
          myRemoveDataRow.RowState);
    }

    public static void Main()
    {
        SqlConnection mySqlConnection =
          new SqlConnection(
            "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=fcis"
          );

        // create a SqlCommand object to hold the SELECT
        SqlCommand mySelectCommand = mySqlConnection.CreateCommand();
        mySelectCommand.CommandText =
          "SELECT " +
          "  ProductID, ProductName, UnitPrice " +
          "FROM Products " +
          "ORDER BY ProductID";

        // create a SqlCommand object to hold the call to the
        // AddProduct4() stored procedure
        SqlCommand myInsertCommand = mySqlConnection.CreateCommand();
        myInsertCommand.CommandText =
          "INSERT INTO Products (" +
          "  ProductName, UnitPrice " +
          ") VALUES (" +
          "  @MyProductName, @MyUnitPrice" +
          ");" +
          "SELECT @MyProductID = SCOPE_IDENTITY();";
        myInsertCommand.Parameters.Add(
          "@MyProductName", SqlDbType.NVarChar, 40, "ProductName");
        myInsertCommand.Parameters.Add(
          "@MyUnitPrice", SqlDbType.Money, 0, "UnitPrice");
        myInsertCommand.Parameters.Add("@MyProductID", SqlDbType.Int,0, "ProductID");
        myInsertCommand.Parameters["@MyProductID"].Direction =ParameterDirection.Output;

        // create a SqlCommand object to hold the call to the
        // UpdateProduct() stored procedure
        SqlCommand myUpdateCommand = mySqlConnection.CreateCommand();
        myUpdateCommand.CommandText =
          "UPDATE Products " +
          "SET " +
          "  ProductName = @NewProductName, " +
          "  UnitPrice = @NewUnitPrice " +
          "WHERE ProductID = @OldProductID " +
          "AND ProductName = @OldProductName " +
          "AND UnitPrice = @OldUnitPrice";
        myUpdateCommand.Parameters.Add(
          "@NewProductName", SqlDbType.NVarChar, 40, "ProductName");
        myUpdateCommand.Parameters.Add(
          "@NewUnitPrice", SqlDbType.Money, 0, "UnitPrice");
        myUpdateCommand.Parameters.Add(
          "@OldProductID", SqlDbType.Int, 0, "ProductID");
        myUpdateCommand.Parameters.Add(
          "@OldProductName", SqlDbType.NVarChar, 40, "ProductName");
        myUpdateCommand.Parameters.Add(
          "@OldUnitPrice", SqlDbType.Money, 0, "UnitPrice");
        myUpdateCommand.Parameters["@OldProductID"].SourceVersion =
          DataRowVersion.Original;
        myUpdateCommand.Parameters["@OldProductName"].SourceVersion =
          DataRowVersion.Original;
        myUpdateCommand.Parameters["@OldUnitPrice"].SourceVersion =
          DataRowVersion.Original;

        // create a SqlCommand object to hold the call to the
        // DeleteProduct() stored procedure
        SqlCommand myDeleteCommand = mySqlConnection.CreateCommand();
        myDeleteCommand.CommandText =
          "DELETE FROM Products " +
          "WHERE ProductID = @OldProductID " +
          "AND ProductName = @OldProductName " +
          "AND UnitPrice = @OldUnitPrice";
        myDeleteCommand.Parameters.Add(
          "@OldProductID", SqlDbType.Int, 0, "ProductID");
        myDeleteCommand.Parameters.Add(
          "@OldProductName", SqlDbType.NVarChar, 40, "ProductName");
        myDeleteCommand.Parameters.Add(
          "@OldUnitPrice", SqlDbType.Money, 0, "UnitPrice");
        myDeleteCommand.Parameters["@OldProductID"].SourceVersion =
          DataRowVersion.Original;
        myDeleteCommand.Parameters["@OldProductName"].SourceVersion =
          DataRowVersion.Original;
        myDeleteCommand.Parameters["@OldUnitPrice"].SourceVersion =
          DataRowVersion.Original;

        // create a SqlDataAdapter and set its properties
        // to the SqlCommand objects previously created
        SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter();
        mySqlDataAdapter.SelectCommand = mySelectCommand;
        mySqlDataAdapter.InsertCommand = myInsertCommand;
        mySqlDataAdapter.UpdateCommand = myUpdateCommand;
        mySqlDataAdapter.DeleteCommand = myDeleteCommand;

        // create a DataSet and fill it using the Fill() method
        DataSet myDataSet = new DataSet();
        mySqlConnection.Open();
        Console.WriteLine("Calling mySqlDataAdapter.Fill()");
        int numOfRows =
          mySqlDataAdapter.Fill(myDataSet, "Products");
        mySqlConnection.Close();
        Console.WriteLine("numOfRows = " + numOfRows);

        // read the Products DataTable from myDataSet
        DataTable productsDataTable = myDataSet.Tables["Products"];

        // set the PrimaryKey property of productsDataTable
        productsDataTable.PrimaryKey =
          new DataColumn[]
      {
        productsDataTable.Columns["ProductID"]
      };

        // set the AllowDBNull, AutoIncrement, AutoIncrementSeed,
        // AutoIncrementStep, ReadOnly, and Unique properties for
        // the ProductID DataColumn of the Products DataTable
        DataColumn productIDDataColumn =
          productsDataTable.Columns["ProductID"];
        productIDDataColumn.AllowDBNull = false;
        productIDDataColumn.AutoIncrement = true;
        productIDDataColumn.AutoIncrementSeed = -1;
        productIDDataColumn.AutoIncrementStep = -1;
        productIDDataColumn.ReadOnly = true;
        productIDDataColumn.Unique = true;

        // add a new row to productsDataTable
        int productID =
          AddDataRow(productsDataTable, mySqlDataAdapter,
            mySqlConnection);

        // modify the new row in productsDataTable
        ModifyDataRow(productsDataTable, productID,
          mySqlDataAdapter, mySqlConnection);

        // remove the new row from productsDataTable
        RemoveDataRow(productsDataTable, productID,
          mySqlDataAdapter, mySqlConnection);
    }
}