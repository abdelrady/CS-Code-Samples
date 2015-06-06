using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((int)(char.MaxValue)).ToString());
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("book");
                writeCarObject();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("book");
                writePersonObject();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                MessageBox.Show("book");
                writeBookObject();
            }

        }

        private void writeCarObject()
        {
            FileStream fs = new FileStream(("quiz.txt"), FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            BinaryWriter sw = new BinaryWriter(fs, Encoding.Default);
            sw.Write((char)'1');
            //sw.Write((int)(new car(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text).ToString().Length));
            sw.Write(new car(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text).ToString());
            sw.Flush();
            sw.Close();
        }

        private void writeBookObject()
        {
            FileStream fs=new FileStream(("quiz.txt"),FileMode.Append,FileAccess.Write,FileShare.ReadWrite);
            BinaryWriter sw = new BinaryWriter(fs,Encoding.Default);
            sw.Write((char)'2');
            //sw.Write((int)(new book(this.textBox1.Text,this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.textBox5.Text).ToString().Length));
            sw.Write(new book(this.textBox1.Text,this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.textBox5.Text).ToString());
            sw.Flush();
            sw.Close();
        }

        private void writePersonObject()
        {
            FileStream fs = new FileStream(("quiz.txt"), FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            BinaryWriter sw = new BinaryWriter(fs, Encoding.Default);
            sw.Write((char)'3');
            //sw.Write((int)(new person(int.Parse(this.textBox1.Text), int.Parse(this.textBox2.Text), this.textBox3.Text).ToString().Length));
            sw.Write(new person(int.Parse(this.textBox1.Text), int.Parse(this.textBox2.Text), this.textBox3.Text).ToString());
            sw.Flush();
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            if (sr == null)
            {
                MessageBox.Show("init");
                sr = new BinaryReader(File.OpenRead("quiz.txt"));
            }

            if (comboBox1.SelectedIndex==0)
            {
                readCarObject();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                readPersonObject();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                readBookObject();
            }
        }
        BinaryReader sr;
        private void readBookObject()
        {
            try
            {
                char iid = sr.ReadChar();
                int len;
                while (iid == '1' || iid == '3')
                {
                    sr.BaseStream.Seek(1, SeekOrigin.Current);
                    //len = sr.ReadInt32();
                    sr.ReadString();
                    iid = sr.ReadChar();
                }
               
                //sr.BaseStream.Seek(1, SeekOrigin.Current);



                string strdata = sr.ReadString();
                string[] strvals = strdata.Split('|');

                try
                {
                    this.textBox1.Text = strvals[0];
                    this.textBox2.Text = strvals[1];
                    this.textBox3.Text = strvals[2];
                    this.textBox4.Text = strvals[3];
                    this.textBox5.Text = strvals[4];
                }
                catch { }
            }
            catch
            {
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
            }


        }

        private void readPersonObject()
        {
            try
            {
                char iid = sr.ReadChar();
                int len;
                while (iid == '1' || iid == '2')
                {
                    sr.BaseStream.Seek(1, SeekOrigin.Current);
                    len = sr.ReadInt32();
                    sr.ReadBytes(len);
                    iid = sr.ReadChar();
                }
                if (iid == '3')
                {
                    sr.BaseStream.Seek(1, SeekOrigin.Current);
                    len = sr.ReadInt32();
                    byte[] data = sr.ReadBytes(len);
                    string strdata = Encoding.Default.GetString(data);
                    MessageBox.Show(strdata);
                    string[] strvals = strdata.Split('|');

                    try
                    {
                        this.textBox1.Text = strvals[0];
                        this.textBox2.Text = strvals[1];
                        this.textBox3.Text = strvals[2];

                    }
                    catch { }
                }
            }
            catch
            {
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
            }

        }

        private void readCarObject()
        {
            //MessageBox.Show("");
            try{
                //MessageBox.Show(sr.BaseStream.Position.ToString());
                Int32 iid = sr.ReadInt32();
                int len;
                //while (iid == 2 || iid == 3)
                //{
                //   // sr.BaseStream.Seek(1, SeekOrigin.Current);
                //   // MessageBox.Show(sr.BaseStream.Position.ToString());
                //    len = sr.ReadInt32();
                //  //  MessageBox.Show(sr.BaseStream.Position.ToString());
                //    sr.ReadBytes(len);
                //    iid = sr.ReadChar();
                //}
                if (iid == 1)
                {
                     MessageBox.Show(sr.BaseStream.Position.ToString());
                   // sr.BaseStream.Seek(1, SeekOrigin.Current);
                   
                    len = sr.ReadInt32();
                    MessageBox.Show(sr.BaseStream.Position.ToString());
                    //MessageBox.Show(sr.BaseStream.Position.ToString());
                    byte[] data = sr.ReadBytes(len);
                    string strdata = Encoding.ASCII.GetString(data);
                    MessageBox.Show(strdata);
                    string[] strvals = strdata.Split('|');

                    try
                    {
                        this.textBox1.Text = strvals[0];
                        this.textBox2.Text = strvals[1];
                        this.textBox3.Text = strvals[2];
                        this.textBox4.Text = strvals[3];
                        this.textBox5.Text = strvals[4];
                    }
                    catch {
                       
                    }
                }
        }
        catch
        {
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
        }

        }
        void clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

    }

    public class car
    {
        string make, model, year, color;
        public car(string make, string model, string year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return this.make + '|' + this.model + '|' + this.year + '|' + this.color + '|';
        }
    }
    public class person
    {
        int id;
        int age;
        string name;
        public person(int id, int age, string name)
        {
            this.id = id;
            this.age = age;
            this.name = name;
        }
        public override string ToString()
        {
            return this.id.ToString() + '|' + this.age.ToString() + '|' + this.name + '|';
        }
    }
    public class book
    {
        string isbn, name, author, publisher, pubdate;
        public book(string isbn,string name,string author,string publisher,string pubdate)
        {
            this.isbn = isbn;
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.pubdate = pubdate;
        }
        public override string ToString()
        {
            return this.isbn + '|' + this.name + '|' + this.author + '|' + publisher+'|' + this.pubdate + '|' + this.pubdate+'|';
        }
    }
}