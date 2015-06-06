using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for TextArea.
	/// </summary>
	public class TextArea : System.Windows.Forms.Form
	{
		public System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TextArea()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.AcceptsTab = true;
			this.richTextBox1.AllowDrop = true;
			this.richTextBox1.AutoSize = true;
			this.richTextBox1.AutoWordSelection = true;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.richTextBox1.HideSelection = false;
			this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(648, 494);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.ZoomFactor = 1.199854F;
			// 
			// TextArea
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 494);
			this.Controls.Add(this.richTextBox1);
			this.Name = "TextArea";
			this.Text = "Document";
			this.ResumeLayout(false);

		}
		#endregion

		public HorizontalAlignment LeftAlignment()
		{
			richTextBox1.SelectionAlignment=HorizontalAlignment.Left;
			return richTextBox1.SelectionAlignment;
		}

		public HorizontalAlignment RightAlignment()
		{
			richTextBox1.SelectionAlignment=HorizontalAlignment.Right;
			return richTextBox1.SelectionAlignment;
		}

		public HorizontalAlignment CenterAlignment()
		{
			richTextBox1.SelectionAlignment=HorizontalAlignment.Center;
			return richTextBox1.SelectionAlignment;
		}

		public void UndoCmd()
		{
		   richTextBox1.Undo();
		}

		public void RedoCmd()
		{
            richTextBox1.Redo();
		}

		public void TextColor (Color a)
		{
           richTextBox1.SelectionColor=a;
		}

		public void FontChange(Font fo)
		{
           richTextBox1.SelectionFont=fo;
		}
	}
}
