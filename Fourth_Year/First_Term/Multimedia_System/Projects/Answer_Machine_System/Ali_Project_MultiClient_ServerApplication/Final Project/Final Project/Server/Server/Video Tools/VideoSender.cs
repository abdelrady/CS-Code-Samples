using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Server.Properties;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace Server
{
    class VideoSender
    {
        private BinaryWriter mysw;
        private NetworkStream myns;
        private TcpClient myclient;
        private MemoryStream ms;
        private string iptostartVChat = "";
        private int videoSentchatPort = 0;
        private int hHwnd;
        public bool StoppedOfSending = false;

        private const short WM_CAP = 1024;
        private const int WM_CAP_EDIT_COPY = WM_CAP + 30;
        PictureBox LocalView = null;

        System.Windows.Forms.Timer capture;

        [DllImport("user32", EntryPoint = "SendMessageA")]
        static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] 
			object lParam);
        public VideoSender(string ip, int port, PictureBox PICV, int m_Handel)
        {
            Clipboard.Clear();

            LocalView = PICV;
            hHwnd = m_Handel;
            iptostartVChat = ip;
            videoSentchatPort = port;

            capture = new System.Windows.Forms.Timer();
            capture.Interval = 100;
            capture.Enabled = true;
            capture.Tick += new EventHandler(capture_Tick);
            capture.Start();
        }

        void capture_Tick(object sender, EventArgs e)
        {
            Start_Sending_Video_Conference();
        }
        public void Start_Sending_Video_Conference()
        {

            if (StoppedOfSending) return;

            try
            {
                ms = new MemoryStream();// Store it in Binary Array as Stream

                IDataObject data;
                Image bmp;

                //  Copy image to clipboard
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);

                //  Get image from clipboard and convert it to a bitmap
                data = Clipboard.GetDataObject();

                if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
                {
                    bmp = ((Image)(data.GetData(typeof(System.Drawing.Bitmap))));
                    bmp.Save(ms, ImageFormat.Bmp);
                }

                // new VideoRcver(ClientVEW.Items[ClientVEW.SelectedIndices[0]].SubItems[2].Text, 6000).ShowDialog();
                LocalView.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrImage = ms.GetBuffer();
                myclient = new TcpClient(iptostartVChat, videoSentchatPort);//Connecting with server
                myns = myclient.GetStream();
                mysw = new BinaryWriter(myns);
                mysw.Write(arrImage);//send the stream to above address

                ms.Flush();
                mysw.Flush();
                myns.Flush();
                ms.Close();
                mysw.Close();
                myns.Close();
                myclient.Close();
            }
            catch //(Exception ex)
            {
               // MessageBox.Show(ex.Message, "Video Conference Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
