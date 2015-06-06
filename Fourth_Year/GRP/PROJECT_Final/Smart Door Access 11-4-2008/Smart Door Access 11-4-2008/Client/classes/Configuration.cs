using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SmartDoor
{
    class Configuration
    {

        public static string ServerIP = "";
        public static string ServerPort = "";
        public static string ClientPassword = "";
        public static string ClientId = "";
        public static string ClientName = "";

        public static string StandaloneMode = "";
        public static string StandaloneModeStudentsFile = "";
        public static string NormalModeStudentsFile = "";

        public static string TextLog = "";
        public static string TextLogFileName = "";

        public static int WaitOnOpened =5000;
        public static int LptPortAddressBase =888;
        public static string UpdatesPort = "";
        public static bool AutoConnect = true;
        public static string TimeOut = "";
        public static string connectionString = "";
        public static bool SQLConnection = false;
        public static void Read_Config()
        {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Data\\Config.ini");
            SQLConnection = Parse_Value(reader.ReadLine().ToLower()) == "True".ToLower() ? true : false;
            ServerIP = Parse_Value(reader.ReadLine());
            ServerPort = Parse_Value(reader.ReadLine());
            ClientPassword = Parse_Value(reader.ReadLine());
            ClientId = Parse_Value(reader.ReadLine());
            ClientName = Parse_Value(reader.ReadLine());

            StandaloneMode = Parse_Value(reader.ReadLine());
            StandaloneModeStudentsFile = Parse_Value(reader.ReadLine());
            NormalModeStudentsFile = Parse_Value(reader.ReadLine());

            TextLog = Parse_Value(reader.ReadLine());
            TextLogFileName = Parse_Value(reader.ReadLine());

            /*Door Properties*/
            WaitOnOpened =int.Parse(Parse_Value(reader.ReadLine()));
            LptPortAddressBase = int.Parse(Parse_Value(reader.ReadLine()));
            /*End Of Properties*/

            UpdatesPort = Parse_Value(reader.ReadLine());
            AutoConnect = Parse_Value(reader.ReadLine().ToLower()) == "True".ToLower() ? true : false;
            TimeOut = Parse_Value(reader.ReadLine());
            //connectionString = (reader.ReadLine());
            
            //MessageBox.Show(connectionString);
            connectionString = Parse_Value(reader.ReadLine());
            
            
            reader.Close();
        }
        private static string Parse_Value(string Value)
        {
            /*
             * By Eagles
             */
            //MessageBox.Show(Value);
             return (Value.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries))[1].Trim();
            
            
        }


        internal static bool Not_Valid()
        {
            try
            {
                Read_Config();
            }
            catch
            {
                return true;
            }
            if (
                ServerIP == "" ||
                ServerPort == "" ||
                ClientPassword == "" ||
                ClientId == "" ||
                ClientName == "" ||
                connectionString==""
                )
                return true;
            return false;
        }
        public static void Open_Configuration_File()
        {
            Process.Start(Directory.GetCurrentDirectory() + "\\Data\\Config.ini");
        }

        internal static void Write_Config(
            string p,
            string p_2,
            string p_3,
            string p_4,
            string p_5,
            string p_6,
            string p_7,
            string p_8,
            string p_9,
            string p_10,
            string p_11,
            string p_12,
            string p_13,
            bool p_14,
            string p_15,
            string p_16,
            bool p_17)
        {
            StreamWriter Writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Data\\Config.ini");
            Writer.WriteLine("SQLSERVER Connection=" + p_17);
            Writer.WriteLine("ServerIP=" + p);
            Writer.WriteLine("ServerPort=" + p_2);
            Writer.WriteLine("ClientPassword=" + p_3);
            Writer.WriteLine("ClientId=" + p_4);
            Writer.WriteLine("ClientName=" + p_5);

            Writer.WriteLine("StandaloneMode=" + p_6);
            Writer.WriteLine("StandaloneModeStudentsFile=" + p_7);
            Writer.WriteLine("NormalModeStudentsFile=" +p_8 );

            Writer.WriteLine("TextLog=" +p_9 );
            Writer.WriteLine("TextLogFileName=" + p_10);

            Writer.WriteLine("WaitOnOpened=" + p_11);
            Writer.WriteLine("LptPortAddressBase=" + p_12);
            Writer.WriteLine("ListenOnUpdatesOnPort=" + p_13);
            Writer.WriteLine("AutoConnectToServer=" + p_14);
            Writer.WriteLine("Timeout interval of Auto Connect=" + p_15);
            Writer.WriteLine("connectionString=" + p_16);

            Writer.Close();    
        }

       
    }
}
