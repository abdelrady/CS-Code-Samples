using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DSBarCode
{
	public class BarCodeCtrl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.ComponentModel.Container components = null;

		public enum AlignType
		{
			Left, Center, Right
		}

		public enum BarCodeWeight
		{
			Small = 1, Medium, Large
		}

		private AlignType align = AlignType.Center;
		private String code = "1234567890";
		private int leftMargin = 10;
		private int topMargin = 10;
		private int height = 50;
		private bool showHeader;
		private bool showFooter;
		private String headerText = "BarCode Demo";
		private BarCodeWeight weight = BarCodeWeight.Small;
		private Font headerFont = new Font("Courier", 18);
		private Font footerFont = new Font("Courier", 8);
		

		public AlignType VertAlign
		{
			get { return align; }
			set { align = value; panel1.Invalidate(); }
		}

		public String BarCode
		{
			get { return code; }
			set { code = value.ToUpper(); panel1.Invalidate(); }
		}

		public int BarCodeHeight
		{
			get { return height; }
			set { height = value; panel1.Invalidate(); }
		}

		public int LeftMargin
		{
			get { return leftMargin; }
			set { leftMargin = value; panel1.Invalidate(); }
		}

		public int TopMargin
		{
			get { return topMargin; }
			set { topMargin = value; panel1.Invalidate(); }
		}

		public bool ShowHeader
		{
			get { return showHeader; }
			set { showHeader = value; panel1.Invalidate(); }
		}

		public bool ShowFooter
		{
			get { return showFooter; }
			set { showFooter = value; panel1.Invalidate(); }
		}

		public String HeaderText
		{
			get { return headerText; }
			set { headerText = value; panel1.Invalidate(); }
		}

		public BarCodeWeight Weight
		{
			get { return weight; }
			set { weight = value; panel1.Invalidate(); }
		}

		public Font HeaderFont
		{
			get { return headerFont; }
			set { headerFont = value; panel1.Invalidate(); }
		}

		public Font FooterFont
		{
			get { return footerFont; }
			set { footerFont = value; panel1.Invalidate(); }
		}

		public BarCodeCtrl()
		{
			InitializeComponent();
		}

		public void Print()
		{
			PrintDialog pd = new PrintDialog();
			pd.Document = printDocument1;

			if (pd.ShowDialog() == DialogResult.OK)
			{
				pd.Document.Print();
			}
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(424, 240);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// BarCodeCtrl
			// 
			this.Controls.Add(this.panel1);
			this.Name = "BarCodeCtrl";
			this.Size = new System.Drawing.Size(424, 240);
			this.Resize += new System.EventHandler(this.BarCodeCtrl_Resize);
			this.ResumeLayout(false);

		}
		#endregion

		String alphabet39="0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%*";

		String [] coded39Char = 
		{
			/* 0 */ "000110100", 			/* 1 */ "100100001", 			/* 2 */ "001100001", 			/* 3 */ "101100000",			/* 4 */ "000110001", 			/* 5 */ "100110000", 			/* 6 */ "001110000", 			/* 7 */ "000100101",			/* 8 */ "100100100", 			/* 9 */ "001100100", 			/* A */ "100001001", 			/* B */ "001001001",			/* C */ "101001000", 			/* D */ "000011001", 			/* E */ "100011000", 			/* F */ "001011000",			/* G */ "000001101", 			/* H */ "100001100", 			/* I */ "001001100", 			/* J */ "000011100",			/* K */ "100000011", 			/* L */ "001000011", 			/* M */ "101000010", 			/* N */ "000010011",			/* O */ "100010010", 			/* P */ "001010010", 			/* Q */ "000000111", 			/* R */ "100000110",			/* S */ "001000110", 			/* T */ "000010110", 			/* U */ "110000001", 			/* V */ "011000001",			/* W */ "111000000", 			/* X */ "010010001", 			/* Y */ "110010000", 			/* Z */ "011010000",			/* - */ "010000101", 			/* . */ "110000100", 			/*' '*/ "011000100",			/* $ */ "010101000",			/* / */ "010100010", 
			/* + */ "010001010", 
			/* % */ "000101010", 
			/* * */ "010010100" 
		};

		

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			String intercharacterGap="0";
			String str = '*'+code.ToUpper()+'*';
			int strLength=str.Length;
			for ( int i=0;i<code.Length ;i++ ) 
			{
				if (alphabet39.IndexOf(code[i])==-1 || code[i] == '*')
				{
					e.Graphics.DrawString("INVALID BAR CODE TEXT", Font, Brushes.Red, 10, 10);
					return;
				}
			}
			String encodedString="";
			for ( int i=0;i<strLength;i++ ) 
			{
				if (i>0) 
					encodedString+=intercharacterGap;
					
				encodedString+=coded39Char[alphabet39.IndexOf(str[i])];
			}
			int encodedStringLength = encodedString.Length;
			int widthOfBarCodeString = 0;
			double wideToNarrowRatio=3;
			
			
			if (align != AlignType.Left)
			{
				for ( int i=0;i<encodedStringLength; i++)
				{
					if ( encodedString[i]=='1' ) 
						widthOfBarCodeString+=(int)(wideToNarrowRatio*(int)weight);
					else 						widthOfBarCodeString+=(int)weight;
				}
			}

			int x = 0;
			int wid=0;
			int yTop = 0;
			SizeF hSize = e.Graphics.MeasureString(headerText, headerFont);
			SizeF fSize = e.Graphics.MeasureString(code, footerFont);

			int headerX = 0;
			int footerX = 0;

			if (align == AlignType.Left)
			{
				x = leftMargin;
				headerX = leftMargin;
				footerX = leftMargin;
			}
			else if (align == AlignType.Center)
			{
				x = (Width - widthOfBarCodeString) / 2;
				headerX = (Width - (int)hSize.Width) / 2;
				footerX = (Width - (int)fSize.Width) / 2;
			}
			else
			{
				x = Width - widthOfBarCodeString - leftMargin;
				headerX = Width - (int)hSize.Width - leftMargin;
				footerX = Width - (int)fSize.Width - leftMargin;
			}

			if (showHeader)
			{
				yTop = (int)hSize.Height + topMargin;
				e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX, topMargin);
			}
			else
			{
				yTop = topMargin;
			}

			for ( int i=0;i<encodedStringLength; i++)
			{
				if ( encodedString[i]=='1' ) 
					wid=(int)(wideToNarrowRatio*(int)weight);
				else 					wid=(int)weight;
				e.Graphics.FillRectangle(i%2==0? Brushes.Black : Brushes.White, x, yTop, wid, height);
				
				x+=wid;
			}

			yTop += height;

			if (showFooter)
				e.Graphics.DrawString(code, footerFont, Brushes.Black, footerX, yTop);
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			panel1_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));
		}

		public void SaveImage(String file)
		{
			Bitmap bmp = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

			Graphics g = Graphics.FromImage(bmp);
			g.FillRectangle(Brushes.White, 0, 0, Width, Height);

			panel1_Paint(null, new PaintEventArgs(g, this.ClientRectangle));

			bmp.Save(file);
		}

		private void BarCodeCtrl_Resize(object sender, System.EventArgs e)
		{
			panel1.Invalidate();
		}
	}
}
