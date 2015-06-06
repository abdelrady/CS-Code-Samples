using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace RDB_test
{
    class Configuration
    {
        public static string connectionString = "";
        public static string userName;
        public static string userPassword;
        public static string ServerName;
        public static string DBName ;
        public static string ConnectionTimeout;
        public static string Encrypt = "Encrypt=False";//Œ·ÌÂ« “Ì „« ÂÌÂ «Ê⁄Ì  €Ì—Â« ⁄·‘«‰ «·‘»ﬂÂ
        public static string persistSecInfo = "Persist Security Info=True";
        public static string IntegratedSecurity = "False";//Œ·ÌÂ« “Ì „« ÂÌÂ «Ê⁄Ì  €Ì—Â« ⁄·‘«‰ «·‘»ﬂÂ
        public static string UserInstance="False";

        static StreamReader reader;

        public static void Read_Config()
        {
            reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Config.ini");
            connectionString = Parse_Value(reader.ReadLine());
            reader.Close();
            //MessageBox.Show(connectionString);
            SetConfigurationAttributes(Parse_Values(connectionString));//Set username,pass,........
            
            
        }

        private static void SetConfigurationAttributes(string[] p)
        {
            ServerName=p[0].Split('=')[1];
            DBName = p[1].Split('=')[1];
            IntegratedSecurity = p[2].Split('=')[1];
            userName = p[4].Split('=')[1];
            userPassword = p[5].Split('=')[1];
            ConnectionTimeout = p[6].Split('=')[1];
            UserInstance = p[8].Split('=')[1];
            
        }
        private static string Parse_Value(string Value)
        {
            /*
             * By Eagle
             */
            return (Value.Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries))[1];
        }
        private static string[] Parse_Values(string Value)
        {
            /*
             * By Eagle
             */
            return (Value.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
        }
        internal static bool Valid()
        {
            try { Read_Config(); }
            catch
            {
                if (reader != null) reader.Close();
                Write_Config(@"Data Source=FCIS\SQLEXPRESS;Initial Catalog=C:\db\SDASDB.mdf;Integrated Security=False;Persist Security Info=True;User ID=sa;Password=sa;Connect Timeout=30;Encrypt=False;User Instance=False");
                //Write_Config(@"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\db\SDASDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");
                return false;
            }
            if (connectionString == "")
            {
                if (reader != null) reader.Close();
                Write_Config(@"Data Source=FCIS\SQLEXPRESS;Initial Catalog=C:\db\SDASDB.mdf;Integrated Security=False;Persist Security Info=True;User ID=sa;Password=sa;Connect Timeout=30;Encrypt=False;User Instance=False");
                //Write_Config(@"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\db\SDASDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");                   
                return false;
            }
            return true;
        }
        public static void Open_Configuration_File()
        {
            Process.Start(Directory.GetCurrentDirectory() + "\\Config.ini");
        }

        internal static void Write_Config(string userName, string userPassword, string ServerName, string DBName, string IntegratedSecurity, string ConnectionTimeout, string UserInstance)
        {
            Configuration.ServerName = ServerName;
            Configuration.DBName = DBName;
            Configuration.IntegratedSecurity = IntegratedSecurity;
            Configuration.userName = userName;
            Configuration.userPassword = userPassword;
            Configuration.ConnectionTimeout = ConnectionTimeout;
            Configuration.UserInstance = UserInstance;

            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Config.ini"))
                File.Create(Directory.GetCurrentDirectory() + "\\Config.ini").Close();
            StreamWriter Writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Config.ini");

            Writer.WriteLine("connectionString=" +"Data Source="+ Configuration.ServerName + ';' +"Initial Catalog="+ Configuration.DBName +';'
                +"Integrated Security="+Configuration.IntegratedSecurity+';'+Configuration.persistSecInfo+';'+"User ID="+Configuration.userName+ ';' +
                "Password=" + Configuration.userPassword + ';' + "Connect Timeout=" + Configuration.ConnectionTimeout + ';' +
                Configuration.Encrypt + ';' + "User Instance="+Configuration.UserInstance);
            Writer.Close();    
        }
        internal static void Write_Config(string p)
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Config.ini"))
                File.Create(Directory.GetCurrentDirectory() + "\\Config.ini").Close();
            StreamWriter Writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Config.ini");

            Writer.WriteLine("connectionString=" +p);
            Writer.Close();    
        }
         
    }
}
