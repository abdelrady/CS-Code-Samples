using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System.Net;

namespace ProtectYourFiles_Drives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] Paths=new string[14];

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if(Dns.GetHostName().ToLower()!="Fcis".ToLower())
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", 1, RegistryValueKind.DWord);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            this.driveListBox1.Drive = Path.GetPathRoot(Environment.SystemDirectory);
            Paths[0] = ".{D4480A50-BA28-11d1-8E75-00C04FA31A86}";
            Paths[1] = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}";
            Paths[2] = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}";
            Paths[3] = ".{20D04FE0-3AEA--1069-A2D8-08002B30309D}";
            Paths[4] = ".{450D8FBA-AD25-11D0-98A8-0800361B1130}";
            Paths[5] = ".{208D2C60-3AEA-1069-A2D7-08002B30309D}";
            Paths[6] = ".{992CFFA0-F557-101A-88EC-00DD010CCC48}";
            Paths[7] = ".{2559a1f5-21d7-11d4-bdaf-00c04f60b9f0}";
            Paths[8] = ".{2227A280-3AEA-1069-A2DE-08002B30309D}";
            Paths[9] = ".{645ff040-5081-101b-9f08-00aa002f954e}";
            Paths[10] = ".{E211B736-43FD-11D11-9EFB-0000F8757FCD}";
            Paths[11] = ".{1f4de370-d627-11d1-ba4f-00a0c91eedba}";
            Paths[12] = ".{00021401-0000-0000-C000-000000000046}";
            Paths[13] = ".{0DF44EAA-FF21-4412-828E-260A8728E7F1}";
            dirListBox1_DoubleClick(null, null);
            this.comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedPath=this.dirListBox1.Path;
            if (MessageBox.Show("Are You sure You Want To Protect This Path: " + SelectedPath, "Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (!Directory.Exists(SelectedPath))
                {
                    MessageBox.Show("Sorry This Path Doesn't Exist.\r\nIf You Are Sure That This Path Already Exist,Please Contact The Application Developer.");
                    return;
                }
                else
                {
                    try
                    {
                        FileSystem.RenameDirectory(SelectedPath, SelectedPath.Substring(SelectedPath.LastIndexOf('\\') + 1) + Paths[this.comboBox1.SelectedIndex]);
                        MessageBox.Show("Path Protected Successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //MessageBox.Show(Path.GetDirectoryName(SelectedPath));
            this.dirListBox1.Path = Path.GetDirectoryName(SelectedPath);//SelectedPath.Substring(0, SelectedPath.LastIndexOf('\\'));
            this.textBox1.Text = this.dirListBox1.Path;
            this.BtnProtect.Enabled = false;
            this.BtnUnProtect.Enabled = true;
        }

        private void dirListBox1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.dirListBox1.Path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ValidPath = false;
            string SelectedPath = this.dirListBox1.Path;
            if (MessageBox.Show("Are You sure You Want To UnProtect This Path: " + SelectedPath, "Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (!Directory.Exists(SelectedPath))
                {
                    MessageBox.Show("Sorry This Path Doesn't Exist.\r\nIf You Are Sure That This Path Already Exist,Please Contact The Application Developer.");
                    return;
                }
                else
                {
                    if (Path.HasExtension(SelectedPath))
                    {
                        try
                        {
                            string FolderNameWithExt = SelectedPath.Substring(SelectedPath.LastIndexOf('\\') + 1);
                            FileSystem.RenameDirectory(SelectedPath, FolderNameWithExt.Remove(FolderNameWithExt.IndexOf(Path.GetExtension(SelectedPath))));
                            MessageBox.Show("Path UnProtected Successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            //MessageBox.Show(Path.GetDirectoryName(SelectedPath.Remove(SelectedPath.IndexOf(Path.GetExtension(SelectedPath)))));
            this.dirListBox1.Path = Path.GetDirectoryName(SelectedPath);//SelectedPath.Substring(0, SelectedPath.LastIndexOf('\\'));
            this.textBox1.Text = this.dirListBox1.Path;
            this.BtnProtect.Enabled = true;
            this.BtnUnProtect.Enabled = false;
        }

      
        private void dirListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
             string SelectedPath = this.dirListBox1.Path;
            //MessageBox.Show(Path.GetExtension(SelectedPath));
            //return;
             for (int i = 0; i < Paths.Length; i++)
             {
                 if (SelectedPath.EndsWith(Paths[i]))
                 {
                     this.BtnUnProtect.Enabled = true;
                     this.BtnProtect.Enabled = false;
                     return;
                 }
             }
             this.BtnProtect.Enabled = true;
             this.BtnUnProtect.Enabled = false;
        }

        private void dirListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dirListBox1.Path = this.driveListBox1.Drive;
                this.textBox1.Text = this.dirListBox1.Path;
            }
            catch { }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer Name: Abdelrady Elagamy Abdelrady.\r\nFaculty Of Computers & Information Sciences.\r\nEmail: Abdelrady@gmail.com", "Contact Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        } 
        
    }
}