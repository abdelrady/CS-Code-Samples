using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bindingSource2
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sqlDataAdapter1.Fill(dataSet11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.dataSet11.People.Constraints.Add("PK_prim", new DataColumn[] { new DataColumn("ID") }, true);
            DataRow dtr= this.dataSet11.People.Rows.Find((object)1);
            dtr.BeginEdit();
            dtr["FirstName"] = "asd";
            dtr["LastName"] = "asd";
            dtr.EndEdit();
            this.sqlDataAdapter1.Update(dataSet11);
        }
    }
}