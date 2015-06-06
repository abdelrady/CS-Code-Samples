using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class StudentsDistribution : System.Windows.Forms.Form
    {

        public System.Windows.Forms.Button ApplayBtn;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        internal System.Windows.Forms.Button BTNrefresh;
        internal System.Windows.Forms.Button BTNSave;
        internal System.Windows.Forms.Button button1;
        private System.ComponentModel.IContainer components;
        public System.Data.OleDb.OleDbConnection dBConnection;
        private Students__House_Control.MyUtility Dutility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAuName;
        private System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.Button nextBTN;
        internal System.Windows.Forms.Button prevBTN;
        public System.Windows.Forms.TextBox roomTXT;
        public int rowPointer;
        private System.Windows.Forms.TextBox ST1;
        private System.Windows.Forms.TextBox ST2;
        private System.Windows.Forms.TextBox ST3;
        private System.Windows.Forms.TextBox ST4;

        public StudentsDistribution()
        {
            components = null;
            rowPointer = 100;
            Dutility = new Students__House_Control.MyUtility();
            InitializeComponent();
        }

        private void ApplayBtn_Click(object sender, System.EventArgs e)
        {
            rowPointer = System.Int32.Parse(roomTXT.Text);
            ST1.Text = "";
            ST2.Text = "";
            ST3.Text = "";
            ST4.Text = "";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable = Dutility.getDataTable("Select ST_NAME FROM students Where R_NUMBER = " + roomTXT.Text + "and Dismissed = false ");
            bool flag = dataTable.Rows.Count != 0;
            if (!flag)
            {
            }
            else
            {
                System.Data.DataRow dataRow = dataTable.Rows[0];
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

        private void B1_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void B2_Click(object sender, System.EventArgs e)
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

        private void B3_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void B4_Click(object sender, System.EventArgs e)
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

        private void BeginToResident(object sender, System.EventArgs e)
        {
            bool flag = listBox1.SelectedIndex < 0;
            if (!flag)
            {
                flag = ST1.Text == "" || ST2.Text == "" || ST3.Text == "" || ST4.Text == "";
                if (!flag)
                {
                    System.Windows.Forms.MessageBox.Show("\u0644\u0627 \u064A\u0645\u0643\u0646 \u0644\u0627\u0643\u062B\u0631 \u0645\u0646 4 \u0637\u0644\u0627\u0628 \u0627\u0646 \u064A\u0643\u0648\u0646\u0648\u0627 \u0641\u0649 \u062D\u062C\u0631\u0647 \u0648\u0627\u062D\u062F\u0647 ", "\u062E\u0637\u0623", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
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

        private void BTNrefresh_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void BTNSave_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void button1_Click(object sender, System.EventArgs e)
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
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.StudentsDistribution));
            roomTXT = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lblAuName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ST1 = new System.Windows.Forms.TextBox();
            ST3 = new System.Windows.Forms.TextBox();
            ST4 = new System.Windows.Forms.TextBox();
            ST2 = new System.Windows.Forms.TextBox();
            listBox1 = new System.Windows.Forms.ListBox();
            label9 = new System.Windows.Forms.Label();
            ApplayBtn = new System.Windows.Forms.Button();
            B1 = new System.Windows.Forms.Button();
            B4 = new System.Windows.Forms.Button();
            B3 = new System.Windows.Forms.Button();
            B2 = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            BTNrefresh = new System.Windows.Forms.Button();
            BTNSave = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            nextBTN = new System.Windows.Forms.Button();
            prevBTN = new System.Windows.Forms.Button();
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            SuspendLayout();
            groupBox.BackColor = System.Drawing.SystemColors.Control;
            groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox.ForeColor = System.Drawing.SystemColors.Control;
            groupBox.Location = new System.Drawing.Point(477, 17);
            groupBox.Name = "groupBox1";
            groupBox.Size = new System.Drawing.Size(2, 204);
            groupBox.TabIndex = 352;
            groupBox.TabStop = false;
            roomTXT.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
            roomTXT.ForeColor = System.Drawing.Color.Blue;
            roomTXT.Location = new System.Drawing.Point(322, 35);
            roomTXT.Name = "roomTXT";
            roomTXT.Size = new System.Drawing.Size(58, 20);
            roomTXT.TabIndex = 6;
            roomTXT.Text = "100";
            roomTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            label1.BackColor = System.Drawing.Color.LightGray;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Tahoma", 8.0F);
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label1.Location = new System.Drawing.Point(382, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 19);
            label1.TabIndex = 5;
            label1.Text = "\u0631\u0642\u0645 \u0627\u0644\u062D\u062C\u0631\u0647";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblAuName.BackColor = System.Drawing.Color.LightGray;
            lblAuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblAuName.Location = new System.Drawing.Point(382, 76);
            lblAuName.Name = "lblAuName";
            lblAuName.Size = new System.Drawing.Size(88, 22);
            lblAuName.TabIndex = 40;
            lblAuName.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u0627\u0648\u0644";
            lblAuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label2.BackColor = System.Drawing.Color.LightGray;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Location = new System.Drawing.Point(382, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 22);
            label2.TabIndex = 42;
            label2.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u062B\u0627\u0646\u0649";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label3.BackColor = System.Drawing.Color.LightGray;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Location = new System.Drawing.Point(382, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 22);
            label3.TabIndex = 44;
            label3.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u0631\u0627\u0628\u0639";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.BackColor = System.Drawing.Color.LightGray;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Location = new System.Drawing.Point(382, 122);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 22);
            label4.TabIndex = 46;
            label4.Text = "\u0627\u0644\u0637\u0627\u0644\u0628 \u0627\u0644\u062B\u0627\u0644\u062B";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ST1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ST1.Font = new System.Drawing.Font("Tahoma", 9.0F);
            ST1.Location = new System.Drawing.Point(214, 77);
            ST1.Name = "ST1";
            ST1.ReadOnly = true;
            ST1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ST1.Size = new System.Drawing.Size(164, 22);
            ST1.TabIndex = 52;
            ST1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            ST3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ST3.Font = new System.Drawing.Font("Tahoma", 9.0F);
            ST3.Location = new System.Drawing.Point(214, 123);
            ST3.Name = "ST3";
            ST3.ReadOnly = true;
            ST3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ST3.Size = new System.Drawing.Size(164, 22);
            ST3.TabIndex = 53;
            ST3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            ST4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ST4.Font = new System.Drawing.Font("Tahoma", 9.0F);
            ST4.Location = new System.Drawing.Point(214, 146);
            ST4.Name = "ST4";
            ST4.ReadOnly = true;
            ST4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ST4.Size = new System.Drawing.Size(164, 22);
            ST4.TabIndex = 54;
            ST4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            ST2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ST2.Font = new System.Drawing.Font("Tahoma", 9.0F);
            ST2.Location = new System.Drawing.Point(214, 100);
            ST2.Name = "ST2";
            ST2.ReadOnly = true;
            ST2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ST2.Size = new System.Drawing.Size(164, 22);
            ST2.TabIndex = 55;
            ST2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            listBox1.Font = new System.Drawing.Font("Tahoma", 8.0F);
            listBox1.ForeColor = System.Drawing.Color.Red;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(7, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(165, 186);
            listBox1.TabIndex = 57;
            listBox1.DoubleClick += new System.EventHandler(BeginToResident);
            label9.BackColor = System.Drawing.Color.LightGray;
            label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label9.Location = new System.Drawing.Point(7, 8);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(165, 19);
            label9.TabIndex = 58;
            label9.Text = "\u0643\u0644 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0633\u0627\u0643\u0646\u064A\u0646";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ApplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ApplayBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ApplayBtn.Location = new System.Drawing.Point(219, 34);
            ApplayBtn.Name = "ApplayBtn";
            ApplayBtn.Size = new System.Drawing.Size(100, 22);
            ApplayBtn.TabIndex = 60;
            ApplayBtn.Text = "&\u062A\u0637\u0628\u064A\u0642";
            ApplayBtn.Click += new System.EventHandler(ApplayBtn_Click);
            B1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            B1.Font = new System.Drawing.Font("Wingdings 3", 15.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 2);
            B1.ForeColor = System.Drawing.SystemColors.ControlText;
            B1.Location = new System.Drawing.Point(175, 76);
            B1.Name = "B1";
            B1.Size = new System.Drawing.Size(38, 20);
            B1.TabIndex = 61;
            B1.Text = "f";
            B1.UseVisualStyleBackColor = true;
            B1.Click += new System.EventHandler(B1_Click);
            B4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            B4.Font = new System.Drawing.Font("Wingdings 3", 15.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 2);
            B4.ForeColor = System.Drawing.SystemColors.ControlText;
            B4.Location = new System.Drawing.Point(175, 146);
            B4.Name = "B4";
            B4.Size = new System.Drawing.Size(38, 20);
            B4.TabIndex = 62;
            B4.Text = "f";
            B4.UseVisualStyleBackColor = true;
            B4.Click += new System.EventHandler(B4_Click);
            B3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            B3.Font = new System.Drawing.Font("Wingdings 3", 15.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 2);
            B3.ForeColor = System.Drawing.SystemColors.ControlText;
            B3.Location = new System.Drawing.Point(175, 122);
            B3.Name = "B3";
            B3.Size = new System.Drawing.Size(38, 20);
            B3.TabIndex = 63;
            B3.Text = "f";
            B3.UseVisualStyleBackColor = true;
            B3.Click += new System.EventHandler(B3_Click);
            B2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            B2.Font = new System.Drawing.Font("Wingdings 3", 15.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 2);
            B2.ForeColor = System.Drawing.SystemColors.ControlText;
            B2.Location = new System.Drawing.Point(175, 99);
            B2.Name = "B2";
            B2.Size = new System.Drawing.Size(38, 20);
            B2.TabIndex = 64;
            B2.Text = "f";
            B2.UseVisualStyleBackColor = true;
            B2.Click += new System.EventHandler(B2_Click);
            label12.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label12.Font = new System.Drawing.Font("Tahoma", 8.0F);
            label12.ForeColor = System.Drawing.Color.Red;
            label12.Location = new System.Drawing.Point(175, 8);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(295, 19);
            label12.TabIndex = 83;
            label12.Text = "     \u0645\u0646 \u062E\u0644\u0627\u0644 \u0647\u0630\u0627 \u0627\u0644\u0646\u0645\u0648\u0630\u062C \u064A\u0645\u0643\u0646\u0643 \u062A\u0633\u0643\u064A\u0646 \u0627\u0644\u0637\u0644\u0627\u0628          \r\n     \r\n\r\n\r\n";
            label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            BTNrefresh.BackColor = System.Drawing.Color.Transparent;
            BTNrefresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            BTNrefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            BTNrefresh.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNrefresh.Image");
            BTNrefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            BTNrefresh.Location = new System.Drawing.Point(483, 68);
            BTNrefresh.Name = "BTNrefresh";
            BTNrefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            BTNrefresh.Size = new System.Drawing.Size(76, 27);
            BTNrefresh.TabIndex = 345;
            BTNrefresh.Text = "&\u062A\u062D\u062F\u064A\u062B";
            BTNrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTNrefresh.UseVisualStyleBackColor = false;
            BTNrefresh.Click += new System.EventHandler(BTNrefresh_Click);
            BTNSave.BackColor = System.Drawing.Color.Transparent;
            BTNSave.Enabled = false;
            BTNSave.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNSave.Image");
            BTNSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BTNSave.Location = new System.Drawing.Point(483, 98);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new System.Drawing.Size(76, 27);
            BTNSave.TabIndex = 344;
            BTNSave.Text = "&\u062D\u0641\u0638";
            BTNSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTNSave.UseVisualStyleBackColor = false;
            BTNSave.Click += new System.EventHandler(BTNSave_Click);
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            button1.Image = (System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(483, 128);
            button1.Name = "button1";
            button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button1.Size = new System.Drawing.Size(76, 27);
            button1.TabIndex = 343;
            button1.Text = "&\u063A\u0644\u0642";
            button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(button1_Click);
            nextBTN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nextBTN.Image = (System.Drawing.Image)componentResourceManager.GetObject("nextBTN.Image");
            nextBTN.Location = new System.Drawing.Point(310, 183);
            nextBTN.Name = "nextBTN";
            nextBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nextBTN.Size = new System.Drawing.Size(67, 24);
            nextBTN.TabIndex = 66;
            nextBTN.Text = "&\u0627\u0644\u062A\u0627\u0644\u0649";
            nextBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            nextBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            nextBTN.UseCompatibleTextRendering = true;
            nextBTN.UseVisualStyleBackColor = true;
            nextBTN.Click += new System.EventHandler(nextBTN_Click_1);
            prevBTN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prevBTN.Image = (System.Drawing.Image)componentResourceManager.GetObject("prevBTN.Image");
            prevBTN.Location = new System.Drawing.Point(243, 183);
            prevBTN.Name = "prevBTN";
            prevBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            prevBTN.Size = new System.Drawing.Size(67, 24);
            prevBTN.TabIndex = 65;
            prevBTN.Text = "\u0627\u0644&\u0633\u0627\u0628\u0642";
            prevBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            prevBTN.UseCompatibleTextRendering = true;
            prevBTN.UseVisualStyleBackColor = true;
            prevBTN.Click += new System.EventHandler(prevBTN_Click);
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(563, 225);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentsDistribution";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0627\u0642\u0627\u0645\u0647";
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(StudentsDistribution_FormClosed);
            Load += new System.EventHandler(StudentsDistribution_Load_1);
            ResumeLayout(false);
            PerformLayout();
        }

        private void nextBTN_Click_1(object sender, System.EventArgs e)
        {
            // trial
        }

        private void prevBTN_Click(object sender, System.EventArgs e)
        {
            bool flag = ST1.Text == "" && ST2.Text == "" && ST3.Text == "" && ST4.Text == "";
            if (!flag)
                BTNSave.PerformClick();
            rowPointer--;
            roomTXT.Text = rowPointer.ToString();
            flag = rowPointer >= 100;
            if (!flag)
            {
                System.Windows.Forms.MessageBox.Show("\u0644\u0627 \u062A\u0648\u062C\u062F \u062D\u062C\u0631\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0629", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                rowPointer++;
                prevBTN.Enabled = false;
                nextBTN.PerformClick();
                prevBTN.PerformClick();
            }
            else
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                ApplayBtn.PerformClick();
                Cursor = System.Windows.Forms.Cursors.Arrow;
                nextBTN.Enabled = true;
            }
        }

        private void StudentsDistribution_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Dutility.RefreshMe();
        }

        private void StudentsDistribution_Load_1(object sender, System.EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class StudentsDistribution

}

