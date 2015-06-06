using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Merge2Files1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string file1, file2, file3;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)file1 = openFileDialog1.FileName;
            textBox1.Text = file1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Hello World";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) file2 = openFileDialog1.FileName;
            textBox2.Text = file2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) file3 = saveFileDialog1.FileName;
            textBox3.Text = file3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add2Files(file1, file2, file3);

        }

        private void Add2Files(string file1, string file2, string file3)
        {

            byte[] arr;

            FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream fs3 = new FileStream(file3, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            BinaryReader br1 = new BinaryReader(fs1);
            BinaryReader br2 = new BinaryReader(fs2);
            BinaryWriter br3 = new BinaryWriter(fs3,Encoding.ASCII);
            
            int num1, num2;
            
            /*while (true)
            {
                MessageBox.Show(br1.ReadInt32().ToString());
            }*/
            try
            {
                while ((br1.PeekChar()) != -1)
                {
                    num1 = br1.ReadInt32();
                    if ((br2.PeekChar()) != -1)
                    {
                        num2 = br2.ReadInt32();
                        MessageBox.Show("num1= " + num1.ToString() + " num2= " + num2.ToString());
                        br3.Write((num1 + num2).ToString());
                    }
                    else
                    {
                        MessageBox.Show("num1= " + num1.ToString() );
                        br3.Write((num1).ToString());
                    }
                    
                    br3.Write((byte)13);
                    br3.Write((byte)10);
                   // if ((br1.PeekChar()) != -1) br1.ReadInt16();//proceed \r\n which have 2bytes
                   // if (br2.PeekChar() != -1) br2.ReadInt16();//proceed \r\n which have 2bytes
                }
            }
            catch { }
            finally
            {
                br1.Close();
                br2.Close();
                br3.Close();
            }
            MessageBox.Show("Successfully Adding Two Files.");
            /*
            byte[] buffer = new byte[1000];
            while ((bytesReaded = fs1..Read(buffer, 0, 1000)) != 0)
            {
                //Encoding.Default.GetString
                fs3.Write(buffer, 0, bytesReaded);
            }
            fs1.Close();
            while ((bytesReaded = fs2.Read(buffer, 0, 1000)) != 0)
            {
                fs3.Write(buffer, 0, bytesReaded);
            }*/
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream(file1, FileMode.Truncate, FileAccess.Write, FileShare.Read);
            FileStream fs2 = new FileStream(file2, FileMode.Truncate, FileAccess.Write, FileShare.Read);
            
            BinaryWriter br1 = new BinaryWriter(fs1);
            BinaryWriter br2 = new BinaryWriter(fs2);

            br1.Write((Int32)12);
            br1.Write((Int32)9);
            br1.Write((Int32)122);
            br1.Write((Int32)12345);
            br1.Write((Int32)3423);
            br1.Write((Int32)1);

            br2.Write((Int32)12);
            br2.Write((Int32)9);
            br2.Write((Int32)12);
            br2.Write((Int32)145);
            br2.Write((Int32)3423);
            br2.Write((Int32)5);

            br1.Close();
            br2.Close();

            MessageBox.Show("Successfully Creating Two Files.");
        }

    }
}