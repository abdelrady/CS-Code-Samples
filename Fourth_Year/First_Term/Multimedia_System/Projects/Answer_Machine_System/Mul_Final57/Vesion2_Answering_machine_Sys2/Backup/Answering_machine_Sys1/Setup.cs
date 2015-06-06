using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tapi1_cs;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Answering_machine_Sys1
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }
        public int lineID;
        public string lineDevName;
        public int RingsCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            lineID = ReturnVal();
            lineDevName = LstModems.SelectedItem.ToString();
            RingsCount = int.Parse(textBox1.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public int ReturnVal()
        {
            int x = LstModems.SelectedIndex;
            return x;
        }
        public static byte[] RawSerialize(object anything)
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
        public string[] ListModemDevs(out int ModemsCount)
        {
            int nError = 0, lUnused = 0, lLineID = 0, lNegVer = 0;
            string ModemsList = "";
            string devName = "";
            TAPI.lineextensionid lpExtensionID = new
            TAPI.lineextensionid();
            long lPrivilege = 0, lMediaMode = 0;
            IntPtr HInstance = IntPtr.Zero;
            lPrivilege = TAPI.LINECALLPRIVILEGE_OWNER +
            TAPI.LINECALLPRIVILEGE_MONITOR;
            lMediaMode = 8;
            
            Module thisModule;
            thisModule = Assembly.GetExecutingAssembly().GetModules()[0];
            HInstance = Marshal.GetHINSTANCE(thisModule);
            TAPI.LineCallBackDelegate callback = new
            TAPI.LineCallBackDelegate(TAPI.LineCallBack);
            
            int Unused = 0;
            nError = TAPI.lineInitialize(ref TAPI.hTAPI,
            HInstance.ToInt32(),
            callback, ref Unused, ref TAPI.lNumLines);
            
            if (nError != 0)
            {
                ModemsCount = 0;
                //MessageBox.Show("Initialize TAPI");
                return null;
            }
            else
            {
                ModemsCount = TAPI.lNumLines;
            }

            nError = TAPI.lineNegotiateAPIVersion(TAPI.hTAPI, lLineID,
                TAPI.TAPIVERSION, TAPI.TAPIVERSION,
                ref lNegVer, ref lpExtensionID);
            
            for (lLineID = 0; lLineID < TAPI.lNumLines; lLineID++)
            {
                TAPI.lpLineDevCaps = new TAPI.linedevcaps();
                TAPI.lpLineDevCaps.dwTotalSize = Marshal.SizeOf(TAPI.lpLineDevCaps);
                int error = TAPI.lineGetDevCaps(TAPI.hTAPI, lLineID, lNegVer, lUnused,
                 ref TAPI.lpLineDevCaps);
                if (error == 0){}
                else ModemsList += "Can't found device Name." + "[#]";
                if (TAPI.lpLineDevCaps.dwLineNameSize != 0)
                {
                    byte[] byt = RawSerialize(TAPI.lpLineDevCaps);
                    for (int i = 0; i < TAPI.lpLineDevCaps.dwLineNameSize; i++)
                    {
                        devName += Convert.ToString((char)
                            (byt[TAPI.lpLineDevCaps.dwLineNameOffset + i]));
                    }
                    ModemsList += devName + "[#]";
                }
                devName = "";

                //MessageBox.Show(devName);

            }
            return ModemsList.Split(new string[] { "[#]" }, StringSplitOptions.RemoveEmptyEntries);
        }
        private void Setup_Load(object sender, EventArgs e)
        {
            int modemsCount=0;
            string[] modemsList = ListModemDevs(out modemsCount);
            LstModems.DataSource = modemsList;
            MessageBox.Show("Number Of Devices: "+modemsCount);
        }
    }
}