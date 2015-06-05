using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace TestBroweServer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServerClass server = new ServerClass();
        string DirPath = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            server.OnDataRecieved += new ServerClass.DataRecieved(server_OnDataRecieved);
            server.OnClientDissConnected += new ServerClass.ClientDissConnected(server_OnClientDissConnected);
            server.OnClientConnected += new ServerClass.ClientConnected(server_OnClientConnected);
            server.OnErrorCatched += new ServerClass.ErrorCatched(server_OnErrorCatched);
            ThreadPool.QueueUserWorkItem(new WaitCallback(server.Listen), null);
        }

        void server_OnErrorCatched(string Error)
        {
            MessageBox.Show(Error);
        }

        void server_OnClientConnected(string RemoteIP)
        {
            toolStripStatusLabel1.Text = "Remote IP: " + RemoteIP;
            toolStripStatusLabel2.Text = "Status: Connected";
        }

        void server_OnClientDissConnected(string Error)
        {
            MessageBox.Show(Error);
            toolStripStatusLabel1.Text = "Remote IP: ";
            toolStripStatusLabel2.Text = "Status: DisConnected";

            ThreadPool.QueueUserWorkItem(new WaitCallback(server.Listen),null);
            //MessageBox.Show(ex.Message);
            //throw new Exception(ex.Message, ex);
        }
        string CurrentDirPath;
        string TotalFilePath;
        void server_OnDataRecieved(string Data)
        {
            //MessageBox.Show(Data);
            toolStripStatusLabel3.Text = "Packet Length: " + Data.Length;
            string[] CmdArgs  = Data.Split(new string[] { "[#]"},StringSplitOptions.RemoveEmptyEntries);
            switch (CmdArgs[0])
            {
                case "[#DirPath#]":
                    lock (this)
                    {
                        //MessageBox.Show(Data);
                        txtFolderPath.Text = CmdArgs[1];
                        DirPath = CmdArgs[1];

                        try
                        {
                            if (CmdArgs.Length > 3)
                                SetDirs(CmdArgs[3]);
                            else ClearDirs();
                        }
                        catch (Exception ex) { MessageBox.Show("Dirs: " + ex.Message); }

                        try
                        {
                            if (CmdArgs.Length > 5)
                                SetFiles(CmdArgs[5]);
                            else
                                ClearFiles();
                        }
                        catch (Exception ex) { MessageBox.Show("Files: " + ex.Message); }
                    }
                    break;
                case "[#FileName#]":
                    //CmdArgs[1] = CmdArgs[1].Replace('\\', '_').Replace(':','_');
                    if (CmdArgs[2] == "[#NoData#]")CmdArgs[2]=string.Empty;
                    TotalFilePath = textBox2.Text + CmdArgs[1].Substring(CmdArgs[1].IndexOf('\\'));
                    CurrentDirPath = textBox2.Text + CmdArgs[1].Substring(CmdArgs[1].IndexOf('\\'), CmdArgs[1].LastIndexOf('\\') - CmdArgs[1].IndexOf('\\'));
                    //MessageBox.Show("Data: " + Data);
                    //MessageBox.Show("TotalFilePath: " + TotalFilePath);
                    //MessageBox.Show("CurrentDirPath: " + CurrentDirPath);
                    Directory.CreateDirectory(CurrentDirPath);
                    File.WriteAllBytes(TotalFilePath, Encoding.Default.GetBytes(CmdArgs[2]));
                    break;
                case "[#Error#]":
                    MessageBox.Show(CmdArgs[1]);
                    break;
                case "[#SearchResults#]":
                    //MessageBox.Show(CmdArgs[1]);
                    //if (CmdArgs[1] != "[#No Files#]")
                    {
                        SetFiles(CmdArgs[1]);
                    }
                    break;
                case "[#FileProps#]":
                    txtFileProps.Text = CmdArgs[1];
                    break;
            }
        }

        private void ClearFiles()
        {
            listBox2.DataSource = null;
            listBox2.Items.Clear();
        }
        private void ClearDirs()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }

        private void SetFiles(string p)
        {
            //MessageBox.Show(p);
            listBox2.DataSource = p.Split(new string[] { "[|]" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void SetDirs(string p)
        {
            //MessageBox.Show(p);
            listBox1.DataSource = p.Split(new string[] { "[|]" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFolderPath.Text != "")
            {
                string msg = "[#ListDirectory#][#]" + txtFolderPath.Text + "[#]";
                server.SendMessage(msg);
            }
            else
            {
                MessageBox.Show("You Must Choose Directory.");
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtFolderPath.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (!Directory.Exists(textBox2.Text))
                {
                    Directory.CreateDirectory(textBox2.Text);
                }
                string msg = "[#CopyFile#][#]" + listBox2.Items[listBox2.SelectedIndex].ToString() + "[#]";
                server.SendMessage(msg);
                //MessageBox.Show("");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (!Directory.Exists(textBox2.Text))
                {
                    Directory.CreateDirectory(textBox2.Text);
                }
                string msg = "[#CopyDirectory#][#]" + txtFolderPath.Text+"[#]";
                server.SendMessage(msg);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();
            opg.Filter = "Exe Files(*.exe)|*.exe";
            if (opg.ShowDialog() == DialogResult.OK)
            {
                string fileName100byte = new string(' ', 100);
                char[] ch=fileName100byte.ToCharArray();
                string fileName = opg.FileName.Substring(opg.FileName.LastIndexOf("\\") + 1);
                fileName.CopyTo(0, ch, 0, fileName.Length);
                fileName100byte = new string(ch);
                MessageBox.Show("[" + fileName100byte + "]");
                server.SendMessage("UploadFile"+ fileName100byte + Encoding.Default.GetString(File.ReadAllBytes(opg.FileName)));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str="";
            if (this.radioButton1.Checked)
            {
                str = "[#At Least#]";
            }
            else if (this.radioButton2.Checked)
            {
                str = "[#At Most#]";
            }
            else
            {
                str = "[#None#]";
            }
            server.SendMessage("[#Search#][#]"+txtFolderPath.Text+"[#][#Criteria#][#][#Extention#][#]" + txtSearchCriteria.Text+"[#][#Size#][#]"+str+"[#]"+txtSearchSize.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            server.SendMessage("[#FileProps#][#]"+ listBox2.Items[listBox2.SelectedIndex].ToString() + "[#]");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            server.Disconnect();
            ThreadPool.QueueUserWorkItem(new WaitCallback(server.Listen), null);
        }
    }
}