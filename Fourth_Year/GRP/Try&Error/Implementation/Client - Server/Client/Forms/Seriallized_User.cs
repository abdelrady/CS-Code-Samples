using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ChatClient
{
    /*
     * Wrapper Class By **Eagles**
     */
    public class Seriallized_User
    {
        public User User_Obj = null;
        public Seriallized_User(){}         
        public void De_Seriallze(byte[]Buffer)
        {

            MemoryStream MemStr = new MemoryStream(Buffer);
            BinaryFormatter formatter = new BinaryFormatter();

            User_Obj = (User)formatter.Deserialize(MemStr);

            MemStr.Close();
         
        }
    }
    [Serializable()]
     public class User
    {
        public  bool   m_userValid;
        public  string m_userfName;
        public  string m_userStage;
        public  string m_userDescription;      
        public  string m_userPhone;
        public  string m_userEmail;
        public  string m_userlName;

        public  object m_userImage;
        public User() { }
    }
}
