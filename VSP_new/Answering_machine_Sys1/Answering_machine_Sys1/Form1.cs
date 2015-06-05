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

namespace Answering_machine_Sys1
{
    public partial class Form1 : Form
    {
        static string lineID;
        static bool first = false;
        //string filename;
        static bool year1, year2, year3, year4;
        static string idstr;
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
            IntPtr HInstance = (IntPtr)0;
            lPrivilege = TAPI.LINECALLPRIVILEGE_OWNER +
            TAPI.LINECALLPRIVILEGE_MONITOR;
            lMediaMode = 4;
            Module thisModule;
            thisModule =
            Assembly.GetExecutingAssembly().GetModules()[0];
            HInstance = Marshal.GetHINSTANCE(thisModule);
            TAPI.LineCallBackDelegate callback = new
            TAPI.LineCallBackDelegate(TAPI.LineCallBack);
            int Unused = 0;
            /*nError = TAPI.lineInitialize(ref TAPI.hTAPI,
            HInstance.ToInt32(),
            callback, ref Unused, ref TAPI.lNumLines);*/
            
            nError = TAPI.lineInitializeEx(ref TAPI.hTAPI,
            HInstance.ToInt32(),
            callback, ref Unused, ref TAPI.lNumLines,TAPI.TAPIVERSION,ref TAPI.LPLINEINITIALIZEEXPARAMS1);
            
            MessageBox.Show("lineInitializeEx: "+nError.ToString());
            for (lLineID = 0; lLineID < TAPI.lNumLines; lLineID++)
            {
                nError = TAPI.lineNegotiateAPIVersion(TAPI.hTAPI, lLineID,
                TAPI.TAPIVERSION, TAPI.TAPIVERSION,
                ref lNegVer, ref lpExtensionID);
                MessageBox.Show("lineNegotiateAPIVersion: "+nError.ToString());
                do
                {
                    nError = TAPI.lineOpen(TAPI.hTAPI, lLineID,
                    ref TAPI.hLine,
                    lNegVer, lUnused, ref lUnused,
                    (int)lPrivilege, (int)lMediaMode, ref lUnused);
                    lMediaMode++;
                } while (nError < 0 && lMediaMode < 100);
                if (nError == 0) break;
            }

            TAPI.lpLineDevCaps.dwTotalSize = 2241;
            //Marshal.SizeOf(TAPI.lpLineDevCaps);
            TAPI.lpLineDevCaps.bBytes = new
            StringBuilder().Append(' ', 2000).ToString();
            nError= TAPI.lineGetDevCaps(TAPI.hTAPI, lLineID, lNegVer, lUnused,
            ref TAPI.lpLineDevCaps);
            MessageBox.Show("lineGetDevCaps: "+nError.ToString());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            TAPI.userInterface = this;
            tbWave.Text = Application.StartupPath + "\\Greeting.wav";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopModem();
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
         
        private static void getResult(int p)
        {
            string tablename="";
            if (year1)
            {
                tablename = "year1";
            }
            else if (year2)
            {
                tablename = "year2";
            }
            else if (year3)
            {
                tablename = "year3";
            }
            else if (year4)
            {
                tablename = "year4";
            }

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=results.mdb;Persist Security Info=False");
            cnn.Open();
            OleDbCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "select result from " + tablename + " where id=" + p.ToString();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                playWave("get.wav");
                Thread.Sleep(1400);
                if (reader[0].ToString() == "Exellent")
                {
                    playWave("m.wav");
                }
                else if (reader[0].ToString() == "Very Good")
                {
                    playWave("gg.wav");
                }
                else if (reader[0].ToString() == "Good")
                {
                    playWave("g.wav");
                }
                else if (reader[0].ToString() == "pass")
                {
                    playWave("mk.wav");
                }
                else if (reader[0].ToString() == "Week")
                {
                    playWave("d.wav");
                }
                else if (reader[0].ToString() == "Very Week")
                {
                    playWave("dg.wav");
                }
                playWave("byebye.wav");

            }
            else
            {
                playWave("wrongID.wav");
                //this.first = false;
            }

            cnn.Close();

         //   throw new Exception("The method or operation is not implemented.");
        }

        private static void playWave(string p)
        {
            audio.audio.LoadFile(ref p);
            audio.audio.Play((short)Convert.ToInt32(lineID));
            //throw new Exception("The method or operation is not implemented.");
        }

        internal void GetNum(int dwParam1)
        {

            string Digits="";// = Convert.ToChar(dwParam1);
            //MessageBox.Show(xx.ToString());
            if (!first)
            {
                first = true;
                TAPI.LineGatherDigits(TAPI.hCall, TAPI.LINEDIGITMODE_DTMF,ref Digits, 1, "", 1000, 2000);
                switch (Convert.ToChar(Digits))
                {
                    case '1':
                        //MessageBox.Show("");
                        year1 = true;
                        year2 = false;
                        year3 = false;
                        year4 = false;
                        break;
                    case '2':
                       // MessageBox.Show("");
                        year2 = true;
                        year1 = false;
                        year3 = false;
                        year4 = false;
                        break;
                    case '3':
                        //MessageBox.Show("");
                        year3 = true;
                        year1 = false;
                        year2 = false;
                        year4 = false;
                        break;
                    case '4':
                       // MessageBox.Show("");
                        year4 = true;
                        year1 = false;
                        year2 = false;
                        year3 = false;
                        break;
                }
                //this.filename = "welcome.wav";
                playWave("ID.wav");

            }
            else
            {
                Digits = "";
                TAPI.LineGatherDigits(TAPI.hCall, TAPI.LINEDIGITMODE_DTMF, ref Digits, 5, "", 1000, 2000);
                playWave("Wait.wav");
                Digits.Replace('#', ' ');
                Digits=Digits.Trim();
                getResult(int.Parse(Digits));
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //first = true;
            year1 = true;
            //GetNum(35/*int.Parse(textBox1.Text)*/);
            getResult(int.Parse(textBox1.Text));
        }

        internal void playWave2(string p)
        {
            lineID = TAPI.GetLineID("comm/datamodem");//wave/out
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
    }
}