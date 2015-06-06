using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDoor.Properties;
using System.IO;
using System.Media;
using System.Threading;

namespace ChatClient.Forms
{
    public partial class AuthorizationFrm : Form
    {
        public int Times = 10;
        SoundPlayer Ssound;
        public AuthorizationFrm(string ErrorStr)
        {
            InitializeComponent();
            LblAuthorized.Text = ErrorStr;

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            LblAuthorized.Location = new Point(this.Width / 2 - LblAuthorized.Width / 2, this.Height / 2 - LblAuthorized.Height / 2);

            Ssound = new SoundPlayer();
            byte[] buffer = new byte[Resources.cached_denied.Length];
            Resources.cached_denied.Read(buffer, 0, (int)Resources.cached_denied.Length);
            System.IO.MemoryStream memStr = new MemoryStream(buffer);
            Ssound.Stream = memStr;          
        }
        private void PlaySoundLogError()
        {            
            Ssound.Play();         
            System.Threading.Thread.Sleep(Timeout.Infinite);   
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(PlaySoundLogError)).Start();
                 
            Times -= 1;
            if (Times == 0)
            {
                timer.Stop();
                timerFrm.Stop();
                {
                    System.Threading.Thread.Sleep(300);
                    Close();
                }
            }
        }

        private void ShowHide()
        {
            LblAuthorized.Visible = !LblAuthorized.Visible;           
        }

        private void timerFrm_Tick(object sender, EventArgs e)
        {
            ShowHide();
        }
    }
}