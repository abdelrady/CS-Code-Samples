using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            localhost.MathService ms = new WindowsApplication4.localhost.MathService();

            int x = Convert.ToInt16(5);
            int y = Convert.ToInt16(10);
            int sum = ms.Add(x, y);
            int sub = ms.Subtract(x, y);
            int mult = ms.Multiply(x, y);
            int div = ms.Divide(x, y);

            MessageBox.Show(x + " + " + y + " = " + sum);

        }
    }
}