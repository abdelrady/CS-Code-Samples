/* --------------------------------------------------------------------
 * Floppy Drive Stepper Motor Control Code
 * Written by: Ashish Derhgawen
 * E-mail: ashish.derhgawen@gmail.com
 * Web: http://ashishrd.blogspot.com
 * 
 * This code is provided without implied warranty so the author
 * is not responsible for any damages caused  by the use of the code.
 --------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace FloppyStepper
{
    public partial class MainForm : Form
    {
        private int adress = 888;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private class PortAccess
        {
            [DllImport("inpout32.dll", EntryPoint = "Out32")]
            public static extern void Output(int adress, int value);
        }

        #region Events
        private void stepperMoveButton1_Click(object sender, EventArgs e)
        {
            MoveStepper(int.Parse(stepTextBox.Text), int.Parse(delayTextBox.Text), 1, 0);
        }

        
        private void stepperMoveButton2_Click(object sender, EventArgs e)
        {
            MoveStepper(int.Parse(stepTextBox.Text), int.Parse(delayTextBox.Text), 3, 2);
        }

        
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (this.adressTextBox.Text == "378")
                adress = 888;
            else
                adress = 632;
        }


        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://ashishrd.blogspot.com");
        }
        #endregion

        private void MoveStepper(int steps, int delay, Int32 onValue, Int32 offValue)
        {
            for (int i = 0; i < steps; i++)
            {
                Application.DoEvents();
                PortAccess.Output(adress, onValue);
                Thread.Sleep(delay);
                PortAccess.Output(adress, offValue);
                Thread.Sleep(delay);
            }
        }

    }
}