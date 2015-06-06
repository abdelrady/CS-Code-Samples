using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Payment_Calculator
{
    public partial class Form1 : Form
    {
        int intyears = 2;
        int months = 0;
        int price = 0;
        int loan = 0;
        int downpayment = 0;
        double dbinterest = 0;
        decimal decmonthlypayment = 0;
        double monthinterest = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Moth\t\tMonthly Payment");
            price = int.Parse(textBox1.Text);
            downpayment = int.Parse(textBox2.Text);
            dbinterest = double.Parse(textBox3.Text)/100;
            monthinterest = dbinterest / 12;
            loan = price - downpayment;
            while (intyears <= 5)
            {
                months = 12 * intyears;
                decmonthlypayment = (decimal)(loan * monthinterest * Math.Pow(1 + monthinterest, months) /( Math.Pow(1 + monthinterest, months) - 1));
                listBox1.Items.Add(months+"\t\t"+string.Format("{0:c}",decmonthlypayment ));
                intyears++;
            }

        }
    }
}