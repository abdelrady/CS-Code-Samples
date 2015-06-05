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
using System.Diagnostics;
using System.Collections;

namespace Browse_Dwonload_links1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int linkidx = 0;
        string[] Filters;

        private void button1_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter("childs_Links.htm", true, Encoding.Unicode);
            ParsetxtFilter();
            Thread th = new Thread(new ParameterizedThreadStart(BD));

            if (!this.checkBox1.Checked)
            {
                StreamReader sr = new StreamReader("link2visit.txt");
                string str = sr.ReadLine();

                th.Start((object)str);
                //MessageBox.Show(str);
                sr.Close();
            }
            else
            {
                th.Start(this.txtLink.Text);
            }
        }

        private void ParsetxtFilter()
        {   
            Filters = this.txtFilter.Text.Split(';');
        }
        StreamWriter sw;
        void BD(object sURL)
        {
            string ipAdress = "";
            GetIpAddress((string)sURL,ref ipAdress);
            
            StreamWriter sw = new StreamWriter("parent_Links.html", false);
            //string sURL = textBox1.Text;
            WebRequest wrGETURL;

            try
            {
                wrGETURL = WebRequest.Create("http://"+ipAdress+"/");
            }
            catch // (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message);
                //sw2 = new StreamWriter("Cant_Run.txt", true);
                //sw2.WriteLine("Error: " + e.Message);
                //sw2.Close();
                return;
            }

            StreamReader objStream;
            try
            {
                objStream =new StreamReader(wrGETURL.GetResponse().GetResponseStream());
            }
            catch //(Exception e)
            {
                // MessageBox.Show("Error: " + e.Message);
                //sw2 = new StreamWriter("Cant_Run.txt", true, Encoding.Unicode);
                //sw2.WriteLine("Error: " + e.Message);
                //sw2.Close();
                return;
            }
            // Stream objStream;

            //byte[] page = new byte[200000];
            string buf;
            string links;
            int idx = 0, idx2 = 0;
            /*for (long j = 0; j < 200000; j++)
                objStream.Read(page, (int)j, 1);
            buf = Encoding.Default.GetString(page);
            buf.Trim();*/
            buf = objStream.ReadToEnd().ToLower();
            File.WriteAllText("home_page.html", buf);
            MessageBox.Show("ÕÃ„ «·’›ÕÂ «·—∆Ì”ÌÂ:" + buf.Length.ToString());
            // buf = buf.Replace("&#0146;", "'");
            // buf = buf.Replace("&#0145;", "'");
            //textBox2.Text = buf;
            string str = this.TxtStartIndex.Text;
            idx2 = buf.IndexOf(str.ToLower());
            if (idx2 == -1)
            {
                //MessageBox.Show(idx2.ToString());
                return;
            }
            idx = 0;
            int linksCount = 0;
            AutoResetEvent asyncOpIsDone = new AutoResetEvent(false);
            ThreadPool.SetMaxThreads(int.MaxValue, 10);
            while (idx != -1 && linksCount < int.Parse(this.textBox4.Text))
            {
                idx = buf.IndexOf("href=", idx2);
                if (idx == -1)
                {
                    sw.Close();
                    return;
                }
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
                idx2 = buf.IndexOf('"', idx + 10);
                if (idx2 != -1)
                {
                    // MessageBox.Show(idx.ToString() + "\n" + idx2.ToString()+"\n");
                    links = buf.Substring((int)idx + 6, idx2 - idx - 6);
                    if (links.EndsWith("/movies.html") || links.EndsWith("/movies2.html")) return;
                    sw.WriteLine("<a href=\"" + links + "\">" + links + "</a><br>");
                    //links[linkidx].Trim();//.Replace(" ", "%20");
                    linksCount++;
                    //th2 = new Thread(new ParameterizedThreadStart(ExtM));
                    //th2.Start(links);
                    ArrayList ar = new ArrayList(2);
                    ar.Add(asyncOpIsDone);
                    ar.Add(links);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(ExtM), ar);
                    //if (linksCount % 10 == 0) Thread.Sleep(2000);
                }
                else //if (idx2 == -1)
                {
                    break;
                }
            }
            sw.Close();
            asyncOpIsDone.WaitOne();        //ÂÌ Â‰« „·Â«‘ ·«“„Â «‰„« „⁄‰«Â« «‰Â ÂÌ” ‰Ì ·€«ÌÂ ﬂ· «·»—ﬂÂ  Œ·’ ‘€·
            //MessageBox.Show("Loading complete Of Home Page.");
        }

        private bool GetIpAddress(string url2Parse,ref string ipaddress)
        {
            WebRequest wrGETURL;

            try
            {
                wrGETURL = WebRequest.Create("http://toolbar.netcraft.com/site_report?url=" + url2Parse);
                /* structure within url file recieved....
                 * <TD><B>IP address</B></TD><TD width="38%">87.248.113.14</TD>
                 */ 
            }
            catch //(Exception e)
            {
                return false;
            }

            StreamReader objStream;
            try
            {
                objStream =new StreamReader( wrGETURL.GetResponse().GetResponseStream());
            }
            catch //(Exception e)
            {
                return false;
            }
            // Stream objStream;
            //byte[] page = new byte[200000];
            string buf;
            int idx = 0, idx2 = 0;
            
           buf= objStream.ReadToEnd().ToLower();

            //page = File.ReadAllBytes(@"F:\xx.htm");
            //for (long j = 0; j < 200000; j++)
            //    objStream.Read(page, (int)j, 1);
            //buf = Encoding.Default.GetString(page);
            //buf.Trim();
            //buf = buf.ToLower();
            //File.WriteAllText("home_page.html", buf);
            //MessageBox.Show("ÕÃ„ «·’›ÕÂ «·—∆Ì”ÌÂ:" + buf.Length.ToString());
            //// buf = buf.Replace("&#0146;", "'");
            // buf = buf.Replace("&#0145;", "'");
            //textBox2.Text = buf;

           idx = buf.IndexOf("<TD><B>IP address</B></TD>".ToLower());
           idx = buf.IndexOf('>', idx + "<TD><B>IP address</B></TD>".Length+2);//you can add +1 or 2 or ....... but <9
           idx2= buf.IndexOf("</", idx );
           if ((idx2 == -1 || idx2 == -1) || (idx2 < idx))
           {
               //MessageBox.Show(idx2.ToString());
               return false;
           }
           else
           {
               ipaddress = buf.Substring((int)idx + 1, idx2 - idx);//from begining of ip as numbers  >87.248.113.14</TD>
               return true;
           }
           //return false;
        }

        public int pageindex = 1;

