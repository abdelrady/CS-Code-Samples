using System;
using System.Collections.Generic;
using System.Text;
using Network.Client;
using System.Threading;

namespace Client_Asynchronous_Test1
{
    class Program
    {
        Client client;
        static AutoResetEvent aur;
        static void Main(string[] args)
        {
            Program p = new Program();
            aur = new AutoResetEvent(false);
            p.client= new Client();
            p.client.Connected += new Client.SocketStatusArg(client_Connected);
            p.client.DataReceived += new Client.SocketDataArg(client_DataReceived);
            p.client.Disconnected += new Client.SocketDisconnectArg(client_Disconnected);
            p.client.ErrorCatched += new Client.SocketErrorArg(client_ErrorCatched);

            p.client.Connect("192.168.2.1", 8080);
            string str = "";
            byte[] byt;
            while (true)
            {
                byt = new byte[1024];
                str = Console.ReadLine();
                Encoding.Default.GetBytes(str, 0, str.Length, byt, 0);
                if (str == "exit") break;
                p.client.SendMessage(byt);
                str = "";
                
            }
            p.client.Disconnect();
            //aur.WaitOne();
        }

        static void client_ErrorCatched(object Sender, SocketErrorEventsArg see)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        static void client_Disconnected(object Sender, SocketDisconnectEventsArg sde)
        {
            aur.Set();
            //throw new Exception("The method or operation is not implemented.");
        }

        static void client_DataReceived(object Sender, SocketDataEventsArg sde)
        {
            Console.WriteLine("Data Recieved: "+Encoding.Default.GetString( sde.Data).TrimEnd(new char[]{(char)0}));

            //throw new Exception("The method or operation is not implemented.");
        }

        static void client_Connected(object Sender, EventArgs ea)
        {
            Console.WriteLine("Connected To Server...");
            //throw new Exception("The method or operation is not implemented.");
        }
    }
}
