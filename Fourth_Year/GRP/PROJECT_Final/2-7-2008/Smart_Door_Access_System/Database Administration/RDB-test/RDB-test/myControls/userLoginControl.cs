#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
#endregion//<--End-->Using Region

namespace RDB_test.myControls
{
    public partial class userLoginControl : UserControl
    {
        bool FirstLoadTime = true;

        #region Delegates
        //
        //  Login Delegates.
        //
        public delegate void LoginSuccessful(object sender, EventArgs e);
        public delegate void LoginUnsuccessful(object sender, EventArgs e);
        //
        //  Account Creation Delegates.
        //
        public delegate void AccountCreated(object sender, EventArgs e);
        public delegate void AccountNotCreated(object sender, EventArgs e);
        //
        //  A Delegate to signify it's ok to close this control now.
        //
        public delegate void LoginClose(object sender, EventArgs e);
        //
        //  A Delegate to start progress timer.
        //
        public delegate void StartMyTimer(object sender, EventArgs e);
        #endregion

        #region Events
        //
        //  Login Events.
        //
        public event LoginSuccessful loginSuccessful;
        public event LoginUnsuccessful loginUnsuccessful;
        //
        //  Account Creation Events.
        //
        public event AccountCreated accountCreated;
        public event AccountNotCreated accountNotCreated;
        //
        //  Close the control Event.
        //
        public event LoginClose loginClose;
        //
        //  StartMyTimer Event.
        //
        public event StartMyTimer startMyTimer;
        #endregion

        #region Constructor
        //
        //  Constructor
        //
        public userLoginControl(bool IsLogin)
        {
            InitializeComponent();

            //  Determine if we are creating an account or logging in.
            if (IsLogin)
            {
                this.loginRadioButton.Checked = true;
            }
            else
            {
                this.newAccountRadioButton.Checked = true;
            }
        }
        #endregion//<--End-->Constructor Region
        //
        //  UserLoginControl Load
        //
        private void userLoginControl_Load(object sender, EventArgs e)
        {
            //  Wire the two TextBoxes' Enter event to an Anonymouse Method.
            nameTextBox.Enter += enterHandler;
            passwordTextBox.Enter += enterHandler;
        }

