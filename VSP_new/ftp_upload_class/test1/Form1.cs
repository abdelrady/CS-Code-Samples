using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CSharp_FTP.FTP ftp = new CSharp_FTP.FTP();
            ftp.setRemoteUser("fcis_2007");
            ftp.setRemotePort(21);
            ftp.setRemotePass("amr_fci");
            ftp.setRemoteHost("localhost");
            ftp.login();
            ftp.upload(@"F:\FCIS\codes\C#\TUX_32.png", true);
            ftp.close();
        }
    }
}