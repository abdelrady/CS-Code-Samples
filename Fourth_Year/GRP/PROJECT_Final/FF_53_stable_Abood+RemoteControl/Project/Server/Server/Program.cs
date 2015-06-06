using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SmartDoor
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.Run(new login());
                Application.Run(new ServerFRM());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Data + "\n" + Ex.Message + "\n" + Ex.Source + "\n" + Ex.TargetSite + "\n" + Ex.StackTrace);
            }
        }
    }
}
