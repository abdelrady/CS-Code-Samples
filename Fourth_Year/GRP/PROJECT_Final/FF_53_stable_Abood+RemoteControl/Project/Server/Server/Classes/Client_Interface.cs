using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
namespace SmartDoor
{
    class Client_Interface
    {
        /*„ €Ì— ⁄·‘«‰ «›—ﬁ «·⁄„·«¡ „‰ »⁄÷*/
        private int m_Key;
        public int M_Key
        {
            set { m_Key = value; }
            get { return m_Key; }
        }

        private Socket m_Connection;
        public Socket M_Connection
        {
            set { m_Connection = value; }
        }

        private NetworkStream m_NetworkStream;
        public NetworkStream M_NetworkStream
        {
            get { return m_NetworkStream; }
            set { m_NetworkStream = value; }
        }

        private BinaryReader m_Reader;
        public BinaryReader M_Reader
        {
            get { return m_Reader; }
            set { m_Reader = value; }
        }

        private BinaryWriter m_Writer;
        public BinaryWriter M_Writer
        {
            get { return m_Writer; }
            set { m_Writer = value; }
        }

        public Client_Interface() { }
        public Client_Interface(Socket Connection, int Key)
        {

            try
            {
                m_Key = Key;
                m_NetworkStream = new NetworkStream(Connection);
                m_Reader = new BinaryReader(m_NetworkStream);
                m_Writer = new BinaryWriter(m_NetworkStream);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(
                      e.ToString(),
                      "Streaming Error ",
                       System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Init_Client()
        {
            try
            {
                m_NetworkStream = new NetworkStream(m_Connection);
                m_Reader = new BinaryReader(m_NetworkStream);
                m_Writer = new BinaryWriter(m_NetworkStream);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(
                      e.ToString(),
                      "Streaming Error ",
                       System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void Init_Client(Socket Connection)
        {
            try
            {
                m_NetworkStream = new NetworkStream(Connection);
                m_Reader = new BinaryReader(m_NetworkStream);
                m_Writer = new BinaryWriter(m_NetworkStream);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(
                      e.ToString(),
                      "Streaming Error ",
                       System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void SendKey()
        {
            try{
                m_Writer.Write(m_Key);
                }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(
                      e.ToString(),
                      "Can't Send Key",
                       System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void Finilize()
        {
            try
            {
                m_NetworkStream.Flush();
                m_NetworkStream = null;
                m_Reader.BaseStream.Flush();
                m_Reader = null;
                m_Writer.BaseStream.Flush();
                m_Writer = null;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(
                      e.ToString(),
                      "Streaming Error ",
                       System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
