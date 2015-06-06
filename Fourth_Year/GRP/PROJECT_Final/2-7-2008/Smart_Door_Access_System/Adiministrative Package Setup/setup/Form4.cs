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
            textBox1.Text = "Smart Door Administrator Package";

        
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
            string oplace = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + textBox1.Text + "\\Server\\DoorServer.exe";
            string bplace = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + textBox1.Text + "\\Admin\\Smart Door Administration.exe";
            
            Create_Shortcut(lplace, oplace, "Doors Server");
            Create_Shortcut(lplace, bplace, "Administration");
            if (checkBox1.Checked)
            {
                //create shortcut on desktop
                lplace = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
                oplace = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\" + textBox1.Text + "\\Server\\DoorServer.exe";
                bplace = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\"+textBox1.Text+"\\Admin\\Smart Door Administration.exe";
       
                Create_Shortcut(lplace, oplace, "Doors Server");
                Create_Shortcut(lplace, bplace, "Administration");
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
        //--------------------------------------------------------------
        public void Extract_Copy_To_Program_Files()
        {
           string ServerPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\"+textBox1.Text+"\\Server\\";
           Directory.CreateDirectory(ServerPath);

           string AdminPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\"+textBox1.Text+"\\Admin\\";

           Directory.CreateDirectory(AdminPath);

           string AdministrationConfiguration = Resources.AConfig;
           string serverConfiguration = Resources.SConfig;/**/
           byte[] Server = Resources.DoorServer;/**/
           byte[] Administration = Resources.Smart_Door_Administration;
           byte[] IrisSkinDLL = Resources.IrisSkin2;
           byte[] SQLDmo = Resources.SQLDMO;/**/
           byte[] uninstall = Resources.uninstall;
           byte[] axFlashI = Resources.AxInterop_ShockwaveFlashObjects;
           byte[] intropFlash = Resources.Interop_ShockwaveFlashObjects;
           byte[] help = Resources.SmartDoor;
           byte[] shock = Resources.myfile;

           progressBar1.Value = 10;
           BinaryWriter sSbw4 = new BinaryWriter(System.IO.File.Create(ServerPath + "myfile.swf"));
           sSbw4.Write(shock, 0, shock.Length);
           sSbw4.Close();

           progressBar1.Value = 10;
           BinaryWriter sSbw1 = new BinaryWriter(System.IO.File.Create(ServerPath+"AxInterop.ShockwaveFlashObjects.dll"));
           sSbw1.Write(axFlashI, 0, axFlashI.Length);
           sSbw1.Close();

           progressBar1.Value = 12;

           BinaryWriter sSbw2 = new BinaryWriter(System.IO.File.Create(ServerPath + "Interop.ShockwaveFlashObjects.dll"));
           sSbw2.Write(intropFlash, 0, intropFlash.Length);
           sSbw2.Close();

           progressBar1.Value = 15;


           BinaryWriter sSbw3 = new BinaryWriter(System.IO.File.Create(ServerPath + "SmartDoor.chm"));
           sSbw3.Write(help, 0, help.Length);
           sSbw3.Close();

           progressBar1.Value = 16;


       
         //  MessageBox.Show(System.Environment.SpecialFolder.ProgramFiles + "\\" + textBox1.Text + "\\uninstall.exe");

           BinaryWriter sSbw = new BinaryWriter(System.IO.File.Create(Environment.GetFolderPath( System.Environment.SpecialFolder.ProgramFiles )+ "\\uninstall.exe"));
           sSbw.Write(uninstall, 0, uninstall.Length);
           sSbw.Close();
           progressBar1.Value = 18;

          
           StreamWriter sw = new StreamWriter(System.IO.File.Create(ServerPath + "Config.ini"));
           sw.WriteLine(serverConfiguration);
           sw.Close();
           progressBar1.Value = 20;
        
           BinaryWriter Sbw = new BinaryWriter(System.IO.File.Create(ServerPath + "DoorServer.exe"));
           Sbw.Write(Server, 0, Server.Length);
           Sbw.Close();
           progressBar1.Value = 30;
        


           FileStream fs = new FileStream(ServerPath + "Interop.SQLDMO.dll", FileMode.Create);
           BinaryWriter SQlbw = new BinaryWriter(fs);
           SQlbw.Write(SQLDmo, 0, SQLDmo.Length);
           SQlbw.Close();

           progressBar1.Value = 40;
        
           StreamWriter asw = new StreamWriter(System.IO.File.Create(AdminPath + "Config.ini"));
           asw.WriteLine(AdministrationConfiguration);
           asw.Close();
           progressBar1.Value = 50;
         
           BinaryWriter aSbw = new BinaryWriter(System.IO.File.Create(AdminPath + "Smart Door Administration.exe"));
           aSbw.Write(Administration, 0, Administration.Length);
           aSbw.Close();
           progressBar1.Value = 55;
         
           BinaryWriter irbw = new BinaryWriter(System.IO.File.Create(AdminPath + "IrisSkin2.dll"));
           irbw.Write(IrisSkinDLL, 0, IrisSkinDLL.Length);
           irbw.Close();
           progressBar1.Value = 60;
         
           string SkinPath = Application.ExecutablePath.Substring(0,Application.ExecutablePath.LastIndexOf("\\"))+ "\\skins";


      //    MessageBox.Show(SkinPath);
          
           Directory.CreateDirectory(AdminPath + "skins");
           DirectoryInfo di = new DirectoryInfo(SkinPath);
           foreach (FileInfo fi in di.GetFiles())
           {
            //   System.IO.File.Create(AdminPath + "skins\\" + System.IO.Path.GetFileName(fi.Name));
               try
               {
                   fi.CopyTo(AdminPath + "skins\\" + System.IO.Path.GetFileName(fi.Name));
               }
               catch { }
           }

         //  try { Directory.Move(SkinPath, AdminPath + "skins"); }
         //  catch { }
           progressBar1.Value = 65;
        //   Percentage.Text = "65";

        }
        //--------------------------------------------------------------
        public void Add_To_AddRemovePrograms()
        {
            //writting values to control panel.
            RegistryKey cpanel = Registry.LocalMachine.CreateSubKey("Software\\microsoft\\windows\\currentversion\\uninstall\\AliHussienSoft");
            cpanel.SetValue("DisplayName", "Smart Door Access[Administrator Package]");
            cpanel.SetValue("DisplayIcon", Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\"+textBox1.Text+"\\uninstall.ico");
            cpanel.SetValue("UninstallString", Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + "\\uninstall.exe");
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