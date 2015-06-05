using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TestBrowseClient1
{
    class ClientClass
    {
        public TcpClient Client;
        BinaryReader br;
        BinaryWriter bw;

        public ClientClass()
        {
            Client = new TcpClient();
        }
        public delegate void ClientConnected();
        public event ClientConnected OnClientConnected;

        public delegate void DataRecieved(string Data);
        public event DataRecieved OnDataRecieved;

        public delegate void ErrorCatched(string data);
        public event ErrorCatched OnErrorCatched;

        public delegate void ClientDissConnected();
        public event ClientDissConnected OnClientDissConnected;

        public void Connect(object state)
        {
            while (true)
            {
                if (!Client.Connected)
                {
                    try
                    {

                        Client.Connect("FCIS", 9875);
                        OnClientConnected();
                        ThreadPool.QueueUserWorkItem(new WaitCallback(RetrieveData), null);
                        break;
                        //Thread.Sleep(10000);
                    }
                    catch (Exception ex) { Thread.Sleep(5000); }
                }
                else
                {
                    Thread.Sleep(5000); 
                }
                
            }
        }
        public void RetrieveData(object state)
        {
            br=new BinaryReader(Client.GetStream());
            while (true)
            {
                try
                {
                    string str = br.ReadString();
                    OnDataRecieved(str);
                }
                catch (IOException exx) { OnClientDissConnected(); break; }
                catch (Exception ex) { OnErrorCatched(ex.Message); }
            }
        }
        public void SendMessage(string msg)
        {
            if (Client.Connected)
            {
                try
                {
                    bw = new BinaryWriter(Client.GetStream());
                    bw.Write(msg);
                }
                catch (IOException exx) { OnClientDissConnected(); }
                catch (Exception ex) { OnErrorCatched(ex.Message); }
            }
        }

    }
}
