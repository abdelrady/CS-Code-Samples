using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Text;
using System.Windows.Forms;

namespace Client_s_.Classes
{
    public partial class DownloadGUI : Form
    {
        public string FnameD, Dpath; 
        public DownloadGUI(  string Cname , string Fname , int Fsize)
        {
            InitializeComponent();         

            ClientNameLBL.Text = Cname+" ?";
            FilenameLBL.Text = Fname;
            FnameD = Fname;
            sizeLBL.Text = Fsize.ToString()+" Bytes";

            if (System.IO.Path.GetExtension(Fname) == "rar")
            {
                pictureBox2.Image = imageList.Images["rar.ico"];
            }
            else if (System.IO.Path.GetExtension(Fname) == "avi")
            {
                pictureBox2.Image = imageList.Images["avi.ico"];
            }
            else if (System.IO.Path.GetExtension(Fname) == "doc")
            {
                pictureBox2.Image = imageList.Images["doc.ico"];
            }
            else if (System.IO.Path.GetExtension(Fname) == "txt")
            {
                pictureBox2.Image = imageList.Images["txt.ico"];
            }
            else if (System.IO.Path.GetExtension(Fname) == "ppt")
            {
                pictureBox2.Image = imageList.Images["ppt.ico"];
            }
            else if (System.IO.Path.GetExtension(Fname) == "pdf")
            {
                pictureBox2.Image = imageList.Images["pdf.ico"];
            }
            else 
            {
                pictureBox2.Image = imageList.Images["void.ico"];
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BTNDownload_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = FnameD;
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Dpath = saveFileDialog.FileName;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
    //Wrapper class
    public class Download
    {
        public  DownloadGUI inputFrm;

        public  string Show( string Cname, string Fname, int Fsize)
        {
            inputFrm = new DownloadGUI(Cname, Fname, Fsize);

            if (inputFrm.ShowDialog() == DialogResult.OK)
                return inputFrm.Dpath;
            return string.Empty;
        }

    }
}