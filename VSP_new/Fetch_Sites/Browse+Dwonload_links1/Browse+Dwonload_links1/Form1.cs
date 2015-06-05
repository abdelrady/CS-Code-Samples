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
using System.Runtime.InteropServices;

namespace Browse_Dwonload_links1
{
    public partial class Form1 : Form
    {
      /*  [DllImport("urlmon",EntryPoint="URLDownloadToFileA")]
        public static extern int URLDownloadToFile (int a,string b,string c,int d,int e);
        [DllImport("wininet",EntryPoint="InternetOpenA")]
        public static extern int InternetOpen (string a,int b,string c,string d,int e);
        [DllImport("wininet")]
        public static extern int InternetCloseHandle (int x);
        private const int INTERNET_OPEN_TYPE_PRECONFIG = 0;
        private const int INTERNET_FLAG_EXISTING_CONNECT = 0x20000000;
        private const int INTERNET_OPEN_TYPE_DIRECT = 1;
        private const int INTERNET_OPEN_TYPE_PROXY = 3;
        private const uint INTERNET_FLAG_RELOAD = 0x80000000;

        void get_file(string sURLFileName,string sSaveFileName)
        {
            int lRet;
            lRet = InternetOpen("", INTERNET_OPEN_TYPE_DIRECT, "", "", 0);
            lRet = URLDownloadToFile(0, sURLFileName, sSaveFileName, 0, 0);

        }
       * */

        public Form1()
        {
            InitializeComponent();
        }

