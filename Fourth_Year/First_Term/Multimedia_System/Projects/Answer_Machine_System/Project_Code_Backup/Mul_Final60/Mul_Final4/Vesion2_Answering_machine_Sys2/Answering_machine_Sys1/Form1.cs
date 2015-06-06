using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Data.OleDb;
using tapi1_cs;
using audio;
using System.Threading;
using System.IO;

namespace Answering_machine_Sys1
{

    public partial class Form1 : Form
    {
        tapi1_cs.TAPI TapiObj = new tapi1_cs.TAPI();
        public static int LineID;
        //static bool first = false;
        //string filename;
        //static bool year1, year2, year3, year4;
        //static string idstr;
        //int idint;
        //------------------------------------------------------------------------
        //The declare for AppFace
        [DllImport("appfaceu.dll")]
        public static extern int SkinStart(string SkinFile, int nDefWinType, string CheckSum, int nType,
            int hInstance, int nLen);
        [DllImport("appfaceu.dll")]
        public static extern int SkinRemove();
        [DllImport("appfaceu.dll")]
        public static extern int SkinWindowSet(IntPtr hWnd, int nSkintype);
        [DllImport("appfaceu.dll")]
        public static extern int SkinWindowSetEx(IntPtr hWnd, int nSkintype, int nResourceId,
            int nUrfLoadType, string SkinFile, int hInstance, int nLen);
        //------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
            TapiObj.OnPlayWaveFile += new TAPI.PlayWaveFile(TapiObj_OnPlayWaveFile);
            TapiObj.ShowThisMessage += new TAPI.ShowMessage(TapiObj_ShowThisMessage);
            TapiObj.Add2DB += new TAPI.add2DB(TapiObj_Add2DB);
            TapiObj.CallAccepted += new TAPI.AcceptCall(TapiObj_CallAccepted);
            TapiObj.CallDropped += new TAPI.DropCall(TapiObj_CallDropped);
        }

        void TapiObj_CallDropped()
        {
            DropCall();
        }

        void TapiObj_CallAccepted()
        {
            acceptCall();
        }

        void TapiObj_Add2DB(int Rate)
        {
            Add2DB(Rate);
        }

