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

    public class Form1 : Form
    {

        public enum Splash
        {
            DontShow,
            Show
        }

        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem basicDataToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripStatusLabel count;
        public OleDbConnection dBConnection;
        public string dblocationMain;
        private ToolStripMenuItem generalDataToolStripMenuItem;
        private ToolStripMenuItem genToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripStatusLabel lbl;
        private ToolStripMenuItem makeAbsencePermesstionToolStripMenuItem;
        private ToolStripMenuItem menuItem2;
        private ToolStripMenuItem menuItem4;
        private ToolStripMenuItem menuItem6;
        private MenuStrip menuStrip1;
        private MyUtility Mutility;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripStatusLabel reminder;
        private ToolStripMenuItem showAbsenceStatusToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem studentsUnitsDestributionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem;
        private ToolStripMenuItem ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem;

        public Form1()
        {
            bool flag;

            dblocationMain = "";
            Mutility = new MyUtility();
            InitializeComponent();
            IEnumerator ienumerator = Controls.GetEnumerator();
            try
            {
                while (flag)
                {
                    Control control = (Control)ienumerator.Current;
                    flag = control.GetType() != typeof(MdiClient);
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
                IDisposable idisposable = ienumerator as IDisposable;
                flag = idisposable == null;
                if (!flag)
                    idisposable.Dispose();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool flag;
            DataRow dataRow;
            DateTime dateTime1, dateTime2;

            dBConnection = Mutility.getDbConnection();
            DataTable dataTable = Mutility.getDataTable("SELECT [ST_National Number],ArriveDate FROM Students WHERE AbsentOrNot=True");
            int i = 0;
            while (flag)
            {
                dataRow = dataTable.Rows[i];
                dateTime1 = DateTime.Parse(dataRow["ArriveDate"].ToString());
                dateTime2 = DateTime.Today;
                flag = DateTime.Compare(dateTime1, dateTime2.Date) >= 0;
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
                dateTime1 = DateTime.Parse(dataRow["TodayPone"].ToString());
                dateTime2 = DateTime.Today;
                flag = DateTime.Compare(dateTime1, dateTime2.Date) >= 0;
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
            components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            basicDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            makeAbsencePermesstionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            showAbsenceStatusToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuItem6 = new ToolStripMenuItem();
            generalDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem5 = new ToolStripMenuItem();
            genToolStripMenuItem = new ToolStripMenuItem();
            studentsUnitsDestributionToolStripMenuItem = new ToolStripMenuItem();
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            menuItem4 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            closeAllToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            count = new ToolStripStatusLabel();
            lbl = new ToolStripStatusLabel();
            reminder = new ToolStripStatusLabel();
            toolStripMenuItem4 = new ToolStripSeparator();
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            openFileDialog1.FileName = "openFileDialog1";
            ToolStripItem[] toolStripItemArr = new ToolStripItem[] {
                                                                     basicDataToolStripMenuItem, 
                                                                     generalDataToolStripMenuItem, 
                                                                     genToolStripMenuItem, 
                                                                     helpToolStripMenuItem, 
                                                                     windowsToolStripMenuItem };
            menuStrip1.Items.AddRange(toolStripItemArr);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(707, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            toolStripItemArr = new ToolStripItem[] {
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
            basicDataToolStripMenuItem.Size = new Size(82, 20);
            basicDataToolStripMenuItem.Text = "\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0627\u0648\u0644\u064A\u0629";
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(201, 22);
            toolStripMenuItem2.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u062A\u0633\u0643\u064A\u0646";
            toolStripMenuItem2.Click += new EventHandler(toolStripMenuItem2_Click);
            menuItem2.Image = Resources.Adminstrative;
            menuItem2.Name = "menuItem2";
            menuItem2.Size = new Size(201, 22);
            menuItem2.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0642\u064A\u0645\u064A\u0646";
            menuItem2.Click += new EventHandler(menuItem2_Click_1);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(201, 22);
            toolStripMenuItem1.Text = "\u062A\u0648\u0632\u064A\u0639 \u0628\u0648\u0646\u0627\u062A \u0627\u0644\u062A\u063A\u0630\u064A\u0629";
            toolStripMenuItem1.Click += new EventHandler(toolStripMenuItem1_Click);
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(198, 6);
            makeAbsencePermesstionToolStripMenuItem.Name = "makeAbsencePermesstionToolStripMenuItem";
            makeAbsencePermesstionToolStripMenuItem.Size = new Size(201, 22);
            makeAbsencePermesstionToolStripMenuItem.Text = "\u0639\u0645\u0644 \u0623\u0630\u0646 \u063A\u064A\u0627\u0628/ \u062A\u062D\u0636\u064A\u0631 \u0637\u0627\u0644\u0628";
            makeAbsencePermesstionToolStripMenuItem.Click += new EventHandler(makeAbsencePermesstionToolStripMenuItem_Click_1);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(198, 6);
            showAbsenceStatusToolStripMenuItem.Name = "showAbsenceStatusToolStripMenuItem";
            showAbsenceStatusToolStripMenuItem.Size = new Size(201, 22);
            showAbsenceStatusToolStripMenuItem.Text = "\u0639\u0631\u0636 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u0627\u0626\u0628\u0648\u0646";
            showAbsenceStatusToolStripMenuItem.Click += new EventHandler(showAbsenceStatusToolStripMenuItem_Click_1);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(201, 22);
            toolStripMenuItem3.Text = "\u0639\u0631\u0636 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0641\u0635\u0648\u0644\u064A\u0646";
            toolStripMenuItem3.Click += new EventHandler(toolStripMenuItem3_Click);
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(198, 6);
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(201, 22);
            toolStripMenuItem8.Text = "\u062A\u063A\u064A\u064A\u0631 \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645 \u0627\u0644\u062D\u0627\u0644\u0649";
            toolStripMenuItem8.Click += new EventHandler(toolStripMenuItem8_Click);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(198, 6);
            menuItem6.Image = Resources.wrong;
            menuItem6.Name = "menuItem6";
            menuItem6.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.ShiftKey | Keys.Space | Keys.Alt;
            menuItem6.Size = new Size(201, 22);
            menuItem6.Text = "\u063A\u0644\u0642 \u0627\u0644\u0628\u0631\u0646\u0627\u0645\u062C";
            menuItem6.Click += new EventHandler(menuItem6_Click_1);
            toolStripItemArr = new ToolStripItem[] {
                                                     toolStripMenuItem6, 
                                                     toolStripSeparator2, 
                                                     toolStripMenuItem5 };
            generalDataToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            generalDataToolStripMenuItem.Name = "generalDataToolStripMenuItem";
            generalDataToolStripMenuItem.Size = new Size(81, 20);
            generalDataToolStripMenuItem.Text = "\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0639\u0627\u0645\u0629";
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(162, 22);
            toolStripMenuItem6.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0643\u0644\u064A\u0627\u062A";
            toolStripMenuItem6.Click += new EventHandler(toolStripMenuItem6_Click);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(159, 6);
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(162, 22);
            toolStripMenuItem5.Text = "\u0628\u064A\u0627\u0646\u0627\u062A \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645\u064A\u0646";
            toolStripMenuItem5.Click += new EventHandler(toolStripMenuItem5_Click_1);
            toolStripItemArr = new ToolStripItem[] {
                                                     studentsUnitsDestributionToolStripMenuItem, 
                                                     ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem };
            genToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            genToolStripMenuItem.Name = "genToolStripMenuItem";
            genToolStripMenuItem.Size = new Size(106, 20);
            genToolStripMenuItem.Text = "\u0627\u0644\u062A\u0642\u0627\u0631\u064A\u0631 \u0648\u0627\u0644\u0623\u062D\u0635\u0627\u0626\u064A\u0627\u062A";
            studentsUnitsDestributionToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("studentsUnitsDestributionToolStripMenuItem.Image");
            studentsUnitsDestributionToolStripMenuItem.Name = "studentsUnitsDestributionToolStripMenuItem";
            studentsUnitsDestributionToolStripMenuItem.Size = new Size(189, 22);
            studentsUnitsDestributionToolStripMenuItem.Text = "\u062A\u0648\u0632\u064A\u0639 \u0627\u0644\u0637\u0644\u0627\u0628 \u0639\u0644\u0649 \u0627\u0644\u0643\u0644\u064A\u0627\u062A";
            studentsUnitsDestributionToolStripMenuItem.Click += new EventHandler(studentsUnitsDestributionToolStripMenuItem_Click);
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Name = "\u062A\u0642\u0631\u064A\u0631\u0627\u0644\u0637\u0644\u0627\u0628\u0627\u0644\u0645\u0641\u0635\u0648\u0644\u064A\u0646ToolStripMenuItem";
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Size = new Size(189, 22);
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Text = "\u062A\u0642\u0631\u064A\u0631 \u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u0645\u0641\u0635\u0648\u0644\u064A\u0646";
            ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem.Click += new EventHandler(ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem_Click);
            toolStripItemArr = new ToolStripItem[] {
                                                     toolStripMenuItem9, 
                                                     menuItem4, 
                                                     aboutToolStripMenuItem, 
                                                     toolStripMenuItem4, 
                                                     ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem };
            helpToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(58, 20);
            helpToolStripMenuItem.Text = "\u0645\u0633\u0627\u0639\u062F\u0647";
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(186, 22);
            toolStripMenuItem9.Text = "\u0639\u0631\u0636 \u0627\u0644\u0645\u0633\u0627\u0639\u062F\u0647";
            toolStripMenuItem9.Click += new EventHandler(toolStripMenuItem9_Click);
            menuItem4.Name = "menuItem4";
            menuItem4.Size = new Size(186, 22);
            menuItem4.Text = "\u0639\u0631\u0636 \u0627\u0644\u0634\u0627\u0634\u0647 \u0627\u0644\u0627\u0641\u062A\u062A\u0627\u062D\u064A\u0647";
            menuItem4.Click += new EventHandler(menuItem4_Click_1);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(186, 22);
            aboutToolStripMenuItem.Text = "\u0639\u0646 \u0627\u0644\u0646\u0638\u0627\u0645";
            aboutToolStripMenuItem.Click += new EventHandler(aboutToolStripMenuItem_Click);
            toolStripItemArr = new ToolStripItem[] {
                                                     cascadeToolStripMenuItem, 
                                                     toolStripSeparator6, 
                                                     closeAllToolStripMenuItem };
            windowsToolStripMenuItem.DropDownItems.AddRange(toolStripItemArr);
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(92, 20);
            windowsToolStripMenuItem.Text = "\u0627\u0644\u0646\u0648\u0627\u0641\u0630 \u0627\u0644\u0645\u0641\u062A\u0648\u062D\u0629";
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.Alt;
            cascadeToolStripMenuItem.Size = new Size(152, 22);
            cascadeToolStripMenuItem.Text = "\u062A\u0631\u062A\u064A\u0628 ";
            cascadeToolStripMenuItem.Click += new EventHandler(cascadeToolStripMenuItem_Click);
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(149, 6);
            closeAllToolStripMenuItem.Image = Resources.wrong;
            closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            closeAllToolStripMenuItem.ShortcutKeys = Keys.MButton | Keys.Back | Keys.Alt;
            closeAllToolStripMenuItem.Size = new Size(152, 22);
            closeAllToolStripMenuItem.Text = "\u063A\u0644\u0642 \u0627\u0644\u0643\u0644";
            closeAllToolStripMenuItem.Click += new EventHandler(closeAllToolStripMenuItem_Click);
            toolStripItemArr = new ToolStripItem[] { refreshToolStripMenuItem };
            contextMenuStrip1.Items.AddRange(toolStripItemArr);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 26);
            refreshToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("refreshToolStripMenuItem.Image");
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.RightToLeft = RightToLeft.Yes;
            refreshToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshToolStripMenuItem.Size = new Size(122, 22);
            refreshToolStripMenuItem.Text = "\u062A\u062D\u062F\u064A\u062B";
            refreshToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            refreshToolStripMenuItem.Click += new EventHandler(refreshToolStripMenuItem_Click);
            toolStripItemArr = new ToolStripItem[] {
                                                     toolStripStatusLabel1, 
                                                     count, 
                                                     lbl, 
                                                     reminder };
            statusStrip1.Items.AddRange(toolStripItemArr);
            statusStrip1.Location = new Point(0, 471);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(707, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(77, 17);
            toolStripStatusLabel1.Text = "\u0627\u0644\u0637\u0644\u0627\u0628 \u0627\u0644\u063A\u0627\u0626\u0628\u0648\u062A";
            count.ForeColor = Color.Red;
            count.Name = "count";
            count.RightToLeft = RightToLeft.No;
            count.Size = new Size(34, 17);
            count.Text = "count";
            lbl.Name = "lbl";
            lbl.Size = new Size(77, 17);
            lbl.Text = "\u0627\u0644\u0628\u0648\u0646\u0627\u062A \u0627\u0644\u0645\u062A\u0628\u0642\u064A\u0647";
            reminder.ForeColor = Color.Red;
            reminder.Name = "reminder";
            reminder.RightToLeft = RightToLeft.No;
            reminder.Size = new Size(49, 17);
            reminder.Text = "reminder";
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(237, 6);
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Name = "\u0641\u062A\u062D\u0642\u0627\u0639\u062F\u0647\u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A\u0644\u0644\u0645\u062A\u062E\u0635\u0635\u064A\u0646\u0641\u0642\u0637ToolStripMenuItem";
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Size = new Size(240, 22);
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Text = "\u0641\u062A\u062D \u0642\u0627\u0639\u062F\u0647 \u0627\u0644\u0628\u064A\u0627\u0646\u0627\u062A(\u0644\u0644\u0645\u062A\u062E\u0635\u0635\u064A\u0646 \u0641\u0642\u0637)";
            ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem.Click += new EventHandler(ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem_Click);
            AutoScaleBaseSize = new Size(5, 14);
            BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(707, 493);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\u0627\u0644\u0646\u0627\u0641\u0630\u0629 \u0627\u0644\u0631\u0626\u064A\u0633\u064A\u0647";
            FormClosing += new FormClosingEventHandler(message);
            Load += new EventHandler(Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void makeAbsencePermesstionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // trial
        }

        private void menuItem2_Click_1(object sender, EventArgs e)
        {
            // trial
        }

        private void menuItem4_Click_1(object sender, EventArgs e)
        {
            // trial
        }

        private void menuItem6_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void message(object sender, FormClosingEventArgs e)
        {
            // trial
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Mutility.RefreshMe();
            Form1_Load(null, null);
            Cursor = Cursors.Arrow;
        }

        private void showAbsenceStatusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            status status = new status();
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

        private void studentsUnitsDestributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load("StatisticsReport.rpt");
                reportDocument.Refresh();
                reportV reportV = new reportV();
                reportV.crystalReportViewer1.ReportSource = reportDocument;
                reportV.Show();
            }
            catch (Exception e1)
            {
                MessageBox.Show("\u062D\u062F\u062B \u062E\u0637\u0623 \u0627\u062B\u0646\u0627\u0621 \u062A\u062D\u0645\u064A\u0644 \u0627\u0644\u062A\u0642\u0631\u064A\u0631,\u0644\u0648 \u0627\u0646\u062A \u062E\u0628\u064A\u0631 \u0627\u0644\u062E\u0637\u0623 \u0647\u0648\n" + e1.Message, "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Cursor = Cursors.Arrow;
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Students students = new Students();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StudentsDistribution studentsDistribution = new StudentsDistribution();
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            // trial
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            faculities faculities = new faculities();
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

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("\u0647\u0644 \u0627\u0646\u062A \u0645\u062A\u0623\u0643\u062F \u0645\u0646 \u0627\u0646\u0643 \u062A\u0631\u064A\u062F \u062A\u063A\u064A\u064A\u0631 \u0627\u0644\u0645\u0633\u062A\u062E\u062F\u0645 \u0627\u0644\u062D\u0627\u0644\u0649", "\u062A\u063A\u064A\u064A\u0631 \u0645\u0633\u062A\u062E\u062F\u0645", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            bool flag = dialogResult != DialogResult.Yes;
            if (!flag)
            {
                Form[] formArr = MdiChildren;
                int i = 0;
                while (flag)
                {
                    Form form = formArr[i];
                    form.Close();
                    i++;
                    flag = i < formArr.Length;
                }
                login login = new login(login.Splash.DontShow);
                login.CancelBtn.Text = "Exit Program ";
                login.ShowDialog();
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            // trial
        }

        private void ÊÞÑíÑÇáØáÇÈÇáãÝÕæáíäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load("Dismiss.rpt");
                reportV reportV = new reportV();
                reportV.crystalReportViewer1.ReportSource = reportDocument;
                reportV.crystalReportViewer1.Zoom(65);
                reportV.Show();
            }
            catch (Exception e1)
            {
                MessageBox.Show("\u062D\u062F\u062B \u062E\u0637\u0623 \u0627\u062B\u0646\u0627\u0621 \u062A\u062D\u0645\u064A\u0644 \u0627\u0644\u062A\u0642\u0631\u064A\u0631,\u0644\u0648 \u0627\u0646\u062A \u062E\u0628\u064A\u0631 \u0627\u0644\u062E\u0637\u0623 \u0647\u0648\n" + e1.Message, "\u062E\u0637\u0623", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Cursor = Cursors.Arrow;
        }

        private void ÝÊÍÞÇÚÏåÇáÈíÇäÇÊááãÊÎÕÕíäÝÞØToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // trial
        }

        protected override void Dispose(bool disposing)
        {
            // trial
        }

        [STAThread]
        public static void Main()
        {
            // trial
        }

    } // class Form1

}

