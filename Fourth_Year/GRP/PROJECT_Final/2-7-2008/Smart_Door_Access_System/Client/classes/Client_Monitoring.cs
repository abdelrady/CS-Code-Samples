using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace SmartDoor
{
    class Client_Monitoring
    {
        public Client_Monitoring(ClientFrm client)
        {
            Clientfrm = client;            
        }
        Direct.Media.Video.VGrabber camObj = new Direct.Media.Video.VGrabber();
        MemoryStream camStream = new MemoryStream();
        ClientFrm Clientfrm;
        TcpClient Client;
        long Quality = 10;
        public void Start()
        {
            new Thread(new ThreadStart(Send_Recieve)).Start();
        }
        public void close()
        {
            try
            {
                if (Client.Connected)
                {
                    Client.Close();
                }
            }
            catch (IOException ex)
            {
                return;
            }
        }
        void Send_Recieve()
        {
            Client = new TcpClient();
            Client.Connect(Configuration.ServerIP, 8000);
            BinaryReader br = new BinaryReader(Client.GetStream(), Encoding.Default);
            BinaryWriter bw = new BinaryWriter(Client.GetStream(), Encoding.Default);
            //Clientfrm.Log("Connected to Port 8000", Color.Black);
            
            try
            {
                bw.Write("[#<CMD>#][#Information#][#]" + Screen.PrimaryScreen.Bounds.Width.ToString() + "[#]" + Screen.PrimaryScreen.Bounds.Height.ToString() + "[#]");
            }
            catch (IOException ex) { close(); return; }

            string msg;
            while (true)
            {
                msg = br.ReadString();
                //Clientfrm.Log(msg, Color.Black);
                if (msg.StartsWith("[#<CMD>#]"))
                {
                    msg=msg.Remove(0, "[#<CMD>#]".Length);
                    string[] CmdArg = msg.Split(new string[] { "[#]" },StringSplitOptions.RemoveEmptyEntries);
                    switch (CmdArg[0])
                    {
                        case "[#Start#]":
                            if (CmdArg[1] == "[#Camera#]" && CmdArg[2].ToLower() == "true")
                            {
                                   try { camObj.IntializeCamera(0); }
                                    catch (Exception ex)
                                    {
                                        try
                                        {
                                            bw.Write("[#Error#][#]Failed to initialize camera.[#][ErrorDesc][#]" + ex.Message);
                                        }
                                        catch (IOException ex2) { close(); return; }
                                    }
                            }
                            else { }
                            break;
                        case "[#Pause#]":
                            if (CmdArg[1] == "[#Camera#]" && CmdArg[2].ToLower() =="true")
                            {
                                camObj.Pause();
                                camObj.Dispose();
                            }
                            break;
                        case "[#Stop#]":
                            if (CmdArg[1] == "[#Camera#]" && CmdArg[2].ToLower() == "false")
                            {
                                camObj.Dispose();
                            }
                            else
                            {
                                Client.Close();
                            }
                            
                            break;
                        case "[#Resume#]":
                            if (CmdArg[1] == "[#Camera#]" && CmdArg[2].ToLower() == "true")
                            {
                                camObj.Start();
                                camObj.GetImage().Save(camStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                try
                                {
                                    bw.Write(Encoding.Default.GetString(camStream.ToArray()));
                                }
                                catch (IOException ex) { close(); return; }
                                camStream.SetLength(0);
                                GC.Collect();
                            }
                            else
                            {
                                try
                                {
                                    bw.Write(Encoding.Default.GetString(SmartDoor.DesktopImage.GetDesktopImage(int.Parse(CmdArg[3]))));
                                }
                                catch (IOException ex) { close(); return; }
                            }
                            break;
                        case "[#EndSession#]":

                            camObj.Dispose();
                            close();
                            return;

                            break;
                        case "[#MouseEvents#]":
                            xPos = int.Parse(CmdArg[3]); yPos = int.Parse(CmdArg[5]);
                            SetCursorPos(xPos, yPos);

                            switch (CmdArg[7])//Button Type
                            {
                                case ("Left"):
                                    MouseBtn = MouseButtons.Left;
                                    break;
                                case ("Right"):
                                    MouseBtn = MouseButtons.Right;
                                    break;
                                case ("Middle"):
                                    MouseBtn = MouseButtons.Middle;
                                    break;
                                case ("None"):
                                    MouseBtn = MouseButtons.None;
                                    break;
                            }

                            switch (CmdArg[1])//Mouse Event Type
                            {
                                case ("[#MouseMove#]"):
                                    // Log("M Move Event", Color.Red);
                                    //mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, xPos, yPos, 0, 0);
                                    Cursor.Position = new Point(xPos, yPos);
                                    break;
                                case ("[#MouseDown#]"):
                                    //Log("M Down Event", Color.Red);
                                    if (MouseBtn == MouseButtons.Left)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Right)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Middle)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEDOWN, xPos, yPos, 0, 0);
                                    break;
                                case ("[#MouseUp#]"):
                                    //Log("M Up Event", Color.Red);
                                    if (MouseBtn == MouseButtons.Left)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Right)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTUP, xPos, yPos, 0, 0);
                                    else if (MouseBtn == MouseButtons.Middle)
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEUP, xPos, yPos, 0, 0);
                                    break;
                                case ("[#MouseClick#]"):
                                    if (MouseBtn == MouseButtons.Left)
                                    {
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, xPos, yPos, 0, 0);
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, xPos, yPos, 0, 0);
                                    }
                                    else if (MouseBtn == MouseButtons.Right)
                                    {
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN, xPos, yPos, 0, 0);
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTUP, xPos, yPos, 0, 0);
                                    }
                                    else if (MouseBtn == MouseButtons.Middle)
                                    {
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEDOWN, xPos, yPos, 0, 0);
                                        mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MIDDLEUP, xPos, yPos, 0, 0);
                                    }
                                    break;
                                case ("[#MouseDoubleClick#]"):
                                    //mouse_event(MOUSEEVENTF_MOVE, xPos, yPos, 0, 0);
                                    break;
                            }

                            break;
                    }
                }
            }
        }
        #region General Declarations
        int xPos, yPos;
        MouseButtons MouseBtn;

        [DllImport("user32.dll")]
        private static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 cButtons, Int32 dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern Int32 SetCursorPos(Int32 x, Int32 y);
        Int32 MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        Int32 MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        Int32 MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        Int32 MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        Int32 MOUSEEVENTF_RIGHTUP = 0x0010;/* right button up */
        Int32 MOUSEEVENTF_MIDDLEDOWN = 0x0020;/* middle button down */
        Int32 MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        Int32 MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        Int32 MOUSEEVENTF_XUP = 0x0100; /* x button down */
        Int32 MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        Int32 MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        Int32 MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */
        #endregion
    }
}