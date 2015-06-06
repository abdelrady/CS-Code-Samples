using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class absencePermetion : System.Windows.Forms.Form
    {

        private System.Windows.Forms.DateTimePicker arriveDate;
        private Students__House_Control.MyUtility Autility;
        internal System.Windows.Forms.Button BTNSave;
        internal System.Windows.Forms.Button BTNsearch;
        internal System.Windows.Forms.Button CloseBtn;
        private System.ComponentModel.IContainer components;
        public System.Data.OleDb.OleDbConnection dBConnection;
        private System.Windows.Forms.DateTimePicker inidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuName;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button mkprestBTN;
        private System.Windows.Forms.ComboBox nameTXT;

        public absencePermetion()
        {
            components = null;
            Autility = new Students__House_Control.MyUtility();
            InitializeComponent();
        }

        private void absencePermetion_Load(object sender, System.EventArgs e)
        {
            inidate.Value = System.DateTime.Today;
            arriveDate.Value = System.DateTime.Today;
            System.Data.DataTable dataTable = new System.Data.DataTable();
            Autility.RefreshMe();
            Autility.fillComboBox(nameTXT, "SELECT ST_Name FROM Students Where Dismissed = FALSE");
            nameTXT.Focus();
        }

        private void BTNSave_Click(object sender, System.EventArgs e)
        {
            bool flag = (System.DateTime.Compare(arriveDate.Value, inidate.Value) != 0) && (System.DateTime.Compare(arriveDate.Value, System.DateTime.Today) >= 0) && (System.DateTime.Compare(inidate.Value, System.DateTime.Today) <= 0) && (System.DateTime.Compare(inidate.Value, System.DateTime.Today) >= 0) && (System.DateTime.Compare(arriveDate.Value, inidate.Value) >= 0);
            if (!flag)
            {
                System.Windows.Forms.MessageBox.Show("\u0644\u0627\u064A\u0645\u0643\u0646 \u0639\u0645\u0644 \u0647\u0630\u0627 \u0627\u0644\u0627\u0630\u0646 ,\u0627\u0644\u062A\u0648\u0627\u0631\u064A\u062E \u063A\u064A\u0631 \u0645\u0646\u0627\u0633\u0628\u0629", "\u062E\u0637\u0623", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            else
            {
                Autility.exQuery("UPDATE Students SET  AbsentOrNot = true , startDate = #" + inidate.Text + "# , ArriveDate = #" + arriveDate.Text + "#WHERE ST_NAME like '" + nameTXT.Text + "'");
                BTNSave.Enabled = false;
                mkprestBTN.Enabled = true;
                System.Windows.Forms.MessageBox.Show("\u062A\u0645 \u062A\u063A\u064A\u064A\u0628 \u0627\u0644\u0637\u0627\u0644\u0628  " + nameTXT.Text + "  \u0645\u0646 " + inidate.Text.ToString() + "  \u0627\u0644\u0649 " + arriveDate.Text.ToString(), "\u0627\u0630\u0646 \u0627\u0644\u063A\u064A\u0627\u0628 \u062A\u0645", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            }
        }

        private void BTNsearch_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void EnableItIf(object sender, System.EventArgs e)
        {
            string s = Autility.getID("select AbsentOrNot from Students where ST_Name = '" + nameTXT.Text + "'");
            bool flag = s != "True";
            if (!flag)
            {
                mkprestBTN.Enabled = true;
                BTNSave.Enabled = false;
            }
            else
            {
                mkprestBTN.Enabled = false;
                BTNSave.Enabled = true;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.absencePermetion));
            inidate = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            lblAuName = new System.Windows.Forms.Label();
            lblISBN = new System.Windows.Forms.Label();
            BTNSave = new System.Windows.Forms.Button();
            BTNsearch = new System.Windows.Forms.Button();
            CloseBtn = new System.Windows.Forms.Button();
            nameTXT = new System.Windows.Forms.ComboBox();
            arriveDate = new System.Windows.Forms.DateTimePicker();
            mkprestBTN = new System.Windows.Forms.Button();
            System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
            SuspendLayout();
            groupBox.BackColor = System.Drawing.SystemColors.Control;
            groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox.ForeColor = System.Drawing.SystemColors.Control;
            groupBox.Location = new System.Drawing.Point(117, 14);
            groupBox.Name = "groupBox1";
            groupBox.Size = new System.Drawing.Size(2, 113);
            groupBox.TabIndex = 351;
            groupBox.TabStop = false;
            inidate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            inidate.Location = new System.Drawing.Point(239, 63);
            inidate.Name = "inidate";
            inidate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            inidate.RightToLeftLayout = true;
            inidate.Size = new System.Drawing.Size(84, 20);
            inidate.TabIndex = 42;
            inidate.Value = new System.DateTime(1980, 1, 1, 22, 50, 0, 0);
            label1.BackColor = System.Drawing.Color.LightGray;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Location = new System.Drawing.Point(329, 85);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 23);
            label1.TabIndex = 49;
            label1.Text = "\u062A\u0627\u0631\u064A\u062E \u0627\u0644\u0639\u0648\u062F\u0647";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblAuName.BackColor = System.Drawing.Color.LightGray;
            lblAuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblAuName.Location = new System.Drawing.Point(329, 39);
            lblAuName.Name = "lblAuName";
            lblAuName.Size = new System.Drawing.Size(93, 23);
            lblAuName.TabIndex = 45;
            lblAuName.Text = "\u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628";
            lblAuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblISBN.BackColor = System.Drawing.Color.LightGray;
            lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblISBN.Location = new System.Drawing.Point(329, 62);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new System.Drawing.Size(93, 23);
            lblISBN.TabIndex = 48;
            lblISBN.Text = "\u062A\u0627\u0631\u064A\u062E \u0627\u0644\u0633\u0641\u0631";
            lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            BTNSave.BackColor = System.Drawing.Color.Transparent;
            BTNSave.Enabled = false;
            BTNSave.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNSave.Image");
            BTNSave.Location = new System.Drawing.Point(9, 39);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new System.Drawing.Size(102, 25);
            BTNSave.TabIndex = 44;
            BTNSave.Text = " \u062D&\u0641\u0638";
            BTNSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BTNSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTNSave.UseVisualStyleBackColor = false;
            BTNSave.Click += new System.EventHandler(BTNSave_Click);
            BTNsearch.BackColor = System.Drawing.Color.Transparent;
            BTNsearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            BTNsearch.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNsearch.Image");
            BTNsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BTNsearch.Location = new System.Drawing.Point(9, 14);
            BTNsearch.Name = "BTNsearch";
            BTNsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            BTNsearch.Size = new System.Drawing.Size(102, 25);
            BTNsearch.TabIndex = 46;
            BTNsearch.Text = "&\u0628\u062D\u062B \u0639\u0646 \u0637\u0627\u0644\u0628";
            BTNsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTNsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            BTNsearch.UseVisualStyleBackColor = false;
            BTNsearch.Click += new System.EventHandler(BTNsearch_Click);
            CloseBtn.BackColor = System.Drawing.Color.Transparent;
            CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            CloseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            CloseBtn.Image = (System.Drawing.Image)componentResourceManager.GetObject("CloseBtn.Image");
            CloseBtn.Location = new System.Drawing.Point(9, 97);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CloseBtn.Size = new System.Drawing.Size(102, 25);
            CloseBtn.TabIndex = 47;
            CloseBtn.Text = "&\u063A\u0644\u0642";
            CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += new System.EventHandler(CloseBtn_Click);
            nameTXT.FormattingEnabled = true;
            nameTXT.Location = new System.Drawing.Point(128, 39);
            nameTXT.Name = "nameTXT";
            nameTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nameTXT.Size = new System.Drawing.Size(195, 21);
            nameTXT.TabIndex = 50;
            nameTXT.SelectedIndexChanged += new System.EventHandler(EnableItIf);
            arriveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            arriveDate.Location = new System.Drawing.Point(239, 86);
            arriveDate.Name = "arriveDate";
            arriveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            arriveDate.RightToLeftLayout = true;
            arriveDate.Size = new System.Drawing.Size(84, 20);
            arriveDate.TabIndex = 51;
            arriveDate.Value = new System.DateTime(1980, 1, 1, 22, 50, 0, 0);
            mkprestBTN.Enabled = false;
            mkprestBTN.Location = new System.Drawing.Point(9, 64);
            mkprestBTN.Name = "mkprestBTN";
            mkprestBTN.Size = new System.Drawing.Size(102, 25);
            mkprestBTN.TabIndex = 52;
            mkprestBTN.Text = "&\u062D\u0636\u0631 \u0647\u0630\u0627 \u0627\u0644\u0637\u0627\u0644\u0628";
            mkprestBTN.UseVisualStyleBackColor = true;
            mkprestBTN.Click += new System.EventHandler(button1_Click);
            AcceptButton = BTNSave;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(433, 147);
            Controls.Add(groupBox);
            Controls.Add(mkprestBTN);
            Controls.Add(arriveDate);
            Controls.Add(nameTXT);
            Controls.Add(BTNSave);
            Controls.Add(BTNsearch);
            Controls.Add(CloseBtn);
            Controls.Add(inidate);
            Controls.Add(label1);
            Controls.Add(lblAuName);
            Controls.Add(lblISBN);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "absencePermetion";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "\u0639\u0645\u0644 \u0623\u0630\u0646 \u063A\u064A\u0627\u0628";
            Load += new System.EventHandler(absencePermetion_Load);
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class absencePermetion

}