        void TapiObj_ShowThisMessage(string msg)
        {
            lock (this)
            {
                showMessage(msg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //startModem();
            int nError = 0, lUnused = 0, lLineID = 0, lNegVer = 0;
            long lPrivilege = 0, lMediaMode = 0;
            int Unused = 0;
            lMediaMode = 8;
            TAPI.lineextensionid lpExtensionID = new
            TAPI.lineextensionid();

            IntPtr HInstance = IntPtr.Zero;
            lPrivilege = TapiObj.LINECALLPRIVILEGE_OWNER +
            TapiObj.LINECALLPRIVILEGE_MONITOR;

            Module thisModule;
            thisModule = Assembly.GetExecutingAssembly().GetModules()[0];
            HInstance = Marshal.GetHINSTANCE(thisModule);
            TAPI.LineCallBackDelegate callback = new
            TAPI.LineCallBackDelegate(TapiObj.LineCallBack);

            nError = TAPI.lineInitialize(ref TapiObj.hTapi,
            HInstance.ToInt32(),
            callback, ref Unused, ref TapiObj.lNumLines);
            if (nError != 0) tbStatus.Text += "Can't Initialize TapiObj."
                + Environment.NewLine;

            nError = TAPI.lineNegotiateAPIVersion(TapiObj.hTapi, DeviceID,
              TapiObj.TAPIVERSION, TapiObj.TAPIVERSION,
              ref lNegVer, ref lpExtensionID);
            if (nError != 0) tbStatus.Text += "Can't negotiate TapiObj Version."
                + Environment.NewLine;

            nError = TAPI.lineOpen(TapiObj.hTapi, DeviceID,
            ref TapiObj.hLine,
            lNegVer, lUnused, ref lUnused,
            (int)lPrivilege, (int)lMediaMode, ref lUnused);

            if (nError != 0)
            {
                tbStatus.Text += "Can't Open Modem Device,On ID: "
                + DeviceID.ToString() + Environment.NewLine;
            }
            else
            {
                tbStatus.Text += Environment.NewLine + "Voice Modem Device Found."
                    + Environment.NewLine;
                LineID = lLineID + 1;
                
                button1.Enabled = false;
                button2.Enabled = true;

            }
            
            TapiObj.lpLineDevCaps.dwTotalSize = Marshal.SizeOf(TapiObj.lpLineDevCaps);
            nError = TAPI.lineGetDevCaps(TapiObj.hTapi, lLineID, lNegVer, lUnused,
             ref TapiObj.lpLineDevCaps);

            TAPI.lineSetStatusMessages(TapiObj.hLine,
             TapiObj.lpLineDevCaps.dwLineStates, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stopModem() == 0)
            {
                button1.Enabled=true;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acceptCall();
        }
        

        public static byte[]RawSerialize(object anything)
        {
            int rawsize =
                Marshal.SizeOf(anything);
            IntPtr buffer =
                Marshal.AllocHGlobal(rawsize);
            Marshal.StructureToPtr(anything,
                buffer, false);
            byte[] rawdata = new byte[rawsize];
            Marshal.Copy(buffer, rawdata,
                0, rawsize);
            Marshal.FreeHGlobal(buffer);
            return rawdata;
        }

        public int line2id = 0;
        public void startModem()
        {
            int nError = 0, lUnused = 0, lLineID = 0, lNegVer = 0;
            string devName = "";
            TAPI.lineextensionid lpExtensionID = new TAPI.lineextensionid();
            long lPrivilege = 0, lMediaMode = 0;
            IntPtr HInstance = IntPtr.Zero;
            lPrivilege = TapiObj.LINECALLPRIVILEGE_OWNER +
            TapiObj.LINECALLPRIVILEGE_MONITOR;

            lMediaMode = 8;

            Module thisModule;
            thisModule = Assembly.GetExecutingAssembly().GetModules()[0];
            HInstance = Marshal.GetHINSTANCE(thisModule);
            TAPI.LineCallBackDelegate callback = new
            TAPI.LineCallBackDelegate(TapiObj.LineCallBack);
            
            int Unused = 0;
            nError = TAPI.lineInitialize(ref TapiObj.hTapi,
            HInstance.ToInt32(),
            callback, ref Unused, ref TapiObj.lNumLines);
            if (nError != 0) tbStatus.Text += "Can't Initialize TapiObj."
                + Environment.NewLine;
            tbStatus.Text += "Number of Modem Devices Found: "
                + TapiObj.lNumLines + "." + Environment.NewLine;
            
            //TapiObj.lNumLines = 1;//For Testing default Modem Device
            for (lLineID = 0; lLineID < TapiObj.lNumLines; lLineID++)
            {
                nError = TAPI.lineNegotiateAPIVersion(TapiObj.hTapi, lLineID,
                TapiObj.TAPIVERSION, TapiObj.TAPIVERSION,
                ref lNegVer, ref lpExtensionID);
                if (nError != 0) tbStatus.Text += "Can't negotiate TapiObj Version."
                    + Environment.NewLine;

                nError = TAPI.lineOpen(TapiObj.hTapi, lLineID,
                ref TapiObj.hLine,
                lNegVer, lUnused, ref lUnused,
                (int)lPrivilege, (int)lMediaMode, ref lUnused);
                if (nError != 0) tbStatus.Text += "Can't Open Modem Device,On ID: "
                    + lLineID.ToString() + Environment.NewLine;
                else
                {
                    tbStatus.Text += "Voice Modem Device Found."
                        + Environment.NewLine;
                    LineID = lLineID + 1;
                    break;
                }
            }
            
            TapiObj.lpLineDevCaps.dwTotalSize = Marshal.SizeOf(TapiObj.lpLineDevCaps);
            int error = TAPI.lineGetDevCaps(TapiObj.hTapi, lLineID, lNegVer, lUnused,
             ref TapiObj.lpLineDevCaps);
            if (error == 0) tbStatus.Text += "Device Name: ";
            else tbStatus.Text += "Can't found device Name." + Environment.NewLine;
            if (TapiObj.lpLineDevCaps.dwLineNameSize != 0)
            {
                byte[] byt = RawSerialize(TapiObj.lpLineDevCaps);
                for (int i = 0; i < TapiObj.lpLineDevCaps.dwLineNameSize; i++)
                {
                    devName += Convert.ToString((char)
                        (byt[TapiObj.lpLineDevCaps.dwLineNameOffset + i]));
                }
                tbStatus.Text += devName;
                tbStatus.Text += " ." + Environment.NewLine;
            }
            TAPI.lineSetStatusMessages(TapiObj.hLine,
             TapiObj.lpLineDevCaps.dwLineStates, 0);
        }

        public void acceptCall()
        {
            int nError;
            string szUnused = "";
            nError = TAPI.lineAnswer(TapiObj.hCall, ref szUnused, 0);
            TAPI.lineMonitorDigits(TapiObj.hCall,
            TapiObj.LINEDIGITMODE_DTMF);
        }

        public void showMessage(string message)
        {
            tbStatus.Text += message + Environment.NewLine;
        }

        public int stopModem()
        {
            int nError;
            nError = TAPI.lineShutdown(TapiObj.hTapi);
            return nError;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TapiObj.userInterface = this;
            audio.audio.userinterface = this;
            this.CenterToScreen();

            SkinStart(Application.StartupPath + "\\spring.urf", 4, "", 1, 0, 0);
            //Pushbutton
            SkinWindowSet(button1.Handle, 208);//SKIN_CLASS_PUSHBUTTON
            SkinWindowSet(button2.Handle, 208);//SKIN_CLASS_PUSHBUTTON
            SkinWindowSet(button3.Handle, 208);//SKIN_CLASS_PUSHBUTTON

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopModem();
            CloseFile();
            StreamWriter sw = new StreamWriter("Results.txt",true, Encoding.ASCII);
            sw.Write(tbStatus.Text);
            sw.Close();
            SkinRemove();
        }
        internal void DropCall()
        {
            TAPI.lineDrop(TapiObj.hCall, "", 0);
            TAPI.lineDeallocateCall(TapiObj.hCall);
           //tbStatus.Text+= TapiObj.lineDrop(TapiObj.hCall, "", 0).ToString()+Environment.NewLine;
           //tbStatus.Text += TapiObj.lineDeallocateCall(TapiObj.hCall).ToString() + Environment.NewLine;
        }
        
        
        public static void playWave2(string p)
        {
            //string lineID = TAPI.GetLineID("wave/out");
            //audio.audio.LoadFile(ref p);
            //if (lineID != "-1") audio.audio.Play(short.Parse(lineID));
            //OpenFile(p);
            //for (short i = 1; i <= TapiObj.lNumLines + 1; i++)
            //audio.audio.Play(i);//short.Parse(LineID.ToString()));//(short)Convert.ToInt32(lineID));
        }


        void TapiObj_OnPlayWaveFile(string File)
        {
            string lineID = TapiObj.GetLineID("wave/out");
            LineID = int.Parse(lineID);
            OpenFile(File);
            Play(int.Parse(lineID));
        }


        private WaveLib.WaveOutPlayer m_Player;
        private WaveLib.WaveFormat m_Format;
        private Stream m_AudioStream;
        Random rr = new Random(1);
        private void Filler(IntPtr data, int size)
        {
            byte[] b = new byte[size];
            if (m_AudioStream != null)
            {
                int pos = 0;
                //while (pos < size)
                {
                    int toget = size - pos;
                    int got = m_AudioStream.Read(b, pos, toget);
                    if (got < toget)
                    {
                        m_AudioStream.Position = 0; // loop if the file ends
                        m_Player.m_Finished = true;
                    }
                    pos += got;
                }
            }
            else
            {
                //for (int i = 0; i < b.Length; i++)
                /*b[i] =*/
                rr.NextBytes(b);//fill array with random numbers
            }
            System.Runtime.InteropServices.Marshal.Copy(b, 0, data, size);
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
        }

        private void Play(int deviceID)
        {
            Stop();
            if (m_AudioStream != null)
            {
                m_AudioStream.Position = 0;
                m_Player = new WaveLib.WaveOutPlayer(deviceID, m_Format, 4096/*16384*/, 10/*3*/, new WaveLib.BufferFillEventHandler(Filler));
            }
        }

        private void CloseFile()
        {
            Stop();
            if (m_AudioStream != null)
                try
                {
                    m_AudioStream.Close();
                }
                finally
                {
                    m_AudioStream = null;
                }
        }
        private void OpenFile(string FileName)
        {
                CloseFile();
                try
                {
                    WaveLib.WaveStream S = new WaveLib.WaveStream(FileName);
                    if (S.Length <= 0)
                        throw new Exception("Invalid WAV file");
                    m_Format = S.Format;
                    if (m_Format.wFormatTag != (short)WaveLib.WaveFormats.Pcm && m_Format.wFormatTag != (short)WaveLib.WaveFormats.Float)
                        throw new Exception("Olny PCM files are supported");

                    m_AudioStream = S;
                }
                catch (Exception e)
                {
                    CloseFile();
                    showMessage(e.Message);
                }
        }

        internal void Add2DB(int dwParam1)
        {
            Stop();//if there is already wave stream playing, Stop it first.
            
            string val = "Exellent";
            switch (dwParam1)
            {
                case 1:
                    val = "Exellent";
                    break;
                case 2:
                    val = "Good";
                    break;
                case 3:
                    val = "bad";
                    break;
            }
            OleDbConnection cnn = new OleDbConnection(
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                +"results.mdb;Persist Security Info=False");
            cnn.Open();
            OleDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText="INSERT INTO results(vote) Values('"+val+"')";
            int x=cmd.ExecuteNonQuery();
            tbStatus.Text += "cmd.ExecuteNonQuery: " + x.ToString() + Environment.NewLine;
            if (x<1)
            {
                //audio.audio.FreeMemory();
                TapiObj_OnPlayWaveFile("Try_again_later.wav");
                return;
            }

            cnn.Close();
            //audio.audio.FreeMemory();
            TapiObj_OnPlayWaveFile("thank_you.wav");
            //while (audio.audio.playing) ;
            DropCall();
        }

        internal static void msg(string p)
        {
            //tbStatus.Text += Environment.NewLine+p;
            MessageBox.Show(p);
        }

        int DeviceID = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            Setup frm = new Setup(TapiObj);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tbStatus.Text += "Selected Device ID= " + frm.lineID;
                tbStatus.Text += Environment.NewLine + "Device Desc.= " + frm.lineDevName + Environment.NewLine;
                DeviceID=frm.lineID;
                TapiObj.RingsCount = frm.RingsCount;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TapiObj.GetLineID("wave/out"));
        }

    }
}