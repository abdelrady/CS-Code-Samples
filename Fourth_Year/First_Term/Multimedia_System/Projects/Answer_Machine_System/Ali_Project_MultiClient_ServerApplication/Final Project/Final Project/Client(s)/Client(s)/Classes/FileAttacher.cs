using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;
using Client_s_.Classes;

namespace NetUtility
{
    class FileAttacher
    {
        private Socket connection;
        private NetworkStream socketStream;
        private BinaryWriter writer;
        private BinaryReader reader;
        private TcpClient client;
        private TcpListener listener;
        private Form parent;     
        public Form Parent
        {
            set { parent = value; }
            get { return parent; }
        }

        //Rcv Attr
        private string ip;
        public string IP
        {
            set { ip = value; }
        }
        private string destination;
        public string Destination
        {
            set { destination = value; }
        }

        private string senderClient;
        public string SenderClient
        {
            set { senderClient = value; }
            get { return senderClient; }
        }
        //send Attr     

        private string fileName;
        public string FileName
        {
            set { fileName = value; }
        }

        public  void SendFile()
        {
            try
            {
                listener = new TcpListener(2000);
                listener.Start();
                while (true)
                {
                    connection = listener.AcceptSocket();
                    socketStream = new NetworkStream(connection);
                    writer = new BinaryWriter(socketStream);
                    try
                    {
                        FileStream file = File.Open(fileName, FileMode.Open);//1*open
                        if (file.Length >= 250000000)
                        {
                            MessageBox.Show(Parent, "File too big.", parent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                          
                            return;
                        }
                        writer.Write(file.Length.ToString());//2*send length
                        writer.Write(Path.GetFileName(fileName));//3*send name
                        byte[] SentBuffer = new byte[file.Length];//4*initiate buffer
                        file.Read(SentBuffer, 0, (int)file.Length);//5*read content
                        writer.Write(SentBuffer);//6*send content
                        file.Close();//7*close

                        socketStream.Close();
                        connection.Close();
                        writer.Close();

                        listener = null;
                        writer = null;
                        connection = null;
                        socketStream = null;
                        GC.Collect();
                        Thread.CurrentThread.Abort();
                        return;
                     
                    }
                    catch //(Exception e)
                    { 
                       // MessageBox.Show(parent,"Error sending file\n"+e.Message, parent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch //(Exception error)
            {
               // MessageBox.Show(error.ToString());                
            } 
            
        }

        public  void RecieveFile()
        {
            try
            {
                client = new TcpClient();
                client.Connect(ip, 2001);
                reader = new BinaryReader(client.GetStream());                
                string sizeStr = reader.ReadString();//1*read size
                int intSize = int.Parse(sizeStr);//2*parse size
                string FileName = reader.ReadString();//3*read file name
                string path = new Download().Show(SenderClient, FileName, intSize);
                if (path != string.Empty)
                {
                    byte[] RecVBuffer = new byte[intSize];//4*initiate buffer
                    RecVBuffer = reader.ReadBytes(intSize);//5*read content
                    FileStream file = File.Create(path);
                    file.Write(RecVBuffer, 0, intSize);
                    file.Close();
                    MessageBox.Show(Parent, "File receiving finished.", parent.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reader.Close();
                    client.Close();
                    reader = null;
                    client = null;
                    GC.Collect();
                    Thread.CurrentThread.Abort();
                    return;
                }
                
            }
            catch// (Exception e)
            {
              //  MessageBox.Show(parent, "Error\n" + e.Message, parent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}