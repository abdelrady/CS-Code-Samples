using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MovieShow
{
    public partial class Form5 : Form
    {
        private static int i, prev;
        private int tm1,tm2,s1,s2,m1,m2,h1,h2;
        private StreamReader sub;
        private float size = 12F;
    
        public Form5()
        {
            InitializeComponent();
        }
        private void begin()
        {
            tm2 = 0;
            tm1 = 0;
            s1 = 0;
            m1 = 0;
            s2 = 0;
            m2 = 0;
            h1 = 0;
            h2 = 0;
        }
        public void initial(string s)
        {
            i = 1;
            sub = new StreamReader(s);
            show();
        }
        private void read()
        {
            string line;
            line = sub.ReadLine();
            string[] time = line.Split(':');
            string[] arrow = time[2].Split(' ');
            string[] seconds = arrow[0].Split(',');
            string[] seconds2 = time[4].Split(',');
            begin();
            s1 = int.Parse(seconds[0]) * 1000 + int.Parse(seconds[1]);
            s2 = int.Parse(seconds2[0]) * 1000 + int.Parse(seconds2[1]);
            m1 = int.Parse(time[1]);
            m2 = int.Parse(time[3]);
            h1 = int.Parse(time[0]);
            h2 = int.Parse(arrow[2]);
            tm1 = s1 + m1 * 60000 + h1 * 3600000;
            tm2 = s2 + m2 * 60000 + h2 * 3600000;
            Notext.Interval = tm1 - prev;
            Showtext.Interval = tm2 - tm1;
            Notext.Start();        
        }
        
        private void Notext_Tick(object sender, EventArgs e)
        {
            Notext.Stop();
            Showtext.Start();
        }

        private void show()
        {
            string line;
            subtitlebox.Items.Clear();
            Showtext.Stop();
            line = sub.ReadLine();
            while (line != i.ToString())
            {
                subtitlebox.Items.Add(line);
                line = sub.ReadLine();
            }
            i++;
            prev = tm2;
            read();

        }
        public void FontColor(Color c)
        {
            subtitlebox.ForeColor = c;
        }

        public void Background(Color c)
        {
            subtitlebox.BackColor = c;
        }

        public void FontSize(float s)
        {
            size = s;
            subtitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", size , System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void FontBold()
        {
            subtitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        public void FontRegular()
        {
            subtitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        public void FontStrikeout()
        {
            subtitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        public void FontItalics()
        {
            subtitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        public void FontUnderline()
        {
            subtitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void Showtext_Tick(object sender, EventArgs e)
        {
            show();
        }

        private void Form5_SizeChanged(object sender, EventArgs e)
        {
            subtitlebox.Size = new Size(this.Width, this.Height - 19);
        }

    }

    }
