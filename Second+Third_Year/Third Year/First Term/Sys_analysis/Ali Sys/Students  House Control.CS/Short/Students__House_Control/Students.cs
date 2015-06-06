using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class Students : Form
    {

        private TextBox addresseTXT;
        private LinkLabel BrowLLBL;
        internal Button BTNNext;
        internal Button BTNPrev;
        internal Button BTNSave;
        internal Button BTNsearch;
        internal Button CloseBtn;
        private IContainer components;
        private Label count;
        private string data;
        private DateTimePicker dateTimePicker1;
        public OleDbConnection dBConnection;
        private Button deleteBTN;
        private string facid;
        private ComboBox faculityCMBO;
        private ComboBox gradeCMBO;
        private string gradeID;
        private GroupBox groupBox1;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblAuName;
        private Label lblAuPhone;
        private Label lblISBN;
        private Label lblPubName;
        private Label lblTitle;
        private DataTable MYDataTable;
        private TextBox nameTXT;
        private TextBox nationalnumberTXT;
        private Button newBTN;
        private RadioButton newCHK;
        private RadioButton oldCHK;
        private string oldRommnumber;
        private OpenFileDialog openFileDialog1;
        private CheckBox paidnotCHK;
        private string PhoneNumber;
        private TextBox phoneTXT;
        private PictureBox pictureBox1;
        private Button refreshBTN;
        private ComboBox religionCMBO;
        private string rid;
        private string roomNumber;
        private bool roomNumberChanged;
        private TextBox roomTXT;
        public int rowPointer;
        private bool SendFromUpdate;
        internal Button ShowRptBtn;
        private string strBLOBFilePath;
        private ComboBox studyYearCMBO;
        private TextBox TotalTXT;
        private Button ubdateBTN;
        private ComboBox UnitTXT;
        private bool userHadBrowseImage;
        private MyUtility Utility;

        public Students()
        {
            rowPointer = -1;
            roomNumberChanged = false;
            userHadBrowseImage = false;
            Utility = new MyUtility();
            components = null;
            InitializeComponent();
        }

        private void BrowLLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.gif)|*.gif";
            openFileDialog1.FileName = "";
            bool flag = openFileDialog1.ShowDialog(this) != DialogResult.Cancel;
            if (!flag)
            {
            }
            else
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                userHadBrowseImage = true;
                BrowLLBL.Visible = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            ShowRptBtn.Enabled = true;
            BTNSave.Enabled = false;
            ubdateBTN.Enabled = true;
            deleteBTN.Enabled = true;
            rowPointer++;
            bool flag = rowPointer < MYDataTable.Rows.Count;
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627 \u064A\u0648\u062C\u062F \u0633\u062C\u0644\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0647", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rowPointer--;
                BTNNext.Enabled = false;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                showData(MYDataTable);
                flag = roomTXT.Text != "";
                if (!flag)
                    ShowRptBtn.Enabled = false;
                else
                    ShowRptBtn.Enabled = true;
                Cursor = Cursors.Arrow;
                BTNPrev.Enabled = true;
                BrowLLBL.Visible = false;
                oldRommnumber = roomTXT.Text;
            }
        }

        private void BTNPrev_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            SendFromUpdate = false;
            bool flag = !CheckConstraints();
            if (!flag)
            {
                BrowLLBL.Visible = false;
                OleDbCommand oleDbCommand = new OleDbCommand();
                gradeID = Utility.getID("SELECT GradeID FROM Grades  WHERE Grade ='" + gradeCMBO.Text + "'");
                facid = Utility.getID("select FAC_ID from Faculities where FAC_NAME = '" + faculityCMBO.Text + "'");
                rid = Utility.getID("select ReligionID from Religion where Religion = '" + religionCMBO.Text + "'");
                string s1 = "NULL";
                flag = roomTXT.Text.ToString() == "";
                if (!flag)
                {
                    s1 = roomTXT.Text.ToString();
                    flag = CheckRoomValid(s1);
                    if (!flag)
                    {
                        MessageBox.Show("\u0627\u0644\u062D\u062C\u0631\u0647 " + s1 + " \u062A\u062D\u062A\u0648\u0649 \u0639\u0644\u0649 \u0627\u0631\u0628\u0639\u0647 \u0637\u0644\u0627\u0628 \u0627\u0636\u063A\u0637 \u0646\u0639\u0645 \u0644\u062A\u0631\u0627\u0647\u0645", "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        StudentsDistribution studentsDistribution = new StudentsDistribution();
                        studentsDistribution.dBConnection = dBConnection;
                        studentsDistribution.roomTXT.Text = s1;
                        studentsDistribution.ApplayBtn.PerformClick();
                        studentsDistribution.Show();
                        roomTXT.Text = "";
                        return;
                    }
                }
                string s2 = paidnotCHK.Checked ? "True" : "False";
                PhoneNumber = phoneTXT.Text;
                flag = !oldCHK.Checked;
                if (!flag)
                    data = "INSERT INTO STUDENTS (R_Number,UnitName,ST_LastFaculityGradeID,ST_Phone,ST_Name,ST_BirthDate,ST_StudyYear,ST_Addresse,[ST_National Number],ST_Fac_ID,ST_Image,ST_ReligionID,PayedOrNot,NewOrOld,Dismissed) VALUES(" + s1 + ",'" + UnitTXT.Text.ToString() + "'," + gradeID + ",'" + PhoneNumber + "','" + nameTXT.Text.ToString() + "',#" + dateTimePicker1.Text.ToString() + "#,'" + studyYearCMBO.Text.ToString() + "','" + addresseTXT.Text.ToString() + "','" + nationalnumberTXT.Text.ToString() + "'," + facid.ToString() + ",(@BLOBData)," + rid.ToString() + "," + s2.ToString() + ",'Old',FALSE)";
                else
                    data = "INSERT INTO STUDENTS (ST_StudyYear,ST_Fac_ID,R_Number,UnitName,SecondrySchoolGrade,ST_Phone,ST_Name,ST_BirthDate,ST_Addresse,[ST_National Number],ST_Image,ST_ReligionID,PayedOrNot,NewOrOld,Dismissed) VALUES('" + studyYearCMBO.Text.ToString() + "'," + facid.ToString() + "," + s1 + ",'" + UnitTXT.Text.ToString() + "'," + TotalTXT.Text.ToString() + ",'" + PhoneNumber + "','" + nameTXT.Text.ToString() + "',#" + dateTimePicker1.Text.ToString() + "#,'" + addresseTXT.Text.ToString() + "','" + nationalnumberTXT.Text.ToString() + "',(@BLOBData)," + rid.ToString() + "," + s2.ToString() + ",'New',FALSE)";
                strBLOBFilePath = openFileDialog1.FileName;
                pictureBox1.Image = null;
                FileStream fileStream = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                byte[] bArr = new byte[fileStream.Length];
                fileStream.Read(bArr, 0, bArr.Length);
                fileStream.Close();
                OleDbParameter oleDbParameter = new OleDbParameter("@BLOBData", OleDbType.VarBinary, bArr.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bArr);
                Utility.exQuery(data, oleDbParameter);
                MessageBox.Show("\u062A\u0645 \u0627\u0636\u0627\u0641\u0629 \u0637\u0644\u0628 \u0628\u0646\u062C\u0627\u062D \u0627\u0644\u0649 \u0642\u0627\u0639\u062F\u0629 \u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A", "\u0627\u0636\u0627\u0641\u0629 \u0637\u0627\u0644\u0628", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                newBTN.PerformClick();
                Students_Load(sender, e);
            }
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowRptBtn.Enabled = false;
            pictureBox1.Image = null;
            BrowLLBL.Visible = true;
            nationalnumberTXT.Text = "";
            roomTXT.Text = "";
            dateTimePicker1.Text = "";
            studyYearCMBO.Text = "";
            faculityCMBO.Text = "";
            phoneTXT.Text = "";
            addresseTXT.Text = "";
            gradeCMBO.Text = "";
            religionCMBO.Text = "";
            UnitTXT.Text = "";
            nameTXT.Text = "";
            TotalTXT.Text = "";
            dateTimePicker1.Text = "";
            nameTXT.Focus();
            BTNSave.Enabled = true;
            ubdateBTN.Enabled = false;
            deleteBTN.Enabled = false;
        }

        public bool CheckConstraints()
        {
            // trial
            return false;
        }

        public bool CheckRoomValid(string roomNumber)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            int i = 0;
            i = Int32.Parse(Utility.getID("SELECT COUNT(*) From Students Where R_Number = " + roomTXT.Text));
            return i < 4;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            BTNSave.Enabled = false;
            ubdateBTN.Enabled = true;
            deleteBTN.Enabled = true;
            rowPointer++;
            bool flag = rowPointer < MYDataTable.Rows.Count;
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627 \u064A\u0648\u062C\u062F \u0633\u062C\u0644\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0647", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rowPointer--;
                BTNNext.Enabled = false;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                showData(MYDataTable);
                Cursor = Cursors.Arrow;
                BTNPrev.Enabled = true;
                BrowLLBL.Visible = false;
            }
        }

        private void paidnotCHK_CheckedChanged(object sender, EventArgs e)
        {
            // trial
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // trial
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "\u062A\u0642\u062F\u064A\u0631 \u0627\u0644\u0637\u0627\u0644\u0628";
            TotalTXT.Visible = false;
            gradeCMBO.Visible = true;
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            Students_Load(sender, e);
        }

        private void SetFacStages(object sender, EventArgs e)
        {
            int i = 0;
            i = Int32.Parse(Utility.getID("Select FAC_Stages From Faculities Where FAC_NAME = '" + faculityCMBO.Text + "'"));
            bool flag = i != 5;
            if (!flag)
            {
                flag = studyYearCMBO.Items.Count != 5;
                if (!flag)
                {
                }
                else
                {
                    flag = studyYearCMBO.Items.Count != 6;
                    if (!flag)
                        studyYearCMBO.Items.RemoveAt(5);
                    else
                        studyYearCMBO.Items.Add("\u0627\u0644\u062E\u0627\u0645\u0633\u0647");
                }
            }
            else
            {
                flag = i != 6;
                if (!flag)
                {
                    flag = studyYearCMBO.Items.Count != 6;
                    if (!flag)
                    {
                    }
                    else
                    {
                        flag = studyYearCMBO.Items.Count != 5;
                        if (!flag)
                        {
                            studyYearCMBO.Items.Add("\u0627\u0644\u0633\u0627\u062F\u0633\u0647");
                        }
                        else
                        {
                            studyYearCMBO.Items.Add("\u0627\u0644\u062E\u0627\u0645\u0633\u0647");
                            studyYearCMBO.Items.Add("\u0627\u0644\u0633\u0627\u062F\u0633\u0647");
                        }
                    }
                }
                else
                {
                    flag = i != 4;
                    if (!flag)
                    {
                        flag = studyYearCMBO.Items.Count != 4;
                        if (!flag)
                        {
                        }
                        else
                        {
                            flag = studyYearCMBO.Items.Count != 5;
                            if (!flag)
                            {
                                studyYearCMBO.Items.RemoveAt(4);
                            }
                            else
                            {
                                flag = studyYearCMBO.Items.Count != 6;
                                if (!flag)
                                {
                                    studyYearCMBO.Items.RemoveAt(5);
                                    studyYearCMBO.Items.RemoveAt(4);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void showData(DataTable dt)
        {
            // trial
        }

        public void showImage(DataTable MYDataTable)
        {
            // trial
        }

        private void ShowRptBtn_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // trial
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

    } // class Students

}

