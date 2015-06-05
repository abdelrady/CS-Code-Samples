using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace http_webRequest1
{
    class Program
    {
        public static void CommunicatingWithWebServer()
        {

            HttpWebRequest request =

                GenerateGetOrPostRequest("http://localhost/asp1/ip.asp", "POST", @"ip=ahmed & add=Add");



            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Console.WriteLine(response.GetResponseHeader("TTL"));

            // This next line uses VerifyResponse from Recipe 13.5
            
            /*if ( VerifyResponse(response) == ResponseCategories.Success)
            {

                Console.WriteLine("Request succeeded");

            }*/

        }



        public static HttpWebRequest GenerateGetOrPostRequest(string uriString,

            string method,

            string postData)
        {

            if ((method.ToUpper() != "GET") &&

                (method.ToUpper() != "POST"))

                throw new ArgumentException(method +

                    " is not a valid method.  Use GET or POST.", "method");



            HttpWebRequest httpRequest = null;

            // get a URI object

            Uri uri = new Uri(uriString);

            // create the initial request

            httpRequest = (HttpWebRequest)WebRequest.Create(uri);



            // check if asked to do a POST request, if so then modify 

            // the original request as it defaults to a GET method

            if (method.ToUpper() == "POST")
            {

                // Get the bytes for the request, should be pre-escaped

                byte[] bytes = Encoding.UTF8.GetBytes(postData);



                // Set the content type of the data being posted.

                httpRequest.ContentType =

                    "application/x-www-form-urlencoded";



                // Set the content length of the string being posted.

                httpRequest.ContentLength = bytes.GetLength(0);



                // Get the request stream and write the post data in

                System.IO.Stream requestStream = httpRequest.GetRequestStream();

                requestStream.Write(bytes, 0, bytes.Length);

                // Done updating for POST so close the stream

                requestStream.Close();

            }



            // return the request

            return httpRequest;

        }

        static void Main(string[] args)
        {
            //CommunicatingWithWebServer();
            // Set the 'Method' property of the 'Webrequest' to 'POST'.
           // HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/asp1/ip.asp");
             //   myHttpWebRequest.Method = "POST";
            //Console.WriteLine("\nPlease enter the data to be posted to the (http://www.contoso.com/codesnippets/next.asp) Uri :");

            // Create a new string object to POST data to the Url.
            //string inputData = Console.ReadLine();


                string postData = "ip=";

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] byte1;
            

            // Set the content type of the data being posted.
            Stream newStream;
            for (int i = 0; i < 30000; i++)
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/asp1/ip.asp");
                myHttpWebRequest.Method = "POST";
                myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            
                postData += i.ToString();
                byte1 = encoding.GetBytes(postData);
                // Set the content length of the string being posted.
                myHttpWebRequest.ContentLength = byte1.Length;
                newStream = myHttpWebRequest.GetRequestStream();
                try
                {
                    Console.WriteLine(i.ToString()+"\t"+postData);
                    newStream.Write(byte1, 0, byte1.Length);
                    newStream.Flush();
                    WebResponse res = myHttpWebRequest.GetResponse();
                    Console.WriteLine(((Stream) res.GetResponseStream()).Read(byte1,0,byte1.Length));
                }
                catch (Exception e)
                {
                }
               
                newStream.Close();
                myHttpWebRequest = null;
                byte1 = null;
                postData = "ip=";
                //newStream = null;
                //System.Threading.Thread.Sleep(10);
            }
            //Console.WriteLine("The value of 'ContentLength' property after sending the data is {0}", myHttpWebRequest.ContentLength);

            // Close the Stream object.
            //newStream.Close();

        }
    }
}
