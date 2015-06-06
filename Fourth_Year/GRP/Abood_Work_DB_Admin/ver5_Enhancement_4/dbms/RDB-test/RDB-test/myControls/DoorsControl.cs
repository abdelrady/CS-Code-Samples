#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
#endregion

namespace RDB_test.myControls
{
    public partial class DoorsControl : UserControl
    {
        //  The current checked item.
        internal ToolStripMenuItem tsmCurrent;
        bool newRecord = false;
        bool FirstLoadTime = true;
        MainForm Parent;
        myData.SDASDBDataSetTableAdapters.Users_DoorsTableAdapter users_DoorsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.Users_DoorsTableAdapter();
        //myData.SDASDBDataSetTableAdapters.Groups_DoorsTableAdapter Groups_DoorsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.Groups_DoorsTableAdapter();
        //
        //  Constructor
        //
        public DoorsControl(MainForm Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }
        //
        //  EmployeeControl Load
        //
        private void employeeControl_Load(object sender, EventArgs e)
        {
            this.validDataGridViewTextBoxColumn.ReadOnly = false;
            //this.includedDataGridViewTextBoxColumn.ReadOnly = false;

            this.users_DoorsTableAdapter.Connection.ConnectionString = this.doorsTableAdapter.Connection.ConnectionString;
            //MessageBox.Show(this.users_DoorsTableAdapter.Connection.ConnectionString);
            this.sDASDBDataSet.Doors.Clear();
            this.doorsTableAdapter.Fill(this.sDASDBDataSet.Doors);

            
            int DoorNum=this.sDASDBDataSet.Doors.Rows[0][0].ToString()!=""?int.Parse(this.sDASDBDataSet.Doors.Rows[0][0].ToString()):0;
            LoadUsers(DoorNum);
            //LoadGroups(DoorNum);
            
        }

        //
        //  PeopleBindingNavigatorSaveItem
        //
        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //  Todo:Change the limit to PhoneLine1 and PhoneLine2 to (14).
            this.Validate();
            if (this.DoorsBindingSource1.Current != null && newRecord == false)
            {
                this.DoorsBindingSource1.EndEdit();
                if (this.doorsTableAdapter.Update(this.sDASDBDataSet.Doors) > 0) Parent.setToolTip("Saving Complete.");//MessageBox.Show("Saving Complete.");
            }
            else
            {
                this.DoorsBindingSource1.EndEdit();
                int results = this.doorsTableAdapter.Update
                    (this.sDASDBDataSet.Doors);
                //int results = this.adminUsersTableAdapter1.InsertQuery(newAdminUserRow.Name, newAdminUserRow.Password, "Admin");

                //  If the creation was successful fire the event.
                if (results > 0)
                {
                    Parent.setToolTip("Successful Insertion.");
                    //MessageBox.Show("Successful Insertion.");
                    this.iDTextBox.ReadOnly = true;
                    newRecord = false;
                }
            }
            //this.peopleBindingSource.EndEdit();
            //this.peopleTableAdapter.Update(this.myReportDataSet.People);
        }

        //
        //  FindToolStripButton
        //
        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            if ((this.tsmCurrent != null) && (this.findToolStripTextBox.Text != ""))
            {
                if (this.DoorsBindingSource1.SupportsSearching != false)
                {
                    this.DoorsBindingSource1.Filter = "";
                    int found = this.DoorsBindingSource1.Find(this.tsmCurrent.Tag.ToString(), this.findToolStripTextBox.Text);
                    if ((found > -1) && this.DoorsBindingSource1.SupportsFiltering != false)
                    {
                        this.DoorsBindingSource1.Filter = String.Format
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
            this.DoorsBindingSource1.Filter = "";
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
                doorsTableAdapter.Update(sDASDBDataSet.Doors);
            }
            else
            {
                //this.UsersDataGridView.Refresh();
                this.sDASDBDataSet.Doors.RejectChanges();
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
            this.DoorNameTextBox.Text = "";
            this.DoorIPTextBox.Text = "";
            this.DoorMacTextBox.Text = "";
            this.DoorPasswordTextBox.Text = "";
            //LoadGroups(0);
            LoadUsers(0);
        }

        private void DoorsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (this.DoorsDataGridView.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    int DoorNum = int.Parse(this.DoorsDataGridView.CurrentRow.Cells[0].Value.ToString());

                    //LoadGroups(DoorNum);

                    LoadUsers(DoorNum);

                }
                else
                {
                    ResetUI();
                }
            }
            catch { }
        }

        private void LoadUsers(int DoorNum)
        {
            this.sDASDBDataSet.UsersInDoors.Clear();
            GC.Collect();
            this.UsersDataAdapter1.SelectCommand.Parameters[0].Value = DoorNum;
            this.UsersDataAdapter1.Fill(this.sDASDBDataSet.UsersInDoors);
        }

