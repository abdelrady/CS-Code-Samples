using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Students__House_Control.Properties;

namespace Students__House_Control
{

    public class Form1 : System.Windows.Forms.Form
    {

        public enum Splash
        {
            DontShow,
            Show
        }

        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel count;
        public System.Data.OleDb.OleDbConnection dBConnection;
        public string dblocationMain;
        private System.Windows.Forms.ToolStripMenuItem generalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbl;
        private System.Windows.Forms.ToolStripMenuItem makeAbsencePermesstionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuItem6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Students__House_Control.MyUtility Mutility;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel reminder;
        private System.Windows.Forms.ToolStripMenuItem showAbsenceStatusToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsUnitsDestributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem;

        public Form1()
        {
            bool flag;

            dblocationMain = "";
            Mutility = new Students__House_Control.MyUtility();
            InitializeComponent();
            System.Collections.IEnumerator ienumerator = Controls.GetEnumerator();
            try
            {
                while (flag)
                {
                    System.Windows.Forms.Control control = (System.Windows.Forms.Control)ienumerator.Current;
                    flag = control.GetType() != typeof(System.Windows.Forms.MdiClient);
                    if (!flag)
                    {
                        control.BackColor = BackColor;
                        control.BackgroundImage = BackgroundImage;
                    }
                    flag = ienumerator.MoveNext();
                }
            }
            finally
            {
                System.IDisposable idisposable = ienumerator as System.IDisposable;
                flag = idisposable == null;
                if (!flag)
                    idisposable.Dispose();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void cascadeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void closeAllToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            bool flag;
            System.Data.DataRow dataRow;
            System.DateTime dateTime1, dateTime2;

            dBConnection = Mutility.getDbConnection();
            System.Data.DataTable dataTable = Mutility.getDataTable("SELECT [ST_National Number],ArriveDate FROM Students WHERE AbsentOrNot=True");
            int i = 0;
            while (flag)
            {
                dataRow = dataTable.Rows[i];
                dateTime1 = System.DateTime.Parse(dataRow["ArriveDate"].ToString());
                dateTime2 = System.DateTime.Today;
                flag = System.DateTime.Compare(dateTime1, dateTime2.Date) >= 0;
                if (!flag)
                    Mutility.exQuery("UPDATE Students SET AbsentOrNot=False Where [ST_National Number]='" + dataRow[0].ToString() + "'");
                i++;
                flag = i < dataTable.Rows.Count;
            }
            dataTable = Mutility.getDataTable("SELECT [ST_National Number],TodayPone FROM Students WHERE TakePone=True");
            i = 0;
            while (flag)
            {
                dataRow = dataTable.Rows[i];
                dateTime1 = System.DateTime.Parse(dataRow["TodayPone"].ToString());
                dateTime2 = System.DateTime.Today;
                flag = System.DateTime.Compare(dateTime1, dateTime2.Date) >= 0;
                if (!flag)
                    Mutility.exQuery("UPDATE Students SET TakePone=False Where [ST_National Number]='" + dataRow[0].ToString() + "'");
                i++;
                flag = i < dataTable.Rows.Count;
            }
            reminder.Text = Mutility.getID("SELECT Count(*) FROM Students Where TakePone = False And Dismissed = FALSE and PayedOrNot = true and AbsentOrNot=false and R_Number is not null");
            count.Text = Mutility.getID("select count(*) from Students where AbsentOrNot=True  And Dismissed = FALSE");
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Students__House_Control.Form1));
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            basicDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            makeAbsencePermesstionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            showAbsenceStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            menuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            generalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            genToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsUnitsDestributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            count = new System.Windows.Forms.ToolStripStatusLabel();
            lbl = new System.Windows.Forms.ToolStripStatusLabel();
            reminder = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            openFileDialog1.FileName = "openFileDialog1";
            System.Windows.Forms.ToolStripItem[] toolStripItemArr = new System.Windows.Forms.ToolStripItem[] {
                                                                                                               basicDataToolStripMenuItem, 
                                                                                                               generalDataToolStripMenuItem, 
                                                                                                               genToolStripMenuItem, 
                                                                                                               helpToolStripMenuItem, 
                                                                                                               windowsToolStripMenuItem };
            menuStrip1.Items.AddRange(toolStripItemArr);
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            menuStrip1.Size = new System.Drawing.Size(707, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            toolStripItemArr = new System.Windows.Forms.ToolStripItem[] {
                                                                          toolStripMenuItem2, 
                                                                          menuItem2, 
                                                                          toolStripMenuItem1, 
                                                                          toolStripSeparator4, 
                                                                          makeAbsencePermesstionToolStripMenuItem, 
                                                                          toolStripSeparator3, 
                                                                          showAbsenceStatusToolStripMenuItem, 
                                                                          toolStripMenuItem3, 
                                                                          toolStripSeparator9, 
                                                                          toolStripMenuItem8, 
                                                                          toolStripSeparator1, 
                                                                          menuItem6 };
            basicDataToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            basicDataToolStripMenuItem.Name = "basicDataToolStripMenuItem";
            basicDataToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            basicDataToolStripMenuItem.Text = "\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0627\u0648\u0644\u064A\u0629";
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(201, 22);
            toolStripMenuItem2.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u062A\u0633\u0643\u064A\u0646";
            toolStripMenuItem2.Click += new System.EventHandler(toolStripMenuItem2_Click);
            menuItem2.Image = Students__House_Control.Properties.Resources.Adminstrative;
            menuItem2.Name = "menuItem2";
            menuItem2.Size = new System.Drawing.Size(201, 22);
            menuItem2.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0642\u064A\u0645\u064A\u0646";
            menuItem2.Click += new System.EventHandler(menuItem2_Click_1);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            toolStripMenuItem1.Text = "\u062A\u0648\u0632\u064A\u0639 \u0628\u0648\u0646\u0627\u062A \u0627\u0644\u062A\u063A\u0630\u064A\u0629";
            toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            makeAbsencePermesstionToolStripMenuItem.Name = "makeAbsencePermesstionToolStripMenuItem";
            makeAbsencePermesstionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            makeAbsencePermesstionToolStripMenuItem.Text = "\u0639\u0645\u0644 \u0623\u0630\u0646 \u063A\u064A\u0627\u0628/ \u062A\u062D\u0636\u064A\u0631 \u0637\u0627\u0644\u0628";
            makeAbsencePermesstionToolStripMenuItem.Click += new System.EventHandler(makeAbsencePermesstionToolStripMenuItem_Click_1);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            showAbsenceStatusToolStripMenuItem.Name = "showAbsenceStatusToolStripMenuItem";
            showAbsenceStatusToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            showAbsenceStatusToolStripMenuItem.Text = "\u0639\u0631\u0636 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u0627\u0626\u0628\u0648\u0646";
            showAbsenceStatusToolStripMenuItem.Click += new System.EventHandler(showAbsenceStatusToolStripMenuItem_Click_1);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(201, 22);
            toolStripMenuItem3.Text = "\u0639\u0631\u0636 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0641\u0635\u0648\u0644\u064A\u0646";
            toolStripMenuItem3.Click += new System.EventHandler(toolStripMenuItem3_Click);
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new System.Drawing.Size(198, 6);
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new System.Drawing.Size(201, 22);
            toolStripMenuItem8.Text = "\u062A\u063A\u064A\u064A\u0631 \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645 \u0627\u0644\u062D\u0627\u0644\u0649";
            toolStripMenuItem8.Click += new System.EventHandler(toolStripMenuItem8_Click);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            menuItem6.Image = Students__House_Control.Properties.Resources.wrong;
            menuItem6.Name = "menuItem6";
            menuItem6.ShortcutKeys = System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.ShiftKey | System.Windows.Forms.Keys.Space | System.Windows.Forms.Keys.Alt;
            menuItem6.Size = new System.Drawing.Size(201, 22);
            menuItem6.Text = "\u063A\u0644\u0642 \u0627\u0644\u0628\u0631\u0646\u0627\u0645\u062C";
            menuItem6.Click += new System.EventHandler(menuItem6_Click_1);
            toolStripItemArr = new System.Windows.Forms.ToolStripItem[] {
                                                                          toolStripMenuItem6, 
                                                                          toolStripSeparator2, 
                                                                          toolStripMenuItem5 };
            generalDataToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            generalDataToolStripMenuItem.Name = "generalDataToolStripMenuItem";
            generalDataToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            generalDataToolStripMenuItem.Text = "\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0639\u0627\u0645\u0629";
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new System.Drawing.Size(162, 22);
            toolStripMenuItem6.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0643\u0644\u064A\u0627\u062A";
            toolStripMenuItem6.Click += new System.EventHandler(toolStripMenuItem6_Click);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new System.Drawing.Size(162, 22);
            toolStripMenuItem5.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645\u064A\u0646";
            toolStripMenuItem5.Click += new System.EventHandler(toolStripMenuItem5_Click_1);
            toolStripItemArr = new System.Windows.Forms.ToolStripItem[] {
                                                                          studentsUnitsDestributionToolStripMenuItem, 
                                                                          ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem };
            genToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            genToolStripMenuItem.Name = "genToolStripMenuItem";
            genToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            genToolStripMenuItem.Text = "\u0627\u0644\u062A\u0642\u0627\u0631\u064A\u0631 \u0648\u0627\u0644\u0623\u062D\u0635\u0627\u0626\u064A\u0627\u062A";
            studentsUnitsDestributionToolStripMenuItem.Image = (System.Drawing.Image)componentResourceManager.GetObject("studentsUnitsDestributionToolStripMenuItem.Image");
            studentsUnitsDestributionToolStripMenuItem.Name = "studentsUnitsDestributionToolStripMenuItem";
            studentsUnitsDestributionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            studentsUnitsDestributionToolStripMenuItem.Text = "\u062A\u0648\u0632\u064A\u0639 \u0627\u0644\u0637\u0644\u0627\u0628 \u0639\u0644\u0649 \u0627\u0644\u0643\u0644\u064A\u0627\u062A";
            studentsUnitsDestributionToolStripMenuItem.Click += new System.EventHandler(studentsUnitsDestributionToolStripMenuItem_Click);
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Name = "\u062A\u0642\u0631\u064A\u0631\u0627\u0644\u0637\u0644\u0627\u0628\u0627\u0644\u0645\u0641\u0635\u0648\u0644\u064A\u0646ToolStripMenuItem";
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Text = "\u062A\u0642\u0631\u064A\u0631 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0641\u0635\u0648\u0644\u064A\u0646";
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Click += new System.EventHandler(ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem_Click);
            toolStripItemArr = new System.Windows.Forms.ToolStripItem[] {
                                                                          toolStripMenuItem9, 
                                                                          menuItem4, 
                                                                          aboutToolStripMenuItem, 
                                                                          toolStripMenuItem4, 
                                                                          ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem };
            helpToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            helpToolStripMenuItem.Text = "\u0645\u0633\u0627\u0639\u062F\u0647";
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new System.Drawing.Size(186, 22);
            toolStripMenuItem9.Text = "\u0639\u0631\u0636 \u0627\u0644\u0645\u0633\u0627\u0639\u062F\u0647";
            toolStripMenuItem9.Click += new System.EventHandler(toolStripMenuItem9_Click);
            menuItem4.Name = "menuItem4";
            menuItem4.Size = new System.Drawing.Size(186, 22);
            menuItem4.Text = "\u0639\u0631\u0636 \u0627\u0644\u0634\u0627\u0634\u0647 \u0627\u0644\u0627\u0641\u062A\u062A\u0627\u062D\u064A\u0647";
            menuItem4.Click += new System.EventHandler(menuItem4_Click_1);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            aboutToolStripMenuItem.Text = "\u0639\u0646 \u0627\u0644\u0646\u0638\u0627\u0645";
            aboutToolStripMenuItem.Click += new System.EventHandler(aboutToolStripMenuItem_Click);
            toolStripItemArr = new System.Windows.Forms.ToolStripItem[] {
                                                                          cascadeToolStripMenuItem, 
                                                                          toolStripSeparator6, 
                                                                          closeAllToolStripMenuItem };
            windowsToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            windowsToolStripMenuItem.Text = "\u0627\u0644\u0646\u0648\u0627\u0641\u0630 \u0627\u0644\u0645\u0641\u062A\u0648\u062D\u0629";
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.LButton | System.Windows.Forms.Keys.RButton | System.Windows.Forms.Keys.Alt;
            cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            cascadeToolStripMenuItem.Text = "\u062A\u0631\u062A\u064A\u0628 ";
            cascadeToolStripMenuItem.Click += new System.EventHandler(cascadeToolStripMenuItem_Click);
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            closeAllToolStripMenuItem.Image = Students__House_Control.Properties.Resources.wrong;
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.MButton | System.Windows.Forms.Keys.Back | System.Windows.Forms.Keys.Alt;
            closeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            closeAllToolStripMenuItem.Text = "\u063A\u0644\u0642 \u0627\u0644\u0643\u0644";
            closeAllToolStripMenuItem.Click += new System.EventHandler(closeAllToolStripMenuItem_Click);
            toolStripItemArr = new System.Windows.Forms.ToolStripItem[] { refreshToolStripMenuItem };
            contextMenuStrip1.Items.AddRange(toolStripItemArr);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            refreshToolStripMenuItem.Image = (System.Drawing.Image)componentResourceManager.GetObject("refreshToolStripMenuItem.Image");
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            refreshToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            refreshToolStripMenuItem.Text = "\u062A\u062D\u062F\u064A\u062B";
            refreshToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            refreshToolStripMenuItem.Click += new System.EventHandler(refreshToolStripMenuItem_Click);
            toolStripItemArr = new System.Windows.Forms.ToolStripItem[] {
                                                                          toolStripStatusLabel1, 
                                                                          count, 
                                                                          lbl, 
                                                                          reminder };
            statusStrip1.Items.AddRange(toolStripItemArr);
            statusStrip1.Location = new System.Drawing.Point(0, 471);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new System.Drawing.Size(707, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            toolStripStatusLabel1.Text = "\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u0627\u0626\u0628\u0648\u062A";
            count.ForeColor = System.Drawing.Color.Red;
            count.Name = "count";
            count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            count.Size = new System.Drawing.Size(34, 17);
            count.Text = "count";
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(77, 17);
            lbl.Text = "\u0627\u0644\u0628\u0648\u0646\u0627\u062A \u0627\u0644\u0645\u062A\u0628\u0642\u064A\u0647";
            reminder.ForeColor = System.Drawing.Color.Red;
            reminder.Name = "reminder";
            reminder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            reminder.Size = new System.Drawing.Size(49, 17);
            reminder.Text = "reminder";
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(237, 6);
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Name = "\u0641\u062A\u062D\u0642\u0627\u0639\u062F\u0647\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A\u0644\u0644\u0645\u062A\u062E\u0635\u0635\u064A\u0646\u0641\u0642\u0637ToolStripMenuItem";
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Text = "\u0641\u062A\u062D \u0642\u0627\u0639\u062F\u0647 \u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A(\u0644\u0644\u0645\u062A\u062E\u0635\u0635\u064A\u0646 \u0641\u0642\u0637)";
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Click += new System.EventHandler(ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem_Click);
            AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            BackgroundImage = (System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(707, 493);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "\u0627\u0644\u0646\u0627\u0641\u0630\u0629 \u0627\u0644\u0631\u0626\u064A\u0633\u064A\u0647";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(message);
            Load += new System.EventHandler(Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void makeAbsencePermesstionToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            // trial
        }

        private void menuItem2_Click_1(object sender, System.EventArgs e)
        {
            // trial
        }

        private void menuItem4_Click_1(object sender, System.EventArgs e)
        {
            // trial
        }

        private void menuItem6_Click_1(object sender, System.EventArgs e)
        {
            Close();
        }

        private void message(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            // trial
        }

        private void refreshToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            Mutility.RefreshMe();
            Form1_Load(null, null);
            Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void showAbsenceStatusToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            Students__House_Control.status status = new Students__House_Control.status();
            bool flag = !Mutility.CheckAlreadyOpened(this, status.Text);
            if (!flag)
            {
            }
            else
            {
                status.MdiParent = this;
                status.dBConnection = dBConnection;
                status.Show();
            }
        }

        private void studentsUnitsDestributionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                reportDocument.Load("StatisticsReport.rpt");
                reportDocument.Refresh();
                Students__House_Control.reportV reportV = new Students__House_Control.reportV();
                reportV.crystalReportViewer1.ReportSource = reportDocument;
                reportV.Show();
            }
            catch (System.Exception e1)
            {
                System.Windows.Forms.MessageBox.Show("\u062D\u062F\u062B \u062E\u0637\u0623 \u0627\u062B\u0646\u0627\u0621 \u062A\u062D\u0645\u064A\u0644 \u0627\u0644\u062A\u0642\u0631\u064A\u0631,\u0644\u0648 \u0627\u0646\u062A \u062E\u0628\u064A\u0631 \u0627\u0644\u062E\u0637\u0623 \u0647\u0648\n" + e1.Message, "\u062E\u0637\u0623", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void toolStripLabel1_Click(object sender, System.EventArgs e)
        {
            Students__House_Control.Students students = new Students__House_Control.Students();
            bool flag = !Mutility.CheckAlreadyOpened(this, students.Text);
            if (!flag)
            {
            }
            else
            {
                students.MdiParent = this;
                students.dBConnection = dBConnection;
                students.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void toolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            Students__House_Control.StudentsDistribution studentsDistribution = new Students__House_Control.StudentsDistribution();
            bool flag = !Mutility.CheckAlreadyOpened(this, studentsDistribution.Text);
            if (!flag)
            {
            }
            else
            {
                studentsDistribution.MdiParent = this;
                studentsDistribution.dBConnection = dBConnection;
                studentsDistribution.Show();
            }
        }

        private void toolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void toolStripMenuItem5_Click_1(object sender, System.EventArgs e)
        {
            // trial
        }

        private void toolStripMenuItem6_Click(object sender, System.EventArgs e)
        {
            Students__House_Control.faculities faculities = new Students__House_Control.faculities();
            bool flag = !Mutility.CheckAlreadyOpened(this, faculities.Text);
            if (!flag)
            {
            }
            else
            {
                faculities.MdiParent = this;
                faculities.dBConnection = dBConnection;
                faculities.Show();
            }
        }

        private void toolStripMenuItem8_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("\u0647\u0644 \u0627\u0646\u062A \u0645\u062A\u0623\u0643\u062F \u0645\u0646 \u0627\u0646\u0643 \u062A\u0631\u064A\u062F \u062A\u063A\u064A\u064A\u0631 \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645 \u0627\u0644\u062D\u0627\u0644\u0649", "\u062A\u063A\u064A\u064A\u0631 \u0645\u0633\u062A\u062E\u062F\u0645", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2);
            bool flag = dialogResult != System.Windows.Forms.DialogResult.Yes;
            if (!flag)
            {
                System.Windows.Forms.Form[] formArr = MdiChildren;
                int i = 0;
                while (flag)
                {
                    System.Windows.Forms.Form form = formArr[i];
                    form.Close();
                    i++;
                    flag = i < formArr.Length;
                }
                Students__House_Control.login login = new Students__House_Control.login(Students__House_Control.login.Splash.DontShow);
                login.CancelBtn.Text = "Exit Program ";
                login.ShowDialog();
            }
        }

        private void toolStripMenuItem9_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        private void ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                reportDocument.Load("Dismiss.rpt");
                Students__House_Control.reportV reportV = new Students__House_Control.reportV();
                reportV.crystalReportViewer1.ReportSource = reportDocument;
                reportV.crystalReportViewer1.Zoom(65);
                reportV.Show();
            }
            catch (System.Exception e1)
            {
                System.Windows.Forms.MessageBox.Show("\u062D\u062F\u062B \u062E\u0637\u0623 \u0627\u062B\u0646\u0627\u0621 \u062A\u062D\u0645\u064A\u0644 \u0627\u0644\u062A\u0642\u0631\u064A\u0631,\u0644\u0648 \u0627\u0646\u062A \u062E\u0628\u064A\u0631 \u0627\u0644\u062E\u0637\u0623 \u0647\u0648\n" + e1.Message, "\u062E\u0637\u0623", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            Cursor = System.Windows.Forms.Cursors.Arrow;
        }

        private void ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

        [System.STAThread]
        public static void Main()
        {
            // trial
        }

    } // class Form1

}

