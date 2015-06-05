//This Label control allows Linear Gradient Background in the ordinary labal control with the
//given two start and end gradient colors and the gradient mode.
//GradColor1 specifies start gradient color
//GradColor2 specifies end gradient color
//GradMode specifies gradient mode i.e. BackwardDiagonal, Horizontal etc.
//EnableBCGradient specifies whether background should be drawn with gradient brush or without it

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CustomLabelControl
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class CustomLabelControl : System.Windows.Forms.Label
	{
		private bool enableBCGradient = true;
		private Color gradColor1 = Color.AliceBlue;
		private Color gradColor2 = Color.LightSteelBlue;
		private System.Drawing.Drawing2D.LinearGradientMode gradMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;

		[
			Category("Appearance"),
			Description("Start Gradient Color")
		]
		public Color GradColor1
		{
			get
			{
				return this.gradColor1;
			}
			set
			{
				this.gradColor1 = value;
				this.Invalidate();
			}
		}

		[
			Category("Appearance"),
			Description("End Gradient Color")
		]
		public Color GradColor2
		{
			get
			{
				return this.gradColor2;
			}
			set
			{
				this.gradColor2 = value;
				this.Invalidate();
			}
		}

		[
			Category("Appearance"),
			Description("Gradient Mode")
		]
		public System.Drawing.Drawing2D.LinearGradientMode GradMode
		{
			get
			{
				return this.gradMode;
			}
			set
			{
				this.gradMode = value;
				this.Invalidate();
			}
		}

		[
		Category("Behavior"),
		Description("Enables or Disables Background Gradient")
		]
		public bool EnableBCGradient
		{
			get
			{
				return this.enableBCGradient;
			}
			set
			{
				this.enableBCGradient = value;
				this.Invalidate();
			}
		}
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CustomLabelControl()
			:base()
		{
			
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call
			/*
			Graphics graphics = Graphics.FromHwnd(this.Handle);
			Rectangle rect = new Rectangle(this.Left,this.Top,50, 50);
			System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(rect, 
				this.gradColor1, this.gradColor2, this.gradMode);
			graphics.FillRectangle(lb, rect);
			*/			
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
			// 
			// CustomLabelControl
			// 
			this.Size = new System.Drawing.Size(336, 150);

		}
		#endregion

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			base.OnPaintBackground(pevent);

			if(this.enableBCGradient == false)
				return;

			Rectangle rect = new Rectangle(0,0,this.Width, this.Height);
			System.Drawing.Drawing2D.LinearGradientBrush lb = new System.Drawing.Drawing2D.LinearGradientBrush(rect, 
				this.gradColor1, this.gradColor2, this.gradMode);
			pevent.Graphics.FillRectangle(lb, rect);		
		}
	}
}
