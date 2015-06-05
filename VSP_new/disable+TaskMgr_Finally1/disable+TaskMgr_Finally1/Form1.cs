using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace disable_TaskMgr_Finally1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static FileStream TaskMan;                          // Hold the file stream object to control task manager.
        private void button1_Click(object sender, EventArgs e)
        {
            for (int I = 0; I < Process.GetProcesses().Length; I++)
                        {
                            if (Process.GetProcesses()[I].ProcessName.ToLower() == "Taskmgr".ToLower()) Process.GetProcesses()[I].Kill();
                            if (Process.GetProcesses()[I].MainWindowTitle.ToLower() == "Windowis Task Manager".ToLower()) Process.GetProcesses()[I].Kill();
                        }
                        TaskMan = File.Open(Environment.SystemDirectory + @"\Taskmgr.exe", FileMode.Open, FileAccess.Read, FileShare.None);
                    //} else if (TaskMan != null) TaskMan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TaskMan != null) TaskMan.Close();
        }
    }
}