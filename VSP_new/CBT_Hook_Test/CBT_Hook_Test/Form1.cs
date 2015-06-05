using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
namespace CBT_Hook_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public LocalCbtHook cbtHook;
        private void Form1_Load(object sender, EventArgs e)
        {
            /*Microsoft.Win32.LocalCbtHook cbt = new LocalCbtHook();//new LocalWindowsHook.HookProc(cbtHookProcedurte));
            cbt.Install();
            cbt.WindowActivated += new LocalCbtHook.CbtEventHandler(cbt_WindowActivated);
            cbt.WindowCreated += new LocalCbtHook.CbtEventHandler(cbt_WindowCreated);
            cbt.WindowDestroyed += new LocalCbtHook.CbtEventHandler(cbt_WindowDestroyed);
            */
            LocalCbtHook cbtHook = new LocalCbtHook();
            cbtHook.Install();
            cbtHook.OnWndCreated += new LocalCbtHook.WndCreated(cbtHook_OnWndCreated);
            cbtHook.OnWndActivated += new LocalCbtHook.WndActivated(cbtHook_OnWndActivated);
            Sunisoft.IrisSkin.SkinEngine sk = new Sunisoft.IrisSkin.SkinEngine();//this, "skins\\Vista2_color7.ssk");
            sk.SkinFile = "skins\\MacOS.ssk";
        }

        int cbtHook_OnWndActivated(IntPtr wParam, IntPtr lParam)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Capacity = 40;
            GetClassName(wParam, sb1, 40);
            string m_class = sb1.ToString();
            if (m_class == "#32770")//message dialog
            {
                SetDlgItemText(wParam, IDOK, new StringBuilder("„«‘Ì Ì« ⁄„"));
                SetDlgItemText(wParam, IDCANCEL, new StringBuilder("·« «·€Ì „⁄·‘"));
                SetDlgItemText(wParam, IDABORT, new StringBuilder("‰›÷ Ì«»«"));
                SetDlgItemText(wParam, IDRETRY, new StringBuilder("„⁄·‘ Ã—»  «‰Ì"));
                SetDlgItemText(wParam, IDIGNORE, new StringBuilder("ÿ‰‘ «·Œÿ√ œÂ"));
                SetDlgItemText(wParam, IDYES, new StringBuilder("«ÊﬂÌ… „Ê«›ﬁ"));
                SetDlgItemText(wParam, IDNO, new StringBuilder("·« ·« „‘ „Ê«›ﬁ"));
            }
            return 0;
        }

        int cbtHook_OnWndCreated(IntPtr wParam, IntPtr lParam)
        {
            // Cache the window's title bar
            StringBuilder sb2 = new StringBuilder();
            sb2.Capacity = 256;
            GetWindowText(wParam, sb2, 256);
            this.Text = "["+sb2.ToString()+"]";

            StringBuilder sb1 = new StringBuilder();
            sb1.Capacity = 40;
            GetClassName(wParam, sb1, 40);
            string m_class = sb1.ToString();
            if (m_class == "#32770")//message dialog
            {
                //return 1;          //uncomment it to Prvent Message Boxs From To Be Shown Entirely.
                //cbtHook.UnInstall();
            }
            return 0;
        }

        void cbt_WindowDestroyed(object sender, CbtEventArgs e)
        {
            this.listBox1.Items.Add("Window Destroyed: " + e.ClassName + ", Title: " + e.Title + " ,IsDialog: " + e.IsDialogWindow.ToString());
            this.Invalidate();
        }

        void cbt_WindowCreated(object sender, CbtEventArgs e)
        {
            this.listBox1.Items.Add("Window Creadted: " + e.ClassName + ", Title: " + e.Title + " ,IsDialog: " + e.IsDialogWindow.ToString());
            this.Invalidate();
        }

        void cbt_WindowActivated(object sender, CbtEventArgs e)
        {
           /* if (e.IsDialogWindow)
            {
                Bitmap bmp = new Bitmap(@"E:\Icons\103057.ICO");
                IntPtr hIcon = bmp.GetHicon();
                IntPtr hwndIcon = GetDlgItem(e.Handle, 0x0014);
                SendMessage(hwndIcon, STM_SETICON, hIcon, IntPtr.Zero);
            }*/
            this.listBox1.Items.Add("Window Activated: " + e.ClassName + ", Title: " + e.Title + " ,IsDialog: " + e.IsDialogWindow.ToString());
            this.Invalidate();
        }
        private int cbtHookProcedurte(int code, IntPtr wp, IntPtr lp)
        {
            //if(code<0)Microsoft.Win32.
            if (code > 0)
            {
                this.Text += ",code>0 ,";
                if (code == 3)  //hcbt_createWnd
                {
                    this.Text += ",createwnd msg ,";
                    StringBuilder sb1 = new StringBuilder();
                    sb1.Capacity = 40;
                    GetClassName(wp, sb1, 40);
                    string m_class = sb1.ToString();
                    if (m_class == "#32770")//message dialog
                    {
                        this.Text+="Found...";
                        return 1;
                    }
                }
            }
            return 0;
        }

       const int IDOK = 1;
       const int IDCANCEL = 2;
       const int IDABORT = 3;
       const int IDRETRY = 4;
       const int IDIGNORE = 5;
       const int IDYES = 6;
       const int IDNO = 7;
       
        [DllImport("shell32.dll")]
        protected static extern IntPtr ExtractIcon(
            IntPtr hInst,            // instance handle
            string lpszExeFileName,  // file name
            int nIconIndex           // icon index
        );
        private const int STM_SETICON = 0x00000170;

        [DllImport("user32.dll")]
        protected static extern IntPtr SendMessage(
            IntPtr hwnd,            // instance handle
            int Msg,
            IntPtr wp,
            IntPtr lp
        );
        [DllImport("user32.dll")]
        protected static extern IntPtr GetDlgItem(
            IntPtr hwnd,            // instance handle
            int nIDDlgItem
        );
        [DllImport("user32.dll")]
        protected static extern int GetWindowText(IntPtr hwnd,
            StringBuilder lpString, int nMaxCount);
        
        [DllImport("user32.dll")]
        protected static extern int GetClassName(IntPtr hwnd,
            StringBuilder lpClassName, int nMaxCount);
        
        [DllImport("user32.dll")]
        protected static extern int SetDlgItemText(IntPtr hwnd, int nIDDlgItem,StringBuilder str);


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Null", "Null", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            new Form().ShowDialog();
        }


    }
}