        Thread th2;
        int linkidx = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ParameterizedThreadStart(BD));
            th.Start(textBox1.Text);
        }
        bool tryWrite(string link)
        {
            StreamWriter sw;
            try
            {

                sw = new StreamWriter("test.htm", true, Encoding.Unicode);
                sw.WriteLine("<a href=\"" + link + "\">" + link + "</a>");
                sw.Close();
                return true;
            }
            catch
            {
                //sw.Close();
                return false;
            }
                    
        }
        void BD(object sURL)
        {
            StreamWriter sw2;
            
            //string sURL = textBox1.Text;
            WebRequest wrGETURL;
            try
            {

                wrGETURL = WebRequest.Create(sURL.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                sw2 = new StreamWriter("Cant_Run.txt", true, Encoding.Unicode);
                sw2.WriteLine("Error: " + e.Message);
                sw2.Close();
                return;
            }

            Stream objStream;
            try
            {
                
                objStream = wrGETURL.GetResponse().GetResponseStream();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                sw2 = new StreamWriter("Cant_Run.txt", true, Encoding.Unicode);
                sw2.WriteLine("Error: " + e.Message);
                sw2.Close();
                return;
            }
           // Stream objStream;
            
            byte[] page = new byte[100000];
            string buf, substr;
            string[] links = new string[150];
            string[] names = new string[50];
            int idx = 0, secondidx = 0, diff = 0, linkendidx = 0, i = 0, nameendidx = 0, idx2=0;
            //page = File.ReadAllBytes(@"F:\xx.htm");
            for (long j = 0; j < 100000; j++)
                objStream.Read(page, (int)j, 1);
            buf = Encoding.Default.GetString(page);
            buf = buf.ToLower();
            buf = buf.Replace("&#0146;", "'");
            buf = buf.Replace("&#0145;", "'");
            while (idx != -1)
            {
                idx = buf.IndexOf("<a href=", idx2);
                /*if (idx == -1)
                {
                    idx = buf.IndexOf("<a href=", idx2);
                    if (idx == -1)
                    {
                        MessageBox.Show("Ended");
                        return;
                    }
                }*/
               // idx2 = buf.IndexOf("\"", idx);
                //idx2=buf.IndexOf('"',idx);
                idx2= buf.IndexOf( '"',idx+10);
               // MessageBox.Show(idx.ToString() + "\n" + idx2.ToString()+"\n");
                links[linkidx] = buf.Substring((int)idx+9, idx2-idx-9);
                //links[linkidx].Trim();//.Replace(" ", "%20");
                if (links[linkidx].Contains(".mpeg") || links[linkidx].Contains(".mpg") || links[linkidx].Contains(".avi") /*|| links[linkidx].Contains(".rar") || links[linkidx].Contains(".zip")*/)
                {
                    //StringBuilder ss=link;
                    //   MessageBox.Show("contain");
                    //fs = File.Open("c:\\tobed.txt", FileMode.Append);
                    
                    System.Diagnostics.Process.Start("download_files1.exe",links[linkidx].Trim() + " " + Application.StartupPath + @"\downloads\" + idx.ToString() + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                    while(!tryWrite(links[linkidx]))Thread.Sleep(1000);
                    //fs.Write(Encoding.ASCII.GetBytes(links[linkidx]), 0, Encoding.ASCII.GetBytes(links[linkidx]).Length);
                    //fs.WriteByte(Convert.ToByte('\n'));
                    //fs.Close();
                    /*if (File.Exists(Application.StartupPath + @"downloads\" + links[linkidx].Substring(links[linkidx].LastIndexOf('/') + 1)))
                    {

                        get_file(links[linkidx], Application.StartupPath + @"\downloads\" + linkidx.ToString() + links[linkidx].Substring(links[linkidx].LastIndexOf('/') + 1));
                    }
                    else
                    {
                        get_file(links[linkidx], Application.StartupPath + @"\downloads\" + idx.ToString() +  links[linkidx].Substring(links[linkidx].LastIndexOf('/') + 1));
                    }*/

                    


                }
                else if ((links[linkidx].Contains(".") == false) && links[linkidx].EndsWith("/")) 
                {


                    th2 = new Thread(new ParameterizedThreadStart(BD));
                    th2.Start(links[linkidx]);
                }
                linkidx++;

                /*secondidx = buf.IndexOf("</A>",idx2);
                if (secondidx == -1)
                {
                    secondidx = buf.IndexOf("</a>", idx2);
                    if (secondidx == -1)
                    {
                        MessageBox.Show("Ended");
                        return;
                    }
                }*/
                //MessageBox.Show(secondidx.ToString());
                //buf.Remove(0, secondidx + 4);
               // MessageBox.Show(links[linkidx] + "\n" + links[linkidx].Length.ToString());
                
            }
            }
        void target(object links1)
        {
            FileStream fs;
            string link = links1.ToString();
            MessageBox.Show(link);
            string sURL = link;
            WebRequest wrGETURL;
            try
            {

                wrGETURL = WebRequest.Create(sURL);
            }
            catch (Exception e)
            {
                return;
            }
            Stream objStream;
            StreamWriter sw;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            byte[] page = new byte[300000];
            string buf, substr;
            string[] links = new string[50];
            string[] names = new string[50];
            int idx = 0, secondidx = 0, diff = 0, linkidx = 0, linkendidx = 0, i = 0, nameendidx = 0, idx2=0;
            for (long j = 0; j < 100000; j++)
                objStream.Read(page, (int)j, 1);
            buf = Encoding.Default.GetString(page);
            buf = buf.ToLower();
            while (idx != -1)
            {
                idx = buf.IndexOf("<a href=", idx2);
                idx2 = buf.IndexOf('"', idx + 10);
                // MessageBox.Show(idx.ToString() + "\n" + idx2.ToString()+"\n");
                links[linkidx] = buf.Substring((int)idx + 9, idx2 - idx - 9);
                //System.Diagnostics.Process.Start("iexplore", link);
                if (links[linkidx].Contains(".mpeg") || links[linkidx].Contains(".mpg") || links[linkidx].Contains(".avi") || links[linkidx].Contains(".rar") || links[linkidx].Contains(".zip"))
                {
                    //StringBuilder ss=link;
                 //   MessageBox.Show("contain");
                    //fs = File.Open("c:\\tobed.txt", FileMode.Append);
                    
                   // sw = new StreamWriter("c:\\tobed.txt", true, Encoding.ASCII); //File.AppendText("c:\\tobed.dat");
                   // sw.WriteLine(links[linkidx]);
                   // sw.Close();
                    //fs.Write(Encoding.ASCII.GetBytes(links[linkidx]), 0, Encoding.ASCII.GetBytes(links[linkidx]).Length);
                    //fs.WriteByte(Convert.ToByte('\n'));
                    //fs.Close();
                         /*   if (File.Exists(Application.StartupPath + @"\downloads\" +link.Substring(link.LastIndexOf('/') + 1)))
                           {
                    
                               get_file(link, Application.StartupPath + @"\downloads\" + linkidx.ToString() + link.Substring(link.LastIndexOf('/') + 1));
                           }
                            else
                            {
                                get_file(link, Application.StartupPath + @"\downloads\" + idx.ToString() +link.Substring(link.LastIndexOf('/') + 1));
                            }
                         */


                }
            }
                linkidx++;
        }

    }
}
