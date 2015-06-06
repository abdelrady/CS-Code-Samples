using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace SmartDoor
{
    class Configuration
    {
        public static string connectionString = "";
        public static string mainPortNumber = "";    
        public static string UpdatesPort = "";
        public static string sendUpdatesEvery = "";
        static StreamReader reader;
        public static void Read_Config()
        {
            reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Config.ini");
            connectionString = Parse_Value(reader.ReadLine());
            mainPortNumber = Parse_Value(reader.ReadLine());
            UpdatesPort = Parse_Value(reader.ReadLine());
            sendUpdatesEvery = Parse_Value(reader.ReadLine());           
            reader.Close();
        }
        private static string Parse_Value(string Value)
        {
            /*
             * By Eagle
             */
            return (Value.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries))[1];
        }
        internal static bool Not_Valid()
        {
            try { Read_Config(); }
            catch
            {
                if (reader != null) reader.Close();              
                Write_Config(@"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\db\SDASDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True", "5000", "5001", "60000");
                return true;
            }
            if (
                connectionString == "" ||
                mainPortNumber == "" ||
                UpdatesPort == "" ||
                sendUpdatesEvery == ""
                )
            {
                if (reader != null) reader.Close();
                Write_Config(@"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\db\SDASDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True", "5000", "5001", "60000");                   
                return true;
            }
            return false;
        }
        public static void Open_Configuration_File()
        {
            Process.Start(Directory.GetCurrentDirectory() + "\\Config.ini");
        }

        internal static void Write_Config(
            string p,
            string p_2,
            string p_3,
            string p_4
          )
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Config.ini"))
                File.Create(Directory.GetCurrentDirectory() + "\\Config.ini").Close();
            StreamWriter Writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Config.ini");

            Writer.WriteLine("connectionString=" + p);
            Writer.WriteLine("mainPortNumber=" + p_2);
            Writer.WriteLine("UpdatesPort=" + p_3);
            Writer.WriteLine("sendUpdatesEvery=" + p_4);
            
            Writer.Close();    
        }
    }
}
