using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class absencePermetion : Form
    {

        private DateTimePicker arriveDate;
        private MyUtility Autility;
        internal Button BTNSave;
        internal Button BTNsearch;
        internal Button CloseBtn;
        private IContainer components;
        public OleDbConnection dBConnection;
        private DateTimePicker inidate;
        private Label label1;
        private Label lblAuName;
        private Label lblISBN;
        private Button mkprestBTN;
        private ComboBox nameTXT;

        public absencePermetion()
        {
            components = null;
            Autility = new MyUtility();
            InitializeComponent();
        }

        private void absencePermetion_Load(object sender, EventArgs e)
        {
            inidate.Value = DateTime.Today;
            arriveDate.Value = DateTime.Today;
            DataTable dataTable = new DataTable();
            Autility.RefreshMe();
            Autility.fillComboBox(nameTXT, "SELECT ST_Name FROM Students Where Dismissed = FALSE");
            nameTXT.Focus();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            bool flag = (DateTime.Compare(arriveDate.Value, inidate.Value) != 0) && (DateTime.Compare(arriveDate.Value, DateTime.Today) >= 0) && (DateTime.Compare(inidate.Value, DateTime.Today) <= 0) && (DateTime.Compare(inidate.Value, DateTime.Today) >= 0) && (DateTime.Compare(arriveDate.Value, inidate.Value) >= 0);
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627\u064A\u0645\u0643\u0646 \u0639\u0645\u0644 \u0647\u0630\u0627 \u0627\u0644\u0627\u0630\u0646 ,\u0627\u0644\u062A\u0648\u0627\u0631\u064A\u062E \u063A\u064A\u0631 \u0645\u0646\u0627\u0633\u0628\u0629", "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Autility.exQuery("UPDATE Students SET  AbsentOrNot = true , startDate = #" + inidate.Text + "# , ArriveDate = #" + arriveDate.Text + "#WHERE ST_NAME like '" + nameTXT.Text + "'");
                BTNSave.Enabled = false;
                mkprestBTN.Enabled = true;
                MessageBox.Show("\u062A\u0645 \u062A\u063A\u064A\u064A\u0628 \u0627\u0644\u0637\u0627\u0644\u0628  " + nameTXT.Text + "  \u0645\u0646 " + inidate.Text.ToString() + "  \u0627\u0644\u0649 " + arriveDate.Text.ToString(), "\u0627\u0630\u0646 \u0627\u0644\u063A\u064A\u0627\u0628 \u062A\u0645", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void EnableItIf(object sender, EventArgs e)
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(absencePermetion));
            inidate = new DateTimePicker();
            label1 = new Label();
            lblAuName = new Label();
            lblISBN = new Label();
            BTNSave = new Button();
            BTNsearch = new Button();
            CloseBtn = new Button();
            nameTXT = new ComboBox();
            arriveDate = new DateTimePicker();
            mkprestBTN = new Button();
            GroupBox groupBox = new GroupBox();
            SuspendLayout();
            groupBox.BackColor = SystemColors.Control;
            groupBox.FlatStyle = FlatStyle.Popup;
            groupBox.ForeColor = SystemColors.Control;
            groupBox.Location = new Point(117, 14);
            groupBox.Name = "groupBox1";
            groupBox.Size = new Size(2, 113);
            groupBox.TabIndex = 351;
            groupBox.TabStop = false;
            inidate.Format = DateTimePickerFormat.Custom;
            inidate.Location = new Point(239, 63);
            inidate.Name = "inidate";
            inidate.RightToLeft = RightToLeft.Yes;
            inidate.RightToLeftLayout = true;
            inidate.Size = new Size(84, 20);
            inidate.TabIndex = 42;
            inidate.Value = new DateTime(1980, 1, 1, 22, 50, 0, 0);
            label1.BackColor = Color.LightGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(329, 85);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 49;
            label1.Text = "\u062A\u0627\u0631\u064A\u062E \u0627\u0644\u0639\u0648\u062F\u0647";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            lblAuName.BackColor = Color.LightGray;
            lblAuName.BorderStyle = BorderStyle.FixedSingle;
            lblAuName.Location = new Point(329, 39);
            lblAuName.Name = "lblAuName";
            lblAuName.Size = new Size(93, 23);
            lblAuName.TabIndex = 45;
            lblAuName.Text = "\u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628";
            lblAuName.TextAlign = ContentAlignment.MiddleCenter;
            lblISBN.BackColor = Color.LightGray;
            lblISBN.BorderStyle = BorderStyle.FixedSingle;
            lblISBN.Location = new Point(329, 62);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(93, 23);
            lblISBN.TabIndex = 48;
            lblISBN.Text = "\u062A\u0627\u0631\u064A\u062E \u0627\u0644\u0633\u0641\u0631";
            lblISBN.TextAlign = ContentAlignment.MiddleCenter;
            BTNSave.BackColor = Color.Transparent;
            BTNSave.Enabled = false;
            BTNSave.Image = (Image)componentResourceManager.GetObject("BTNSave.Image");
            BTNSave.Location = new Point(9, 39);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(102, 25);
            BTNSave.TabIndex = 44;
            BTNSave.Text = " \u062D&\u0641\u0638";
            BTNSave.TextAlign = ContentAlignment.MiddleLeft;
            BTNSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNSave.UseVisualStyleBackColor = false;
            BTNSave.Click += new EventHandler(BTNSave_Click);
            BTNsearch.BackColor = Color.Transparent;
            BTNsearch.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BTNsearch.Image = (Image)componentResourceManager.GetObject("BTNsearch.Image");
            BTNsearch.ImageAlign = ContentAlignment.MiddleLeft;
            BTNsearch.Location = new Point(9, 14);
            BTNsearch.Name = "BTNsearch";
            BTNsearch.RightToLeft = RightToLeft.No;
            BTNsearch.Size = new Size(102, 25);
            BTNsearch.TabIndex = 46;
            BTNsearch.Text = "&\u0628\u062D\u062B \u0639\u0646 \u0637\u0627\u0644\u0628";
            BTNsearch.TextAlign = ContentAlignment.MiddleRight;
            BTNsearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTNsearch.UseVisualStyleBackColor = false;
            BTNsearch.Click += new EventHandler(BTNsearch_Click);
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            CloseBtn.Image = (Image)componentResourceManager.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(9, 97);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.RightToLeft = RightToLeft.No;
            CloseBtn.Size = new Size(102, 25);
            CloseBtn.TabIndex = 47;
            CloseBtn.Text = "&\u063A\u0644\u0642";
            CloseBtn.TextAlign = ContentAlignment.MiddleRight;
            CloseBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += new EventHandler(CloseBtn_Click);
            nameTXT.FormattingEnabled = true;
            nameTXT.Location = new Point(128, 39);
            nameTXT.Name = "nameTXT";
            nameTXT.RightToLeft = RightToLeft.Yes;
            nameTXT.Size = new Size(195, 21);
            nameTXT.TabIndex = 50;
            nameTXT.SelectedIndexChanged += new EventHandler(EnableItIf);
            arriveDate.Format = DateTimePickerFormat.Custom;
            arriveDate.Location = new Point(239, 86);
            arriveDate.Name = "arriveDate";
            arriveDate.RightToLeft = RightToLeft.Yes;
            arriveDate.RightToLeftLayout = true;
            arriveDate.Size = new Size(84, 20);
            arriveDate.TabIndex = 51;
            arriveDate.Value = new DateTime(1980, 1, 1, 22, 50, 0, 0);
            mkprestBTN.Enabled = false;
            mkprestBTN.Location = new Point(9, 64);
            mkprestBTN.Name = "mkprestBTN";
            mkprestBTN.Size = new Size(102, 25);
            mkprestBTN.TabIndex = 52;
            mkprestBTN.Text = "&\u062D\u0636\u0631 \u0647\u0630\u0627 \u0627\u0644\u0637\u0627\u0644\u0628";
            mkprestBTN.UseVisualStyleBackColor = true;
            mkprestBTN.Click += new EventHandler(button1_Click);
            AcceptButton = BTNSave;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(433, 147);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "absencePermetion";
            RightToLeft = RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\u0639\u0645\u0644 \u0623\u0630\u0646 \u063A\u064A\u0627\u0628";
            Load += new EventHandler(absencePermetion_Load);
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class absencePermetion

}

