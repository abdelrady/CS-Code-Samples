using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class login : Form
    {

        public enum Splash
        {
            DontShow,
            Show
        }

        public Button CancelBtn;
        private IContainer components;
        public OleDbConnection dBConnection;
        public string dblocationMain;
        internal Button EnterBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblAuName;
        private MyUtility Lutility;
        private login.Splash Mode;
        private TextBox PassWordTXT;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox UserCombo;

        public login(login.Splash GivenMode)
        {
            Lutility = new MyUtility();
            dblocationMain = "";
            Mode = login.Splash.Show;
            components = null;
            Mode = GivenMode;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void login_Load(object sender, EventArgs e)
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

