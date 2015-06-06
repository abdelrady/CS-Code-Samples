using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace Server
{
   
    public partial class AudioSetting : Form
    {
        private AudioSet Setting;         
        public AudioSetting()
        {
            InitializeComponent();
         
            Setting = new AudioSet();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "+")
            {
                button1.Text = "-";
                this.Size = new System.Drawing.Size(280, 297);
                groupBox2.Visible = true;
                label9.Text = "Littel Options";
            }
            else 
            {
                button1.Text = "+";
                this.Size = new System.Drawing.Size(280, 201);
                groupBox2.Visible = false;
                label9.Text = "Advanced Options";
            }
        }

        private void AudioSetting_Load(object sender, EventArgs e)
        {
          
            try
            {
                LoadPrevSetting();
            }
            catch
            {
                rateC.SelectedIndex = 0;
                bitsC.SelectedIndex = 0;
                channelC.SelectedIndex = 0;
                buffersC.SelectedIndex = 2;
                sizeC.SelectedIndex = 0;
            }
            
        }      

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            ReadFromGUI();
            WriteToFile();
            MessageBox.Show("Setting saved successfully", "Audio Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveBTN.Enabled = false;
        }

        private void WriteToFile()
        {
            Stream stream =File.Open("AData.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            
            formatter.Serialize(stream, Setting);
            stream.Close();

        }

        private void ReadFromGUI()
        {
            Setting = new AudioSet();
            Setting.rate = int.Parse( rateC.Text);
            Setting.bits = int.Parse(bitsC.Text);
            Setting.buffers =int.Parse( buffersC.Text);
            Setting.channels =int.Parse( channelC.Text);
            Setting.size = int.Parse(sizeC.Text);
        }
        private void LoadPrevSetting()
        {
            Setting = null;           
            Stream stream = File.Open("AData.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Setting = (AudioSet)formatter.Deserialize(stream);
            stream.Close();
            SetToGUI();

        }

        private void SetToGUI()
        {
            rateC.Text = Setting.rate.ToString();
            bitsC.Text = Setting.bits.ToString();
            buffersC.Text = Setting.buffers.ToString();
            channelC.Text = Setting.channels.ToString();
            sizeC.Text = Setting.size.ToString(); 
        }

        private void sizeC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveBTN.Enabled = true;
        }

        private void buffersC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveBTN.Enabled = true;
        }

        private void bitsC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveBTN.Enabled = true;
        }

        private void channelC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveBTN.Enabled = true;
        }

        private void rateC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveBTN.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
    [Serializable()]
    class AudioSet
    {
        public  int rate;
        public int bits;
        public int channels;
        public int buffers;
        public int size;
    }
}