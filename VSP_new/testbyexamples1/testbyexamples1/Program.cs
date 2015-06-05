using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace testbyexamples1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            byte[] byt2=new byte[15];
            MemoryStream ms = new MemoryStream(byt2);
            for (int i = 0; i < 15; i++)
            {
                ms.WriteByte((byte)i);
            }
            Console.WriteLine("Reading From Buffer: ");
            foreach (byte b in byt2)
            {
                Console.Write("{0,-3}|", b);
            }
            
            Console.WriteLine("\r\nReading From MS: ");
            byte[] byt = ms.ToArray();//ms.GetBuffer();
            foreach (byte b in byt)
            {
                Console.Write("{0,-3}|", b);
            }
            ms.Close();
        }
    }
}