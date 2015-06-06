using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace sss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private Bitmap lastPic;
        private clsFaceDetectionWrapper objFaceDetector;
        private Pen myPen = new Pen(Color.Red, 2.0f);
        Graphics picGraphics;

        Thread th;
        Image img;
        IDataObject data;
        void capture()
        {
            while (true)
            {
                //  Copy image to clipboard
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);

                //  Get image from clipboard and convert it to a bitmap
                data = Clipboard.GetDataObject();
                if (data != null)
                {
                    this.Text = "data in";
                    if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
                    {
                        img = (Image)(data.GetData(typeof(System.Drawing.Bitmap)));
                        lastPic = new Bitmap(img);
                        btnDetect();

                        //              bmp.Save(ms, ImageFormat.Jpeg);
                    }
                   
                }
                Thread.Sleep(2000);
            }

        }
        int FalseCount = 0;
        private  void btnDetect()
        {

            //int firstTime = Environment.TickCount;
            if(lastPic != null)
            {
               // pictureBox2.Image = img;
                int faces = objFaceDetector.WrapDetectFaces(lastPic);
                this.Text = "Number of faces : " + faces.ToString() + " ";
                double fm;
                unsafe
                {
                    picGraphics = pictureBox2.CreateGraphics();
                    int lx, ly, rx, ry, res;
                    for(int f = 0; f < faces; f++)
                    {                        
                        objFaceDetector.WrapGetFaceCordinates(f, &lx, &ly, &rx, &ry);

                        picGraphics.DrawRectangle(myPen, lx * ((float)pictureBox2.Width / lastPic.Width),
                ly * ((float)pictureBox2.Height / lastPic.Height),
                rx * ((float)pictureBox2.Width / lastPic.Width),
                ry * ((float)pictureBox2.Height / lastPic.Height));
                        int fy = ly; 
                        int width = rx - lx;
                        int height = ry - ly;
                    
                        this.Text += " Ratio=" + ((double)width / height).ToString();

                       
                        res = objFaceDetector.WrapGetEyeCordinates(f, &lx, &ly, &rx, &ry);

                        if (res > -1)
                        {
                            //picGraphics.DrawLine(myPen, lx-5, ly, lx+5, ly);
                            //picGraphics.DrawLine(myPen, lx, ly-5, lx, ly+5);

                            //picGraphics.DrawLine(myPen, rx-5, ry, rx+5, ry);
                            //picGraphics.DrawLine(myPen, rx, ry-5, rx, ry+5);
                           /// picGraphics.DrawString("+", new Font("arial", 20.2f), new SolidBrush(Color.Red), lx * ((float)pictureBox2.Width / lastPic.Width), ly * ((float)pictureBox2.Height / lastPic.Height));
                           // picGraphics.DrawString("+", new Font("arial", 20.2f), new SolidBrush(Color.Red), rx * ((float)pictureBox2.Height / lastPic.Height), ry * ((float)pictureBox2.Height / lastPic.Height));
                            //this.Text += "D(x)" + (rx - lx).ToString();
                            int f1 = Math.Abs(fy - ly);
                            int f2 = Math.Abs(fy - ry);
                            fm = (double)(f1 + f2 )/ 2;
                            fm /= height;
                            fm *= 1000;

                            try
                            {
                                progressBar1.Value = (int)(((double)Math.Abs(Math.Min(fm, Thre)) / Math.Abs(Math.Max(fm, Thre))) * 100);
                            }
                            catch { }
                            //fm = 0;
                            this.Text += /*"  R(x) = " + ((double)(rx - lx) / width).ToString() +*/ "  V(x) = " + fm.ToString()+" "+progressBar1.Value.ToString();
                            if (profile)
                            {
                                V[trushFrames--] = fm;
                                if (trushFrames == -1)
                                {
                                    CalculateAndW();
                                    profile = false;
                                    trushFrames = 4;
                                }
                            }
                        }
                        else {
                            progressBar1.Value = 0;
                        }   
                    }
                    picGraphics.Save();
                    picGraphics.Dispose();
                    if (ScreenSaverHandler.IsScreenSaverRunning() && progressBar1.Value > 85)
                    {
                        ////Destroy Screen Saver
                        
                        ScreenSaverHandler.StopScreenSaver();
                        Thread.Sleep(1000);
                        trackBar1.Value = 2000;
                    }
                    if (progressBar1.Value < 85 && !ScreenSaverHandler.IsScreenSaverRunning())
                    {
                        FalseCount++;
                        if (FalseCount >= trackBar2.Value)
                        {
                            ScreenSaverHandler.LaunchScreenSaver();
                            trackBar1.Value = 5000;
                            Thread.Sleep(1000);
                            FalseCount = 0;
                        }
                    }
                    else
                    {
                        FalseCount = 0;
                    }
                }
            }
         //   int SecondTime = Environment.TickCount;
           // this.Text += "Within: " + (SecondTime - firstTime).ToString() + " S.";
        }

        private void CalculateAndW()
        {
            double sum = 0.0;
            for (int i = 0; i < V.Length; i++)
            {
                sum += V[i];
            }
            sum /= 5;
                sw.WriteLine(sum.ToString());
                sw.Close();

               // MessageBox.Show(sum.ToString());
                
            
        }
        FileStream f;
        double[] V = new double[5];

        double Thre;
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream f = new FileStream("Profile.txt", FileMode.Open, FileAccess.Read,FileShare.ReadWrite);
            StreamReader sw = new StreamReader(f);
            Thre = Convert.ToDouble( sw.ReadLine());
            objFaceDetector = clsFaceDetectionWrapper.GetSingletonInstance();
            //tmrPolling.Enabled = true;
           sw.Close();
           
        }
        private int hHwnd;
        private void OpenPreviewWindow()
        {
            int iHeight = 171;
            int iWidth = 219;
            // 
            //  Open Preview window in picturebox
            // 
            hHwnd =
                capCreateCaptureWindowA("0",
                (WS_VISIBLE | WS_CHILD), 0, 0, 640, 480,
                pictureBox1.Handle.ToInt32(), 0);
            // 
            //  Connect to device
            // 
            if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT,/*iDevice */0, 0) == 1)
            {
                // 
                // Set the preview scale
                // 
                SendMessage(hHwnd, WM_CAP_SET_SCALE, 1, 0);
                // 
                // Set the preview rate in milliseconds
                // 
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0);
                // 
                // Start previewing the image from the camera
                // 
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, 1, 0);
                // 
                //  Resize window to fit in picturebox
                // 
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, iWidth, iHeight, (SWP_NOMOVE | SWP_NOZORDER));
            }
            else
            {
                // 
                //  Error connecting to device close window
                // 
                MessageBox.Show(this, "There is no capturing device in your computer", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DestroyWindow(hHwnd);
            }
        }
        private void ClosePreviewWindow()
        {

            // 
            //  Disconnect from device
            // 
            SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, /*iDevice*/ 0, 0);
            // 
            //  close window
            // 
            DestroyWindow(hHwnd);
        }
        private const short WM_CAP = 1024;
        private const int WM_CAP_DRIVER_CONNECT = WM_CAP + 10;
        private const int WM_CAP_DRIVER_DISCONNECT = WM_CAP + 11;

        private const int WM_CAP_SET_PREVIEW = WM_CAP + 50;
        private const int WM_CAP_SET_PREVIEWRATE = WM_CAP + 52;
        private const int WM_CAP_SET_SCALE = WM_CAP + 53;
        private const int WS_CHILD = 1073741824;
        private const int WS_VISIBLE = 268435456;
        private const short SWP_NOMOVE = 2;
        private const short SWP_NOSIZE = 1;
        private const short SWP_NOZORDER = 4;
        private const short HWND_BOTTOM = 1;
        private const int WM_CAP_EDIT_COPY = WM_CAP + 30;
        [DllImport("user32", EntryPoint = "SendMessageA")]
        static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] 
			object lParam);
        [DllImport("user32", EntryPoint = "SetWindowPos")]
        static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [DllImport("user32")]
        static extern bool DestroyWindow(int hndw);
        [DllImport("avicap32.dll")]
        static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int x, int y, int nWidth, short nHeight, int hWndParent, int nID);
        [DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(short wDriver, string lpszName, int cbName, string lpszVer, int cbVer);


         public unsafe delegate void OnFrameRecived(byte* data,int size);

      
        private void button1_Click(object sender, EventArgs e)
        {
            //th.Abort();
            //Application.ExitThread();
            timer1.Stop();
            ClosePreviewWindow();
            this.pictureBox2.Image = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            button1.PerformClick();
            ScreenSaverHandler.SetScreenSaverTimeout(99999);//10 minutes
        }


        void Process()
        {
            while (true)
            {
                Thread.Sleep(this.trackBar1.Value);
                lock (this)
                {
                    ////  Copy image to clipboard
                    //SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);

                    ////  Get image from clipboard and convert it to a bitmap
                    //data = Clipboard.GetDataObject();
                    //if (data != null)
                    //{
                    //    if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
                    //    {
                    //        // this.pictureBox2.Image = (Image)(data.GetData(typeof(System.Drawing.Bitmap)));
                    //        lastPic = new Bitmap((Image)(data.GetData(typeof(System.Drawing.Bitmap))));
                    //        this.pictureBox2.Image = lastPic;
                    //        //              bmp.Save(ms, ImageFormat.Jpeg);
                    //    }
                    //    btnDetect();
                    //}
                }
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                //  Copy image to clipboard
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);

                //  Get image from clipboard and convert it to a bitmap
                data = Clipboard.GetDataObject();
                if (data != null)
                {
                    if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
                    {
                        // this.pictureBox2.Image = (Image)(data.GetData(typeof(System.Drawing.Bitmap)));
                        lastPic = new Bitmap((Image)(data.GetData(typeof(System.Drawing.Bitmap))));
                        this.pictureBox2.Image = lastPic;
                        //              bmp.Save(ms, ImageFormat.Jpeg);
                    }
                    btnDetect();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenPreviewWindow();
            // capture();
            //th = new Thread(new ThreadStart(capture));
            // th.Start();
            //new Thread(new ThreadStart(Process)).Start();
            timer1.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
        bool profile = false;
        int trushFrames =4;
        StreamWriter sw;
        private void button3_Click(object sender, EventArgs e)
        {
            profile = true;
            f = new FileStream("Profile.txt", FileMode.Truncate, FileAccess.Write,FileShare.ReadWrite);
             sw = new StreamWriter(f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScreenSaverHandler.LaunchScreenSaver();
            //this.SendToBack();
            Thread.Sleep(10000);
            
            ScreenSaverHandler.StopScreenSaver();
        }

       
        
    }
}