#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDB_test.myControls;
using System.Runtime.InteropServices;
#endregion

namespace RDB_test {
    public partial class MainForm : Form
    {
        #region Reference Variables
        //
        //  Reference Variables
        //
        private userLoginControl newLoginCntrl;
        private String UsersName;
        private System.Diagnostics.Stopwatch myStopWatch;
        private UsersControl newEmployeeCntrl;
        private DoorsControl newDoorCntrl;
        private LogControl newlogcntrl;
        private GroupsControl newgroupcntrl;
        private SettingControl newSettingcntrl;
        private DBAdminSetting newDBSettingcntrl;
        internal bool isLoggedIn;
        private bool BoolStart=true;
        #endregion//<--End-->Reference Variables Region

        #region Constructor
        //
        //  Constructor
        //
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr Hwnd,Int32 min,Int32 max);
        //
        //setToolTip
        //
        public void setToolTip(string msg)
        {
            notifyIcon1.BalloonTipText = msg;
            notifyIcon1.ShowBalloonTip(100);
            notifyIcon1.BalloonTipTitle = "Help Info.";
        }
        //
        //  MainForm Load
        //
        private void MainForm_Load(object sender, EventArgs e)
        {
            Configuration.Valid();
            //MessageBox.Show(Configuration.ServerName + " " + Configuration.IntegratedSecurity + " " + Configuration.userName + " " + Configuration.userPassword + " " + Configuration.ConnectionTimeout);
            //Configuration.Read_Config();
            RDB_test.Properties.Settings.Default.SDASDBConnectionString = Configuration.connectionString;

            //  hide the progressBar on the status strip.
            //this.BoolStart = true;
            this.toolStripProgressBar1.Visible = false;

            //  set the default value, since we're not logged in.
            this.isLoggedIn = false;

            //  Create a new StopWatch to record how long the user as been online.
            myStopWatch = new System.Diagnostics.Stopwatch();
            myStopWatch.Start();

            //  Disable toolstrip items that are not available yet.
            this.openDocToolStripButton.Enabled = false;
            this.closeDocToolStripButton.Enabled = false;

            SetProcessWorkingSetSize(Handle, -1, -1);
        }
        //
        //  MainForm FormClosing
        //
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Ask the user if he/she wishes to quit.
            if (MessageBox.Show("Are you sure you want to Quit?", "Quitting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Login, Logout & Account
        #region ShowLogin
        //
        //  ShowLogin
        //
        private void ShowLogin(bool IsLogin)
        {
            //  Check if there are any controls loaded in the targetPanel collection.
            int i = this.targetPanel.Controls.Count;
            if (i <= 1)
            {
                //  Check to see if the control is already created.
                if (this.newLoginCntrl == null)
                {
                    //  Create a new userLoginControl.
                    this.newLoginCntrl = new userLoginControl(IsLogin);

                    //  Change the location of are newly created control.
                    this.newLoginCntrl.Left = 20;
                    this.newLoginCntrl.Top = 20;

                    //  Wire the userLoginControl's custom event handlers.
                    this.newLoginCntrl.loginSuccessful +=
                        new userLoginControl.LoginSuccessful(LoginSuccessful);
                    this.newLoginCntrl.loginUnsuccessful +=
                        new userLoginControl.LoginUnsuccessful(LoginUnsuccessful);
                    this.newLoginCntrl.loginClose +=
                        new userLoginControl.LoginClose(LoginClose);
                    this.newLoginCntrl.accountCreated +=
                        new userLoginControl.AccountCreated(AccountCreated);
                    this.newLoginCntrl.accountNotCreated +=
                        new userLoginControl.AccountNotCreated(AccountNotCreated);
                    this.newLoginCntrl.startMyTimer +=
                        new userLoginControl.StartMyTimer(StartMyTimer);

                    //  Add the control to the TargetPanel.
                    this.targetPanel.Controls.Add(this.newLoginCntrl);

                    //  Show the form.
                    this.newLoginCntrl.Show();
                }
            }
        }
        #endregion//<--End-->ShowLogin Region

        #region Logout
        //
        //  Logout
        //
        private void Logout()
        {
            //  If the user has any open documents warn them to close everything first.
            if (this.targetPanel.Controls.Count > 0)
            {
                MessageBox.Show("Please save your data and close any open documents before proceeding!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.UsersName = null;
                this.isLoggedIn = false;
                this.statusToolStripStatusLabel.Text = "You have been logged out...";
                this.closeDocToolStripButton.Enabled = false;
                this.openDocToolStripButton.Enabled = false;
                //  Reset the toolTipText to sync with the underlying function.
                this.accountToolStripButton.ToolTipText = "Login or Create a New Account";
            }
        }
        #endregion//<--End-->Logout Region

        #region Login Events
        //
        //  LoginSuccessful
        //
        private void LoginSuccessful(object sender, EventArgs e)
        {
            //  Store the Name in a Variable.
            this.UsersName = RDB_test.Properties.Settings.Default.UserName;

            //  Alert the user that they have been logged in.
            String msg = String.Format("You have been logged in as \"{0}\"", this.UsersName.ToUpper());
            this.statusToolStripStatusLabel.Text = msg;

            //  Raise the LoginClose Event
            this.LoginClose(sender, e);
            
            this.accountToolStripButton.Image = RDB_test.Properties.Resources.LogonICO;

            // Turn off progress on the progress bar.
            this.progressTimer.Stop();
            this.toolStripProgressBar1.Visible = false;

            //  Enable tool bar items.
            this.openDocToolStripButton.Enabled = true;

            //  Set the isLoggedIn flag.
            this.isLoggedIn = true;

            //  Change the ToolTipText.
            this.accountToolStripButton.ToolTipText = "Click here to log out";
            this.accountToolStripButton.Text = "Log Out";

        }
        //
        //  LoginUnsuccessful
        //
        private void LoginUnsuccessful(object sender, EventArgs e)
        {
            //  Alert the user that they were not logged in.
            String msg = String.Format("You have not been logged in! Please try again.");
            this.statusToolStripStatusLabel.Text = msg;

            // Turn off progress on the progress bar.
            this.progressTimer.Stop();
            this.toolStripProgressBar1.Visible = false;
        }
        //
        //  LoginClose
        //
        private void LoginClose(object sender, EventArgs e)
        {
            //  Remove the newLoginCntrl from the TargetPanel's Control List.
            this.targetPanel.Controls.Clear();
            //this.targetPanel.Controls.Add(this.Catlabel);
            //  Set the control to null so we can re-load it if necessary.
            this.newLoginCntrl.Dispose();
            this.newLoginCntrl = null;
            // Turn off progress on the progress bar.
            this.progressTimer.Stop();
            this.toolStripProgressBar1.Visible = false;
            //this.progressTimer = null;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
        #endregion//<--End-->Login Events Region

        #region Account
        //
        //  AccountCreated
        //
        private void AccountCreated(object sender, EventArgs e)
        {
            String msg = ("Account has been created; Please Login!");
            this.statusToolStripStatusLabel.Text = msg;

            // Turn off
            this.progressTimer.Stop();
            this.toolStripProgressBar1.Visible = false;
        }
        //
        //  AccountNotCreated
        //
        private void AccountNotCreated(object sender, EventArgs e)
        {
            String msg = ("Account was not created; Please try again!");
            this.statusToolStripStatusLabel.Text = msg;

            // Turn off
            this.progressTimer.Stop();
            this.toolStripProgressBar1.Visible = false;
        }
        #endregion//<--End-->Account Region

        #region Progress
        //
        //  StartMyTimer
        //
        private void StartMyTimer(object sender, EventArgs e)
        {
            //  Show the progressBar.
            this.toolStripProgressBar1.Visible = true;

            //  Start the progress for account operations.
            this.progressTimer.Start();
        }
        #endregion//<--End-->Progress Region
        #endregion//<--End-->Login, Logout & Account Region

        #region Stop Watch
        //
        //  HowLongRunning
        //
        private String HowLongRunning()
        {
            TimeSpan ts = myStopWatch.Elapsed;
            return String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        }
        #endregion//<--End-->Stop Watch Region
        //
        //  AccountToolStripButton Click
        //
        private void accountToolStripButton_Click(object sender, EventArgs e)
        {
            //  I wired the events in the menu pertaining to login and account to this event.
            //  Lets see who's firing the event.
            if ((sender is ToolStripMenuItem) || (sender is ToolStripButton))
            {
                if ((sender == this.loginToolStripMenuItem) || (sender == this.accountToolStripButton))
                {
                    if (this.isLoggedIn == false)
                    {
                        //  User wants to Login.
                        this.ShowLogin(true);
                    }
                    else
                    {
                        this.Logout();
                        this.accountToolStripButton.Image = RDB_test.Properties.Resources.LogOutICO;
                        this.accountToolStripButton.Text = "Log In";
                    }
                }
                else if (sender == this.createAccountToolStripMenuItem)
                {
                    //  User wants to create an Account.
                    this.ShowLogin(false);
                }
            }
        }
        //
        //  ExitToolStripMenuItem Click
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Exit the application.
            Application.Exit();
        }
        //
        //  ProgressTimer Tick
        //
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            // Update progress bar
            if ((this.toolStripProgressBar1.Value + this.toolStripProgressBar1.Step) > this.toolStripProgressBar1.Maximum)
            {
                this.toolStripProgressBar1.Value = this.toolStripProgressBar1.Minimum;
            }
            else
            {
                this.toolStripProgressBar1.Value += this.toolStripProgressBar1.Step;
            }
        }
        //
        //  DetailSheetToolStripMenuItem Click
        //
        private void detailSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  If no control exists create one.
            closeDocToolStripButton.PerformClick();
            if (this.newEmployeeCntrl == null)
            {
                this.newEmployeeCntrl = new UsersControl(this);
                this.newEmployeeCntrl.Left = 20;
                this.newEmployeeCntrl.Top = 20;
                this.targetPanel.Controls.Add(this.newEmployeeCntrl);
                this.newEmployeeCntrl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                this.newEmployeeCntrl.Show();
                //this.newEmployeeCntrl.Dock = DockStyle.Fill;
                this.closeDocToolStripButton.Enabled = true;
                this.Text = "DB Administration     |Users Detail Sheet|";
                // this.Catlabel.Text = "Users Detail Sheet";
            }

        }

        //
        //  CloseDocToolStripButton Click
        //
        private void closeDocToolStripButton_Click(object sender, EventArgs e)
        {
            int count = this.targetPanel.Controls.Count;
            //  If there are controls remove them all the targetPanel.
            if (count > 0)
            {
                this.targetPanel.Controls.Clear();
                this.newLoginCntrl = null;
                this.newEmployeeCntrl = null;
                this.newDoorCntrl = null;
                this.newlogcntrl = null;
                
                //this.newgroupcntrl.Dispose();
                this.newgroupcntrl = null;
                this.newDBSettingcntrl = null;

                this.newSettingcntrl = null;
                this.closeDocToolStripButton.Enabled = false;
                this.Text = "DB Administration";
                //this.Catlabel.Text = "";
                
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
            }
        }
        //
        //  TimeToolStripMenuItem Click
        //
        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Create a message to inform the user upon request how long they've been on for.
            String msg = String.Format("You have been on the system for {0}", this.HowLongRunning());
            this.statusToolStripStatusLabel.Text = msg;
        }

