using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;

namespace Send_WM_Close_Message1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr Handle, long MSG, IntPtr WP, IntPtr LP);
        const int WM_MOUSEMOVE                =    0x0200;
        bool asd=true; ArrayList ar = new ArrayList();
        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                /*case WM_MOUSEMOVE:
                    {
                        //this.Text = "Lparam=" + message.LParam.ToString() + " Wparam=" + message.WParam.ToString();
                        if (asd)
                        {
                            
                            //Message msg = message;
                            //ar.Add(msg);
                        }
                    }
                    break;*/
                // If message is of interest, invoke the method on the form that
                // functions as a callback to perform actions in response to the message.
                case 0x403:
                    {
                        this.Text = message.LParam.ToInt32().ToString() + " , " + message.WParam.ToInt32().ToString();
                    }
                    break;
            }
            base.WndProc(ref message);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int xz = 783478;
            
            //IntPtr ipr = new IntPtr(xz);
            //MessageBox.Show((ipr).ToString());
            //Message msg = Message.Create(Handle,0x10,IntPtr.Zero,IntPtr.Zero);//0x0200 For WM_MouseMove
            unsafe
            {
                //MessageBox.Show((string)(&ipr));// = 238971;
                //Message msg = Message.Create(Handle, 0x0200, IntPtr.Zero, ipr);

                //DefWndProc(ref msg);
            }

            asd = false;
            int i = 0;
            bool retval=false;
            foreach (object obj in ar)
            {   
                Message msg = (Message)obj;
                //Message msg = Message.Create(Handle, 0x0200, ((Message)obj).WParam, ((Message)obj).LParam);
                
                //DefWndProc(ref msg);

                retval=PostMessage(msg.HWnd, msg.Msg, msg.WParam, msg.LParam);
                //this.Text = "Lparam2=" + msg.LParam.ToString() + " Wparam=" + msg.WParam.ToString() 
                  //  + " i=" + (i++).ToString() + " " + retval.ToString();
                Thread.Sleep(100);
            }
        }

        // Assign integers to messages.
        // Note that custom Window messages start at WM_USER = 0x400.
        public const int WM_CUSTOMMSG = 0x0400;
        
        private void button2_Click(object sender, EventArgs e)
        {
            unsafe
            {
                //MessageBox.Show((string)(&ipr));// = 238971;
                //IntPtr ss= Marshal.StringToBSTR("welcome");
                mousePos mo=new mousePos();
                mo.x=12;
                mo.y=139;

                int xx = 9034809;

                IntPtr ss = Marshal.AllocHGlobal(sizeof(mousePos));
                Marshal.StructureToPtr(mo, ss, false);

                Message msg = Message.Create(Handle, 0x0403, ss, IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }
    }
    public struct mousePos
    {
        public int x;
        public int y;
    }
}