using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte[] byt = new byte[1024];
            byt = Encoding.Default.GetBytes("Welcomeback");
            Array.Resize<byte>(ref byt, byt.Length + 4);
            Array.Copy(BitConverter.GetBytes((int)10000),0, byt,0,4);

            MessageBox.Show(Encoding.Default.GetString(byt));

            MessageBox.Show( BitConverter.ToInt32(byt, 0).ToString());

        }
    }
}