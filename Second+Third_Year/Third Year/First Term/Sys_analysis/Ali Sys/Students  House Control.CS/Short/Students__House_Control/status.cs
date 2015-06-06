using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class status : Form
    {

        public Button button1;
        internal Button CloseBtn;
        private IContainer components;
        public OleDbConnection dBConnection;
        private Label label1;
        private Label label12;
        internal DataGrid mYDtaGrid;
        public Button refreshBTN;
        public MyUtility Sutility;

        public status()
        {
            components = null;
            Sutility = new MyUtility();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            absencePermetion absencePermetion = new absencePermetion();
            bool flag = !Sutility.CheckAlreadyOpened(MdiParent, absencePermetion.Text);
            if (!flag)
            {
            }
            else
            {
                absencePermetion.MdiParent = MdiParent;
                absencePermetion.Show();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(status));
            CloseBtn = new Button();
            refreshBTN = new Button();
            label12 = new Label();
            mYDtaGrid = new DataGrid();
            button1 = new Button();
            label1 = new Label();
            mYDtaGrid.BeginInit();
            SuspendLayout();
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            CloseBtn.Image = (Image)componentResourceManager.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(355, 215);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.RightToLeft = RightToLeft.No;
            CloseBtn.Size = new Size(86, 29);
            CloseBtn.TabIndex = 23;
            CloseBtn.Text = "&\u063A\u0644\u0642";
            CloseBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += new EventHandler(CloseBtn_Click);
            refreshBTN.BackColor = Color.Transparent;
            refreshBTN.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBTN.Location = new Point(355, 59);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(86, 29);
            refreshBTN.TabIndex = 24;
            refreshBTN.Text = "&\u062A\u062D\u062F\u064A\u062B";
            refreshBTN.UseVisualStyleBackColor = false;
            refreshBTN.Click += new EventHandler(refreshBTN_Click);
            label12.BackColor = Color.FromArgb(224, 224, 224);
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Tahoma", 8.0F);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(6, 6);
            label12.Name = "label12";
            label12.Size = new Size(343, 19);
            label12.TabIndex = 83;
            label12.Text = "\u0643\u0644 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u0627\u0626\u0628\u0648\u0646\r\n\r\n\r\n";
            label12.TextAlign = ContentAlignment.TopCenter;
            mYDtaGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            mYDtaGrid.BorderStyle = BorderStyle.FixedSingle;
            mYDtaGrid.CaptionVisible = false;
            mYDtaGrid.DataMember = "";
            mYDtaGrid.HeaderForeColor = SystemColors.ControlText;
            mYDtaGrid.Location = new Point(6, 28);
            mYDtaGrid.Name = "mYDtaGrid";
            mYDtaGrid.ReadOnly = true;
            mYDtaGrid.RightToLeft = RightToLeft.Yes;
            mYDtaGrid.RowHeaderWidth = 16;
            mYDtaGrid.Size = new Size(343, 215);
            mYDtaGrid.TabIndex = 84;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(355, 6);
            button1.Name = "button1";
            button1.Size = new Size(86, 47);
            button1.TabIndex = 85;
            button1.Text = "\u062A&\u062D\u0636\u064A\u0631/ \u062A\u063A\u064A\u064A\u0628 \u0637\u0627\u0644\u0628";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click);
            label1.Font = new Font("Tahoma", 15.0F);
            label1.Location = new Point(55, 102);
            label1.Name = "label1";
            label1.Size = new Size(232, 63);
            label1.TabIndex = 322;
            label1.Text = "\u0644\u0627 \u064A\u0648\u062C\u062F \u0637\u0644\u0627\u0628 \u063A\u0627\u0626\u0628\u0648\u0646";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = false;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(446, 250);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(mYDtaGrid);
            Controls.Add(label12);
            Controls.Add(refreshBTN);
            Controls.Add(CloseBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "status";
            RightToLeft = RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\u062D\u0627\u0644\u0629 \u0627\u0644\u063A\u064A\u0627\u0628";
            Activated += new EventHandler(RefreshData);
            Load += new EventHandler(status_Load);
            mYDtaGrid.EndInit();
            ResumeLayout(false);
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            status_Load(sender, e);
        }

        private void RefreshData(object sender, EventArgs e)
        {
            // trial
        }

        private void status_Load(object sender, EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class status

}

