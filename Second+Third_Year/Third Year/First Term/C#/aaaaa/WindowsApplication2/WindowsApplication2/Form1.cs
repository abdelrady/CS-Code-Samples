using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        private Graphics m_objGraphic;
        bool m_blnShouldPaint, m_blnShouldErase;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_objGraphic = CreateGraphics();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
                        if ( e.Button == MouseButtons.Left )
            {
               m_blnShouldPaint = true;
            }
            // erase blue-violet circles if right button is held down
            else if ( e.Button == MouseButtons.Right )
            {
               m_blnShouldErase = true;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           m_blnShouldPaint = false; // do not draw on the Form
           m_blnShouldErase = false; // do not erase

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ( m_blnShouldPaint == true )
           {
              m_objGraphic.FillEllipse(                   
                 new SolidBrush( Color.BlueViolet ),      
                 e.X, e.Y, 8, 8 );
           }
           // mouse pointer "erases" if right mouse button is pressed
           else if ( m_blnShouldErase == true )
           {
              m_objGraphic.FillEllipse( new SolidBrush( BackColor ),
                 e.X, e.Y, 8, 8 );          
           }

        }
    }
}