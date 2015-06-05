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
        static string lineID;
        //static bool first = false;
        //string filename;
        //static bool year1, year2, year3, year4;
        //static string idstr;
        //int idint;
        //------------------------------------------------------------------------
        //The declare for AppFace
        [DllImport("appface.dll")]
        public static extern int SkinStart(string SkinFile, int nDefWinType, string CheckSum, int nType,
            int hInstance, int nLen);
        [DllImport("appface.dll")]
        public static extern int SkinRemove();
        [DllImport("appface.dll")]
        public static extern int SkinWindowSet(IntPtr hWnd, int nSkintype);
        [DllImport("appface.dll")]
        public static extern int SkinWindowSetEx(IntPtr hWnd, int nSkintype, int nResourceId,
            int nUrfLoadType, string SkinFile, int hInstance, int nLen);
        //------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startModem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopModem();
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

        public void startModem()
        {
            int nError = 0, lUnused = 0, lLineID = 0, lNegVer = 0;
            string devName = "";
            TAPI.lineextensionid lpExtensionID = new
            TAPI.lineextensionid();
            long lPrivilege = 0, lMediaMode = 0;
            IntPtr HInstance = IntPtr.Zero;
            lPrivilege = TAPI.LINECALLPRIVILEGE_OWNER +
            TAPI.LINECALLPRIVILEGE_MONITOR;
            lMediaMode = 8;
            Module thisModule;
            thisModule =Assembly.GetExecutingAssembly().GetModules()[0];
            HInstance = Marshal.GetHINSTANCE(thisModule);
            TAPI.LineCallBackDelegate callback = new
            TAPI.LineCallBackDelegate(TAPI.LineCallBack);
            int Unused = 0;
            nError = TAPI.lineInitialize(ref TAPI.hTAPI,
            HInstance.ToInt32(),
            callback, ref Unused, ref TAPI.lNumLines);
            if (nError != 0) tbStatus.Text += "Can't Initialize TAPI."
                + Environment.NewLine;
            tbStatus.Text += "Number of Modem Devices Found: "
                + TAPI.lNumLines +"."+ Environment.NewLine;
            for (lLineID = 0; lLineID < TAPI.lNumLines; lLineID++)
            {
                nError = TAPI.lineNegotiateAPIVersion(TAPI.hTAPI, lLineID,
                TAPI.TAPIVERSION, TAPI.TAPIVERSION,
                ref lNegVer, ref lpExtensionID);
                if (nError != 0) tbStatus.Text += "Can't negotiate TAPI Version."
                    + Environment.NewLine;

                nError = TAPI.lineOpen(TAPI.hTAPI, lLineID,
                ref TAPI.hLine,
                lNegVer, lUnused, ref lUnused,
                (int)lPrivilege, (int)lMediaMode, ref lUnused);
                if (nError != 0) tbStatus.Text += "Can't Open Modem Device,On ID: " 
                    + lLineID.ToString() + Environment.NewLine;
                else
                {
                    tbStatus.Text += "Voice Modem Device Found."
                        + Environment.NewLine;
                    break;
                }
            }
            TAPI.lpLineDevCaps.dwTotalSize =Marshal.SizeOf(TAPI.lpLineDevCaps);
            int error=TAPI.lineGetDevCaps(TAPI.hTAPI, lLineID, lNegVer, lUnused,
             ref TAPI.lpLineDevCaps);
            if (error == 0) tbStatus.Text += "Device Name: ";
            else tbStatus.Text += "Can't found device Name.";
            if (TAPI.lpLineDevCaps.dwLineNameSize != 0)
            {
               byte[] byt= RawSerialize(TAPI.lpLineDevCaps);
                for( int i=0;i<TAPI.lpLineDevCaps.dwLineNameSize;i++)
                {
                    devName += Convert.ToString((char)
                        (byt[TAPI.lpLineDevCaps.dwLineNameOffset + i]));
                }
                tbStatus.Text += devName;
                tbStatus.Text += " ." + Environment.NewLine;
            }
            TAPI.lineSetStatusMessages(TAPI.hLine,
             TAPI.lpLineDevCaps.dwLineStates, 0);
        }

        public void acceptCall()
        {
            int nError;
            string szUnused = "";
            nError = TAPI.lineAnswer(TAPI.hCall, ref szUnused, 0);
            TAPI.lineMonitorDigits(TAPI.hCall,
            TAPI.LINEDIGITMODE_DTMF);
        }

        public void showMessage(string message)
        {
            tbStatus.Text += message;
        }

        public void stopModem()
        {
            int nError;
            nError = TAPI.lineShutdown(TAPI.hTAPI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TAPI.userInterface = this;

            this.CenterToScreen();

            SkinStart(Application.StartupPath+"\\spring.urf", 4, "", 1, 0, 0);
            //Pushbutton
            SkinWindowSet(button1.Handle, 208);//SKIN_CLASS_PUSHBUTTON
            SkinWindowSet(button2.Handle, 208);//SKIN_CLASS_PUSHBUTTON
            SkinWindowSet(button3.Handle, 208);//SKIN_CLASS_PUSHBUTTON
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopModem();
            StreamWriter sw = new StreamWriter("Results.txt",true, Encoding.ASCII);
            sw.Write(tbStatus.Text);
            sw.Close();
        }
        
        private static void playWave(string p)
        {
            audio.audio.LoadFile(ref p);
            audio.audio.Play((short)Convert.ToInt32(lineID));
            //throw new Exception("The method or operation is not implemented.");
        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            Add2DB(1);
            //first = true;
           // year1 = true;
            //GetNum(35/*int.Parse(textBox1.Text)*/);
           // getResult(int.Parse(textBox1.Text));
        }

        internal void playWave3(string p,string lineID)
        {
            audio.audio.LoadFile(ref p);
            audio.audio.Play((short)Convert.ToInt32(lineID));
            //throw new Exception("The method or operation is not implemented.");
        }

        internal void DropCall()
        {
            TAPI.lineDrop(TAPI.hCall, "", 0);
            TAPI.lineDeallocateCall(TAPI.hCall);
            //throw new Exception("The method or"
            //+"operation is not implemented.");
        }

        internal void playWave2(string p)
        {                           //comm/datamodem
            lineID = TAPI.GetLineID("wave/out");
            audio.audio.LoadFile(ref p);
            audio.audio.Play((short)Convert.ToInt32(lineID));
            //throw new Exception("The method or"
            //+"operation is not implemented.");
        }
        
        internal void Add2DB(int dwParam1)
        {
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
                default:
                    playWave2("Bad_choise.wav");
                    return;
            }
            OleDbConnection cnn = new OleDbConnection(
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                +"results.mdb;Persist Security Info=False");
            cnn.Open();
            OleDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText="INSERT INTO results(vote) Values('"+val+"')";
            if (cmd.ExecuteNonQuery()<1)
            {
                playWave2("Try_again_later.wav");
                //return;
            }
            playWave2("thank_you.wav");
            cnn.Close();
        }

        
    }
}