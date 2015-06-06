using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Setup;
using Microsoft.Win32;
using System.IO;
using IWshRuntimeLibrary;
using setup.Properties;
using System.Diagnostics;
namespace setup
{
    public partial class Form4 : Form
    {
        Form3 form3 = null;
        public Form4(Form3 frm)
        {
            InitializeComponent();
            form3 = frm;
            form3.form4 = this;

        }

       
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Smart Door Client Package";

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form3.Visible = true;
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public void Setup()
        {
            progressBar1.Value = 0;
            //create folder in program files
            CreateFolder(Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles), textBox1.Text);
            //create folder in start menu
            CreateFolder(
                Environment.GetFolderPath(System.Environment.SpecialFolder.Programs), textBox1.Text);
            //extract and copy files
            progressBar1.Value = 5;
            Extract_Copy_To_Program_Files();
            progressBar1.Value = 70;
            //create shortcut in programs
            string lplace = Environment.GetFolderPath(System.Environment.SpecialFolder.Programs) + "\\" + textBox1.Text;
            string oplace = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + textBox1.Text + "\\Client\\DoorClient.exe";
           
            Create_Shortcut(lplace, oplace, "Smart Door Client");
             if (checkBox1.Checked)
            {
                //create shortcut on desktop
                lplace = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
                oplace = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + textBox1.Text + "\\Client\\DoorClient.exe";

                Create_Shortcut(lplace, oplace, "Smart Door Client");
           }
            progressBar1.Value = 70;
            //add to add remove programs
            Add_To_AddRemovePrograms();
            //if the db not exists
            //if ( false)
            //{
            //    //copy db to the location specified
            //    string src = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\pharma";
            //    //   string dst = TBNameLocation.Text;

            //    //    System.IO.File.Copy(src + "\\Ph.mdf", dst + "\\Ph.mdf", true);
            //    System.IO.File.Delete(src + "\\Ph.mdf");

            //    //    System.IO.File.Copy(src + "\\Ph_log.ldf", dst + "\\Ph_log.ldf", true);
            //    System.IO.File.Delete(src + "\\Ph_log.ldf");
            //}
            //add to registry

            //copy uninstall file to system folder
          //  System.IO.File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\pharma\\UIPH.exe", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\UIPH.exe", true);
           // System.IO.File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\pharma\\LybraVb.dll", Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\LybraVb.dll", true);
            //add information to the registry
            Add_Info_To_Registry();
            //attach db
            progressBar1.Value = 100;
            
           
        }
        //--------------------------------------------------------------
        public void Add_Info_To_Registry()
        {
         /*   RegistryKey rk = Registry.LocalMachine.CreateSubKey("Software\\Smart Door Administartion");
            rk.Flush();
            //exit with windows
            //   rk.SetValue("ExitWithWin", CBLogOff.Checked);
            rk.Flush();
            //run program when windows start
            if (CBStartWithWin.Checked == true)
            {

                RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\MicroSoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("pharma", Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\pharma\\Pharmacy.exe");

            }
            else
            {
                try
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\MicroSoft\\Windows\\CurrentVersion\\Run", true);
                    key.DeleteValue("pharma", false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            */
        }
        string clientpath;
        //--------------------------------------------------------------
        public void Extract_Copy_To_Program_Files()
        {
            clientpath = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + textBox1.Text + "\\Client\\";
           Directory.CreateDirectory(clientpath);

           byte[] client = Resources.DoorClient;//////////////////////////
           byte[] config = Resources.Config;/////////////////////////////////////////////////
           byte[] IrisSkinDLL = Resources.IrisSkin2;////////////////////////

           byte[] inpout32 = Resources.INPOUT32;
           byte[] uninstall = Resources.uninstall;///////////////         
           byte[] help = Resources.SmartDoor;////////////////////////////////////////

           byte[] key = Resources.KEYConfig;
            
           BinaryWriter sSbw44 = new BinaryWriter(System.IO.File.Create(clientpath + "\\KEYConfig.cfg"));
           sSbw44.Write(key, 0, key.Length);
           sSbw44.Close();
           progressBar1.Value = 15;


           BinaryWriter sSbw = new BinaryWriter(System.IO.File.Create(Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\uninstallClient.exe"));
           sSbw.Write(uninstall, 0, uninstall.Length);
           sSbw.Close();
           progressBar1.Value = 20;


        
           BinaryWriter sSbw4 = new BinaryWriter(System.IO.File.Create(clientpath + "DoorClient.exe"));
           sSbw4.Write(client, 0, client.Length);
           sSbw4.Close();
           progressBar1.Value = 30;

           BinaryWriter irbw = new BinaryWriter(System.IO.File.Create(clientpath + "IrisSkin2.dll"));
           irbw.Write(IrisSkinDLL, 0, IrisSkinDLL.Length);
           irbw.Close();
           progressBar1.Value = 40;



           BinaryWriter sSbw3 = new BinaryWriter(System.IO.File.Create(clientpath + "SmartDoor.chm"));
           sSbw3.Write(help, 0, help.Length);
           sSbw3.Close();
           progressBar1.Value = 50;


           
           BinaryWriter sSbw1 = new BinaryWriter(System.IO.File.Create(clientpath + "Config.exe"));
           sSbw1.Write(config, 0, config.Length);
           sSbw1.Close();
           progressBar1.Value = 60;


           BinaryWriter sSbw2 = new BinaryWriter(System.IO.File.Create(clientpath + "INPOUT32.dll"));
           sSbw2.Write(inpout32, 0, inpout32.Length);
           sSbw2.Close();

            ////
         
        }
        //--------------------------------------------------------------
        public void Add_To_AddRemovePrograms()
        {
            //writting values to control panel.
            RegistryKey cpanel = Registry.LocalMachine.CreateSubKey("Software\\microsoft\\windows\\currentversion\\uninstall\\AliHussienSoftClient");
            cpanel.SetValue("DisplayName", "Smart Door Access[Client Package]");
            cpanel.SetValue("DisplayIcon", Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + textBox1.Text + "\\uninstallClient.ico");
            cpanel.SetValue("UninstallString", Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\uninstallClient.exe");
        }
        //--------------------------------------------------------------
        public void CreateFolder(string path, string Name)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (Directory.Exists(path + Name))
            {
                Directory.Delete(path + Name, true);
            }
            dir.CreateSubdirectory(Name);
            dir.Refresh();
        }
        //--------------------------------------------------------------
        public void Create_Shortcut(string Lplace, string OrigionFile, string ShortcutName)
        {
            try
            {
                // Create a shortcut in the special folder for the file

                // Making use of the Windows Scripting Host

                 WshShell shell = new WshShell();

                 IWshShortcut link = (IWshShortcut)shell.CreateShortcut(Lplace + "\\" + ShortcutName + ".lnk");
                 link.WorkingDirectory = OrigionFile.Remove(OrigionFile.LastIndexOf("\\"));
                   link.TargetPath = OrigionFile;

                  link.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""&&button3.Text == "&Install")
            {
                button1.Visible = false;
                Setup();
              
                label4.Text = "Installation completed.";
                button3.Text = "&Finish";
                progressBar1.Value = 100;
            }
           else if (button3.Text == "&Finish")
            {
                Process.Start(clientpath + "Config.exe");

               Application.ExitThread();
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);

           
                
        }
        //--------------------------------------------------------------
    }
}