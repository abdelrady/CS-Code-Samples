using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practical_Exam_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        TcpClient client = new TcpClient();
        NetworkStream ns;
        private void button1_Click(object sender, EventArgs e)
        {
            
            client.Connect(new IPEndPoint(IPAddress.Parse(textBox1.Text),8080));
            ns = client.GetStream();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();
            if (opg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opg.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //BinaryWriter bw = new BinaryWriter(ns);

            NetworkStream ns=client.GetStream();
            BinaryWriter bw = new BinaryWriter(ns,Encoding.Default);
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            string ss = Encoding.Default.GetString(ms.ToArray());
            MessageBox.Show(ss.Length.ToString());
            bw.Write(ss);
            //StreamWriter s = new StreamWriter(ns);
            //new BinaryFormatter().Serialize(ns, pictureBox1.Image);
            //ms.WriteTo(ns);
            //ns.Write(ms.ToArray(), 0, (int)ms.Length);
            //ns.Flush();
            //ns.WriteByte((byte)('\0'));
            //ns.Close();
            //s.Close();
            //ns.Write(ms.ToArray(), 0, (int)ms.Length);
            //bw.Write(Encoding.Default.GetString(ms.ToArray()));

        }
    }
}