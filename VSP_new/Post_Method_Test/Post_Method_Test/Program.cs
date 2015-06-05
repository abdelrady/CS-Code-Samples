using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace Post_Method_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(/*"http://localhost/cms/login.aspx?ReturnUrl=%2fcms%2fAdminstration%2fadmin.aspx"*/"https://www.tansik.egypt.gov.eg/Application/Login/login1.aspx");
            wr.Method = "GET";
            
            
            Console.WriteLine("writeData...");
            WebResponse ws = wr.GetResponse();
            Console.WriteLine("writeData...");
            StreamReader sr = new StreamReader(ws.GetResponseStream());
            Console.WriteLine(string.Join(" , ", ws.Headers.AllKeys));
            Console.WriteLine("writeData...");
            string str = "";
            File.Delete("e:\\a.htm");
            
            Char[] readBuff = new Char[256];
            int count = sr.Read(readBuff, 0, 256);
            Console.WriteLine("\nThe HTML contents of page the are  : \n\n ");
            while (count > 0)
            {
                String outputData = new String(readBuff, 0, count);
                File.AppendAllText("e:\\a.htm", outputData);
                Console.Write(outputData);
                count = sr.Read(readBuff, 0, 256);
            }
        }
    }
}
/*www.07770500.com hack */
/*HttpWebRequest wr = (HttpWebRequest)WebRequest.Create("http://ecc.07770500.com/natega_show.asp" /*"http://localhost:1248/WebSite2/Default.aspx");
            wr.Method = "POST";
            wr.ContentType = "application/x-www-form-urlencoded";
            //wr.Headers.Add("data", "Dept=3&ID=747883");
            //wr.Headers.Add("Dept=3");//ID:747883
            //wr.Headers.Add("ID=747883");
            Stream ss = wr.GetRequestStream();
            byte[] data = Encoding.Default.GetBytes("Dept=2&ID=747841&ID=747842&ID=747843&ID=747844");
            ss.Write(data, 0, data.Length);
            ss.Flush();
            ss.Close();
            //StreamWriter sw = new StreamWriter(ws.GetResponseStream());
            //sw.Write("Dept=3&ID=747883");
            Console.WriteLine("writeData...");
            WebResponse ws = wr.GetResponse();
            Console.WriteLine("writeData...");
            StreamReader sr = new StreamReader(ws.GetResponseStream());
            Console.WriteLine("writeData...");
            string str = "";
            File.Delete("e:\\a.htm");
            
            Char[] readBuff = new Char[256];
            int count = sr.Read(readBuff, 0, 256);
            Console.WriteLine("\nThe HTML contents of page the are  : \n\n ");
            while (count > 0)
            {
                String outputData = new String(readBuff, 0, count);
                File.AppendAllText("e:\\a.htm", outputData);
                Console.Write(outputData);
                count = sr.Read(readBuff, 0, 256);
            }*/