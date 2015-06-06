using System.Windows.Forms;
using System.Drawing;
public class TSCUpdater
{
    //################################################################################
    delegate void TextProc(string Text);
    delegate void EnabledProc(bool Enabled);
    delegate void AddItemProc(ListViewItem Item);
    delegate void UpdateItemProc(string Item);
    delegate void DeleteItemProc(string Item);
    delegate void ImageProc(Image Image);
    delegate void AppendProc(string Msg);
    //################################################################################
    Control TargetControl;
    //################################################################################
    TextProc VarText;
    EnabledProc VarEnabled;
    AddItemProc VarAddItem;
    UpdateItemProc VarUpdateItem;
    DeleteItemProc VarDeleteItem;
    ImageProc VarImage;
    AppendProc VarString;
    //################################################################################
    public TSCUpdater(Control Ctrl)
    {
        TargetControl = Ctrl;
        VarText = new TextProc(Proc_Text);
        VarEnabled = new EnabledProc(Proc_Enabled);
        VarAddItem = new AddItemProc(Proc_AddItem);
        VarUpdateItem = new UpdateItemProc(Proc_UpdateItem);
        VarDeleteItem = new DeleteItemProc(Proc_DeleteItem);
        VarImage = new ImageProc(Proc_Image);
        VarString = new AppendProc(AppendText);
    }
    //################################################################################
    public string Text
    {
        set { Proc_Text(value); }     
    }
    public bool Enabled
    {
        set { Proc_Enabled(value); }
    }
    public ListViewItem AddItem
    {
        set { Proc_AddItem(value); }
    }
    public string DeleteItem
    {
        set { Proc_DeleteItem(value); }
    }
    public string UpdateItem
    {
        set { Proc_UpdateItem(value); }
    }
    public Image Image
    {
        set { Proc_Image(value); }
    }
    //################################################################################
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
    void Proc_AddItem(ListViewItem ItemArg)
    {
        if (TargetControl.InvokeRequired)
        {
            TargetControl.BeginInvoke(VarAddItem, new object[] { ItemArg });
            return;
        }
        (TargetControl as ListView).Items.Add(ItemArg);
    }
    void Proc_UpdateItem(string ItemArg)
    {
        if (TargetControl.InvokeRequired)
        {
            TargetControl.BeginInvoke(VarUpdateItem, new object[] { ItemArg });
            return;
        }
        string[] DataElement = ItemArg.Split(new char[] { '#' });
        (TargetControl as ListView).FindItemWithText(DataElement[0]).SubItems[int.Parse(DataElement[1])].Text = DataElement[2];
    }
    void Proc_DeleteItem(string ItemKey)
    {
        if (TargetControl.InvokeRequired)
        {
            TargetControl.BeginInvoke(VarDeleteItem, new object[] { ItemKey });
            return;
        }
        (TargetControl as ListView).Items.Remove((TargetControl as ListView).FindItemWithText(ItemKey));
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
    public void AppendText(string Text)
    {
        if (TargetControl.InvokeRequired)
        {
            TargetControl.BeginInvoke(VarString, new object[] { Text });
            return;
        }
        (TargetControl as RichTextBox).AppendText(Text);
    }
}