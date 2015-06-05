using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Using_Huffman_Compresion_Dll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string outstr = "", inStr = "";
            MemoryStream ms=new MemoryStream();
            pictureBox1.Image.Save(ms,ImageFormat.Jpeg);
            QUICKCOMPRESSLib.HuffmanClass obj = new QUICKCOMPRESSLib.HuffmanClass();
            obj.Compress(Encoding.Default.GetString(/*File.ReadAllBytes(openFileDialog1.FileName)*/ ms.ToArray()), ref outstr);
            //MessageBox.Show(File.ReadAllBytes("E:\\421109529_d18f5882ff.jpg").Length.ToString() + ", " + outstr.Length.ToString());
            obj.Uncompress(outstr, ref inStr);
            //MessageBox.Show(File.ReadAllBytes("E:\\421109529_d18f5882ff.jpg").Length.ToString() + ", " + inStr.Length.ToString());
            pictureBox2.Image = Image.FromStream(new MemoryStream(Encoding.Default.GetBytes(inStr)));
            this.Text=outstr.Length.ToString() + ", " + inStr.Length.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string outstr = "", inStr = "";
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            QUICKCOMPRESSLib.RunLengthClass obj = new QUICKCOMPRESSLib.RunLengthClass();
            obj.Encode(Encoding.Default.GetString(/*File.ReadAllBytes(openFileDialog1.FileName)*/ms.ToArray()), ref outstr);
            //MessageBox.Show(File.ReadAllBytes("E:\\421109529_d18f5882ff.jpg").Length.ToString() + ", " + outstr.Length.ToString());
            obj.Decode(outstr, ref inStr);
            //MessageBox.Show(File.ReadAllBytes("E:\\421109529_d18f5882ff.jpg").Length.ToString() + ", " + inStr.Length.ToString());
            pictureBox2.Image = Image.FromStream(new MemoryStream(Encoding.Default.GetBytes(inStr)));
            this.Text = outstr.Length.ToString() + ", " + inStr.Length.ToString();
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
        public byte[] GetDesktopImage(long quality)
        {
            // Set the bitmap object to the size of the screen
            //if (!Environment.UserName.ToLower().Contains(Settings.Default.AccountName.ToLower())) return;

            using (Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format24bppRgb))
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
                        EncoderParameter ColorDepthRatio = new EncoderParameter(System.Drawing.Imaging.Encoder.ColorDepth, 8L /*5L*/);// 8bpp
                        // Add the quality parameter to the list
                        EncoderParameters codecParams = new EncoderParameters(2);
                        codecParams.Param[0] = ratio;
                        codecParams.Param[1] = ColorDepthRatio;

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

        private void button4_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(GetDesktopImage(10L));
            pictureBox1.Image = Image.FromStream(ms);
            this.Text = (ms.Length / 1024).ToString();
        }
    }
}