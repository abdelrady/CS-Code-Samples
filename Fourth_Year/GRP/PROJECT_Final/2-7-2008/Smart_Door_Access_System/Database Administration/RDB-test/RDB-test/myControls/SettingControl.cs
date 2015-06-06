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

namespace RDB_test.myControls {
    public partial class SettingControl : UserControl
    {
        //  The current checked item.
        internal ToolStripMenuItem tsmCurrent;
        bool FirstLoadTime = true;
        MainForm Parent;
        //
        //  Constructor
        //
        public SettingControl(MainForm Parent)
        {
            InitializeComponent();
            this.Parent = Parent;
        }
        //
        //  EmployeeControl Load
        //
        private void employeeControl_Load(object sender, EventArgs e)
        {
            this.sDASDBDataSet.ServerSettings.Clear();
            this.serverSettingsTableAdapter.Fill(this.sDASDBDataSet.ServerSettings);
        }
        //
        //  PeopleBindingNavigatorSaveItem
        //
        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //  Todo:Change the limit to PhoneLine1 and PhoneLine2 to (14).
            this.Validate();
            if (this.SettingBindingSource1.Current != null)
            {
                this.SettingBindingSource1.EndEdit();
                if (this.serverSettingsTableAdapter.Update(this.sDASDBDataSet.ServerSettings) > 0) Parent.setToolTip("Saving Complete."); //MessageBox.Show("Saving Complete.");
            }
        }
        //
        //  FindToolStripButton
        //
        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            if ((this.tsmCurrent != null) && (this.findToolStripTextBox.Text != ""))
            {
                if (this.SettingBindingSource1.SupportsSearching != false)
                {
                    this.SettingBindingSource1.Filter = "";
                    //int found = this.SettingBindingSource1.Find(this.tsmCurrent.Tag.ToString(), this.findToolStripTextBox.Text);
                    //if ((found > -1) && this.SettingBindingSource1.SupportsFiltering != false)
                    try
                    {
                        this.SettingBindingSource1.Filter = String.Format
                            ("{0}='{1}'", this.tsmCurrent.Tag, this.findToolStripTextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
            this.SettingBindingSource1.Filter = "";
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
            this.serverSettingsTableAdapter.Update(sDASDBDataSet.ServerSettings);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sDASDBDataSet.ServerSettings.Clear();
                this.serverSettingsTableAdapter.Fill(this.sDASDBDataSet.ServerSettings);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void RefreshStripButton1_Click(object sender, EventArgs e)
        {
            this.sDASDBDataSet.Logs.Clear();
            this.serverSettingsTableAdapter.Fill(this.sDASDBDataSet.ServerSettings);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SettingControl_ParentChanged(object sender, EventArgs e)
        {

            if (!FirstLoadTime)
            {
                this.sDASDBDataSet.Clear();
                this.sDASDBDataSet.Dispose();
                
                this.serverSettingsTableAdapter.Dispose();
                this.serverSettingsTableAdapter = null;

                GC.Collect();
            }
            else
            {
                FirstLoadTime = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.sDASDBDataSet.Logs.Clear();
            this.serverSettingsTableAdapter.Fill(this.sDASDBDataSet.ServerSettings);
        }

    }
    }
