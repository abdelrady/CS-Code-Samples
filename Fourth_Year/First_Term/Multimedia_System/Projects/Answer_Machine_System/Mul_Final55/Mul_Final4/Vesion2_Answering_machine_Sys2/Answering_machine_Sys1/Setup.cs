using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Answering_machine_Sys1
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }
        public static int lineID;
        private void button1_Click(object sender, EventArgs e)
        {
            ReturnVal();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public int ReturnVal()
        {
            int x = comboBox1.SelectedIndex;
            return x;
        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }
    }
}