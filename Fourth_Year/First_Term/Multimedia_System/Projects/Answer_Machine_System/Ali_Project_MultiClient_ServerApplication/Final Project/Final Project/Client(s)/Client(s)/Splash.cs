using System;
using System.Collections.Generic;
using System.ComponentModel;


using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Client_s_
{
    public partial class Splash : Form
    {
        int X ;
         public Splash(){}
        public Splash(int interval,bool showprogr)
        {           
            InitializeComponent();
            X = interval;
            timer.Interval = interval;
            progressBar1.Visible = showprogr ? true : false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            --X;
            if (X == 0)
            {
                timer.Stop();
                CloseForm();
            }
            else { progressBar1.Value = 100 - X; }
        }
        private delegate void CloseFormDelegate();
        private void CloseForm()
        {
            if (this.InvokeRequired)
            {
                Invoke(new CloseFormDelegate(CloseForm));
            }
            else {
                Dispose();
                Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }    
    }
}