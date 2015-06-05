using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.IO.Compression;

namespace bitmap_Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap myBitmap;

        public void SetPixel_Example(PaintEventArgs e)
        {

            // Create a Bitmap object from a file.
            //Bitmap myBitmap = new Bitmap(@"E:\flx.JPG");

            // Draw myBitmap to the screen.
            e.Graphics.DrawImage(myBitmap, 0, 0, myBitmap.Width,
                myBitmap.Height);

            // Set each pixel in myBitmap to black.
           /* for (int Xcount = 0; Xcount < myBitmap.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < myBitmap.Height; Ycount++)
                {
                    myBitmap.SetPixel(Xcount, Ycount, Color.Black);
                }
                
            }
            //Color bb = new Color();
            

            // Draw myBitmap to the screen again.
            e.Graphics.DrawImage(myBitmap, myBitmap.Width, 0,
                myBitmap.Width, myBitmap.Height);*/
        }
        FileStream fs,fs2;
        BinaryReader br, br2;
        bool FirstTime=true;
        void OpenGetNextPixel(string file1, string file2)
        {
            int offset = 0, offset2 = 0, size = 0, bitsPerPixel = 0, infoHeaderSize = 0, width = 0, hieght = 0,size2 = 0, bitsPerPixel2 = 0, infoHeaderSize2 = 0, width2 = 0, hieght2 = 0;

           // if (FirstTime)
            {
                //MessageBox.Show(((int)('B')).ToString());

                fs = new FileStream(file1, FileMode.Open, FileAccess.Read, FileShare.None);
                br = new BinaryReader(fs);
                fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read, FileShare.Read);
                br2 = new BinaryReader(fs2);

                if (br.ReadChar() != 'B' || br.ReadChar() != 'M')
                {
                    MessageBox.Show("Bmp1 Is Not True Bmp Format.");
                    br.Close();
                    br2.Close();
                    return;
                }
                if (br2.ReadChar() != 'B' || br2.ReadChar() != 'M')
                {
                    MessageBox.Show("Bmp2 Is Not True Bmp Format.");
                    br.Close();
                    br2.Close();
                    return;
                }
               // FirstTime = false;
            }
            size=br.ReadInt32();
            size2 = br2.ReadInt32();
            //MessageBox.Show("True Bmp File & Size=" + ( size/ 1024).ToString());
            br.ReadInt32();
            br2.ReadInt32();
            
            offset = br.ReadInt32();//data offset
            offset2 = br2.ReadInt32();//data offset

            infoHeaderSize = br.ReadInt32();//infoHeader structre Size
            infoHeaderSize2 = br2.ReadInt32();//infoHeader structre Size

            width = br.ReadInt32();//width
            MessageBox.Show("width= " + width.ToString());
            hieght = br.ReadInt32();//hieght
            width2 = br2.ReadInt32();//width
            hieght2 = br2.ReadInt32();//hieght

            myBitmap = new Bitmap(width, hieght);

            br.ReadInt16();//planes
            bitsPerPixel = br.ReadInt16();
            br2.ReadInt16();//planes
            bitsPerPixel2 = br2.ReadInt16();
            //MessageBox.Show("width= " + width.ToString() + "  hieght= " + hieght.ToString() + "  bitsPerPixel= " + bitsPerPixel.ToString()+"  Image size-offset= "+(offset).ToString());
            //br.ReadBytes(24);
            fs.Seek(offset, SeekOrigin.Begin);
            fs2.Seek(offset2, SeekOrigin.Begin);
            int j = 0, i = 0; byte[] bytereaded;
            bytereaded = new byte[6];
            for (i = 1; i <=hieght; i++)//((size*1024)-offset)/width
            {
                for (j = 1; j <= width; j++)
                {
                    bytereaded[0] = br.ReadByte();
                    bytereaded[1] = br.ReadByte();
                    bytereaded[2] = br.ReadByte();

                    bytereaded[3] = br2.ReadByte();
                    bytereaded[4] = br2.ReadByte();
                    bytereaded[5] = br2.ReadByte();
                    // x.R = bytereaded; x.G = bytereaded; ; x.B = bytereaded;
                    //x=ColorTranslator.FromHtml(toHex(bytereaded));
                    //sw2.WriteLine(x.ToString());
                    myBitmap.SetPixel(j - 1, myBitmap.Height - i, Color.FromArgb(PosIt(bytereaded[5]-bytereaded[2])
                        ,PosIt(bytereaded[4]- bytereaded[1]),PosIt( bytereaded[3]-bytereaded[0])));//(Color)Enum.ToObject(Type.GetType("KnownColor"),bytereaded));/*(Color)cv.ConvertTo(intcolor,x.GetType()));*/
                }           // Color.FromArgb(bytereaded, bytereaded, bytereaded)
                this.Text = i.ToString()+" "+j.ToString();
            }
            br.Close();
            br2.Close();
            this.pictureBox1.Image = myBitmap;
        }
        int PosIt(int x)
        {
            return x >= 0 ? x : -1 * x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenGetNextPixel(this.textBox1.Text, this.textBox2.Text);
        }

        string toHex(int num)
        {
            //string hexNum = "";
            if (num != 0)
            {
                return  toHex(num / 16) + (num % 16).ToString();
            }
            return "0";

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //SetPixel_Example(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Image Files(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) textBox1.Text = openFileDialog1.FileName;
            //textBox1.Text = file1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Image Files(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) textBox2.Text = openFileDialog1.FileName;
//            textBox2.Text = file2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MemoryStream mss=new MemoryStream();
            this.pictureBox1.Image.Save(mss, ImageFormat.Bmp);
            byte[] bytData = mss.ToArray();
            mss = null;
            MessageBox.Show(bytData.Length.ToString());
            byte[] compressedData;
            //try
            {
                MemoryStream ms = new MemoryStream();
                Stream s = new GZipStream(ms, CompressionMode.Compress);
                s.Write(bytData, 0, bytData.Length);
                s.Close();
                compressedData = (byte[])ms.ToArray();
                
                //File.WriteAllBytes(
            }
           // catch
            {
                //return null;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, compressedData);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}