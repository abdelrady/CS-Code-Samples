using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace sql_pools_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a SqlConnection object to connect to the database,
            // setting max pool size to 10 and min pool size to 5
            SqlConnection mySqlConnection =
              new SqlConnection(
                @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=.\SQLEXPRESS" 
//                "max pool size=10;min pool size=5"
              );

            // open the SqlConnection object 10 times
            for (int count = 1; count <= 10; count++)
            {
                Console.WriteLine("count = " + count);

                // create a DateTime object and set it to the
                // current date and time
                DateTime start = DateTime.Now;

                // open the database connection using the
                // Open() method of the SqlConnection object
                mySqlConnection.Open();

                // subtract the current date and time from the start,
                // storing the difference in a TimeSpan
                TimeSpan timeTaken = DateTime.Now - start;

                // display the number of milliseconds taken to open
                // the connection
                Console.WriteLine("Milliseconds = " + timeTaken.Milliseconds);

                // display the connection state
                Console.WriteLine("mySqlConnection.State = " +
                 mySqlConnection.State);

                // close the database connection using the Close() method
                // of the SqlConnection object
                mySqlConnection.Close();
                SqlDataReader ss;
                
            }
        }
    }
}
