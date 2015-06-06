using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;
using System.Collections;

namespace SmartDoor
{
	public class SlideDialog : System.Windows.Forms.Form
	{
		public int SelectedValue = 0;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer SLDTimer;
		protected Form _oOwner;
		public enum SLIDE_DIRECTION {TOP, LEFT, BOTTOM, RIGHT};
		protected SLIDE_DIRECTION _eSlideDirection;
		private float _fRatio; 
		private float _fStep;
		private bool _bExpand;
		private SizeF _oOffset;
        private SizeF _oStep;
		private Point _oOrigin;
        private ArrayList Allowed_Students;
        private string mbarCode;
        private Network.Client.Client  mClient;
        ChatClient.Forms.AuthorizationFrm Warnning_Form;
        TextBox TxtBx;
       
        private bool elabsed = false;
     
     
        private Button CMD_One;
        private Button CMD_Three;
        private Button CMD_Two;
        private Button CMD_Five;
        private Button CMD_Four;
        private Button CMD_Six;
        private Button CMD_nine;
        private Button CMD_Seven;
        private Button CMD_Send;
        private Button CMD_Zero;
        private Button CMD_eight;      

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
		
        public SlideDialog(Form poOwner, float pfStep,Network.Client.Client _Client,ArrayList Al,TextBox T)
		{
			InitializeComponent();
            mClient = _Client;
            Allowed_Students = Al;
            if (elabsed) return;           
            elabsed = true;
			_oOwner = poOwner;
			_fRatio = 0.0f;
			SlideStep = pfStep;
			if (poOwner != null)
				Owner = poOwner.Owner;
            TxtBx = T;
            TxtBx.Text = "";

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
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.SLDTimer = new System.Windows.Forms.Timer(this.components);
            this.CMD_One = new System.Windows.Forms.Button();
            this.CMD_Three = new System.Windows.Forms.Button();
            this.CMD_Two = new System.Windows.Forms.Button();
            this.CMD_Five = new System.Windows.Forms.Button();
            this.CMD_Four = new System.Windows.Forms.Button();
            this.CMD_Six = new System.Windows.Forms.Button();
            this.CMD_nine = new System.Windows.Forms.Button();
            this.CMD_Seven = new System.Windows.Forms.Button();
            this.CMD_eight = new System.Windows.Forms.Button();
            this.CMD_Send = new System.Windows.Forms.Button();
            this.CMD_Zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SLDTimer
            // 
            this.SLDTimer.Interval = 5;
            this.SLDTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CMD_One
            // 
            this.CMD_One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_One.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_One.Location = new System.Drawing.Point(0, 0);
            this.CMD_One.Name = "CMD_One";
            this.CMD_One.Size = new System.Drawing.Size(42, 35);
            this.CMD_One.TabIndex = 0;
            this.CMD_One.Text = "1";
            this.CMD_One.UseVisualStyleBackColor = true;
            this.CMD_One.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_Three
            // 
            this.CMD_Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Three.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Three.Location = new System.Drawing.Point(82, 0);
            this.CMD_Three.Name = "CMD_Three";
            this.CMD_Three.Size = new System.Drawing.Size(42, 35);
            this.CMD_Three.TabIndex = 2;
            this.CMD_Three.Text = "3";
            this.CMD_Three.UseVisualStyleBackColor = true;
            this.CMD_Three.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_Two
            // 
            this.CMD_Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Two.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Two.Location = new System.Drawing.Point(41, 0);
            this.CMD_Two.Name = "CMD_Two";
            this.CMD_Two.Size = new System.Drawing.Size(42, 35);
            this.CMD_Two.TabIndex = 1;
            this.CMD_Two.Text = "2";
            this.CMD_Two.UseVisualStyleBackColor = true;
            this.CMD_Two.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_Five
            // 
            this.CMD_Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Five.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Five.Location = new System.Drawing.Point(41, 34);
            this.CMD_Five.Name = "CMD_Five";
            this.CMD_Five.Size = new System.Drawing.Size(42, 35);
            this.CMD_Five.TabIndex = 4;
            this.CMD_Five.Text = "5";
            this.CMD_Five.UseVisualStyleBackColor = true;
            this.CMD_Five.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_Four
            // 
            this.CMD_Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Four.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Four.Location = new System.Drawing.Point(0, 34);
            this.CMD_Four.Name = "CMD_Four";
            this.CMD_Four.Size = new System.Drawing.Size(42, 35);
            this.CMD_Four.TabIndex = 3;
            this.CMD_Four.Text = "4";
            this.CMD_Four.UseVisualStyleBackColor = true;
            this.CMD_Four.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_Six
            // 
            this.CMD_Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Six.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Six.Location = new System.Drawing.Point(82, 34);
            this.CMD_Six.Name = "CMD_Six";
            this.CMD_Six.Size = new System.Drawing.Size(42, 35);
            this.CMD_Six.TabIndex = 5;
            this.CMD_Six.Text = "6";
            this.CMD_Six.UseVisualStyleBackColor = true;
            this.CMD_Six.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_nine
            // 
            this.CMD_nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_nine.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_nine.Location = new System.Drawing.Point(82, 68);
            this.CMD_nine.Name = "CMD_nine";
            this.CMD_nine.Size = new System.Drawing.Size(42, 35);
            this.CMD_nine.TabIndex = 8;
            this.CMD_nine.Text = "9";
            this.CMD_nine.UseVisualStyleBackColor = true;
            this.CMD_nine.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_Seven
            // 
            this.CMD_Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Seven.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Seven.Location = new System.Drawing.Point(0, 68);
            this.CMD_Seven.Name = "CMD_Seven";
            this.CMD_Seven.Size = new System.Drawing.Size(42, 35);
            this.CMD_Seven.TabIndex = 6;
            this.CMD_Seven.Text = "7";
            this.CMD_Seven.UseVisualStyleBackColor = true;
            this.CMD_Seven.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_eight
            // 
            this.CMD_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_eight.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_eight.Location = new System.Drawing.Point(41, 68);
            this.CMD_eight.Name = "CMD_eight";
            this.CMD_eight.Size = new System.Drawing.Size(42, 35);
            this.CMD_eight.TabIndex = 7;
            this.CMD_eight.Text = "8";
            this.CMD_eight.UseVisualStyleBackColor = true;
            this.CMD_eight.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // CMD_Send
            // 
            this.CMD_Send.BackColor = System.Drawing.SystemColors.Control;
            this.CMD_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Send.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CMD_Send.Location = new System.Drawing.Point(41, 102);
            this.CMD_Send.Name = "CMD_Send";
            this.CMD_Send.Size = new System.Drawing.Size(83, 34);
            this.CMD_Send.TabIndex = 9;
            this.CMD_Send.UseVisualStyleBackColor = false;
            this.CMD_Send.Click += new System.EventHandler(this.CMD_Send_Click);
            // 
            // CMD_Zero
            // 
            this.CMD_Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Zero.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Zero.Location = new System.Drawing.Point(0, 102);
            this.CMD_Zero.Name = "CMD_Zero";
            this.CMD_Zero.Size = new System.Drawing.Size(42, 34);
            this.CMD_Zero.TabIndex = 10;
            this.CMD_Zero.Text = "0";
            this.CMD_Zero.UseVisualStyleBackColor = true;
            this.CMD_Zero.Click += new System.EventHandler(this.CMD_nine_Click);
            // 
            // SlideDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(124, 137);
            this.ControlBox = false;
            this.Controls.Add(this.CMD_Zero);
            this.Controls.Add(this.CMD_Send);
            this.Controls.Add(this.CMD_nine);
            this.Controls.Add(this.CMD_Seven);
            this.Controls.Add(this.CMD_eight);
            this.Controls.Add(this.CMD_Six);
            this.Controls.Add(this.CMD_Four);
            this.Controls.Add(this.CMD_Five);
            this.Controls.Add(this.CMD_Two);
            this.Controls.Add(this.CMD_Three);
            this.Controls.Add(this.CMD_One);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlideDialog";
            this.ShowInTaskbar = false;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SlideDialog_Paint);
            this.ResumeLayout(false);

		}
		#endregion	
	
