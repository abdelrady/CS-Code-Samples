using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BabyKeyboardBash
{
    public partial class Form1 : Form
    {
        //Store an instance of DrawShapes
        DrawShapes ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create an instance of DrawShapes, passing the form
            //to draw on and the settings from the config file
            string setting = Program.appSettings["DisplayConfig"];

            ds = new DrawShapes(this, setting);

            //Set up the event handler for the KeyboardHook's
            //KeyIntercepted event
            Program.kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(kh_KeyIntercepted);
        }

        void kh_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            //Check if this key event is being passed to
            //other applications and disable TopMost in 
            //case they need to come to the front
            if (e.PassThrough)
            {
                this.TopMost = false;
            }
            
            ds.Draw(e.KeyName);
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            //Clear the form
            ds.Initialise();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Restore the screen from DrawShape's backup bitmap if all 
            //or part of the screen needs repainting
            using (Graphics graphics = e.Graphics)
            {
                graphics.DrawImage(ds.BackupBitmap, 0, 0);
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //Put the form back on top if it is activated
            //(this will hide the Windows Taskbar)
            this.TopMost = true;
        }


    }
}