/*to compile
csc /r:Microsoft.DirectX.AudioVideoPlayback.dll /target:winexe /out:vision.exe C:\WINDOWS\Desktop\machine_vision\*.cs
*/
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.IO;

namespace MachineVision
{
    class Vision
    {
        //for now all methods are static
        private Vision()
        {

        }

        ///<summary>
        ///this method creates a black and white copy of the image
        ///</summary>
        public static void DetectEdges(Bitmap original, ref Bitmap modified, Color c, int noise)
        {
            Graphics g = Graphics.FromImage(original);
            for (Int32 x = 0; x < original.Width; x++)
            {
                for (Int32 y = 0; y < original.Height; y++)
                {
                    if (x > 2 && y > 2)
                    {
                        try
                        {
                            Color current = modified.GetPixel(x, y);
                            Color right = modified.GetPixel(x + 1, y);
                            Color left = modified.GetPixel(x - 1, y);

                            int totalCurrent = current.R + current.G + current.B;
                            int totalRight = right.R + right.G + right.B;
                            int totalLeft = left.R + left.G + left.B;

                            if (totalCurrent > (totalLeft + noise) || totalCurrent > (totalRight + noise))
                            {
                                modified.SetPixel(x - 1, y, Color.White);//white
                            }
                            else if (totalCurrent > (totalRight + noise))
                            {
                                modified.SetPixel(x + 1, y, Color.White);//white
                            }
                            else
                                modified.SetPixel(x, y, Color.Black);//black

                            Color upOne = modified.GetPixel(x, y - 1);
                            Color downOne = modified.GetPixel(x, y + 1);

                            int totalUpOne = upOne.R + upOne.G + upOne.B;
                            int totalDownOne = downOne.R + downOne.G + downOne.B;

                            if (totalUpOne > (totalCurrent + noise))
                            {
                                modified.SetPixel(x, y - 1, Color.White);
                            }
                            else if (totalDownOne > (totalCurrent + noise))
                            {
                                modified.SetPixel(x, y + 1, Color.White);
                            }
                            else
                                modified.SetPixel(x, y, Color.Black);




                            Color upLeft = modified.GetPixel(x - 1, y - 1);
                            Color downRight = modified.GetPixel(x + 1, y + 1);

                            int totalUpLeft = upLeft.R + upLeft.G + upLeft.B;
                            int totalDownRight = downRight.R + downRight.G + downRight.B;
                            if (totalUpLeft > (totalCurrent + noise))
                            {
                                modified.SetPixel(x - 1, y - 1, Color.White);
                            }
                            else if (totalDownRight > (totalCurrent + noise))
                            {
                                modified.SetPixel(x + 1, y + 1, Color.White);
                            }
                            else
                                modified.SetPixel(x, y, Color.Black);

                            Color upRight = modified.GetPixel(x + 1, y - 1);
                            Color downLeft = modified.GetPixel(x - 1, y + 1);

                            int totalupRight = upRight.R + upRight.G + upRight.B;
                            int totalDownLeft = downLeft.R + downLeft.G + downLeft.B;
                            if (totalupRight > (totalCurrent + noise))
                            {
                                modified.SetPixel(x + 1, y - 1, Color.White);
                            }
                            else if (totalDownRight > (totalCurrent + noise))
                            {
                                modified.SetPixel(x - 1, y + 1, Color.White);
                            }
                            else
                                modified.SetPixel(x, y, Color.Black);
                        }
                        catch (System.ArgumentException)
                        {

                        }
                    }
                }
            }


        }

