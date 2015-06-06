using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class login : System.Windows.Forms.Form
    {

        public enum Splash
        {
            DontShow,
            Show
        }

        public System.Windows.Forms.Button CancelBtn;
        private System.ComponentModel.IContainer components;
        public System.Data.OleDb.OleDbConnection dBConnection;
        public string dblocationMain;
        internal System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuName;
        private Students__House_Control.MyUtility Lutility;
        private Students__House_Control.login.Splash Mode;
        private System.Windows.Forms.TextBox PassWordTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox UserCombo;

        public login(Students__House_Control.login.Splash GivenMode)
        {
            Lutility = new Students__House_Control.MyUtility();
            dblocationMain = "";
            Mode = Students__House_Control.login.Splash.Show;
            components = null;
            Mode = GivenMode;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void EnterBtn_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void login_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void login_Load(object sender, System.EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            bool flag = !disposing || (components == null);
            if (!flag)
                components.Dispose();
            base.Dispose(disposing);
        }

    } // class login

}

