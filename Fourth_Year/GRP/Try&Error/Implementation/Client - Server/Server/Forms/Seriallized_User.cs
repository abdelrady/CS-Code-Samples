using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace ChatServer
{
    /*
     * Wrapper Class By **Eagles**
     */
    public class Seriallized_User
    {
        User user = new User();
        public Seriallized_User(DataRow RowData)
        {
            user.m_userValid = (RowData["userValid"].ToString()=="True")?true:false;
            user.m_userfName = RowData["userfName"].ToString();
            user.m_userStage = RowData["userStage"].ToString();
            user.m_userDescription = RowData["userDescription"].ToString();
            user.m_userPhone = RowData["userPhone"].ToString();
            user.m_userEmail = RowData["userEmail"].ToString();
            user.m_userlName = RowData["userlName"].ToString();
            
        }
         public byte[]Seriallze()
         { 
             MemoryStream MemStr = new MemoryStream();
             BinaryFormatter formatter = new BinaryFormatter();
             byte[] buffer = null;
             try
             {               
                 formatter.Serialize(MemStr, user);
                 buffer= new byte[MemStr.Length];
                 MemStr.Read(buffer,0,(int)MemStr.Length);
                 MemStr.Close();
             }
             catch (Exception error)
             {
                 MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            return buffer;
         }
    }
    [Serializable()]
     class User
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
