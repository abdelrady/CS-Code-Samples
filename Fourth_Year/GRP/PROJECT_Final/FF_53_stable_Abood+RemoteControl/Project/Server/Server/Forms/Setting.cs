using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDoor
{
    public partial class Settingfrm : Form
    {
        public Settingfrm()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(sendupdatestxt.Text) < 2000)
            {
                MessageBox.Show(
                   this,
                   "The minimum interval between updates must not less than 2000",
                   "Smart Door",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                sendupdatestxt.Text = "2000";
            }
            else
            {
                if (MessageBox.Show(
                   this,
                   "Are you sure that you want to change configuration?",
                   "Smart Door",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Configuration.Write_Config(Connectionstrtxt.Text, mainpornumbertxt.Text, updatesporttxt.Text, sendupdatestxt.Text);
                    MessageBox.Show(
                        this,
                        "Configuration saving succeeded,\nYou Must Restart Application To apply new configurations.",
                        "Smart Door",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                Close();
            }          
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settingfrm_Load(object sender, EventArgs e)
        {
            Connectionstrtxt.Text = Configuration.connectionString;
            mainpornumbertxt.Text = Configuration.mainPortNumber;
            updatesporttxt.Text = Configuration.UpdatesPort;
            sendupdatestxt.Text = Configuration.sendUpdatesEvery;
        }
    }
}