using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
namespace SmartDoor
{
    public class FilePacket
    {
       
        public int mLength = 0;
        public int mProgress = 0;
        public MemoryStream ImageChunks = new MemoryStream();
        public Image ClientImage;
        public FilePacket()
        {
            mLength = 0;
        }
        public FilePacket( int FileLength)
        {           
            mLength = FileLength;
        }
        public void WriteData(byte[] Data, bool LiveDrawing)
        {
            ImageChunks.Write(Data, 0, Data.Length);
            mProgress += Data.Length;
            if (LiveDrawing)
            {
                ClientImage = Image.FromStream(ImageChunks);
                //ImageChunks.SetLength(0);
                //MessageBox.Show(ImageChunks.Length.ToString());
            }
        }

        internal void Truncate()
        {
            ImageChunks.SetLength(0);
        }
    }
}
