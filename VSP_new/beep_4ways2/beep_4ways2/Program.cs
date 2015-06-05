using System;
using System.Collections.Generic;
//using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Beep_4Ways1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // Import the Windows Beep() API function.
        [DllImport("kernel32.dll")]
        private static extern bool Beep(int freq, int dur);
        // Define some constants for using the PlaySound() function.
        public const int SND_FILENAME = 0x00020000;
        public const int SND_ASYNC = 0x0001;
        // Import the Windows PlaySound() function.
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound,
        int hmod,
        int fdwSound);
        [STAThread]
        static void Main(string[] args)
        {
            // Create a sound using an escape character.
            //Console.Write("\a");
            int x=0;
            Console.WriteLine("Press Any Key When Ready...");
            while (x < 40000)
            {
                //            Console.ReadLine();
                // Create a sound using a Windows API call.
                Beep(x, 200);
                Console.WriteLine(x.ToString());
                x+=10;
                //x = int.Parse(Console.ReadLine());
            }
            // Create a sound using a Visual Basic call.
            //Microsoft.VisualBasic.Interaction.Beep();
            //Console.WriteLine("Press Any Key When Ready...");
            //Console.ReadLine();
            // Create a sound using a WAV file.
            /*PlaySound("BELLS.WAV",
            0,
            SND_FILENAME | SND_ASYNC);
            Console.WriteLine("Press Any Key When Ready...");
            Console.ReadLine();*/
        }
    }
}