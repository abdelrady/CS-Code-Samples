#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
#endregion

namespace RDB_test.myControls {
    public partial class GroupsControl : UserControl {
        //  The current checked item.
        internal ToolStripMenuItem tsmCurrent;
        bool newRecord = false;
        bool FirstLoadTime = true;
        RDB_test.MainForm parent;
        myData.SDASDBDataSetTableAdapters.Users_GroupsTableAdapter Users_GroupsTableAdapter = new RDB_test.myData.SDASDBDataSetTableAdapters.Users_GroupsTableAdapter();
        //myData.SDASDBDataSetTableAdapters.DoorsTableAdapter DoorsTableAdapter1 = new RDB_test.myData.SDASDBDataSetTableAdapters.DoorsTableAdapter();
        //myData.SDASDBDataSetTableAdapters.Groups_DoorsTableAdapter Groups_DoorsTableAdapter1 = new RDB_test.myData.SDASDBDataSetTableAdapters.Groups_DoorsTableAdapter();
        //myData.SDASDBDataSetTableAdapters.GroupsTableAdapter GroupsTableAdapter1 = new RDB_test.myData.SDASDBDataSetTableAdapters.GroupsTableAdapter();
        //myData.SDASDBDataSetTableAdapters.UsersTableAdapter UsersTableAdapter1 = new RDB_test.myData.SDASDBDataSetTableAdapters.UsersTableAdapter();

        //RDB_test.User_DoorsdataSet1TableAdapters.Users_GroupsTableAdapter Users_GroupsTableAdapter1 = new RDB_test.User_DoorsdataSet1TableAdapters.Users_GroupsTableAdapter();
            
        //
        //  Constructor
        //
        public GroupsControl(RDB_test.MainForm mf)
        {
            InitializeComponent();
            parent = mf;
        }
        
        //
        //  EmployeeControl Load
        //
        private void employeeControl_Load(object sender, EventArgs e) {
            this.includedDataGridViewTextBoxColumn.ReadOnly = false;
            this.includedDataGridViewTextBoxColumn1.ReadOnly = false;

            this.sDASDBDataSet.Groups.Clear();
            this.groupsTableAdapter.Fill(this.sDASDBDataSet.Groups);

            //int GroupNum = this.sDASDBDataSet.Groups.Rows[0][0].ToString() != "" ? int.Parse(this.sDASDBDataSet.Groups.Rows[0][0].ToString()) : 0;
            //LoadDoors(GroupNum);
            //Thread th = new Thread(new ThreadStart(LoadUsers));
            //th.Start(GroupNum);
            //LoadUsers(GroupNum);
            }

        private void LoadUsers(object GroupsNum)
        {
            this.sDASDBDataSet.UsersINGroup.Clear();
            this.sDASDBDataSet.UsersINGroup.Dispose();
            GC.Collect();
            this.Group_usersDataAdapter.SelectCommand.Parameters["@Param"].Value = (int)GroupsNum;
            this.Group_usersDataAdapter.Fill(this.sDASDBDataSet.UsersINGroup);
        }
        
