using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class DismissedS : System.Windows.Forms.Form
    {

        internal System.Windows.Forms.Button CloseBtn;
        private System.ComponentModel.IContainer components;
        public System.Data.OleDb.OleDbConnection dBConnection;
        private System.Windows.Forms.Button deleteBTN;
        public Students__House_Control.MyUtility Dutility;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGrid mYDtaGrid;
        public System.Windows.Forms.Button refreshBTN;
        internal System.Windows.Forms.Button ShowRptBtn;

        public DismissedS()
        {
            components = null;
            Dutility = new Students__House_Control.MyUtility();
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void deleteBTN_Click(object sender, System.EventArgs e)
        {
            bool flag = System.Windows.Forms.MessageBox.Show(" \u0647\u0644 \u0627\u0646\u062A \u0645\u062A\u0627\u0643\u062F \u0645\u0646 \u0647\u0630\u0627 \u0627\u0644\u0639\u0645\u0644 \u061F", "\u062A\u062D\u0630\u064A\u0631 ", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.No;
            if (!flag)
            {
            }
            else
            {
                mYDtaGrid.DataSource = null;
                Dutility.exQuery("DELETE FROM Students WHERE Dismissed=True");
                System.Windows.Forms.MessageBox.Show(" \u062A\u0645 \u062D\u0630\u0641 \u0643\u0644 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0641\u0635\u0648\u0644\u064A\u0646 \u0645\u0646 \u0642\u0627\u0639\u062F\u0629 \u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A ", "\u0627\u0644\u0645\u062F\u064A\u0646\u0629 \u0627\u0644\u062C\u0627\u0645\u0639\u064A\u0647 \u0644\u0644\u0637\u0644\u0627\u0628", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                refreshBTN.PerformClick();
            }
        }

        private void DismissedS_Load(object sender, System.EventArgs e)
        {
            Dutility.RefreshMe();
            bool flag = Dutility.getDataTable("SELECT ST_Name as '\u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628',ReasonofDismission as '\u0633\u0628\u0628 \u0627\u0644\u0641\u0635\u0644' FROM Students WHERE Dismissed = True").Rows.Count != 0;
            if (!flag)
            {
                label1.Show();
                ShowRptBtn.Enabled = false;
                deleteBTN.Enabled = false;
            }
            else
            {
                mYDtaGrid.DataSource = Dutility.getDataTable("SELECT ST_Name as '\u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628',ReasonofDismission as '\u0633\u0628\u0628 \u0627\u0644\u0641\u0635\u0644' FROM Students WHERE Dismissed = True");
                Dutility.AdjustDataGridColumnWidth2(Dutility.getDataTable("SELECT ST_Name as '\u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628',ReasonofDismission as '\u0633\u0628\u0628 \u0627\u0644\u0641\u0635\u0644' FROM Students WHERE Dismissed = True"), mYDtaGrid);
                label1.Hide();
                ShowRptBtn.Enabled = true;
                deleteBTN.Enabled = true;
            }
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void refreshBTN_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void ShowRptBtn_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void ﬁÀ»ﬁÀ”«Ì‘›‘(object sender, System.EventArgs e)
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

    } // class DismissedS

}

