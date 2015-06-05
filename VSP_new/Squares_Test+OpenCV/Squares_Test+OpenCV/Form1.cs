using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Squares_Test_OpenCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        clsFaceDetectionWrapper cls = clsFaceDetectionWrapper.GetSingletonInstance();
        private void button1_Click(object sender, EventArgs e)
        {
          int num=  cls.WrapDetectFaces(new Bitmap("c:\\test.bmp"));
          string str = "";
          for (int i = 0; i < num; i++)
          {
              unsafe
              {
                  int x, y, x2, y2;
                  cls.WrapGetCoordinates(i, &x, &y, &x2, &y2);
                  str += x + " " + y + " " + x2 + " " + y2 + Environment.NewLine;
              }
              
          }
          MessageBox.Show(str);
        }
    }
}