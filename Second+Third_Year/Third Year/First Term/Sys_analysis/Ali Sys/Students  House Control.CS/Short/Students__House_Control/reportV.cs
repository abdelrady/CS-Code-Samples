using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Students__House_Control
{

    public class reportV : Form
    {

        private Button BTNClose;
        private IContainer components;
        public CrystalReportViewer crystalReportViewer1;

        public reportV()
        {
            components = null;
            InitializeComponent();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(reportV));
            crystalReportViewer1 = new CrystalReportViewer();
            BTNClose = new Button();
            SuspendLayout();
            crystalReportViewer1.ActiveViewIndex = -1;
            crystalReportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            crystalReportViewer1.DisplayGroupTree = false;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Location = new Point(0, 0);
            crystalReportViewer1.Name = "crystalReportViewer1";
            crystalReportViewer1.SelectionFormula = "";
            crystalReportViewer1.ShowCloseButton = false;
            crystalReportViewer1.ShowGotoPageButton = false;
            crystalReportViewer1.ShowGroupTreeButton = false;
            crystalReportViewer1.ShowTextSearchButton = false;
            crystalReportViewer1.Size = new Size(687, 451);
            crystalReportViewer1.TabIndex = 0;
            crystalReportViewer1.ViewTimeSelectionFormula = "";
            BTNClose.Anchor = AnchorStyles.Bottom;
            BTNClose.Image = (Image)componentResourceManager.GetObject("BTNClose.Image");
            BTNClose.Location = new Point(244, 457);
            BTNClose.Name = "BTNClose";
            BTNClose.Size = new Size(176, 31);
            BTNClose.TabIndex = 1;
            BTNClose.Text = "&\u063A\u0644\u0642 \u0639\u0640\u0640\u0640\u0640\u0640\u0640\u0627\u0631\u0636 \u0627\u0644\u0640\u0640\u0640\u0640\u062A\u0642\u0627\u0631\u064A\u0631";
            BTNClose.TextAlign = ContentAlignment.MiddleRight;
            BTNClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNClose.UseVisualStyleBackColor = true;
            BTNClose.Click += new EventHandler(BTNClose_Click);
            AutoScaleDimensions = new SizeF(7.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(687, 495);
            Controls.Add(BTNClose);
            Controls.Add(crystalReportViewer1);
            Font = new Font("Tahoma", 8.0F, FontStyle.Bold);
            MinimumSize = new Size(695, 529);
            Name = "reportV";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\u0639\u0640\u0640\u0640\u0640\u0640\u0640\u0627\u0631\u0636 \u0627\u0644\u0640\u0640\u0640\u0640\u062A\u0642\u0627\u0631\u064A\u0631";
            Load += new EventHandler(reportV_Load);
            ResumeLayout(false);
        }

        private void reportV_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Zoom(75);
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class reportV

}

