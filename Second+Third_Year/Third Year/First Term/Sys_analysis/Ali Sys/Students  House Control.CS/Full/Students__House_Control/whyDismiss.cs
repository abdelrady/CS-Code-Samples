using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class whyDismiss : System.Windows.Forms.Form
    {

        private System.ComponentModel.IContainer components;
        public string IDNum;
        public string name;
        private System.Windows.Forms.Button OkBTN;
        private System.Windows.Forms.TextBox reasonTXT;
        private System.Windows.Forms.Button undoBTN;
        private Students__House_Control.MyUtility Wutility;

        public whyDismiss(string nameTXT, string IDTXT)
        {
            Wutility = new Students__House_Control.MyUtility();
            components = null;
            name = nameTXT;
            IDNum = IDTXT;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void OkBTN_Click(object sender, System.EventArgs e)
        {
            bool flag = reasonTXT.Text != "";
            if (!flag)
            {
                System.Windows.Forms.MessageBox.Show("\u0644\u0627\u0628\u062F \u0645\u0646 \u0643\u062A\u0627\u0628\u0629 \u0633\u0628\u0628 \u0627\u0644\u0641\u0635\u0644", "\u0628\u064A\u0627\u0646\u0627\u062A \u0645\u0641\u0642\u0648\u062F\u0629 ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                reasonTXT.Focus();
            }
            else
            {
                System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("\u0647\u0644 \u0627\u0646\u062A \u0645\u062A\u0627\u0643\u062F \u0645\u0646 \u0641\u0635\u0644 \u0627\u0644\u0637\u0627\u0644\u0628   " + name + "  \u0645\u0646 \u0627\u0644\u0645\u062F\u064A\u0646\u0647 \u0627\u0644\u062C\u0627\u0645\u0639\u064A\u0629", "\u062A\u0627\u0643\u064A\u062F \u0641\u0635\u0644 \u0637\u0627\u0644\u0628 ", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation);
                flag = !dialogResult.Equals(6);
                if (!flag)
                {
                    Wutility.exQuery("UPDATE  students SET Dismissed = TRUE , ReasonofDismission = '" + reasonTXT.Text.ToString() + "' WHERE [ST_National Number] like '" + IDNum + "'");
                    Wutility.exQuery("UPDATE Students SET R_Number = NULL Where ST_Name = '" + name + "'");
                    System.Windows.Forms.MessageBox.Show("\u0627\u0644\u0637\u0627\u0644\u0628 " + name + " \u062A\u0645 \u0641\u0635\u0644\u0629", "Student ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                    Close();
                }
            }
        }

        private void undoBTN_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            bool flag = !disposing || (components == null);
            if (!flag)
                components.Dispose();
            base.Dispose(disposing);
        }

    } // class whyDismiss

}

