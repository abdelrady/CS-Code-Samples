using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CDPlayer
{
	public class SlideDialog : System.Windows.Forms.Form
	{
		public int SelectedValue = 0;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer timer1;
		protected Form _oOwner;
		public enum SLIDE_DIRECTION {TOP, LEFT, BOTTOM, RIGHT};
		protected SLIDE_DIRECTION _eSlideDirection;
		private float _fRatio; 
		private float _fStep;
		private bool _bExpand;
		private SizeF _oOffset;
		private SizeF _oStep;
		private System.Windows.Forms.PictureBox Background;
		private System.Windows.Forms.ListView DriveView;
		private System.Windows.Forms.ImageList ImageList;
		private Point _oOrigin;
		/// <summary>
		/// Return the state of the form (expanded or not)
		/// </summary>
		public bool IsExpanded
		{
			get
			{
				return _bExpand;
			}
		}
		/// <summary>
		/// Direction of sliding
		/// </summary>
		public SLIDE_DIRECTION SlideDirection
		{
			set
			{
				_eSlideDirection = value;
			}
		}
		/// <summary>
		/// Slide step of the motion
		/// </summary>
		public float SlideStep
		{
			set
			{
				_fStep = value;
			}
		}
		/// <summary>
		/// Default constructor
		/// </summary>
		public SlideDialog() : this(null, 0)
		{
		}
		/// <summary>
		/// Constructor with parent window and step of sliding motion
		/// </summary>
		public SlideDialog(Form poOwner, float pfStep)
		{
			InitializeComponent();
			_oOwner = poOwner;
			_fRatio = 0.0f;
			SlideStep = pfStep;
			if (poOwner != null)
				Owner = poOwner.Owner;
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideDialog));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Background = new System.Windows.Forms.PictureBox();
            this.DriveView = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Background
            // 
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(182, 48);
            this.Background.TabIndex = 13;
            this.Background.TabStop = false;
            // 
            // DriveView
            // 
            this.DriveView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.DriveView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DriveView.FullRowSelect = true;
            this.DriveView.GridLines = true;
            this.DriveView.LargeImageList = this.ImageList;
            this.DriveView.Location = new System.Drawing.Point(2, -2);
            this.DriveView.MultiSelect = false;
            this.DriveView.Name = "DriveView";
            this.DriveView.Size = new System.Drawing.Size(207, 47);
            this.DriveView.SmallImageList = this.ImageList;
            this.DriveView.TabIndex = 14;
            this.DriveView.UseCompatibleStateImageBehavior = false;
            this.DriveView.View = System.Windows.Forms.View.SmallIcon;
            this.DriveView.SelectedIndexChanged += new System.EventHandler(this.DriveView_SelectedIndexChanged);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            // 
            // SlideDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(182, 48);
            this.ControlBox = false;
            this.Controls.Add(this.DriveView);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlideDialog";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		/// <summary>
		/// Use this method to start the slide motion (in ou out) 
		/// according to the slide direction
		/// </summary>
		public void Slide()
		{
			if (!_bExpand)
				Show();
			_oOwner.BringToFront();
			_bExpand = !_bExpand;
			timer1.Start();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (_bExpand)
			{
				_fRatio += _fStep;
				_oOffset += _oStep;
				if (_fRatio >= 1)
					timer1.Stop();
			}
			else
			{
				_fRatio -= _fStep;
				_oOffset -= _oStep;
				if (_fRatio <= 0)
					timer1.Stop();
			}
			SetLocation();
		}
		private void SetLocation()
		{
			Location = _oOrigin + _oOffset.ToSize();
		}

		private void SlideDialog_Move(object sender, System.EventArgs e)
		{
			SetSlideLocation();
			SetLocation();
		}

		private void SlideDialog_Resize(object sender, System.EventArgs e)
		{
			SetSlideLocation();
			SetLocation();
		}
		private void SlideDialog_Closed(object sender, System.EventArgs e)
		{
			Close();
		}

		private void SetSlideLocation()
		{
			if (_oOwner != null)
			{
				_oOrigin = new Point();
				switch (_eSlideDirection)
				{
					case SLIDE_DIRECTION.BOTTOM:
						_oOrigin.X = _oOwner.Location.X+32;
						_oOrigin.Y = (_oOwner.Location.Y + _oOwner.Height - Height);
						//Width = _oOwner.Width;
						_oStep = new SizeF(0, Height * _fStep);
						break;
					case SLIDE_DIRECTION.LEFT:
						_oOrigin = _oOwner.Location;
						_oStep = new SizeF(- Width * _fStep, 0);
						Height = _oOwner.Height;
						//Width = _oOwner.Width;
						break;
					case SLIDE_DIRECTION.TOP:
						_oOrigin = _oOwner.Location;
						//Width = _oOwner.Width;
						_oStep = new SizeF(0, - Height * _fStep);
						break;
					case SLIDE_DIRECTION.RIGHT:
						_oOrigin.X = _oOwner.Location.X + _oOwner.Width - Width;
						_oOrigin.Y = _oOwner.Location.Y;
						_oStep = new SizeF(Width * _fStep, 0);
						Height = _oOwner.Height;
						//Width = _oOwner.Width;
						break;
				}
			}
		}
		protected override void OnLoad(System.EventArgs e)
		{
			SetSlideLocation();
			SetLocation();
			if (_oOwner != null)
			{
				_oOwner.LocationChanged += new System.EventHandler(this.SlideDialog_Move);
				_oOwner.Resize += new System.EventHandler(this.SlideDialog_Resize);
				_oOwner.Closed += new System.EventHandler(this.SlideDialog_Closed);

			}
		}

		public void BindListView( ArrayList Drives )
		{
			foreach(string Drive in Drives)
			{
				this.DriveView.Items.Add(Drive + " CDROM Drive",0);
			}
		}

		private void DriveView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int counter = 0;
			foreach( int item in this.DriveView.SelectedIndices)
			{
				if(counter<=0) this.SelectedValue = item;
				counter++;
			}
		}

	}
}
