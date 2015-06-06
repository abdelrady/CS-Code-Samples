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
using sss.Properties;

namespace sss
{
    public partial class frmMain : Form
    {
        private Bitmap lastPic;
        private clsFaceDetectionWrapper objFaceDetector;
        private Pen myPen = new Pen(Color.Red, 2.0f);
        private Graphics picGraphics;
        private Image img;
        private IDataObject data;
        private int FalseCount = 0;
        private FileStream Profilef;
        private double[] MeanVector = new double[5];
        private double Threshold;
 
        private const short WM_CAP = 1024;
        private const int   WM_CAP_DRIVER_CONNECT = WM_CAP + 10;
        private const int   WM_CAP_DRIVER_DISCONNECT = WM_CAP + 11;
        private const int   WM_CAP_SET_PREVIEW = WM_CAP + 50;
        private const int   WM_CAP_SET_PREVIEWRATE = WM_CAP + 52;
        private const int   WM_CAP_SET_SCALE = WM_CAP + 53;
        private const int   WS_CHILD = 1073741824;
        private const int   WS_VISIBLE = 268435456;
        private const short SWP_NOMOVE = 2;
        private const short SWP_NOSIZE = 1;
        private const short SWP_NOZORDER = 4;
        private const short HWND_BOTTOM = 1;
        private const int   WM_CAP_EDIT_COPY = WM_CAP + 30;