        ///<summary>
        ///outlines the edges of an image
        ///</summary>
        public static void OutLineEdges(Bitmap original, ref Bitmap modified, Color c, int noise)
        {
            Graphics g = Graphics.FromImage(original);
            for (Int32 x = 0; x < original.Width; x++)
            {
                for (Int32 y = 0; y < original.Height; y++)
                {
                    if (x > 2 && y > 2)
                    {
                        try
                        {
                            Color current = modified.GetPixel(x, y);
                            Color right = modified.GetPixel(x + 1, y);
                            Color left = modified.GetPixel(x - 1, y);

                            int totalCurrent = current.R + current.G + current.B;
                            int totalRight = right.R + right.G + right.B;
                            int totalLeft = left.R + left.G + left.B;

                            if (totalCurrent > (totalLeft + noise) || totalCurrent > (totalRight + noise))
                            {
                                modified.SetPixel(x - 1, y, c);
                            }
                            else if (totalCurrent > (totalRight + noise))
                            {
                                modified.SetPixel(x + 1, y, c);
                            }

                            Color upOne = modified.GetPixel(x, y - 1);
                            Color downOne = modified.GetPixel(x, y + 1);

                            int totalUpOne = upOne.R + upOne.G + upOne.B;
                            int totalDownOne = downOne.R + downOne.G + downOne.B;

                            if (totalUpOne > (totalCurrent + noise)) //|| totalDownOne > (totalCurrent + 75))
                            {
                                modified.SetPixel(x, y - 1, c);
                            }
                            else if (totalDownOne > (totalCurrent + noise))
                            {
                                modified.SetPixel(x, y + 1, c);
                            }

                            Color upLeft = modified.GetPixel(x - 1, y - 1);
                            Color downRight = modified.GetPixel(x + 1, y + 1);

                            int totalUpLeft = upLeft.R + upLeft.G + upLeft.B;
                            int totalDownRight = downRight.R + downRight.G + downRight.B;
                            if (totalUpLeft > (totalCurrent + noise))
                            {
                                modified.SetPixel(x - 1, y - 1, c);
                            }
                            else if (totalDownRight > (totalCurrent + noise))
                            {
                                modified.SetPixel(x + 1, y + 1, c);
                            }

                            Color upRight = modified.GetPixel(x + 1, y - 1);
                            Color downLeft = modified.GetPixel(x - 1, y + 1);

                            int totalupRight = upRight.R + upRight.G + upRight.B;
                            int totalDownLeft = downLeft.R + downLeft.G + downLeft.B;
                            if (totalupRight > (totalCurrent + noise))
                            {
                                modified.SetPixel(x + 1, y - 1, c);
                            }
                            else if (totalDownRight > (totalCurrent + noise))
                            {
                                modified.SetPixel(x - 1, y + 1, c);
                            }

                        }
                        catch (System.ArgumentException)
                        {

                        }
                    }
                }
            }
        }







        ///<summary>
        ///detects skin. loops through the pixels in the image, if the pixel is skin then it leaves that pixel alone,
        ///or else it will color that pixel black.
        ///</summary>
        public static void DetectSkin(Bitmap original, ref Bitmap modified)
        {
            Graphics g = Graphics.FromImage(original);
            ArrayList points = new ArrayList();
            for (Int32 x = 0; x < original.Width; x++)
            {
                for (Int32 y = 0; y < original.Height; y++)
                {


                    Color c = modified.GetPixel(x, y);


                    /* convert RGB color space to IRgBy color space using this formula:
                    I= [L(R) + L(B) + L(G)] / 3
                    Rg = L(R) - L(G)
                    By = L(B) - [L(G) +L(R)] / 2
					
                    to calculate the hue:
                    hue = atan2(Rg,By) * (180 / 3.141592654f)
                    */
                    double I = (Math.Log(c.R) + Math.Log(c.B) + Math.Log(c.G)) / 3;
                    double Rg = Math.Log(c.R) - Math.Log(c.G);
                    double By = Math.Log(c.B) - (Math.Log(c.G) + Math.Log(c.R)) / 2;
                    double hue = Math.Atan2(Rg, By) * (180 / Math.PI);




                    if (I <= 5 && (hue >= 4 && hue <= 255))
                    {
                        //r = 255;
                        points.Add(new Point(x, y));
                    }
                    else
                    {
                        modified.SetPixel(x, y, Color.Black);
                    }


                }
            }
            //SortPoints(ref points);
            //PlotLines(Graphics.FromImage(modified), (Point)points[0], (Point)points[points.Count - 1]);
        }

        private static void PlotLines(Graphics g, Point p1, Point p2)
        {
            g.DrawLine(Pens.White, p1, p2);
        }

        private static void SortPoints(ref ArrayList pts)
        {
            //int x = 4;
            for (int i = 1; i < pts.Count; i++)
            {
                Point thisPoint = (Point)pts[i];
                Point lastPoint = (Point)pts[i - 1];
                if (thisPoint.X < lastPoint.X && thisPoint.Y < lastPoint.Y)
                {
                    //thisPoint is closer to 0,0
                }
                else
                {
                    //lastPoint is closer to 0,0
                    //swap thisPoint and lastPoint
                    swap(ref pts, i - 1, i);
                }
            }
            //--x;
            //if(!(x == 0)) SortPoints(ref pts);
        }

        private static void swap(ref ArrayList pts, int a, int b)
        {
            Point temp;
            Point pA = (Point)pts[a];
            Point pB = (Point)pts[b];

            temp = pA;
            pA = pB;
            pB = temp;
        }

        private static int max(int r, int g, int b)
        {
            if (r > g && r > b)
                return r;
            else if (g > r && g > b)
                return g;
            else
                return b;
        }

        private static int min(int r, int g, int b)
        {
            if (r < g && r < b)
                return r;
            else if (g < r && g < b)
                return g;
            else
                return b;
        }

    }
}