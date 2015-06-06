using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;


namespace BabyKeyboardBash
{

    static class Program
    {
        public static KeyboardHook kh;
        public static NameValueCollection appSettings = 
            ConfigurationManager.AppSettings;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Read setting from application config file
            string khParam = Program.appSettings["KeyboardHookConfig"];
            using (kh = new KeyboardHook(khParam))
            {
                Application.Run(new Form1());
            }
        }

    }
}