/// <summary>
/// /////////////////////////////Download Objects
/// </summary>
/// <param name="link">link to be downloaded</param>
        void ExtM(object state_and_link)
        {
            ArrayList ar = (ArrayList)state_and_link;
            string linkWithoutHtm = ar[1].ToString().Substring(0, ar[1].ToString().LastIndexOf('/') + 1);
            //string sURL = textBox1.Text;
            
            string ipAdress = "";
            if (!GetIpAddress(linkWithoutHtm, ref ipAdress))
                return;
            
            WebRequest wrGETURL;
            try
            {
                wrGETURL = WebRequest.Create("http://" + ipAdress + ar[1].ToString().Substring(ar[1].ToString().LastIndexOf('/')));
            }
            catch
            {
                return;
            }

            Stream objStream;
            try
            {
                objStream = wrGETURL.GetResponse().GetResponseStream();
            }
            catch
            {
                return;
            }

            //BinaryReader br = new BinaryReader(objStream);
            byte[] page = new byte[100000];
            string buf;
            string[] links = new string[150];
            int idx = 0, idx2 = 0;
            //page = File.ReadAllBytes(@"F:\xx.htm");
            for (long j = 0; j < 100000; j++)
                objStream.Read(page, (int)j, 1);
            buf = Encoding.Default.GetString(page);
            buf = buf.ToLower();
            buf = buf.Replace("&#0146;", "'");
            buf = buf.Replace("&#0145;", "'");
            lock (this)
            {
                File.WriteAllText("downloads\\Link_" + (pageindex++) + ".htm", buf);
            }
            while (idx != -1)
            {
                idx = buf.IndexOf("href=", idx2);
                if (idx != -1)
                {
                    idx2 = buf.IndexOf('"', idx + 10);
                    if (idx2 != -1 && idx2 > idx)
                    {
                        links[linkidx] = buf.Substring((int)idx + 6, idx2 - idx - 6);
                        //links[linkidx].Trim();//.Replace(" ", "%20");

                        //Uri urii = new Uri(links[linkidx]);
                        //urii.LocalPath    //File Name.Mpg
                        /*if (links[linkidx].Contains(".mpeg")
                            || links[linkidx].Contains(".mpg")
                            || links[linkidx].Contains(".avi")
                            || links[linkidx].Contains(".wmv")*//*|| links[linkidx].Contains(".rar") || links[linkidx].Contains(".zip")*/
                        for(int z=0;z<Filters.Length;z++)
                        if (links[linkidx].Contains(Filters[z]))
                        {
                            //tryWrite(links[linkidx]);
                            //////////links[linkidx].Replace(' ', '+');
                            //if(radioButton1.Checked )System.Diagnostics.Process.Start("download_files1.exe", links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                            //else if (radioButton2.Checked) System.Diagnostics.Process.Start("download_files2.exe", links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                            //else if (radioButton3.Checked) System.Diagnostics.Process.Start(textBox2.Text, links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                            //System.Diagnostics.Process.Start("download_files2.exe", linkWithoutHtm + links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                            /*  lock (this)
                              {
                                  this.notifyIcon1.BalloonTipText = linkWithoutHtm + links[linkidx];
                                  this.notifyIcon1.ShowBalloonTip(0);
                              }*/
                            //while (!tryWrite(linkWithoutHtm + links[linkidx])) Thread.Sleep(50);
                            sw.WriteLine("<a href=\"" + ("http://"+ipAdress +"/"+ links[linkidx]) + "\">" + "HelloWorld......" + "</a><br>");
                            break;
                        }
                    }

                    else
                    {
                        //MessageBox.Show("idx2=-1");
                    }
                }
                else
                {
                    break;
                    //MessageBox.Show("idx=-1");
                }
            }
            ((AutoResetEvent)ar[0]).Set();

            /*
        catch (Exception e)
        {
            continue;
        }*/
            // MessageBox.Show("Loading complete Of all Sub Pages.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sw.Close();
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sw.Close();
            }
            catch { }
        }

        #region Deprecated
        /*
         *         bool tryWrite(string link)
        {
            StreamWriter sw;
            try
            {

                sw = new StreamWriter("childs_Links.htm", true, Encoding.Unicode);
                sw.WriteLine("<a href=\"" + link + "\">" + "HelloWorld......" + "</a><br>");
                sw.Close();
                return true;
            }
            catch
            {
                //sw.Close();
                return false;
            }
                    
        }
         * 
        void target(object links1)
        {
            FileStream fs;
            string link = links1.ToString();
            //MessageBox.Show(link);
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
                           // if (File.Exists(Application.StartupPath + @"\downloads\" +link.Substring(link.LastIndexOf('/') + 1)))
                           //{
                    
                           //    get_file(link, Application.StartupPath + @"\downloads\" + linkidx.ToString() + link.Substring(link.LastIndexOf('/') + 1));
                           //}
                           // else
                           // {
                           //     get_file(link, Application.StartupPath + @"\downloads\" + idx.ToString() +link.Substring(link.LastIndexOf('/') + 1));
                           // }
                         


                }
            }
                linkidx++;
        }*/
        #endregion
    }
}
