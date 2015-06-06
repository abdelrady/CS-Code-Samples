using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RawInput
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            KeyboardHook kh = new KeyboardHook();
            kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(kh_KeyIntercepted);
        }

        void kh_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
        }
 
    }
}