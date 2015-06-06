using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace SmartDoor.Forms
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

       /*    axShockwaveFlash1.LoadMovie(0, Directory.GetCurrentDirectory() + "\\myfile.swf");
            axShockwaveFlash1.GotoFrame(0);

            axShockwaveFlash1.Play();*/
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 10), new Rectangle(this.Width - 1, this.Height - 1, 0, 0));

            LinearGradientBrush brBrush;
            Rectangle rcBrush = new Rectangle(0, 0, this.Width, this.Height); ;
            brBrush = new LinearGradientBrush(rcBrush, Color.Green, Color.Black, LinearGradientMode.ForwardDiagonal);

            brBrush.WrapMode = WrapMode.Tile;
            brBrush.SetSigmaBellShape(0);
            ColorBlend cb = new ColorBlend(2);
            cb.Positions[0] = 0.0f;
            cb.Positions[1] = 1.0f;
            cb.Colors[0] = Color.White;
            cb.Colors[1] = Color.Silver;


            brBrush.InterpolationColors = cb;

            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.CompositingMode = CompositingMode.SourceCopy;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle rcClient = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rcContent = rcClient;
            e.Graphics.FillRectangle(brBrush, rcContent);
           // e.Graphics.DrawRectangle(new Pen(Color.Gray, 5), new Rectangle(0, 0, this.Width - 1, this.Height - 1));

            base.OnPaint(e);
        }

                private void AboutBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }        
    }
}