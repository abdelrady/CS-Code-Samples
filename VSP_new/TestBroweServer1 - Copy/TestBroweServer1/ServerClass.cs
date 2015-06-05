using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace TestBroweServer1
{
    class ServerClass
    {
        TcpListener Server = new TcpListener(9875);
        TcpClient Client;


        public delegate void ClientConnected(string RemoteIP);
        public event ClientConnected OnClientConnected;

        public delegate void DataRecieved(string Data);
        public event DataRecieved OnDataRecieved;

        public delegate void ErrorCatched(string Error);
        public event ErrorCatched OnErrorCatched;

        public delegate void ClientDissConnected(string Error);
        public event ClientDissConnected OnClientDissConnected;


        public void Listen(object state)
        {
            Server.Start();
            Client = Server.AcceptTcpClient();
            OnClientConnected(Client.Client.RemoteEndPoint.ToString());
            new Thread(new ParameterizedThreadStart(Retrieve)).Start(Client);
        }
        public void SendMessage(string msg)
        {
            try
            {
                BinaryWriter bw = new BinaryWriter(Client.GetStream());
                bw.Write(msg);
            }
            catch (IOException exx) { OnClientDissConnected(exx.Message); }
            catch (Exception ex) { OnErrorCatched(ex.Message); }
        }
        void Retrieve(object state)
        {
            TcpClient client = (TcpClient)state;
            BinaryReader br = new BinaryReader(client.GetStream());
            while (true)
            {
                try
                {
                    string data = br.ReadString();
                    OnDataRecieved(data);
                }
                catch (IOException exx) { OnClientDissConnected(exx.Message); return; }
                catch (Exception ex) { OnErrorCatched(ex.Message); }
            }
        }
        public void Disconnect()
        {
            if (Client.Connected)
            {
                try
                {
                    this.Client.Close();
                    //this.Server.Stop();
                    OnClientDissConnected("Client Disconnected Successfuly.");
                }
                catch (Exception ex) { OnClientDissConnected(ex.Message); }
            }
        }

    }
}
