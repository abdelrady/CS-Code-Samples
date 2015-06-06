using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace SmartDoor
{
    public class DesktopImage
    {
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            } return null;
        }
        public static byte[] GetDesktopImage(long quality)
        {
            // Set the bitmap object to the size of the screen
            //if (!Environment.UserName.ToLower().Contains(Settings.Default.AccountName.ToLower())) return;

            using (Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb))
            {
                // Create a graphics object from the bitmap

                using (Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot))
                {
                    try
                    {
                        // Log("Capture screen");
                        // Take the screenshot from the upper left corner to the right bottom corner
                        gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                        // Save the screenshot to the specified path that the user has chosen

                        //Get the ImageCodecInfo for the desired target format
                        ImageCodecInfo codec = GetEncoderInfo("image/jpeg");

                        // Set the quality to very low
                        System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameter ratio = new EncoderParameter(qualityEncoder, quality /*5L*/);
                        // Add the quality parameter to the list
                        EncoderParameters codecParams = new EncoderParameters(1);
                        codecParams.Param[0] = ratio;

                        //string filePath = Directory.GetCurrentDirectory() +
                        //    "\\pic" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() +
                        //    DateTime.Now.Second.ToString() + ".jpg";//FilePath(Settings.Default.LastFileNo);
                        //if (File.Exists(filePath)) File.Delete(filePath);
                        
                        // Log("Save file: " + filePath);

                        //using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        using (MemoryStream ms = new MemoryStream())
                        {
                            /*
                             * my Code Modification
                             * write To File & Memory Stream To return array of image data
                             */
                            byte[] imageData;
                            bmpScreenshot.Save(ms, codec, codecParams);
                            imageData = ms.ToArray();
                            Array.Resize(ref imageData, imageData.Length + 9);
                            Array.Copy(Encoding.ASCII.GetBytes("[#<EOF>#]"), 0, imageData, imageData.Length - 9, 9);
                            return imageData;

                            //         fs.Close();
                            //      ms = new MemoryStream(File.ReadAllBytes(filePath)); //ms.ToArray();
                            //bmpScreenshot.Save(ms, ImageFormat.Jpeg);
                            
                            //MessageBox.Show(imageData.Length.ToString());
                            //fs.Write(ms.GetBuffer(), 0, ms.GetBuffer().Length);
                            //ms.Close();
                            //imageData = null;
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                        //Log(x.ToString());
                        if (x is Win32Exception)
                        {
                            //Log("Restarting...");
                            //Application.Restart();
                        }
                    }
                    finally
                    {
                        
                        //imageData = null;
                        //Settings.Default.LastFileNo++;
                        //Settings.Default.Save();
                    }
                    return null;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        public static int GetDesktopImage(long quality,bool OnlyLength)
        {
            // Set the bitmap object to the size of the screen
            //if (!Environment.UserName.ToLower().Contains(Settings.Default.AccountName.ToLower())) return;

            using (Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb))
            {
                // Create a graphics object from the bitmap

                using (Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot))
                {
                    try
                    {
                        // Log("Capture screen");
                        // Take the screenshot from the upper left corner to the right bottom corner
                        gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                        // Save the screenshot to the specified path that the user has chosen

                        //Get the ImageCodecInfo for the desired target format
                        ImageCodecInfo codec = GetEncoderInfo("image/jpeg");

                        // Set the quality to very low
                        System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameter ratio = new EncoderParameter(qualityEncoder, quality /*5L*/);
                        // Add the quality parameter to the list
                        EncoderParameters codecParams = new EncoderParameters(1);
                        codecParams.Param[0] = ratio;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            //byte[] imageData;
                            bmpScreenshot.Save(ms, codec, codecParams);
                            //imageData = ms.ToArray();
                            //Array.Resize(ref imageData, imageData.Length + 9);
                            //Array.Copy(Encoding.ASCII.GetBytes("[#<EOF>#]"), 0, imageData, imageData.Length - 9, 9);
                            return (int)ms.Length+9;
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                        //Log(x.ToString());
                        if (x is Win32Exception)
                        {
                            //Log("Restarting...");
                            //Application.Restart();
                        }
                    }
                    finally
                    {
                        
                        //imageData = null;
                        //Settings.Default.LastFileNo++;
                        //Settings.Default.Save();
                    }
                    return 0;
                }
            }
}
        }
    }
    class DeskTop
    {
        #region Do Not Open!!!!!!!!!!!!!!
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        private static extern int GetSystemMetrics(int abc);
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        private static extern IntPtr GetDC(IntPtr ptr);
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        private static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);
        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
        private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);
        [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
        private static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
        [DllImport("gdi32.dll", EntryPoint = "BitBlt")]
        private static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, int RasterOp);
        [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
        private static extern IntPtr DeleteDC(IntPtr hDc);
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern IntPtr DeleteObject(IntPtr hDc);
        #endregion

        public static byte[] GetDesktopImage()
        {
            IntPtr DesktopHWnd = GetDC(GetDesktopWindow());
            IntPtr DesktopHDC = CreateCompatibleDC(DesktopHWnd);
            IntPtr BitmapHWnd = CreateCompatibleBitmap(DesktopHWnd, GetSystemMetrics(0), GetSystemMetrics(1));
            IntPtr BitmapHDC = (IntPtr)SelectObject(DesktopHDC, BitmapHWnd);
            BitBlt(DesktopHDC, 0, 0, GetSystemMetrics(0), GetSystemMetrics(1), DesktopHWnd, 0, 0, 13369376);
            SelectObject(DesktopHDC, BitmapHDC);
            System.Drawing.Bitmap _Desktop = System.Drawing.Image.FromHbitmap(BitmapHWnd);
            ReleaseDC(GetDesktopWindow(), DesktopHWnd);
            DeleteDC(DesktopHDC);
            DeleteObject(BitmapHWnd);
            System.IO.MemoryStream ImageStream = new System.IO.MemoryStream();
            _Desktop.Save(ImageStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] ImageChunks = ImageStream.ToArray();
            Array.Resize(ref ImageChunks, ImageChunks.Length + 9);
            Array.Copy(Encoding.ASCII.GetBytes("[#<EOF>#]"), 0, ImageChunks, ImageChunks.Length - 9, 9);
            return (ImageChunks);
        }
    }

