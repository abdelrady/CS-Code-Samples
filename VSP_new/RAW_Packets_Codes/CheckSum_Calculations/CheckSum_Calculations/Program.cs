using System;
using System.Collections.Generic;
using System.Text;

namespace CheckSum_Calculations
{
    class Program
    {
        public static UInt16 getChecksum(byte[] data)
        {

            UInt32 chcksm = 0;
            int packetsize = 20;
            int index = 0;
            while (index < packetsize)
            {
                chcksm += Convert.ToUInt32(BitConverter.ToUInt16(data, index));
                index += 2;
            }
            chcksm = (chcksm >> 16) + (chcksm & 0xffff);
            chcksm += (chcksm >> 16);
            return (UInt16)(~chcksm);
        }
        static void Main(string[] args)
        {
            byte[] data = {0x45, 0x00, 0x00, 0x2b, 0x98, 0xc5, 0x00, 0x00,  0x80,
                            0x01, 0x60, 0x60, 0x7f, 0x00, 0x00, 0x01, 0xC0, 0xA8, 0x02,  0x03};
            UInt16 checkSum = getChecksum(data);
            Console.WriteLine(checkSum.ToString());

            byte[] dd = BitConverter.GetBytes(checkSum);

            Console.WriteLine(string.Format("{0:x}", dd[0]));
            Console.WriteLine(string.Format("{0:x}", dd[1]));
        }
    }
}
