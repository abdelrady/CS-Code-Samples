using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    class AudioSender : IDisposable
    {
        private UdpClient client;
        private IPEndPoint sentPoint;
        private WaveLib.WaveInRecorder m_Recorder;
        private WaveLib.FifoStream m_Fifo = new WaveLib.FifoStream();
        private byte[] m_RecBuffer;
        private bool Stopped;
        private AudioSet Setting;
        public AudioSender(string IP, int SendPort)
        {
            sentPoint = new IPEndPoint(IPAddress.Parse(IP), SendPort);
            client = new UdpClient();
            Stopped = false;
            Setting = new AudioSet();
            try
            {
                LoadAudioSetting();
            }
            catch
            {
                Setting.bits = 16;
                Setting.buffers = 3;
                Setting.channels = 2;
                Setting.rate = 44100;
                Setting.size = 8192;
            }
        }
        private void LoadAudioSetting()
        {
            Setting = null;
            Stream stream = File.Open("AData.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Setting = (AudioSet)formatter.Deserialize(stream);
            stream.Close();
       

        }
        public void StopAudioChat()
        {
            Stopped = true;
            m_Fifo.Flush();
        }
        public void ResumeAudioChat()
        {
            Stopped = false;
        }

        private void DataArrived(IntPtr data, int size)
        {
            if (!Stopped)
                try
                {
                    if (m_RecBuffer == null || m_RecBuffer.Length < size)
                        m_RecBuffer = new byte[size];
                    System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
                    m_Fifo.Write(m_RecBuffer, 0, m_RecBuffer.Length);
                    //Microphone ==> data ==> m_RecBuffer ==> m_Fifo

                    client.Send(m_RecBuffer, m_RecBuffer.Length, sentPoint);
                }
                catch //(Exception d)
                {
                    //System.Windows.Forms.MessageBox.Show(d.Message + "\n Server:Error sending data");
                }
        }
        private void Stop()
        {

            if (m_Recorder != null)
                try
                {
                    m_Recorder.Dispose();
                }
                finally
                {
                    m_Recorder = null;
                }
            m_Fifo.Flush();
        }

        public void StartSendAudio()
        {

            try
            {
                WaveLib.WaveFormat fmt = new WaveLib.WaveFormat(Setting.rate, Setting.bits, Setting.channels);
                m_Recorder = new WaveLib.WaveInRecorder(-1, fmt, Setting.size, Setting.buffers, new WaveLib.BufferDoneEventHandler(DataArrived));
             //   WaveLib.WaveFormat fmt = new WaveLib.WaveFormat(44100, 16, 2);
            //    m_Recorder = new WaveLib.WaveInRecorder(-1, fmt, 8192, 3, new WaveLib.BufferDoneEventHandler(DataArrived));
            
            }
            catch
            {
                Stop();
                throw;
            }
        }

        public void Dispose()
        {
            Stop();
            client.Close();
            client = null;
            GC.SuppressFinalize(this);
        }


    }
}
