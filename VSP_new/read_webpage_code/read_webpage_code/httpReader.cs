using System;
using System.Net;
using System.IO;
using System.Text;

namespace Library.SDS.Web.Http
{

    /// <summary>
    /// Class to read HTTP Streams
    /// </summary>
    public class HttpReader
    {

        private WebRequest REQUEST = null;
        private StreamReader STREAM = null;
        private System.Text.StringBuilder STRING_BUILDER = null;
        private string LINE = string.Empty;

        /// <summary>
        /// reads the source of a web page and returns it
        /// </summary>
        /// <param name="urlToRead">the url to read</param>
        /// <returns>string: page source</returns>
        public string readWebPageSource(string urlToRead)
        {
            try
            {
                REQUEST = WebRequest.Create(urlToRead);
                STREAM = new StreamReader(REQUEST.GetResponse().GetResponseStream());
                STRING_BUILDER = new System.Text.StringBuilder();

                while ((LINE = STREAM.ReadLine()) != null)
                {
                    // Ignore blank lines
                    if (LINE.Length > 0)
                        STRING_BUILDER.Append(LINE);
                }

                STREAM.Close();
                Console.Write(STRING_BUILDER.ToString());
                return STRING_BUILDER.ToString();
            }

            catch (Exception e)
            {
                return e.Message;
            }

            finally
            {
                REQUEST = null;
                STREAM = null;
                STRING_BUILDER = null;
                LINE = null;
            }
        }




    }
}
