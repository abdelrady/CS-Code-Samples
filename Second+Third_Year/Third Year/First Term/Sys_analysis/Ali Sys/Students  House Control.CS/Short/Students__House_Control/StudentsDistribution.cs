using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class StudentsDistribution : Form
    {

        public Button ApplayBtn;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button B4;
        internal Button BTNrefresh;
        internal Button BTNSave;
        internal Button button1;
        private IContainer components;
        public OleDbConnection dBConnection;
        private MyUtility Dutility;
        private Label label1;
        private Label label12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label lblAuName;
        private ListBox listBox1;
        internal Button nextBTN;
        internal Button prevBTN;
        public TextBox roomTXT;
        public int rowPointer;
        private TextBox ST1;
        private TextBox ST2;
        private TextBox ST3;
        private TextBox ST4;

        public StudentsDistribution()
        {
            components = null;
            rowPointer = 100;
            Dutility = new MyUtility();
            InitializeComponent();
        }

        private void ApplayBtn_Click(object sender, EventArgs e)
        {
            rowPointer = Int32.Parse(roomTXT.Text);
            ST1.Text = "";
            ST2.Text = "";
            ST3.Text = "";
            ST4.Text = "";
            DataTable dataTable = new DataTable();
            dataTable = Dutility.getDataTable("Select ST_NAME FROM students Where R_NUMBER = " + roomTXT.Text + "and Dismissed = false ");
            bool flag = dataTable.Rows.Count != 0;
            if (!flag)
            {
            }
            else
            {
                DataRow dataRow = dataTable.Rows[0];
                flag = dataTable.Rows.Count != 1;
                if (!flag)
                    ST1.Text = dataRow[0].ToString();
                flag = dataTable.Rows.Count != 2;
                if (!flag)
                {
                    dataRow = dataTable.Rows[0];
                    ST1.Text = dataRow[0].ToString();
                    dataRow = dataTable.Rows[1];
                    ST2.Text = dataRow[0].ToString();
                }
                flag = dataTable.Rows.Count != 3;
                if (!flag)
                {
                    dataRow = dataTable.Rows[0];
                    ST1.Text = dataRow[0].ToString();
                    dataRow = dataTable.Rows[1];
                    ST2.Text = dataRow[0].ToString();
                    dataRow = dataTable.Rows[2];
                    ST3.Text = dataRow[0].ToString();
                }
                flag = dataTable.Rows.Count != 4;
                if (!flag)
                {
                    dataRow = dataTable.Rows[0];
                    ST1.Text = dataRow[0].ToString();
                    dataRow = dataTable.Rows[1];
                    ST2.Text = dataRow[0].ToString();
                    dataRow = dataTable.Rows[2];
                    ST3.Text = dataRow[0].ToString();
                    dataRow = dataTable.Rows[3];
                    ST4.Text = dataRow[0].ToString();
                }
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void B2_Click(object sender, EventArgs e)
        {
            bool flag = ST2.Text != "";
            if (!flag)
            {
            }
            else
            {
                listBox1.Items.Add(ST2.Text.ToString());
                string s = ST2.Text;
                Dutility.exQuery("UPDATE Students SET R_Number = NULL Where ST_Name = '" + s + "'");
                ST2.Text = "";
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void B4_Click(object sender, EventArgs e)
        {
            bool flag = ST4.Text != "";
            if (!flag)
            {
            }
            else
            {
                listBox1.Items.Add(ST4.Text.ToString());
                string s = ST4.Text;
                Dutility.exQuery("UPDATE Students SET R_Number = NULL Where ST_Name = '" + s + "'");
                ST4.Text = "";
            }
        }

        private void BeginToResident(object sender, EventArgs e)
        {
            bool flag = listBox1.SelectedIndex < 0;
            if (!flag)
            {
                flag = ST1.Text == "" || ST2.Text == "" || ST3.Text == "" || ST4.Text == "";
                if (!flag)
                {
                    MessageBox.Show("\u0644\u0627 \u064A\u0645\u0643\u0646 \u0644\u0627\u0643\u062B\u0631 \u0645\u0646 4 \u0637\u0644\u0627\u0628 \u0627\u0646 \u064A\u0643\u0648\u0646\u0648\u0627 \u0641\u0649 \u062D\u062C\u0631\u0647 \u0648\u0627\u062D\u062F\u0647 ", "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    flag = ST1.Text != "";
                    if (!flag)
                    {
                        ST1.Text = listBox1.SelectedItem.ToString();
                        listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                        BTNSave.Enabled = true;
                    }
                    else
                    {
                        flag = ST2.Text != "";
                        if (!flag)
                        {
                            ST2.Text = listBox1.SelectedItem.ToString();
                            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                            BTNSave.Enabled = true;
                        }
                        else
                        {
                            flag = ST3.Text != "";
                            if (!flag)
                            {
                                ST3.Text = listBox1.SelectedItem.ToString();
                                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                                BTNSave.Enabled = true;
                            }
                            else
                            {
                                ST4.Text = listBox1.SelectedItem.ToString();
                                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                                BTNSave.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void BTNrefresh_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool CheckRoomValid(string roomnumber)
        {
            // trial
            return false;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(StudentsDistribution));
            roomTXT = new TextBox();
            label1 = new Label();
            lblAuName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ST1 = new TextBox();
            ST3 = new TextBox();
            ST4 = new TextBox();
            ST2 = new TextBox();
            listBox1 = new ListBox();
            label9 = new Label();
            ApplayBtn = new Button();
            B1 = new Button();
            B4 = new Button();
            B3 = new Button();
            B2 = new Button();
            label12 = new Label();
            BTNrefresh = new Button();
            BTNSave = new Button();
            button1 = new Button();
            nextBTN = new Button();
            prevBTN = new Button();
            GroupBox groupBox = new GroupBox();
            SuspendLayout();
            groupBox.BackColor = SystemColors.Control;
            groupBox.FlatStyle = FlatStyle.Popup;
            groupBox.ForeColor = SystemColors.Control;
            groupBox.Location = new Point(477, 17);
            groupBox.Name = "groupBox1";
            groupBox.Size = new Size(2, 204);
            groupBox.TabIndex = 352;
            groupBox.TabStop = false;
            roomTXT.Font = new Font("Tahoma", 8.0F, FontStyle.Bold);
            roomTXT.ForeColor = Color.Blue;
            roomTXT.Location = new Point(322, 35);
            roomTXT.Name = "roomTXT";
            roomTXT.Size = new Size(58, 20);
            roomTXT.TabIndex = 6;
            roomTXT.Text = "100";
            roomTXT.TextAlign = HorizontalAlignment.Center;
            label1.BackColor = Color.LightGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 8.0F);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(382, 36);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 5;
            label1.Text = "\u0631\u0642\u0645 \u0627\u0644\u062D\u062C\u0631\u0647";
            label1.TextAlign = ContentAlignment.TopCenter;
            lblAuName.BackColor = Color.LightGray;
            lblAuName.BorderStyle = BorderStyle.FixedSingle;
            lblAuName.Location = new Point(382, 76);
            lblAuName.Name = "lblAuName";
            lblAuName.Size = new Size(88, 22);
            lblAuName.TabIndex = 40;
            lblAuName.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u0627\u0648\u0644";
            lblAuName.TextAlign = ContentAlignment.MiddleCenter;
            label2.BackColor = Color.LightGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(382, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 42;
            label2.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u062B\u0627\u0646\u0649";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label3.BackColor = Color.LightGray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(382, 145);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 44;
            label3.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u0631\u0627\u0628\u0639";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label4.BackColor = Color.LightGray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(382, 122);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 46;
            label4.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u062B\u0627\u0644\u062B";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            ST1.BackColor = SystemColors.InactiveCaptionText;
            ST1.Font = new Font("Tahoma", 9.0F);
            ST1.Location = new Point(214, 77);
            ST1.Name = "ST1";
            ST1.ReadOnly = true;
            ST1.RightToLeft = RightToLeft.No;
            ST1.Size = new Size(164, 22);
            ST1.TabIndex = 52;
            ST1.TextAlign = HorizontalAlignment.Right;
            ST3.BackColor = SystemColors.InactiveCaptionText;
            ST3.Font = new Font("Tahoma", 9.0F);
            ST3.Location = new Point(214, 123);
            ST3.Name = "ST3";
            ST3.ReadOnly = true;
            ST3.RightToLeft = RightToLeft.No;
            ST3.Size = new Size(164, 22);
            ST3.TabIndex = 53;
            ST3.TextAlign = HorizontalAlignment.Right;
            ST4.BackColor = SystemColors.InactiveCaptionText;
            ST4.Font = new Font("Tahoma", 9.0F);
            ST4.Location = new Point(214, 146);
            ST4.Name = "ST4";
            ST4.ReadOnly = true;
            ST4.RightToLeft = RightToLeft.No;
            ST4.Size = new Size(164, 22);
            ST4.TabIndex = 54;
            ST4.TextAlign = HorizontalAlignment.Right;
            ST2.BackColor = SystemColors.InactiveCaptionText;
            ST2.Font = new Font("Tahoma", 9.0F);
            ST2.Location = new Point(214, 100);
            ST2.Name = "ST2";
            ST2.ReadOnly = true;
            ST2.RightToLeft = RightToLeft.No;
            ST2.Size = new Size(164, 22);
            ST2.TabIndex = 55;
            ST2.TextAlign = HorizontalAlignment.Right;
            listBox1.Font = new Font("Tahoma", 8.0F);
            listBox1.ForeColor = Color.Red;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(7, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 186);
            listBox1.TabIndex = 57;
            listBox1.DoubleClick += new EventHandler(BeginToResident);
            label9.BackColor = Color.LightGray;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(7, 8);
            label9.Name = "label9";
            label9.Size = new Size(165, 19);
            label9.TabIndex = 58;
            label9.Text = "\u0643\u0644 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0633\u0627\u0643\u0646\u064A\u0646";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            ApplayBtn.FlatStyle = FlatStyle.System;
            ApplayBtn.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplayBtn.Location = new Point(219, 34);
            ApplayBtn.Name = "ApplayBtn";
            ApplayBtn.Size = new Size(100, 22);
            ApplayBtn.TabIndex = 60;
            ApplayBtn.Text = "&\u062A\u0637\u0628\u064A\u0642";
            ApplayBtn.Click += new EventHandler(ApplayBtn_Click);
            B1.FlatStyle = FlatStyle.System;
            B1.Font = new Font("Wingdings 3", 15.0F, FontStyle.Bold, GraphicsUnit.Point, 2);
            B1.ForeColor = SystemColors.ControlText;
            B1.Location = new Point(175, 76);
            B1.Name = "B1";
            B1.Size = new Size(38, 20);
            B1.TabIndex = 61;
            B1.Text = "f";
            B1.UseVisualStyleBackColor = true;
            B1.Click += new EventHandler(B1_Click);
            B4.FlatStyle = FlatStyle.System;
            B4.Font = new Font("Wingdings 3", 15.0F, FontStyle.Bold, GraphicsUnit.Point, 2);
            B4.ForeColor = SystemColors.ControlText;
            B4.Location = new Point(175, 146);
            B4.Name = "B4";
            B4.Size = new Size(38, 20);
            B4.TabIndex = 62;
            B4.Text = "f";
            B4.UseVisualStyleBackColor = true;
            B4.Click += new EventHandler(B4_Click);
            B3.FlatStyle = FlatStyle.System;
            B3.Font = new Font("Wingdings 3", 15.0F, FontStyle.Bold, GraphicsUnit.Point, 2);
            B3.ForeColor = SystemColors.ControlText;
            B3.Location = new Point(175, 122);
            B3.Name = "B3";
            B3.Size = new Size(38, 20);
            B3.TabIndex = 63;
            B3.Text = "f";
            B3.UseVisualStyleBackColor = true;
            B3.Click += new EventHandler(B3_Click);
            B2.FlatStyle = FlatStyle.System;
            B2.Font = new Font("Wingdings 3", 15.0F, FontStyle.Bold, GraphicsUnit.Point, 2);
            B2.ForeColor = SystemColors.ControlText;
            B2.Location = new Point(175, 99);
            B2.Name = "B2";
            B2.Size = new Size(38, 20);
            B2.TabIndex = 64;
            B2.Text = "f";
            B2.UseVisualStyleBackColor = true;
            B2.Click += new EventHandler(B2_Click);
            label12.BackColor = Color.FromArgb(224, 224, 224);
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.FlatStyle = FlatStyle.System;
            label12.Font = new Font("Tahoma", 8.0F);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(175, 8);
            label12.Name = "label12";
            label12.Size = new Size(295, 19);
            label12.TabIndex = 83;
            label12.Text = "     \u0645\u0646 \u062E\u0644\u0627\u0644 \u0647\u0630\u0627 \u0627\u0644\u0646\u0645\u0648\u0630\u062C \u064A\u0645\u0643\u0646\u0643 \u062A\u0633\u0643\u064A\u0646 \u0627\u0644\u0637\u0644\u0627\u0628          \r\n     \r\n\r\n\r\n";
            label12.TextAlign = ContentAlignment.BottomCenter;
            BTNrefresh.BackColor = Color.Transparent;
            BTNrefresh.Cursor = Cursors.Arrow;
            BTNrefresh.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BTNrefresh.Image = (Image)componentResourceManager.GetObject("BTNrefresh.Image");
            BTNrefresh.ImageAlign = ContentAlignment.TopLeft;
            BTNrefresh.Location = new Point(483, 68);
            BTNrefresh.Name = "BTNrefresh";
            BTNrefresh.RightToLeft = RightToLeft.No;
            BTNrefresh.Size = new Size(76, 27);
            BTNrefresh.TabIndex = 345;
            BTNrefresh.Text = "&\u062A\u062D\u062F\u064A\u062B";
            BTNrefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNrefresh.UseVisualStyleBackColor = false;
            BTNrefresh.Click += new EventHandler(BTNrefresh_Click);
            BTNSave.BackColor = Color.Transparent;
            BTNSave.Enabled = false;
            BTNSave.Image = (Image)componentResourceManager.GetObject("BTNSave.Image");
            BTNSave.ImageAlign = ContentAlignment.MiddleLeft;
            BTNSave.Location = new Point(483, 98);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(76, 27);
            BTNSave.TabIndex = 344;
            BTNSave.Text = "&\u062D\u0641\u0638";
            BTNSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNSave.UseVisualStyleBackColor = false;
            BTNSave.Click += new EventHandler(BTNSave_Click);
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
            button1.Location = new Point(483, 128);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(76, 27);
            button1.TabIndex = 343;
            button1.Text = "&\u063A\u0644\u0642";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click);
            nextBTN.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextBTN.Image = (Image)componentResourceManager.GetObject("nextBTN.Image");
            nextBTN.Location = new Point(310, 183);
            nextBTN.Name = "nextBTN";
            nextBTN.RightToLeft = RightToLeft.No;
            nextBTN.Size = new Size(67, 24);
            nextBTN.TabIndex = 66;
            nextBTN.Text = "&\u0627\u0644\u062A\u0627\u0644\u0649";
            nextBTN.TextAlign = ContentAlignment.MiddleRight;
            nextBTN.TextImageRelation = TextImageRelation.TextBeforeImage;
            nextBTN.UseCompatibleTextRendering = true;
            nextBTN.UseVisualStyleBackColor = true;
            nextBTN.Click += new EventHandler(nextBTN_Click_1);
            prevBTN.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prevBTN.Image = (Image)componentResourceManager.GetObject("prevBTN.Image");
            prevBTN.Location = new Point(243, 183);
            prevBTN.Name = "prevBTN";
            prevBTN.RightToLeft = RightToLeft.No;
            prevBTN.Size = new Size(67, 24);
            prevBTN.TabIndex = 65;
            prevBTN.Text = "\u0627\u0644&\u0633\u0627\u0628\u0642";
            prevBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            prevBTN.UseCompatibleTextRendering = true;
            prevBTN.UseVisualStyleBackColor = true;
            prevBTN.Click += new EventHandler(prevBTN_Click);
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(563, 225);
            Controls.Add(groupBox);
            Controls.Add(BTNrefresh);
            Controls.Add(BTNSave);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(nextBTN);
            Controls.Add(prevBTN);
            Controls.Add(B2);
            Controls.Add(B3);
            Controls.Add(B4);
            Controls.Add(B1);
            Controls.Add(ApplayBtn);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(ST2);
            Controls.Add(ST4);
            Controls.Add(ST3);
            Controls.Add(ST1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblAuName);
            Controls.Add(roomTXT);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentsDistribution";
            RightToLeft = RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0627\u0642\u0627\u0645\u0647";
            FormClosed += new FormClosedEventHandler(StudentsDistribution_FormClosed);
            Load += new EventHandler(StudentsDistribution_Load_1);
            ResumeLayout(false);
            PerformLayout();
        }

        private void nextBTN_Click_1(object sender, EventArgs e)
        {
            // trial
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            bool flag = ST1.Text == "" && ST2.Text == "" && ST3.Text == "" && ST4.Text == "";
            if (!flag)
                BTNSave.PerformClick();
            rowPointer--;
            roomTXT.Text = rowPointer.ToString();
            flag = rowPointer >= 100;
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627 \u062A\u0648\u062C\u062F \u062D\u062C\u0631\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0629", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rowPointer++;
                prevBTN.Enabled = false;
                nextBTN.PerformClick();
                prevBTN.PerformClick();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                ApplayBtn.PerformClick();
                Cursor = Cursors.Arrow;
                nextBTN.Enabled = true;
            }
        }

        private void StudentsDistribution_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dutility.RefreshMe();
        }

        private void StudentsDistribution_Load_1(object sender, EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class StudentsDistribution

}

