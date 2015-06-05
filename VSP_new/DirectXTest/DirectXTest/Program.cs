using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;
using System.IO;

namespace DirectXTest
{
    class Program : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.RUN();
        }

        private void RUN()
        {
            Device dev = new Device();
            SecondaryBuffer sound = null;
            BufferDescription desc;
            dev.SetCooperativeLevel(this, CooperativeLevel.Normal);
            WaveFormat wvx = new WaveFormat();
            wvx.BitsPerSample = 8;
            wvx.Channels = 1;
            wvx.SamplesPerSecond = 44100;
            wvx.AverageBytesPerSecond = 1 * 44100;
            desc = new BufferDescription(wvx);
            desc.GlobalFocus = true; // Why every time I click on another window my wav player dont pause?
            desc.ControlVolume = true;
            byte[] data = new byte[1 * 44100];
            double step = 0;
            double val = 0.0;
            for (int i = 0; i < 1 * 44100; i++)
            {
                val = ((Math.Sin(step)));// * Math.Pow(2, 3));
                Console.Write((val).ToString() + "   ");
                data[i] = (byte)val;
                step += (360 * 100 / 44100);
            }
            MemoryStream ms = new MemoryStream(data);
            //ms.Write(
            sound = new SecondaryBuffer(ms,44100, desc, dev);
            sound.SetCurrentPosition(0);
            sound.Play(0, BufferPlayFlags.Looping);
        }
    }
}
