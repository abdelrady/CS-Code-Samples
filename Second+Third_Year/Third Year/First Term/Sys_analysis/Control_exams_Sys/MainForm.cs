/*
 * Created by SharpDevelop.
 * User: pc123
 * Date: 1/4/2006
 * Time: 7:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using Library.Win32;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using WindowsApplication1;
using System.Threading;
using System.IO;
namespace DefaultNamespace
{
	/// <summary>
	/// Description of MainForm.	
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
    {
        //choose ab;
        Form1 f1;
        coarse_form f2;
        Connection Asd;
        private IContainer components;
        private Label lblNow;
        private System.Windows.Forms.Timer progressTimer;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStrip mainToolStrip;
        private ToolStripButton accountToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripDropDownButton openDocToolStripButton;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem masterDetailToolStripMenuItem;
        private ToolStripMenuItem detailSheetToolStripMenuItem;
        private ToolStripMenuItem companiesToolStripMenuItem;
        private ToolStripMenuItem jobsToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButtoneXit;
        private ToolStripContentPanel ContentPanel;
        private ToolStripContainer toolStripContainer1;
        private Panel targetPanel;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem1;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem2;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem3;
        private ToolStripButton toolStripButton1;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem4;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem5;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem6;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem7;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem8;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem9;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem10;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem11;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem12;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem13;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem deleteAStudentToolStripMenuItem;
        private ToolStripMenuItem addUpdateStudentGradesToolStripMenuItem;
        private ToolStripMenuItem addNewCourseToolStripMenuItem;
        private ToolStripMenuItem updateCourseInfoToolStripMenuItem;
        private ToolStripMenuItem deleteCourseToolStripMenuItem;
        private ToolStripMenuItem showDetailShToolStripMenuItem;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem showAllStudentsToolStripMenuItem;
        private ToolStripMenuItem showAllCourcesToolStripMenuItem;
        private ToolBarButton tbSep4;
        private ToolBarButton tbAuthor;
        private ToolBarButton tbShortcuts;
        private ToolBarButton tbSep3;
        private ToolBarButton tbCalc;
        private ToolBarButton tbMSPaint;
        private ToolBarButton tbExplorer;
        private ToolBarButton tblWrite;
        private ToolBarButton tbNotepad;
        private ToolBarButton tbSep1;
        private ToolBarButton tbDepartment;
        private ToolBarButton tbEmployees;
        private ToolBar tbTop;
        private ImageList i32x32;
		
		public MainForm(Connection asd)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            Asd = asd;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() 
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblNow = new System.Windows.Forms.Label();
            this.i32x32 = new System.Windows.Forms.ImageList(this.components);
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.accountToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openDocToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateStudentGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCourseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailShToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtoneXit = new System.Windows.Forms.ToolStripButton();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.targetPanel = new System.Windows.Forms.Panel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinCollectionItem1 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem2 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem3 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem4 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem5 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem6 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem7 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem8 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem9 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem10 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem11 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem12 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem13 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSep4 = new System.Windows.Forms.ToolBarButton();
            this.tbAuthor = new System.Windows.Forms.ToolBarButton();
            this.tbShortcuts = new System.Windows.Forms.ToolBarButton();
            this.tbSep3 = new System.Windows.Forms.ToolBarButton();
            this.tbCalc = new System.Windows.Forms.ToolBarButton();
            this.tbMSPaint = new System.Windows.Forms.ToolBarButton();
            this.tbExplorer = new System.Windows.Forms.ToolBarButton();
            this.tblWrite = new System.Windows.Forms.ToolBarButton();
            this.tbNotepad = new System.Windows.Forms.ToolBarButton();
            this.tbSep1 = new System.Windows.Forms.ToolBarButton();
            this.tbDepartment = new System.Windows.Forms.ToolBarButton();
            this.tbEmployees = new System.Windows.Forms.ToolBarButton();
            this.tbTop = new System.Windows.Forms.ToolBar();
            this.mainToolStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNow
            // 
            this.lblNow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNow.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNow.Location = new System.Drawing.Point(0, 275);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(576, 41);
            this.lblNow.TabIndex = 13;
            this.lblNow.Text = "Copyright © 2006 FCIS SOFT™. All Rights Reserved. Visit Our Website at http://www" +
                ".fcis.110mb.com";
            this.lblNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // i32x32
            // 
            this.i32x32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i32x32.ImageStream")));
            this.i32x32.TransparentColor = System.Drawing.Color.Transparent;
            this.i32x32.Images.SetKeyName(0, "");
            this.i32x32.Images.SetKeyName(1, "");
            this.i32x32.Images.SetKeyName(2, "");
            this.i32x32.Images.SetKeyName(3, "");
            this.i32x32.Images.SetKeyName(4, "");
            this.i32x32.Images.SetKeyName(5, "");
            this.i32x32.Images.SetKeyName(6, "");
            this.i32x32.Images.SetKeyName(7, "");
            this.i32x32.Images.SetKeyName(8, "");
            this.i32x32.Images.SetKeyName(9, "");
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 60;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripButton,
            this.toolStripSeparator6,
            this.openDocToolStripButton,
            this.toolStripSeparator8,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButtoneXit});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 3);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(62, 203);
            this.mainToolStrip.TabIndex = 1;
            // 
            // accountToolStripButton
            // 
            this.accountToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("accountToolStripButton.Image")));
            this.accountToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.accountToolStripButton.Name = "accountToolStripButton";
            this.accountToolStripButton.Size = new System.Drawing.Size(60, 36);
            this.accountToolStripButton.ToolTipText = "Login or Create a New Account";
            this.accountToolStripButton.Click += new System.EventHandler(this.accountToolStripButton_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(60, 6);
            // 
            // openDocToolStripButton
            // 
            this.openDocToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openDocToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.companiesToolStripMenuItem,
            this.jobsToolStripMenuItem1,
            this.showDetailShToolStripMenuItem});
            this.openDocToolStripButton.Enabled = false;
            this.openDocToolStripButton.Image = global::WindowsApplication1.Properties.Resources.folder_closed_32;
            this.openDocToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openDocToolStripButton.Name = "openDocToolStripButton";
            this.openDocToolStripButton.Size = new System.Drawing.Size(60, 36);
            this.openDocToolStripButton.Text = "Open an Existing Document";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterDetailToolStripMenuItem,
            this.detailSheetToolStripMenuItem,
            this.deleteAStudentToolStripMenuItem,
            this.showAllStudentsToolStripMenuItem});
            this.employeeToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.documents_321;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.employeeToolStripMenuItem.Text = "Students";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // masterDetailToolStripMenuItem
            // 
            this.masterDetailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masterDetailToolStripMenuItem.Image")));
            this.masterDetailToolStripMenuItem.Name = "masterDetailToolStripMenuItem";
            this.masterDetailToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.masterDetailToolStripMenuItem.Text = "Add New Student";
            this.masterDetailToolStripMenuItem.Click += new System.EventHandler(this.masterDetailToolStripMenuItem_Click_1);
            // 
            // detailSheetToolStripMenuItem
            // 
            this.detailSheetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailSheetToolStripMenuItem.Image")));
            this.detailSheetToolStripMenuItem.Name = "detailSheetToolStripMenuItem";
            this.detailSheetToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.detailSheetToolStripMenuItem.Text = "&Update Existing Student";
            this.detailSheetToolStripMenuItem.Click += new System.EventHandler(this.detailSheetToolStripMenuItem_Click);
            // 
            // deleteAStudentToolStripMenuItem
            // 
            this.deleteAStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteAStudentToolStripMenuItem.Image")));
            this.deleteAStudentToolStripMenuItem.Name = "deleteAStudentToolStripMenuItem";
            this.deleteAStudentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deleteAStudentToolStripMenuItem.Text = "Delete A Student";
            this.deleteAStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteAStudentToolStripMenuItem_Click);
            // 
            // showAllStudentsToolStripMenuItem
            // 
            this.showAllStudentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllStudentsToolStripMenuItem.Image")));
            this.showAllStudentsToolStripMenuItem.Name = "showAllStudentsToolStripMenuItem";
            this.showAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showAllStudentsToolStripMenuItem.Text = "Show All Students";
            this.showAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.showAllStudentsToolStripMenuItem_Click);
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateStudentGradesToolStripMenuItem});
            this.companiesToolStripMenuItem.Image = global::WindowsApplication1.Properties.Resources.documents_322;
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.companiesToolStripMenuItem.Text = "Grades";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // addUpdateStudentGradesToolStripMenuItem
            // 
            this.addUpdateStudentGradesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addUpdateStudentGradesToolStripMenuItem.Image")));
            this.addUpdateStudentGradesToolStripMenuItem.Name = "addUpdateStudentGradesToolStripMenuItem";
            this.addUpdateStudentGradesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.addUpdateStudentGradesToolStripMenuItem.Text = "Add/Update Student Grades";
            this.addUpdateStudentGradesToolStripMenuItem.Click += new System.EventHandler(this.addUpdateStudentGradesToolStripMenuItem_Click);
            // 
            // jobsToolStripMenuItem1
            // 
            this.jobsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCourseToolStripMenuItem,
            this.updateCourseInfoToolStripMenuItem,
            this.deleteCourseToolStripMenuItem,
            this.showAllCourcesToolStripMenuItem});
            this.jobsToolStripMenuItem1.Image = global::WindowsApplication1.Properties.Resources.documents_323;
            this.jobsToolStripMenuItem1.Name = "jobsToolStripMenuItem1";
            this.jobsToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.jobsToolStripMenuItem1.Text = "Cources";
            this.jobsToolStripMenuItem1.Click += new System.EventHandler(this.jobsToolStripMenuItem1_Click);
            // 
            // addNewCourseToolStripMenuItem
            // 
            this.addNewCourseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewCourseToolStripMenuItem.Image")));
            this.addNewCourseToolStripMenuItem.Name = "addNewCourseToolStripMenuItem";
            this.addNewCourseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addNewCourseToolStripMenuItem.Text = "Add New Course";
            this.addNewCourseToolStripMenuItem.Click += new System.EventHandler(this.addNewCourseToolStripMenuItem_Click);
            // 
            // updateCourseInfoToolStripMenuItem
            // 
            this.updateCourseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateCourseInfoToolStripMenuItem.Image")));
            this.updateCourseInfoToolStripMenuItem.Name = "updateCourseInfoToolStripMenuItem";
            this.updateCourseInfoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.updateCourseInfoToolStripMenuItem.Text = "Update Course Info";
            this.updateCourseInfoToolStripMenuItem.Click += new System.EventHandler(this.updateCourseInfoToolStripMenuItem_Click);
            // 
            // deleteCourseToolStripMenuItem
            // 
            this.deleteCourseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteCourseToolStripMenuItem.Image")));
            this.deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            this.deleteCourseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteCourseToolStripMenuItem.Text = "Delete Course";
            this.deleteCourseToolStripMenuItem.Click += new System.EventHandler(this.deleteCourseToolStripMenuItem_Click);
            // 
            // showAllCourcesToolStripMenuItem
            // 
            this.showAllCourcesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllCourcesToolStripMenuItem.Image")));
            this.showAllCourcesToolStripMenuItem.Name = "showAllCourcesToolStripMenuItem";
            this.showAllCourcesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showAllCourcesToolStripMenuItem.Text = "Show All Cources";
            this.showAllCourcesToolStripMenuItem.Click += new System.EventHandler(this.showAllCourcesToolStripMenuItem_Click);
            // 
            // showDetailShToolStripMenuItem
            // 
            this.showDetailShToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailShToolStripMenuItem.Image")));
            this.showDetailShToolStripMenuItem.Name = "showDetailShToolStripMenuItem";
            this.showDetailShToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showDetailShToolStripMenuItem.Text = "Show Detail Sheet";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(60, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 36);
            this.toolStripButton1.ToolTipText = "Change Program Skin";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 36);
            this.toolStripButton2.Text = "Show Help";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtoneXit
            // 
            this.toolStripButtoneXit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtoneXit.Image")));
            this.toolStripButtoneXit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtoneXit.Name = "toolStripButtoneXit";
            this.toolStripButtoneXit.Size = new System.Drawing.Size(60, 36);
            this.toolStripButtoneXit.Text = "Exit";
            this.toolStripButtoneXit.ToolTipText = "Exit The Application";
            this.toolStripButtoneXit.Click += new System.EventHandler(this.toolStripButtoneXit_Click_1);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(513, 174);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.targetPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(514, 206);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.mainToolStrip);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 44);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(576, 231);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // targetPanel
            // 
            this.targetPanel.AutoScroll = true;
            this.targetPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.targetPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("targetPanel.BackgroundImage")));
            this.targetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetPanel.Location = new System.Drawing.Point(0, 0);
            this.targetPanel.Name = "targetPanel";
            this.targetPanel.Size = new System.Drawing.Size(515, 245);
            this.targetPanel.TabIndex = 2;
            // 
            // skinEngine1
            // 
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem1);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem2);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem3);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem4);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem5);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem6);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem7);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem8);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem9);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem10);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem11);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem12);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem13);
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // skinCollectionItem1
            // 
            this.skinCollectionItem1.SkinPassword = null;
            this.skinCollectionItem1.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem1.SkinSteam")));
            // 
            // skinCollectionItem2
            // 
            this.skinCollectionItem2.SkinPassword = null;
            this.skinCollectionItem2.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem2.SkinSteam")));
            // 
            // skinCollectionItem3
            // 
            this.skinCollectionItem3.SkinPassword = null;
            this.skinCollectionItem3.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem3.SkinSteam")));
            // 
            // skinCollectionItem4
            // 
            this.skinCollectionItem4.SkinPassword = null;
            this.skinCollectionItem4.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem4.SkinSteam")));
            // 
            // skinCollectionItem5
            // 
            this.skinCollectionItem5.SkinPassword = null;
            this.skinCollectionItem5.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem5.SkinSteam")));
            // 
            // skinCollectionItem6
            // 
            this.skinCollectionItem6.SkinPassword = null;
            this.skinCollectionItem6.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem6.SkinSteam")));
            // 
            // skinCollectionItem7
            // 
            this.skinCollectionItem7.SkinPassword = null;
            this.skinCollectionItem7.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem7.SkinSteam")));
            // 
            // skinCollectionItem8
            // 
            this.skinCollectionItem8.SkinPassword = null;
            this.skinCollectionItem8.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem8.SkinSteam")));
            // 
            // skinCollectionItem9
            // 
            this.skinCollectionItem9.SkinPassword = null;
            this.skinCollectionItem9.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem9.SkinSteam")));
            // 
            // skinCollectionItem10
            // 
            this.skinCollectionItem10.SkinPassword = null;
            this.skinCollectionItem10.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem10.SkinSteam")));
            // 
            // skinCollectionItem11
            // 
            this.skinCollectionItem11.SkinPassword = null;
            this.skinCollectionItem11.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem11.SkinSteam")));
            // 
            // skinCollectionItem12
            // 
            this.skinCollectionItem12.SkinPassword = null;
            this.skinCollectionItem12.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem12.SkinSteam")));
            // 
            // skinCollectionItem13
            // 
            this.skinCollectionItem13.SkinPassword = null;
            this.skinCollectionItem13.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem13.SkinSteam")));
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbSep4
            // 
            this.tbSep4.Name = "tbSep4";
            this.tbSep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbAuthor
            // 
            this.tbAuthor.ImageIndex = 4;
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ToolTipText = "Authors";
            // 
            // tbShortcuts
            // 
            this.tbShortcuts.ImageIndex = 3;
            this.tbShortcuts.Name = "tbShortcuts";
            this.tbShortcuts.ToolTipText = "Key Shortcuts";
            // 
            // tbSep3
            // 
            this.tbSep3.Name = "tbSep3";
            this.tbSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbCalc
            // 
            this.tbCalc.ImageIndex = 5;
            this.tbCalc.Name = "tbCalc";
            this.tbCalc.ToolTipText = "Calculator";
            // 
            // tbMSPaint
            // 
            this.tbMSPaint.ImageIndex = 7;
            this.tbMSPaint.Name = "tbMSPaint";
            this.tbMSPaint.ToolTipText = "MS Paint";
            // 
            // tbExplorer
            // 
            this.tbExplorer.ImageIndex = 6;
            this.tbExplorer.Name = "tbExplorer";
            this.tbExplorer.ToolTipText = "Explorer";
            // 
            // tblWrite
            // 
            this.tblWrite.ImageIndex = 8;
            this.tblWrite.Name = "tblWrite";
            this.tblWrite.ToolTipText = "Wordpad";
            // 
            // tbNotepad
            // 
            this.tbNotepad.ImageIndex = 9;
            this.tbNotepad.Name = "tbNotepad";
            this.tbNotepad.ToolTipText = "Notepad";
            // 
            // tbSep1
            // 
            this.tbSep1.Name = "tbSep1";
            this.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbDepartment
            // 
            this.tbDepartment.ImageIndex = 1;
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.ToolTipText = "Department\'s Records";
            // 
            // tbEmployees
            // 
            this.tbEmployees.ImageIndex = 0;
            this.tbEmployees.Name = "tbEmployees";
            this.tbEmployees.ToolTipText = "Employee\'s Records";
            // 
            // tbTop
            // 
            this.tbTop.AllowDrop = true;
            this.tbTop.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbTop.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbEmployees,
            this.tbDepartment,
            this.tbSep1,
            this.tbNotepad,
            this.tblWrite,
            this.tbExplorer,
            this.tbMSPaint,
            this.tbCalc,
            this.tbSep3,
            this.tbShortcuts,
            this.tbAuthor,
            this.tbSep4});
            this.tbTop.ButtonSize = new System.Drawing.Size(39, 20);
            this.tbTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbTop.DropDownArrows = true;
            this.tbTop.ImageList = this.i32x32;
            this.tbTop.Location = new System.Drawing.Point(0, 0);
            this.tbTop.Name = "tbTop";
            this.tbTop.ShowToolTips = true;
            this.tbTop.Size = new System.Drawing.Size(576, 44);
            this.tbTop.TabIndex = 12;
            this.tbTop.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbTop_ButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 316);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.lblNow);
            this.Controls.Add(this.tbTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		
		private void student_f_Click(object sender, System.EventArgs e)
		{
			

		}

		private void coarse_f_Click(object sender, System.EventArgs e)
		{
			
		}
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Run(new Form3());
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            ClassLibrary2.Class1 class2 = new ClassLibrary2.Class1();
            class2.SetProcessWorkingSetSize();
            this.Text = "Today is:  " + DateTime.Now.ToLongDateString() + " [ " + DateTime.Now.ToLongTimeString() + " ] ";
            f1 = new Form1(Asd);
            f2 = new  coarse_form(Asd);
        }

        private void mnuNotepad_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("notepad.exe");
            this.Cursor = Cursors.Default;		
        }

        private void mnuExplorer_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("explorer.exe");
            this.Cursor = Cursors.Default;	
        }

        private void mnuCalc_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("calc.exe");
            this.Cursor = Cursors.Default;
        }

        private void mnuPaint_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("MSPaint.exe");
            this.Cursor = Cursors.Default;
        }

        private void mnuWorpad_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Diagnostics.Process.Start("Write.exe");
            this.Cursor = Cursors.Default;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            MainForm_FormClosing(sender, e);
        }
        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            try{Asd.MyConnection.Close();}
                catch(OleDbException){}
            FormEffect.Fade.Out(this, 0, .05);
        }

        private void mainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButtoneXit_Click(object sender, EventArgs e)
        {
            MainForm_FormClosing(sender, e);
        }

        private void targetPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void masterDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();*/
        }

        private void tbTop_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.ToolTipText == "Employee's Records")
            {
                //mnuEmployees.PerformClick();
            }
            else if (e.Button.ToolTipText == "Department's Records")
            {
                //mnuDepartments.PerformClick();
            }
            else if (e.Button.ToolTipText == "Notepad")
            {
                if (clsFunctions.shell("notepad.exe") == false)
                {
                    MessageBox.Show("No Notepad installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.Button.ToolTipText == "Wordpad")
            {
                if (clsFunctions.shell("Write.exe") == false)
                {
                    MessageBox.Show("No Wordpad installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.Button.ToolTipText == "Explorer")
            {
                if (clsFunctions.shell("explorer.exe") == false)
                {
                    MessageBox.Show("No Explorer installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.Button.ToolTipText == "MS Paint")
            {
                if (clsFunctions.shell("MSPaint.exe") == false)
                {
                    MessageBox.Show("No MS Paint installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.Button.ToolTipText == "Calculator")
            {
                if (clsFunctions.shell("calc.exe") == false)
                {
                    MessageBox.Show("No Calculator installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.Button.ToolTipText == "Key Shortcuts")
            {
                tmp a = new tmp();
                a.ShowDialog();
            }
            else if (e.Button.ToolTipText == "Authors")
            {
                this.toolStripButton2.PerformClick();
            }				
        }
    private login a; 
 
        private void accountToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (accountToolStripButton.ToolTipText == "Login or Create a New Account")
            {
                a = new login(Asd);
                a.loginSuccessful +=
                        new login.LoginSuccessful(LoginSuccessful);
                a.Top += 30;
                a.Left += 20;
                this.targetPanel.Controls.Add(a);
                a.Show();
                
            }
            else if (accountToolStripButton.ToolTipText == "Logout From System.")
            {
                accountToolStripButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\32NT_Drive.ico");
                accountToolStripButton.ToolTipText = "Login or Create a New Account";
                this.targetPanel.Controls.Clear();
                this.openDocToolStripButton.Enabled = false;
            }
        }
        private void LoginSuccessful(object sender, EventArgs e)
        {
            //  Store the Name in a Variable.
            //this.UsersName = RDB_test.Properties.Settings.Default.UserName;

            //  Alert the user that they have been logged in.
            //String msg = String.Format("You have been logged in as \"{0}\"", this.UsersName.ToUpper());
            //this.statusToolStripStatusLabel.Text = msg;
            accountToolStripButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\33NT_Drive_Disabled.ico");
            accountToolStripButton.ToolTipText = "Logout From System.";
            this.targetPanel.Controls.Remove(a);
            this.openDocToolStripButton.Enabled = true;
            
        }
        int currentSkin = 0;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(currentSkin);
            currentSkin++;
            if (currentSkin == 13)
                currentSkin = 0;
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }

            private void timer_Tick(object sender, System.EventArgs e)
		{
			
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Today is:  " + DateTime.Now.ToLongDateString() + " [ " + DateTime.Now.ToLongTimeString() + " ] ";

        }

        private void toolStripButtoneXit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void masterDetailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            f1.choose(1);
            f1.ShowDialog();
            
            /*ab = new choose();
            ab.Top += 30;
            ab.Left += 20;
            this.targetPanel.Controls.Add(ab);
            ab.Show();*/
        }

        private void detailSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.choose(3);
            f1.ShowDialog();
        }

        private void deleteAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.choose(4);
            f1.ShowDialog();
        }

        private void showAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.choose(0);
            f1.ShowDialog();
        }

        private void addUpdateStudentGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.choose(5);
            f1.ShowDialog();
        }

        private void addNewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.choose(1);
            f2.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(f1==null)
                f1 = new Form1(Asd);
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 == null)
                f1 = new Form1(Asd);
        }

        private void jobsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (f2 == null)
                f2 = new coarse_form(Asd);
        }

        private void updateCourseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.choose(2);
            f2.ShowDialog();
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.choose(3);
            f2.ShowDialog();
        }

        private void showAllCourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.choose(0);
            f2.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new AboutBox(this.Handle.ToInt32(), this.Icon.Handle.ToInt32(), "Exams Control Room System", "Version 1.0.748787").Show();
        }
        
		
	}
	
	
	
	
}
