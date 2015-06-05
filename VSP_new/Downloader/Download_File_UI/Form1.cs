using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Downloader;
using System.Threading;

namespace Download_File_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Downloader.DownloaderClass obj;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("You Must Select File"); return; }
            string str = textBox1.Text;
            obj = new DownloaderClass();
            obj.TargetUrl = str;
            obj.HDPath = str.Substring(str.LastIndexOf('/'));
            //obj.OnDownloadBegin += new DownloaderClass.DownloadBegin(obj_OnDownloadBegin);
            obj.OnDownloadComplete += new DownloaderClass.DownloadComplete(obj_OnDownloadComplete);
            obj.OnDataRecieved += new DownloaderClass.DataRecieved(obj_OnDataRecieved);
            new Thread(new ThreadStart(obj.run)).Start();

            //MessageBox.Show(obj.DataSize.ToString());
        }

        void obj_OnDataRecieved(DownloaderClass p)
        {
            if (p.FileLength != 0)
            {
                progressBar1.Maximum = p.FileLength;
                try
                {
                    progressBar1.Value = p.RecievedDataLength;
                }
                catch { }
            }
            label1.Text = (p.RecievedDataLength/1024).ToString();
        }

        void obj_OnDownloadBegin()
        {
           /* if (obj.HaveLength)
            {
                progressBar1.Maximum = obj.DataSize;
            }
            timer1.Start();*/
            MessageBox.Show("Download Begin");
        }

        void obj_OnDownloadComplete()
        {
            //timer1.Stop();
            //progressBar1.Value = 0;
            
            MessageBox.Show("Download Complete");
            label1.Text = "";
            button1.Enabled = true;
            progressBar1.Value = 0;
        }

 private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }
    }
}