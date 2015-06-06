using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class Students : System.Windows.Forms.Form
    {

        private System.Windows.Forms.TextBox addresseTXT;
        private System.Windows.Forms.LinkLabel BrowLLBL;
        internal System.Windows.Forms.Button BTNNext;
        internal System.Windows.Forms.Button BTNPrev;
        internal System.Windows.Forms.Button BTNSave;
        internal System.Windows.Forms.Button BTNsearch;
        internal System.Windows.Forms.Button CloseBtn;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label count;
        private string data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Data.OleDb.OleDbConnection dBConnection;
        private System.Windows.Forms.Button deleteBTN;
        private string facid;
        private System.Windows.Forms.ComboBox faculityCMBO;
        private System.Windows.Forms.ComboBox gradeCMBO;
        private string gradeID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAuName;
        private System.Windows.Forms.Label lblAuPhone;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPubName;
        private System.Windows.Forms.Label lblTitle;
        private System.Data.DataTable MYDataTable;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.TextBox nationalnumberTXT;
        private System.Windows.Forms.Button newBTN;
        private System.Windows.Forms.RadioButton newCHK;
        private System.Windows.Forms.RadioButton oldCHK;
        private string oldRommnumber;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox paidnotCHK;
        private string PhoneNumber;
        private System.Windows.Forms.TextBox phoneTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.ComboBox religionCMBO;
        private string rid;
        private string roomNumber;
        private bool roomNumberChanged;
        private System.Windows.Forms.TextBox roomTXT;
        public int rowPointer;
        private bool SendFromUpdate;
        internal System.Windows.Forms.Button ShowRptBtn;
        private string strBLOBFilePath;
        private System.Windows.Forms.ComboBox studyYearCMBO;
        private System.Windows.Forms.TextBox TotalTXT;
        private System.Windows.Forms.Button ubdateBTN;
        private System.Windows.Forms.ComboBox UnitTXT;
        private bool userHadBrowseImage;
        private Students__House_Control.MyUtility Utility;

        public Students()
        {
            rowPointer = -1;
            roomNumberChanged = false;
            userHadBrowseImage = false;
            Utility = new Students__House_Control.MyUtility();
            components = null;
            InitializeComponent();
        }

        private void BrowLLBL_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.gif)|*.gif";
            openFileDialog1.FileName = "";
            bool flag = openFileDialog1.ShowDialog(this) != System.Windows.Forms.DialogResult.Cancel;
            if (!flag)
            {
            }
            else
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                userHadBrowseImage = true;
                BrowLLBL.Visible = false;
            }
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BTNNext_Click(object sender, System.EventArgs e)
        {
            ShowRptBtn.Enabled = true;
            BTNSave.Enabled = false;
            ubdateBTN.Enabled = true;
            deleteBTN.Enabled = true;
            rowPointer++;
            bool flag = rowPointer < MYDataTable.Rows.Count;
            if (!flag)
            {
                System.Windows.Forms.MessageBox.Show("\u0644\u0627 \u064A\u0648\u062C\u062F \u0633\u062C\u0644\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0647", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                rowPointer--;
                BTNNext.Enabled = false;
            }
            else
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                showData(MYDataTable);
                flag = roomTXT.Text != "";
                if (!flag)
                    ShowRptBtn.Enabled = false;
                else
                    ShowRptBtn.Enabled = true;
                Cursor = System.Windows.Forms.Cursors.Arrow;
                BTNPrev.Enabled = true;
                BrowLLBL.Visible = false;
                oldRommnumber = roomTXT.Text;
            }
        }

        private void BTNPrev_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void BTNSave_Click(object sender, System.EventArgs e)
        {
            SendFromUpdate = false;
            bool flag = !CheckConstraints();
            if (!flag)
            {
                BrowLLBL.Visible = false;
                System.Data.OleDb.OleDbCommand oleDbCommand = new System.Data.OleDb.OleDbCommand();
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
                        System.Windows.Forms.MessageBox.Show("\u0627\u0644\u062D\u062C\u0631\u0647 " + s1 + " \u062A\u062D\u062A\u0648\u0649 \u0639\u0644\u0649 \u0627\u0631\u0628\u0639\u0647 \u0637\u0644\u0627\u0628 \u0627\u0636\u063A\u0637 \u0646\u0639\u0645 \u0644\u062A\u0631\u0627\u0647\u0645", "\u062E\u0637\u0623", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                        Students__House_Control.StudentsDistribution studentsDistribution = new Students__House_Control.StudentsDistribution();
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
                System.IO.FileStream fileStream = new System.IO.FileStream(strBLOBFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] bArr = new byte[fileStream.Length];
                fileStream.Read(bArr, 0, bArr.Length);
                fileStream.Close();
                System.Data.OleDb.OleDbParameter oleDbParameter = new System.Data.OleDb.OleDbParameter("@BLOBData", System.Data.OleDb.OleDbType.VarBinary, bArr.Length, System.Data.ParameterDirection.Input, false, 0, 0, null, System.Data.DataRowVersion.Current, bArr);
                Utility.exQuery(data, oleDbParameter);
                System.Windows.Forms.MessageBox.Show("\u062A\u0645 \u0627\u0636\u0627\u0641\u0629 \u0637\u0644\u0628 \u0628\u0646\u062C\u0627\u062D \u0627\u0644\u0649 \u0642\u0627\u0639\u062F\u0629 \u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A", "\u0627\u0636\u0627\u0641\u0629 \u0637\u0627\u0644\u0628", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                newBTN.PerformClick();
                Students_Load(sender, e);
            }
        }

        private void BTNsearch_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void button1_Click(object sender, System.EventArgs e)
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
            System.Data.OleDb.OleDbCommand oleDbCommand = new System.Data.OleDb.OleDbCommand();
            int i = 0;
            i = System.Int32.Parse(Utility.getID("SELECT COUNT(*) From Students Where R_Number = " + roomTXT.Text));
            return i < 4;
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void deleteBTN_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void nextBTN_Click(object sender, System.EventArgs e)
        {
            BTNSave.Enabled = false;
            ubdateBTN.Enabled = true;
            deleteBTN.Enabled = true;
            rowPointer++;
            bool flag = rowPointer < MYDataTable.Rows.Count;
            if (!flag)
            {
                System.Windows.Forms.MessageBox.Show("\u0644\u0627 \u064A\u0648\u062C\u062F \u0633\u062C\u0644\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0647", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                rowPointer--;
                BTNNext.Enabled = false;
            }
            else
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                showData(MYDataTable);
                Cursor = System.Windows.Forms.Cursors.Arrow;
                BTNPrev.Enabled = true;
                BrowLLBL.Visible = false;
            }
        }

        private void paidnotCHK_CheckedChanged(object sender, System.EventArgs e)
        {
            // trial
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            // trial
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            label6.Text = "\u062A\u0642\u062F\u064A\u0631 \u0627\u0644\u0637\u0627\u0644\u0628";
            TotalTXT.Visible = false;
            gradeCMBO.Visible = true;
        }

        private void refreshBTN_Click(object sender, System.EventArgs e)
        {
            Students_Load(sender, e);
        }

        private void SetFacStages(object sender, System.EventArgs e)
        {
            int i = 0;
            i = System.Int32.Parse(Utility.getID("Select FAC_Stages From Faculities Where FAC_NAME = '" + faculityCMBO.Text + "'"));
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

        public void showData(System.Data.DataTable dt)
        {
            // trial
        }

        public void showImage(System.Data.DataTable MYDataTable)
        {
            // trial
        }

        private void ShowRptBtn_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void Students_Load(object sender, System.EventArgs e)
        {
            // trial
        }

        private void ubdateBTN_Click(object sender, System.EventArgs e)
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

