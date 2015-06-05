using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Mouse_Events1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 cButtons, Int32 dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern Int32 SetCursorPos(Int32 x, Int32 y);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 ret;
           /* for (int i = 0; i < 800; i++)
            {
                Thread.Sleep(20);
                ret = SetCursorPos(i, i);
                //if (ret != 1) MessageBox.Show(ret.ToString());
            }
           */ 
            ret = SetCursorPos(10 ,790);
            mouse_event (0x2, 10, 790, 0, 0);
            mouse_event (0x4, 10, 790, 0, 0);
        }
        MouseEventHandler msh;
        
        private void button2_Click(object sender, EventArgs e)
        {
            msh = new MouseEventHandler(Form1_MouseClick);
            
            this.MouseClick += msh;
        }

        void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text=e.X.ToString();
            //throw new Exception("The method or operation is not implemented.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.MouseClick -= msh;
        }
    }
}
