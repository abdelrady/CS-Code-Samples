using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartDoor
{
    public partial class Door_Details : Form
    {
        public Door_Details(string SID, SqlConnection Con,string DoorName,string DoorNum)
        {
            InitializeComponent();
            this.Text = DoorName;
            SocIDTXT.Text = SID;
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Doorip,doormac,doorlastlogrecieved,doorlastlistupdate FROM doors WHERE doornum=" + DoorNum, Con);
            DataTable Dtable = new DataTable();
            Adapter.Fill(Dtable);
            string[] Data = DBUtility.Get_String_Data(Dtable.Rows[0].ItemArray);

            DoorNameTXT.Text = DoorName;
            DoorNumTXt.Text = DoorNum;
            doorip.Text = Data[0].Trim();

            doorMac.Text = (Data[1].Trim() != "") ? Data[1].Trim() : "NOT_CONFIGURED";
            lastlog.Text = (Data[2].Trim() != "") ? Data[2].Trim() : "NOT_CONFIGURED";
            lastupdate.Text = (Data[3].Trim() != "") ? Data[3].Trim() : "NOT_CONFIGURED";
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}