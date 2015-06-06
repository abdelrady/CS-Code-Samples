using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChatClient
{
    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Client());
        }
    }
}
