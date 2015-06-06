using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Collections;
using System.Threading;

namespace SocketTest1
{
    class Program
    {
       static byte[] dataRecieved = new byte[1024];

        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(new IPEndPoint(IPAddress.Any,8080));
             sock.Listen(5);
            Socket client= sock.Accept();
            //Socket client2 = sock.Accept();
            //Socket client3 = sock.Accept();

            Console.WriteLine(client.RemoteEndPoint.ToString());

            //ArrayList ar = new ArrayList();
            //ar.Add(client); ar.Add(client2); ar.Add(client3);
            //Thread.Sleep(2000);
            //Socket.Select(ar, ar, null, 100000);
            
            Console.WriteLine("Select Executed");

            /*try
            {
                client.Blocking = false;
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }*/
            client.Blocking = true;
            int y = 0;
            while (true) 
            {
                //byte[] count=new byte[4];
                //y= client.Receive(count);
                //if (y == 0){Console.WriteLine("Client Disconnected..."); break;}
                //int x= BitConverter.ToInt32(count,0);
                dataRecieved = new byte[1024];
                y=client.Receive(dataRecieved);
                if (y == 0) { Console.WriteLine("Client Disconnected..."); break; }
                string str = Encoding.Default.GetString(dataRecieved, 0, y);
                //str = str.Replace("\r\n", string.Empty);
                Console.Write("\r\n#"+y.ToString()+": ");
                Console.Write(str.TrimEnd(new char[]{(char)(0)}));
                
                //Thread.Sleep(1000);
            }

            /*foreach (Socket so in ar)
            {
                so.BeginReceive(dataRecieved,0,dataRecieved.Length,0,new AsyncCallback(onDataRecieved),so);

                //Console.WriteLine(so.RemoteEndPoint.ToString()+"  :  " +Encoding.Default.GetString(dataRecieved, 0, x));
            }*/

           /*
            //client.Send(Encoding.Default.GetBytes("Hello world...."));
            string ipRemote = client.RemoteEndPoint.ToString().Split(new char[] { ':' }).GetValue(0).ToString();
            string PortRemote = client.RemoteEndPoint.ToString().Split(new char[] { ':' }).GetValue(1).ToString();
            EndPoint RemoteIp = new IPEndPoint(IPAddress.Parse(ipRemote), int.Parse(PortRemote));
            client.SendTo(Encoding.Default.GetBytes("Hello world...."),RemoteIp);
           //Console.WriteLine(sock.RemoteEndPoint.ToString());
            string strDataRecieved = "";
            int count = 0;
            //while (true)
            {
                if(client.Connected)
                //try
                {
                    client.BeginReceive(dataRecieved,0,dataRecieved.Length,SocketFlags.None,new AsyncCallback(onDataRecieved), client);
                    
                }
                else
                //catch
                {
                    Console.WriteLine("client Disconnected....");
                    
                }
                //strDataRecieved = Encoding.Default.GetString(dataRecieved, 0, count);
                //if (strDataRecieved == "-1") break;
                //Console.WriteLine(strDataRecieved);
                //client.Send(dataRecieved, count, SocketFlags.None);
                
            }
            //client.Shutdown(SocketShutdown.Both);
            //client.Close();
            */
            new AutoResetEvent(false).WaitOne();
        }
        static void onDataRecieved(IAsyncResult ar)
        {
            Socket client = (Socket)ar.AsyncState;
            try
            {
                if (client.Connected)
                {
                    int count = client.EndReceive(ar);

                    if (count == 0) { Console.WriteLine("client Disconnected2...."+count.ToString()); }
                    lock (ar.AsyncState)
                    {
                        Console.WriteLine(Encoding.Default.GetString(dataRecieved, 0, count));
                    }

                    client.Send(dataRecieved, count, SocketFlags.None);

                    client.BeginReceive(dataRecieved, 0, dataRecieved.Length, SocketFlags.None, new AsyncCallback(onDataRecieved), client);
                }
                else
                {
                    Console.WriteLine("client Disconnected....");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.Data);
            }

        }
    }
}
