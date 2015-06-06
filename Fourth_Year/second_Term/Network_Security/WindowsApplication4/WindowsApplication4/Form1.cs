using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
namespace WindowsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              //  this.textBox1.Text = openFileDialog1.FileName;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.textBox2.Text = openFileDialog1.FileName;
                    Rijndael RijndaelAlg = Rijndael.Create();
                    //FileStream fs = new FileStream(this.textBox1.Text, FileMode.Open, FileAccess.Read);
                    CryptoStream cr = new CryptoStream(new FileStream(this.textBox2.Text, FileMode.OpenOrCreate, FileAccess.Write), RijndaelAlg.CreateEncryptor(RijndaelAlg.Key, RijndaelAlg.IV), CryptoStreamMode.Write);

                    // Create a StreamWriter using the CryptoStream.
                    StreamWriter sWriter = new StreamWriter(cr);

                    try
                    {
                        // Write the data to the stream 
                        // to encrypt it.
                        sWriter.WriteLine("Here Is The text To Insert"/*new StreamReader(fs).ReadToEnd()*/);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: {0}", ex.Message);
                    }
                    finally
                    {
                        // Close the streams and
                        // close the file.
                        cr.Close();
                        //fs.Close();
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = openFileDialog1.FileName;
                /*Rijndael RijndaelAlg = Rijndael.Create();
                //FileStream fs = new FileStream(this.textBox2.Text, FileMode.Open, FileAccess.Read);
                FileStream rfs=new FileStream(this.textBox2.Text, FileMode.OpenOrCreate, FileAccess.Read);
                CryptoStream cr = new CryptoStream(rfs, RijndaelAlg.CreateDecryptor(RijndaelAlg.Key, RijndaelAlg.IV), CryptoStreamMode.Read);

                // Create a StreamWriter using the CryptoStream.
                StreamReader sWriter = new StreamReader(cr);
                //cr.Position = 0;
                rfs.Position = 0;
                byte[] arr = new byte[1024];
                rfs.Read(arr, 0, 1024);
                //cr.Read(arr, 0, 1024);
                MessageBox.Show(Encoding.Default.GetString(arr));
                try
                {
                   MessageBox.Show(sWriter.ReadToEnd());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: {0}", ex.Message);
                }
                finally
                {
                    cr.Close();
                }*/
                // Create or open the specified file. 
                FileStream fStream = File.Open(this.textBox2.Text, FileMode.OpenOrCreate);

                // Create a new Rijndael object.
                Rijndael RijndaelAlg = Rijndael.Create();

                // Create a CryptoStream using the FileStream 
                // and the passed key and initialization vector (IV).
                CryptoStream cStream = new CryptoStream(fStream,
                    RijndaelAlg.CreateDecryptor(RijndaelAlg.Key,RijndaelAlg.IV),
                    CryptoStreamMode.Read);

                // Create a StreamReader using the CryptoStream.
                StreamReader sReader = new StreamReader(cStream);

                string val = null;

                try
                {
                    // Read the data from the stream 
                    // to decrypt it.
                    val = sReader.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: {0}", ex.Message);
                }
                finally
                {

                    // Close the streams and
                    // close the file.
                    sReader.Close();
                    cStream.Close();
                    fStream.Close();
                }
                MessageBox.Show(val);

            }
        }
    }
}