        private void detailSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeDocToolStripButton.PerformClick();
            if (this.newDoorCntrl == null)
            {
                this.newDoorCntrl = new DoorsControl(this);
                this.newDoorCntrl.Left = 20;
                this.newDoorCntrl.Top = 20;
                this.targetPanel.Controls.Add(this.newDoorCntrl);
                //this.newDoorCntrl.Dock = DockStyle.Fill;
                this.newDoorCntrl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                this.newDoorCntrl.Show();
                this.closeDocToolStripButton.Enabled = true;
                this.Text = "DB Administration     |Doors Detail Sheet|";
                //this.Catlabel.Text = "Doors Detail Sheet";
            }

        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDocToolStripButton.PerformClick();
            if (this.newlogcntrl == null)
            {
                this.newlogcntrl = new LogControl(this);
                this.newlogcntrl.Left = 20;
                this.newlogcntrl.Top = 20;
                this.targetPanel.Controls.Add(this.newlogcntrl);
                //this.newlogcntrl.Dock = DockStyle.Fill;
                this.newlogcntrl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                this.newlogcntrl.Show();
                this.closeDocToolStripButton.Enabled = true;
                this.Text = "DB Administration     |Logs Detail Sheet|";
                //this.Catlabel.Text = "Logs Detail Sheet";
            }
        }

       
        private void targetPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if (e.Control==(Control)this.Catlabel) this.targetPanel.Controls.Add(this.Catlabel);
        }

        private void serverSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDocToolStripButton.PerformClick();
            if (this.newSettingcntrl == null)
            {
                this.newSettingcntrl = new SettingControl(this);
                this.newSettingcntrl.Left = 20;
                this.newSettingcntrl.Top = 20;
                this.targetPanel.Controls.Add(this.newSettingcntrl);
                //this.newgroupcntrl.Dock = DockStyle.Fill;
                this.newSettingcntrl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                this.newSettingcntrl.Show();
                this.closeDocToolStripButton.Enabled = true;
                this.Text = "DB Administration     |Server Setting Sheet|";
                //this.Catlabel.Text = "Groups Detail Sheet";
            }
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Opacity.ToString());
            if (this.BoolStart)
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.15;
                    this.LoadTimer.Interval += 20;
                }
                else
                {
                    this.LoadTimer.Stop();
                    this.LoadTimer = null;
                    GC.Collect();
                    //this.BoolStart = false;
                    //MessageBox.Show(BoolStart.ToString());
                }
            }
            /*else
            {
                MessageBox.Show(this.Opacity.ToString());
                if (this.Opacity >0)
                {
                    //MessageBox.Show(this.Opacity.ToString());
                    this.Opacity -= 0.05;
                    this.LoadTimer.Interval += 5;
                }
                else
                {
                    this.LoadTimer.Stop();
                 //   this.LoadTimer.Dispose();
                }
            }*/
        }

        private void detailSheetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            closeDocToolStripButton.PerformClick();
            if (this.newgroupcntrl == null)
            {
                this.newgroupcntrl = new GroupsControl(this);
                this.newgroupcntrl.Left = 20;
                this.newgroupcntrl.Top = 20;
                this.targetPanel.Controls.Add(this.newgroupcntrl);
                //this.newgroupcntrl.Dock = DockStyle.Fill;
                this.newgroupcntrl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                this.newgroupcntrl.Show();
                this.closeDocToolStripButton.Enabled = true;
                this.Text = "DB Administration     |Groups Detail Sheet|";
                //this.Catlabel.Text = "Groups Detail Sheet";
            }
        }

       private void dBAdminSettingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            closeDocToolStripButton.PerformClick();
            if (this.newDBSettingcntrl == null)
            {
                this.newDBSettingcntrl = new DBAdminSetting(this);
                this.newDBSettingcntrl.Left = 20;
                this.newDBSettingcntrl.Top = 20;
                this.targetPanel.Controls.Add(this.newDBSettingcntrl);
                //this.newgroupcntrl.Dock = DockStyle.Fill;
                this.newDBSettingcntrl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                this.newDBSettingcntrl.Show();
                this.closeDocToolStripButton.Enabled = true;
                this.Text = "DB Administration     |DB Settings.|";
                //this.Catlabel.Text = "Groups Detail Sheet";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
    }