using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class Accounts : Form
    {

        internal Button BTNNext;
        internal Button BTNPrev;
        internal Button BTNSave;
        internal Button CloseBtn;
        private IContainer components;
        private Label count;
        private int Count;
        public OleDbConnection dBConnection;
        private Button deleteBTN;
        private bool Fromisert;
        private GroupBox groupBox1;
        private Label IDTXT;
        internal Label Label1;
        private Label label10;
        private Label label12;
        internal Label Label2;
        internal Label label3;
        private DataTable MYDataTable;
        private Button newBTN;
        private string oldUsereName;
        internal TextBox PasswordTXT;
        private Button refreshBTN;
        public int rowPointer;
        private Button ubdateBTN;
        internal ComboBox UserNameCombo;

        public Accounts()
        {
            components = null;
            rowPointer = -1;
            Fromisert = false;
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            // trial
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void BTNPrev_Click(object sender, EventArgs e)
        {
            BTNSave.Enabled = false;
            ubdateBTN.Enabled = true;
            deleteBTN.Enabled = true;
            rowPointer--;
            bool flag = rowPointer >= 0;
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627 \u064A\u0648\u062C\u062F \u0645\u0633\u062A\u062E\u062F\u0645\u064A\u0646 \u0627\u062E\u0631\u0648\u0646", "\u062A\u062D\u0630\u064A\u0631", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rowPointer++;
                BTNPrev.Enabled = false;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                showData(MYDataTable);
                oldUsereName = UserNameCombo.Text;
                Cursor = Cursors.Arrow;
                BTNNext.Enabled = true;
            }
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // trial
        }

        public bool ChecForDup()
        {
            bool flag1;

            bool flag2 = !Fromisert;
            if (!flag2)
            {
                OleDbCommand oleDbCommand = new OleDbCommand("SELECT Count(name) FROM Employee where name = '" + UserNameCombo.Text + "'", dBConnection);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                while (flag2)
                {
                    Count = oleDbDataReader.GetInt32(0);
                    flag2 = oleDbDataReader.Read();
                }
                flag2 = Count != 1;
                if (!flag2)
                {
                    MessageBox.Show("\u0647\u0630\u0627 \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645 \u0645\u0648\u062C\u0648\u062F \u0641\u0649 \u0642\u0627\u0639\u062F\u0647 \u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A", "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
                flag2 = oldUsereName != UserNameCombo.Text;
                if (!flag2)
                {
                    return true;
                }
            }
            return true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            bool flag;

            OleDbCommand oleDbCommand1 = new OleDbCommand("SELECT Count(*) FROM Acounts ", dBConnection);
            OleDbDataReader oleDbDataReader = oleDbCommand1.ExecuteReader();
            while (flag)
            {
                Count = oleDbDataReader.GetInt32(0);
                flag = oleDbDataReader.Read();
            }
            flag = Count != 1;
            if (!flag)
            {
                MessageBox.Show("\u062F\u0647 \u0627\u0644\u064A\u0648\u0632\u0631 \u0627\u0644\u0648\u062D\u064A\u062F ,\u0628\u0627\u0644\u0644\u0647 \u0639\u0644\u064A\u0643 \u0644\u0648 \u0645\u0633\u062D\u062A\u0647 \u0647\u062A\u062F\u062E\u0644 \u0628\u0623\u064A\u0647 ", "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("\u0647\u0644 \u0623\u0646\u062A \u0645\u062A\u0623\u0643\u062F \u0645\u0646 \u062E\u0630\u0641  " + UserNameCombo.Text + " \u0645\u0646 \u0642\u0627\u0639\u062F\u0647 \u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A", "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645\u064A\u0646", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                flag = !dialogResult.Equals(6);
                if (!flag)
                {
                    OleDbCommand oleDbCommand2 = new OleDbCommand();
                    oleDbCommand2.CommandText = "Delete FROM   Acounts Where password1 = '" + PasswordTXT.Text + "'";
                    oleDbCommand2.Connection = dBConnection;
                    try
                    {
                        oleDbCommand2.ExecuteNonQuery();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Error Occured In Deleting\n" + e1.Message.ToUpper().ToString(), "Cannot Delete ", MessageBoxButtons.OK);
                        goto label_1;
                    }
                    MessageBox.Show("\u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645   " + UserNameCombo.Text + " \u062A\u0645 \u062D\u0630\u0641\u0647", "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645\u064A\u0646 ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    refreshBTN.PerformClick();
                    newBTN.PerformClick();
                }
            }
        label_1:;
        }

        public void FillUserNameCombo()
        {
            OleDbCommand oleDbCommand = new OleDbCommand("SELECT name FROM EmployeeView ", dBConnection);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);
            bool flag = dataTable.Rows.Count != 0;
            if (!flag)
            {
            }
            else
            {
                int i = 0;
                while (flag)
                {
                    DataRow dataRow = dataTable.Rows[i];
                    UserNameCombo.Items.Add(dataRow[0].ToString());
                    i++;
                    flag = i < dataTable.Rows.Count;
                }
            }
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            UserNameCombo.Items.Clear();
            Accounts_Load(sender, e);
        }

        public void showData(DataTable dt)
        {
            DataRow dataRow = dt.Rows[rowPointer];
            UserNameCombo.Text = dataRow["Name"].ToString();
            PasswordTXT.Text = dataRow["Password1"].ToString();
            IDTXT.Text = dataRow["EMPID"].ToString();
        }

        private void ubdateBTN_Click(object sender, EventArgs e)
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

    } // class Accounts

}

