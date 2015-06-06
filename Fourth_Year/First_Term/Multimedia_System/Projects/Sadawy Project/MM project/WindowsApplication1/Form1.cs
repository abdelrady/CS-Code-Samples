using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Diagnostics;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private SoundPlayer asd = new SoundPlayer();
        public Form1()
        {
           
            InitializeComponent();
        }    


        private void button1_Click(object sender, EventArgs e)
        {
            
                  int i;
                  for (i = 0; i < textBox1.Text.Length; i++)
                  {              
                   
                      switch (textBox1.Text[i].ToString())
                      {
                          case "Ç":
                              playSound(Directory.GetCurrentDirectory() + "\\"+"Ç.wav");
                              break;
                          case "È":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "È.wav");
                              break;
                          case "Ê":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ê.wav");
                              break;
                          case "Ë":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ë.wav");
                              break;
                          case "Ì":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ì.wav");
                              break;
                          case "Í":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Í.wav");
                              break;
                          case "Î":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Î.wav");
                              break;
                          case "Ï":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ï.wav");
                              break;
                          case "Ð":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ð.wav");
                              break;
                          case "Ñ":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ñ.wav");
                              break;
                          case "Ò":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ò.wav");
                              break;
                          case "Ó":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ó.wav");
                              break;
                          case "Ô":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ô.wav");
                              break;
                          case "Õ":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Õ.wav");
                              break;
                          case "Ö":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ö.wav");
                              break;
                          case "Ø":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ø.wav");
                              break;
                          case "Ù":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ù.wav");
                              break;
                          case "Ú":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ú.wav");
                              break;
                          case "Û":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Û.wav");
                              break;
                          case "Ý":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Ý.wav");
                              break;
                          case "Þ":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "Þ.wav");
                              break;
                          case "ß":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "ß.wav");
                              break;
                          case "á":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "á.wav");
                              break;
                          case "ã":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "ã.wav");
                              break;
                          case "ä":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "ä.wav");
                              break;
                          case "å":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "å.wav");
                              break;
                          case "æ":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "æ.wav");
                              break;
                          case "ì":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "ì.wav");
                              break;
                          case " ":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "space.wav");
                              break;
                          case "0":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "0.wav");
                              break;
                          case "1":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "1.wav");
                              break;
                          case "2":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "2.wav");
                              break;
                          case "3":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "3.wav");
                              break;
                          case "4":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "4.wav");
                              break;
                          case "5":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "5.wav");
                              break;
                          case "6":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "6.wav");
                              break;
                          case "7":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "7.wav");
                              break;
                          case "8":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "8.wav");
                              break;
                          case "9":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "9.wav");
                              break;
                               

                              }

                      
                  }
    }

        private void playSound(string p)
        {
            asd.SoundLocation = p;
            asd.LoadAsync();
            asd.PlaySync();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           //playSound( Directory.GetCurrentDirectory() + "\\about.wav");
            MessageBox.Show("Simple Text Editor Program :SADAWY KAMEL SADAWY", "About", MessageBoxButtons.OK,               MessageBoxIcon.Information);
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("TextWithVoice.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Text Editor Program :SADAWY KAMEL SADAWY", "About", MessageBoxButtons.OK,             MessageBoxIcon.Information);

        }
    }
}