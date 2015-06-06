using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

using DexterLib;

namespace Car_Tracking_Using_bgEstimation
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendString", SetLastError = true)]
        public static extern void mciSendString(string msg, int length, IntPtr handle);

        int numberOfCarsInImage = 0;
        int num = 0, grayScale = 0;
        int preLY = 0, preRY = 0, preX = 0, preLen = 0;

        Splash splfrm;
        About AboutFrm = new About();

        OpenFileDialog ofdlg;

        Bitmap ThresholdImg ;         //used to make the thresholde images 
        Bitmap background ;           //the extracted GrayScale background from video
        Bitmap backgroundColored;    //the extracted Colored background from video

        int avgRed = 0, avgGreen = 0, avgBlue = 0;

        string fileName;                        //used to save the movie file name 
        string storagePath;                     //used for the path where we save images

        MediaDetClass md;                       //needed to extract pictures

        static int counter = 0;                 //to generate different file names

        int preY = 0;

        public Form1()
        {
            InitializeComponent();

            storagePath = Application.StartupPath + "\\tmp\\"; //creating temprory directory
            if (!Directory.Exists(storagePath))
            {
                Directory.CreateDirectory(storagePath);
            }
            if (!Directory.Exists(Application.StartupPath + "\\tmpThreshold\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\tmpThreshold\\");
            }
            if (!Directory.Exists(Application.StartupPath + "\\tmpOut\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\tmpOut\\");
            }
        }

        //*********************************/ Framing /***************************************************

        // Thread class to be able to display the progress
        // using the static label
        class FramingThread
        {
            MediaDetClass md;
            string fileName;
            string storagePath;
            public Thread t;
            public FramingThread(string s, string f)
            {
                storagePath = s;
                fileName = f;
                t = new Thread(new ThreadStart(this.Scan));
                t.Start();
            }
            void Scan()
            {
                md = new MediaDetClass();
                Image img;
                md.Filename = fileName;
                md.CurrentStream = 0;
                int len = (int)md.StreamLength;
                for (float i = 0.0f; i < len; i = i + 0.1f)
                {
                    counter++;
                    string fBitmapName = storagePath + counter.ToString();
                    md.WriteBitmapBits(i, 150, 150, fBitmapName + ".bmp");
                    img = Image.FromFile(fBitmapName + ".bmp");
                    img.Save(fBitmapName + ".jpg");
                    img.Dispose();
                    System.IO.File.Delete(fBitmapName + ".bmp");
                }
            }
        }

        //**************************************************************************************

        public void DrawRect(int startX, int startY, int endY, int Clen, Bitmap IMG)
        {
            Boolean r = false, r1 = false;

            for (int i = preX; i >= preX - preLen; i--)
                if (startX == i)
                {
                    r1 = true;
                    break;
                }

            if (r1 == true)
            {
                for (int i = endY; i >= startY; i--)
                {
                    for (int j = preRY; j >= preLY; j--)
                    {
                        if (i == j)
                            r = true;
                    }
                    if (r == true)
                        break;
                }
            }

            if (r == false)
            {
                numberOfCarsInImage++;


                for (int rectX = startY; rectX <= endY; rectX++)
                {
                    if (rectX < 0)
                        rectX = 0;

                    IMG.SetPixel(rectX, startX, Color.FromArgb(255, 0, 0));
                    IMG.SetPixel(rectX, (startX - Clen), Color.FromArgb(255, 0, 0));
                }
                for (int rectY = startX; rectY >= (startX - Clen); rectY--)
                {
                    if (startY >= 0)
                    {
                        IMG.SetPixel(startY, rectY, Color.FromArgb(255, 0, 0));
                        IMG.SetPixel(endY, rectY, Color.FromArgb(255, 0, 0));
                    }
                }
                preLY = startY;
                preRY = endY;
                preX = startX;
                preLen = Clen;
            }
        }//End of DrawRect Methode

        //*****************************************************************

        int getX(int xax, int yax, Bitmap bitmap)
        {
            int pix = 0, ret = xax, count = 0, xx = 0;
            for (int i = yax - 10; i < yax + 10; i++)
            {
                if (i <= 149 && i >= 0)
                {
                    count = 0;
                    xx = xax;
                    while (count < 40 && xx >= 0)
                    {
                        pix = (int)bitmap.GetPixel(i, xx--).R;
                        if (pix == 0)
                            count++;
                        else
                        {
                            if (ret > xx && pix == 255)
                            {
                                ret = xx;
                                count = 0;
                            }
                        }
                    }
                }
            }
            ret = xax - ret;
            return ret;
        }//End of getX methode

        //*****************************************************************

        int getLeftY(int xax, int yax, Bitmap bitmap, int retlength)
        {
            int count = 0, pix = 0, ret = yax, yy = 0;

            for (int i = xax; i >= xax - retlength; i--)
            {
                if (i >= 0 && i <= 149)
                {
                    yy = yax;
                    count = 0;
                    while (count < 11 && yy >= 0)
                    {
                        pix = (int)bitmap.GetPixel(yy--, i).R;
                        if (pix == 0)
                            count++;
                        else if (ret > yy && pix == 255)
                        {
                            ret = yy;
                            count = 0;
                        }
                    }
                }
            }
            return ret;
        }//End of getLeftY methode

        //*****************************************************************

        int getRightY(int xax, int yax, Bitmap bitmap, int retlength)
        {
            int count = 0, pix = 0, ret = 0, yy = 0;

            for (int i = xax; i >= xax - retlength; i--)
            {
                if (i >= 0 && i <= 149)
                {
                    yy = yax;
                    count = 0;
                    while (count < 11 && yy <= 149)
                    {
                        pix = (int)bitmap.GetPixel(yy++, i).R;
                        if (pix == 0)
                            count++;
                        else if (ret < yy && pix == 255)
                        {
                            ret = yy;
                            count = 0;
                        }
                    }
                }
            }
            return ret;
        }//End of getRightY methode

        //**********************************/ Background Extraction /***************************************

        void ExtractBackground()   //methode used to extract background image
        {
            if (counter < 50)
                num = counter;
            else
                num = 50;

            Bitmap[] bgEstimate=new Bitmap[num];

            for (int i = 1; i <= num;i++ )
                bgEstimate [i-1]= (Bitmap)(Image.FromFile(Application.StartupPath + "\\tmp\\" + i + ".jpg"));
                for (int x = 0; x < 150; x++)
                {
                    //------------------------------------------------------------ 
                   
                    if (progressBar1.Value == 100)
                        progressBar1.Value = 0;
                    progressBar1.Increment(1);

                    //------------------------------------------------------------

                    for (int y = 0; y < 150; y++)
                    {
                        avgRed = 0;
                        avgGreen = 0;
                        avgBlue = 0;

                        for (int j = 0; j < num; j++)
                        {
                            avgRed += (int)bgEstimate[j].GetPixel(y, x).R;
                            avgGreen += (int)bgEstimate[j].GetPixel(y, x).G;
                            avgBlue += (int)bgEstimate[j].GetPixel(y, x).B;
                        }

                        avgRed = (int)(avgRed / num);
                        avgGreen = (int)(avgGreen / num);
                        avgBlue = (int)(avgBlue / num);

                        backgroundColored.SetPixel(y, x, Color.FromArgb(avgRed, avgGreen, avgBlue));
                        grayScale = (int)(avgRed * 0.299 + avgGreen * 0.587 + avgBlue * 0.114);
                        background.SetPixel(y, x, Color.FromArgb(grayScale, grayScale, grayScale));
                    }
                }
            BackgroundPictureBox.Image = background;
            background.Save(Application.StartupPath + "\\backgroundGraysale.jpg");
            backgroundColored.Save(Application.StartupPath + "\\backgroundColored.jpg");
        }   //End of ExtractBackground()Methode

        //***********************************/ Thresholding /**********************************************

        void GenerateThresholded()   //methode used to generate the thresholded images
        {
            Bitmap TempImg = new Bitmap(150, 150);
            int newPix = 0, pixR = 0, pixG = 0, pixB = 0,gray=0;
            try
            {
                for (int im = 1; im <= counter; im++)
                {
                    //------------------------------------------------------------

                    if (progressBar1.Value == 100)
                        progressBar1.Value = 0;
                    progressBar1.Increment(1);

                    //------------------------------------------------------------

                    TempImg = (Bitmap)Image.FromFile(Application.StartupPath + "\\tmp\\" + im + ".jpg");

                    for (int x = 0; x < 150; x++)
                    {
                        for (int y = 0; y < 150; y++)
                        {
                            pixR = (int)(TempImg.GetPixel(y, x).R);
                            pixG = (int)(TempImg.GetPixel(y, x).G);
                            pixB = (int)(TempImg.GetPixel(y, x).B);

                            gray = (int)(pixR * 0.299 + pixG * 0.587 + pixB * 0.114);

                            newPix = gray - background.GetPixel(y, x).R;

                            if (newPix < 0)
                                newPix = (newPix * -1) ;

                            if (newPix < 70)
                                newPix = 0;
                            else 
                                newPix = 255;
                            
                            ThresholdImg.SetPixel(y, x, Color.FromArgb(newPix, newPix, newPix));
                        }
                    }
                    ThresholdImg.Save(Application.StartupPath + "\\tmpThreshold\\" + im + ".jpg");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        } //End of GenerateThresholded()Methode

        //*************************************/ Video Generation /************************************

        void CollectVideo(string file,string dir)
        {
            FileStream vid = new FileStream(file, FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite);
            AviWriter AviVideoWriter = new AviWriter(); 
            try
            {
                Bitmap temp = new Bitmap(150, 150);
                AviVideoWriter.Open(file, 10, 150, 150); //10 frame per second
                for (int i = 1; i <= counter; i++)
                {
                    //------------------------------------------------------------
                    progressBar1.Increment(1);
                    if (progressBar1.Value == 100)
                        progressBar1.Value = 0;
                    //------------------------------------------------------------
                    temp = new Bitmap(dir + i + ".jpg");
                    temp.RotateFlip(RotateFlipType.Rotate180FlipX);
                    AviVideoWriter.LoadFrame(temp);
                    AviVideoWriter.AddFrame();
                }
            }
            catch (AviWriter.AviException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                AviVideoWriter.Close();
                vid.Close();
            }
        }//End of CollectVideo Methode

        //*************************************************************************************************

        private void miOpenFile_Click(object sender, EventArgs e)
        {
            ThresholdImg = new Bitmap(150, 150);
            background = new Bitmap(150, 150);
            backgroundColored = new Bitmap(150, 150);


            InputVideolabel.Text = "Input Video : ";
            ofdlg = new OpenFileDialog();
            ofdlg.InitialDirectory = Application.StartupPath;
            ofdlg.DefaultExt = "avi Files|*.avi";
            ofdlg.Filter = "AVI Video Files | *.avi";     //to select avi files only

            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                Video.Enabled = true;
                try
                {
                    fileName = ofdlg.FileName;
                    InputVideolabel.Text += Path.GetFileName(fileName);

                    //-----------------------------------------------------------------------------------
                    
                    mciSendString("OPEN \"" + fileName + "\" TYPE MPEGVideo ALIAS InputVideo PARENT " 
                        + InputVideoPanel.Handle + " STYLE child", 0, IntPtr.Zero);

                    //to make the video stretched to the showing window
                    mciSendString("PUT InputVideo WINDOW AT " + (0).ToString() + " "
                        + (0).ToString() + " " + (InputVideoPanel.Width).ToString()
                        + " " + (InputVideoPanel.Height).ToString(), 0, IntPtr.Zero);

                    mciSendString("PLAY InputVideo REPEAT", 0, IntPtr.Zero);   
                     
                    //-----------------------------------------------------------------------------------
                    
                    //create the MediaDetClass and set its properties

                    md = new MediaDetClass();
                    md.Filename = fileName;
                    md.CurrentStream = 0;

                    int len = (int)md.StreamLength;   //get the length of the video file in seconds                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't open This file");
                }                              
            }
        }
        
        //*************************************************************************************************

        private void miCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //**************************************************************************************************

        private void miFraming_Click(object sender, EventArgs e)
        {
            miBackground.Enabled = true;
            progressBar1.Value = 0;
            if (md == null) return;

            FramingThread framingThread = new FramingThread(storagePath, fileName);
            do
            {
                //waits until the processing is done, displaying the
                //number of the file we are currently saving
                Thread.Sleep(1000);
                ;
                //------------------------------------------------------------
                if (progressBar1.Value == 100)
                    progressBar1.Value = 0;
                progressBar1.Increment(1);
                progressBar1.Invalidate();
                progressBar1.Update();

                //------------------------------------------------------------
            } while (framingThread.t.IsAlive);

            framingThread.t.Abort();
            splfrm = new Splash("Framing Complete Succesfully");
            splfrm.Show();
        }

        //**************************************************************************************************

        private void miBackground_Click(object sender, EventArgs e)
        {
            miThreshold.Enabled = true;                 
            ExtractBackground();
            splfrm = new Splash("Background Extracted Succesfully");
            splfrm.Show();
        }

        //**************************************************************************************************

        private void miThreshold_Click(object sender, EventArgs e)
        {
            miGenerateOutVideo.Enabled = true;

            GenerateThresholded();

            CollectVideo(Application.StartupPath.ToString() + "\\Thresholded.avi" , Application.StartupPath + "\\tmpThreshold\\");

            mciSendString("open \"" + Application.StartupPath + "\\Thresholded.avi" 
                + "\" type mpegvideo alias ThresholdedVideo parent " 
                + ThresholdedVideopanel.Handle + " style child", 0, IntPtr.Zero);

            //to make the video stretched to the showing window
            mciSendString("PUT ThresholdedVideo WINDOW AT " + (0).ToString() + " "
                + (0).ToString() + " " + (ThresholdedVideopanel.Width).ToString()
                + " " + (ThresholdedVideopanel.Height).ToString(), 0, IntPtr.Zero);

            mciSendString("play ThresholdedVideo REPEAT", 0, IntPtr.Zero);
            
            splfrm = new Splash("Thresholded Video Created");
            splfrm.Show();
        }
        
        //**************************************************************************************************

        private void miGenerateOutVideo_Click(object sender, EventArgs e)
        {
            int numpixR = 0, numpixG = 0, numpixB = 0;
            int Carlen = 0, leftY = 0, RightY = 0;

            Bitmap TempOutImg1 = new Bitmap(150, 150);
            Bitmap TempOutImg2 = new Bitmap(150, 150);
            Bitmap OutImg = new Bitmap(150, 150);

            try
            {
                for (int im = 1; im <= counter; im++)
                {
                    numberOfCarsInImage = 0;
                    preLY = 0;
                    preRY = 0;
                    preX = 0;
                    preLen = 0;

                    //------------------------------------------------------------

                    if (progressBar1.Value == 100)
                        progressBar1.Value = 0;
                    progressBar1.Increment(1);

                    //------------------------------------------------------------

                    TempOutImg1 = (Bitmap)Image.FromFile(Application.StartupPath
                   + "\\tmpThreshold\\" + im + ".jpg");

                    TempOutImg2 = (Bitmap)Image.FromFile(Application.StartupPath
                        + "\\tmp\\" + im + ".jpg");

                    for (int q = 0; q < 150; q++)
                        TempOutImg2.SetPixel(q, 30, Color.FromArgb(0, 255, 0));
                    //------------------------------------------------------------

                    for (int x = 149; x > 30; x--)
                    {
                        for (int y = 149; y >= 0; y--)
                        {
                            if (y >= 0)
                            {
                                if (TempOutImg1.GetPixel(y, x).R == 255)
                                {
                                    Carlen = getX(x, y, TempOutImg1);
                                    leftY = getLeftY(x, y, TempOutImg1, Carlen);
                                    RightY = getRightY(x, y, TempOutImg1, Carlen);

                                    if ((x - Carlen) >= 30 && Carlen > 15 && (RightY - leftY) > 15)
                                    {
                                        DrawRect(x, leftY, RightY, Carlen, TempOutImg2);
                                        y = y - RightY - leftY;
                                    }
                                }
                            }
                        }
                    }

                    OutImg = (Bitmap)Image.FromFile(Application.StartupPath
                        + "\\Numbers\\" + numberOfCarsInImage + ".jpg");

                    for (int n = 0; n < 25; n++)
                        for (int m = 0; m < 30; m++)
                        {
                            numpixR = (int)OutImg.GetPixel(m, n).R;
                            numpixG = (int)OutImg.GetPixel(m, n).G;
                            numpixB = (int)OutImg.GetPixel(m, n).B;
                            TempOutImg2.SetPixel(m, n, Color.FromArgb(numpixR, numpixG, numpixB));
                        }

                    TempOutImg2.Save(Application.StartupPath + "\\tmpOut\\" + im + ".jpg");
                } //End of images loop

                //---------------------------------------------------------------------------------------

                CollectVideo(Application.StartupPath + "\\Out.avi"
                           , Application.StartupPath + "\\tmpOut\\");

                mciSendString("open \"" + Application.StartupPath + "\\Out.avi"
                    + "\" type mpegvideo alias OutVideo parent "
                    + OutputVideoPanel.Handle + " style child", 0, IntPtr.Zero);

                //to make the video stretched to the showing window
                mciSendString("PUT OutVideo WINDOW AT " + (0).ToString() + " "
                    + (0).ToString() + " " + (OutputVideoPanel.Width).ToString()
                    + " " + (OutputVideoPanel.Height).ToString(), 0, IntPtr.Zero);

                mciSendString("play OutVideo REPEAT", 0, IntPtr.Zero);
                progressBar1.Value = progressBar1.Maximum;

                splfrm = new Splash("Output Video Created");
                splfrm.Show();
                Delete.Enabled = true;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        //**************************************************************************************************

        private void miDeleteTempFiles_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(storagePath,true);
                Directory.Delete(Application.StartupPath + "\\tmpThreshold\\",true);
                Directory.Delete(Application.StartupPath + "\\tmpOut\\", true);
                splfrm = new Splash("Directories Deleted Succesfully");
                splfrm.Show();
            }
            catch (IOException IO)
            {
                MessageBox.Show(IO.Message);
            }
        }

        //**************************************************************************************************

        private void miProject_Click(object sender, EventArgs e)
        {
            AboutFrm.Show();
        }

        //**************************************************************************************************
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Directory.Delete(storagePath, true);
                Directory.Delete(Application.StartupPath + "\\tmpThreshold\\", true);
                Directory.Delete(Application.StartupPath + "\\tmpOut\\", true);
                System.IO.File.Delete(Application.StartupPath + "\\Thresholded.avi");
                System.IO.File.Delete(Application.StartupPath + "\\Out.avi");
                System.IO.File.Delete(Application.StartupPath + "\\backgroundColored.jpg");
                System.IO.File.Delete(Application.StartupPath + "\\backgroundGraysale.jpg");
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }        
    }
}