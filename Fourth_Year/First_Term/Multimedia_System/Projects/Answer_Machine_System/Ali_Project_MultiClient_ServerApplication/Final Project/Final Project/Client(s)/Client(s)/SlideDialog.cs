using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;

namespace Client_s_
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
		private System.Windows.Forms.ImageList ImageList;
        private PictureBox RemoteView;
		private Point _oOrigin;

        private Thread myth;
        private TcpListener mytcpl;
        private Socket mysocket;
        private NetworkStream ns;
        private bool elabsed = false;
        private int RCVportNumber;
        private const short WM_CAP = 1024;
        private const int WM_CAP_EDIT_COPY = WM_CAP + 30;
        [DllImport("user32", EntryPoint = "SendMessageA")]
        static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] 
			object lParam);

		public bool IsExpanded
		{
			get
			{
				return _bExpand;
			}
		}		
		public SLIDE_DIRECTION SlideDirection
		{
			set
			{
				_eSlideDirection = value;
			}
		}		
		public float SlideStep
		{
			set
			{
				_fStep = value;
			}
		}		
		public SlideDialog() : this(null, 0,0)
		{
		}
        public SlideDialog(Form poOwner, float pfStep, int RCV)
		{
			InitializeComponent();        

            RCVportNumber = RCV;

            if (elabsed) return;
           
            elabsed = true;

			_oOwner = poOwner;
			_fRatio = 0.0f;
			SlideStep = pfStep;
			if (poOwner != null)
				Owner = poOwner.Owner;

            myth = new Thread(new ThreadStart(Start_Receiving_Video_Conference));
            myth.Start();
		}     
        private void Start_Receiving_Video_Conference()
        {

            try
            {
                // Open The Port
                mytcpl = new TcpListener(RCVportNumber);
                mytcpl.Start();						 // Start Listening on That Port
                mysocket = mytcpl.AcceptSocket();		 // Accept Any Request From Client and Start a Session
                ns = new NetworkStream(mysocket);	 // Receives The Binary Data From Port

                RemoteView.Image = Image.FromStream(ns);
                mytcpl.Stop();				 // Close TCP Session
                Start_Receiving_Video_Conference();             // Back to First Method
                ns.Flush();
            }
            catch (Exception d) { MessageBox.Show(d.ToString() + " Error Receiving Frame"); myth.Abort(); }

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
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.RemoteView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteView)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            // 
            // RemoteView
            // 
            this.RemoteView.BackColor = System.Drawing.Color.White;
            this.RemoteView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RemoteView.Location = new System.Drawing.Point(5, 5);
            this.RemoteView.Name = "RemoteView";
            this.RemoteView.Size = new System.Drawing.Size(195, 155);
            this.RemoteView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoteView.TabIndex = 0;
            this.RemoteView.TabStop = false;
            this.RemoteView.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SlideDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(215, 165);
            this.ControlBox = false;
            this.Controls.Add(this.RemoteView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlideDialog";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.RemoteView)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion		
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
						//Height = _oOwner.Height;
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
						//Height = _oOwner.Height;
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Slide();
        }          

	}
}
