using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "This must be stored in a file.";
            // Create file to save the data to
            FileStream fs = new FileStream("SerializedString.txt", FileMode.Create);
            // Create a BinaryFormatter object to perform the serialization
            BinaryFormatter bf = new BinaryFormatter();
            // Use the BinaryFormatter object to serialize the data to the file
            bf.Serialize(fs, data);
            // Close the file
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = "";
            // Create file to save the data to
            FileStream fs = new FileStream("SerializedString.txt", FileMode.Open);
            // Create a BinaryFormatter object to perform the serialization
            BinaryFormatter bf = new BinaryFormatter();
            // Use the BinaryFormatter object to serialize the data to the file
            data=(String)bf.Deserialize(fs);
            // Close the file
            fs.Close();
            MessageBox.Show(data);
        }
    }
}