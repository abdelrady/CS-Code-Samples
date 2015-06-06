using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace SmartDoor
{
    class ImageCompressor
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
        public static byte[]Compress(byte[]UnCompressed_Image,int mQuality)
        {
            ImageCodecInfo codec = GetEncoderInfo("image/jpeg");
            Image I = Image.FromStream(new MemoryStream(UnCompressed_Image));
            using (Graphics gfxScreenshot = Graphics.FromImage(I))
            {
                try
                {

                    System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                    EncoderParameter ratio = new EncoderParameter(qualityEncoder, mQuality /*5L*/);
                    // Add the quality parameter to the list
                    EncoderParameters codecParams = new EncoderParameters(1);
                    codecParams.Param[0] = ratio;


                    using (MemoryStream ms = new MemoryStream())
                    {
                        /*
                         * my Code Modification
                         * write To File & Memory Stream To return array of image data
                         */

                        byte[] imageData;
                        I.Save(ms, codec, codecParams);
                        imageData = ms.ToArray();
                        //Array.Resize(ref imageData, imageData.Length + 9);
                        //Array.Copy(Encoding.ASCII.GetBytes("[#<EOF>#]"), 0, imageData, imageData.Length - 9, 9);
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
                    System.Windows.Forms.MessageBox.Show("Compress"+x.Message);                   
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
}
