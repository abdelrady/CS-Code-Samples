using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Net.Sockets;
using System.Data;
/*
 * Wrapper Class By **Eagles**
 */
namespace Serialization
{
    public class Seriallized_User
    {
        public User User_Obj;   
        public Seriallized_User(NetworkStream netstr)
        {
         
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                User_Obj = (User)formatter.Deserialize(netstr);
                //System.Windows.Forms.MessageBox.Show("Deser Suc.");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Deserial Error " + e.Message);
            }
        }
    }
}