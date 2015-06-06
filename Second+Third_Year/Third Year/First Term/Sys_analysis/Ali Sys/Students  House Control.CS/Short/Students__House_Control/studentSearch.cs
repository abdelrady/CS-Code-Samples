using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class studentSearch : Form
    {

        private Button button1;
        private Button button2;
        private IContainer components;
        public OleDbConnection dBConnection;
        private Label label4;
        private ListBox listBox1;
        public string selectedName;
        public MyUtility seUtility;
        private TextBox textBox1;

        public studentSearch()
        {
            components = null;
            seUtility = new MyUtility();
            selectedName = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedName = textBox1.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            // trial
        }

        private void SelectName(object sender, EventArgs e)
        {
            bool flag = listBox1.SelectedIndex < 0;
            if (!flag)
            {
                selectedName = listBox1.SelectedItem.ToString();
                Close();
            }
        }

        private void studentSearch_Load(object sender, EventArgs e)
        {
            // trial
        }

        private void UpdateTXT(object sender, EventArgs e)
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

