using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using USBDriveSerialNumber;



namespace USBTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            USBSerialNumber obj = new USBSerialNumber();
            String strCode = obj.getSerialNumberFromDriveLetter();
            label1.Text = strCode;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            USBSerialNumber obj = new USBSerialNumber();
            String strCode = obj.getSerialNumberFromDriveLetter();
            label1.Text = strCode;
            string driveLetter = obj.driveLetter;

            DriveInfo di = new DriveInfo(driveLetter);
            DirectoryInfo dirInfo = di.RootDirectory;
            FileInfo[] fi = dirInfo.GetFiles();
            foreach (FileInfo f in fi)
            {
                listBox1.Items.Add(f.FullName);
            }
        }
    }
}