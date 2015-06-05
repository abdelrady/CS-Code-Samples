using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Imaging;

namespace Camera_capture1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenPreviewWindow();
            timer2.Start();
            //objFaceDetector.WrapSetFaceDetectionMode(1);
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ClosePreviewWindow();
        }
        
        Graphics picGraphics;
        private clsFaceDetectionWrapper objFaceDetector;
        Bitmap lastPic;
        Pen myPen = new Pen(Color.Red, 2);
        MemoryStream ms = new MemoryStream();
        int llx,lly,rrx,rry;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            //lock (this)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                lastPic = new Bitmap(ms);
                ms.SetLength(0);
            }*/
            
            int faces = objFaceDetector.WrapDetectFaces(lastPic);
            this.Text = "Number of faces : " + faces.ToString();
            picGraphics = pictureBox2.CreateGraphics();
            unsafe
            {
                
                int lx, ly, rx, ry, res;
                //for (int f = 0; f < faces; f++)
                //{
                    objFaceDetector.WrapGetFaceCordinates(0, &lx, &ly, &rx, &ry);
                    llx = lx; lly = ly; rrx = rx; rry = ry;
                    this.Text+="   lx="+lx.ToString()+" ly="+ly.ToString()+" rx="+rx.ToString()+" ry="+ry.ToString();
                    picGraphics.DrawRectangle(myPen, lx * ((float)pictureBox2.Width / lastPic.Width),
                        ly * ((float)pictureBox2.Height / lastPic.Height),
                        rx * ((float)pictureBox2.Width / lastPic.Width),
                        ry * ((float)pictureBox2.Height / lastPic.Height));
                //}
               
            }
            picGraphics.Save();
            picGraphics.Dispose();
            timer1.Stop();
         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            ClosePreviewWindow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objFaceDetector = clsFaceDetectionWrapper.GetSingletonInstance();
            picGraphics = pictureBox2.CreateGraphics();
            //lastPic = new Bitmap(@"D:\Documents and Settings\fci_2007.FCIS\Desktop\WebCam Center\Capture\20080314\213220.jpg");
            //pictureBox2.Image = lastPic;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picGraphics = pictureBox2.CreateGraphics();
            picGraphics.DrawRectangle(myPen, llx, lly, rrx, rry);
            picGraphics.Save();
            picGraphics.Dispose();
           //pictureBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        IDataObject data;
        Bitmap bmp;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //  Copy image to clipboard
            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);

            //  Get image from clipboard and convert it to a bitmap
            data = Clipboard.GetDataObject();

            if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
            {
                this.pictureBox2.Image =(Image)(data.GetData(typeof(System.Drawing.Bitmap)));

  //              bmp.Save(ms, ImageFormat.Jpeg);
            }
            DetectFaces();

//            this.pictureBox2.Image = Image.FromStream(ms);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        void DetectFaces()
        {
            picGraphics = pictureBox2.CreateGraphics();
            lastPic = new Bitmap(this.pictureBox2.Image);
            int faces = objFaceDetector.WrapDetectFaces(lastPic);
            this.Text = "Number of faces : " + faces.ToString();
            
            unsafe
            {
                int lx, ly, rx, ry, res;
                //for (int f = 0; f < faces; f++)
                //{
                objFaceDetector.WrapGetFaceCordinates(0, &lx, &ly, &rx, &ry);
                llx = lx; lly = ly; rrx = rx; rry = ry;
                //}

            }
            
            this.Text += "   lx=" + llx.ToString() + " ly=" + lly.ToString() + " rx=" + rrx.ToString() + " ry=" + rry.ToString();
            picGraphics.DrawRectangle(myPen, llx * ((float)pictureBox2.Width / lastPic.Width),
                lly * ((float)pictureBox2.Height / lastPic.Height),
                rrx * ((float)pictureBox2.Width / lastPic.Width),
                rry * ((float)pictureBox2.Height / lastPic.Height));
            picGraphics.Save();
            picGraphics.Dispose();
        }
    }
}