		public void Slide()
		{
           
			if (!_bExpand)
				Show();
			_oOwner.BringToFront();
          

			_bExpand = !_bExpand;
			SLDTimer.Start();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (_bExpand)
			{
				_fRatio += _fStep;
				_oOffset += _oStep;
				if (_fRatio >= 1)
					SLDTimer.Stop();
			}
			else
			{
				_fRatio -= _fStep;
				_oOffset -= _oStep;
				if (_fRatio <= 0)
					SLDTimer.Stop();
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

        private void picture_comming_Click(object sender, EventArgs e)
        {
            this.Slide();
        }

        private void SlideDialog_Paint(object sender, PaintEventArgs e)
        {
            ClientFrm.Paint_Gradiant(e,(Form)this);
        }
        public void Turn_Warnning()
        {
            Warnning_Form = new ChatClient.Forms.AuthorizationFrm("You Are not Authorized!");
            Warnning_Form.Times = 2;/*beep twice only do not make bollika*/
            Warnning_Form.ShowDialog(_oOwner);
        }
        private void CMD_Send_Click(object sender, EventArgs e)
        {
            Slide();           
            try
            {
                /*
                 * Sending Barcode and door number for logging 
                 */
                if (mClient != null )
                {
                    if(mbarCode.Trim()!="") 
                    mClient.SendMessage("[#<CMD>#][#Barcode#][#]" + mbarCode + "[#]" + Configuration.ClientName + "[#]" + Configuration.ClientId + "[#]");
                    //inputTextBox.Clear();
                }
                else
                {
                    if (Allowed_Students.BinarySearch(mbarCode) < 0)
                    // Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning...Beep beep Warning , . . .
                    {
                        new Thread(new ThreadStart(Turn_Warnning)).Start();
                    }
                    else
                    {
                        /**************************************************/
                        /*               OPEN THE DOOR                    */
                        /*              OPEN  THE  DOOR                   */
                        /**************************************************/
                        MessageBox.Show("Allowed");
                    }
                    //inputTextBox.Clear();                 
                }

            }
            catch (SocketException)
            {

                MessageBox.Show(this, "Error sending barcode [" + mbarCode + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void CMD_nine_Click(object sender, EventArgs e)
        {
            mbarCode+=(sender as Button).Text;
            TxtBx.Text = mbarCode;
        }              

	}
}
