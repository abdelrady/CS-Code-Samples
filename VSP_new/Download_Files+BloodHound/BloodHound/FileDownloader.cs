/* ----------------------------------------------------------------------
 * 
 *  Author: Shailen Sukul BSC, MCSD.Net, Mcsd, Mcad
 *  Date: 9/April/2006
 *  Copyright Ashlen Consulting Services P/L
 * ----------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.Services.Protocols;
using System.Net;
namespace BloodHound
{
    /// <summary>
    /// FileDownloader encapsulates the file download operation.
    /// </summary>
    public class FileDownloader
    {
        #region  Fields
        private string _DocumentUrl = string.Empty;
        private string _DirectoryPath = string.Empty;
        public bool _IsDownloading = false;
        public bool _IsDownloadSuccessful = false;
        public bool _IsStarted = false;

        #endregion

        #region Delegates
        public delegate void _delDownloadStarting(FileDownloader thread);
        public delegate void _delDownloadCompleted(FileDownloader thread, bool isSuccess);

        #endregion

        #region Events
        public event _delDownloadStarting DownloadStarting;
        public event _delDownloadCompleted DownloadCompleted;

        #endregion

        #region Properties

        private string proxyUri = string.Empty;

        public string ProxyUri
        {
            get { return proxyUri; }
            set { proxyUri = value; }
        }

        public string FileName
        {
            get
            {
                if (_DocumentUrl.Equals(string.Empty))
                {
                    throw new ArgumentException("Please supply a document url.");
                }
                int loc = _DocumentUrl.LastIndexOf("/") + 1;
                int len = _DocumentUrl.Length - loc;
                string filename = _DocumentUrl.Substring(loc, len);
                return filename;
            }
        }

        #endregion

        #region Methods

        #region ctor
        public FileDownloader(string documentUrl, string directory)
        {
            _DocumentUrl = documentUrl;
            _DirectoryPath = directory;
        }
        #endregion

        /// <summary>
        /// Starts the download of the attached url into the given directory.
        /// </summary>
        public void StartDownload()
        {
            if (_DocumentUrl.Equals(string.Empty))
            {
                throw new ArgumentException("Please supply a document url.");
            }
            if (_DirectoryPath.Equals(string.Empty))
            {
                throw new ArgumentException("Please supply a directory.");
            }
            _IsStarted = true;
            /* raise the download starting event. */
            DownloadStarting(this);            
            _IsDownloading = true;
            _IsDownloadSuccessful = false;
            Stream stream = null;
            FileStream fstream = null;

            try
            {
                string destFileName = _DirectoryPath + "\\" + FileName;
                destFileName = destFileName.Replace("/", " ").Replace("%20", " ");

                if (File.Exists(destFileName) == false)
                {
                    IWebProxy proxy = null;
                    if (ProxyUri != null && ProxyUri != string.Empty)
                    {
                        proxy = new WebProxy(ProxyUri, true);
                        proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    }
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_DocumentUrl);
                    if (proxy != null)
                    {
                        request.Proxy = proxy;
                    }
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    stream = response.GetResponseStream();

                    byte[] inBuffer = ReadFully(stream, 32768);

                    fstream = new FileStream(destFileName, FileMode.OpenOrCreate, FileAccess.Write);
                    fstream.Write(inBuffer, 0, inBuffer.Length);


                    fstream.Close();
                    stream.Close();                   
                }
                _IsDownloadSuccessful = true;
                _IsDownloading = false;
                /* raise a download completed event. */
                DownloadCompleted(this, _IsDownloadSuccessful);
            }
            catch
            {
                _IsDownloadSuccessful = false;
            }
            finally
            {
                if (fstream != null)
                {
                    fstream.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }  
            }
        }

        /// <summary>
        /// Reads data from a stream until the end is reached. The
        /// data is returned as a byte array. An IOException is
        /// thrown if any of the underlying IO calls fail.
        /// </summary>
        /// <param name="stream">The stream to read data from</param>
        /// <param name="initialLength">The initial buffer length</param>
        public byte[] ReadFully(Stream stream, int initialLength)
        {
            /* If we've been passed an unhelpful initial length, just
             use 32K. */
            if (initialLength < 1)
            {
                initialLength = 32768;
            }

            byte[] buffer = new byte[initialLength];
            int read = 0;

            int chunk;
            while ((chunk = stream.Read(buffer, read, buffer.Length - read)) > 0)
            {
                read += chunk;

                /* If we've reached the end of our buffer, check to see if there's
                 any more information */
                if (read == buffer.Length)
                {
                    int nextByte = stream.ReadByte();

                    /* End of stream? If so, we're done */
                    if (nextByte == -1)
                    {
                        return buffer;
                    }

                    /* Nope. Resize the buffer, put in the byte we've just
                     read, and continue */
                    byte[] newBuffer = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuffer, buffer.Length);
                    newBuffer[read] = (byte)nextByte;
                    buffer = newBuffer;
                    read++;
                }
            }
            /* Buffer is now too big. Shrink it. */
            byte[] ret = new byte[read];
            Array.Copy(buffer, ret, read);
            return ret;
        }
        #endregion
    }
}
