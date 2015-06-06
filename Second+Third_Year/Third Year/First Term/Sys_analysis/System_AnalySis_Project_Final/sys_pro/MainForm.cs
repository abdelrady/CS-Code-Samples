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
        private ToolStripButton toolStripButton1;
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripProgressBar toolStripProgressBar1;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem14;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem15;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem17;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem18;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem23;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem19;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem20;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem21;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem22;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem24;
        private Sunisoft.IrisSkin.SkinCollectionItem skinCollectionItem1;
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
            this.i32x32 = new System.Windows.Forms.ImageList(this.components);
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
            this.skinCollectionItem14 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem17 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem18 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem15 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem23 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem19 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem20 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem21 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem22 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem24 = new Sunisoft.IrisSkin.SkinCollectionItem();
            this.skinCollectionItem1 = new Sunisoft.IrisSkin.SkinCollectionItem();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mainToolStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.mainToolStrip.Size = new System.Drawing.Size(62, 216);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(514, 239);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.mainToolStrip);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 44);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(576, 264);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // targetPanel
            // 
            this.targetPanel.AutoScroll = true;
            this.targetPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.targetPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("targetPanel.BackgroundImage")));
            this.targetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetPanel.Location = new System.Drawing.Point(0, 0);
            this.targetPanel.Name = "targetPanel";
            this.targetPanel.Size = new System.Drawing.Size(514, 239);
            this.targetPanel.TabIndex = 2;
            // 
            // skinEngine1
            // 
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem14);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem17);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem18);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem15);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem23);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem19);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem20);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem21);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem22);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem24);
            this.skinEngine1.AddtionalBuiltInSkins.Add(this.skinCollectionItem1);
            this.skinEngine1.SerialNumber = "2PR15Iv1IkwhDHUM9A81bnJELLFAg qbkYojg8TIPdT_";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // skinCollectionItem14
            // 
            this.skinCollectionItem14.SkinPassword = null;
            this.skinCollectionItem14.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem14.SkinSteam")));
            // 
            // skinCollectionItem17
            // 
            this.skinCollectionItem17.SkinPassword = null;
            this.skinCollectionItem17.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem17.SkinSteam")));
            // 
            // skinCollectionItem18
            // 
            this.skinCollectionItem18.SkinPassword = null;
            this.skinCollectionItem18.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem18.SkinSteam")));
            // 
            // skinCollectionItem15
            // 
            this.skinCollectionItem15.SkinPassword = null;
            this.skinCollectionItem15.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem15.SkinSteam")));
            // 
            // skinCollectionItem23
            // 
            this.skinCollectionItem23.SkinPassword = null;
            this.skinCollectionItem23.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem23.SkinSteam")));
            // 
            // skinCollectionItem19
            // 
            this.skinCollectionItem19.SkinPassword = null;
            this.skinCollectionItem19.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem19.SkinSteam")));
            // 
            // skinCollectionItem20
            // 
            this.skinCollectionItem20.SkinPassword = null;
            this.skinCollectionItem20.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem20.SkinSteam")));
            // 
            // skinCollectionItem21
            // 
            this.skinCollectionItem21.SkinPassword = null;
            this.skinCollectionItem21.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem21.SkinSteam")));
            // 
            // skinCollectionItem22
            // 
            this.skinCollectionItem22.SkinPassword = null;
            this.skinCollectionItem22.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem22.SkinSteam")));
            // 
            // skinCollectionItem24
            // 
            this.skinCollectionItem24.SkinPassword = null;
            this.skinCollectionItem24.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem24.SkinSteam")));
            // 
            // skinCollectionItem1
            // 
            this.skinCollectionItem1.SkinPassword = null;
            this.skinCollectionItem1.SkinSteam = ((System.IO.MemoryStream)(resources.GetObject("skinCollectionItem1.SkinSteam")));
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 286);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(267, 17);
            this.toolStripStatusLabel3.Text = "Copyright © 2006 FCIS SOFT™. All Rights Reserved.";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "UserName:None";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel2.Text = "Loged At: None";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(576, 308);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripContainer1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
            toolStripButton1.Image.Save("e:\\test.jpg");
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
        private void LoginSuccessful(object sender, EventArgs e,string str)
        {
            //  Store the Name in a Variable.
            //this.UsersName = RDB_test.Properties.Settings.Default.UserName;

            //  Alert the user that they have been logged in.
            //String msg = String.Format("You have been logged in as \"{0}\"", this.UsersName.ToUpper());
            //this.statusToolStripStatusLabel.Text = msg;
            //timer2.Start();
            //Thread.Sleep(1000);
            this.toolStripProgressBar1.Value += 20;
            Thread.Sleep(200);
            this.toolStripProgressBar1.Value += 20;
            Thread.Sleep(200);
            this.toolStripProgressBar1.Value += 20;
            Thread.Sleep(200);
            this.toolStripProgressBar1.Value += 20;
            Thread.Sleep(100);
            this.toolStripProgressBar1.Value += 20;
            Thread.Sleep(100);
            this.toolStripProgressBar1.Value = 0;

            accountToolStripButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\33NT_Drive_Disabled.ico");
            accountToolStripButton.ToolTipText = "Logout From System.";
            this.toolStripStatusLabel1.Text = "UserName:" + str.ToUpper();
            this.toolStripStatusLabel2.Text = "Login Time: ("+DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second+")";
            this.targetPanel.Controls.Remove(a);
            this.openDocToolStripButton.Enabled = true;
            
        }
        int currentSkin = 0;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(currentSkin);
            currentSkin++;
            if (currentSkin == 11)
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

        /*private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.toolStripProgressBar1.Value < 100)
                this.toolStripProgressBar1.Value += 20;
            else timer2.Stop();
        }
        */
		
	}
	
	
	
	
}
