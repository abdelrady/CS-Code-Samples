using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class whyDismiss : Form
    {

        private IContainer components;
        public string IDNum;
        public string name;
        private Button OkBTN;
        private TextBox reasonTXT;
        private Button undoBTN;
        private MyUtility Wutility;

        public whyDismiss(string nameTXT, string IDTXT)
        {
            Wutility = new MyUtility();
            components = null;
            name = nameTXT;
            IDNum = IDTXT;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void OkBTN_Click(object sender, EventArgs e)
        {
            bool flag = reasonTXT.Text != "";
            if (!flag)
            {
                MessageBox.Show("\u0644\u0627\u0628\u062F \u0645\u0646 \u0643\u062A\u0627\u0628\u0629 \u0633\u0628\u0628 \u0627\u0644\u0641\u0635\u0644", "\u0628\u064A\u0627\u0646\u0627\u062A \u0645\u0641\u0642\u0648\u062F\u0629 ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                reasonTXT.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("\u0647\u0644 \u0627\u0646\u062A \u0645\u062A\u0627\u0643\u062F \u0645\u0646 \u0641\u0635\u0644 \u0627\u0644\u0637\u0627\u0644\u0628   " + name + "  \u0645\u0646 \u0627\u0644\u0645\u062F\u064A\u0646\u0647 \u0627\u0644\u062C\u0627\u0645\u0639\u064A\u0629", "\u062A\u0627\u0643\u064A\u062F \u0641\u0635\u0644 \u0637\u0627\u0644\u0628 ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                flag = !dialogResult.Equals(6);
                if (!flag)
                {
                    Wutility.exQuery("UPDATE  students SET Dismissed = TRUE , ReasonofDismission = '" + reasonTXT.Text.ToString() + "' WHERE [ST_National Number] like '" + IDNum + "'");
                    Wutility.exQuery("UPDATE Students SET R_Number = NULL Where ST_Name = '" + name + "'");
                    MessageBox.Show("\u0627\u0644\u0637\u0627\u0644\u0628 " + name + " \u062A\u0645 \u0641\u0635\u0644\u0629", "Student ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
            }
        }

        private void undoBTN_Click(object sender, EventArgs e)
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

