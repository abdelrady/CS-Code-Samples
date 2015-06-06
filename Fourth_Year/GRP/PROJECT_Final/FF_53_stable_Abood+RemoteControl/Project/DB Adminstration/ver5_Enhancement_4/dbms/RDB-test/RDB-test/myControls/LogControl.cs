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
    public partial class LogControl : UserControl {
        //  The current checked item.
        internal ToolStripMenuItem tsmCurrent;
        bool FirstLoadTime = true;
        MainForm Parent;
        //
        //  Constructor
        //
        public LogControl(MainForm Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }
        //
        //  EmployeeControl Load
        //
        private void employeeControl_Load(object sender, EventArgs e) {
           // this.peopleTableAdapter.Fill(this.myReportDataSet.People);
            this.logsTableAdapter.Fill(this.sDASDBDataSet.Logs);
            }
        //
        //  PeopleBindingNavigatorSaveItem
        //
        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //  Todo:Change the limit to PhoneLine1 and PhoneLine2 to (14).
            this.Validate();
            if (this.LogBindingSource1.Current != null)
            {
                this.LogBindingSource1.EndEdit();
                if (this.logsTableAdapter.Update(this.sDASDBDataSet.Logs) > 0) Parent.setToolTip("Saving Complete."); //MessageBox.Show("Saving Complete.");
            }
        }
        //
        //  FindToolStripButton
        //
        private void findToolStripButton_Click(object sender, EventArgs e) {
            if ((this.tsmCurrent != null) && (this.findToolStripTextBox.Text != ""))
            {
                if (this.LogBindingSource1.SupportsSearching != false)
                {
                    this.LogBindingSource1.Filter = "";
                    int found = this.LogBindingSource1.Find(this.tsmCurrent.Tag.ToString(), this.findToolStripTextBox.Text);
                    if ((found > -1) && this.LogBindingSource1.SupportsFiltering != false)
                    {
                        this.LogBindingSource1.Filter = String.Format
                            ("{0}='{1}'", this.tsmCurrent.Tag, this.findToolStripTextBox.Text);
                    }
                }
            }
            else MessageBox.Show("Please Select Column Name & Set Desired Text To Search For Firstly.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        //
        //  ShowAllToolStripButton
        //
        private void showAllToolStripButton_Click(object sender, EventArgs e) {
            //this.peopleBindingSource.Filter = "";
            this.LogBindingSource1.Filter = "";
            }
        //
        //  Find Buttons
        //
        private void FindButtonsClick(object sender, EventArgs e) {
            ToolStripMenuItem tsmItem = sender as ToolStripMenuItem;
            tsmItem.Checked = true;
            if (tsmCurrent != null) {
                tsmCurrent.Checked = false;
                }
            tsmCurrent = tsmItem;
            tsmItem = null;
            }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Row ?!!!", "Deleting From Collection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.logsTableAdapter.Update(sDASDBDataSet.Logs);
            }
            else
            {
                //this.UsersDataGridView.Refresh();
                this.sDASDBDataSet.Logs.RejectChanges();
            } 
        }
       
        private void RefreshStripButton1_Click(object sender, EventArgs e)
        {
            this.sDASDBDataSet.Logs.Clear();
            this.logsTableAdapter.Fill(this.sDASDBDataSet.Logs);
        }

        private void UsersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (this.UsersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() != "True") this.UsersDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            //index += " " + e.RowIndex.ToString();
            //Thread.Sleep(1);
        }

        private void LogControl_ParentChanged(object sender, EventArgs e)
        {
            if (!FirstLoadTime)
            {
                this.sDASDBDataSet.Clear();
                this.sDASDBDataSet.Dispose();

                this.logsTableAdapter.Dispose();
                this.logsTableAdapter = null;

                GC.Collect();
            }
            else
            {
                FirstLoadTime = false;
            }
        }
        }
    }
