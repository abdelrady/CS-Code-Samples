using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client_s_
{
    class AudioReceiver : IDisposable
    {
        private UdpClient client;
        private IPEndPoint receivePoint;
        private WaveLib.WaveOutPlayer m_Player;
        private WaveLib.FifoStream m_Fifo = new WaveLib.FifoStream();
        private byte[] m_PlayBuffer;
        private bool Stopped;
        private AudioSet Setting;

        public AudioReceiver(string IP, int RcvPort)
        {
            receivePoint = new IPEndPoint(IPAddress.Parse(IP), RcvPort);
            client = new UdpClient(RcvPort);
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


        public void StartReceiveAudio()
        {
            Thread readThread = new Thread(new ThreadStart(Voice_In));
            readThread.Start();
            StartPlayAudio();
        }
        public void StopAudioChat()
        {
            Stopped = true;
        }
        private void Filler(IntPtr data, int size)
        {
            if (m_PlayBuffer == null || m_PlayBuffer.Length < size)
                m_PlayBuffer = new byte[size];
            if (m_Fifo.Length >= size)
                m_Fifo.Read(m_PlayBuffer, 0, size);
            else
                for (int i = 0; i < m_PlayBuffer.Length; i++)
                    m_PlayBuffer[i] = 0;
            System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
            // m_Fifo ==> m_PlayBuffer==> data ==> Speakers            
        }
        private void Voice_In()
        {
            while (true)
            {
                try
                {
                    if (!Stopped)
                        m_PlayBuffer = client.Receive(ref receivePoint);
                }
                catch { }
                m_Fifo.Write(m_PlayBuffer, 0, m_PlayBuffer.Length);
            }
        }
        private void Stop()
        {
            if (m_Player != null)
                try
                {
                    m_Player.Dispose();
                }
                finally
                {
                    m_Player = null;
                }

            m_Fifo.Flush();
        }

        private void StartPlayAudio()
        {
            try
            {
                 WaveLib.WaveFormat fmt = new WaveLib.WaveFormat(Setting.rate,Setting.bits, Setting.channels);
                 m_Player = new WaveLib.WaveOutPlayer(-1, fmt, Setting.size,Setting.channels, new WaveLib.BufferFillEventHandler(Filler));
               // WaveLib.WaveFormat fmt = new WaveLib.WaveFormat(44100, 16, 2);
               // m_Player = new WaveLib.WaveOutPlayer(-1, fmt, 8192, 3, new WaveLib.BufferFillEventHandler(Filler));
            }
            catch
            {
                Stop();
                throw;
            }

        }
        public void Dispose()
        {
            client.Close();
            client = null;
            GC.SuppressFinalize(this);
        }


    }
}
