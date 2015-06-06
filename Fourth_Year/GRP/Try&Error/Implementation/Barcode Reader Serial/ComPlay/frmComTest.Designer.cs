namespace ComPlay
{
	partial class frmComTest
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.CardReader = new System.IO.Ports.SerialPort(this.components);
            this.txtData = new System.Windows.Forms.TextBox();
            this.butListen = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.txtToSend = new System.Windows.Forms.TextBox();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.butSendFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.butSetFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRandomFolder = new System.Windows.Forms.TextBox();
            this.butSendRandom = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.timerRandomSendFile = new System.Windows.Forms.Timer(this.components);
            this.txtMinimumWaitBeforeSend = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxWait = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSending = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butEnumerateComPorts = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSending.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardReader
            // 
            this.CardReader.StopBits = System.IO.Ports.StopBits.Two;
            this.CardReader.WriteBufferSize = 8000;
            this.CardReader.WriteTimeout = 10000;
            this.CardReader.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(4, 393);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(358, 56);
            this.txtData.TabIndex = 0;
            // 
            // butListen
            // 
            this.butListen.Location = new System.Drawing.Point(8, 14);
            this.butListen.Name = "butListen";
            this.butListen.Size = new System.Drawing.Size(133, 26);
            this.butListen.TabIndex = 3;
            this.butListen.Text = "Connect Now";
            this.butListen.UseVisualStyleBackColor = true;
            this.butListen.Click += new System.EventHandler(this.butListen_Click);
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(246, 19);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 4;
            this.butSend.Text = "Send Text";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // txtToSend
            // 
            this.txtToSend.Location = new System.Drawing.Point(19, 19);
            this.txtToSend.Multiline = true;
            this.txtToSend.Name = "txtToSend";
            this.txtToSend.Size = new System.Drawing.Size(221, 23);
            this.txtToSend.TabIndex = 5;
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(87, 19);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(153, 20);
            this.txtfile.TabIndex = 6;
            // 
            // butSendFile
            // 
            this.butSendFile.Location = new System.Drawing.Point(246, 19);
            this.butSendFile.Name = "butSendFile";
            this.butSendFile.Size = new System.Drawing.Size(75, 23);
            this.butSendFile.TabIndex = 7;
            this.butSendFile.Text = "Send File";
            this.butSendFile.UseVisualStyleBackColor = true;
            this.butSendFile.Click += new System.EventHandler(this.butSendFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // butSetFile
            // 
            this.butSetFile.Location = new System.Drawing.Point(19, 17);
            this.butSetFile.Name = "butSetFile";
            this.butSetFile.Size = new System.Drawing.Size(62, 23);
            this.butSetFile.TabIndex = 8;
            this.butSetFile.Text = "Set File";
            this.butSetFile.UseVisualStyleBackColor = true;
            this.butSetFile.Click += new System.EventHandler(this.butSetFile_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(4, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save Incoming data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Set Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRandomFolder
            // 
            this.txtRandomFolder.Location = new System.Drawing.Point(161, 31);
            this.txtRandomFolder.Name = "txtRandomFolder";
            this.txtRandomFolder.Size = new System.Drawing.Size(171, 20);
            this.txtRandomFolder.TabIndex = 12;
            // 
            // butSendRandom
            // 
            this.butSendRandom.Location = new System.Drawing.Point(99, 123);
            this.butSendRandom.Name = "butSendRandom";
            this.butSendRandom.Size = new System.Drawing.Size(111, 23);
            this.butSendRandom.TabIndex = 13;
            this.butSendRandom.Text = "Send Random Files";
            this.butSendRandom.UseVisualStyleBackColor = true;
            this.butSendRandom.Click += new System.EventHandler(this.butSendRandom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Card ID\r\n";
            // 
            // timerRandomSendFile
            // 
            this.timerRandomSendFile.Tick += new System.EventHandler(this.timerRandomSendFile_Tick);
            // 
            // txtMinimumWaitBeforeSend
            // 
            this.txtMinimumWaitBeforeSend.Location = new System.Drawing.Point(163, 61);
            this.txtMinimumWaitBeforeSend.Name = "txtMinimumWaitBeforeSend";
            this.txtMinimumWaitBeforeSend.Size = new System.Drawing.Size(94, 20);
            this.txtMinimumWaitBeforeSend.TabIndex = 15;
            this.txtMinimumWaitBeforeSend.Text = "1000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaxWait);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.butSendRandom);
            this.groupBox1.Controls.Add(this.txtMinimumWaitBeforeSend);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtRandomFolder);
            this.groupBox1.Location = new System.Drawing.Point(8, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 186);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Sending Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Max wait ( Milliseconds )";
            // 
            // txtMaxWait
            // 
            this.txtMaxWait.Location = new System.Drawing.Point(163, 87);
            this.txtMaxWait.Name = "txtMaxWait";
            this.txtMaxWait.Size = new System.Drawing.Size(94, 20);
            this.txtMaxWait.TabIndex = 17;
            this.txtMaxWait.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Min wait ( Milliseconds )";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSending);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 370);
            this.tabControl1.TabIndex = 17;
            // 
            // tabSending
            // 
            this.tabSending.Controls.Add(this.groupBox3);
            this.tabSending.Controls.Add(this.groupBox2);
            this.tabSending.Controls.Add(this.groupBox1);
            this.tabSending.Location = new System.Drawing.Point(4, 22);
            this.tabSending.Name = "tabSending";
            this.tabSending.Padding = new System.Windows.Forms.Padding(3);
            this.tabSending.Size = new System.Drawing.Size(358, 344);
            this.tabSending.TabIndex = 0;
            this.tabSending.Text = "Sending";
            this.tabSending.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butSend);
            this.groupBox3.Controls.Add(this.txtToSend);
            this.groupBox3.Location = new System.Drawing.Point(9, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 68);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtfile);
            this.groupBox2.Controls.Add(this.butSendFile);
            this.groupBox2.Controls.Add(this.butSetFile);
            this.groupBox2.Location = new System.Drawing.Point(8, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 62);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send File";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butEnumerateComPorts);
            this.tabPage2.Controls.Add(this.propertyGrid1);
            this.tabPage2.Controls.Add(this.butListen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // butEnumerateComPorts
            // 
            this.butEnumerateComPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEnumerateComPorts.Location = new System.Drawing.Point(8, 41);
            this.butEnumerateComPorts.Name = "butEnumerateComPorts";
            this.butEnumerateComPorts.Size = new System.Drawing.Size(133, 26);
            this.butEnumerateComPorts.TabIndex = 18;
            this.butEnumerateComPorts.Text = "Enumerate Ports";
            this.butEnumerateComPorts.UseVisualStyleBackColor = true;
            this.butEnumerateComPorts.Click += new System.EventHandler(this.butEnumerateComPorts_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 73);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(352, 268);
            this.propertyGrid1.TabIndex = 4;
            // 
            // frmComTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 486);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmComTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSending.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort CardReader;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Button butListen;
		private System.Windows.Forms.Button butSend;
		private System.Windows.Forms.TextBox txtToSend;
		private System.Windows.Forms.TextBox txtfile;
		private System.Windows.Forms.Button butSendFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button butSetFile;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtRandomFolder;
		private System.Windows.Forms.Button butSendRandom;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timerRandomSendFile;
		private System.Windows.Forms.TextBox txtMinimumWaitBeforeSend;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMaxWait;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSending;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button butEnumerateComPorts;
	}
}

