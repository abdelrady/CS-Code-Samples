using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComPlay
{
	public partial class frmComTest : Form
	{
		public frmComTest()
		{
			InitializeComponent();
		}

		// This delegate enables asynchronous calls for setting
		// the text property on a TextBox control.
		delegate void SetTextCallback(string text);


		private void butListen_Click(object sender, EventArgs e)
		{
			try
			{
				this.CardReader.Close();
				this.CardReader.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.ToString () );
				return;
			}
			MessageBox.Show( "COM port opened and successfully.");

		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			SetText(this.CardReader.ReadExisting());
		}

		private void SetText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.txtData.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.txtData.Text += text;
			}
		}

		private void butSend_Click(object sender, EventArgs e)
		{
			if (CardReader.IsOpen == false)
			{
				this.CardReader.Open();
			}
			CardReader.Write(this.txtToSend.Text);
			
		}

		private void butSendFile_Click(object sender, EventArgs e)
		{
			if (CardReader.IsOpen == false)
			{
				this.CardReader.Open();
			}
		   CardReader.Write(System.IO.File.ReadAllText(this.txtfile.Text));
		}

		private void butSetFile_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.ShowDialog();

			this.txtfile.Text = this.openFileDialog1.FileName;
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(this.saveFileDialog1.ShowDialog()== DialogResult.OK)
			System.IO.File.WriteAllText(this.saveFileDialog1.FileName, this.txtData.Text);
		}

		
		private void butSendRandom_Click(object sender, EventArgs e)
		{
			this.timerRandomSendFile.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.ShowDialog();
			this.txtRandomFolder.Text = this.folderBrowserDialog1.SelectedPath;
		}

		private void timerRandomSendFile_Tick(object sender, EventArgs e)
		{
			this.timerRandomSendFile.Stop();

			String[] Filenames = System.IO.Directory.GetFiles(this.txtRandomFolder.Text);
			if (Filenames.Length == 0)
			{
				return;
			}

			Random rand = new Random();

			if (CardReader.IsOpen == false)
			{
				this.CardReader.Open();
			}

			CardReader.Write(System.IO.File.ReadAllText(Filenames[rand.Next( Filenames.Length )]));

		   Random randTimer = new Random();

			timerRandomSendFile.Interval = randTimer.Next( Int32.Parse( this.txtMinimumWaitBeforeSend.Text ), Int32.Parse( this.txtMaxWait.Text ));
			
			this.timerRandomSendFile.Start();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.propertyGrid1.SelectedObject = this.CardReader;
		}

		private void butEnumerateComPorts_Click(object sender, EventArgs e)
		{

			MessageBox.Show(String.Join(",", System.IO.Ports.SerialPort.GetPortNames() ) + " are found on your machine."  );

		}
	}
}