using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class studentSearch : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.IContainer components;
        public System.Data.OleDb.OleDbConnection dBConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        public string selectedName;
        public Students__House_Control.MyUtility seUtility;
        private System.Windows.Forms.TextBox textBox1;

        public studentSearch()
        {
            components = null;
            seUtility = new Students__House_Control.MyUtility();
            selectedName = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            selectedName = textBox1.Text;
            Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void SelectName(object sender, System.EventArgs e)
        {
            bool flag = listBox1.SelectedIndex < 0;
            if (!flag)
            {
                selectedName = listBox1.SelectedItem.ToString();
                Close();
            }
        }

        private void studentSearch_Load(object sender, System.EventArgs e)
        {
            // trial
        }

        private void UpdateTXT(object sender, System.EventArgs e)
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

    } // class studentSearch

}

