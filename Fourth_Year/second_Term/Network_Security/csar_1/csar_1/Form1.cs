using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace csar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename;
        private void button1_Click(object sender, EventArgs e)
        {
            string enc=cesar(textBox1.Text,3);
            MessageBox.Show(enc);
            MessageBox.Show(cesarDec(enc));
        }

        private string cesar(string p,int key)
        {
            //int i = 0;
            string p2="";
            int asc = 0;char ch=' ';
            for(int i=0;i<p.Length;i++)
            {
                asc = (int)p[i];
                p2 += ((char)((((asc - 97) + key) % 26) + 97)).ToString();
                //i++;
            }
            return p2;
        }
        private string cesarDec(string p)
        {
            //int i = 0;
            string p2 = "";
            int asc = 0; char ch = ' ';
            for (int i = 0; i < p.Length; i++)
            {
                asc = (int)p[i];
                
                if (asc - 3 < 97)
                    p2 += ((char)((asc) - 3+26)).ToString();
                else
                    p2 += ((char)((Math.Abs(((asc) - 3))))).ToString();
                //i++;
            }
            return p2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enc = transpositionMat(this.textBox2.Text);
            MessageBox.Show(enc);
            MessageBox.Show(transpositionMatDec(enc));
        }

        private string transpositionMatDec(string enc)
        {
            char[][] mat = new char[rowsNum][];
            for (int i = 0; i < rowsNum; i++)
            {
                mat[i] = new char[ColsNum];
            }
            int counter=0;
            for (int i = 0; i < ColsNum; i++)
            {
                for (int j = 0; j < rowsNum; j++)
                {
                    mat[j][i] = enc[counter++];

                }
            }
            string str="";
            for (int i = 0; i < rowsNum; i++)
                str += new string(mat[i]) + " ";
            return str;
        }
        int ColsNum = 0; int rowsNum = 0;
        private string transpositionMat(string p)
        {
            string[] vals = p.Split(' ');
            string cryptotext = "";
            ColsNum = vals[0].Length;
            rowsNum = vals.Length;
            //char[,] mat = new char[vals.Length, vals[0].Length];
            for (int i = 0; i < vals[0].Length; i++)
            {
                for (int j = 0; j < vals.Length; j++)
                {
                    cryptotext += vals[j][i];
                }
            }
            return cryptotext;
        }
    }
}