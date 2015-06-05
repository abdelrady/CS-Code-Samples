using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace M_P_Api1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
        public static extern int mciSendString(string msg,string returnString,int length, IntPtr handle);
        [DllImport("winmm.dll", EntryPoint = "mciGetErrorStringA")]
        public static extern int mciGetErrorString(int fdwError, char[] lpszErrorText, int textLength);

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog opf1 = new OpenFileDialog();
            opf1.Filter = "Wave Files|*.wav|Midi Files|*.mid|All Files|*.*";
            opf1.DefaultExt = "Midi Files|*.mid";
            opf1.InitialDirectory = "f\\";//Application.StartupPath;
            if (opf1.ShowDialog() == DialogResult.OK) fileName = opf1.FileName;
            else fileName = "cdaudio";
            errCode = mciSendString("open \"" + fileName + "\" type mpegvideo alias audio1 parent " + panel1.Handle/* this.Handle */+ " style child", null, 0, IntPtr.Zero);
            //mciSendString("open cdaudio alias audio1","",0,IntPtr.Zero);
            //mciSendString("break mysound on 113", "", 0, IntPtr.Zero);
            //string str = "";
            //mciSendString("info audio1 vesion wait", str, 200, IntPtr.Zero);
            //MessageBox.Show(str);
            //if (errCode != 0) MessageBox.Show("Error Opening Device" + ReturnError(errCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        int errCode; string fileName;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errCode = mciSendString("stop audio1", null, 0, IntPtr.Zero);
            //if (errCode != 0) MessageBox.Show("Error stopping Device" + ReturnError(errCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            errCode = mciSendString("seek audio1 to start", null, 0, IntPtr.Zero);
            //if (errCode != 0) MessageBox.Show("Error Seeking Device To Start" + ReturnError(errCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errCode = mciSendString("play audio1", null, 0, IntPtr.Zero);
          //  if (errCode != 0) MessageBox.Show("Error Playing Device" + ReturnError(errCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errCode = mciSendString("pause audio1", null, 0, IntPtr.Zero);
           // if (errCode != 0) MessageBox.Show("Error Pausing Device" + ReturnError(errCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            errCode = mciSendString("close audio1", null, 0, IntPtr.Zero);
           // if (errCode != 0) MessageBox.Show("Error Closing Device" + ReturnError( errCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }
        string ReturnError(int errcode)
        {

            char[] errstr=new char[128]; int retval;
            //errstr[[128] = " ";
            string err="";
            retval = mciGetErrorString(errcode, errstr,errstr.Length);
            for (int i = 0; i < errstr.Length; i++)
            {
                err += errstr[i];

            }
            if (retval != 0) return err/*.Clone()*/;
            return "\nUnknwon Error";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}