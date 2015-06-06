using System.Windows.Forms;
using System;

namespace RawInput
{
    public partial class Form1 : Form
    {
        InputDevice id;
        int NumberOfKeyboards;
        private const int WM_INPUT = 0x00FF;
        public static KeyboardHook kh;
        //public IntPtr hwnd = Handle;
        /*
        public static IntPtr GetHandle()
        {
            
            return hwnd;
        }*/
        public Form1()
        {
            InitializeComponent();
            
            kh = new KeyboardHook();
            kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(OnKeyIntecept);

            // Create a new InputDevice object, get the number of
            // keyboards, and register the method which will handle the 
            // InputDevice KeyPressed event
            id = new InputDevice( Handle );
            NumberOfKeyboards = id.EnumerateDevices();
            id.KeyPressed += new InputDevice.DeviceEventHandler( m_KeyPressed );
        }

        void OnKeyIntecept(KeyboardHook.KeyboardHookEventArgs e)
        {
            
            //m_KeyPressed(this, e2);
        }
        
        // The WndProc is overridden to allow InputDevice to intercept
        // messages to the window and thus catch WM_INPUT messages
        protected override void WndProc( ref Message message )
        {
            
           if( id != null )
           {
               id.ProcessMessage(message);
               /*switch (message.Msg)
               {
                   case WM_INPUT:
                       {
                           Message msg = new Message();
                           msg.HWnd = Handle;
                           msg.LParam = (IntPtr.Zero);
                           base.WndProc(ref  msg);
                       }
                       break;
               }
               */
           }
           base.WndProc(ref  message);
        }

        private void m_KeyPressed( object sender, InputDevice.KeyControlEventArgs e )
        {
            //Replace() is just a cosmetic fix to stop ampersands turning into underlines
            lbHandle.Text = e.Keyboard.deviceHandle.ToString();
            lbType.Text = e.Keyboard.deviceType;
            lbName.Text = e.Keyboard.deviceName.Replace("&", "&&");
            lbDescription.Text = e.Keyboard.Name;         
            lbKey.Text = e.Keyboard.key.ToString();
            lbNumKeyboards.Text = NumberOfKeyboards.ToString();
            lbVKey.Text = e.Keyboard.vKey;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}