        [DllImport("user32", EntryPoint = "SendMessageA")]
        static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)]object lParam);
        [DllImport("user32", EntryPoint = "SetWindowPos")]
        static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [DllImport("user32")]
        static extern bool DestroyWindow(int hndw);
        [DllImport("avicap32.dll")]
        static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int x, int y, int nWidth, short nHeight, int hWndParent, int nID);
        [DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(short wDriver, string lpszName, int cbName, string lpszVer, int cbVer);

        public frmMain()
        {
            InitializeComponent();      
          
        }      
     
    
        private  void Detect()
        {           
            if(lastPic != null)
            {              
                int faces = objFaceDetector.WrapDetectFaces(lastPic);
                if (faces > 0)
                {
                    SetGUI(true);
                    ScreenSaver_Running = false ;

                    lblFeatureLevel.Text = "Number Of Faces:" + faces.ToString() + " ";
                    double fm;
                    unsafe
                    {
                        picGraphics = picDetectFaces.CreateGraphics();
                        int lx, ly, rx, ry, res;
                        for (int f = 0; f < faces; f++)
                        {
                          objFaceDetector.WrapGetFaceCordinates(f, &lx, &ly, &rx, &ry);

                            picGraphics.DrawRectangle(myPen,
                                lx * ((float)picDetectFaces.Width / lastPic.Width),
                                ly * ((float)picDetectFaces.Height / lastPic.Height),
                                rx * ((float)picDetectFaces.Width / lastPic.Width),
                                ry * ((float)picDetectFaces.Height / lastPic.Height));

                            int fy = ly;
                            int width = rx - lx;
                            int height = ry - ly;

                            lblFeatureLevel.Text += ", Ratio=" + ((double)width / height).ToString();


                            res = objFaceDetector.WrapGetEyeCordinates(f, &lx, &ly, &rx, &ry);

                            if (res > -1)
                            {
                                int f1 = Math.Abs(fy - ly);
                                int f2 = Math.Abs(fy - ry);
                                fm = (double)(f1 + f2) / 2;
                                fm /= height;
                                fm *= 1000;

                                try
                                {
                                    BarAuthebtication.Value 
                                        = (int)(((double)Math.Abs(Math.Min(fm, Threshold)) / Math.Abs(Math.Max(fm, Threshold))) * 100);
                                }
                                catch { }
                                lblRatio.Text = BarAuthebtication.Value.ToString() + "%";
                                lblFeatureLevel.Text = fm.ToString();
                                if (profile)
                                {
                                    MeanVector[trushFrames--] = fm;
                                    if (trushFrames == -1)
                                    {
                                        CalculateAndW();
                                        profile = false;
                                        trushFrames = 4;
                                    }
                                }
                            }
                            else
                            {
                                lblRatio.Text = "20%";
                                BarAuthebtication.Value = 20;
                            }
                        }
                        picGraphics.Save();
                        picGraphics.Dispose();                       
                    }
                }
                else
                {
                    if (FalseCount >= tBarFCount.Value)
                    {
                        if (!ScreenSaver_Running)
                        {
                            SetGUI(false);
                            ScreenSaver_Running = true;
                        }
                    }
                    else 
                        ++FalseCount;
                }
            }        
        }

        bool ScreenSaver_Running = false;
        private void SetGUI(bool p)
        {
            if (!p)
            {
                lblRatio.Text = "0%";
                BarAuthebtication.Value = 0;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackgroundImage = Image.FromHbitmap(Resources.Background.GetHbitmap());
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else {
                lblRatio.Text = "20%";
                BarAuthebtication.Value = 20;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.BackgroundImage = null;
            
            }

            this.label2.Visible = p;
            this.picDetectFaces.Visible = p;
            this.tBarFCount.Visible = p;
            this.tBarPoll.Visible = p;
            this.btnClosePreviewWnd.Visible = p;
            this.btnCreateProfile.Visible = p;
            this.BarAuthebtication.Visible = p;
            this.btnClosePreviewWnd.Visible = p;
            this.btnTestScreenSaver.Visible = p;
            this.btnStartPreviewWnd.Visible = p;
            this.statusStrip1.Visible = p;
            this.label1.Visible = p;
            this.label3.Visible = p;
            this.label4.Visible = p;
            this.lblFeatureLevel.Visible = p;
            this.lblRatio.Visible = p;        
            this.TopMost = !p;
            this.allow_close = p;
        }
        bool allow_close = true;
        private void CalculateAndW()
        {
            double sum = 0.0;
            for (int i = 0; i < MeanVector.Length; i++)
            {
                sum += MeanVector[i];
            }
            sum /= 5;
                sw.WriteLine(sum.ToString());
                sw.Close();        
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream f = new FileStream("Profile.txt", FileMode.Open, FileAccess.Read,FileShare.ReadWrite);
            StreamReader sw = new StreamReader(f);
            Threshold = Convert.ToDouble( sw.ReadLine());
            objFaceDetector = clsFaceDetectionWrapper.GetSingletonInstance();     
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
                picPreview.Handle.ToInt32(), 0);
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
            SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, /*iDevice*/ 0, 0);            
            DestroyWindow(hHwnd);
        }   
      


        private void btnClosePreviewWnd_Click(object sender, EventArgs e)
        {
            btnClosePreviewWnd.Enabled = false;
            btnStartPreviewWnd.Enabled = true;
            timer1.Stop();
            ClosePreviewWindow();
            this.picDetectFaces.Image = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allow_close == false) 
            {
                e.Cancel = true;
            }
            else
            {
                btnClosePreviewWnd.PerformClick();
                ScreenSaverHandler.SetScreenSaverTimeout(99999);//10 minutes
            }
        }

        Thread th;

        private void PollTimer_Tick(object sender, EventArgs e)
        {
            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);
           
                data = Clipboard.GetDataObject();
                if (data != null)
                {
                    if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
                    {
                        lastPic = new Bitmap((Image)(data.GetData(typeof(System.Drawing.Bitmap))));
                        this.picDetectFaces.Image = lastPic;
                    }
                    Detect();
                }
        }
       
        private void btnStartPreviewWnd_Click(object sender, EventArgs e)
        {
            btnClosePreviewWnd.Enabled = true;
            btnStartPreviewWnd.Enabled = false;
            OpenPreviewWindow();          
            timer1.Start();
        }

        private void tBarPoll_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tBarPoll.Value;
        }
        bool profile = false;
        int trushFrames =4;
        StreamWriter sw;
        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            if (BarAuthebtication.Value <= 20)
            {
                MessageBox.Show(this,"Please, Reorder Your Face in the Right Position             \n\n   - Put Your Face in The Center of the preview window\n   - Take Off Your Glassess!", "Can not Create Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                profile = true;
                Profilef = new FileStream("Profile.txt", FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
                sw = new StreamWriter(Profilef);
            }
        }
        private void btnTestScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSaverHandler.LaunchScreenSaver();     
            Thread.Sleep(10000);            
            ScreenSaverHandler.StopScreenSaver();
        }

        private void tBarFCount_Scroll(object sender, EventArgs e)
        {
            label2.Text = tBarFCount.Value+" Frame";
        }     
        
    }
}