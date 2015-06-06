using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class status : System.Windows.Forms.Form
    {

        public System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button CloseBtn;
        private System.ComponentModel.IContainer components;
        public System.Data.OleDb.OleDbConnection dBConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.DataGrid mYDtaGrid;
        public System.Windows.Forms.Button refreshBTN;
        public Students__House_Control.MyUtility Sutility;

        public status()
        {
            components = null;
            Sutility = new Students__House_Control.MyUtility();
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Students__House_Control.absencePermetion absencePermetion = new Students__House_Control.absencePermetion();
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

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.status));
            CloseBtn = new System.Windows.Forms.Button();
            refreshBTN = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            mYDtaGrid = new System.Windows.Forms.DataGrid();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            mYDtaGrid.BeginInit();
            SuspendLayout();
            CloseBtn.BackColor = System.Drawing.Color.Transparent;
            CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            CloseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            CloseBtn.Image = (System.Drawing.Image)componentResourceManager.GetObject("CloseBtn.Image");
            CloseBtn.Location = new System.Drawing.Point(355, 215);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CloseBtn.Size = new System.Drawing.Size(86, 29);
            CloseBtn.TabIndex = 23;
            CloseBtn.Text = "&\u063A\u0644\u0642";
            CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += new System.EventHandler(CloseBtn_Click);
            refreshBTN.BackColor = System.Drawing.Color.Transparent;
            refreshBTN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            refreshBTN.Location = new System.Drawing.Point(355, 59);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new System.Drawing.Size(86, 29);
            refreshBTN.TabIndex = 24;
            refreshBTN.Text = "&\u062A\u062D\u062F\u064A\u062B";
            refreshBTN.UseVisualStyleBackColor = false;
            refreshBTN.Click += new System.EventHandler(refreshBTN_Click);
            label12.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label12.Font = new System.Drawing.Font("Tahoma", 8.0F);
            label12.ForeColor = System.Drawing.Color.Red;
            label12.Location = new System.Drawing.Point(6, 6);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(343, 19);
            label12.TabIndex = 83;
            label12.Text = "\u0643\u0644 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u0627\u0626\u0628\u0648\u0646\r\n\r\n\r\n";
            label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            mYDtaGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            mYDtaGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mYDtaGrid.CaptionVisible = false;
            mYDtaGrid.DataMember = "";
            mYDtaGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            mYDtaGrid.Location = new System.Drawing.Point(6, 28);
            mYDtaGrid.Name = "mYDtaGrid";
            mYDtaGrid.ReadOnly = true;
            mYDtaGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            mYDtaGrid.RowHeaderWidth = 16;
            mYDtaGrid.Size = new System.Drawing.Size(343, 215);
            mYDtaGrid.TabIndex = 84;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(355, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(86, 47);
            button1.TabIndex = 85;
            button1.Text = "\u062A&\u062D\u0636\u064A\u0631/ \u062A\u063A\u064A\u064A\u0628 \u0637\u0627\u0644\u0628";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(button1_Click);
            label1.Font = new System.Drawing.Font("Tahoma", 15.0F);
            label1.Location = new System.Drawing.Point(55, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 63);
            label1.TabIndex = 322;
            label1.Text = "\u0644\u0627 \u064A\u0648\u062C\u062F \u0637\u0644\u0627\u0628 \u063A\u0627\u0626\u0628\u0648\u0646";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Visible = false;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(446, 250);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(mYDtaGrid);
            Controls.Add(label12);
            Controls.Add(refreshBTN);
            Controls.Add(CloseBtn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "status";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "\u062D\u0627\u0644\u0629 \u0627\u0644\u063A\u064A\u0627\u0628";
            Activated += new System.EventHandler(RefreshData);
            Load += new System.EventHandler(status_Load);
            mYDtaGrid.EndInit();
            ResumeLayout(false);
        }

        private void refreshBTN_Click(object sender, System.EventArgs e)
        {
            status_Load(sender, e);
        }

        private void RefreshData(object sender, System.EventArgs e)
        {
            // trial
        }

        private void status_Load(object sender, System.EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class status

}

