using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class pones : System.Windows.Forms.Form
    {

        internal System.Windows.Forms.Button BTNnext;
        internal System.Windows.Forms.Button BTNprev;
        internal System.Windows.Forms.Button BTNrefresh;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label Counttxt;
        private System.Data.OleDb.OleDbDataAdapter da;
        private System.Data.DataTable daTable;
        public System.Data.OleDb.OleDbConnection dBConnection;
        public string dblocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox roomTXT;
        public int rowPointer;
        private System.Data.OleDb.OleDbCommand selectCmd;
        private string studentName;
        private System.Windows.Forms.CheckBox tk1;
        private System.Windows.Forms.CheckBox tk2;
        private System.Windows.Forms.CheckBox tk3;
        private System.Windows.Forms.CheckBox tk4;

        public pones()
        {
            rowPointer = 100;
            dblocation = "";
            components = null;
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void BTNnext_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void BTNprev_Click(object sender, System.EventArgs e)
        {
            rowPointer--;
            roomTXT.Text = rowPointer.ToString();
            bool flag = rowPointer >= 100;
            if (!flag)
            {
                System.Windows.Forms.MessageBox.Show("\u0644\u0627 \u062A\u0648\u062C\u062F \u062D\u062C\u0631\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0629", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                rowPointer++;
                BTNprev.Enabled = false;
                BTNnext.PerformClick();
                BTNprev.PerformClick();
            }
            else
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                showData();
                Cursor = System.Windows.Forms.Cursors.Arrow;
                BTNnext.Enabled = true;
                flag = tk1.Checked;
                if (!flag)
                    tk1.Enabled = true;
                flag = tk2.Checked;
                if (!flag)
                    tk2.Enabled = true;
                flag = tk3.Checked;
                if (!flag)
                    tk3.Enabled = true;
                flag = tk4.Checked;
                if (!flag)
                    tk4.Enabled = true;
            }
        }

        private void BTNrefresh_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            residance_Load(null, null);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Students__House_Control.Form2 form2 = new Students__House_Control.Form2();
            form2.ShowDialog(this);
        }

        private void ClearGrid()
        {
            listBox1.Items.Clear();
            da.Dispose();
            daTable.Dispose();
            da = new System.Data.OleDb.OleDbDataAdapter();
            daTable = new System.Data.DataTable();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.pones));
            label1 = new System.Windows.Forms.Label();
            tk1 = new System.Windows.Forms.CheckBox();
            tk3 = new System.Windows.Forms.CheckBox();
            tk4 = new System.Windows.Forms.CheckBox();
            tk2 = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            roomTXT = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            Counttxt = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            BTNnext = new System.Windows.Forms.Button();
            BTNprev = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            BTNrefresh = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            label1.BackColor = System.Drawing.Color.LightGray;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Location = new System.Drawing.Point(339, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "\u0631\u0642\u0645 \u0627\u0644\u062D\u062C\u0631\u0647";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tk1.Appearance = System.Windows.Forms.Appearance.Button;
            tk1.BackColor = System.Drawing.Color.LightYellow;
            tk1.Font = new System.Drawing.Font("Tahoma", 6.0F, System.Drawing.FontStyle.Bold);
            tk1.ForeColor = System.Drawing.Color.Red;
            tk1.Location = new System.Drawing.Point(228, 92);
            tk1.Name = "tk1";
            tk1.Size = new System.Drawing.Size(36, 17);
            tk1.TabIndex = 4;
            tk1.Text = ">";
            tk1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            tk1.UseVisualStyleBackColor = false;
            tk1.CheckedChanged += new System.EventHandler(tk1_CheckedChanged);
            tk3.Appearance = System.Windows.Forms.Appearance.Button;
            tk3.BackColor = System.Drawing.Color.LightYellow;
            tk3.Font = new System.Drawing.Font("Tahoma", 6.0F, System.Drawing.FontStyle.Bold);
            tk3.ForeColor = System.Drawing.Color.Red;
            tk3.Location = new System.Drawing.Point(228, 124);
            tk3.Name = "tk3";
            tk3.Size = new System.Drawing.Size(36, 17);
            tk3.TabIndex = 6;
            tk3.Text = ">";
            tk3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            tk3.UseVisualStyleBackColor = false;
            tk3.CheckedChanged += new System.EventHandler(tk3_CheckedChanged);
            tk4.Appearance = System.Windows.Forms.Appearance.Button;
            tk4.BackColor = System.Drawing.Color.LightYellow;
            tk4.Font = new System.Drawing.Font("Tahoma", 6.0F, System.Drawing.FontStyle.Bold);
            tk4.ForeColor = System.Drawing.Color.Red;
            tk4.Location = new System.Drawing.Point(228, 140);
            tk4.Name = "tk4";
            tk4.Size = new System.Drawing.Size(36, 17);
            tk4.TabIndex = 7;
            tk4.Text = ">";
            tk4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            tk4.UseVisualStyleBackColor = false;
            tk4.CheckedChanged += new System.EventHandler(tk4_CheckedChanged);
            tk2.Appearance = System.Windows.Forms.Appearance.Button;
            tk2.BackColor = System.Drawing.Color.LightYellow;
            tk2.Font = new System.Drawing.Font("Tahoma", 6.0F, System.Drawing.FontStyle.Bold);
            tk2.ForeColor = System.Drawing.Color.Red;
            tk2.Location = new System.Drawing.Point(228, 108);
            tk2.Name = "tk2";
            tk2.Size = new System.Drawing.Size(36, 17);
            tk2.TabIndex = 5;
            tk2.Text = ">";
            tk2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            tk2.UseVisualStyleBackColor = false;
            tk2.CheckedChanged += new System.EventHandler(tk2_CheckedChanged);
            label2.BackColor = System.Drawing.Color.LightGray;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Location = new System.Drawing.Point(228, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 19);
            label2.TabIndex = 11;
            label2.Text = "\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0642\u064A\u0645\u064A\u0646 \u0641\u0649 \u0647\u0630\u0647 \u0627\u0644\u062D\u062C\u0631\u0629";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label3.BackColor = System.Drawing.Color.LightGray;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Location = new System.Drawing.Point(156, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 89);
            label3.TabIndex = 10;
            label3.Text = "\u0644\u0627\u0639\u0637\u0627\u0621 \u0628\u0648\u0646\u0627\u062A \u0627\u0636\u063A\u0637  \u0627\u0645\u0627\u0645 \u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(156, 38);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(97, 22);
            button1.TabIndex = 0;
            button1.Text = "&\u062A\u0637\u0628\u064A\u0642";
            button1.Click += new System.EventHandler(button1_Click);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(267, 91);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            listBox1.Size = new System.Drawing.Size(158, 69);
            listBox1.TabIndex = 12;
            roomTXT.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
            roomTXT.Location = new System.Drawing.Point(253, 39);
            roomTXT.Name = "roomTXT";
            roomTXT.Size = new System.Drawing.Size(86, 20);
            roomTXT.TabIndex = 0;
            roomTXT.Text = "100";
            roomTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            label5.Location = new System.Drawing.Point(320, 167);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 20);
            label5.TabIndex = 16;
            label5.Text = "\u0639\u062F\u062F \u0627\u0644\u0628\u0648\u0646\u0627\u062A \u0627\u0644\u0645\u062A\u0628\u0642\u064A\u0647";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Counttxt.BackColor = System.Drawing.Color.White;
            Counttxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Counttxt.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Bold);
            Counttxt.ForeColor = System.Drawing.Color.MediumBlue;
            Counttxt.Location = new System.Drawing.Point(267, 167);
            Counttxt.Name = "Counttxt";
            Counttxt.Size = new System.Drawing.Size(51, 20);
            Counttxt.TabIndex = 17;
            Counttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            button2.Image = (System.Drawing.Image)componentResourceManager.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(48, 126);
            button2.Name = "button2";
            button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button2.Size = new System.Drawing.Size(63, 24);
            button2.TabIndex = 346;
            button2.Text = "&\u063A\u0644\u0642";
            button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(button2_Click);
            BTNnext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BTNnext.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNnext.Image");
            BTNnext.Location = new System.Drawing.Point(82, 68);
            BTNnext.Name = "BTNnext";
            BTNnext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            BTNnext.Size = new System.Drawing.Size(63, 22);
            BTNnext.TabIndex = 345;
            BTNnext.Text = "&\u0627\u0644\u062A\u0627\u0644\u0649";
            BTNnext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTNnext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            BTNnext.UseCompatibleTextRendering = true;
            BTNnext.UseVisualStyleBackColor = true;
            BTNnext.Click += new System.EventHandler(BTNnext_Click);
            BTNprev.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BTNprev.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNprev.Image");
            BTNprev.Location = new System.Drawing.Point(18, 68);
            BTNprev.Name = "BTNprev";
            BTNprev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            BTNprev.Size = new System.Drawing.Size(63, 22);
            BTNprev.TabIndex = 344;
            BTNprev.Text = "\u0627\u0644&\u0633\u0627\u0628\u0642";
            BTNprev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTNprev.UseCompatibleTextRendering = true;
            BTNprev.UseVisualStyleBackColor = true;
            BTNprev.Click += new System.EventHandler(BTNprev_Click);
            label4.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label4.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(12, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(413, 20);
            label4.TabIndex = 348;
            label4.Text = "\u0644\u0627\u062D\u0638:\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0645\u0633\u062F\u062F\u064A\u0646 \u0644\u0646 \u062A\u0638\u0647\u0631 \u0627\u0633\u0645\u0627\u0626\u0647\u0645 \u0641\u0649 \u0642\u0627\u0626\u0645\u0629 \u0627\u0644\u0627\u0633\u0645\u0627\u0621 \u0627\u0644\u0645\u0639\u0631\u0648\u0636\u0647 \r\n\r\n\r\n";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            BTNrefresh.BackColor = System.Drawing.Color.Transparent;
            BTNrefresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            BTNrefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            BTNrefresh.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNrefresh.Image");
            BTNrefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            BTNrefresh.Location = new System.Drawing.Point(48, 96);
            BTNrefresh.Name = "BTNrefresh";
            BTNrefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            BTNrefresh.Size = new System.Drawing.Size(63, 24);
            BTNrefresh.TabIndex = 349;
            BTNrefresh.Text = "\u062A&\u062D\u062F\u064A\u062B";
            BTNrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTNrefresh.UseVisualStyleBackColor = false;
            BTNrefresh.Click += new System.EventHandler(BTNrefresh_Click);
            button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button3.Image = (System.Drawing.Image)componentResourceManager.GetObject("button3.Image");
            button3.Location = new System.Drawing.Point(15, 165);
            button3.Name = "button3";
            button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button3.Size = new System.Drawing.Size(234, 24);
            button3.TabIndex = 350;
            button3.Text = "\u0639\u0631\u0636 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0645\u0633\u062F\u062F\u064A\u0646 \u062E\u0644\u0627\u0644 \u0647\u0630\u0627 \u0627\u0644\u0634\u0647\u0631";
            button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);
            AcceptButton = button1;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(437, 195);
            Controls.Add(button3);
            Controls.Add(BTNrefresh);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(BTNnext);
            Controls.Add(BTNprev);
            Controls.Add(Counttxt);
            Controls.Add(label5);
            Controls.Add(roomTXT);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tk2);
            Controls.Add(tk4);
            Controls.Add(tk3);
            Controls.Add(tk1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "pones";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "\u062A\u0648\u0632\u064A\u0639 \u0628\u0648\u0646\u0627\u062A \u0627\u0644\u062A\u063A\u0630\u064A\u0647";
            Load += new System.EventHandler(residance_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        public void initilizeCount()
        {
            bool flag;

            System.Data.OleDb.OleDbCommand oleDbCommand = new System.Data.OleDb.OleDbCommand();
            oleDbCommand.CommandText = "SELECT Count(TakePone) FROM Students Where TakePone = False And Dismissed = FALSE and PayedOrNot = true and AbsentOrNot=false and R_Number is not null";
            oleDbCommand.Connection = dBConnection;
            System.Data.OleDb.OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (flag)
            {
                int i = oleDbDataReader.GetInt32(0);
                Counttxt.Text = i.ToString();
                flag = oleDbDataReader.Read();
            }
        }

        private void nextBTN_Click(object sender, System.EventArgs e)
        {
            rowPointer++;
            roomTXT.Text = rowPointer.ToString();
            bool flag = rowPointer < 800;
            if (!flag)
            {
                System.Windows.Forms.MessageBox.Show("No More Rooms         ", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                rowPointer--;
                BTNnext.Enabled = false;
            }
            else
            {
                Cursor = System.Windows.Forms.Cursors.WaitCursor;
                showData();
                Cursor = System.Windows.Forms.Cursors.Arrow;
                BTNprev.Enabled = true;
            }
        }

        private void residance_Load(object sender, System.EventArgs e)
        {
            // trial
        }

        public void showData()
        {
            // trial
        }

        private void tk1_CheckedChanged(object sender, System.EventArgs e)
        {
            // trial
        }

        private void tk2_CheckedChanged(object sender, System.EventArgs e)
        {
            tk2.Enabled = false;
            bool flag = tk2.Checked;
            if (!flag)
            {
            }
            else
            {
                studentName = listBox1.Items[1].ToString();
                UPdatePonesByGivingItToStudents();
            }
        }

        private void tk3_CheckedChanged(object sender, System.EventArgs e)
        {
            // trial
        }

        private void tk4_CheckedChanged(object sender, System.EventArgs e)
        {
            tk4.Enabled = false;
            bool flag = tk4.Checked;
            if (!flag)
            {
            }
            else
            {
                studentName = listBox1.Items[3].ToString();
                UPdatePonesByGivingItToStudents();
            }
        }

        public void UPdatePonesByGivingItToStudents()
        {
            System.Data.OleDb.OleDbCommand oleDbCommand = new System.Data.OleDb.OleDbCommand("UPdate Students set TakePone =True where ST_Name = '" + studentName + "'", dBConnection);
            oleDbCommand.ExecuteNonQuery();
            System.DateTime dateTime2 = System.DateTime.Today;
            System.DateTime dateTime1 = dateTime2.Date;
            dateTime2 = dateTime1.Date;
            string s = dateTime2.ToString();
            oleDbCommand.CommandText = "UPdate Students set TodayPone ='" + s + "' where ST_Name = '" + studentName + "'";
            oleDbCommand.ExecuteNonQuery();
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class pones

}

