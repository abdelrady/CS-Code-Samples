using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class pones : Form
    {

        internal Button BTNnext;
        internal Button BTNprev;
        internal Button BTNrefresh;
        private Button button1;
        internal Button button2;
        internal Button button3;
        private IContainer components;
        private Label Counttxt;
        private OleDbDataAdapter da;
        private DataTable daTable;
        public OleDbConnection dBConnection;
        public string dblocation;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private TextBox roomTXT;
        public int rowPointer;
        private OleDbCommand selectCmd;
        private string studentName;
        private CheckBox tk1;
        private CheckBox tk2;
        private CheckBox tk3;
        private CheckBox tk4;

        public pones()
        {
            rowPointer = 100;
            dblocation = "";
            components = null;
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void BTNnext_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void BTNprev_Click(object sender, EventArgs e)
        {
            rowPointer--;
            roomTXT.Text = rowPointer.ToString();
            bool flag = rowPointer >= 100;
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627 \u062A\u0648\u062C\u062F \u062D\u062C\u0631\u0627\u062A \u0627\u062E\u0631\u0649", "\u062A\u0646\u0628\u064A\u0629", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rowPointer++;
                BTNprev.Enabled = false;
                BTNnext.PerformClick();
                BTNprev.PerformClick();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                showData();
                Cursor = Cursors.Arrow;
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

        private void BTNrefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            residance_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void ClearGrid()
        {
            listBox1.Items.Clear();
            da.Dispose();
            daTable.Dispose();
            da = new OleDbDataAdapter();
            daTable = new DataTable();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(pones));
            label1 = new Label();
            tk1 = new CheckBox();
            tk3 = new CheckBox();
            tk4 = new CheckBox();
            tk2 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            roomTXT = new TextBox();
            label5 = new Label();
            Counttxt = new Label();
            button2 = new Button();
            BTNnext = new Button();
            BTNprev = new Button();
            label4 = new Label();
            BTNrefresh = new Button();
            button3 = new Button();
            SuspendLayout();
            label1.BackColor = Color.LightGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(339, 39);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "\u0631\u0642\u0645 \u0627\u0644\u062D\u062C\u0631\u0647";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            tk1.Appearance = Appearance.Button;
            tk1.BackColor = Color.LightYellow;
            tk1.Font = new Font("Tahoma", 6.0F, FontStyle.Bold);
            tk1.ForeColor = Color.Red;
            tk1.Location = new Point(228, 92);
            tk1.Name = "tk1";
            tk1.Size = new Size(36, 17);
            tk1.TabIndex = 4;
            tk1.Text = ">";
            tk1.TextAlign = ContentAlignment.TopCenter;
            tk1.UseVisualStyleBackColor = false;
            tk1.CheckedChanged += new EventHandler(tk1_CheckedChanged);
            tk3.Appearance = Appearance.Button;
            tk3.BackColor = Color.LightYellow;
            tk3.Font = new Font("Tahoma", 6.0F, FontStyle.Bold);
            tk3.ForeColor = Color.Red;
            tk3.Location = new Point(228, 124);
            tk3.Name = "tk3";
            tk3.Size = new Size(36, 17);
            tk3.TabIndex = 6;
            tk3.Text = ">";
            tk3.TextAlign = ContentAlignment.TopCenter;
            tk3.UseVisualStyleBackColor = false;
            tk3.CheckedChanged += new EventHandler(tk3_CheckedChanged);
            tk4.Appearance = Appearance.Button;
            tk4.BackColor = Color.LightYellow;
            tk4.Font = new Font("Tahoma", 6.0F, FontStyle.Bold);
            tk4.ForeColor = Color.Red;
            tk4.Location = new Point(228, 140);
            tk4.Name = "tk4";
            tk4.Size = new Size(36, 17);
            tk4.TabIndex = 7;
            tk4.Text = ">";
            tk4.TextAlign = ContentAlignment.TopCenter;
            tk4.UseVisualStyleBackColor = false;
            tk4.CheckedChanged += new EventHandler(tk4_CheckedChanged);
            tk2.Appearance = Appearance.Button;
            tk2.BackColor = Color.LightYellow;
            tk2.Font = new Font("Tahoma", 6.0F, FontStyle.Bold);
            tk2.ForeColor = Color.Red;
            tk2.Location = new Point(228, 108);
            tk2.Name = "tk2";
            tk2.Size = new Size(36, 17);
            tk2.TabIndex = 5;
            tk2.Text = ">";
            tk2.TextAlign = ContentAlignment.TopCenter;
            tk2.UseVisualStyleBackColor = false;
            tk2.CheckedChanged += new EventHandler(tk2_CheckedChanged);
            label2.BackColor = Color.LightGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(228, 68);
            label2.Name = "label2";
            label2.Size = new Size(197, 19);
            label2.TabIndex = 11;
            label2.Text = "\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0642\u064A\u0645\u064A\u0646 \u0641\u0649 \u0647\u0630\u0647 \u0627\u0644\u062D\u062C\u0631\u0629";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label3.BackColor = Color.LightGray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(156, 68);
            label3.Name = "label3";
            label3.Size = new Size(66, 89);
            label3.TabIndex = 10;
            label3.Text = "\u0644\u0627\u0639\u0637\u0627\u0621 \u0628\u0648\u0646\u0627\u062A \u0627\u0636\u063A\u0637  \u0627\u0645\u0627\u0645 \u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(156, 38);
            button1.Name = "button1";
            button1.Size = new Size(97, 22);
            button1.TabIndex = 0;
            button1.Text = "&\u062A\u0637\u0628\u064A\u0642";
            button1.Click += new EventHandler(button1_Click);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(267, 91);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(158, 69);
            listBox1.TabIndex = 12;
            roomTXT.Font = new Font("Tahoma", 8.0F, FontStyle.Bold);
            roomTXT.Location = new Point(253, 39);
            roomTXT.Name = "roomTXT";
            roomTXT.Size = new Size(86, 20);
            roomTXT.TabIndex = 0;
            roomTXT.Text = "100";
            roomTXT.TextAlign = HorizontalAlignment.Center;
            label5.BackColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(320, 167);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 16;
            label5.Text = "\u0639\u062F\u062F \u0627\u0644\u0628\u0648\u0646\u0627\u062A \u0627\u0644\u0645\u062A\u0628\u0642\u064A\u0647";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            Counttxt.BackColor = Color.White;
            Counttxt.BorderStyle = BorderStyle.Fixed3D;
            Counttxt.Font = new Font("Tahoma", 9.0F, FontStyle.Bold);
            Counttxt.ForeColor = Color.MediumBlue;
            Counttxt.Location = new Point(267, 167);
            Counttxt.Name = "Counttxt";
            Counttxt.Size = new Size(51, 20);
            Counttxt.TabIndex = 17;
            Counttxt.TextAlign = ContentAlignment.MiddleCenter;
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
            button2.Location = new Point(48, 126);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(63, 24);
            button2.TabIndex = 346;
            button2.Text = "&\u063A\u0644\u0642";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += new EventHandler(button2_Click);
            BTNnext.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNnext.Image = (Image)componentResourceManager.GetObject("BTNnext.Image");
            BTNnext.Location = new Point(82, 68);
            BTNnext.Name = "BTNnext";
            BTNnext.RightToLeft = RightToLeft.No;
            BTNnext.Size = new Size(63, 22);
            BTNnext.TabIndex = 345;
            BTNnext.Text = "&\u0627\u0644\u062A\u0627\u0644\u0649";
            BTNnext.TextAlign = ContentAlignment.MiddleRight;
            BTNnext.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTNnext.UseCompatibleTextRendering = true;
            BTNnext.UseVisualStyleBackColor = true;
            BTNnext.Click += new EventHandler(BTNnext_Click);
            BTNprev.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNprev.Image = (Image)componentResourceManager.GetObject("BTNprev.Image");
            BTNprev.Location = new Point(18, 68);
            BTNprev.Name = "BTNprev";
            BTNprev.RightToLeft = RightToLeft.No;
            BTNprev.Size = new Size(63, 22);
            BTNprev.TabIndex = 344;
            BTNprev.Text = "\u0627\u0644&\u0633\u0627\u0628\u0642";
            BTNprev.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNprev.UseCompatibleTextRendering = true;
            BTNprev.UseVisualStyleBackColor = true;
            BTNprev.Click += new EventHandler(BTNprev_Click);
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Tahoma", 10.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(413, 20);
            label4.TabIndex = 348;
            label4.Text = "\u0644\u0627\u062D\u0638:\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0645\u0633\u062F\u062F\u064A\u0646 \u0644\u0646 \u062A\u0638\u0647\u0631 \u0627\u0633\u0645\u0627\u0626\u0647\u0645 \u0641\u0649 \u0642\u0627\u0626\u0645\u0629 \u0627\u0644\u0627\u0633\u0645\u0627\u0621 \u0627\u0644\u0645\u0639\u0631\u0648\u0636\u0647 \r\n\r\n\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            BTNrefresh.BackColor = Color.Transparent;
            BTNrefresh.Cursor = Cursors.Arrow;
            BTNrefresh.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BTNrefresh.Image = (Image)componentResourceManager.GetObject("BTNrefresh.Image");
            BTNrefresh.ImageAlign = ContentAlignment.TopLeft;
            BTNrefresh.Location = new Point(48, 96);
            BTNrefresh.Name = "BTNrefresh";
            BTNrefresh.RightToLeft = RightToLeft.No;
            BTNrefresh.Size = new Size(63, 24);
            BTNrefresh.TabIndex = 349;
            BTNrefresh.Text = "\u062A&\u062D\u062F\u064A\u062B";
            BTNrefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNrefresh.UseVisualStyleBackColor = false;
            BTNrefresh.Click += new EventHandler(BTNrefresh_Click);
            button3.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)componentResourceManager.GetObject("button3.Image");
            button3.Location = new Point(15, 165);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(234, 24);
            button3.TabIndex = 350;
            button3.Text = "\u0639\u0631\u0636 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u064A\u0631 \u0645\u0633\u062F\u062F\u064A\u0646 \u062E\u0644\u0627\u0644 \u0647\u0630\u0627 \u0627\u0644\u0634\u0647\u0631";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = true;
            button3.Click += new EventHandler(button3_Click);
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(437, 195);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "pones";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\u062A\u0648\u0632\u064A\u0639 \u0628\u0648\u0646\u0627\u062A \u0627\u0644\u062A\u063A\u0630\u064A\u0647";
            Load += new EventHandler(residance_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        public void initilizeCount()
        {
            bool flag;

            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.CommandText = "SELECT Count(TakePone) FROM Students Where TakePone = False And Dismissed = FALSE and PayedOrNot = true and AbsentOrNot=false and R_Number is not null";
            oleDbCommand.Connection = dBConnection;
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (flag)
            {
                int i = oleDbDataReader.GetInt32(0);
                Counttxt.Text = i.ToString();
                flag = oleDbDataReader.Read();
            }
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            rowPointer++;
            roomTXT.Text = rowPointer.ToString();
            bool flag = rowPointer < 800;
            if (!flag)
            {
                MessageBox.Show("No More Rooms         ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                rowPointer--;
                BTNnext.Enabled = false;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                showData();
                Cursor = Cursors.Arrow;
                BTNprev.Enabled = true;
            }
        }

        private void residance_Load(object sender, EventArgs e)
        {
            // trial
        }

        public void showData()
        {
            // trial
        }

        private void tk1_CheckedChanged(object sender, EventArgs e)
        {
            // trial
        }

        private void tk2_CheckedChanged(object sender, EventArgs e)
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

        private void tk3_CheckedChanged(object sender, EventArgs e)
        {
            // trial
        }

        private void tk4_CheckedChanged(object sender, EventArgs e)
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
            OleDbCommand oleDbCommand = new OleDbCommand("UPdate Students set TakePone =True where ST_Name = '" + studentName + "'", dBConnection);
            oleDbCommand.ExecuteNonQuery();
            DateTime dateTime2 = DateTime.Today;
            DateTime dateTime1 = dateTime2.Date;
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

