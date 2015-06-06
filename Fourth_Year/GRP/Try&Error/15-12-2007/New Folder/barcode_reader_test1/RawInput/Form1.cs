using System.Windows.Forms;
using System;
using System.Threading;

namespace RawInput
{
    public partial class Form1 : Form
    {
        InputDevice id;
        int NumberOfKeyboards;

        public Form1()
        {
            InitializeComponent();

            // Create a new InputDevice object, get the number of
            // keyboards, and register the method which will handle the 
            // InputDevice KeyPressed event
            id = new InputDevice( Handle );
            NumberOfKeyboards = id.EnumerateDevices();
            //MessageBox.Show(NumberOfKeyboards.ToString());
            id.KeyPressed += new InputDevice.DeviceEventHandler( m_KeyPressed );
        }
        
        // The WndProc is overridden to allow InputDevice to intercept
        // messages to the window and thus catch WM_INPUT messages
        protected override void WndProc( ref Message message )
        {
           if( id != null )
           {
               id.ProcessMessage( message );
           }
           base.WndProc( ref message );
        }
        string barcode1,barcode2;
        private void m_KeyPressed( object sender, InputDevice.KeyControlEventArgs e )
        {
            IntPtr ptr=new IntPtr(65631);
            if (e.Keyboard.deviceHandle != ptr)
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
            new Thread(new ThreadStart(UpdateListDev)).Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

      
    }
}