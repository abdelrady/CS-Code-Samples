using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class faculities : Form
    {

        internal Button BTNrefresh;
        internal Button BTNSave;
        internal Button CloseBtn;
        private IContainer components;
        private Label count;
        public OleDbConnection dBConnection;
        private ComboBox faculityCMBO;
        private Label IDTXT;
        private Label label10;
        internal Label label3;
        private Label lblAuName;
        private Label lblAuPhone;
        private Button newBTN;
        private TextBox stages;
        private MyUtility u;
        private Button ubdateBTN;

        public faculities()
        {
            u = new MyUtility();
            components = null;
            InitializeComponent();
        }

        private void BTNrefresh_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // trial
        }

        public bool check()
        {
            bool flag1;

            bool flag2 = Int32.Parse(stages.Text.ToString()) <= 6;
            if (!flag2)
            {
                stages.Text = "";
                stages.Focus();
                flag1 = true;
            }
            else
            {
                flag1 = false;
            }
            return flag1;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void faculities_Load(object sender, EventArgs e)
        {
            u.RefreshMe();
            u.fillComboBox(faculityCMBO, "SELECT FAC_NAME from faculities");
            u.RefreshMe();
            IDTXT.Text = u.getID("SELECT COUNT(*) FROM faculities");
            count.Text = u.getID("SELECT COUNT(*) FROM faculities");
            newBTN.PerformClick();
        }

        private void faculityCMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            stages.Text = u.getID("SELECT FAC_STAGES from faculities where FAC_NAME='" + faculityCMBO.Text + "'");
            ubdateBTN.Enabled = true;
            BTNSave.Enabled = false;
            IDTXT.Text = u.getID("SELECT FAC_ID from faculities where FAC_NAME='" + faculityCMBO.Text + "'");
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void ubdateBTN_Click(object sender, EventArgs e)
        {
            bool flag = faculityCMBO.Text.Trim() != "" && stages.Text.Trim() != "" && !check();
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627\u064A\u0645\u0643\u0646 \u0627\u0636\u0627\u0641\u0629 \u0643\u0644\u064A\u0647 \u062C\u062F\u064A\u062F\u0647 ,\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0627\u0633\u0627\u0633\u064A\u0647 \u0646\u0627\u0642\u0635\u0629,\u0623\u0648 \u063A\u064A\u0631 \u0645\u0646\u0637\u0642\u064A\u0629", "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                faculityCMBO.Focus();
            }
            else
            {
                u.exQuery("UPDATE faculities set FAC_NAME='" + faculityCMBO.Text + "',FAC_STAGES=" + stages.Text + " WHERE FAC_ID=" + IDTXT.Text);
                MessageBox.Show("\u062A\u0645 \u062A\u0639\u062F\u064A\u0644 \u0627\u0644\u0643\u0644\u064A\u0629 \u0628\u0646\u062C\u0627\u062D \u0641\u0649 \u0642\u0627\u0639\u062F\u0629\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A", "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0643\u0644\u064A\u0627\u062A", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                newBTN.PerformClick();
                ubdateBTN.Enabled = false;
                BTNrefresh.PerformClick();
            }
        }

        protected override void Dispose(bool disposing)
        {
            bool flag = !disposing || (components == null);
            if (!flag)
                components.Dispose();
            base.Dispose(disposing);
        }

    } // class faculities

}

