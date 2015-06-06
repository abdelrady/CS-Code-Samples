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
        public void showMessage(string message)
        {
            tbStatus.Text += message;
        }
        public void stopModem()
        {
            int nError;
            nError = TAPI.lineShutdown(TAPI.hTAPI);
        }
        public void startModem()
        {
            int nError = 0;
            TAPI.lineextensionid lpExtensionID = new
            TAPI.lineextensionid();
            int lUnused = 0;
            int lLineID = 0;
            int lNegVer = 0;
            long lPrivilege = 0;
            long lMediaMode = 0;
            IntPtr HInstance = IntPtr.Zero;///(IntPtr)0;
            lPrivilege = TAPI.LINECALLPRIVILEGE_OWNER +
            TAPI.LINECALLPRIVILEGE_MONITOR;
            lMediaMode = 8;
            Module thisModule;
            thisModule =
            Assembly.GetExecutingAssembly().GetModules()[0];
            HInstance = Marshal.GetHINSTANCE(thisModule);
            TAPI.LineCallBackDelegate callback = new
            TAPI.LineCallBackDelegate(TAPI.LineCallBack);
            int Unused = 0;
            nError = TAPI.lineInitialize(ref TAPI.hTAPI,
            HInstance.ToInt32(),
            callback, ref Unused, ref TAPI.lNumLines);
            MessageBox.Show(nError.ToString() + ": " + TAPI.lNumLines);
            //for (lLineID = 0; lLineID < TAPI.lNumLines; lLineID++)
            lLineID = 1;
            {
                nError = TAPI.lineNegotiateAPIVersion(TAPI.hTAPI, lLineID,
                TAPI.TAPIVERSION, TAPI.TAPIVERSION,
                ref lNegVer, ref lpExtensionID);
                MessageBox.Show(nError.ToString());
               // do
                {

                    nError = TAPI.lineOpen(TAPI.hTAPI, lLineID,
                    ref TAPI.hLine,
                    lNegVer, lUnused, ref lUnused,
                    (int)lPrivilege, (int)lMediaMode, ref lUnused);
                    //MessageBox.Show(nError.ToString());
                    //lMediaMode++;
                }// while (nError < 0);//&& lMediaMode<100);//Convert.ToInt32( 
                if (nError == 0)
                {
                    tbStatus.Text += "Found -"+lLineID.ToString() +"-"+ lMediaMode.ToString()+":";
                   // break;
                    
                }

            }

            TAPI.lpLineDevCaps.bBytes = new string(' ', 2000);
            TAPI.lpLineDevCaps.dwTotalSize =
            Marshal.SizeOf(TAPI.lpLineDevCaps);
            MessageBox.Show("TAPI.lpLineDevCaps.dwTotalSize:" + TAPI.lpLineDevCaps.dwTotalSize.ToString());
            
            //StringBuilder().Append(' ', 2000).ToString();
            //TAPI.lpLineDevCaps.bBytes = new StringBuilder(null, 2000);
            //for (int x = 0; x < 2000;x++)
            {
              //  TAPI.lpLineDevCaps.bBytes[x] = ' ';
            }

            
            
            int error=TAPI.lineGetDevCaps(TAPI.hTAPI, lLineID, lNegVer, lUnused,
             ref TAPI.lpLineDevCaps);
            //MessageBox.Show("lineGetDevCaps");
            tbStatus.Text += "-" + TAPI.lpLineDevCaps.dwLineNameOffset.ToString();
            tbStatus.Text += "-" + TAPI.lpLineDevCaps.dwLineNameSize.ToString();
            if (error == 0);// tbStatus.Text += " text:" + TAPI.lpLineDevCaps.bBytes;
            else MessageBox.Show(error.ToString());
            //tbStatus.Text += "\n" + TAPI.lpLineDevCaps.bBytes;
            TAPI.lineSetStatusMessages(TAPI.hLine,
             TAPI.lpLineDevCaps.dwLineStates, 0);
            
            string lineName = "";
            byte[] linename2 ={ 0 };
            

            //IntPtr ptr1 = new IntPtr(TAPI.lpLineDevCaps.dwLineNameOffset);
            //Marshal.StructureToPtr( TAPI.lpLineDevCaps,ptr1,true);
            //ptr1 += (TAPI.lpLineDevCaps.dwLineNameOffset);
            //Marshal.Copy(ptr1, linename2, 0, TAPI.lpLineDevCaps.dwLineNameSize);
            //lineName = Encoding.ASCII.GetString(linename2);
            //tbStatus.Text += "\n" + lineName;
        }
        public void acceptCall()
        {
            int nError;
            string szUnused = "";
            nError = TAPI.lineAnswer(TAPI.hCall, ref szUnused, 0);
            TAPI.lineMonitorDigits(TAPI.hCall,
            TAPI.LINEDIGITMODE_DTMF);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TAPI.userInterface = this;
            //tbWave.Text = Application.StartupPath + "\\Greeting.wav";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopModem();
            StreamWriter sw = new StreamWriter("Results.txt",true, Encoding.ASCII);
            sw.Write(tbStatus.Text);
            sw.Close();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Wave Files|*.wav";
            openFileDialog.ShowDialog();
            tbWave.Text = openFileDialog.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filename = tbWave.Text;
            lineID = TAPI.GetLineID("wave/out");
            audio.audio.LoadFile(ref filename);
            audio.audio.Play((short)Convert.ToInt32(lineID));
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

        internal void playWave2(string p)
        {
            //lineID = TAPI.GetLineID("wave/out");////comm/datamodem
            lineID = "2";
            audio.audio.LoadFile(ref p);
            audio.audio.Play((short)Convert.ToInt32(lineID));
            //throw new Exception("The method or operation is not implemented.");
        }
        internal void playWave3(string p,string lineID)
        {
            audio.audio.LoadFile(ref p);
            audio.audio.Play((short)Convert.ToInt32(lineID));
            //throw new Exception("The method or operation is not implemented.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < 100; x++)
            {
                MessageBox.Show(x.ToString() + " " + Convert.ToChar(x).ToString());
            }
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
                    break;
            }
            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=results.mdb;Persist Security Info=False");
            cnn.Open();
            OleDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "INSERT INTO results(vote) Values('" + val + "') ";
            if (cmd.ExecuteNonQuery()<1)
            {
                playWave2("Try_again_later.wav");
                //return;
            }
            playWave2("thank_you.wav");
            cnn.Close();
            //throw new Exception("The method or operation is not implemented.");
        }
    }
}