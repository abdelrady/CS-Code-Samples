
/* ----------------------------------------------------------------------
 * 
 *  Author: Shailen Sukul BSC, MCSD.Net, Mcsd, Mcad
 *  Date: 9/April/2006
 *  Copyright Ashlen Consulting Services P/L
 * ----------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace BloodHound
{

    /// <summary>
    /// Interrogates the given url and extracts a bunch of urls that match 
    /// the defined filter.
    /// For example *.doc will retrieve all documents with a .doc extention.
    /// </summary>
    public class WebPageInterrogater
    {
        #region Fields
        private string _url = string.Empty;
        // regex for <href> tags.
        const string _findAllHrefsPattern = "(?<HTML><a[^>]*href\\s*=\\s*[\\\"\\']?(?<HRef>[^\"'>\\s]*)[\\\"\\']?[^>]*>(?<Title>[^<]+|.*?)?</a\\s*>)";
        string _filters = string.Empty;

        #endregion

        #region Properties
        /// <summary>
        /// Returns the root url
        /// </summary>
        public string TopLevelUrl
        {
            get
            {
                if (_url.Equals(string.Empty))
                {
                    throw new ArgumentException("Please specify a url.");
                }
                string topLevelUrl = _url.Substring(0, _url.LastIndexOf("/"));
                return topLevelUrl;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Crawls the given url looking for hyperlinks and extracts all hyperlinks that match the filter.
        /// For example *.doc will return hyperlinks for word documents.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="sFilters"></param>
        public WebPageInterrogater(string url, string sFilters)
        {
            _url = url;
            string[] filters = sFilters.Split(';');
            string pattern = string.Empty;
            for (int i = 0; i < filters.Length; i++ )
            {
                pattern = "\\" + filters[i].Replace("*", string.Empty) + "$" + "|";
                _filters += pattern;
            }
            _filters = _filters.Substring(0, _filters.Length-1);
        }

        /// <summary>
        /// Returns a collection of documents that are eligible to download.
        /// </summary>
        /// <returns></returns>
        public StringCollection ListFiles()
        {
            StringCollection sCol = new StringCollection();
            string webPage = GetWebPage();

            string ahref = string.Empty;
            string title = string.Empty;
            string value = string.Empty;
            string fileName = string.Empty;


            Regex regEx = new Regex(_findAllHrefsPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex regEx2 = new Regex(_filters, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = regEx.Matches(webPage);
            foreach (Match match in matches)
            {
                int iCount = match.Groups.Count;
                ahref = match.Groups[0].Value;
                value = match.Groups[2].Value;
                title = match.Groups[3].Value;

                if (regEx2.IsMatch(value))
                {
                    sCol.Add(TopLevelUrl + "/" + value);
                }
            }
            return sCol;
        }

        /// <summary>
        /// Returns a string representation of the contents of the main url
        /// </summary>
        /// <returns></returns>
        private string GetWebPage()
        {
            if (_url.Equals(string.Empty))
            {
                throw new ArgumentException("Please supply a url first.");
            }

            string webPage = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();

            StreamReader sr = new StreamReader(stream);
            webPage = sr.ReadToEnd();

            stream.Close();
            return webPage;
        }
        #endregion
    }
}
