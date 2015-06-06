using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace RawInput
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int PeekMessage(ref Message lpMsg, IntPtr hwnd, int wMsgFilterMin, int wMsgFilterMax, int wRemoveMsg);
        public const int PM_REMOVE = 0x1;

        private const int WM_INPUT = 0x00FF;
        InputDevice id;
        int NumberOfKeyboards;

        public Form1()
        {
            InitializeComponent();


            //KeyboardHook kh = new KeyboardHook();
            //kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(kh_KeyIntercepted);


            // Create a new InputDevice object, get the number of
            // keyboards, and register the method which will handle the 
            // InputDevice KeyPressed event
            id = new InputDevice( Handle );
            NumberOfKeyboards = id.EnumerateDevices();
            //MessageBox.Show(NumberOfKeyboards.ToString());
            id.KeyPressed += new InputDevice.DeviceEventHandler( m_KeyPressed );
        }

        void kh_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            
            //throw new Exception("The method or operation is not implemented.");
        }
        
        // The WndProc is overridden to allow InputDevice to intercept
        // messages to the window and thus catch WM_INPUT messages
        IntPtr ptr_wndproc;
        protected override void WndProc( ref Message message )
        {

            if (id != null)
            {
                id.ProcessMessage(message);
                
                //SendKeys.Send("{BS}");
            }

            switch (message.Msg)
            {

                case WM_INPUT:
                    PeekMessage(ref message, Handle, 0, 0, PM_REMOVE);
                    break;
                case 0x100:
                case 0x101:
                case 0x102:
                case 0x103:
                case 0x104:
                case 0x105:
                case 0x106:
                case 0x107:
                case 0x108:
                case 0x109:
                    {
                        //MessageBox.Show(message.Msg.ToString());

                        //MessageBox.Show(message.LParam.ToString()+" "+message.WParam.ToString());
//                        SendKeys.Send("{BS}");
                    //    ptr_wndproc = (IntPtr)1;//Marshal.AllocHGlobal(200);//sizeof(RawInput.InputDevice.RAWINPUT));
                        //Marshal.StructureToPtr(new RawInput.InputDevice.RAWINPUT(), ptr_wndproc, true);
                    //    message.LParam = (IntPtr)1;
                    //    message.Result = ptr_wndproc;
                    //    message.HWnd = (IntPtr)65500;
                        //MessageBox.Show("WM_INPUT");
                        //MessageBox.Show(message.LParam.ToString());
                        //MessageBox.Show(message.HWnd.ToString()+" "+message.LParam.ToString() + " " + message.WParam.ToString());
                        //Thread.Sleep(10000);
                        
                    }
                    break;

                default:

                    
                    break;
            }

            base.WndProc(ref message);
         
        }
        string barcode1,barcode2;
        private void m_KeyPressed( object sender, InputDevice.KeyControlEventArgs e )
        {
            IntPtr ptr=new IntPtr(65631);
            //if (e.Keyboard.deviceHandle != ptr)
            {


                //Replace() is just a cosmetic fix to stop ampersands turning into underlines
                lbHandle.Text = e.Keyboard.deviceHandle.ToString();
                lbType.Text = e.Keyboard.deviceType;
                lbName.Text = e.Keyboard.deviceName.Replace("&", "&&");
                lbDescription.Text = e.Keyboard.Name;
                lbKey.Text = e.Keyboard.key.ToString();
                if (e.Keyboard.key == 13)
                {
                    lblbarc.Text = barcode1;
                    barcode1 = "";
                    return;
                }
                //if (e.Keyboard.key.ToString() == Keys.Enter.ToString())
                {
                  //  MessageBox.Show("");
                    if(e.Keyboard.key!=17 &&e.Keyboard.key!=13 && e.Keyboard.key!=74)
                    barcode1 += (e.Keyboard.key-48).ToString();
                   // barcode2 += e.Keyboard.vKey.ToString();
                   
                }
                
                lbNumKeyboards.Text = NumberOfKeyboards.ToString();
                lbVKey.Text = e.Keyboard.vKey;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        public System.IntPtr Handle2
        {
            get { return Handle; }
        }

        internal static void PeekMessage2(ref Message message)
        {
            Form1 ff = new Form1();
            PeekMessage(ref message,ff.Handle, 0, 0, PM_REMOVE);
            //throw new Exception("The method or operation is not implemented.");
        }
    }
}