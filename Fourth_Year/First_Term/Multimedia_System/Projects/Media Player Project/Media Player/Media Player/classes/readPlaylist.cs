using System;
using System.Collections;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
namespace Media_Player
{
    class readPlaylist
    {
        //private string m_xmlFile = "C:\\Documents and Settings\\loneferret\\My Documents\\My Music\\My Playlists\\New Playlist.wpl";
        private ArrayList name = new ArrayList();
        private string m_xmlFile;
        //--------------------------createplayList-------------
        public static StreamWriter sw;
        /// <summary>
        /// The Windows Media Playlist Path xxx.wpl file
        /// </summary>
        public string playListPath
        {
            get
            {
                return m_xmlFile;
            }
            set
            {
                m_xmlFile = value;
                Readplaylist();
            }
        }

        /// <summary>
        /// Return an Arraylist of file found in Windows Media Playlist file
        /// </summary>
        public ArrayList PlayList
        {
            get
            {
                return name;
            }
        }
        
        /// <summary>
        /// Fills up an Arraylist with titles found in the Windows Media Playlist file.
        /// Using XmlTextReader
        /// </summary>
        private void Readplaylist()
        {
            StreamReader s = new StreamReader(m_xmlFile);
            for (int i = 0; i <9; i++)
                s.ReadLine();
            string readtext=s.ReadLine();
            while (readtext != "\t\t</seq>")
            {
                int ind = 15;
                readtext = readtext.Substring(ind);
                readtext = readtext.Remove(readtext.Length - 3);
                name.Add(readtext);
                readtext = s.ReadLine();
            }

        }
        //----------------------------------------------------------------
        #region CreatePlayList
        public void CreatePlayList(string sFileName,string[]files)
        {
            // Open a file to write
            FileStream fs = File.Create(sFileName);
            FileInfo f = new FileInfo(sFileName);
            sw = new StreamWriter(fs);
            string txtAuthor = "";
            string txtTitle = "WPlayList";
           try
            {
                sw.WriteLine("<?wpl version=\"1.0\"?>");    // File Header
                sw.WriteLine("<smil>");                     // Start of File Tag
                sw.WriteLine("\t<head>");                     // Playlist File Header Information Start Tag
                sw.WriteLine("\t\t<meta name=\"Generator\"content=\"Microsoft Windows Media Player -- 10.0.0.4036\"/>");
                sw.WriteLine("\t\t<author>" + txtAuthor + "</author>");
                sw.WriteLine("\t\t<title>" + txtTitle + "</title>");
                sw.WriteLine("\t</head>");                    // Playlist File Header Information End Tag
                sw.WriteLine("\t<body>");                     // Start of body Tag
                sw.WriteLine("\t\t<seq>");                      // Start of filelist Tag
                // Add files
                string fileLine="";
                foreach (string file in files)
                {
                    fileLine = "\t\t\t<media src=\"" + file + "\"/>";
                    sw.WriteLine(fileLine);
                }
                sw.WriteLine("\t\t</seq>");                      // End of filelist Tag
                sw.WriteLine("\t</body>");                    // End of body Tag
                sw.WriteLine("</smil>");                    // End of File Tag
                sFileName = sFileName + " Successfully created.";
                MessageBox.Show(sFileName, "Create Playlis");
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Playlist: Error");

                sFileName = sFileName + " Unsuccessful.";

                MessageBox.Show(sFileName, "Create Playlis");
            }
            finally
            {
                sw.Close();
                fs.Close();
                f.Attributes = FileAttributes.ReadOnly;
               
            }
        }
        #endregion
    }
}