        #region Buttons
        //
        //  Ok Button Click
        //
        private void okButton_Click(object sender, EventArgs e)
        {
            if (loginRadioButton.Checked == true)
            {
                //  Start the progress.
                startMyTimer(sender, e);

                //  Run the login operation on a seperate thread using BWorker1.
                this.backgroundWorker1.RunWorkerAsync();
            }
            else if (newAccountRadioButton.Checked == true)
            {
                //  Start the progress.
                startMyTimer(sender, e);

                //  Run the operation to create a new account on a seperate thread using BWorker2.
                this.backgroundWorker2.RunWorkerAsync();
            }
        }
        //
        //  CancelButton Click
        //
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.loginRadioButton.Checked == true)
            {
                //  This allows a user to cancel the operations.
                this.backgroundWorker1.CancelAsync();
                loginClose(sender, e);
            }
            else if (this.newAccountRadioButton.Checked == true)
            {
                //  Allow the user to cancel creation of the new account.
                this.backgroundWorker2.CancelAsync();
                loginClose(sender, e);
            }
        }
        #endregion

        #region TextBoxes' UI
        //
        //  An anonymous method for the Enter event of the TextBoxes.
        //
        EventHandler enterHandler = delegate(object sender, EventArgs e)
        {
            //  Find out which TextBox fired the event and store the object.
            TextBox TBox = sender as TextBox;
            //  Determine if there is text in the TextBox.
            if (TBox != null)
            {
                TBox.SelectAll();
            }
        };
        #endregion//<--End-->TextBoxes' UI Region

        #region BackgroundWorker1
        //
        //  BackgroundWorker DoWork
        //
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //  Don't access the form's BackgroundWorker reference directly.
            //  Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            //  Start the custom operation used to interact with a database.
            e.Result = UserLogin(bw);

            //  If the user cancelled the operation, notify the BackgroundWorker.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        //
        //  BackgroundWorker RunWorkerCompleted
        //
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //  Check the arguments to see if the user has cancelled the operation.
            if (e.Cancelled)
            {
                //  Login was Unsuccessful, so raise the event.
                loginUnsuccessful(sender, e);
            }
            else if (e.Error != null)
            {
                //  There was an error.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);

                //  Login was Unsuccessful, so raise the event.
                loginUnsuccessful(sender, e);
            }
            else
            {
                //  The operation was a success.
                if ((bool)e.Result != true)
                {
                    //  The backgroundWorker performed it's operations properly but the user,
                    //  has not been logged in due to no credentials.
                    loginUnsuccessful(sender, e);
                }
                else
                {
                    //  If the user's login was successful store their Name in the custom,
                    //  settings' property.
                    RDB_test.Properties.Settings.Default.UserName = this.nameTextBox.Text;

                    //  Login was Successful, so raise the event.
                    loginSuccessful(sender, e);
                }
            }//<--End-->Main if/else structure
        }
        #endregion//<--End-->BackgroundWorker1 Region

        #region BackgroundWorker2
        //
        //  BackgroundWorker DoWork
        //
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //  Don't access the form's BackgroundWorker reference directly.
            //  Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            //  Start the custom operation used to interact with a database.
            e.Result = CreateUserAccount(bw);

            //  If the user cancelled the operation, notify the BackgroundWorker.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        //
        //  BackgroundWorker RunWorkerCompleted
        //
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //  Check the arguments to see if the user has cancelled the operation.
            if (e.Cancelled)
            {
                //  Account creation Unsuccessful.
                accountNotCreated(sender, e);
            }
            else if (e.Error != null)
            {
                //  There was an error.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);

                //  Account creation Unsuccessful.
                accountNotCreated(sender, e);
            }
            else if ((bool)e.Result != true)
            {
                //  The backgroundWorker performed it's operations properly but the account,
                //  has not been created.
                accountNotCreated(sender, e);
            }
            else
            {
                //  Login was Successful, so raise the event.
                accountCreated(sender, e);
            }
        }//<--End-->Main if/else structure
        #endregion<--End-->BackgroundWorker2 Region

        #region UserLogin
        //
        //  UserLogin --> Ran by the BackgroundWorker
        //
        private bool UserLogin(BackgroundWorker bw)
        {
            //  If the user cancelled the operation no need to continue.
            if (!this.backgroundWorker1.CancellationPending)
            {
                //  Fill the TableAdapter with a list from the Users Table.
                this.adminUsersTableAdapter.Fill(this.sDASDBDataSet.AdminUsers);

                //  Check to see if Filtering is supported.
                if (!AdminUsersBindingSource1.SupportsFiltering)
                {
                    return false;

                }
                else
                {
                    //  Fill the dataset with the filtered users.
                    this.AdminUsersBindingSource1.Filter =
                        (String.Format
                        ("Name='{0}'", this.nameTextBox.Text));

                    //  Check to see if Searching is supported.
                    if (!AdminUsersBindingSource1.SupportsSearching)
                    {
                        return false;
                    }
                    else
                    {
                        //  Search from the selected users to find,
                        //  one with this password.
                        int foundIndex = this.AdminUsersBindingSource1.Find
                            ("Password", this.passwordTextBox.Text);
                        if (foundIndex > -1)
                        {
                            //CollectMem();
                            // MessageBox.Show("Found");
                            return true;//  Found the Name/Password.
                        }
                        else
                        {
                            return false;//  Could not find Name/Password.
                        }
                    }
                }
            }
            else
            {
                return false;//  The user cancelled the operation.
            }
        }

        private void CollectMem()
        {
            
            this.adminUsersTableAdapter.Dispose();
            this.adminUsersTableAdapter = null;
            this.sDASDBDataSet.Clear();
            GC.Collect();
        }
        #endregion//<--End-->User Login Region

        #region CreateUserAccount
        //
        //  CreateUserAccount
        //
        private bool UserFound(BackgroundWorker bw)
        {
              //  Fill the TableAdapter with a list from the Users Table.
                this.adminUsersTableAdapter.Fill(this.sDASDBDataSet.AdminUsers);

                    //  Fill the dataset with the filtered users.
                    this.AdminUsersBindingSource1.Filter =
                        (String.Format
                        ("Name='{0}'", this.nameTextBox.Text));

                    //  Check to see if Searching is supported.
                    if (this.AdminUsersBindingSource1.Count>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
        }
        public bool CreateUserAccount(BackgroundWorker bw)
        {
            
            //  Check to see if the user even entered any valid data.
            if (this.nameTextBox.Text == null || this.passwordTextBox.Text == null)
            {
                MessageBox.Show("You did not enter any information to be processed!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (UserFound(bw))
                {
                    MessageBox.Show("Error:User Name already Exist!\r\nPlease Select Another User Name"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //  Create a new row to store the account info.
                myData.SDASDBDataSet.AdminUsersRow newAdminUserRow =
                    this.sDASDBDataSet.AdminUsers.NewAdminUsersRow();
                //  Add the Users info to the new row.
                newAdminUserRow.Name = this.nameTextBox.Text;
                newAdminUserRow.Password = this.passwordTextBox.Text;
                //  Add the row to the dataset and commit the changes.
                this.sDASDBDataSet.AdminUsers.Rows.Add(newAdminUserRow);
                this.AdminUsersBindingSource1.EndEdit();
                int results = this.adminUsersTableAdapter.Update
                    (this.sDASDBDataSet.AdminUsers);
                //int results = this.adminUsersTableAdapter1.InsertQuery(newAdminUserRow.Name, newAdminUserRow.Password, "Admin");

                //  If the creation was successful fire the event.
                if (results > 0)
                {
                    // MessageBox.Show(results.ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion//<--End-->CreateUserAccount Region

        private void userLoginControl_ParentChanged(object sender, EventArgs e)
        {
            if (!FirstLoadTime)
            {
                this.adminUsersTableAdapter.Dispose();
                this.adminUsersTableAdapter = null;
                this.sDASDBDataSet.Clear();
                this.backgroundWorker1.Dispose();
                this.backgroundWorker1 = null;
                this.backgroundWorker2.Dispose();
                this.backgroundWorker2 = null;
                GC.Collect();
            }
            else
            {
                FirstLoadTime = false;
            }
        }

        private void userLoginControl_Paint(object sender, PaintEventArgs e)
        {
            this.nameLabel.BackColor = this.BackColor;
            this.passwordLabel.BackColor = this.BackColor;
            this.loginRadioButton.BackColor = this.BackColor;
            this.newAccountRadioButton.BackColor = this.BackColor;
        }

    }
}