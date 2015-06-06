using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb ;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class maintainBill : Form
    {
        public maintainBill()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=O:\\Alamia.mdb");
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "SELECT * FROM „‰ Ã_„⁄ÿÊ» WHERE SN='" + textBox1.Text + "'";// AND Cus_ID=" + textBox6.Text + "";//WHERE  Name='Mahmoud'
            
            con.Open();
            OleDbDataReader dr = command.ExecuteReader();

            int FCount = dr.VisibleFieldCount;

            string[] Arr = new string[FCount];

            DataGridViewTextBoxColumn Cols;

            dataGridView1.Columns.Clear();
            for (int i = 0; i < FCount; i++)
            {
                Cols = new DataGridViewTextBoxColumn();
                Cols.HeaderText = dr.GetName(i);
                dataGridView1.Columns.Add(Cols);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = FCount;
            DataGridViewRow R = new DataGridViewRow();
            dataGridView1.Visible = false;
            while (dr.Read())
            {
                for (int i = 0; i < FCount; i++)
                    Arr[i] = dr[i].ToString();

                dataGridView1.Rows.Add(Arr);
            }
            dataGridView1.Visible = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        //    printDocument1.PrintPage();
            printDocument1.Print();
        }

        private void maintainBill_Load(object sender, EventArgs e)
        {
            button1.Enabled = false ;
            t1 .Enabled =false;
            t2.Enabled =false;
            t3.Enabled  =false;
            t4.Enabled=false;
            label1 .Enabled =false;
            label2 .Enabled=false;
            label3 .Enabled=false;
            label12 .Enabled=false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
                t1.Enabled = true;
                t2.Enabled = true;
                t3.Enabled = true;
                t4.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label12.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                t1.Enabled = false;
                t2.Enabled = false;
                t3.Enabled = false;
                t4.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label12.Enabled = false;
            }
        }

        
    }
}