using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace webrequest_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(new Uri("http://www.freeproxyserver.ca/index.php?btxmnercdeqt=aHR0cDovL3d3dy55b3V0dWJlLmNvbQ%3D%3D&hl=3ad"));
            wr.AllowAutoRedirect = true;
            //wr.KeepAlive = true;
            wr.Method = "Get";

            StreamReader sr;
            //wr.Proxy
            sr = new StreamReader(wr.GetResponse().GetResponseStream());
            File.WriteAllText("e:\\abc.htm", sr.ReadToEnd());
            sr.Close();
            */

            StreamReader sr;
            int i = 0;
            //string str = Dns.GetHostByName("www.youtube.com").AddressList[0].Address.ToString();
            IPHostEntry iphs = Dns.GetHostEntry("youtube.com");

            foreach (IPAddress ip in iphs.AddressList)
            {
                string str = ip.ToString();
                //WebClient web = new WebClient();
                string link = "http://" + str + "/";
                Console.WriteLine(link);
                byte[] byt = Encoding.Default.GetBytes(ip.Address.ToString());
                //Array.Reverse(byt);

                Console.WriteLine("http://" + Encoding.Default.GetString(byt) + "/");
                try
                {
                    //HttpWebRequest wr = (HttpWebRequest)WebRequest.CreateDefault(new Uri("http://www.freeproxyserver.ca/index.php"));
                    //wr.Proxy = new WebProxy("http://www.freeproxyserver.ca/");
                    //wr.AllowAutoRedirect = true;
                    //wr.KeepAlive = true;
                    //wr.Method = "Post";

                    //wr.Proxy
                    //sr = new StreamReader(wr.GetResponse().GetResponseStream());
                    //   File.WriteAllText("e:\\asd"+(i++)+".html", sr.ReadToEnd());
                    //sr.Close();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //continue;
                }
                finally
                {
                    //                    sr.Close();
                }
                // trytest();
                // try2();
            }
        }

        private static void try2()
        {
            string lcUrl = "http://www.freeproxyserver.ca/index.php?btxmnercdeqt=aHR0cDovL3d3dy55b3V0dWJlLmNvbQ%3D%3D&hl=3ad";

            HttpWebRequest loHttp =

               (HttpWebRequest)WebRequest.Create(lcUrl);



            // *** Send any POST data

            string lcPostData =

               "btxmnercdeqt=http://www.youtube.com&hl=3ad";



            loHttp.Method = "POST";

            byte[] lbPostBuffer = System.Text.

                                   Encoding.GetEncoding(1252).GetBytes(lcPostData);

            loHttp.ContentLength = lbPostBuffer.Length;



            Stream loPostData = loHttp.GetRequestStream();

            loPostData.Write(lbPostBuffer, 0, lbPostBuffer.Length);

            loPostData.Close();



            HttpWebResponse loWebResponse = (HttpWebResponse)loHttp.GetResponse();



            Encoding enc = System.Text.Encoding.GetEncoding(1252);



            StreamReader loResponseStream =

               new StreamReader(loWebResponse.GetResponseStream(), enc);



            string lcHtml = loResponseStream.ReadToEnd();



            loWebResponse.Close();

            loResponseStream.Close();
            File.WriteAllText("e:\\zxc.htm",lcHtml);

        }

        private static void trytest()
        {
            //sync
            WebRequest request = WebRequest.Create("http://208.65.153.251/");
            Stream response = request.GetResponse().GetResponseStream();
            File.WriteAllText("e:\\zxc.htm", new StreamReader(response).ReadToEnd());
	
        }
        void MyCallback(IAsyncResult ar)
        {
            
        }
    }
}
