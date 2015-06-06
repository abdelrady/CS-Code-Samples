using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Print_Card_Module
{
    public partial class IDForm : Form
    {
        private StringBuilder Barcode;
        public IDForm()
        {
            InitializeComponent();
        }

        private void BrowseImageBtn12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OpenImageDlg.ShowDialog(this) == DialogResult.OK)
            {
                string image_pass = OpenImageDlg.FileName;
                switch (tabControl.SelectedIndex)
                {
                    case 0: Pic1.Image = Image.FromFile(image_pass); break;
                    case 1: Pic2.Image = Image.FromFile(image_pass); break;
                    case 2: Pic3.Image = Image.FromFile(image_pass); break;
                    case 3: Pic4.Image = Image.FromFile(image_pass); break;
                    case 4: Pic5.Image = Image.FromFile(image_pass); break;
                    case 5: Pic6.Image = Image.FromFile(image_pass); break;
                    case 6: Pic7.Image = Image.FromFile(image_pass); break;
                    case 7: Pic8.Image = Image.FromFile(image_pass); break;
                 
                }
            }

        }

        private void FaceDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;      

            e.HasMorePages = false;

            e.PageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            int startX = 50;

            int startY = 50;     

            StringFormat strFormat = new StringFormat();

            Font font2 = new Font("Trebuchet MS", 12, FontStyle.Bold);

            Font font3 = new Font("Trebuchet MS", 10, FontStyle.Regular);
         
            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(startX, startY, 330, 160));//Draw Rectangl Border
            
            if (Pic1.Image != null)
            {
                e.Graphics.DrawImage(Pic1.Image, startX + 230, startY + 45, 85, 100);
            }
           
            e.Graphics.DrawString("Smart Door Project",
                font2,
                Brushes.DarkBlue,
                startX + 70,
                startY + 15,
                strFormat);
            
            e.Graphics.DrawString("Name : " + nameCBO1.Text,
                font3,
                Brushes.Black,
                startX + 15, 
                startY + 45,
                strFormat);
            
            e.Graphics.DrawString("Study Year : " + StudyYearCBO1.Text,
                font3,
                Brushes.Black,
                startX + 15,
                startY + 75,
                strFormat);
            
            e.Graphics.DrawString("Issue Date :" + IssueDate1.Value.Date.Day + "-" + IssueDate1.Value.Date.Month + "-" + IssueDate1.Value.Date.Year,
                font3, 
                Brushes.Black,
                startX + 15, 
                startY + 105, 
                strFormat);
        }

        private void PreviewFace1Btn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog prntDlg = new PrintPreviewDialog();

            FaceDoc.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            prntDlg.Name = "prntPreviewDlgFace";
            prntDlg.Document = FaceDoc;


            prntDlg.Show();
        }

        private void BackDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;      
      
            e.HasMorePages = false;

            e.PageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            BarcodeGenerator.CSBarcode Bgen = new BarcodeGenerator.CSBarcode();

            Image BarcodeImage = Bgen.GetBarCode(Barcode.ToString(), BarcodeGenerator.BarCodeClass.ClassB, 30);

            int startY = 50;

            int startX = e.PageBounds.Width - 380/*-50-330PB*/;

            StringFormat strFormat = new StringFormat(StringFormatFlags.LineLimit);

            Font font2 = new Font("Arial", 10, FontStyle.Bold);

            e.Graphics.DrawImage((Image)Print_Card_Module.Properties.Resources.FCIS, e.PageBounds.Width - 50 - 100, startY + 20, 85, 100);

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(startX, startY, 330, 160));//Draw Rectangl Border

            e.Graphics.DrawString(Notes1.Text, font2, Brushes.Black, startX + 10, startY + 20, strFormat);
                   
            e.Graphics.DrawImage(BarcodeImage, startX + 10, startY + 130, 105, 20);            
        }

        private void PreviewFace2Btn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog prntDlg = new PrintPreviewDialog();

            Barcode = new StringBuilder(14);

            Barcode.Append(nameCBO1.Text);           

            BackDoc.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);

            prntDlg.Name = "prntPreviewDlgFace";

            prntDlg.Document = BackDoc;

            prntDlg.Show();
        }
    }
}