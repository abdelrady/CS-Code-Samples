using System.Windows.Forms;
using System;
using System.Threading;
using System.Diagnostics;

namespace RawInput
{
    public partial class Form1 : Form
    {
        InputDevice id;
        int NumberOfKeyboards;
        private DriveDetector driveDetector = null;
        public static KeyboardHook kh;


        public Form1()
        {
            InitializeComponent();
            //new Thread(new ThreadStart(HookThread)).Start();
           // kh = new KeyboardHook();
            //kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(OnKeyIntecept);


            /*
             *Detect insertion & removal Of any usb Device 
             */
            driveDetector = new DriveDetector(this);
   //         driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrived);
   //         driveDetector.DeviceRemoved += new DriveDetectorEventHandler(OnDriveRemoved);
   //         driveDetector.QueryRemove += new DriveDetectorEventHandler(OnQueryRemove);
            driveDetector.DeviceChanged += new DriveDetectorEventHandler(OnDevChange);
           
            // Create a new InputDevice object, get the number of
            // keyboards, and register the method which will handle the 
            // InputDevice KeyPressed event
            id = new InputDevice( Handle );
            NumberOfKeyboards = id.EnumerateDevices();
            //MessageBox.Show(NumberOfKeyboards.ToString());
            id.KeyPressed += new InputDevice.DeviceEventHandler( m_KeyPressed );
        }

        public void HookThread()
        {

            kh = new KeyboardHook();
            kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(OnKeyIntecept);
            while (true) ;
        }
        void OnKeyIntecept(KeyboardHook.KeyboardHookEventArgs e)
        {

            //m_KeyPressed(this, e2);
        }
        
        // Called by DriveDetector when removable usb Dev. Changed
        private void OnDevChange(object sender, DriveDetectorEventArgs e)
        {
        
            id.EnumerateDevices();
            this.label2.Text = "Barcode Status Changed.";
        }

        private const int WM_INPUT = 0x00FF;


        // The WndProc is overridden to allow InputDevice to intercept
        // messages to the window and thus catch WM_INPUT messages
        protected override void WndProc( ref Message message )
        {
           
           if (driveDetector != null)
           {
               driveDetector.WndProc(ref message);
           }
           if (id != null)
           {
               id.ProcessMessage(message);
               switch (message.Msg)
               {

                   case WM_INPUT:
                      GenMethods.PeekMessage(ref message, Handle, 0, 0,GenMethods.PM_REMOVE);
                       break;
               }
           }
           base.WndProc( ref message );

        }
        string barcode1,barcode2;
        private void m_KeyPressed( object sender, InputDevice.KeyControlEventArgs e )
        {

            IntPtr ptr=new IntPtr(65633);
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
        
        public void UpdateListDev()
        {
            /*
             * Update device list and device list 
             * so when the bad user blugs the card reader from one usb port 
             * and inserted it in another port program automatically
             * update dev list
             * 
             * very creative part and trickely
             * Created by Eagles **Abd El rady --Ali**
             * 
             */

            while (true)
            {
                id.EnumerateDevices();
                //update device list every 300 ms
                Thread.Sleep(300); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
 //           new Thread(new ThreadStart(UpdateListDev)).Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           // MessageBox.Show("KeyDown");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}