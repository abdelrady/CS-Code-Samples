using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Data;

namespace SmartDoor
{
   public class _Serialization
   {
      /// <summary>
      ///  Binary Serializes an object
      /// </summary>
      /// <param name="obj">The object to serialize</param>
      /// <returns>byte array</returns>
       User user ;
     public _Serialization(DataRow RowData)
        {
            user = new User();
            user.m_userValid = (RowData["userValid"].ToString() == "True") ? true : false;
            user.m_userfName = RowData["userfName"].ToString();
            user.m_userStage = RowData["userStage"].ToString();
            user.m_userDescription = RowData["userDescription"].ToString();
            user.m_userPhone = RowData["userPhone"].ToString();
            user.m_userEmail = RowData["userEmail"].ToString();
            user.m_userlName = RowData["userlName"].ToString();            
        }
       public  byte[] BinarySerialize()
      {
         byte[] serializedObject;
         MemoryStream ms = new MemoryStream();
         BinaryFormatter b = new BinaryFormatter();
         b.Serialize(ms, user);
         ms.Seek(0, 0);
         serializedObject = ms.ToArray();
         ms.Close();
         return serializedObject;
      }

      /// <summary>
      ///  Binary DeSerializes an object
      /// </summary>
      /// <param name="obj">The object to serialize</param>
      /// <returns>The deserialized object</returns>
      public  User BinaryDeSerialize (byte[] serializedObject)
      {
         MemoryStream ms = new MemoryStream();
         ms.Write(serializedObject, 0, serializedObject.Length);
         ms.Seek(0, 0);
         BinaryFormatter b = new BinaryFormatter();
         Object obj = b.Deserialize(ms);
         ms.Close();
         return (User)obj;
      }      
   }
}
