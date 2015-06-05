using System;
using System.Collections.Generic;
using System.Text;
using Server;

namespace Windows_Firwall_Control
{
    class Program
    {
        static void Main(string[] args)
        {

            WinXPSP2FireWall FireWall = new WinXPSP2FireWall();
            FireWall.Initialize();
            /*FireWall.AddApplication(@"D:\Final Project\Server\Server\bin\Debug\Server.exe", "_server");
            FireWall.AddApplication(@"D:\Final Project\Client_last\Client\bin\Debug\Client.exe", "Client");
            FireWall.AddPort(8000, NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP, "port : " + 8000);*/
            FireWall.TurnOnWindowsFirewall();//.TurnOffWindowsFirewall();
        }
    }
}
