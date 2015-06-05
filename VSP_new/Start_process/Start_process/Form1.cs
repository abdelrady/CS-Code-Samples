using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.CSharp;

namespace Start_process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("c");
            
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.ErrorDialog = false; ;
            StreamWriter st = new StreamWriter("c:\\usb.txt", true);
            
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception mm)
            {
                st.WriteLine(DateTime.Now.ToLongDateString()+"\t"+DateTime.Now.ToLongTimeString()+"\t"+mm.Message);
                st.Close();
                Application.Exit();
                
                //Application.Restart();
            }
            /*catch (FileNotFoundException)
            {
                Application.Restart();
            }*/

        }
    }
}