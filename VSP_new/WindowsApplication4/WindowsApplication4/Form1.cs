using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection cnn = new OleDbConnection("Provider = Microsoft.Jet.OlEDB.4.0; Data Source = "+Application.StartupPath+"\\images.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "bmp|*.bmp|gif|*.gif|jpg|*.jpg|png|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
               // pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //pictureBox1.Image = null;
            cnn.Open();
            FileStream fs = new FileStream(textBox1.Text, FileMode.Open);
            byte[] byte1=new byte[fs.Length];
            fs.Read(byte1, 0, byte1.Length);
            fs.Close();
            
            //BinaryReader bin = new BinaryReader(textBox1.Text);
            //bin.Read(byte1, 0, byte1.Length);
            cmd=new OleDbCommand("INSERT INTO [images](id,image) values(1,[@ima])",cnn);
            OleDbParameter par1 = new OleDbParameter("@ima", OleDbType.LongVarBinary);
            par1.Value = byte1;
            cmd.Parameters.Add(par1);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Success");
            }

        }
    }
}