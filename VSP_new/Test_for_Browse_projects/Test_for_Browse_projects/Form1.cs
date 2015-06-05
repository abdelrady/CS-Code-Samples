using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_for_Browse_projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Files;
            String[] dirs;
            string Element2;
            //if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar) Dst += Path.DirectorySeparatorChar;
            //if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            StreamWriter sw = new StreamWriter("asd.html", true);
            Files = Directory.GetFiles(@"E:\vs.net_projects\test\", "*.rar", SearchOption.TopDirectoryOnly);
            foreach (string Element in Files)
            {
                Element2 = Element.Substring(Element.LastIndexOf('\\') + 1);
                sw.WriteLine("<a href=\"http://localhost:1039/vs.net_projects/test/" + Element2 + "\">" + Element2 + "</a>");
            }
            sw.Close();
        }
    }
}