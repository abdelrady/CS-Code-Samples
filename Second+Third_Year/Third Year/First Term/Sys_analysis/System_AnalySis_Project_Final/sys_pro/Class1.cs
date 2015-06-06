using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace WindowsApplication1
{

    public class clsFunctions
    {

        //Call the Installed Programs in the System.
        public static bool shell(string strShell)
        {
            System.Diagnostics.Process.Start(strShell);
            return true;
        }


        //Function if Textbox is Empty.
        public void isTextEmpty(TextBox txt, string sLabel)
        {
            MessageBox.Show(sLabel + " is empty. Pls check the field.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt.Focus();
        }

        //Function if String is Empty.
        public void isStringEmpty(string sLabel)
        {
            MessageBox.Show(sLabel + " is empty. Pls check the field.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Fill All Records in the Table.
        public void fillRecords(ListView sListview, OleDbDataReader dr)
        {
            ListViewItem lvItem;
            sListview.Items.Clear();

            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                int i = 1;
                while (i <= dr.FieldCount - 1)
                {
                    lvItem.SubItems.Add(dr.GetString(i));
                    i++;
                }
                sListview.Items.Add(lvItem);
            }
        }

        //Fill TabControls.
        public void fillTabControls(TabControl tb, OleDbDataReader dr, string sAll)
        {
            tb.TabPages.Clear();

            if (sAll != "") tb.TabPages.Add(new TabPage(sAll));

            while (dr.Read())
            {
                int i = 1;
                while (i <= dr.FieldCount - 2)
                {
                    tb.Controls.Add(new TabPage(dr.GetString(i)));
                    i++;
                }
                if (tb.TabPages.Count > 0) tb.SelectedIndex = 0;
            }
        }
    }
}
