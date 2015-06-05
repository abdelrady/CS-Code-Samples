using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Telnet_Client_win32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient Client;
        StreamReader sr;
        StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Client = new TcpClient(this.textBox1.Text, int.Parse(this.textBox2.Text));
                sr = new StreamReader(Client.GetStream());
                sw = new StreamWriter(Client.GetStream());
                new Thread(new ThreadStart(OnRecieve)).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured: " + ex.Message);
                return;
            }
            this.toolStripStatusLabel1.Text = "Status Connected.";

        }
        private void OnRecieve()
        {
            while (true)
            {
                try
                {
                    string Data = sr.ReadToEnd();
                    //if (Data.Length != 0)
                    {
                        this.toolStripStatusLabel1.Text = "Status: Data Recieved " + Data.Length + " Bytes.";
                        this.textBox5.Text += Data;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured: " +ex.Message);
                    return;
                }
                Thread.Sleep(1000);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //byte[] data = Encoding.Default.GetBytes(this.textBox3.Text);
            sw.Write(this.textBox3.Text);//data, 0, data.Length);
            sw.Flush();
            this.toolStripStatusLabel1.Text = "Status: Data Sent " + this.textBox3.Text.Length + " Bytes.";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}