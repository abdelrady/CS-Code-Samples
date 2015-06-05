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

        Thread th2;
        int linkidx = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("link2visit.txt");
            string str=sr.ReadLine();
            Thread th = new Thread(new ParameterizedThreadStart(BD));
            th.Start((object)str);
            //MessageBox.Show(str);
            sr.Close();
        }
        bool tryWrite(string link)
        {
            StreamWriter sw;
            try
            {

                sw = new StreamWriter("childs_Links.htm", true, Encoding.Unicode);
                sw.WriteLine("<a href=\"" + link + "\">" + link + "</a><br>");
                sw.Close();
                return true;
            }
            catch
            {
                //sw.Close();
                return false;
            }
                    
        }
        //
        //
        //
        ArrayList _threads;


        /// <summary>
        /// Parse The Parent Html File & extract parent links...
        /// </summary>
        /// <param name="sURL"></param>
        void BD(object sURL)
        {
            string linkWithoutHtm = sURL.ToString().Substring(0, sURL.ToString().LastIndexOf('/') + 1);
            //StreamWriter sw2;
            
            StreamWriter sw = new StreamWriter("parent_Links.html", false);
            //string sURL = textBox1.Text;
            WebRequest wrGETURL;

            try
            {

                wrGETURL = WebRequest.Create(sURL.ToString());
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message);
                //sw2 = new StreamWriter("Cant_Run.txt", true);
                //sw2.WriteLine("Error: " + e.Message);
                //sw2.Close();
                return;
            }

            Stream objStream;
            try
            {
                
                objStream = wrGETURL.GetResponse().GetResponseStream();
            }
            catch (Exception e)
            {
               // MessageBox.Show("Error: " + e.Message);
                //sw2 = new StreamWriter("Cant_Run.txt", true, Encoding.Unicode);
                //sw2.WriteLine("Error: " + e.Message);
                //sw2.Close();
                return;
            }
           // Stream objStream;
            
            byte[] page = new byte[200000];
            string buf, substr;
            string links;
            //string[] names = new string[50];
            int idx = 0, idx2=0;
            //page = File.ReadAllBytes(@"F:\xx.htm");
            for (long j = 0; j < 200000; j++)
                objStream.Read(page, (int)j, 1);
            buf = Encoding.Default.GetString(page);
            buf.Trim();
            buf = buf.ToLower();
            File.WriteAllText("home_page.html", buf);
            MessageBox.Show("ÍÌã ÇáÕÝÍå ÇáÑÆíÓíå:" + buf.Length.ToString());
           // buf = buf.Replace("&#0146;", "'");
           // buf = buf.Replace("&#0145;", "'");
            //textBox2.Text = buf;
            string str = this.textBox3.Text ;
            idx2 = buf.IndexOf(str.ToLower());
            if (idx2 == -1)
            {
                //MessageBox.Show(idx2.ToString());
                return;
            }
            idx = 0;
            int linksCount = 0;

            AutoResetEvent asyncOpIsDone = new AutoResetEvent(false);

            while (idx != -1 && linksCount<15)
            {
                //this.Text = linksCount.ToString();
                //try
                {
                    idx = buf.IndexOf("href=", idx2);
                    if (idx == -1)
                    {
                        sw.Close();
                        //return;
                        break;
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
                    if (idx2 != -1 )
                    {
                        // MessageBox.Show(idx.ToString() + "\n" + idx2.ToString()+"\n");
                        links = buf.Substring((int)idx + 6, idx2 - idx - 6);
                        if (links.EndsWith("/movies.html") || links.EndsWith("/movies2.html")) return;
                        sw.WriteLine("<a href=\"" + links + "\">"+links+"</a><br>");
                        //links[linkidx].Trim();//.Replace(" ", "%20");
                        linksCount++;
                        //th2 = new Thread(new ParameterizedThreadStart(ExtM));
                        //th2.Name = linkWithoutHtm+links;
                        //_threads.Add(th2);
                        ThreadPool.QueueUserWorkItem(new WaitCallback(ExtM), asyncOpIsDone);
                        //th2.Start(links);
                        //if (linksCount % 10 == 0) Thread.Sleep(2000);
                    }
                    else //if (idx2 == -1)
                    {
                        break;
                    }

                }/*
                catch (Exception e)
                {
                    continue;
                }*/
                //linkidx++;

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
            sw.Close();
            MessageBox.Show("Parsing Sub Nodes");
            StartParsingSubNodes(false);
           //MessageBox.Show("Loading complete Of Home Page.");
            }
        object _lockObject = new object();
        int limit;
        private void StartParsingSubNodes(bool one)
        {
            if (one)
            {
                foreach (Thread th in _threads)
                {
                    lock (_lockObject)
                    {
                        if (!th.IsAlive)
                        {
                            //MessageBox.Show(th.Name);
                            th.Start(th.Name);
                            return;
                        }
                    }
                }
            }
            else
            {
                //MessageBox.Show("Parsing Sub Nodes");
                lock (_lockObject)
                {
                    limit = int.Parse(this.textBox4.Text);
                    this.Text = limit.ToString();
                }
                int i = 0;
                foreach (Thread th in _threads)
                {
                    lock (_lockObject)
                    {
                        if (!th.IsAlive)
                        {
                            //MessageBox.Show(th.Name);
                            th.Start(th.Name);
                            //this.Text = i.ToString();
                        }
                    }
                    i++;
                    if (i == limit) break;
                }
            }
        }
        private void RemoveFromPool(Thread th)
        {
            foreach (Thread th2 in _threads)
            {
                if (th2 == th)
                {
                    lock (this)
                    {
                        if (th.IsAlive)
                           th.Abort();
                        _threads.Remove(th2);
                        //this.Text = th2.Name;
                    }
                    StartParsingSubNodes(true);
                }
            }
        }

        public int pageindex = 1;

/// <summary>
/// /////////////////////////////Download Objects
/// </summary>
/// <param name="link">link to be downloaded</param>
        void ExtM(object link)
        {
            string linkWithoutHtm = link.ToString().Substring(0, link.ToString().LastIndexOf('/') + 1);
           //StreamWriter sw2;
            
            //string sURL = textBox1.Text;
            WebRequest wrGETURL;
            try
            {
                wrGETURL = WebRequest.Create(link.ToString());
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message);
             //   sw2 = new StreamWriter("Cant_link.txt", true, Encoding.Unicode);
             //   sw2.WriteLine("Error: " + e.Message);
             //   sw2.Close();
                
                return;
            }

            Stream objStream;
            try
            {
                
                objStream = wrGETURL.GetResponse().GetResponseStream();
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message);
                //sw2 = new StreamWriter("Cant_link.txt", true, Encoding.Unicode);
                //sw2.WriteLine("Error: " + e.Message);
                //sw2.Close();
                return;
            }
           // Stream objStream;
            
            byte[] page = new byte[100000];
            string buf;
            string[] links = new string[150];
            
            
            int idx = 0, idx2=0;
            //page = File.ReadAllBytes(@"F:\xx.htm");
            for (long j = 0; j < 100000; j++)
                objStream.Read(page, (int)j, 1);
            buf = Encoding.Default.GetString(page);
            buf = buf.ToLower();
            buf = buf.Replace("&#0146;", "'");
            buf = buf.Replace("&#0145;", "'");
            File.WriteAllText("downloads\\Link_" + (pageindex++) + ".htm", buf);
            while (idx != -1)
            {
                //try
                {

                    idx = buf.IndexOf("href=", idx2);
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
                    if (idx != -1)
                    {
                        idx2 = buf.IndexOf('"', idx + 10);
                        if (idx2 != -1 && idx2 > idx)
                        {

                            //if (idx2 == -1) continue;
                            links[linkidx] = buf.Substring((int)idx + 6, idx2 - idx - 6);
                            //links[linkidx].Trim();//.Replace(" ", "%20");

                            //Uri urii = new Uri(links[linkidx]);
                            //urii.LocalPath    //File Name.Mpg
                            if (links[linkidx].Contains(".mpeg") || links[linkidx].Contains(".mpg") || links[linkidx].Contains(".avi") || links[linkidx].Contains(".wmv") /*|| links[linkidx].Contains(".rar") || links[linkidx].Contains(".zip")*/)
                            {
                                //tryWrite(links[linkidx]);
                                //////////links[linkidx].Replace(' ', '+');
                                //if(radioButton1.Checked )System.Diagnostics.Process.Start("download_files1.exe", links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                                //else if (radioButton2.Checked) System.Diagnostics.Process.Start("download_files2.exe", links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                                //else if (radioButton3.Checked) System.Diagnostics.Process.Start(textBox2.Text, links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                                //System.Diagnostics.Process.Start("download_files2.exe", linkWithoutHtm + links[linkidx].Trim() + " " + links[linkidx].Trim().Substring(links[linkidx].LastIndexOf('/') + 1));
                                while (!tryWrite(linkWithoutHtm + links[linkidx])) Thread.Sleep(50);
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
                    /*
                catch (Exception e)
                {
                    continue;
                }*/
            }
            
            RemoveFromPool(Thread.CurrentThread);
            
           // MessageBox.Show("Loading complete Of all Sub Pages.");

        }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            _threads = new ArrayList();
        }

    }
}
