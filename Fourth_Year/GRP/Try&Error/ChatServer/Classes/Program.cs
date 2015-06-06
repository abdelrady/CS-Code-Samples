using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChatServer
{
    class Program
    {
        [STAThread]
        static void Main()
        {  
            Application.Run(new login());
            Application.Run(new Server());
          
        }
    }
}
