using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace uninstall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PBNext_Click(object sender, EventArgs e)
        {
            
            try
            {
                progressBar1.Value = 0;
                //delete from program files
                string PFpath=Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);
                if (Directory.Exists(PFpath + "\\Smart Door Client Package"))
                    Directory.Delete(PFpath + "\\Smart Door Client Package", true);
                progressBar1.Value = 30;
                //delete from start menu
                string SMPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Programs);
                if (Directory.Exists(SMPath + "\\Smart Door Client Package"))
                    Directory.Delete(SMPath + "\\Smart Door Client Package", true);
                progressBar1.Value = 60;
                //delete shortcut on desktop
                if (File.Exists(Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "\\Smart Door Client.lnk"))
                    File.Delete(Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "\\Smart Door Client.lnk");
                     //delete from registry
                progressBar1.Value = 90;
              //  Registry.LocalMachine.DeleteSubKey("software\\AliHussienSoft");
                Registry.LocalMachine.DeleteSubKey("Software\\microsoft\\windows\\currentversion\\uninstall\\AliHussienSoftClient");
                progressBar1.Value = 100;
                MessageBox.Show(this, "Smart Door Uninstalled sucessfully.", "Successful uninstallation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(Environment.ExitCode);
            }
            catch
            {
                MessageBox.Show(this, "Error occured during uninstalling applicatton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
                
            }
        }
    }
}