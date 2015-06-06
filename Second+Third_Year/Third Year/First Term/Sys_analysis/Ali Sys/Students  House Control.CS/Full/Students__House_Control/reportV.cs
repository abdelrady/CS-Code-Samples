using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Students__House_Control
{

    public class reportV : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Button BTNClose;
        private System.ComponentModel.IContainer components;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public reportV()
        {
            components = null;
            InitializeComponent();
        }

        private void BTNClose_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.reportV));
            crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            BTNClose = new System.Windows.Forms.Button();
            SuspendLayout();
            crystalReportViewer1.ActiveViewIndex = -1;
            crystalReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            crystalReportViewer1.DisplayGroupTree = false;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            crystalReportViewer1.Name = "crystalReportViewer1";
            crystalReportViewer1.SelectionFormula = "";
            crystalReportViewer1.ShowCloseButton = false;
            crystalReportViewer1.ShowGotoPageButton = false;
            crystalReportViewer1.ShowGroupTreeButton = false;
            crystalReportViewer1.ShowTextSearchButton = false;
            crystalReportViewer1.Size = new System.Drawing.Size(687, 451);
            crystalReportViewer1.TabIndex = 0;
            crystalReportViewer1.ViewTimeSelectionFormula = "";
            BTNClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            BTNClose.Image = (System.Drawing.Image)componentResourceManager.GetObject("BTNClose.Image");
            BTNClose.Location = new System.Drawing.Point(244, 457);
            BTNClose.Name = "BTNClose";
            BTNClose.Size = new System.Drawing.Size(176, 31);
            BTNClose.TabIndex = 1;
            BTNClose.Text = "&\u063A\u0644\u0642 \u0639\u0640\u0640\u0640\u0640\u0640\u0640\u0627\u0631\u0636 \u0627\u0644\u0640\u0640\u0640\u0640\u062A\u0642\u0627\u0631\u064A\u0631";
            BTNClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            BTNClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BTNClose.UseVisualStyleBackColor = true;
            BTNClose.Click += new System.EventHandler(BTNClose_Click);
            AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 13.0F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(687, 495);
            Controls.Add(BTNClose);
            Controls.Add(crystalReportViewer1);
            Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
            MinimumSize = new System.Drawing.Size(695, 529);
            Name = "reportV";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "\u0639\u0640\u0640\u0640\u0640\u0640\u0640\u0627\u0631\u0636 \u0627\u0644\u0640\u0640\u0640\u0640\u062A\u0642\u0627\u0631\u064A\u0631";
            Load += new System.EventHandler(reportV_Load);
            ResumeLayout(false);
        }

        private void reportV_Load(object sender, System.EventArgs e)
        {
            crystalReportViewer1.Zoom(75);
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

    } // class reportV

}

