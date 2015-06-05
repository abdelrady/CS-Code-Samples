using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ftp_authnication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo thisFile = new FileInfo("f:\\aa.txt");
            Type ITC;
            object[] parameter = new object[2];
            object ITCObject;
            ITC = Type.GetTypeFromProgID("InetCtls.Inet");
            ITCObject = Activator.CreateInstance(ITC);
            parameter[0] = (string)"ftp://fci_2007:amr_fci2010@127.0.0.1";
            parameter[1] = (string)"PUT " + thisFile.FullName + " /" +
            thisFile.Name;
            ITC.InvokeMember("execute", BindingFlags.InvokeMethod,null, ITCObject, parameter);
        }
    }
}