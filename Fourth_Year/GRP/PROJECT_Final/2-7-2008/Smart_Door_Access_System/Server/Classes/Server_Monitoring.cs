using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Drawing;

namespace SmartDoor
{
    class Server_Monitoring
    {
        TcpListener Server;
        TcpClient Client;
        ServerFRM ServerFrm;
        Thread MonitorThread;
        public bool CamMonitoring = true;
        bool Recieve = true;
        bool ResumeRecieveing = true;
        bool StopMonitoring = false;
        public delegate void SetImage(Image I);
        public event SetImage SetPicture;
        public delegate void SychDataRecieved(string Data);
        public event SychDataRecieved sychDataRecieved;

        public delegate void SychClientDisconnected(string Data);
        public event SychClientDisconnected sychClientDissconnected;

        public delegate void SychClientErrorCatched(string Data);
        public event SychClientErrorCatched OnSychClientErrorCatched;
        
        VideoFrm videoform = null;
        public Server_Monitoring(VideoFrm vf) { videoform = vf; }
        public void Start()
        {
            Server = new TcpListener(8000);
            Server.Start();
            MonitorThread = new Thread(new ThreadStart(Accept));
            MonitorThread.Start();
        }
        public void Pause()
        {
            //MonitorThread.Suspend();
            //Send("[#<CMD>#][#Pause#]");
            ResumeRecieveing = false;
            Send("[#<CMD>#][#Pause#][#][#Camera#][#]" + CamMonitoring);
        }
        public void Resume()
        {
            //Send("[#<CMD>#][#Resume#]");
            //MonitorThread.Resume();
            ResumeRecieveing = true;
        }
        public void Close()
        {
            lock (this) { Recieve = false; StopMonitoring = true; }
            //MonitorThread.Join();
            //MonitorThread.Abort();
            Server.Stop();
            Server = null;
        }

        public void Send(string msg)
        {
            //MonitorThread.Suspend();
            try
            {
                BinaryWriter bw = new BinaryWriter(Client.GetStream(), Encoding.Default);
                bw.Write(msg);
            }
            catch (IOException EX) { sychClientDissconnected(EX.Message); return; }
            //MonitorThread.Resume();
        }

        public void Accept()
        {

            string str;

            Client = Server.AcceptTcpClient();
            BinaryReader br = new BinaryReader(Client.GetStream(), Encoding.Default);
            BinaryWriter bw = new BinaryWriter(Client.GetStream(), Encoding.Default);
            try
            {
                str = br.ReadString();//read remote screen info
                sychDataRecieved(str);
            }
            catch (IOException ex) { sychClientDissconnected(ex.Message); return; }
            catch (Exception ex) { OnSychClientErrorCatched(ex.Message); }

            if (CamMonitoring)
            {
                bw.Write("[#<CMD>#][#Start#][#][#Camera#][#]" + CamMonitoring);
            }

            while (true)
            {
                if (StopMonitoring)
                {
                    try
                    {
                        bw.Write("[#<CMD>#][#EndSession#][#]");
                        bw.Flush();
                        bw.Close();
                        Client.Close();
                        return;
                    }
                    catch (IOException ex) { sychClientDissconnected(ex.Message); return; }
                }
                if (ResumeRecieveing)
                {
                    try
                    {
                        bw.Write("[#<CMD>#][#Resume#][#][#Camera#][#]" + CamMonitoring + "[#]" + videoform.barQuality.Value.ToString() + "[#]");
                        bw.Flush();
                        str = br.ReadString();
                        sychDataRecieved(str);
                        Thread.Sleep(100);
                    }
                    catch (IOException ex)
                    {
                        sychClientDissconnected(ex.Message);
                        return;
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                }

                /*if (!Recieve)
                {
                    bw.Write("Pause");
                    bw.Flush();
                }
                else if (StopMonitoring)
                {
                    bw.Write("Stop");
                    bw.Flush();
                    bw.Close();
                    client.Close();
                    return;
                }
                else
                {
                    bw.Write("Resume");
                    bw.Flush();
                    string str = br.ReadString();
                    SetPicture(Image.FromStream(new MemoryStream(Encoding.Default.GetBytes(str))));
                }*/
            }
        }
    }
}
