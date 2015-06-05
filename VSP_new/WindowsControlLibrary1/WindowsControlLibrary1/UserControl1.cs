using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RawInput;

namespace WindowsControlLibrary1
{
    public partial class UserControl1 : UserControl
    {
        InputDevice id;
        int NumberOfKeyboards;
        public UserControl1()
        {
            InitializeComponent();
            id = new InputDevice(Handle);
            NumberOfKeyboards = id.EnumerateDevices();
            //MessageBox.Show(NumberOfKeyboards.ToString());
            id.KeyPressed += new InputDevice.DeviceEventHandler(m_KeyPressed);
            //InputDevice id;
            
        
        }


        // The WndProc is overridden to allow InputDevice to intercept
        // messages to the window and thus catch WM_INPUT messages
        protected override void WndProc(ref Message message)
        {
            if (id != null)
            {
                id.ProcessMessage(message);
            }
            base.WndProc(ref message);

        }
        string barcode1, barcode2;
        private void m_KeyPressed(object sender, InputDevice.KeyControlEventArgs e)
        {

            IntPtr ptr = new IntPtr(65633);
            //if (e.Keyboard.deviceHandle != ptr)
            {
                if (e.Keyboard.key == 13)
                {
                    lblbarc.Text = barcode1;
                    barcode1 = "";
                    return;
                }
                if (e.Keyboard.key != 17 && e.Keyboard.key != 13 && e.Keyboard.key != 74)
                    barcode1 += (e.Keyboard.key - 48).ToString();

            }
        }
        
        
    }
}