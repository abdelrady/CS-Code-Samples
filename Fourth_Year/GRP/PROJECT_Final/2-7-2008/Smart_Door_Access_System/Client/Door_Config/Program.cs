using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SmartDoor
{
    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();

            LoginToConfiguration cl = new LoginToConfiguration();
            if (cl.ShowDialogModel() == true)
            {
                Application.Run(new Door_Config(cl.Password));
            }

        } 

            
    }
}
