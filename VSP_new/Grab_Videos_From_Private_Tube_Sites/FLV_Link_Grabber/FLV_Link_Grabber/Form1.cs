using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace FLV_Link_Grabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            if (!this.radioButton2.Checked)
                new Thread(new ThreadStart(GetLink)).Start();

            new Thread(new ThreadStart(GetLinkFromExplicitSite)).Start();
        }
        private void GetLinkFromExplicitSite()
        {
            //this.button1.Enabled = false;
            //this.textBox1.Enabled = false;

            HttpWebRequest wr = (HttpWebRequest)HttpWebRequest.Create(this.textBox1.Text);
            HttpWebResponse ws = (HttpWebResponse)wr.GetResponse();
            string str = new StreamReader(ws.GetResponseStream()).ReadToEnd();
            
            //clsid:d27cdb6e-ae6d-11cf-96b8-444553540000
            int index1 = str.IndexOf("clsid:d27cdb6e-ae6d-11cf-96b8-444553540000");
            int index2=0;
            int index3 = 0;
            string ParamValueID = "";
            int VlaueID = 11111;
            if(index1 > 0)
            {
                index2= str.IndexOf("flashvars",index1);
                if (index2 > 0)
                    index3 = str.IndexOf("value", index2);
                else { MessageBox.Show("Param Value Id Not Found. "); return; }

                ParamValueID = str.Substring(index3 + 7, str.IndexOf('"', index3 + 7)-(index3+7));
                ParamValueID = ParamValueID.Substring(9);
                MessageBox.Show(ParamValueID);
                if (ParamValueID != "")
                {
                    //string PacketHttpHeader = "";
                    //wr = (HttpWebRequest)HttpWebRequest.Create("flashembed.xvideos.com");
                    //wr.Method = "Post";
                    //wr.Headers.Add("");
                    int len = File.ReadAllBytes("d:\\Interest_Stream_Packet.txt").Length;
                    byte[] byt;
                    //byt = File.ReadAllBytes("d:\\Interest_Stream_Packet.txt");
                    /*
                    wr = (HttpWebRequest)HttpWebRequest.Create("http://flashembed.xvideos.com/flashservices/gateway.php");
                    wr.Method = "POST";
                    wr.ProtocolVersion = new Version(1, 1);*/
                    //wr.Accept="text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                    /*wr.Headers.Add("Keep-Alive: 115");
                    wr.KeepAlive = true;

                    
                    byte[] byt2=new byte[6];
                    byt2[0]=byt2[3]=0x02;
                    byt2[1]=byt2[2]=byt2[4]=byt2[5]=0x00;

                    wr.ContentType = "application/x-amf";
                    wr.ContentLength = 55;
                    wr.Referer = "http://www.xvideos.com/sitevideos/flv_player_site_v4.swf\r\ngetViewerParams.get/1\r\n145027" + Encoding.UTF8.GetString(byt2);
                    *///wr.Headers.Add("Host:flashembed.xvideos.com");*/
                    //wr.Headers.Add("User-Agent:Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.13) Gecko/20101203 Firefox/3.6.13");
                    //wr.Headers.Add("Accept-Language:en-us,en;q=0.5");
                    //wr.Headers.Add("Accept-Encoding:gzip,deflate");
                    //wr.Headers.Add("Accept-Charset:ISO-8859-1,utf-8;q=0.7,*;q=0.7");
                    //wr.Connection = "keep-alive";   //error
                    //byt= new byte["getViewerParams.get/1\r\n145027".Length+6];
                    //Array.Copy(Encoding.UTF8.GetBytes("getViewerParams.get/1\r\n145027"), byt, "getViewerParams.get/1\r\n145027".Length);
                    //Array.Copy(byt2, 0, byt, byt.Length - 6, 6);
                    //wr.Headers.Add(File.ReadAllText("d:\\Interest_Stream_Packet.txt",Encoding.UTF8));
                    //wr.ContentType = "application/x-www-form-urlencoded";
                    //Stream st2 = wr.GetRequestStream();
                    //st2.Write(byt, 0, byt.Length);
                    //st2.Flush(); //st2.Close();
                    //BinaryReader br = cl1.OpenRead("flashembed.xvideos.com");
                    /*ws = (HttpWebResponse)wr.GetResponse();
                    string str2 = new StreamReader(ws.GetResponseStream()).ReadToEnd();
                    File.WriteAllText("d:\\FinalResult.txt", str2);
                    MessageBox.Show("Succ.");*/
                    IPHostEntry iph = Dns.GetHostEntry("flashembed.xvideos.com");
                    TcpClient cl1 = new TcpClient(iph.HostName, 80);//flashservices/gateway.php
                    StreamWriter sw = new StreamWriter(cl1.GetStream());
                    StreamReader sr = new StreamReader(cl1.GetStream());
                    Byte[] arr = new byte[] { 0x00,0x00,0x00,0x00,0x00,0x01,0x00,0x13,0x67,0x65,0x74,0x56,0x69,0x65,0x77,0x65,0x72,0x50,0x61,0x72,0x61,0x6d,0x73,0x2e
                        ,0x67,0x65,0x74,0x00,0x02,0x2f,0x31,0x00,0x00,0x00,0x14,0x0a,0x00,0x00,0x00,0x03,0x02,0x00,0x06};//,0x32,0x33,0x39,0x34,0x38,0x39,0x02,0x00,0x00,0x02,0x00,0x00};
                    byte[] badding = new byte[]{0x02,0x00,0x00,0x02,0x00,0x00};
                    sw.Write(File.ReadAllText("d:\\Interest_Stream_Packet.txt", Encoding.UTF8) + Encoding.UTF8.GetString(arr) + ParamValueID + Encoding.UTF8.GetString(badding));
                    sw.Flush(); //sw.Close();
                    string str3 = sr.ReadToEnd();
                    string UrlMarker = Encoding.UTF8.GetString(new byte[] { 0x00, 0x03, 0x75, 0x72, 0x6c, 0x02, 0x00, 0xef, 0xbf, 0xbd });
                    int UrlMarkerIndex = str3.IndexOf(UrlMarker);
                    this.textBox2.Text = str3.Substring(UrlMarkerIndex + 10, str3.IndexOf("3gp_url", UrlMarkerIndex) - UrlMarkerIndex - 10);
                    File.WriteAllText("d:\\FinalResult.txt", str3);
                    MessageBox.Show("Succ.");
                    
                    
                }
            }

        }
        void GetLink()
        {
            //this.button1.Enabled = false;
            //this.textBox1.Enabled = false;

            HttpWebRequest wr = (HttpWebRequest)HttpWebRequest.Create(this.textBox1.Text);
            HttpWebResponse ws = (HttpWebResponse)wr.GetResponse();
            string str = new StreamReader(ws.GetResponseStream()).ReadToEnd();

            string link = "";
            int HashIndexB = str.IndexOf("hashlink");
            int HashIndexE = 0;
            if (HashIndexB > 0)
            {
                HashIndexB += 9;
                HashIndexE = str.IndexOf('"', HashIndexB);
                if (HashIndexE > HashIndexB)
                {
                    link = str.Substring(HashIndexB, HashIndexE - HashIndexB);
                    link = link.Replace("%3A", ":");//or use: 
                    link = link.Replace("%2F", "/");// add reference to system.web from Project Tab ,then add reference
                    link = link.Replace("%3F", "?");// type using System.Web;
                    link = link.Replace("%3D", "=");//then use Static methods urlEncode And urlDecode
                    link = link.Replace("%26", "&");//link=httputility.urldecode(link);

                    //Console.WriteLine("Final Link: " + link);
                }
            }
            
            this.textBox2.Text = link;
            //this.button1.Enabled = true;
            //this.textBox1.Enabled = true;

            wr = null;
            ws = null;
            System.GC.Collect();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBox2.Text);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
//            this.textBox1.Text = "";
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}