        private void LoadDoors(int GroupID)
        {

            this.sDASDBDataSet.DoorsInGroup.Clear();
            this.sDASDBDataSet.DoorsInGroup.Dispose();
            GC.Collect();
            this.Group_DoorsDataAdapter.SelectCommand.Parameters["@Param"].Value = GroupID;
            this.Group_DoorsDataAdapter.Fill(this.sDASDBDataSet.DoorsInGroup);
        }
        //
        //  PeopleBindingNavigatorSaveItem
        //
        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //  Todo:Change the limit to PhoneLine1 and PhoneLine2 to (14).
            this.Validate();
            if (this.GroupsBindingSource1.Current != null && newRecord == false)
            {
                this.GroupsBindingSource1.EndEdit();
                if (this.groupsTableAdapter.Update(this.sDASDBDataSet.Groups) > 0) parent.setToolTip("Saving Complete.");//MessageBox.Show("Saving Complete.");
            }
            else
            {
                this.GroupsBindingSource1.EndEdit();
                int results = this.groupsTableAdapter.Update
                    (this.sDASDBDataSet.Groups);

                //  If the creation was successful fire the event.
                if (results > 0)
                {
                    parent.setToolTip("Successful Insertion.");
                    //MessageBox.Show("Successful Insertion.");
                    this.iDTextBox.ReadOnly = true;
                    newRecord = false;
                }
            }
        }
        //
        //  FindToolStripButton
        //
        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            if ((this.tsmCurrent != null)&& (this.findToolStripTextBox.Text != ""))
            {
                if (this.GroupsBindingSource1.SupportsSearching != false)
                {
                    this.GroupsBindingSource1.Filter = "";
                    int found = this.GroupsBindingSource1.Find(this.tsmCurrent.Tag.ToString(), this.findToolStripTextBox.Text);
                    if ((found > -1) && this.GroupsBindingSource1.SupportsFiltering != false)
                    {
                        this.GroupsBindingSource1.Filter = String.Format
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
            this.GroupsBindingSource1.Filter = "";
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
                groupsTableAdapter.Update(sDASDBDataSet.Groups);
            }
            else
            {
                //this.UsersDataGridView.Refresh();
                this.sDASDBDataSet.Groups.RejectChanges();
            }
        }

        private void ResetUI()
        {
            this.iDTextBox.Text = "";
            this.GroupNameTextBox.Text = "";
        }

        private void DoorsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string val = (this.DoorsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1" ? "0" : "1");
            
                int groupNum=int.Parse(this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString());
                int doorNum = int.Parse(this.DoorsGridView.CurrentRow.Cells[0].Value.ToString());
                RDB_test.myData.SDASDBDataSetTableAdapters.Groups_DoorsTableAdapter dd = new RDB_test.myData.SDASDBDataSetTableAdapters.Groups_DoorsTableAdapter();
                try
                {
                    if (val == "0")//delete
                    {
                        string msg = dd.DeleteQuery(groupNum, doorNum) > 0 ? "Successful Removal." : "Unknown Error Occured. During Delete Process.";
                        parent.setToolTip(msg);
                        //MessageBox.Show(dd.DeleteQuery(groupNum, doorNum) > 0 ? "Successful Removal." : "Unknown Error Occured. During Delete Process.");
                        this.DoorsGridView.CurrentRow.Cells[e.ColumnIndex].Value = 0;

                    }
                    else if (val == "1")//insert
                    {
                        string msg = dd.Insert(groupNum, doorNum) > 0 ? "Successful Insertion." : "Unknown Error Occured.During Insertion Process.";
                        parent.setToolTip(msg);
                        //MessageBox.Show(dd.Insert(groupNum, doorNum) > 0 ? "Successful Insertion." : "Unknown Error Occured.During Insertion Process.");
                        this.DoorsGridView.CurrentRow.Cells[e.ColumnIndex].Value = 1;
                    }
                    else
                    {
                        parent.setToolTip("Unknown Error Occured."); 
                        //MessageBox.Show("Unknown Error Occured.");
                        LoadDoors(int.Parse(this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
         //   MessageBox.Show(this.DoorsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        private void GroupsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString());
            //ResetGridViews();
            try
            {
                if (this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    int GroupNum = int.Parse(this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    LoadDoors(GroupNum);
                    LoadUsers(GroupNum);
                }
                else
                {

                }
            }
            catch { }
        }
        
        private void ResetGridViews()
        {
            for (int j = 0; j < this.DoorsGridView.Rows.Count ; j++)
            {
                this.DoorsGridView.Rows[j].Cells[2].Value = 0;
            }
            for (int j = 0; j < this.UsersGridView.Rows.Count ; j++)
            {
                this.UsersGridView.Rows[j].Cells[3].Value = 0;
            }
        }

        private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(this.UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            
            if (e.ColumnIndex == 3)
            {
                string val = (this.UsersGridView.CurrentRow.Cells[e.ColumnIndex].Value.ToString() == "1" ? "0" : "1");
                int groupNum = int.Parse(this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString());
                string UserID = this.UsersGridView.CurrentRow.Cells[0].Value.ToString();
                
                if (val == "0")//delete
                {
                    string msg = Users_GroupsTableAdapter.Delete(UserID, groupNum) > 0 ? "Successful Removal." : "Unknown Error Occured.";
                    parent.setToolTip(msg);
                    //MessageBox.Show(Users_GroupsTableAdapter.Delete(UserID, groupNum) > 0 ? "Successful Removal." : "Unknown Error Occured.");
                    //MessageBox.Show(Users_GroupsTableAdapter1.Delete(UserID.ToString(),groupNum).ToString());
                    this.UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;

                }
                else if (val == "1")//insert
                {
                    string msg = Users_GroupsTableAdapter.Insert(UserID, groupNum) > 0 ? "Successful Insertion." : "Unknown Error Occured.";
                    parent.setToolTip(msg);
                    //MessageBox.Show();
                    //MessageBox.Show(Users_GroupsTableAdapter1.Insert(UserID.ToString(), groupNum).ToString());
                    this.UsersGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
                else
                {
                    parent.setToolTip("Unknown Error Occured.");
                    //MessageBox.Show("Unknown Error Occured.");
                    LoadUsers(int.Parse(this.GroupsDataGridView.CurrentRow.Cells[0].Value.ToString()));
                }

            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            ResetUI();
            this.iDTextBox.ReadOnly = false;
            newRecord = true;
            ResetGridViews();
        }


        /// <summary>
        /// For Testing Purposes Only........... Garbage Collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
           // this.sDASDBDataSet.Clear();
           // this.user_DoorsdataSet11.Clear();
           // this.usersTableAdapter.Dispose();
           // this.usersTableAdapter = null;

            




            Users_GroupsTableAdapter = null;
            this.groupsTableAdapter.Dispose();
            this.groupsTableAdapter = null;
            //this.sqlDataAdapter1.Dispose();
            //this.sqlDataAdapter1 = null;
            //this.sqlDataAdapter2.Dispose();
            //this.sqlDataAdapter2 = null;
           
            
           
            this.Dispose(true);
        
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //this.imagePictureBox.Image = null;
            //GC.Collect();

            /*this.sDASDBDataSet.Groups.Clear();
            this.groupsTableAdapter.Fill(this.sDASDBDataSet.Groups);
            */
            //this.Group_usersDataAdapter = null;
            //this.sDASDBDataSet.UsersINGroup.Clear();
            //this.sDASDBDataSet.UsersINGroup.Dispose();
            //GC.Collect();
            //int GroupNum = this.sDASDBDataSet.Groups.Rows[0][0].ToString() != "" ? int.Parse(this.sDASDBDataSet.Groups.Rows[0][0].ToString()) : 0;

            //LoadDoors(GroupNum);
            //Thread th = new Thread(new ThreadStart(LoadUsers));
            //th.Start(GroupNum);
            //LoadUsers(GroupNum);
        }

        private void GroupsControl_ParentChanged(object sender, EventArgs e)
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

                this.groupsTableAdapter.Dispose();
                this.groupsTableAdapter = null;
                this.Group_DoorsDataAdapter.Dispose();
                this.Group_DoorsDataAdapter = null;
                this.Group_usersDataAdapter.Dispose();
                this.Group_usersDataAdapter = null;

                this.imagePictureBox.Dispose();
                this.imagePictureBox = null;

                GC.Collect();
            }
            else
            {
                FirstLoadTime = false;
            }
        }
    }
}