using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dblhours;
            decimal decwage;
            decimal decearnings;
            dblhours = double.Parse(textBox1.Text);
            decwage = decimal.Parse(textBox2.Text);
            if (dblhours <= 40)
            {
                decearnings = (decimal)dblhours * decwage;
            }
            else
            {
                decearnings = 40 * decwage;
                decearnings +=  (decimal)(dblhours - 40) * ((decimal)(1.5)*decwage);
            }
            label4.Text = string.Format ("{0:c}",decearnings);
        }
    }
}