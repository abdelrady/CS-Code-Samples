using System;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace MsgWindow
{
    public class MessageWindowForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;

        // Create an instance of MsgWindow, a derived MessageWindow class.
        MsgWindow MsgWin;

        public MessageWindowForm()
        {

            InitializeComponent();

            // Create the message window using this form for its constructor.
            this.MsgWin = new MsgWindow(this);

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.Menu = this.mainMenu1;
            this.Text = "Message Window Test";

        }
        #endregion

        static void Main()
        {
            Application.Run(new MessageWindowForm());
        }

        // Process taps to generate messages
        // with the WParam and LParam parameters
        // using the X and Y mouse coordinates.
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Message msg = Message.Create(MsgWin.Hwnd,
             MsgWindow.WM_CUSTOMMSG,
             (IntPtr)e.X,
             (IntPtr)e.Y);
            
            MessageWindow.SendMessage(ref msg);
            base.OnMouseMove(e);
        }

        // This callback method responds to the Windows-based message.
        public void RespondToMessage(int x, int y)
        {
            this.Text = "X = " + x.ToString() + ", Y= " + y.ToString();
        }
    }

    // Derive MessageWindow to respond to
    // Windows messages and to notify the
    // form when they are received.
    public class MsgWindow : MessageWindow
    {
        // Assign integers to messages.
        // Note that custom Window messages start at WM_USER = 0x400.
        public const int WM_CUSTOMMSG = 0x0400;


        // Create an instance of the form.
        private MessageWindowForm msgform;

        // Save a reference to the form so it can
        // be notified when messages are received.
        public MsgWindow(MessageWindowForm msgform)
        {
            this.msgform = msgform;
        }

        // Override the default WndProc behavior to examine messages.
        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {
                // If message is of interest, invoke the method on the form that
                // functions as a callback to perform actions in response to the message.
                case WM_CUSTOMMSG:
                    this.msgform.RespondToMessage((int)msg.WParam, (int)msg.LParam);
                    break;
            }
            // Call the base WndProc method
            // to process any messages not handled.
            base.WndProc(ref msg);
        }
    }
}