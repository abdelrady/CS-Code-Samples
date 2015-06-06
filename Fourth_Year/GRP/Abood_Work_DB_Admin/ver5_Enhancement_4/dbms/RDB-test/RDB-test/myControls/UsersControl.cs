#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
#endregion

namespace RDB_test.myControls
{
    public partial class UsersControl : UserControl
    {
        //  The current checked item.
        internal ToolStripMenuItem tsmCurrent;
        bool newRecord = false;
        bool FirstLoadTime = true;
        MainForm Parent;
        //byte[] NewImage = null;
        //
        //  Constructor
        //
        public UsersControl(MainForm Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }
        //
        //Finalizer For Garbage Collection.......
        //
       
        //
        //  EmployeeControl Load
        //
        private void employeeControl_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter1.Fill(this.sDASDBDataSet.Users);

        }
        //
        //  PeopleBindingNavigatorSaveItem
        //
        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //  Todo:Change the limit to PhoneLine1 and PhoneLine2 to (14).
            this.Validate();
            if (this.UsersBindingSource1.Current != null && newRecord == false)
            {
                this.UsersBindingSource1.EndEdit();
                if (this.usersTableAdapter1.Update(this.sDASDBDataSet.Users) > 0) Parent.setToolTip("Saving Complete.");// MessageBox.Show("Saving Complete.");
            }
            else
            {

                /*    myData.SDASDBDataSet.UsersRow UserRow =
                            this.sDASDBDataSet.Users.NewUsersRow();
                    //  Add the Users info to the new row.
                    UserRow.userID = "111";//this.iDTextBox.Text;
                    UserRow.userfName = this.firstNameTextBox.Text;
                    UserRow.userlName = this.lastNameTextBox.Text;
                    UserRow.userPhone = this.phoneLine1MaskedTextBox.Text;
                    UserRow.userStage = this.StageTextBox.Text;
                    UserRow.userValid = (this.ValidcomboBox.SelectedText == "True" ? true : false);
                    UserRow.userEmail = this.EmailTextBox.Text;
                    UserRow.userDescription = "";
                    UserRow.userImage = NewImage;
                    //  Add the row to the dataset and commit the changes.
                    this.sDASDBDataSet.Users.Rows.Add(UserRow);
                  */
                this.UsersBindingSource1.EndEdit();
                int results = this.usersTableAdapter1.Update
                    (this.sDASDBDataSet.Users);

                //  If the creation was successful fire the event.
                if (results > 0)
                {
                    Parent.setToolTip("Successful Insertion.");//MessageBox.Show("Successful Insertion.");
                    this.iDTextBox.ReadOnly = true;
                    newRecord = false;
                }
            }
        }
        //
        //  OpenFileDialog Clicked Ok
        //
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.ImportImage(this.openFileDialog1.FileName);
        }
        //
        //  ImportImage
        //
        private void ImportImage(string filename)
        {
            try
            {
                //check for boundaries before performing delete: datatable is empty, or there is no selection
                if (this.UsersBindingSource1.Current != null)
                {
                    //convert generic Current object returned by DataConnector to the typed movie row object
                    DataRowView rowView = (DataRowView)this.UsersBindingSource1.Current;
                    RDB_test.myData.SDASDBDataSet.UsersRow UserRow = (RDB_test.myData.SDASDBDataSet.UsersRow)rowView.Row;

                    //open file as Readonly from file system, copy bytes, and assign to the image property of the current row
                    UserRow.userImage = File.ReadAllBytes(filename);

                    this.UsersBindingSource1.ResetCurrentItem();
                }
                else
                {
                    //NewImage= File.ReadAllBytes(filename);
                    //this.imagePictureBox.Image=Image.FromFile(filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("There was a problem loading the image: {0}", ex.Message));
                //Debug.WriteLine(ex.ToString());
            }
        }
        //
        //  ImportToolStripButton
        //
        private void importToolStripButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }
        //
        //  FindToolStripButton
        //
        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            
            if ((this.tsmCurrent != null) && (this.findToolStripTextBox.Text != ""))
            {
                if (this.UsersBindingSource1.SupportsSearching != false)
                {
                    this.UsersBindingSource1.Filter = "";
                    int found = this.UsersBindingSource1.Find(this.tsmCurrent.Tag.ToString(), this.findToolStripTextBox.Text);
                    if ((found > -1) && this.UsersBindingSource1.SupportsFiltering != false)
                    {
                        this.UsersBindingSource1.Filter = String.Format
                            ("{0}='{1}'", this.tsmCurrent.Tag, this.findToolStripTextBox.Text);
                    }
                }
            }
            else MessageBox.Show("Please Select Column Name & Set Desired Text To Search For Firstly.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //
        //  ShowAllToolStripButton
        //
        private void showAllToolStripButton_Click(object sender, EventArgs e)
        {
            //this.peopleBindingSource.Filter = "";
            this.UsersBindingSource1.Filter = "";
        }
        //
        //  Find Buttons
        //
        private void FindButtonsClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmItem = sender as ToolStripMenuItem;
            tsmItem.Checked = true;
            if (tsmCurrent != null)
            {
                tsmCurrent.Checked = false;
            }
            tsmCurrent = tsmItem;
            tsmItem = null;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Row ?!!!", "Deleting From Collection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usersTableAdapter1.Update(sDASDBDataSet.Users);
            }
            else
            {
                //this.UsersDataGridView.Refresh();
                this.sDASDBDataSet.Users.RejectChanges();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ResetUI();
            this.iDTextBox.ReadOnly = false;
            newRecord = true;
            //this.UsersDataGridView.CurrentCell = null;
        }

        private void ResetUI()
        {
            this.iDTextBox.Text = "";
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.phoneLine1MaskedTextBox.Text = "";
            this.StagecomboBox.SelectedIndex = -1;
            this.ValidcomboBox.SelectedIndex = -1;
            this.DescTextBox.Text = "";
            this.EmailTextBox.Text = "";
            this.imagePictureBox.Image = null;
        }

        private void UsersControl_ParentChanged(object sender, EventArgs e)
        {

            if (!FirstLoadTime)
            {
                this.sDASDBDataSet.Clear();
                this.sDASDBDataSet.Dispose();
                this.imagePictureBox.Image = null;

                this.usersTableAdapter1.Dispose();
                this.usersTableAdapter1 = null;

                GC.Collect();
            }
            else
            {
                FirstLoadTime = false;
            }
        }

        private void UsersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter1.Fill(this.sDASDBDataSet.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
