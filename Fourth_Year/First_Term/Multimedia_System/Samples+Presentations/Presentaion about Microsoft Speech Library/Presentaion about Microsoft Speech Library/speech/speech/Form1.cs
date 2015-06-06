using System;
using System.Windows.Forms;
using System.Threading;
using SpeechLib;

namespace speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("No Text For Read Please Enter A Text", "TEXT ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Cursor = Cursors.WaitCursor;

                SpeechVoiceSpeakFlags SpFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;

                SpVoice Voice = new SpVoice();

                Voice.Voice = Voice.GetVoices("name=" + comboBox1.Text, "language = 409").Item(0);

                Voice.Speak(textBox1.Text, SpFlags);

                Voice.WaitUntilDone(Timeout.Infinite);

                this.Cursor = Cursors.Arrow;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}