using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartDoor
{
    class Program
    {
        [STAThread]
        static void Main()
        {
           
                Application.EnableVisualStyles();       
                string uname="";
                SqlConnection Connection = null;
            try
            {
                login.ShowThis(ref uname, ref Connection);
                Application.Run(new ServerFRM(uname, Connection));
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Data + "\n" + Ex.Message + "\n" + Ex.Source + "\n" + Ex.TargetSite + "\n" + Ex.StackTrace);
            }
        }
    }
}
