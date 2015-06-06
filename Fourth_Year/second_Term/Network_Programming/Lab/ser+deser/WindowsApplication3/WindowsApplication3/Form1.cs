using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Threading;
using System.Diagnostics;

namespace WindowsApplication1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoapFormatter bbr = new SoapFormatter();
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream asdfs = new FileStream("C:\\asd.txt",FileMode.Create, FileAccess.Write);
            bbr.Serialize(asdfs,this.textBox1.Text);
            asdfs.Close();
            MessageBox.Show("Successfully serialized object.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream readfs = new FileStream("C:\\asd.txt", FileMode.Open, FileAccess.Read);
            MessageBox.Show( bbr.Deserialize(readfs).ToString());
            readfs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Thread th = new Thread(new ThreadStart(test));
            //th.Start();
            students std = new students(1, "asd", "fcis", "2/3/2000", "egypt");
            std.SaveTo();
            std.RetrieveFrom();
            //MessageBox.Show( new students((students)std.RetrieveFrom()).ToString() );
            //foreach (students s in (students[])std.RetrieveFrom())
            {
              //  MessageBox.Show(s.ToString());
            }
        }
        public void test()
        {
            for (; ; )
            {
                //Process
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            students std = new students(1, "asd", "fcis", "2/3/2000", "egypt");
            byte[] array=std.SaveToMS();
            //MessageBox.Show(Encoding.Default.GetString(array));
            MessageBox.Show(new students((students)std.RetrieveFromMS(array)).ToString());
        }
    }
    [Serializable]
    public class students
    {
        int id;
        string FName, LName, DOB, Address;
        public students(int id, string FName, string LName, string DOB, string Address)
        {
            this.id = id; this.FName = FName; this.LName = LName; this.DOB = DOB; this.Address = Address;
        }
        public students(students std)
        {
            this.id = std.id;
            this.FName = std.FName;
            this.LName = std.LName;
            this.DOB = std.DOB;
            this.Address = std.Address;
        }
        public void SaveTo()
        {
            FileStream fs = new FileStream("C:\\asd.txt", FileMode.Create, FileAccess.Write);
            SoapFormatter sp = new SoapFormatter();
            sp.Serialize(fs, this);
            this.id=2;
            this.FName = "Abood";
            this.LName = "ASDASD";
            this.DOB = "1/1/2008";
            this.Address = "Luxor";
            sp.Serialize(fs,this) ;
            fs.Close();
        }
        public object RetrieveFrom()
        {
            FileStream fs = new FileStream("C:\\asd.txt", FileMode.Open, FileAccess.Read);
            SoapFormatter sp = new SoapFormatter();
            fs.Position = 0;
            MessageBox.Show(((students) sp.Deserialize(fs)).ToString());
            MessageBox.Show(fs.Position.ToString());
            MessageBox.Show(((students)sp.Deserialize(fs)).ToString());
            //MessageBox.Show(fs.Position.ToString());
            return null;
            //fs.Close();
        }
        public byte[] SaveToMS()
        {
            MemoryStream ms = new MemoryStream();
            SoapFormatter sp = new SoapFormatter();
            sp.Serialize(ms, this);
            //sp.Serialize(ms, this);
            //ms.Position = 12;
            return ms.ToArray();
        }
        public object RetrieveFromMS(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            SoapFormatter sp = new SoapFormatter();
            return sp.Deserialize(ms);
            //fs.Close();
        }
        public override string ToString()
        {
            return "ID= "+this.id.ToString()+" FirstName= "+this.FName+" LastName= "+this.LName+" Date Of Birth= "+this.DOB+"Address= "+this.Address;
        }

    }
}