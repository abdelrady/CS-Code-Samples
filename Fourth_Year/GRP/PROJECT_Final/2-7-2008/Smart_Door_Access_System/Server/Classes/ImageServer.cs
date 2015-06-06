using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace SmartDoor.Classes
{
    class ImageServer
    {
        public ImageServer(int port)
        {
            TcpListener tcpl = new TcpListener(port);
            tcpl.Start();

        }
    }
}