        /*private void LoadGroups(int DoorNum)
        {
            this.sDASDBDataSet.GroupsInDoor.Clear();
            GC.Collect();
            this.Groups_doorsDataAdapter1.SelectCommand.Parameters[0].Value = DoorNum;
            this.Groups_doorsDataAdapter1.Fill(this.sDASDBDataSet.GroupsInDoor);
        }*/
       
        private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string val = (this.UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1" ? "0" : "1");
                int DoorNum = int.Parse(this.DoorsDataGridView.CurrentRow.Cells[0].Value.ToString());
                string UserID = this.UsersGridView.CurrentRow.Cells[0].Value.ToString();
                //MessageBox.Show(this.UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (val == "0")//delete
                {
                    if(users_DoorsTableAdapter.Delete(UserID, DoorNum) > 0 )
                        Parent.setToolTip("Successful Removal.");
                    else  Parent.setToolTip("Unknown Error Occured. In Delete Process.");
                    //MessageBox.Show(users_DoorsTableAdapter.Delete(UserID, DoorNum) > 0 ? "Successful Removal." : "Unknown Error Occured. In Delete Process.");
                    this.UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
                else if (val == "1")//insert
                {
                    if (users_DoorsTableAdapter.Insert(UserID, DoorNum) > 0) Parent.setToolTip("Successful Insertion.");
                    else Parent.setToolTip("Unknown Error Occured. In Insertion Process.");
                    //MessageBox.Show(users_DoorsTableAdapter.Insert(UserID, DoorNum) > 0 ? "Successful Insertion." : "Unknown Error Occured. In Insertion Process.");
                    this.UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
                else
                {
                    Parent.setToolTip("Unknown Error Occured.");
                    //MessageBox.Show("Unknown Error Occured.");
                    LoadUsers(int.Parse(this.DoorsDataGridView.CurrentRow.Cells[0].Value.ToString()));
                }
                //LoadUsers(int.Parse(this.DoorsDataGridView.CurrentRow.Cells[0].Value.ToString()));
            }

        }

       /* private void GroupsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string val = (this.GroupsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1" ? "0" : "1");
                int DoorNum = int.Parse(this.DoorsDataGridView.CurrentRow.Cells[0].Value.ToString());
                int GroupNum = int.Parse(this.GroupsGridView.CurrentRow.Cells[0].Value.ToString());

                if (val == "0")//delete
                {
                    if (Groups_DoorsTableAdapter.Delete(GroupNum, DoorNum) > 0) Parent.setToolTip("Successful Removal.");
                    else Parent.setToolTip("Unknown Error Occured.");
                    //MessageBox.Show(Groups_DoorsTableAdapter.Delete(GroupNum, DoorNum) > 0 ? "Successful Removal." : "Unknown Error Occured.");
                    //MessageBox.Show(Users_GroupsTableAdapter1.Delete(UserID.ToString(),groupNum).ToString());
                    this.GroupsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;

                }
                else//insert
                {
                    if(Groups_DoorsTableAdapter.Insert(GroupNum, DoorNum) > 0) Parent.setToolTip("Successful Insertion.");
                    else Parent.setToolTip("Unknown Error Occured.");
                    //MessageBox.Show(Groups_DoorsTableAdapter.Insert(GroupNum, DoorNum) > 0 ? "Successful Insertion." : "Unknown Error Occured.");
                    //MessageBox.Show(Users_GroupsTableAdapter1.Insert(UserID.ToString(), groupNum).ToString());
                    this.GroupsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            //    LoadGroups(int.Parse(this.DoorsDataGridView.CurrentRow.Cells[0].Value.ToString()));
            }
        }*/

        private void DoorsControl_ParentChanged(object sender, EventArgs e)
        {

            if (!FirstLoadTime)
            {
                //FirstLoadTime = true;
                //this.sDASDBDataSet.Groups.Clear();
                //this.sDASDBDataSet.Groups.Dispose();

                //this.sDASDBDataSet.UsersINGroup.Clear();
                //this.sDASDBDataSet.UsersINGroup.Dispose();

                this.sDASDBDataSet.Clear();
                this.sDASDBDataSet.Dispose();

                //this.Groups_doorsDataAdapter1.Dispose();
                //this.Groups_doorsDataAdapter1 = null;
                //this.Groups_DoorsTableAdapter.Dispose();
                //this.Groups_DoorsTableAdapter = null;
                this.UsersDataAdapter1.Dispose();
                this.UsersDataAdapter1 = null;
                this.users_DoorsTableAdapter.Dispose();
                this.users_DoorsTableAdapter = null;
                
                GC.Collect();
            }
            else
            {
                FirstLoadTime = false;
            }
        }

    }

}

    /*
                SELECT     Doors.doorNum, Users.userfName
    FROM         Doors INNER JOIN
                          Users_Doors ON Doors.doorNum = Users_Doors.doorNum INNER JOIN
                          Users ON Users_Doors.userID = Users.userID
    WHERE     (Doors.doorNum = @doorNum)
                 * */
