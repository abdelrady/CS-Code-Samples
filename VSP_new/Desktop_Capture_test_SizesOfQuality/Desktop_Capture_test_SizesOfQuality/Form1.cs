using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.IO.Compression;

namespace Desktop_Capture_test_SizesOfQuality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void convert2HighQuality()
        {
            //using (FileStream fs = new FileStream("", FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                MemoryStream ms = new MemoryStream(File.ReadAllBytes("C:\\pic151012.jpg"));
                Bitmap bmpScreenshot =new Bitmap( Image.FromStream(ms));

                ImageCodecInfo codec = GetEncoderInfo("image/jpeg");

                // Set the quality to very low
                System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                EncoderParameter ratio = new EncoderParameter(qualityEncoder, 100L/* quality*/);
                // Add the quality parameter to the list
                EncoderParameters codecParams = new EncoderParameters(1);
                codecParams.Param[0] = ratio;

                string filePath = "C:\\pic" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".jpg";//FilePath(Settings.Default.LastFileNo);
                if (File.Exists(filePath)) File.Delete(filePath);

                // Log("Save file: " + filePath);

                using (FileStream fs = new FileStream("c:\\highQuality.jpg", FileMode.Create))
                {
                    bmpScreenshot.Save(fs, codec, codecParams);
                    fs.Close();
                }
            }
        }
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
        void captureScreen(long quality,out byte[] imageData)
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

                        string filePath = Directory.GetCurrentDirectory()+ 
                            "\\pic" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() +
                            DateTime.Now.Second.ToString() + ".jpg";//FilePath(Settings.Default.LastFileNo);
                        if (File.Exists(filePath)) File.Delete(filePath);

                       // Log("Save file: " + filePath);

                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            /*
                             * my Code Modification
                             * write To File & Memory Stream To return array of image data
                             */
                            MemoryStream ms = new MemoryStream();
                            bmpScreenshot.Save(ms, codec, codecParams);
                            fs.Close();
                            imageData = /*File.ReadAllBytes(filePath); //*/ms.ToArray();
                            MemoryStream compStream=new MemoryStream();
                            GZipStream gz = new GZipStream(compStream, CompressionMode.Compress,true);
                            //byte[] arr=new byte[100000];
                            gz.Write(imageData, 0, Convert.ToInt32(imageData.Length));
                            //gz.Flush();
                            gz.Close();
                            //Thread.Sleep(100);
                            MessageBox.Show("imageData Length: " + imageData.Length + " GZipStream Length: " + compStream.Length);
                            //fs.Write(ms.GetBuffer(), 0, ms.GetBuffer().Length);
                            compStream.Close();
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                        //Log(x.ToString());
                        if (x is Win32Exception)
                        {
                            //Log("Restarting...");
                            Application.Restart();
                        }
                    }
                    finally
                    {
                        imageData = null;
                        //Settings.Default.LastFileNo++;
                        //Settings.Default.Save();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] arr;
            captureScreen(10L, out arr);//up to 100 quality, larger mean good
        }

        private void button2_Click(object sender, EventArgs e)
        {
            convert2HighQuality();
            //captureScreen(5);
        }
    }
}