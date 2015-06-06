/*


namespace MovieShow
{
    
    public class Media 
    {
        
        
        #region abc
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem22;
        private System.Windows.Forms.MenuItem menuItem26;
        private System.Windows.Forms.MenuItem menuFileOpenClip;
        private System.Windows.Forms.MenuItem menuFileClose;
        private System.Windows.Forms.MenuItem menuFileExit;
        private System.Windows.Forms.MenuItem menuFilePause;
        private System.Windows.Forms.MenuItem menuFileStop;
        private System.Windows.Forms.MenuItem menuFileMute;
        private System.Windows.Forms.MenuItem menuSingleStep;
        private System.Windows.Forms.MenuItem menuFileSizeHalf;
        private System.Windows.Forms.MenuItem menuFileSizeThreeQuarter;
        private System.Windows.Forms.MenuItem menuFileSizeNormal;
        private System.Windows.Forms.MenuItem menuFileSizeDouble;
        private System.Windows.Forms.MenuItem menuFileFullScreen;
        private System.Windows.Forms.MenuItem menuRateIncrease;
        private System.Windows.Forms.MenuItem menuRateDecrease;
        private System.Windows.Forms.MenuItem menuRateNormal;
        private System.Windows.Forms.MenuItem menuRateHalf;
        private System.Windows.Forms.MenuItem menuRateDouble;
        private System.Windows.Forms.MenuItem menuHelpAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        // openFileDialog1
        // 
 //           this.openFileDialog1.Filter = @"Video Files (*.avi; *.qt; *.mov; *.mpg; *.mpeg; *.m1v)|*.avi; *.qt; *.mov; *.mpg; *.mpeg; *.m1v|Audio files (*.wav; *.mpa; *.mp2; *.mp3; *.au; *.aif; *.aiff; *.snd)|*.wav; *.mpa; *.mp2; *.mp3; *.au; *.aif; *.aiff; *.snd|MIDI Files (*.mid, *.midi, *.rmi)|*.mid; *.midi; *.rmi|Image Files (*.jpg, *.bmp, *.gif, *.tga)|*.jpg; *.bmp; *.gif; *.tga|All Files (*.*)|*.*";
        #endregion
        
        //
     // Graph creation and destruction methods
     //

        

        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Enable XP style controls
            Application.EnableVisualStyles();
            Application.DoEvents();

            using (MainForm form = new MainForm())
            {
                if (args.Length > 0)
                    form.filename = args[0];

                form.Show();
                form.OpenClip();

                Application.Run(form);
            }
        }

    }
}
*/