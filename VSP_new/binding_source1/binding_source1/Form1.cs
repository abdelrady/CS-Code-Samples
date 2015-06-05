using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace binding_source1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gsmlanka_DataDataSet.phone_details' table. You can move, or remove it, as needed.
            this.phone_detailsTableAdapter.Fill(this.gsmlanka_DataDataSet.phone_details);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.phone_detailsTableAdapter.Update(gsmlanka_DataDataSet);
        }
    }
}