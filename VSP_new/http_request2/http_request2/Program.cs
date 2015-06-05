using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace http_request2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CommunicatingWithWebServer();
            // Set the 'Method' property of the 'Webrequest' to 'POST'.
           // HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/asp1/ip.asp");
             //   myHttpWebRequest.Method = "POST";
            //Console.WriteLine("\nPlease enter the data to be posted to the (http://www.contoso.com/codesnippets/next.asp) Uri :");

            // Create a new string object to POST data to the Url.
            //string inputData = Console.ReadLine();


            string postData = @"selectFont=0&selectFontSize=0&forumCodes=True&email=True&message=welcome+back&mode=reply&FID=1&TID=1&PID=1&TPN=1&ThreadPos=2&browser=RTE&sessionID=1052809629";

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] byte1;
            

            // Set the content type of the data being posted.
            Stream newStream;
            for (int i = 0; i < 5; i++)
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.0.1/web2/post_message.asp?PN=1");
                myHttpWebRequest.Method = "POST";
                myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
                myHttpWebRequest.Referer = "http://192.168.0.1/web2/forum_posts.asp?TID=1&PN=1";
                myHttpWebRequest.Headers.Add("Cookie","WWF=NS=0&UID=masterA5C223A9C2&LTVST=39301%2E2343518519; RT=TID1=1; __utma=224789850.1112439389.1186030208.1186030208.1186030208.1; __utmz=224789850.1186030208.1.1.utmccn=(direct)|utmcsr=(direct)|utmcmd=(none); _dmnid=578665_1186030208859; ASPSESSIONIDASACBSQQ=MJJJAMODCKNFHOHLBHLMJPJL");
                //CookieCollection cook = new CookieCollection();
                //cook.Add();
                //myHttpWebRequest.CookieContainer=
                //postData += i.ToString();
                byte1 = encoding.GetBytes(postData);
                // Set the content length of the string being posted.
                myHttpWebRequest.ContentLength = byte1.Length;
                newStream = myHttpWebRequest.GetRequestStream();
                try
                {
                    Console.WriteLine(i.ToString());
                    newStream.Write(byte1, 0, byte1.Length);
                    newStream.Flush();
                    HttpWebResponse res2 =(HttpWebResponse) myHttpWebRequest.GetResponse();
                    //WebResponse res = myHttpWebRequest.GetResponse();
                    ((Stream)res2.GetResponseStream()).Read(byte1, 0, byte1.Length);
                    Console.WriteLine(System.Text.Encoding.ASCII.GetString(byte1));
                }
                catch (Exception e)
                {
                }
               
                newStream.Close();
                myHttpWebRequest = null;
                byte1 = null;
                //postData = "ip=";
                //newStream = null;
                //System.Threading.Thread.Sleep(10);
            }
            //Console.WriteLine("The value of 'ContentLength' property after sending the data is {0}", myHttpWebRequest.ContentLength);

            // Close the Stream object.
            //newStream.Close();

        }
    }
}
