#define debug

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CustomCollapsableGroupBox2
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	/// 

	public class CollapsableGroupBox : System.Windows.Forms.ContainerControl
	{
		#region data field declarations	

		public event System.EventHandler CollapsedStateChanged;
	
		private bool autoHide;//if set true, control will automatically collapse/expand itself.
		private bool smoothCollapse;
		private int smoothCollapseSpeed;
		private bool mouseOnContainerArea;//used internally for autoHide functionality.
		private int timeToAutoHide;//time in milliseconds after which the control autohides itself.
		private int timeToAutoHideCounter;//temporary used for measuring the time in 
		//timer2_tick event to detect whether the timeToAutoHide has passed or not.

		private bool isChangingState;//is ture when smoothCollapse is true and the control is 
		//changing its state.

		private bool collapsed;
		private bool borderVisible;
		private int actualHeight;//stores the expanded state height, that is set at design time
		private int expandedStateHeight;//used to store the groupbox height temporarily when its collapsed
		private System.Drawing.Color originalCaptionTextColor;
		private System.Drawing.Color highlightCaptionTextColor;
		private System.Drawing.Color borderColor;
		
		private System.Windows.Forms.PictureBox picArrowUp;
		private System.Windows.Forms.PictureBox picArrowDown;
		private System.Windows.Forms.PictureBox picArrowUpHighlight;		
		private System.Windows.Forms.PictureBox picArrowDownHighlight;		
		private CustomLabelControl.CustomLabelControl lblCaption;
		private System.Windows.Forms.Splitter splitterBottom;
		private System.Windows.Forms.Splitter splitterLeft;
		private System.Windows.Forms.Splitter splitterRight;
		private System.Windows.Forms.Timer timerAutoHide;
		private System.Windows.Forms.Timer timerSmoothCollapse;
		//private System.Windows.Forms.Splitter splitterRight;
		
		private System.ComponentModel.IContainer components;

		#endregion

		#region properties

		[
		Category("Layout"),
		Description("Sets the initial state of groupbox to collapsed or expanded")
		]
		public bool Collapsed
		{
			get
			{
				return this.collapsed;
			}
			set
			{
				this.collapsed = value;
				this.ToggleCollapseState();
			}
		}

		[
		Category("Appearance"),
		Description("Toggles the visibility of the borders.")
		]
		public bool BorderVisible
		{
			get
			{
				return this.borderVisible;
			}
			set
			{
				this.borderVisible = value;
				this.splitterBottom.Visible = this.borderVisible;
				this.splitterLeft.Visible = this.borderVisible;
				this.splitterRight.Visible = this.borderVisible;
			}
		}



		[
		Category("Appearance"),
		Description("Sets the border color.")
		]
		public System.Drawing.Color BorderColor
		{
			get
			{
				return this.borderColor;
			}
			set
			{
				this.borderColor = value;				
				this.splitterBottom.BackColor = this.borderColor;
				this.splitterLeft.BackColor = this.borderColor;
				this.splitterRight.BackColor = this.borderColor;
			}
		}



		[
		Category("Appearance"),
		Description("Sets the border thickness (Default=1, Maximum Possible=3, Minimum Possible=1)")
		]
		public int BorderThickness
		{
			get
			{
				return this.splitterLeft.Size.Width;
			}
			set
			{				
				if(value>=1 && value<=3)
				{	
					this.splitterLeft.Width = value;
					this.splitterRight.Width = value;
					this.splitterBottom.Height = value;									
				}
			}
		}



		[
		Category("Appearance"),
		Description("Sets the caption text color.")
		]
		public System.Drawing.Color CaptionTextColor
		{
			get
			{
				return this.originalCaptionTextColor;
			}
			set
			{
				this.originalCaptionTextColor = value;
				this.lblCaption.ForeColor = this.originalCaptionTextColor;
			}
		}

		[
		Category("Appearance"),
		Description("Sets the highlight caption text color.")
		]
		public System.Drawing.Color HighlightCaptionTextColor
		{
			get
			{
				return this.highlightCaptionTextColor;
			}
			set
			{
				this.highlightCaptionTextColor = value;				
			}
		}



		[
		Category("Appearance"),
		Description("Sets the text of the caption.")
		]
		public override string Text
		{
			get
			{
				return this.lblCaption.Text;
			}
			set
			{
				this.lblCaption.Text = value;								
			}
		}

		[
		Category("Behavior"),
		Description("Enables/disables the smooth state change behavior of the control.")
		]
		public bool SmoothCollapse
		{
			get
			{
				return this.smoothCollapse;
			}
			set
			{
				this.smoothCollapse = value;								
			}
		}

		[
		Category("Behavior"),
		Description("Sets the speed,Between 1(slowest) to 15(fastest), at which the control changes state smoothly, if enabled.")
		]
		public int SmoothCollapseSpeed
		{
			get
			{
				return this.smoothCollapseSpeed;
			}
			set
			{
				if(value >= 1 && value <=15)
				{
					this.smoothCollapseSpeed = value;								
					this.timerSmoothCollapse.Interval = this.smoothCollapseSpeed;
				}				
			}
		}

		[
		Category("Behavior"),
		Description("Enables or Disables Caption Background Gradient")
		]
		public bool CaptionEnableBCGradient
		{
			get
			{
				return this.lblCaption.EnableBCGradient;
			}
			set
			{
				this.lblCaption.EnableBCGradient = value;				
			}
		}

		[
		Category("Appearance"),
		Description("Caption Back Color")
		]
		public Color CaptionBackColor
		{
			get
			{
				return this.lblCaption.BackColor;
			}
			set
			{
				this.lblCaption.BackColor = value;				
			}
		}

		[
		Category("Appearance"),
		Description("Caption Start Gradient Color")
		]
		public Color CaptionGradColor1
		{
			get
			{
				return this.lblCaption.GradColor1;
			}
			set
			{
				this.lblCaption.GradColor1 = value;				
			}
		}

		[
		Category("Appearance"),
		Description("Caption End Gradient Color")
		]
		public Color CaptionGradColor2
		{
			get
			{
				return this.lblCaption.GradColor2;
			}
			set
			{
				this.lblCaption.GradColor2 = value;				
			}
		}

		[
		Category("Appearance"),
		Description("Caption Gradient Mode")
		]
		public System.Drawing.Drawing2D.LinearGradientMode CaptionGradMode
		{
			get
			{
				return this.lblCaption.GradMode;
			}
			set
			{
				this.lblCaption.GradMode = value;				
			}
		}

		[
		Category("Appearance"),
		Description("Caption Text Alignment")
		]
		public System.Drawing.ContentAlignment CaptionTextAlignment
		{
			get
			{
				return this.lblCaption.TextAlign;				
			}
			set
			{
				this.lblCaption.TextAlign = value;				
			}
		}



		[
		Category("Appearance"),
		Description("The height of the caption (Default=26, Maximum Possible=20, Minimum Possible=40)")
		]
		public int CaptionHeight
		{
			get
			{
				return this.lblCaption.Height;
			}
			set
			{
				if(value >= 20  &&  value <= 40)
					this.lblCaption.Height = value;
			}
		}



		public int ActualHeight
		{
			get
			{
				return this.actualHeight;
			}
		}



		[
		Category("Behavior"),
		Description("Auto expandes/copllapses when the mouse enters/leaves thec control.")
		]
		public bool AutoHide
		{
			get
			{
				return this.autoHide;
			}
			set
			{
				this.autoHide = value;
			}
		}



		[
		Category("Behavior"),
		Description("Time in milliseconds after which the control auto-collapses itself, if AutoHide"+
			" is set to true. (Default=0, Minimum Possible=0, MaximumPossible=2000")
		]
		public int TimeToAutoHide
		{
			get
			{
				return this.timeToAutoHide;
			}
			set
			{
				if(value >=0  &&  value <= 2000)
					this.timeToAutoHide = value;
			}
		}

		#endregion

		#region Methods
		public CollapsableGroupBox()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call
			this.collapsed = false;
			this.borderVisible = true;
			this.borderColor = System.Drawing.Color.White;
			this.originalCaptionTextColor = System.Drawing.Color.SteelBlue;
			this.highlightCaptionTextColor = System.Drawing.Color.DodgerBlue;
			this.lblCaption.ForeColor = this.originalCaptionTextColor;
			
			this.smoothCollapse = false;
			this.smoothCollapseSpeed = 5;
			this.timerSmoothCollapse.Interval = this.smoothCollapseSpeed;	
			this.actualHeight = this.Height;
			this.autoHide = false;
			this.mouseOnContainerArea = false;
			this.isChangingState = false;
			this.timeToAutoHide = 0;
			this.timerAutoHide.Interval = 100;
			this.timeToAutoHideCounter = 0;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CollapsableGroupBox));
			this.picArrowDownHighlight = new System.Windows.Forms.PictureBox();
			this.picArrowDown = new System.Windows.Forms.PictureBox();
			this.picArrowUp = new System.Windows.Forms.PictureBox();
			this.picArrowUpHighlight = new System.Windows.Forms.PictureBox();
			this.lblCaption = new CustomLabelControl.CustomLabelControl();
			this.timerSmoothCollapse = new System.Windows.Forms.Timer(this.components);
			this.splitterBottom = new System.Windows.Forms.Splitter();
			this.splitterLeft = new System.Windows.Forms.Splitter();
			this.splitterRight = new System.Windows.Forms.Splitter();
			this.timerAutoHide = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// picArrowDownHighlight
			// 
			this.picArrowDownHighlight.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.picArrowDownHighlight.Image = ((System.Drawing.Image)(resources.GetObject("picArrowDownHighlight.Image")));
			this.picArrowDownHighlight.Location = new System.Drawing.Point(17, 17);
			this.picArrowDownHighlight.Name = "picArrowDownHighlight";
			this.picArrowDownHighlight.Size = new System.Drawing.Size(18, 18);
			this.picArrowDownHighlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picArrowDownHighlight.TabIndex = 9;
			this.picArrowDownHighlight.TabStop = false;
			this.picArrowDownHighlight.Visible = false;
			// 
			// picArrowDown
			// 
			this.picArrowDown.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.picArrowDown.Image = ((System.Drawing.Image)(resources.GetObject("picArrowDown.Image")));
			this.picArrowDown.Location = new System.Drawing.Point(17, 54);
			this.picArrowDown.Name = "picArrowDown";
			this.picArrowDown.Size = new System.Drawing.Size(18, 18);
			this.picArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picArrowDown.TabIndex = 8;
			this.picArrowDown.TabStop = false;
			this.picArrowDown.Visible = false;
			// 
			// picArrowUp
			// 
			this.picArrowUp.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.picArrowUp.Image = ((System.Drawing.Image)(resources.GetObject("picArrowUp.Image")));
			this.picArrowUp.Location = new System.Drawing.Point(140, 17);
			this.picArrowUp.Name = "picArrowUp";
			this.picArrowUp.Size = new System.Drawing.Size(18, 18);
			this.picArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picArrowUp.TabIndex = 7;
			this.picArrowUp.TabStop = false;
			this.picArrowUp.Visible = false;
			// 
			// picArrowUpHighlight
			// 
			this.picArrowUpHighlight.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.picArrowUpHighlight.Image = ((System.Drawing.Image)(resources.GetObject("picArrowUpHighlight.Image")));
			this.picArrowUpHighlight.Location = new System.Drawing.Point(17, 54);
			this.picArrowUpHighlight.Name = "picArrowUpHighlight";
			this.picArrowUpHighlight.Size = new System.Drawing.Size(18, 18);
			this.picArrowUpHighlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picArrowUpHighlight.TabIndex = 6;
			this.picArrowUpHighlight.TabStop = false;
			this.picArrowUpHighlight.Visible = false;
			// 
			// lblCaption
			// 
			this.lblCaption.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblCaption.EnableBCGradient = true;
			this.lblCaption.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCaption.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblCaption.GradColor1 = System.Drawing.Color.White;
			this.lblCaption.GradColor2 = System.Drawing.Color.LightSteelBlue;
			this.lblCaption.GradMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.lblCaption.Image = ((System.Drawing.Image)(resources.GetObject("lblCaption.Image")));
			this.lblCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblCaption.Location = new System.Drawing.Point(0, 0);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(200, 26);
			this.lblCaption.TabIndex = 1;
			this.lblCaption.Text = "My Collapsable Groupbox";
			this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCaption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseUp);
			this.lblCaption.MouseEnter += new System.EventHandler(this.lblCaption_MouseEnter);
			this.lblCaption.MouseLeave += new System.EventHandler(this.lblCaption_MouseLeave);
			// 
			// timerSmoothCollapse
			// 
			this.timerSmoothCollapse.Tick += new System.EventHandler(this.timerSmoothCollapse_Tick);
			// 
			// splitterBottom
			// 
			this.splitterBottom.BackColor = System.Drawing.Color.White;
			this.splitterBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitterBottom.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitterBottom.Location = new System.Drawing.Point(17, 54);
			this.splitterBottom.Name = "splitterBottom";
			this.splitterBottom.Size = new System.Drawing.Size(200, 1);
			this.splitterBottom.TabIndex = 4;
			this.splitterBottom.TabStop = false;
			this.splitterBottom.MouseLeave += new System.EventHandler(this.splitters_MouseLeave);
			// 
			// splitterLeft
			// 
			this.splitterLeft.BackColor = System.Drawing.Color.White;
			this.splitterLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitterLeft.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitterLeft.Location = new System.Drawing.Point(17, 37);
			this.splitterLeft.Name = "splitterLeft";
			this.splitterLeft.Size = new System.Drawing.Size(1, 141);
			this.splitterLeft.TabIndex = 5;
			this.splitterLeft.TabStop = false;
			this.splitterLeft.MouseLeave += new System.EventHandler(this.splitters_MouseLeave);
			// 
			// splitterRight
			// 
			this.splitterRight.BackColor = System.Drawing.Color.White;
			this.splitterRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitterRight.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitterRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitterRight.Location = new System.Drawing.Point(248, 17);
			this.splitterRight.Name = "splitterRight";
			this.splitterRight.Size = new System.Drawing.Size(1, 141);
			this.splitterRight.TabIndex = 6;
			this.splitterRight.TabStop = false;
			this.splitterRight.MouseLeave += new System.EventHandler(this.splitters_MouseLeave);
			// 
			// timerAutoHide
			// 
			this.timerAutoHide.Tick += new System.EventHandler(this.timerAutoHide_Tick);
			// 
			// CollapsableGroupBox
			// 
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Controls.Add(this.splitterRight);
			this.Controls.Add(this.splitterLeft);
			this.Controls.Add(this.splitterBottom);
			this.Controls.Add(this.lblCaption);
			this.Size = new System.Drawing.Size(200, 168);
			this.Resize += new System.EventHandler(this.CollapsableGroupBox_Resize);
			this.MouseEnter += new System.EventHandler(this.CollapsableGroupBox_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.CollapsableGroupBox_MouseLeave);
			this.ResumeLayout(false);

		}
		#endregion

		private void ToggleCollapseState()
		{
			if(this.collapsed == true)
			{
				this.expandedStateHeight = this.actualHeight;
				if(this.borderVisible == true)
					this.splitterBottom.Visible = false;				
				this.lblCaption.Image = this.picArrowDown.Image;

				if(this.smoothCollapse == true && this.DesignMode == false)
				{
					this.isChangingState = true;
					this.timerSmoothCollapse.Enabled = true;
				}
				else					
					this.Height = this.lblCaption.Height;
			}
			else
			{				
				if(this.borderVisible == true)
					this.splitterBottom.Visible = true;
				this.lblCaption.Image = this.picArrowUp.Image;

				if(this.smoothCollapse == true  &&  this.DesignMode == false)
				{
					this.timerSmoothCollapse.Enabled = true;
					this.isChangingState = true;
				}
				else					
					this.Height = this.expandedStateHeight;			
			}
		}


		private void timerSmoothCollapse_Tick(object sender, System.EventArgs e)
		{
			//user wanted the control to be in collapsed state
			if(this.collapsed == true)
			{
				if(this.Height > this.lblCaption.Height)
				{
					if(this.Height - this.smoothCollapseSpeed >= this.lblCaption.Height)
						this.Height -= this.smoothCollapseSpeed;
					else
						this.Height = this.lblCaption.Height;
				}
				else
					this.timerSmoothCollapse.Enabled = false;													
			}
			else//user wanted the control to be in expanded state
			{
				if(this.Height < this.expandedStateHeight)
				{
					if(this.Height + this.smoothCollapseSpeed <= this.expandedStateHeight)
						this.Height += this.smoothCollapseSpeed;
					else
						this.Height = this.expandedStateHeight;
				}
				else
					this.timerSmoothCollapse.Enabled = false;					
			}			
		}


		private void lblCaption_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{		
			this.InitiateStateChange(!(this.collapsed), sender, e);			
		}


		private void lblCaption_MouseEnter(object sender, System.EventArgs e)
		{
			this.lblCaption.ForeColor = this.highlightCaptionTextColor;
			if(this.collapsed == false)
				this.lblCaption.Image = this.picArrowUpHighlight.Image;				
			else
				this.lblCaption.Image = this.picArrowDownHighlight.Image;				

			if(this.autoHide == true)
				this.CollapsableGroupBox_MouseEnter(sender, e);
		}


		private void lblCaption_MouseLeave(object sender, System.EventArgs e)
		{
			this.lblCaption.ForeColor = this.originalCaptionTextColor;
			if(this.collapsed == false)
				this.lblCaption.Image = this.picArrowUp.Image;				
			else
				this.lblCaption.Image = this.picArrowDown.Image;		
		
			if(this.autoHide == true)
				this.CollapsableGroupBox_MouseLeave(sender, e);
		}


		private void CollapsableGroupBox_MouseEnter(object sender, System.EventArgs e)
		{
			if(this.autoHide == true  &&  this.collapsed == true  &&  this.DesignMode == false)
			{
				this.mouseOnContainerArea = true;		
				this.InitiateStateChange(false, sender, e);
			}
		}


		private void CollapsableGroupBox_MouseLeave(object sender, System.EventArgs e)
		{
			if(this.autoHide == true  &&  this.collapsed == false  &&  this.DesignMode == false)
			{
				//Check if mouse has actually left the groupbox boundaries and is not on any of the
				//controls inside the groupbox
				System.Drawing.Point mousePos = this.PointToClient(System.Windows.Forms.Form.MousePosition);
				int mouseX = mousePos.X;
				int mouseY = mousePos.Y;
			
				if(mouseX<0  ||  mouseX>=this.Width   ||  mouseY<0  ||  mouseY>=this.Height)
				{//yes mouse is outside the boundaries of groupbox
					this.mouseOnContainerArea = false;
									
					if(this.timeToAutoHide == 0)//directly initiate state change; no need to enable timer
						this.InitiateStateChange(true, sender, e);
					else if(this.timerAutoHide.Enabled == false)
						this.timerAutoHide.Enabled = true;					
				}			
			}
		}


		private void CollapsableGroupBox_Resize(object sender, System.EventArgs e)
		{
			if(this.collapsed!= true  &&  this.isChangingState != true)
				this.actualHeight = this.Height;
		}


		private void InitiateStateChange(bool collapse, object sender, System.EventArgs e)
		{
			this.collapsed = collapse;
			this.ToggleCollapseState();
			if(this.CollapsedStateChanged != null) 
				this.CollapsedStateChanged(sender, e);
		}


		private void timerAutoHide_Tick(object sender, System.EventArgs e)
		{
			if(this.mouseOnContainerArea == true)
			{
				this.timeToAutoHideCounter = 0;
				this.timerAutoHide.Enabled = false;
				return;
			}

			this.timeToAutoHideCounter += this.timerAutoHide.Interval;	
			
			if(this.timeToAutoHideCounter >= this.timeToAutoHide)
			{
				this.timerAutoHide.Enabled = false;
				this.timeToAutoHideCounter = 0;
				this.InitiateStateChange(true, sender, e);
			}		
		}


		private void splitters_MouseLeave(object sender, System.EventArgs e)
		{
			if(this.autoHide == true)
				this.CollapsableGroupBox_MouseLeave(sender, e);
		}


		#endregion		

	}
}
