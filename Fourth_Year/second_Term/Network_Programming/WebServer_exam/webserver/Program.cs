using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace webserver
{
    class Program
    {
        TcpListener server;
        Thread thrAccept;
        string htmlPage;
        string httpResponse;
        byte[] bResponse;
        public Program()
        {
            server = new TcpListener(80);
            server.Start();
            htmlPage = "<html><head></head><body>Hello World !!!</body></html>";
            //the minimum headers required 
            //note colon : is adjacent to header name if space exists it won't be valid response 
            httpResponse = "HTTP/1.1 200 OK\r\n";
            httpResponse += "Server: Hosh\r\n";
            httpResponse += "connection: close";
            httpResponse += "Content-Type: text/html\r\n";
            httpResponse += "Content-Length: " + htmlPage.Length + "\r\n";
            httpResponse +="\r\n";
            httpResponse += htmlPage;
            bResponse = Encoding.ASCII.GetBytes(httpResponse);
            thrAccept = new Thread(new ThreadStart(AcceptClients));
            thrAccept.IsBackground = true;//so it terminate when main thread terminate
            thrAccept.Start();

        }
        private void AcceptClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                ThreadPool.QueueUserWorkItem(new WaitCallback(HandleConnection), client);
            }
        }
        private void HandleConnection(object ob)
        {
            TcpClient client = (TcpClient)ob;
            NetworkStream ns = client.GetStream();
            byte[] b = new byte[100];
            ns.Read(b, 0, b.Length);
            string s = Encoding.ASCII.GetString(b);
            ns.Write(bResponse, 0, bResponse.Length);
            ns.Flush();
            ns.Close();
            client.Close(); //if u want to close client then put in header connection: close
            //if u make close and didn't specify connection: close then it won't give response in IE
        }
        static void Main(string[] args)
        {
            Program p = new Program();//calling constructor initialize server and start accepting
            Console.WriteLine("WebServer is running on port 80 try write 127.0.0.1 on browser");
            Console.WriteLine("Press any key to quit");
            Console.Read();
        }
    }
}
