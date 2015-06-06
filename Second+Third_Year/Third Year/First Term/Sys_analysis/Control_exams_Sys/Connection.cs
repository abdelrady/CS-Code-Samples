using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public class Connection
    {
        public OleDbConnection MyConnection;
        
        public Connection()
        {
            try
            {
                MyConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=control_room.mdb");
                MyConnection.Open();
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Error: Database not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }	
        }

    }
}
