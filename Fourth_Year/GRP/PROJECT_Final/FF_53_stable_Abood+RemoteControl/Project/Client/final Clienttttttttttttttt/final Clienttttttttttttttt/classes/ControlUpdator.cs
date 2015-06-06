using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SmartDoor
{
    public class TSCUpdater
    {
        //################################################################################
        delegate void TextProc(string Text);
        delegate void EnabledProc(bool Enabled);
        delegate void AppendProc(string Msg);
        delegate void ImageProc(Image Image);
        delegate void SelectProc(int start,int end);

        delegate void SelectColorProc(Color col);
        //################################################################################
        Control TargetControl;
        //################################################################################
        TextProc VarText;
        EnabledProc VarEnabled;
        AppendProc VarString;
        ImageProc VarImage;
        SelectProc VarSel;
        SelectColorProc varColo;
        //################################################################################
        
        public TSCUpdater(Control Ctrl)
        {
            TargetControl = Ctrl;
            VarText = new TextProc(Proc_Text);
            VarEnabled = new EnabledProc(Proc_Enabled);
            VarString = new AppendProc(AppendText);
            VarImage = new ImageProc(Proc_Image);
            VarSel = new SelectProc(Select);
            varColo = new SelectColorProc(proc_SelectionColor);
        }
        //################################################################################
        public string Text
        {
            set { Proc_Text(value); }
            get { return TargetControl.Text; }
        }
        public Image Image
        {
            set { Proc_Image(value); }
        }
        public Color SelectionColor
        {
            set { proc_SelectionColor(value); }
        }

        private void proc_SelectionColor(Color value)
        {
            if (TargetControl.InvokeRequired)
            {
                TargetControl.BeginInvoke(varColo, new object[] { value });
                return;
            }
            (TargetControl as RichTextBox).SelectionColor = value;
        }
        public bool Enabled
        {
            set { Proc_Enabled(value); }
        }
        //################################################################################
        public void AppendText(string Text)
        {
            if (TargetControl.InvokeRequired)
            {
                TargetControl.BeginInvoke(VarString, new object[] { Text });
                return;
            }
            ((RichTextBox)TargetControl).AppendText(Text);
        }
        void Proc_Text(string Text)
        {
            if (TargetControl.InvokeRequired)
            {
                TargetControl.BeginInvoke(VarText, new object[] { Text });
                return;
            }
            TargetControl.Text = Text;
        }
        void Proc_Enabled(bool Enabled)
        {
            if (TargetControl.InvokeRequired)
            {
                TargetControl.BeginInvoke(VarEnabled, new object[] { Enabled });
                return;
            }
            TargetControl.Enabled = Enabled;
        }
        void Proc_Image(Image Image)
        {
            if (TargetControl.InvokeRequired)
            {
                TargetControl.BeginInvoke(VarImage, new object[] { Image });
                return;
            }
            (TargetControl as PictureBox).Image = Image;
        }
        //################################################################################

        public void Select(int p, int p_2)
        {
            if (TargetControl.InvokeRequired)
            {
                TargetControl.BeginInvoke(VarSel, new object[] { p, p_2 });
                return;
            }
            (TargetControl as RichTextBox).Select(p,p_2);
        }
    }
}
