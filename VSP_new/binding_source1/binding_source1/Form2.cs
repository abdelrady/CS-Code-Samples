using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace binding_source1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gsmlanka_DataDataSet1.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.gsmlanka_DataDataSet1.Manufacturer);
            //this.manufacturerTableAdapter.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.bindingSource1.AllowEdit.ToString());
            this.Validate();
            this.bindingSource1.EndEdit();
            this.manufacturerTableAdapter.Update(this.gsmlanka_DataDataSet1.Manufacturer);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.manufacturerTableAdapter.FillBy(this.gsmlanka_DataDataSet1.Manufacturer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.manufacturerTableAdapter.Update(this.gsmlanka_DataDataSet1.Manufacturer);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DataRow dt= this.gsmlanka_DataDataSet1.Manufacturer.FindByman_id(14);
            dt[1] = "SUN";
            //dt.SetAdded();
            this.bindingSource1.EndEdit();
            this.manufacturerTableAdapter.Connection.Open();
            manufacturerTableAdapter.Update(dt);
            this.manufacturerTableAdapter.Connection.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.manufacturerTableAdapter.Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.manufacturerTableAdapter.Connection.Open();

            this.manufacturerTableAdapter.Fill(gsmlanka_DataDataSet1.Manufacturer);
            this.manufacturerTableAdapter.Connection.Close();
        }
    }
}